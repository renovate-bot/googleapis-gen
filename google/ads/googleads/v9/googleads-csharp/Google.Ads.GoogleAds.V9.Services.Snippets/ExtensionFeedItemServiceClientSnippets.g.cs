// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Enums;
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedExtensionFeedItemServiceClientSnippets
    {
        /// <summary>Snippet for GetExtensionFeedItem</summary>
        public void GetExtensionFeedItemRequestObject()
        {
            // Snippet: GetExtensionFeedItem(GetExtensionFeedItemRequest, CallSettings)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = ExtensionFeedItemServiceClient.Create();
            // Initialize request argument(s)
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            // Make the request
            ExtensionFeedItem response = extensionFeedItemServiceClient.GetExtensionFeedItem(request);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionFeedItemAsync</summary>
        public async Task GetExtensionFeedItemRequestObjectAsync()
        {
            // Snippet: GetExtensionFeedItemAsync(GetExtensionFeedItemRequest, CallSettings)
            // Additional: GetExtensionFeedItemAsync(GetExtensionFeedItemRequest, CancellationToken)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = await ExtensionFeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            // Make the request
            ExtensionFeedItem response = await extensionFeedItemServiceClient.GetExtensionFeedItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionFeedItem</summary>
        public void GetExtensionFeedItem()
        {
            // Snippet: GetExtensionFeedItem(string, CallSettings)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = ExtensionFeedItemServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/extensionFeedItems/[FEED_ITEM_ID]";
            // Make the request
            ExtensionFeedItem response = extensionFeedItemServiceClient.GetExtensionFeedItem(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionFeedItemAsync</summary>
        public async Task GetExtensionFeedItemAsync()
        {
            // Snippet: GetExtensionFeedItemAsync(string, CallSettings)
            // Additional: GetExtensionFeedItemAsync(string, CancellationToken)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = await ExtensionFeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/extensionFeedItems/[FEED_ITEM_ID]";
            // Make the request
            ExtensionFeedItem response = await extensionFeedItemServiceClient.GetExtensionFeedItemAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionFeedItem</summary>
        public void GetExtensionFeedItemResourceNames()
        {
            // Snippet: GetExtensionFeedItem(ExtensionFeedItemName, CallSettings)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = ExtensionFeedItemServiceClient.Create();
            // Initialize request argument(s)
            ExtensionFeedItemName resourceName = ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]");
            // Make the request
            ExtensionFeedItem response = extensionFeedItemServiceClient.GetExtensionFeedItem(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionFeedItemAsync</summary>
        public async Task GetExtensionFeedItemResourceNamesAsync()
        {
            // Snippet: GetExtensionFeedItemAsync(ExtensionFeedItemName, CallSettings)
            // Additional: GetExtensionFeedItemAsync(ExtensionFeedItemName, CancellationToken)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = await ExtensionFeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionFeedItemName resourceName = ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]");
            // Make the request
            ExtensionFeedItem response = await extensionFeedItemServiceClient.GetExtensionFeedItemAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateExtensionFeedItems</summary>
        public void MutateExtensionFeedItemsRequestObject()
        {
            // Snippet: MutateExtensionFeedItems(MutateExtensionFeedItemsRequest, CallSettings)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = ExtensionFeedItemServiceClient.Create();
            // Initialize request argument(s)
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateExtensionFeedItemsResponse response = extensionFeedItemServiceClient.MutateExtensionFeedItems(request);
            // End snippet
        }

        /// <summary>Snippet for MutateExtensionFeedItemsAsync</summary>
        public async Task MutateExtensionFeedItemsRequestObjectAsync()
        {
            // Snippet: MutateExtensionFeedItemsAsync(MutateExtensionFeedItemsRequest, CallSettings)
            // Additional: MutateExtensionFeedItemsAsync(MutateExtensionFeedItemsRequest, CancellationToken)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = await ExtensionFeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateExtensionFeedItemsResponse response = await extensionFeedItemServiceClient.MutateExtensionFeedItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateExtensionFeedItems</summary>
        public void MutateExtensionFeedItems()
        {
            // Snippet: MutateExtensionFeedItems(string, IEnumerable<ExtensionFeedItemOperation>, CallSettings)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = ExtensionFeedItemServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ExtensionFeedItemOperation> operations = new ExtensionFeedItemOperation[]
            {
                new ExtensionFeedItemOperation(),
            };
            // Make the request
            MutateExtensionFeedItemsResponse response = extensionFeedItemServiceClient.MutateExtensionFeedItems(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateExtensionFeedItemsAsync</summary>
        public async Task MutateExtensionFeedItemsAsync()
        {
            // Snippet: MutateExtensionFeedItemsAsync(string, IEnumerable<ExtensionFeedItemOperation>, CallSettings)
            // Additional: MutateExtensionFeedItemsAsync(string, IEnumerable<ExtensionFeedItemOperation>, CancellationToken)
            // Create client
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient = await ExtensionFeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ExtensionFeedItemOperation> operations = new ExtensionFeedItemOperation[]
            {
                new ExtensionFeedItemOperation(),
            };
            // Make the request
            MutateExtensionFeedItemsResponse response = await extensionFeedItemServiceClient.MutateExtensionFeedItemsAsync(customerId, operations);
            // End snippet
        }
    }
}
