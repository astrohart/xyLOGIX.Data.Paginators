namespace xyLOGIX.Data.Paginators.Events
{
    /// <summary>
    /// Method signature for the handler of a <c>UrlExpressionRequested</c> event.
    /// </summary>
    /// <param name="sender">(Required.) Reference to the sender of the event.</param>
    /// <param name="e">
    /// (Required.) A
    /// <see cref="T:xyLOGIX.Data.Paginators.Events.UrlExpressionRequestedEventArgs" />
    /// containing the event data.
    /// </param>
    /// <returns></returns>
    public delegate string UrlExpressionRequestedEventHandler(
        [NotLogged] object sender,
        [NotLogged] UrlExpressionRequestedEventArgs e
    );
}