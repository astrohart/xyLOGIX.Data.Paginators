using PostSharp.Patterns.Model;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Data.Paginators.Events;
using xyLOGIX.Data.Paginators.Interfaces;
using xyLOGIX.Data.Paginators.Models;

namespace xyLOGIX.Data.Paginators
{
    /// <summary>
    /// Object that provides services for accessing paginated data from a
    /// data source.
    /// </summary>
    [Synchronized]
    public class UrlBasedPaginator : PaginatorBase, IUrlPaginator
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Paginators.UrlBasedPaginator" /> and returns a
        /// reference to it.
        /// </summary>
        public UrlBasedPaginator()
            => Pagination = new Pagination();

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:CoinMarketCap.Data.Scraper.CoinMarketCapPagination" /> and returns
        /// a reference to it.
        /// </summary>
        /// ///
        /// <param name="pagination">
        /// (Required.) Reference to an instance of a
        /// <see cref="T:xyLOGIX.Data.Paginators.Models.Pagination" /> object that provides
        /// the pagination data, such as current page, page size, total entries, etc.
        /// </param>
        public UrlBasedPaginator(Pagination pagination)
        {
            Pagination = pagination;
        }

        /// <summary> Gets or sets an integer describing the current page. </summary>
        /// <remarks>
        /// The value of this property can be changed using the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.First" /> ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev" /> ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage" /> ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next" /> , or
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last" /> methods in
        /// a robust, fault-tolerant, and thread-safe manner.
        /// </remarks>
        public override int CurrentPage
        {
            protected set => Pagination.CurrentPage = value;
            get => Pagination.CurrentPage;
        }

        /// <summary> Gets a value indicating whether the paginator is initialized. </summary>
        public override bool IsInitialized
            => PageSize > 0 && TotalEntries > 0 && TotalPages > 0;

        /// <summary> Gets an integer describing the total number of entries on a page. </summary>
        public override int PageSize
        {
            set => Pagination.PageSize = value;
            get => Pagination.PageSize;
        }

        /// <summary> Gets a string containing the URL of the current page. </summary>
        /// <remarks>
        /// This property's <c>getter</c> merely raises the
        /// <see cref="E:xyLOGIX.Data.Paginators.PaginatorBase.UrlExpressionRequested" /> event to
        /// request the client of this object to tell it what expression is to be used for
        /// requesting a new page of results.
        /// <para />
        /// The value of the
        /// <see cref="P:xyLOGIX.Data.Paginators.UrlBasedPaginator.CurrentPage" /> property
        /// is submitted to the event handler, or the <see cref="F:System.String.Empty" />
        /// value is returned if an invalid page number is set as the value of the
        /// <see cref="P:xyLOGIX.Data.Paginators.UrlBasedPaginator.CurrentPage" />
        /// property, such as a negative quantity (page numbers can only be nonnegative).
        /// </remarks>
        public override string PageUrl
        {
            get
            {
                var result = string.Empty;

                try
                {
                    if (CurrentPage < 0) return result;

                    result = OnFormatPageURL(
                        new UrlExpressionRequestedEventArgs(CurrentPage)
                    );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets a reference to a
        /// <see cref="T:xyLOGIX.Data.Paginators.Pagination" /> object.
        /// </summary>
        /// <remarks> This is the object that contains the page size, etc. </remarks>
        [Reference]
        public override Pagination Pagination { get; protected set; }

        /// <summary>
        /// Gets an integer describing the total number of entries in the entire
        /// listing.
        /// </summary>
        public override int TotalEntries
        {
            set => Pagination.TotalEntries = value;
            get => Pagination.TotalEntries;
        }

        /// <summary> Gets an integer describing the total number of pages. </summary>
        public override int TotalPages
            => TotalEntries > 0 && PageSize > 0
                ? (TotalEntries + PageSize + 1) / PageSize
                : 1;

        /// <summary> Navigates to the first page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public override string First()
            => GoToPage(1);

        /// <summary>
        /// Attempts the paginator to the desired <paramref name="page" /> in a
        /// robust, fault-tolerant, and thread-safe manner.
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
        public override string GoToPage(int page)
        {
            var result = string.Empty;

            if (page <= 0 ||
                TotalPages <=
                1) // trying to move before the first or only page, stop at first page.
            {
                CurrentPage = 1;
                OnPageChanged(new PageChangedEventArgs(1, TotalPages));
                result = PageUrl;
            }
            else if
                (page >
                 TotalPages) // trying to move past the end; stop at last page.
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
                OnPageChanged(
                    new PageChangedEventArgs(CurrentPage, TotalPages)
                );
                result = PageUrl; // return resultant page URL
            }

            return result;
        }

        /// <summary> Navigates to the last page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public override string Last()
            => GoToPage(TotalPages);

        /// <summary> Navigates to the next page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public override string Next()
            => GoToPage(++CurrentPage);

        /// <summary> Navigates to the previous page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public override string Prev()
            => GoToPage(--CurrentPage);
    }
}