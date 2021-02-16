using System;
using xyLOGIX.Data.Paginators.Events;
using xyLOGIX.Data.Paginators.Interfaces;

namespace xyLOGIX.Data.Paginators
{
   public abstract class PaginatorBase : IPaginator
   {
      /// <summary>
      /// Reference to an instance of an object that serves as a
      /// thread-synchronization root object.
      /// </summary>
      protected readonly object SyncRoot = new object();

      /// <summary>
      /// Expression that tells us how to format the URL for each page.
      /// </summary>
      protected Func<int, string> _urlExpression;

      /// <summary>
      /// Gets or sets an integer describing the current page.
      /// </summary>
      /// <remarks>
      /// The value of this property can be changed using the
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.First" />
      /// ,
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev" />
      /// ,
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage" />
      /// ,
      /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next" /> ,
      /// or <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last" />
      /// methods in a robust, fault-tolerant, and thread-safe manner.
      /// </remarks>
      public abstract int CurrentPage { get; protected set; }

      /// <summary>
      /// Gets a value indicating whether the paginator is initialized.
      /// </summary>
      public abstract bool IsInitialized { get; }

      /// <summary>
      /// Gets an integer describing the total number of entries on a page.
      /// </summary>
      public abstract int PageSize { get; protected set; }

      /// <summary>
      /// Gets a string containing the URL of the current page.
      /// </summary>
      public abstract string PageUrl { get; }

      /// <summary>
      /// Gets an integer describing the total number of entries in the entire listing.
      /// </summary>
      public abstract int TotalEntries { get; protected set; }

      /// <summary>
      /// Gets an integer describing the total number of pages.
      /// </summary>
      public abstract int TotalPages { get; }

      /// <summary>
      /// Occurs when the current page has been set to a new value.
      /// </summary>
      public abstract event PageChangedEventHandler PageChanged;

      /// <summary>
      /// Navigates to the first page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" />
      /// method internally.
      /// </remarks>
      public abstract string First();

      /// <summary>
      /// Attempts the paginator to the desired <paramref name="page" /> in a
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
      public abstract string GoToPage(int page);

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
      /// (Required.) A <see cref="T:System.Func" /> that takes the current page
      /// number as the parameter and returns a string with the
      /// properly-formatted URL for scraping the Nth page, where N is a number
      /// equal to or greater than 1 and less than or equal to the total number
      /// of pages.
      /// </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// Thrown if either of the <paramref name="pageSize" /> or
      /// <paramref
      ///    name="totalEntries" />
      /// values are zero or negative. Since these are
      /// page and entry counts, respectively, it is to be assumed that these
      /// will always be positive values.
      /// </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// Thrown if the <paramref name="urlExpression" /> parameter is not initialized.
      /// </exception>
      public abstract void InitializePagination(int pageSize, int totalEntries,
         Func<int, string> urlExpression);

      /// <summary>
      /// Navigates to the last page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" />
      /// method internally.
      /// </remarks>
      public abstract string Last();

      /// <summary>
      /// Navigates to the next page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" />
      /// method internally.
      /// </remarks>
      public abstract string Next();

      /// <summary>
      /// Navigates to the previous page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the
      /// <see
      ///    cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" />
      /// method internally.
      /// </remarks>
      public abstract string Prev();

      /// <summary>
      /// Invokes the expression, if any, attached to the
      /// <see
      ///    cref="F:"
      ///    CoinMarketCap.Data.Scraper.Interfaces.CoinMarketCapPagination._urlExpression />
      /// delegate.
      /// </summary>
      /// <param name="pageNumber">
      /// Page number of the
      /// current page.
      /// </param>
      /// <returns>String containing the </returns>
      protected abstract string OnFormatPageURL(int pageNumber);

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:xyLOGIX.Data.Paginators.IPaginator.PageChanged" />
      /// event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:xyLOGIX.Data.Paginators.Events.PageChangedEventArgs" />
      /// that contains the event data.
      /// </param>
      protected abstract void OnPageChanged(PageChangedEventArgs e);
   }
}