# ShopwareSharp.Model.Criteria
Search parameters. For more information, see our documentation on [Search Queries](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#structure)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Page** | **int** | Search result page | [optional] 
**Limit** | **int** | Number of items per result page | [optional] 
**Filter** | [**List&lt;CriteriaFilterInner&gt;**](CriteriaFilterInner.md) | List of filters to restrict the search result. For more information, see [Search Queries &gt; Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#filter) | [optional] 
**Sort** | [**List&lt;CriteriaSortInner&gt;**](CriteriaSortInner.md) | Sorting in the search result. | [optional] 
**PostFilter** | [**List&lt;CriteriaFilterInner&gt;**](CriteriaFilterInner.md) | Filters that applied without affecting aggregations. For more information, see [Search Queries &gt; Post Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#post-filter) | [optional] 
**Associations** | **Object** | Used to fetch associations which are not fetched by default. | [optional] 
**Aggregations** | [**List&lt;CriteriaAggregationsInner&gt;**](CriteriaAggregationsInner.md) | Used to perform aggregations on the search result. For more information, see [Search Queries &gt; Aggregations](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#aggregations) | [optional] 
**Grouping** | **List&lt;string&gt;** | Perform groupings over certain fields | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

