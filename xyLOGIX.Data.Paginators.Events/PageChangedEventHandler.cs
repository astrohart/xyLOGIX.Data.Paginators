namespace xyLOGIX.Data.Paginators.Events
{
   /// <summary>
   /// Defines the method signature for the handlers of a <c>PageChanged</c> event.
   /// </summary>
   /// <param name="sender">
   /// Reference to the instance of the object that raised the event.
   /// </param>
   /// <param name="e">
   /// A <see cref="T:xyLOGIX.Data.Paginators.Interfaces.PageChangedEventArgs"/>
   /// that contains the event data.
   /// </param>
   public delegate void PageChangedEventHandler(object sender, PageChangedEventArgs e);
}