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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRemarketingActionServiceClientSnippets
    {
        /// <summary>Snippet for GetRemarketingAction</summary>
        public void GetRemarketingActionRequestObject()
        {
            // Snippet: GetRemarketingAction(GetRemarketingActionRequest, CallSettings)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = RemarketingActionServiceClient.Create();
            // Initialize request argument(s)
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            // Make the request
            RemarketingAction response = remarketingActionServiceClient.GetRemarketingAction(request);
            // End snippet
        }

        /// <summary>Snippet for GetRemarketingActionAsync</summary>
        public async Task GetRemarketingActionRequestObjectAsync()
        {
            // Snippet: GetRemarketingActionAsync(GetRemarketingActionRequest, CallSettings)
            // Additional: GetRemarketingActionAsync(GetRemarketingActionRequest, CancellationToken)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = await RemarketingActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            // Make the request
            RemarketingAction response = await remarketingActionServiceClient.GetRemarketingActionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRemarketingAction</summary>
        public void GetRemarketingAction()
        {
            // Snippet: GetRemarketingAction(string, CallSettings)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = RemarketingActionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/remarketingActions/[REMARKETING_ACTION_ID]";
            // Make the request
            RemarketingAction response = remarketingActionServiceClient.GetRemarketingAction(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetRemarketingActionAsync</summary>
        public async Task GetRemarketingActionAsync()
        {
            // Snippet: GetRemarketingActionAsync(string, CallSettings)
            // Additional: GetRemarketingActionAsync(string, CancellationToken)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = await RemarketingActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/remarketingActions/[REMARKETING_ACTION_ID]";
            // Make the request
            RemarketingAction response = await remarketingActionServiceClient.GetRemarketingActionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetRemarketingAction</summary>
        public void GetRemarketingActionResourceNames()
        {
            // Snippet: GetRemarketingAction(RemarketingActionName, CallSettings)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = RemarketingActionServiceClient.Create();
            // Initialize request argument(s)
            RemarketingActionName resourceName = RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]");
            // Make the request
            RemarketingAction response = remarketingActionServiceClient.GetRemarketingAction(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetRemarketingActionAsync</summary>
        public async Task GetRemarketingActionResourceNamesAsync()
        {
            // Snippet: GetRemarketingActionAsync(RemarketingActionName, CallSettings)
            // Additional: GetRemarketingActionAsync(RemarketingActionName, CancellationToken)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = await RemarketingActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemarketingActionName resourceName = RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]");
            // Make the request
            RemarketingAction response = await remarketingActionServiceClient.GetRemarketingActionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateRemarketingActions</summary>
        public void MutateRemarketingActionsRequestObject()
        {
            // Snippet: MutateRemarketingActions(MutateRemarketingActionsRequest, CallSettings)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = RemarketingActionServiceClient.Create();
            // Initialize request argument(s)
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new RemarketingActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateRemarketingActionsResponse response = remarketingActionServiceClient.MutateRemarketingActions(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRemarketingActionsAsync</summary>
        public async Task MutateRemarketingActionsRequestObjectAsync()
        {
            // Snippet: MutateRemarketingActionsAsync(MutateRemarketingActionsRequest, CallSettings)
            // Additional: MutateRemarketingActionsAsync(MutateRemarketingActionsRequest, CancellationToken)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = await RemarketingActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new RemarketingActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateRemarketingActionsResponse response = await remarketingActionServiceClient.MutateRemarketingActionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRemarketingActions</summary>
        public void MutateRemarketingActions()
        {
            // Snippet: MutateRemarketingActions(string, IEnumerable<RemarketingActionOperation>, CallSettings)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = RemarketingActionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<RemarketingActionOperation> operations = new RemarketingActionOperation[]
            {
                new RemarketingActionOperation(),
            };
            // Make the request
            MutateRemarketingActionsResponse response = remarketingActionServiceClient.MutateRemarketingActions(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateRemarketingActionsAsync</summary>
        public async Task MutateRemarketingActionsAsync()
        {
            // Snippet: MutateRemarketingActionsAsync(string, IEnumerable<RemarketingActionOperation>, CallSettings)
            // Additional: MutateRemarketingActionsAsync(string, IEnumerable<RemarketingActionOperation>, CancellationToken)
            // Create client
            RemarketingActionServiceClient remarketingActionServiceClient = await RemarketingActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<RemarketingActionOperation> operations = new RemarketingActionOperation[]
            {
                new RemarketingActionOperation(),
            };
            // Make the request
            MutateRemarketingActionsResponse response = await remarketingActionServiceClient.MutateRemarketingActionsAsync(customerId, operations);
            // End snippet
        }
    }
}
