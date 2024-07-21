using System.Diagnostics;
using PostSharp.Patterns.Threading;
using xyLOGIX.Data.Paginators.Events;
using xyLOGIX.Data.Paginators.Models;

namespace xyLOGIX.Data.Paginators.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// manages the pagination of scraped data.
    /// </summary>
    [Synchronized]
    public interface IScrapedDataPaginator
    {
        /// <summary> Gets or sets an integer describing the current page. </summary>
        /// <remarks>
        /// The value of this property can be changed using the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.First" />
        /// ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.Prev" />
        /// ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.GoToPage" />
        /// ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.Next" />
        /// , or
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.Last" />
        /// methods in a robust, fault-tolerant, and thread-safe manner.
        /// </remarks>
        int CurrentPage { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets a value indicating whether the scrapedDataPaginator is
        /// initialized.
        /// </summary>
        bool IsInitialized { [DebuggerStepThrough] get; }

        /// <summary> Gets an integer describing the total number of entries on a page. </summary>
        int PageSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets a string containing the URL of the current page. </summary>
        /// <remarks>
        /// This property's <c>getter</c> merely raises the
        /// <see cref="E:xyLOGIX.Data.Paginators.PaginatorBase.UrlExpressionRequested" />
        /// event to
        /// request the client of this object to tell it what expression is to be used for
        /// requesting a new page of results.
        /// <para />
        /// The value of the
        /// <see
        ///     cref="P:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.CurrentPage" />
        /// property
        /// is submitted to the event handler, or the <see cref="F:System.String.Empty" />
        /// value is returned if an invalid page number is set as the value of the
        /// <see
        ///     cref="P:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.CurrentPage" />
        /// property, such as a negative quantity (page numbers can only be nonnegative).
        /// </remarks>
        string PageUrl { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets a reference to a
        /// <see cref="T:xyLOGIX.Data.Paginators.Models.Pagination" /> object that defines
        /// the pagination parameters, such as current page, page size, total entries, etc.
        /// </summary>
        Pagination Pagination { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets an integer describing the total number of entries in the entire
        /// listing.
        /// </summary>
        int TotalEntries { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets an integer describing the total number of pages. </summary>
        int TotalPages { [DebuggerStepThrough] get; }

        /// <summary> Occurs when the current page has been set to a new value. </summary>
        event PageChangedEventHandler PageChanged;

        /// <summary> Gets an expression that tells us how to format the URL for each page. </summary>
        event UrlExpressionRequestedEventHandler UrlExpressionRequested;

        /// <summary> Navigates to the first page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IScrapedDataPaginator.GoToPage" /> method
        /// internally.
        /// </remarks>
        string First();

        /// <summary>
        /// Attempts the scrapedDataPaginator to the desired
        /// <paramref name="page" /> in a robust, fault-tolerant, and thread-safe manner.
        /// </summary>
        /// <param name="page">
        /// (Required.) A positive number, in between and including 1
        /// and the total number of pages, that indicates to which page you wish to
        /// navigate.
        /// </param>
        /// <returns>
        /// String containing the URL of the new page, or blank if a problem
        /// occurred. This method will not go beyond the bounds of the current range of
        /// pages.
        /// </returns>
        string GoToPage(int page);

        /// <summary>
        /// Specifies the pagination strategy to be utilized with this object in
        /// a fluent manner.
        /// </summary>
        /// <param name="pagination">
        /// Reference to an instance of
        /// <see cref="T:xyLOGIX.Data.Paginators.Models.Pagination" /> that specifies the
        /// pagination strategy to be utilized.
        /// </param>
        /// <returns>
        /// Reference to the instance of the object that called this method for
        /// fluent use.
        /// </returns>
        dynamic HavingPagination(Pagination pagination);

        /// <summary>
        /// Initializes this scrapedDataPaginator to start with default settings
        /// for Current Page (= 1), Page Size (= 0), and Total Entries (= 0).
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <remarks>
        /// This method simply initializes a new pagination parameter object and
        /// sets the <see cref="P:xyLOGIX.Data.Paginators.PaginatorBase.Pagination" />
        /// property to it.
        /// </remarks>
        dynamic HavingStartingPagination();

        /// <summary> Navigates to the last page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IScrapedDataPaginator.GoToPage" /> method
        /// internally.
        /// </remarks>
        string Last();

        /// <summary> Navigates to the next page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IScrapedDataPaginator.GoToPage" /> method
        /// internally.
        /// </remarks>
        string Next();

        /// <summary> Navigates to the previous page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IScrapedDataPaginator.GoToPage" /> method
        /// internally.
        /// </remarks>
        string Prev();
    }
}