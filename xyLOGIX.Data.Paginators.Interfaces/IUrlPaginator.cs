namespace xyLOGIX.Data.Paginators.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a url-based
    /// scrapedDataPaginator object.
    /// </summary>
    /// <remarks>
    /// These objects change the URL route to match the current page, i.e.,
    /// <c>https://localhost:45665/houses/2/</c> for page 2 of a houses list.
    /// </remarks>
    public interface IUrlPaginator : IScrapedDataPaginator
    {
        // TODO: Add event, method, and property definitions here.
    }
}