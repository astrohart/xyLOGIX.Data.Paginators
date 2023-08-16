<a name='assembly'></a>
# xyLOGIX.Data.Paginators.Models

## Contents

- [Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination')
  - [#ctor()](#M-xyLOGIX-Data-Paginators-Models-Pagination-#ctor 'xyLOGIX.Data.Paginators.Models.Pagination.#ctor')
  - [#ctor(currentPage,pageSize,totalEntries)](#M-xyLOGIX-Data-Paginators-Models-Pagination-#ctor-System-Int32,System-Int32,System-Int32- 'xyLOGIX.Data.Paginators.Models.Pagination.#ctor(System.Int32,System.Int32,System.Int32)')
  - [CurrentPage](#P-xyLOGIX-Data-Paginators-Models-Pagination-CurrentPage 'xyLOGIX.Data.Paginators.Models.Pagination.CurrentPage')
  - [PageSize](#P-xyLOGIX-Data-Paginators-Models-Pagination-PageSize 'xyLOGIX.Data.Paginators.Models.Pagination.PageSize')
  - [TotalEntries](#P-xyLOGIX-Data-Paginators-Models-Pagination-TotalEntries 'xyLOGIX.Data.Paginators.Models.Pagination.TotalEntries')
- [Resources](#T-xyLOGIX-Data-Paginators-Models-Properties-Resources 'xyLOGIX.Data.Paginators.Models.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Culture 'xyLOGIX.Data.Paginators.Models.Properties.Resources.Culture')
  - [Error_CurrentPage_OutOfRange](#P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Error_CurrentPage_OutOfRange 'xyLOGIX.Data.Paginators.Models.Properties.Resources.Error_CurrentPage_OutOfRange')
  - [Error_PageSizeMustBePositiveIntegerOrZero](#P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Error_PageSizeMustBePositiveIntegerOrZero 'xyLOGIX.Data.Paginators.Models.Properties.Resources.Error_PageSizeMustBePositiveIntegerOrZero')
  - [Error_TotalEntriesMustBePositive](#P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Error_TotalEntriesMustBePositive 'xyLOGIX.Data.Paginators.Models.Properties.Resources.Error_TotalEntriesMustBePositive')
  - [ResourceManager](#P-xyLOGIX-Data-Paginators-Models-Properties-Resources-ResourceManager 'xyLOGIX.Data.Paginators.Models.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Data-Paginators-Models-Pagination'></a>
## Pagination `type`

##### Namespace

xyLOGIX.Data.Paginators.Models

##### Summary

Describes the pagination data for a paginator (current page, page size, etc.).

<a name='M-xyLOGIX-Data-Paginators-Models-Pagination-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Models-Pagination-#ctor-System-Int32,System-Int32,System-Int32-'></a>
### #ctor(currentPage,pageSize,totalEntries) `constructor`

##### Summary

Constructs a new instance of
[Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentPage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer specifying the number of the current page. Set to
1 for the first page. Must be 1 or greater. |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer specifying the number of rows of data per page.
This value must be zero or greater. |
| totalEntries | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer specifying the total entries in the entire (paged)
list. This value must be zero or greater. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the `currentPage` parameter is less than 1,
or either of the `pageSize` or
`totalEntries`
parameters are less than zero. |

<a name='P-xyLOGIX-Data-Paginators-Models-Pagination-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Gets or sets an integer describing the current page.

##### Remarks

The value of this property can be changed using the
[First](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.First')
,
[Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev')
,
[GoToPage](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage')
,
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next') ,
or [Last](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last')
methods in a robust, fault-tolerant, and thread-safe manner.

<a name='P-xyLOGIX-Data-Paginators-Models-Pagination-PageSize'></a>
### PageSize `property`

##### Summary

Gets an integer describing the total number of entries on a page.

<a name='P-xyLOGIX-Data-Paginators-Models-Pagination-TotalEntries'></a>
### TotalEntries `property`

##### Summary

Gets an integer describing the total number of entries in the entire listing.

<a name='T-xyLOGIX-Data-Paginators-Models-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Paginators.Models.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Error_CurrentPage_OutOfRange'></a>
### Error_CurrentPage_OutOfRange `property`

##### Summary

Looks up a localized string similar to The value for currentPage must be 1 or greater..

<a name='P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Error_PageSizeMustBePositiveIntegerOrZero'></a>
### Error_PageSizeMustBePositiveIntegerOrZero `property`

##### Summary

Looks up a localized string similar to The pageSize parameter must be zero or greater..

<a name='P-xyLOGIX-Data-Paginators-Models-Properties-Resources-Error_TotalEntriesMustBePositive'></a>
### Error_TotalEntriesMustBePositive `property`

##### Summary

Looks up a localized string similar to The total number of entries must be zero or greater..

<a name='P-xyLOGIX-Data-Paginators-Models-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
