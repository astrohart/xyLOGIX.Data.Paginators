<a name='assembly'></a>
# xyLOGIX.Data.Paginators.Events

## Contents

- [PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs')
  - [#ctor(currentPage,totalPages)](#M-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-#ctor-System-Int32,System-Int32- 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs.#ctor(System.Int32,System.Int32)')
  - [CurrentPage](#P-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-CurrentPage 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs.CurrentPage')
  - [TotalPages](#P-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-TotalPages 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs.TotalPages')
- [PageChangedEventHandler](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventHandler 'xyLOGIX.Data.Paginators.Events.PageChangedEventHandler')
- [Resources](#T-xyLOGIX-Data-Paginators-Events-Properties-Resources 'xyLOGIX.Data.Paginators.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Paginators-Events-Properties-Resources-Culture 'xyLOGIX.Data.Paginators.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Paginators-Events-Properties-Resources-ResourceManager 'xyLOGIX.Data.Paginators.Events.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs'></a>
## PageChangedEventArgs `type`

##### Namespace

xyLOGIX.Data.Paginators.Events

##### Summary

Defines the data that is passed by all events of type [PageChangedEventHandler](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventHandler 'xyLOGIX.Data.Paginators.Events.PageChangedEventHandler') .

<a name='M-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-#ctor-System-Int32,System-Int32-'></a>
### #ctor(currentPage,totalPages) `constructor`

##### Summary

Creates a new instance of [PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer describing the new page that the paginator has
been set to. Must be a positive value starting from 1. |
| totalPages | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer describing the total page count of the paginator
object. Must be a positive value starting from 1. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if either the `totalPages` or `currentPage` parameters are zero or negative, or if `currentPage` is greater than `totalPages`. |

<a name='P-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Gets a value that describes the current page that the paginator has
been set to.

##### Remarks

This value is always 1 or higher.

<a name='P-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-TotalPages'></a>
### TotalPages `property`

##### Summary

Gets a value that describes the total count of pages in the paginator.

##### Remarks

This value is always 1 or higher.

<a name='T-xyLOGIX-Data-Paginators-Events-PageChangedEventHandler'></a>
## PageChangedEventHandler `type`

##### Namespace

xyLOGIX.Data.Paginators.Events

##### Summary

Defines the method signature for the handlers of a `PageChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Data.Paginators.Events.PageChangedEventHandler](#T-T-xyLOGIX-Data-Paginators-Events-PageChangedEventHandler 'T:xyLOGIX.Data.Paginators.Events.PageChangedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-xyLOGIX-Data-Paginators-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Paginators.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Paginators-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Paginators-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
