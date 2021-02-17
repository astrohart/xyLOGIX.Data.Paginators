using System;
using xyLOGIX.Data.Paginators.Events;

namespace xyLOGIX.Data.Paginators.Interfaces
{
   /// <summary>
   /// Defines the public-exposed methods and properties of an object that
   /// manages the pagination of scraped data.
   /// </summary>
   public interface IPaginator
   {
      /// <summary>
      /// Occurs when the current page has been set to a new value.
      /// </summary>
      event PageChangedEventHandler PageChanged;

      /// <summary>
      /// Gets or sets an integer describing the current page.
      /// </summary>
      /// <remarks>
      /// The value of this property can be changed using the <see
      /// cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.First"/>
      /// , <see
      /// cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev"/>
      /// , <see
      /// cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage"/>
      /// , <see
      /// cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next"/>
      /// , or <see
      /// cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last"/>
      /// methods in a robust, fault-tolerant, and thread-safe manner.
      /// </remarks>
      int CurrentPage { get; }

      /// <summary>
      /// Gets a value indicating whether the paginator is initialized.
      /// </summary>
      bool IsInitialized { get; }

      /// <summary>
      /// Gets an integer describing the total number of entries on a page.
      /// </summary>
      int PageSize { get; }

      /// <summary>
      /// Gets a string containing the URL of the current page.
      /// </summary>
      string PageUrl { get; }

      /// <summary>
      /// Gets an integer describing the total number of entries in the entire listing.
      /// </summary>
      int TotalEntries { get; }

      /// <summary>
      /// Gets an integer describing the total number of pages.
      /// </summary>
      int TotalPages { get; }

      /// <summary>
      /// Gets a reference to a
      /// <see
      ///     cref="T:xyLOGIX.Data.Paginators.Pagination" />
      /// object.
      /// </summary>
      Pagination Pagination { get; }

      /// <summary>
      /// Navigates to the first page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      string First();

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
      string GoToPage(int page);

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
      void InitializePagination(int pageSize, int totalEntries,
         Func<int, string> urlExpression);

      /// <summary>
      /// Navigates to the last page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      string Last();

      /// <summary>
      /// Navigates to the next page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      string Next();

      /// <summary>
      /// Navigates to the previous page in a thread-safe manner.
      /// </summary>
      /// <returns>
      /// String containing the URL of the new page.
      /// </returns>
      /// <remarks>
      /// Implementers of this method should call the <see
      /// cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage"/>
      /// method internally.
      /// </remarks>
      string Prev();
   }
}