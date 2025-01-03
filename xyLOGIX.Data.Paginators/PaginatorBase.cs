﻿using System.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Data.Paginators.Events;
using xyLOGIX.Data.Paginators.Interfaces;
using xyLOGIX.Data.Paginators.Models;

namespace xyLOGIX.Data.Paginators
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all
    /// Paginator object.
    /// </summary>
    public abstract class PaginatorBase : IScrapedDataPaginator
    {
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
        public abstract int CurrentPage { get; protected set; }

        /// <summary> Gets a value indicating whether the paginator is initialized. </summary>
        public abstract bool IsInitialized { [DebuggerStepThrough] get; }

        /// <summary> Gets an integer describing the total number of entries on a page. </summary>
        public abstract int PageSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets a string containing the URL of the current page. </summary>
        /// <remarks>
        /// This property's <c>getter</c> merely raises the
        /// <see
        ///     cref="E:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator.UrlExpressionRequested" />
        /// event to request the client of this object to tell it what expression is to be
        /// used for requesting a new page of results.
        /// <para />
        /// The value of the
        /// <see cref="P:xyLOGIX.Data.Paginators.UrlBasedPaginator.CurrentPage" /> property
        /// is submitted to the event handler, or the <see cref="F:System.String.Empty" />
        /// value is returned if an invalid page number is set as the value of the
        /// <see cref="P:xyLOGIX.Data.Paginators.UrlBasedPaginator.CurrentPage" />
        /// property, such as a negative quantity (page numbers can only be nonnegative).
        /// </remarks>
        public abstract string PageUrl { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets a reference to a
        /// <see cref="T:xyLOGIX.Data.Paginators.Models.Pagination" /> object that defines
        /// the pagination parameters, such as current page, page size, total entries, etc.
        /// </summary>
        public abstract Pagination Pagination { get; protected set; }

        /// <summary>
        /// Gets an integer describing the total number of entries in the entire
        /// listing.
        /// </summary>
        public abstract int TotalEntries { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets an integer describing the total number of pages. </summary>
        public abstract int TotalPages { [DebuggerStepThrough] get; }

        /// <summary> Occurs when the current page has been set to a new value. </summary>
        public event PageChangedEventHandler PageChanged;

        /// <summary> Gets an expression that tells us how to format the URL for each page. </summary>
        public event UrlExpressionRequestedEventHandler UrlExpressionRequested;

        /// <summary> Navigates to the first page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public abstract string First();

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
        public abstract string GoToPage(int page);

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
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="pagination" />, is passed a <see langword="null" /> value.
        /// </exception>
        public dynamic HavingPagination(Pagination pagination)
        {
            Pagination = pagination ??
                         throw new ArgumentNullException(nameof(pagination));

            return this;
        }

        /// <summary>
        /// Initializes this paginator to start with default settings for Current
        /// Page (= 1), Page Size (= 0), and Total Entries (= 0).
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
        public dynamic HavingStartingPagination()
        {
            Pagination = new Pagination();
            return this;
        }

        /// <summary> Navigates to the last page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public abstract string Last();

        /// <summary> Navigates to the next page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public abstract string Next();

        /// <summary> Navigates to the previous page in a thread-safe manner. </summary>
        /// <returns> String containing the URL of the new page. </returns>
        /// <remarks>
        /// Implementers of this method should call the
        /// <see cref="M:xyLOGIX.Data.Paginators.IPaginator.GoToPage" /> method internally.
        /// </remarks>
        public abstract string Prev();

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Data.Paginators.UrlBasedPaginator.UrlExpressionRequested" />
        /// event
        /// to request the formatted page request URL from the client of this object.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:xyLOGIX.Data.Paginators.Events.UrlExpressionRequestedEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        /// <returns>
        /// String containing the URL of the page having the value of the
        /// <see
        ///     cref="P:xyLOGIX.Data.Paginators.Events.UrlExpressionRequestedEventArgs.CurrentPage" />
        /// property as its page number, or the <see cref="F:System.String.Empty" /> value
        /// if an error occurred, such as invalid current page number passed.
        /// </returns>
        [Yielder]
        protected virtual string OnFormatPageURL(
            UrlExpressionRequestedEventArgs e
        )
        {
            var result = string.Empty;

            try
            {
                if (UrlExpressionRequested == null) return result;

                result = UrlExpressionRequested(this, e);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Data.Paginators.IPaginator.PageChanged" /> event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Data.Paginators.Events.PageChangedEventArgs" /> that
        /// contains the event data.
        /// </param>
        [Yielder]
        protected virtual void OnPageChanged(PageChangedEventArgs e)
            => PageChanged?.Invoke(this, e);
    }
}