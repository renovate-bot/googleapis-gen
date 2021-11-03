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
    public sealed class GeneratedCustomerUserAccessInvitationServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerUserAccessInvitation</summary>
        public void GetCustomerUserAccessInvitationRequestObject()
        {
            // Snippet: GetCustomerUserAccessInvitation(GetCustomerUserAccessInvitationRequest, CallSettings)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = CustomerUserAccessInvitationServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            // Make the request
            CustomerUserAccessInvitation response = customerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitation(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessInvitationAsync</summary>
        public async Task GetCustomerUserAccessInvitationRequestObjectAsync()
        {
            // Snippet: GetCustomerUserAccessInvitationAsync(GetCustomerUserAccessInvitationRequest, CallSettings)
            // Additional: GetCustomerUserAccessInvitationAsync(GetCustomerUserAccessInvitationRequest, CancellationToken)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = await CustomerUserAccessInvitationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            // Make the request
            CustomerUserAccessInvitation response = await customerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessInvitation</summary>
        public void GetCustomerUserAccessInvitation()
        {
            // Snippet: GetCustomerUserAccessInvitation(string, CallSettings)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = CustomerUserAccessInvitationServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerUserAccessInvitations/[INVITATION_ID]";
            // Make the request
            CustomerUserAccessInvitation response = customerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessInvitationAsync</summary>
        public async Task GetCustomerUserAccessInvitationAsync()
        {
            // Snippet: GetCustomerUserAccessInvitationAsync(string, CallSettings)
            // Additional: GetCustomerUserAccessInvitationAsync(string, CancellationToken)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = await CustomerUserAccessInvitationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerUserAccessInvitations/[INVITATION_ID]";
            // Make the request
            CustomerUserAccessInvitation response = await customerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessInvitation</summary>
        public void GetCustomerUserAccessInvitationResourceNames()
        {
            // Snippet: GetCustomerUserAccessInvitation(CustomerUserAccessInvitationName, CallSettings)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = CustomerUserAccessInvitationServiceClient.Create();
            // Initialize request argument(s)
            CustomerUserAccessInvitationName resourceName = CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]");
            // Make the request
            CustomerUserAccessInvitation response = customerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessInvitationAsync</summary>
        public async Task GetCustomerUserAccessInvitationResourceNamesAsync()
        {
            // Snippet: GetCustomerUserAccessInvitationAsync(CustomerUserAccessInvitationName, CallSettings)
            // Additional: GetCustomerUserAccessInvitationAsync(CustomerUserAccessInvitationName, CancellationToken)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = await CustomerUserAccessInvitationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerUserAccessInvitationName resourceName = CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]");
            // Make the request
            CustomerUserAccessInvitation response = await customerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccessInvitation</summary>
        public void MutateCustomerUserAccessInvitationRequestObject()
        {
            // Snippet: MutateCustomerUserAccessInvitation(MutateCustomerUserAccessInvitationRequest, CallSettings)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = CustomerUserAccessInvitationServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerUserAccessInvitationRequest request = new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = "",
                Operation = new CustomerUserAccessInvitationOperation(),
            };
            // Make the request
            MutateCustomerUserAccessInvitationResponse response = customerUserAccessInvitationServiceClient.MutateCustomerUserAccessInvitation(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccessInvitationAsync</summary>
        public async Task MutateCustomerUserAccessInvitationRequestObjectAsync()
        {
            // Snippet: MutateCustomerUserAccessInvitationAsync(MutateCustomerUserAccessInvitationRequest, CallSettings)
            // Additional: MutateCustomerUserAccessInvitationAsync(MutateCustomerUserAccessInvitationRequest, CancellationToken)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = await CustomerUserAccessInvitationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerUserAccessInvitationRequest request = new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = "",
                Operation = new CustomerUserAccessInvitationOperation(),
            };
            // Make the request
            MutateCustomerUserAccessInvitationResponse response = await customerUserAccessInvitationServiceClient.MutateCustomerUserAccessInvitationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccessInvitation</summary>
        public void MutateCustomerUserAccessInvitation()
        {
            // Snippet: MutateCustomerUserAccessInvitation(string, CustomerUserAccessInvitationOperation, CallSettings)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = CustomerUserAccessInvitationServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            CustomerUserAccessInvitationOperation operation = new CustomerUserAccessInvitationOperation();
            // Make the request
            MutateCustomerUserAccessInvitationResponse response = customerUserAccessInvitationServiceClient.MutateCustomerUserAccessInvitation(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccessInvitationAsync</summary>
        public async Task MutateCustomerUserAccessInvitationAsync()
        {
            // Snippet: MutateCustomerUserAccessInvitationAsync(string, CustomerUserAccessInvitationOperation, CallSettings)
            // Additional: MutateCustomerUserAccessInvitationAsync(string, CustomerUserAccessInvitationOperation, CancellationToken)
            // Create client
            CustomerUserAccessInvitationServiceClient customerUserAccessInvitationServiceClient = await CustomerUserAccessInvitationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            CustomerUserAccessInvitationOperation operation = new CustomerUserAccessInvitationOperation();
            // Make the request
            MutateCustomerUserAccessInvitationResponse response = await customerUserAccessInvitationServiceClient.MutateCustomerUserAccessInvitationAsync(customerId, operation);
            // End snippet
        }
    }
}
