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

namespace Google.Cloud.WebSecurityScanner.V1Beta.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedWebSecurityScannerClientSnippets
    {
        /// <summary>Snippet for CreateScanConfig</summary>
        public void CreateScanConfigRequestObject()
        {
            // Snippet: CreateScanConfig(CreateScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            CreateScanConfigRequest request = new CreateScanConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ScanConfig = new ScanConfig(),
            };
            // Make the request
            ScanConfig response = webSecurityScannerClient.CreateScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateScanConfigAsync</summary>
        public async Task CreateScanConfigRequestObjectAsync()
        {
            // Snippet: CreateScanConfigAsync(CreateScanConfigRequest, CallSettings)
            // Additional: CreateScanConfigAsync(CreateScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            CreateScanConfigRequest request = new CreateScanConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ScanConfig = new ScanConfig(),
            };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.CreateScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateScanConfig</summary>
        public void CreateScanConfig()
        {
            // Snippet: CreateScanConfig(string, ScanConfig, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ScanConfig scanConfig = new ScanConfig();
            // Make the request
            ScanConfig response = webSecurityScannerClient.CreateScanConfig(parent, scanConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateScanConfigAsync</summary>
        public async Task CreateScanConfigAsync()
        {
            // Snippet: CreateScanConfigAsync(string, ScanConfig, CallSettings)
            // Additional: CreateScanConfigAsync(string, ScanConfig, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ScanConfig scanConfig = new ScanConfig();
            // Make the request
            ScanConfig response = await webSecurityScannerClient.CreateScanConfigAsync(parent, scanConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateScanConfig</summary>
        public void CreateScanConfigResourceNames()
        {
            // Snippet: CreateScanConfig(ProjectName, ScanConfig, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ScanConfig scanConfig = new ScanConfig();
            // Make the request
            ScanConfig response = webSecurityScannerClient.CreateScanConfig(parent, scanConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateScanConfigAsync</summary>
        public async Task CreateScanConfigResourceNamesAsync()
        {
            // Snippet: CreateScanConfigAsync(ProjectName, ScanConfig, CallSettings)
            // Additional: CreateScanConfigAsync(ProjectName, ScanConfig, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ScanConfig scanConfig = new ScanConfig();
            // Make the request
            ScanConfig response = await webSecurityScannerClient.CreateScanConfigAsync(parent, scanConfig);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfig</summary>
        public void DeleteScanConfigRequestObject()
        {
            // Snippet: DeleteScanConfig(DeleteScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            DeleteScanConfigRequest request = new DeleteScanConfigRequest
            {
                ScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            webSecurityScannerClient.DeleteScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfigAsync</summary>
        public async Task DeleteScanConfigRequestObjectAsync()
        {
            // Snippet: DeleteScanConfigAsync(DeleteScanConfigRequest, CallSettings)
            // Additional: DeleteScanConfigAsync(DeleteScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScanConfigRequest request = new DeleteScanConfigRequest
            {
                ScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            await webSecurityScannerClient.DeleteScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfig</summary>
        public void DeleteScanConfig()
        {
            // Snippet: DeleteScanConfig(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            webSecurityScannerClient.DeleteScanConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfigAsync</summary>
        public async Task DeleteScanConfigAsync()
        {
            // Snippet: DeleteScanConfigAsync(string, CallSettings)
            // Additional: DeleteScanConfigAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            await webSecurityScannerClient.DeleteScanConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfig</summary>
        public void DeleteScanConfigResourceNames()
        {
            // Snippet: DeleteScanConfig(ScanConfigName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanConfigName name = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            webSecurityScannerClient.DeleteScanConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfigAsync</summary>
        public async Task DeleteScanConfigResourceNamesAsync()
        {
            // Snippet: DeleteScanConfigAsync(ScanConfigName, CallSettings)
            // Additional: DeleteScanConfigAsync(ScanConfigName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanConfigName name = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            await webSecurityScannerClient.DeleteScanConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfig</summary>
        public void GetScanConfigRequestObject()
        {
            // Snippet: GetScanConfig(GetScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                ScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            ScanConfig response = webSecurityScannerClient.GetScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfigAsync</summary>
        public async Task GetScanConfigRequestObjectAsync()
        {
            // Snippet: GetScanConfigAsync(GetScanConfigRequest, CallSettings)
            // Additional: GetScanConfigAsync(GetScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                ScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.GetScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfig</summary>
        public void GetScanConfig()
        {
            // Snippet: GetScanConfig(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            ScanConfig response = webSecurityScannerClient.GetScanConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfigAsync</summary>
        public async Task GetScanConfigAsync()
        {
            // Snippet: GetScanConfigAsync(string, CallSettings)
            // Additional: GetScanConfigAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            ScanConfig response = await webSecurityScannerClient.GetScanConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfig</summary>
        public void GetScanConfigResourceNames()
        {
            // Snippet: GetScanConfig(ScanConfigName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanConfigName name = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            ScanConfig response = webSecurityScannerClient.GetScanConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfigAsync</summary>
        public async Task GetScanConfigResourceNamesAsync()
        {
            // Snippet: GetScanConfigAsync(ScanConfigName, CallSettings)
            // Additional: GetScanConfigAsync(ScanConfigName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanConfigName name = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            ScanConfig response = await webSecurityScannerClient.GetScanConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigs</summary>
        public void ListScanConfigsRequestObject()
        {
            // Snippet: ListScanConfigs(ListScanConfigsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListScanConfigsRequest request = new ListScanConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigsAsync</summary>
        public async Task ListScanConfigsRequestObjectAsync()
        {
            // Snippet: ListScanConfigsAsync(ListScanConfigsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListScanConfigsRequest request = new ListScanConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigs</summary>
        public void ListScanConfigs()
        {
            // Snippet: ListScanConfigs(string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigsAsync</summary>
        public async Task ListScanConfigsAsync()
        {
            // Snippet: ListScanConfigsAsync(string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigs</summary>
        public void ListScanConfigsResourceNames()
        {
            // Snippet: ListScanConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigsAsync</summary>
        public async Task ListScanConfigsResourceNamesAsync()
        {
            // Snippet: ListScanConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfig</summary>
        public void UpdateScanConfigRequestObject()
        {
            // Snippet: UpdateScanConfig(UpdateScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScanConfig response = webSecurityScannerClient.UpdateScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfigAsync</summary>
        public async Task UpdateScanConfigRequestObjectAsync()
        {
            // Snippet: UpdateScanConfigAsync(UpdateScanConfigRequest, CallSettings)
            // Additional: UpdateScanConfigAsync(UpdateScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.UpdateScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfig</summary>
        public void UpdateScanConfig()
        {
            // Snippet: UpdateScanConfig(ScanConfig, FieldMask, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanConfig scanConfig = new ScanConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ScanConfig response = webSecurityScannerClient.UpdateScanConfig(scanConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfigAsync</summary>
        public async Task UpdateScanConfigAsync()
        {
            // Snippet: UpdateScanConfigAsync(ScanConfig, FieldMask, CallSettings)
            // Additional: UpdateScanConfigAsync(ScanConfig, FieldMask, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanConfig scanConfig = new ScanConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ScanConfig response = await webSecurityScannerClient.UpdateScanConfigAsync(scanConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for StartScanRun</summary>
        public void StartScanRunRequestObject()
        {
            // Snippet: StartScanRun(StartScanRunRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            StartScanRunRequest request = new StartScanRunRequest
            {
                ScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            ScanRun response = webSecurityScannerClient.StartScanRun(request);
            // End snippet
        }

        /// <summary>Snippet for StartScanRunAsync</summary>
        public async Task StartScanRunRequestObjectAsync()
        {
            // Snippet: StartScanRunAsync(StartScanRunRequest, CallSettings)
            // Additional: StartScanRunAsync(StartScanRunRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            StartScanRunRequest request = new StartScanRunRequest
            {
                ScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            ScanRun response = await webSecurityScannerClient.StartScanRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartScanRun</summary>
        public void StartScanRun()
        {
            // Snippet: StartScanRun(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            ScanRun response = webSecurityScannerClient.StartScanRun(name);
            // End snippet
        }

        /// <summary>Snippet for StartScanRunAsync</summary>
        public async Task StartScanRunAsync()
        {
            // Snippet: StartScanRunAsync(string, CallSettings)
            // Additional: StartScanRunAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            ScanRun response = await webSecurityScannerClient.StartScanRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StartScanRun</summary>
        public void StartScanRunResourceNames()
        {
            // Snippet: StartScanRun(ScanConfigName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanConfigName name = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            ScanRun response = webSecurityScannerClient.StartScanRun(name);
            // End snippet
        }

        /// <summary>Snippet for StartScanRunAsync</summary>
        public async Task StartScanRunResourceNamesAsync()
        {
            // Snippet: StartScanRunAsync(ScanConfigName, CallSettings)
            // Additional: StartScanRunAsync(ScanConfigName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanConfigName name = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            ScanRun response = await webSecurityScannerClient.StartScanRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanRun</summary>
        public void GetScanRunRequestObject()
        {
            // Snippet: GetScanRun(GetScanRunRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetScanRunRequest request = new GetScanRunRequest
            {
                ScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            ScanRun response = webSecurityScannerClient.GetScanRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanRunAsync</summary>
        public async Task GetScanRunRequestObjectAsync()
        {
            // Snippet: GetScanRunAsync(GetScanRunRequest, CallSettings)
            // Additional: GetScanRunAsync(GetScanRunRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            GetScanRunRequest request = new GetScanRunRequest
            {
                ScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            ScanRun response = await webSecurityScannerClient.GetScanRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanRun</summary>
        public void GetScanRun()
        {
            // Snippet: GetScanRun(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            ScanRun response = webSecurityScannerClient.GetScanRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanRunAsync</summary>
        public async Task GetScanRunAsync()
        {
            // Snippet: GetScanRunAsync(string, CallSettings)
            // Additional: GetScanRunAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            ScanRun response = await webSecurityScannerClient.GetScanRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanRun</summary>
        public void GetScanRunResourceNames()
        {
            // Snippet: GetScanRun(ScanRunName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanRunName name = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ScanRun response = webSecurityScannerClient.GetScanRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanRunAsync</summary>
        public async Task GetScanRunResourceNamesAsync()
        {
            // Snippet: GetScanRunAsync(ScanRunName, CallSettings)
            // Additional: GetScanRunAsync(ScanRunName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName name = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ScanRun response = await webSecurityScannerClient.GetScanRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListScanRuns</summary>
        public void ListScanRunsRequestObject()
        {
            // Snippet: ListScanRuns(ListScanRunsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListScanRunsRequest request = new ListScanRunsRequest
            {
                ParentAsScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            PagedEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanRunsAsync</summary>
        public async Task ListScanRunsRequestObjectAsync()
        {
            // Snippet: ListScanRunsAsync(ListScanRunsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListScanRunsRequest request = new ListScanRunsRequest
            {
                ParentAsScanConfigName = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanRuns</summary>
        public void ListScanRuns()
        {
            // Snippet: ListScanRuns(string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            PagedEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanRunsAsync</summary>
        public async Task ListScanRunsAsync()
        {
            // Snippet: ListScanRunsAsync(string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanRuns</summary>
        public void ListScanRunsResourceNames()
        {
            // Snippet: ListScanRuns(ScanConfigName, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanConfigName parent = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            PagedEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanRunsAsync</summary>
        public async Task ListScanRunsResourceNamesAsync()
        {
            // Snippet: ListScanRunsAsync(ScanConfigName, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanConfigName parent = ScanConfigName.FromProjectScanConfig("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for StopScanRun</summary>
        public void StopScanRunRequestObject()
        {
            // Snippet: StopScanRun(StopScanRunRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            StopScanRunRequest request = new StopScanRunRequest
            {
                ScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            ScanRun response = webSecurityScannerClient.StopScanRun(request);
            // End snippet
        }

        /// <summary>Snippet for StopScanRunAsync</summary>
        public async Task StopScanRunRequestObjectAsync()
        {
            // Snippet: StopScanRunAsync(StopScanRunRequest, CallSettings)
            // Additional: StopScanRunAsync(StopScanRunRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            StopScanRunRequest request = new StopScanRunRequest
            {
                ScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            ScanRun response = await webSecurityScannerClient.StopScanRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StopScanRun</summary>
        public void StopScanRun()
        {
            // Snippet: StopScanRun(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            ScanRun response = webSecurityScannerClient.StopScanRun(name);
            // End snippet
        }

        /// <summary>Snippet for StopScanRunAsync</summary>
        public async Task StopScanRunAsync()
        {
            // Snippet: StopScanRunAsync(string, CallSettings)
            // Additional: StopScanRunAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            ScanRun response = await webSecurityScannerClient.StopScanRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StopScanRun</summary>
        public void StopScanRunResourceNames()
        {
            // Snippet: StopScanRun(ScanRunName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanRunName name = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ScanRun response = webSecurityScannerClient.StopScanRun(name);
            // End snippet
        }

        /// <summary>Snippet for StopScanRunAsync</summary>
        public async Task StopScanRunResourceNamesAsync()
        {
            // Snippet: StopScanRunAsync(ScanRunName, CallSettings)
            // Additional: StopScanRunAsync(ScanRunName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName name = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ScanRun response = await webSecurityScannerClient.StopScanRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrls</summary>
        public void ListCrawledUrlsRequestObject()
        {
            // Snippet: ListCrawledUrls(ListCrawledUrlsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListCrawledUrlsRequest request = new ListCrawledUrlsRequest
            {
                ParentAsScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CrawledUrl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCrawledUrlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrlsAsync</summary>
        public async Task ListCrawledUrlsRequestObjectAsync()
        {
            // Snippet: ListCrawledUrlsAsync(ListCrawledUrlsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListCrawledUrlsRequest request = new ListCrawledUrlsRequest
            {
                ParentAsScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrlsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CrawledUrl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCrawledUrlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrls</summary>
        public void ListCrawledUrls()
        {
            // Snippet: ListCrawledUrls(string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CrawledUrl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCrawledUrlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrlsAsync</summary>
        public async Task ListCrawledUrlsAsync()
        {
            // Snippet: ListCrawledUrlsAsync(string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CrawledUrl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCrawledUrlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrls</summary>
        public void ListCrawledUrlsResourceNames()
        {
            // Snippet: ListCrawledUrls(ScanRunName, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CrawledUrl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCrawledUrlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrlsAsync</summary>
        public async Task ListCrawledUrlsResourceNamesAsync()
        {
            // Snippet: ListCrawledUrlsAsync(ScanRunName, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CrawledUrl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCrawledUrlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFindingRequestObject()
        {
            // Snippet: GetFinding(GetFindingRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest
            {
                FindingName = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]"),
            };
            // Make the request
            Finding response = webSecurityScannerClient.GetFinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingRequestObjectAsync()
        {
            // Snippet: GetFindingAsync(GetFindingRequest, CallSettings)
            // Additional: GetFindingAsync(GetFindingRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest
            {
                FindingName = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]"),
            };
            // Make the request
            Finding response = await webSecurityScannerClient.GetFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFinding()
        {
            // Snippet: GetFinding(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]/findings/[FINDING]";
            // Make the request
            Finding response = webSecurityScannerClient.GetFinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingAsync()
        {
            // Snippet: GetFindingAsync(string, CallSettings)
            // Additional: GetFindingAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]/findings/[FINDING]";
            // Make the request
            Finding response = await webSecurityScannerClient.GetFindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFindingResourceNames()
        {
            // Snippet: GetFinding(FindingName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            FindingName name = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]");
            // Make the request
            Finding response = webSecurityScannerClient.GetFinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingResourceNamesAsync()
        {
            // Snippet: GetFindingAsync(FindingName, CallSettings)
            // Additional: GetFindingAsync(FindingName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            FindingName name = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]");
            // Make the request
            Finding response = await webSecurityScannerClient.GetFindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsRequestObject()
        {
            // Snippet: ListFindings(ListFindingsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsRequestObjectAsync()
        {
            // Snippet: ListFindingsAsync(ListFindingsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Finding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindings()
        {
            // Snippet: ListFindings(string, string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindings(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsAsync()
        {
            // Snippet: ListFindingsAsync(string, string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindingsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Finding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsResourceNames()
        {
            // Snippet: ListFindings(ScanRunName, string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindings(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsResourceNamesAsync()
        {
            // Snippet: ListFindingsAsync(ScanRunName, string, string, int?, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindingsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Finding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStats</summary>
        public void ListFindingTypeStatsRequestObject()
        {
            // Snippet: ListFindingTypeStats(ListFindingTypeStatsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListFindingTypeStatsRequest request = new ListFindingTypeStatsRequest
            {
                ParentAsScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            ListFindingTypeStatsResponse response = webSecurityScannerClient.ListFindingTypeStats(request);
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStatsAsync</summary>
        public async Task ListFindingTypeStatsRequestObjectAsync()
        {
            // Snippet: ListFindingTypeStatsAsync(ListFindingTypeStatsRequest, CallSettings)
            // Additional: ListFindingTypeStatsAsync(ListFindingTypeStatsRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingTypeStatsRequest request = new ListFindingTypeStatsRequest
            {
                ParentAsScanRunName = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]"),
            };
            // Make the request
            ListFindingTypeStatsResponse response = await webSecurityScannerClient.ListFindingTypeStatsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStats</summary>
        public void ListFindingTypeStats()
        {
            // Snippet: ListFindingTypeStats(string, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            ListFindingTypeStatsResponse response = webSecurityScannerClient.ListFindingTypeStats(parent);
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStatsAsync</summary>
        public async Task ListFindingTypeStatsAsync()
        {
            // Snippet: ListFindingTypeStatsAsync(string, CallSettings)
            // Additional: ListFindingTypeStatsAsync(string, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/scanConfigs/[SCAN_CONFIG]/scanRuns/[SCAN_RUN]";
            // Make the request
            ListFindingTypeStatsResponse response = await webSecurityScannerClient.ListFindingTypeStatsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStats</summary>
        public void ListFindingTypeStatsResourceNames()
        {
            // Snippet: ListFindingTypeStats(ScanRunName, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ListFindingTypeStatsResponse response = webSecurityScannerClient.ListFindingTypeStats(parent);
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStatsAsync</summary>
        public async Task ListFindingTypeStatsResourceNamesAsync()
        {
            // Snippet: ListFindingTypeStatsAsync(ScanRunName, CallSettings)
            // Additional: ListFindingTypeStatsAsync(ScanRunName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ListFindingTypeStatsResponse response = await webSecurityScannerClient.ListFindingTypeStatsAsync(parent);
            // End snippet
        }
    }
}
