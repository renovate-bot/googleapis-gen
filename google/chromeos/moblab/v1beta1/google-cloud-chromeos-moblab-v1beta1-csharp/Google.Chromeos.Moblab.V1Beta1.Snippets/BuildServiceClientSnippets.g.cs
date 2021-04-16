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

namespace Google.Chromeos.Moblab.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBuildServiceClientSnippets
    {
        /// <summary>Snippet for ListBuilds</summary>
        public void ListBuildsRequestObject()
        {
            // Snippet: ListBuilds(ListBuildsRequest, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            ListBuildsRequest request = new ListBuildsRequest
            {
                ParentAsModelName = ModelName.FromBuildTargetModel("[BUILD_TARGET]", "[MODEL]"),
                Filter = "",
                ReadMask = new FieldMask(),
                GroupBy = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListBuildsResponse, Build> response = buildServiceClient.ListBuilds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Build item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public async Task ListBuildsRequestObjectAsync()
        {
            // Snippet: ListBuildsAsync(ListBuildsRequest, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBuildsRequest request = new ListBuildsRequest
            {
                ParentAsModelName = ModelName.FromBuildTargetModel("[BUILD_TARGET]", "[MODEL]"),
                Filter = "",
                ReadMask = new FieldMask(),
                GroupBy = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListBuildsResponse, Build> response = buildServiceClient.ListBuildsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Build item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public void ListBuilds()
        {
            // Snippet: ListBuilds(string, string, int?, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            string parent = "buildTargets/[BUILD_TARGET]/models/[MODEL]";
            // Make the request
            PagedEnumerable<ListBuildsResponse, Build> response = buildServiceClient.ListBuilds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Build item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public async Task ListBuildsAsync()
        {
            // Snippet: ListBuildsAsync(string, string, int?, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "buildTargets/[BUILD_TARGET]/models/[MODEL]";
            // Make the request
            PagedAsyncEnumerable<ListBuildsResponse, Build> response = buildServiceClient.ListBuildsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Build item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public void ListBuildsResourceNames()
        {
            // Snippet: ListBuilds(ModelName, string, int?, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            ModelName parent = ModelName.FromBuildTargetModel("[BUILD_TARGET]", "[MODEL]");
            // Make the request
            PagedEnumerable<ListBuildsResponse, Build> response = buildServiceClient.ListBuilds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Build item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public async Task ListBuildsResourceNamesAsync()
        {
            // Snippet: ListBuildsAsync(ModelName, string, int?, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName parent = ModelName.FromBuildTargetModel("[BUILD_TARGET]", "[MODEL]");
            // Make the request
            PagedAsyncEnumerable<ListBuildsResponse, Build> response = buildServiceClient.ListBuildsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Build item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CheckBuildStageStatus</summary>
        public void CheckBuildStageStatusRequestObject()
        {
            // Snippet: CheckBuildStageStatus(CheckBuildStageStatusRequest, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            // Make the request
            CheckBuildStageStatusResponse response = buildServiceClient.CheckBuildStageStatus(request);
            // End snippet
        }

        /// <summary>Snippet for CheckBuildStageStatusAsync</summary>
        public async Task CheckBuildStageStatusRequestObjectAsync()
        {
            // Snippet: CheckBuildStageStatusAsync(CheckBuildStageStatusRequest, CallSettings)
            // Additional: CheckBuildStageStatusAsync(CheckBuildStageStatusRequest, CancellationToken)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            // Make the request
            CheckBuildStageStatusResponse response = await buildServiceClient.CheckBuildStageStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckBuildStageStatus</summary>
        public void CheckBuildStageStatus()
        {
            // Snippet: CheckBuildStageStatus(string, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            string name = "buildTargets/[BUILD_TARGET]/models/[MODEL]/builds/[BUILD]/artifacts/[ARTIFACT]";
            // Make the request
            CheckBuildStageStatusResponse response = buildServiceClient.CheckBuildStageStatus(name);
            // End snippet
        }

        /// <summary>Snippet for CheckBuildStageStatusAsync</summary>
        public async Task CheckBuildStageStatusAsync()
        {
            // Snippet: CheckBuildStageStatusAsync(string, CallSettings)
            // Additional: CheckBuildStageStatusAsync(string, CancellationToken)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "buildTargets/[BUILD_TARGET]/models/[MODEL]/builds/[BUILD]/artifacts/[ARTIFACT]";
            // Make the request
            CheckBuildStageStatusResponse response = await buildServiceClient.CheckBuildStageStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CheckBuildStageStatus</summary>
        public void CheckBuildStageStatusResourceNames()
        {
            // Snippet: CheckBuildStageStatus(BuildArtifactName, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            BuildArtifactName name = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
            // Make the request
            CheckBuildStageStatusResponse response = buildServiceClient.CheckBuildStageStatus(name);
            // End snippet
        }

        /// <summary>Snippet for CheckBuildStageStatusAsync</summary>
        public async Task CheckBuildStageStatusResourceNamesAsync()
        {
            // Snippet: CheckBuildStageStatusAsync(BuildArtifactName, CallSettings)
            // Additional: CheckBuildStageStatusAsync(BuildArtifactName, CancellationToken)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            BuildArtifactName name = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
            // Make the request
            CheckBuildStageStatusResponse response = await buildServiceClient.CheckBuildStageStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StageBuild</summary>
        public void StageBuildRequestObject()
        {
            // Snippet: StageBuild(StageBuildRequest, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            StageBuildRequest request = new StageBuildRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = buildServiceClient.StageBuild(request);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = buildServiceClient.PollOnceStageBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StageBuildAsync</summary>
        public async Task StageBuildRequestObjectAsync()
        {
            // Snippet: StageBuildAsync(StageBuildRequest, CallSettings)
            // Additional: StageBuildAsync(StageBuildRequest, CancellationToken)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            StageBuildRequest request = new StageBuildRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = await buildServiceClient.StageBuildAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = await buildServiceClient.PollOnceStageBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StageBuild</summary>
        public void StageBuild()
        {
            // Snippet: StageBuild(string, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            string name = "buildTargets/[BUILD_TARGET]/models/[MODEL]/builds/[BUILD]/artifacts/[ARTIFACT]";
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = buildServiceClient.StageBuild(name);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = buildServiceClient.PollOnceStageBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StageBuildAsync</summary>
        public async Task StageBuildAsync()
        {
            // Snippet: StageBuildAsync(string, CallSettings)
            // Additional: StageBuildAsync(string, CancellationToken)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "buildTargets/[BUILD_TARGET]/models/[MODEL]/builds/[BUILD]/artifacts/[ARTIFACT]";
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = await buildServiceClient.StageBuildAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = await buildServiceClient.PollOnceStageBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StageBuild</summary>
        public void StageBuildResourceNames()
        {
            // Snippet: StageBuild(BuildArtifactName, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            BuildArtifactName name = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = buildServiceClient.StageBuild(name);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = buildServiceClient.PollOnceStageBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StageBuildAsync</summary>
        public async Task StageBuildResourceNamesAsync()
        {
            // Snippet: StageBuildAsync(BuildArtifactName, CallSettings)
            // Additional: StageBuildAsync(BuildArtifactName, CancellationToken)
            // Create client
            BuildServiceClient buildServiceClient = await BuildServiceClient.CreateAsync();
            // Initialize request argument(s)
            BuildArtifactName name = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = await buildServiceClient.StageBuildAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = await buildServiceClient.PollOnceStageBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
