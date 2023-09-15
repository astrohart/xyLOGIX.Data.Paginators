<a name='assembly'></a>
# xyLOGIX.Data.Paginators.Factories

## Contents

- [GetPaginator](#T-xyLOGIX-Data-Paginators-Factories-GetPaginator 'xyLOGIX.Data.Paginators.Factories.GetPaginator')
  - [OfType(type)](#M-xyLOGIX-Data-Paginators-Factories-GetPaginator-OfType-xyLOGIX-Data-Paginators-Constants-PaginatorType- 'xyLOGIX.Data.Paginators.Factories.GetPaginator.OfType(xyLOGIX.Data.Paginators.Constants.PaginatorType)')
- [Resources](#T-xyLOGIX-Data-Paginators-Factories-Properties-Resources 'xyLOGIX.Data.Paginators.Factories.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Paginators-Factories-Properties-Resources-Culture 'xyLOGIX.Data.Paginators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Paginators-Factories-Properties-Resources-ResourceManager 'xyLOGIX.Data.Paginators.Factories.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Data-Paginators-Factories-GetPaginator'></a>
## GetPaginator `type`

##### Namespace

xyLOGIX.Data.Paginators.Factories

##### Summary

Creates instances of objects that implement the
[IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator')
interface.

<a name='M-xyLOGIX-Data-Paginators-Factories-GetPaginator-OfType-xyLOGIX-Data-Paginators-Constants-PaginatorType-'></a>
### OfType(type) `method`

##### Summary

Creates an instance of an object implementing the
[IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator')
interface
which corresponds to the value specified in `type`,
and returns a reference to it.

##### Returns

A reference to the instance of the object that implements the
[IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator')
interface
which corresponds to the value specified in `type`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [xyLOGIX.Data.Paginators.Constants.PaginatorType](#T-xyLOGIX-Data-Paginators-Constants-PaginatorType 'xyLOGIX.Data.Paginators.Constants.PaginatorType') | One of the
[PaginatorType](#T-xyLOGIX-Data-Paginators-Factories-PaginatorType 'xyLOGIX.Data.Paginators.Factories.PaginatorType')
values that
describes what type of object you want. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no corresponding concrete type defined that
implements the
[IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator')
interface and
which corresponds to the value passed in the `type`
parameter. |

##### Remarks

This method will throw an exception if there are no types implemented
that correspond to the value of `type`.

<a name='T-xyLOGIX-Data-Paginators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Paginators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Paginators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Paginators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
