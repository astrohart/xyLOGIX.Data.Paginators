using System.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Data.Paginators.Models.Properties;

namespace xyLOGIX.Data.Paginators.Models
{
    /// <summary>
    /// Describes the pagination data for a paginator (current page, page
    /// size, etc.).
    /// </summary>
    [Synchronized]
    public sealed class Pagination
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Paginators.Models.Pagination" /> and returns a
        /// reference to it.
        /// </summary>
        public Pagination()
        {
            CurrentPage = 1;
            PageSize = 0;
            TotalEntries = 0;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Paginators.Models.Pagination" /> and returns a
        /// reference to it.
        /// </summary>
        /// ///
        /// <param name="currentPage">
        /// (Required.) Integer specifying the number of the
        /// current page. Set to 1 for the first page. Must be 1 or greater.
        /// </param>
        /// ///
        /// <param name="pageSize">
        /// (Required.) Integer specifying the number of rows of
        /// data per page. This value must be zero or greater.
        /// </param>
        /// ///
        /// <param name="totalEntries">
        /// (Required.) Integer specifying the total entries in
        /// the entire (paged) list. This value must be zero or greater.
        /// </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the
        /// <paramref name="currentPage" /> parameter is less than 1, or either of the
        /// <paramref name="pageSize" /> or <paramref name="totalEntries" /> parameters are
        /// less than zero.
        /// </exception>
        public Pagination(int currentPage, int pageSize, int totalEntries)
        {
            if (currentPage < 1)
                throw new ArgumentOutOfRangeException(
                    Resources.Error_CurrentPage_OutOfRange, nameof(currentPage)
                );
            if (pageSize < 0)
                throw new ArgumentOutOfRangeException(
                    Resources.Error_PageSizeMustBePositiveIntegerOrZero,
                    nameof(pageSize)
                );
            if (totalEntries < 0)
                throw new ArgumentOutOfRangeException(
                    Resources.Error_TotalEntriesMustBePositive,
                    nameof(totalEntries)
                );

            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalEntries = totalEntries;
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
        public int CurrentPage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets an integer describing the total number of entries on a page. </summary>
        public int PageSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets an integer describing the total number of entries in the entire
        /// listing.
        /// </summary>
        public int TotalEntries { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    }
}