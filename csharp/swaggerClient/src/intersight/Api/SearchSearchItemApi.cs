/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 0.1.0-559
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using intersight.Client;
using intersight.Model;

namespace intersight.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchSearchItemApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>SearchSearchItemList</returns>
        SearchSearchItemList SearchSearchItemsGet (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null);

        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>ApiResponse of SearchSearchItemList</returns>
        ApiResponse<SearchSearchItemList> SearchSearchItemsGetWithHttpInfo (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null);
        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>SearchSearchItem</returns>
        SearchSearchItem SearchSearchItemsMoidGet (string moid);

        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>ApiResponse of SearchSearchItem</returns>
        ApiResponse<SearchSearchItem> SearchSearchItemsMoidGetWithHttpInfo (string moid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>Task of SearchSearchItemList</returns>
        System.Threading.Tasks.Task<SearchSearchItemList> SearchSearchItemsGetAsync (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null);

        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>Task of ApiResponse (SearchSearchItemList)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchSearchItemList>> SearchSearchItemsGetAsyncWithHttpInfo (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null);
        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>Task of SearchSearchItem</returns>
        System.Threading.Tasks.Task<SearchSearchItem> SearchSearchItemsMoidGetAsync (string moid);

        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>Task of ApiResponse (SearchSearchItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchSearchItem>> SearchSearchItemsMoidGetAsyncWithHttpInfo (string moid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchSearchItemApi : ISearchSearchItemApi
    {
        private intersight.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSearchItemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchSearchItemApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = intersight.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSearchItemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchSearchItemApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = intersight.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public intersight.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>SearchSearchItemList</returns>
        public SearchSearchItemList SearchSearchItemsGet (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
             ApiResponse<SearchSearchItemList> localVarResponse = SearchSearchItemsGetWithHttpInfo(count, inlinecount, top, skip, filter, select, orderby, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>ApiResponse of SearchSearchItemList</returns>
        public ApiResponse< SearchSearchItemList > SearchSearchItemsGetWithHttpInfo (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {

            var localVarPath = "/search/SearchItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (count != null) localVarQueryParams.Add("$count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (inlinecount != null) localVarQueryParams.Add("$inlinecount", Configuration.ApiClient.ParameterToString(inlinecount)); // query parameter
            if (top != null) localVarQueryParams.Add("$top", Configuration.ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) localVarQueryParams.Add("$skip", Configuration.ApiClient.ParameterToString(skip)); // query parameter
            if (filter != null) localVarQueryParams.Add("$filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (select != null) localVarQueryParams.Add("$select", Configuration.ApiClient.ParameterToString(select)); // query parameter
            if (orderby != null) localVarQueryParams.Add("$orderby", Configuration.ApiClient.ParameterToString(orderby)); // query parameter
            if (expand != null) localVarQueryParams.Add("$expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSearchItemsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchSearchItemList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchSearchItemList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchSearchItemList)));
        }

        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>Task of SearchSearchItemList</returns>
        public async System.Threading.Tasks.Task<SearchSearchItemList> SearchSearchItemsGetAsync (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
             ApiResponse<SearchSearchItemList> localVarResponse = await SearchSearchItemsGetAsyncWithHttpInfo(count, inlinecount, top, skip, filter, select, orderby, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of &#39;searchSearchItem&#39; instances 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The $count query option allows clients to request a count of the matching resources. (optional)</param>
        /// <param name="inlinecount">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response (optional)</param>
        /// <param name="top">The max number of records to return (optional)</param>
        /// <param name="skip">The number of records to skip (optional)</param>
        /// <param name="filter">Filter criteria for records to return. A URI with a $filter System Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in $filter operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. Query examples: $filter&#x3D;Name eq &#39;Bob&#39; $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39;) $filter&#x3D;Tags/any(t: t/Key eq &#39;Site&#39; and t/Value eq &#39;London&#39;)  (optional)</param>
        /// <param name="select">Specifies a subset of properties to return (optional)</param>
        /// <param name="orderby">Determines what values are used to order a collection of records (optional)</param>
        /// <param name="expand">Specify additional attributes or related records to return. Supports only &#39;DisplayNames&#39; attribute now. Query examples: $expand&#x3D;DisplayNames  (optional)</param>
        /// <returns>Task of ApiResponse (SearchSearchItemList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchSearchItemList>> SearchSearchItemsGetAsyncWithHttpInfo (bool? count = null, string inlinecount = null, int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {

            var localVarPath = "/search/SearchItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (count != null) localVarQueryParams.Add("$count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (inlinecount != null) localVarQueryParams.Add("$inlinecount", Configuration.ApiClient.ParameterToString(inlinecount)); // query parameter
            if (top != null) localVarQueryParams.Add("$top", Configuration.ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) localVarQueryParams.Add("$skip", Configuration.ApiClient.ParameterToString(skip)); // query parameter
            if (filter != null) localVarQueryParams.Add("$filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (select != null) localVarQueryParams.Add("$select", Configuration.ApiClient.ParameterToString(select)); // query parameter
            if (orderby != null) localVarQueryParams.Add("$orderby", Configuration.ApiClient.ParameterToString(orderby)); // query parameter
            if (expand != null) localVarQueryParams.Add("$expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSearchItemsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchSearchItemList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchSearchItemList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchSearchItemList)));
        }

        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>SearchSearchItem</returns>
        public SearchSearchItem SearchSearchItemsMoidGet (string moid)
        {
             ApiResponse<SearchSearchItem> localVarResponse = SearchSearchItemsMoidGetWithHttpInfo(moid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>ApiResponse of SearchSearchItem</returns>
        public ApiResponse< SearchSearchItem > SearchSearchItemsMoidGetWithHttpInfo (string moid)
        {
            // verify the required parameter 'moid' is set
            if (moid == null)
                throw new ApiException(400, "Missing required parameter 'moid' when calling SearchSearchItemApi->SearchSearchItemsMoidGet");

            var localVarPath = "/search/SearchItems/{moid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (moid != null) localVarPathParams.Add("moid", Configuration.ApiClient.ParameterToString(moid)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSearchItemsMoidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchSearchItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchSearchItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchSearchItem)));
        }

        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>Task of SearchSearchItem</returns>
        public async System.Threading.Tasks.Task<SearchSearchItem> SearchSearchItemsMoidGetAsync (string moid)
        {
             ApiResponse<SearchSearchItem> localVarResponse = await SearchSearchItemsMoidGetAsyncWithHttpInfo(moid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific instance of &#39;searchSearchItem&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moid">The moid of the searchSearchItem instance.</param>
        /// <returns>Task of ApiResponse (SearchSearchItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchSearchItem>> SearchSearchItemsMoidGetAsyncWithHttpInfo (string moid)
        {
            // verify the required parameter 'moid' is set
            if (moid == null)
                throw new ApiException(400, "Missing required parameter 'moid' when calling SearchSearchItemApi->SearchSearchItemsMoidGet");

            var localVarPath = "/search/SearchItems/{moid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (moid != null) localVarPathParams.Add("moid", Configuration.ApiClient.ParameterToString(moid)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSearchItemsMoidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchSearchItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchSearchItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchSearchItem)));
        }

    }
}
