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
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedLifeEventServiceClientSnippets
    {
        /// <summary>Snippet for GetLifeEvent</summary>
        public void GetLifeEventRequestObject()
        {
            // Snippet: GetLifeEvent(GetLifeEventRequest, CallSettings)
            // Create client
            LifeEventServiceClient lifeEventServiceClient = LifeEventServiceClient.Create();
            // Initialize request argument(s)
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            // Make the request
            LifeEvent response = lifeEventServiceClient.GetLifeEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetLifeEventAsync</summary>
        public async Task GetLifeEventRequestObjectAsync()
        {
            // Snippet: GetLifeEventAsync(GetLifeEventRequest, CallSettings)
            // Additional: GetLifeEventAsync(GetLifeEventRequest, CancellationToken)
            // Create client
            LifeEventServiceClient lifeEventServiceClient = await LifeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLifeEventRequest request = new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]"),
            };
            // Make the request
            LifeEvent response = await lifeEventServiceClient.GetLifeEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLifeEvent</summary>
        public void GetLifeEvent()
        {
            // Snippet: GetLifeEvent(string, CallSettings)
            // Create client
            LifeEventServiceClient lifeEventServiceClient = LifeEventServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/lifeEvents/[LIFE_EVENT_ID]";
            // Make the request
            LifeEvent response = lifeEventServiceClient.GetLifeEvent(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLifeEventAsync</summary>
        public async Task GetLifeEventAsync()
        {
            // Snippet: GetLifeEventAsync(string, CallSettings)
            // Additional: GetLifeEventAsync(string, CancellationToken)
            // Create client
            LifeEventServiceClient lifeEventServiceClient = await LifeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/lifeEvents/[LIFE_EVENT_ID]";
            // Make the request
            LifeEvent response = await lifeEventServiceClient.GetLifeEventAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLifeEvent</summary>
        public void GetLifeEventResourceNames()
        {
            // Snippet: GetLifeEvent(LifeEventName, CallSettings)
            // Create client
            LifeEventServiceClient lifeEventServiceClient = LifeEventServiceClient.Create();
            // Initialize request argument(s)
            LifeEventName resourceName = LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]");
            // Make the request
            LifeEvent response = lifeEventServiceClient.GetLifeEvent(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLifeEventAsync</summary>
        public async Task GetLifeEventResourceNamesAsync()
        {
            // Snippet: GetLifeEventAsync(LifeEventName, CallSettings)
            // Additional: GetLifeEventAsync(LifeEventName, CancellationToken)
            // Create client
            LifeEventServiceClient lifeEventServiceClient = await LifeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            LifeEventName resourceName = LifeEventName.FromCustomerLifeEvent("[CUSTOMER_ID]", "[LIFE_EVENT_ID]");
            // Make the request
            LifeEvent response = await lifeEventServiceClient.GetLifeEventAsync(resourceName);
            // End snippet
        }
    }
}
