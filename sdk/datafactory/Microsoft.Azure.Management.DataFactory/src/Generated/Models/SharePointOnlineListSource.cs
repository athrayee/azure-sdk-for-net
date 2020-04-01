// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity source for sharePoint online list source.
    /// </summary>
    public partial class SharePointOnlineListSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the SharePointOnlineListSource class.
        /// </summary>
        public SharePointOnlineListSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharePointOnlineListSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="query">The OData query to filter the data in
        /// SharePoint Online list. For example, "$top=1". Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="httpRequestTimeout">The wait time to get a response
        /// from SharePoint Online. Default value is 5 minutes (00:05:00).
        /// Type: string (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        public SharePointOnlineListSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object query = default(object), object httpRequestTimeout = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            Query = query;
            HttpRequestTimeout = httpRequestTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the OData query to filter the data in SharePoint
        /// Online list. For example, "$top=1". Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the wait time to get a response from SharePoint
        /// Online. Default value is 5 minutes (00:05:00). Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestTimeout")]
        public object HttpRequestTimeout { get; set; }

    }
}