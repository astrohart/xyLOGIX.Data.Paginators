namespace xyLOGIX.Data.Paginators
{
    /// <summary>
    /// Describes the pagination data for a paginator (current page, page size, etc.).
    /// </summary>
    public sealed class Pagination
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Data.Paginators.Pagination" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// Call this constructor when calling the constructor of one of the
        /// family of classes that implement
        /// <see
        ///     cref="T:xyLOGIX.Data.Paginators.Interfaces.IPaginatorxyLOGIX.Data.Paginators.Interfaces.IPaginator" />
        /// to specify the pagination parameters.
        /// </remarks>
        public Pagination()
        {
            CurrentPage = 1;
            PageSize = 0;
            TotalEntries = 0;
        }

        /// <summary>
        /// Gets or sets an integer describing the current page.
        /// </summary>
        /// <remarks>
        /// The value of this property can be changed using the
        /// <see
        ///     cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.First" />
        /// ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev" /> ,
        /// <see
        ///     cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage" />
        /// ,
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next" /> ,
        /// or
        /// <see
        ///     cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last" />
        /// methods in a robust, fault-tolerant, and thread-safe manner.
        /// </remarks>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets an integer describing the total number of entries on a page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets an integer describing the total number of entries in the entire listing.
        /// </summary>
        public int TotalEntries { get; set; }
    }
}