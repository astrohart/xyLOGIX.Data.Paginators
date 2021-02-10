using System;
using xyLOGIX.Data.Paginators.Events;
using xyLOGIX.Data.Paginators.Interfaces;

namespace xyLOGIX.Data.Paginators
{
   /// <summary>
   /// Object that provides services for accessing paginated data from a data source.
   /// </summary>
   public sealed class Paginator : IPaginator
   {
      /// <summary>
      /// Reference to an instance of an object that serves as a
      /// thread-synchronization root object.
      /// </summary>
      private readonly object SyncRoot = new object();

      /// <summary>
      /// Expression that tells us how to format the URL for each page.
      /// </summary>
      private Func<int, string> _urlExpression;

      /// <summary>
      /// Constructs a new instance of <see
      /// cref="T:CoinMarketCap.Data.Scraper.CoinMarketCapPagination"/> and
      /// returns a reference to it.
      /// </summary>
      public Paginator()
      {
         CurrentPage = 1;
         PageSize = 0;
         TotalEntries = 0;
         _urlExpression = null;
      }

      /// <summary>
      /// Occurs when the current page has been set to a new value.
      /// </summary>
      public event PageChangedEventHandler PageChanged;

      /// <summary>
      /// Gets or sets an integer describing the current page.
      /// </summary>
      /// <remarks>
      /// The value of this property can be changed using the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator.First"/>
      /// , <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator.Prev"/>
      /// , <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator.GoToPage"/>
      /// , <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator.Next"/>
      /// , or <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.Interfaces.IPaginator.Last"/>
      /// methods in a robust, fault-tolerant, and thread-safe manner.
      /// </remarks>
      public int CurrentPage { get; private set; }

      /// <summary>
      /// Gets a value indicating whether the paginator is initialized.
      /// </summary>
      public bool IsInitialized
         => PageSize > 0 && TotalEntries > 0 && TotalPages > 0 &&
            _urlExpression != null;

      /// <summary>
      /// Gets an integer describing the total number of entries on a page.
      /// </summary>
      public int PageSize { get; private set; }

      /// <summary>
      /// Gets a string containing the URL of the current page.
      /// </summary>
      public string PageUrl
      {
         get => OnFormatPageURL(CurrentPage);
      }

      /// <summary>
      /// Gets an integer describing the total number of entries in the entire listing.
      /// </summary>
      public int TotalEntries { get; private set; }

      /// <summary>
      /// Gets an integer describing the total number of pages.
      /// </summary>
      public int TotalPages
         => TotalEntries > 0 && PageSize > 0
            ? (TotalEntries + PageSize + 1) / PageSize
            : 1;

      /// <summary>
      /// Navigates to the first page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      public string First()
         => GoToPage(1);

      /// <summary>
      /// Attempts the paginator to the desired <paramref name="page"/> in a
      /// robust, fault-tolerant, and thread-safe manner.
      /// </summary>
      /// <param name="page">
      /// (Required.) A positive number, in between and including 1 and the
      /// total number of pages, that indicates to which page you wish to navigate.
      /// </param>
      /// <returns>
      /// String containing the URL of the new page, or blank if a problem
      /// occurred. This method will not go beyond the bounds of the current
      /// range of pages.
      /// </returns>
      public string GoToPage(int page)
      {
         lock (SyncRoot)
         {
            var result = string.Empty;

            if (page <= 0 || TotalPages <= 1
            ) // trying to move before the first or only page, stop at first page.
            {
               CurrentPage = 1;
               OnPageChanged(new PageChangedEventArgs(1, TotalPages));
               result = PageUrl;
            }
            else if (page > TotalPages) // trying to move past the end; stop at last page.
            {
               CurrentPage = TotalPages;
               OnPageChanged(new PageChangedEventArgs(TotalPages, TotalPages));
               result = PageUrl;
            }
            else if (CurrentPage == page) // we're already at the desired page.
            {
               OnPageChanged(new PageChangedEventArgs(page, TotalPages));
               result = PageUrl;
            }
            else
            {
               CurrentPage = page; // set CurrentPage to desired value
               OnPageChanged(new PageChangedEventArgs(CurrentPage, TotalPages));
               result = PageUrl; // return resultant page URL
            }

            return result;
         }
      }

      /// <summary>
      /// Called to initialize the values of the paginator parameters.
      /// </summary>
      /// <param name="pageSize">
      /// (Required.) Positive integer specifying the number of entries on a page.
      /// </param>
      /// <param name="totalEntries">
      /// (Required.) Positive integer specifying the total number of entries
      /// across all pages.
      /// </param>
      /// <param name="urlExpression">
      /// (Required.) A <see cref="T:System.Func"/> that takes the current page
      /// number as the parameter and returns a string with the
      /// properly-formatted URL for scraping the Nth page, where N is a number
      /// equal to or greater than 1 and less than or equal to the total number
      /// of pages.
      /// </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// Thrown if either of the <paramref name="pageSize"/> or <paramref
      /// name="totalEntries"/> values are zero or negative. Since these are
      /// page and entry counts, respectively, it is to be assumed that these
      /// will always be positive values.
      /// </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// Thrown if the <paramref name="urlExpression"/> parameter is not initialized.
      /// </exception>
      public void InitializePagination(int pageSize, int totalEntries,
         Func<int, string> urlExpression)
      {
         if (pageSize <= 0)
            throw new ArgumentOutOfRangeException(nameof(pageSize));
         if (totalEntries <= 0)
            throw new ArgumentOutOfRangeException(nameof(totalEntries));

         CurrentPage = 1; // current page always starts at 1
         PageSize = pageSize;
         TotalEntries = totalEntries;
         _urlExpression = urlExpression ??
                          throw new ArgumentNullException(
                             nameof(urlExpression)
                          );
      }

      /// <summary>
      /// Navigates to the last page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      public string Last()
         => GoToPage(TotalPages);

      /// <summary>
      /// Navigates to the next page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      public string Next()
         => GoToPage(++CurrentPage);

      /// <summary>
      /// Navigates to the previous page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:CoinMarketCap.Data.Scraper.Helpers.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      public string Prev()
         => GoToPage(--CurrentPage);

      /// <summary> Invokes the expression, if any, attached to the <see
      /// cref="F:"
      /// CoinMarketCap.Data.Scraper.Interfaces.CoinMarketCapPagination._urlExpression
      /// /> delegate. </summary> <param name="pageNumber"> Page number of the
      /// current page. </param> <returns>String containing the </returns>
      private string OnFormatPageURL(int pageNumber)
         => _urlExpression?.Invoke(pageNumber) ?? null;

      /// <summary>
      /// Raises the <see
      /// cref="E:CoinMarketCap.Data.Scraper.Helpers.IPaginator.PageChanged"/> event.
      /// </summary>
      /// <param name="e">
      /// A <see
      /// cref="T:CoinMarketCap.Data.Scraper.Helpers.Events.PageChangedEventArgs"/>
      /// that contains the event data.
      /// </param>
      private void OnPageChanged(PageChangedEventArgs e)
         => PageChanged?.Invoke(this, e);
   }
}