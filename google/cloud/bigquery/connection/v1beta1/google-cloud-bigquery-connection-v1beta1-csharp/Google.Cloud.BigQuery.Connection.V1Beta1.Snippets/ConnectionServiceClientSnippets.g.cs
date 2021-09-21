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

namespace Google.Cloud.BigQuery.Connection.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedConnectionServiceClientSnippets
    {
        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionRequestObject()
        {
            // Snippet: CreateConnection(CreateConnectionRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
            };
            // Make the request
            Connection response = connectionServiceClient.CreateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionRequestObjectAsync()
        {
            // Snippet: CreateConnectionAsync(CreateConnectionRequest, CallSettings)
            // Additional: CreateConnectionAsync(CreateConnectionRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
            };
            // Make the request
            Connection response = await connectionServiceClient.CreateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnection()
        {
            // Snippet: CreateConnection(string, Connection, string, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = connectionServiceClient.CreateConnection(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionAsync()
        {
            // Snippet: CreateConnectionAsync(string, Connection, string, CallSettings)
            // Additional: CreateConnectionAsync(string, Connection, string, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = await connectionServiceClient.CreateConnectionAsync(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionResourceNames()
        {
            // Snippet: CreateConnection(LocationName, Connection, string, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = connectionServiceClient.CreateConnection(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionResourceNamesAsync()
        {
            // Snippet: CreateConnectionAsync(LocationName, Connection, string, CallSettings)
            // Additional: CreateConnectionAsync(LocationName, Connection, string, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = await connectionServiceClient.CreateConnectionAsync(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionRequestObject()
        {
            // Snippet: GetConnection(GetConnectionRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = connectionServiceClient.GetConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionRequestObjectAsync()
        {
            // Snippet: GetConnectionAsync(GetConnectionRequest, CallSettings)
            // Additional: GetConnectionAsync(GetConnectionRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = await connectionServiceClient.GetConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnection()
        {
            // Snippet: GetConnection(string, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = connectionServiceClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionAsync()
        {
            // Snippet: GetConnectionAsync(string, CallSettings)
            // Additional: GetConnectionAsync(string, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = await connectionServiceClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionResourceNames()
        {
            // Snippet: GetConnection(ConnectionName, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = connectionServiceClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionResourceNamesAsync()
        {
            // Snippet: GetConnectionAsync(ConnectionName, CallSettings)
            // Additional: GetConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = await connectionServiceClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsRequestObject()
        {
            // Snippet: ListConnections(ListConnectionsRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MaxResults = 0U,
                PageToken = "",
            };
            // Make the request
            ListConnectionsResponse response = connectionServiceClient.ListConnections(request);
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsRequestObjectAsync()
        {
            // Snippet: ListConnectionsAsync(ListConnectionsRequest, CallSettings)
            // Additional: ListConnectionsAsync(ListConnectionsRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MaxResults = 0U,
                PageToken = "",
            };
            // Make the request
            ListConnectionsResponse response = await connectionServiceClient.ListConnectionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnections()
        {
            // Snippet: ListConnections(string, uint?, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            uint? maxResults = 0U;
            // Make the request
            ListConnectionsResponse response = connectionServiceClient.ListConnections(parent, maxResults);
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsAsync()
        {
            // Snippet: ListConnectionsAsync(string, uint?, CallSettings)
            // Additional: ListConnectionsAsync(string, uint?, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            uint? maxResults = 0U;
            // Make the request
            ListConnectionsResponse response = await connectionServiceClient.ListConnectionsAsync(parent, maxResults);
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsResourceNames()
        {
            // Snippet: ListConnections(LocationName, uint?, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            uint? maxResults = 0U;
            // Make the request
            ListConnectionsResponse response = connectionServiceClient.ListConnections(parent, maxResults);
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsResourceNamesAsync()
        {
            // Snippet: ListConnectionsAsync(LocationName, uint?, CallSettings)
            // Additional: ListConnectionsAsync(LocationName, uint?, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            uint? maxResults = 0U;
            // Make the request
            ListConnectionsResponse response = await connectionServiceClient.ListConnectionsAsync(parent, maxResults);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionRequestObject()
        {
            // Snippet: UpdateConnection(UpdateConnectionRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Connection response = connectionServiceClient.UpdateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionRequestObjectAsync()
        {
            // Snippet: UpdateConnectionAsync(UpdateConnectionRequest, CallSettings)
            // Additional: UpdateConnectionAsync(UpdateConnectionRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Connection response = await connectionServiceClient.UpdateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnection()
        {
            // Snippet: UpdateConnection(string, Connection, FieldMask, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connection response = connectionServiceClient.UpdateConnection(name, connection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionAsync()
        {
            // Snippet: UpdateConnectionAsync(string, Connection, FieldMask, CallSettings)
            // Additional: UpdateConnectionAsync(string, Connection, FieldMask, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connection response = await connectionServiceClient.UpdateConnectionAsync(name, connection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionResourceNames()
        {
            // Snippet: UpdateConnection(ConnectionName, Connection, FieldMask, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connection response = connectionServiceClient.UpdateConnection(name, connection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionResourceNamesAsync()
        {
            // Snippet: UpdateConnectionAsync(ConnectionName, Connection, FieldMask, CallSettings)
            // Additional: UpdateConnectionAsync(ConnectionName, Connection, FieldMask, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connection response = await connectionServiceClient.UpdateConnectionAsync(name, connection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionCredential</summary>
        public void UpdateConnectionCredentialRequestObject()
        {
            // Snippet: UpdateConnectionCredential(UpdateConnectionCredentialRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            UpdateConnectionCredentialRequest request = new UpdateConnectionCredentialRequest
            {
                Name = "",
                Credential = new ConnectionCredential(),
            };
            // Make the request
            connectionServiceClient.UpdateConnectionCredential(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionCredentialAsync</summary>
        public async Task UpdateConnectionCredentialRequestObjectAsync()
        {
            // Snippet: UpdateConnectionCredentialAsync(UpdateConnectionCredentialRequest, CallSettings)
            // Additional: UpdateConnectionCredentialAsync(UpdateConnectionCredentialRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionCredentialRequest request = new UpdateConnectionCredentialRequest
            {
                Name = "",
                Credential = new ConnectionCredential(),
            };
            // Make the request
            await connectionServiceClient.UpdateConnectionCredentialAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionCredential</summary>
        public void UpdateConnectionCredential()
        {
            // Snippet: UpdateConnectionCredential(string, ConnectionCredential, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            ConnectionCredential credential = new ConnectionCredential();
            // Make the request
            connectionServiceClient.UpdateConnectionCredential(name, credential);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionCredentialAsync</summary>
        public async Task UpdateConnectionCredentialAsync()
        {
            // Snippet: UpdateConnectionCredentialAsync(string, ConnectionCredential, CallSettings)
            // Additional: UpdateConnectionCredentialAsync(string, ConnectionCredential, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            ConnectionCredential credential = new ConnectionCredential();
            // Make the request
            await connectionServiceClient.UpdateConnectionCredentialAsync(name, credential);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionRequestObject()
        {
            // Snippet: DeleteConnection(DeleteConnectionRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            connectionServiceClient.DeleteConnection(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionRequestObjectAsync()
        {
            // Snippet: DeleteConnectionAsync(DeleteConnectionRequest, CallSettings)
            // Additional: DeleteConnectionAsync(DeleteConnectionRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            await connectionServiceClient.DeleteConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnection()
        {
            // Snippet: DeleteConnection(string, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            connectionServiceClient.DeleteConnection(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionAsync()
        {
            // Snippet: DeleteConnectionAsync(string, CallSettings)
            // Additional: DeleteConnectionAsync(string, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            await connectionServiceClient.DeleteConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionResourceNames()
        {
            // Snippet: DeleteConnection(ConnectionName, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            connectionServiceClient.DeleteConnection(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionResourceNamesAsync()
        {
            // Snippet: DeleteConnectionAsync(ConnectionName, CallSettings)
            // Additional: DeleteConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            await connectionServiceClient.DeleteConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = connectionServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await connectionServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, GetPolicyOptions, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            GetPolicyOptions options = new GetPolicyOptions();
            // Make the request
            Policy response = connectionServiceClient.GetIamPolicy(resource, options);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, GetPolicyOptions, CallSettings)
            // Additional: GetIamPolicyAsync(string, GetPolicyOptions, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            GetPolicyOptions options = new GetPolicyOptions();
            // Make the request
            Policy response = await connectionServiceClient.GetIamPolicyAsync(resource, options);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, GetPolicyOptions, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            GetPolicyOptions options = new GetPolicyOptions();
            // Make the request
            Policy response = connectionServiceClient.GetIamPolicy(resource, options);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, GetPolicyOptions, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, GetPolicyOptions, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            GetPolicyOptions options = new GetPolicyOptions();
            // Make the request
            Policy response = await connectionServiceClient.GetIamPolicyAsync(resource, options);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = connectionServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await connectionServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = connectionServiceClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await connectionServiceClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = connectionServiceClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await connectionServiceClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = connectionServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await connectionServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = connectionServiceClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await connectionServiceClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = connectionServiceClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            ConnectionServiceClient connectionServiceClient = await ConnectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await connectionServiceClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
