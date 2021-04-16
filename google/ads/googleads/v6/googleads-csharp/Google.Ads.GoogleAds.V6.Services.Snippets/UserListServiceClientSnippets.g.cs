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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedUserListServiceClientSnippets
    {
        /// <summary>Snippet for GetUserList</summary>
        public void GetUserListRequestObject()
        {
            // Snippet: GetUserList(GetUserListRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = UserListName.FromCustomerUserList("[CUSTOMER_ID]", "[USER_LIST_ID]"),
            };
            // Make the request
            UserList response = userListServiceClient.GetUserList(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserListAsync</summary>
        public async Task GetUserListRequestObjectAsync()
        {
            // Snippet: GetUserListAsync(GetUserListRequest, CallSettings)
            // Additional: GetUserListAsync(GetUserListRequest, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = UserListName.FromCustomerUserList("[CUSTOMER_ID]", "[USER_LIST_ID]"),
            };
            // Make the request
            UserList response = await userListServiceClient.GetUserListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserList</summary>
        public void GetUserList()
        {
            // Snippet: GetUserList(string, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/userLists/[USER_LIST_ID]";
            // Make the request
            UserList response = userListServiceClient.GetUserList(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserListAsync</summary>
        public async Task GetUserListAsync()
        {
            // Snippet: GetUserListAsync(string, CallSettings)
            // Additional: GetUserListAsync(string, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/userLists/[USER_LIST_ID]";
            // Make the request
            UserList response = await userListServiceClient.GetUserListAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserList</summary>
        public void GetUserListResourceNames()
        {
            // Snippet: GetUserList(UserListName, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            UserListName resourceName = UserListName.FromCustomerUserList("[CUSTOMER_ID]", "[USER_LIST_ID]");
            // Make the request
            UserList response = userListServiceClient.GetUserList(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserListAsync</summary>
        public async Task GetUserListResourceNamesAsync()
        {
            // Snippet: GetUserListAsync(UserListName, CallSettings)
            // Additional: GetUserListAsync(UserListName, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListName resourceName = UserListName.FromCustomerUserList("[CUSTOMER_ID]", "[USER_LIST_ID]");
            // Make the request
            UserList response = await userListServiceClient.GetUserListAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateUserLists</summary>
        public void MutateUserListsRequestObject()
        {
            // Snippet: MutateUserLists(MutateUserListsRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new UserListOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateUserListsResponse response = userListServiceClient.MutateUserLists(request);
            // End snippet
        }

        /// <summary>Snippet for MutateUserListsAsync</summary>
        public async Task MutateUserListsRequestObjectAsync()
        {
            // Snippet: MutateUserListsAsync(MutateUserListsRequest, CallSettings)
            // Additional: MutateUserListsAsync(MutateUserListsRequest, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new UserListOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateUserListsResponse response = await userListServiceClient.MutateUserListsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateUserLists</summary>
        public void MutateUserLists()
        {
            // Snippet: MutateUserLists(string, IEnumerable<UserListOperation>, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<UserListOperation> operations = new UserListOperation[]
            {
                new UserListOperation(),
            };
            // Make the request
            MutateUserListsResponse response = userListServiceClient.MutateUserLists(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateUserListsAsync</summary>
        public async Task MutateUserListsAsync()
        {
            // Snippet: MutateUserListsAsync(string, IEnumerable<UserListOperation>, CallSettings)
            // Additional: MutateUserListsAsync(string, IEnumerable<UserListOperation>, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<UserListOperation> operations = new UserListOperation[]
            {
                new UserListOperation(),
            };
            // Make the request
            MutateUserListsResponse response = await userListServiceClient.MutateUserListsAsync(customerId, operations);
            // End snippet
        }
    }
}
