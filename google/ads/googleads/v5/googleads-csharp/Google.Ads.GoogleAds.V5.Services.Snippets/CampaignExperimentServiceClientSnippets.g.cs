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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Enums;
    using Google.Ads.GoogleAds.V5.Resources;
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignExperimentServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignExperiment</summary>
        public void GetCampaignExperimentRequestObject()
        {
            // Snippet: GetCampaignExperiment(GetCampaignExperimentRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            // Make the request
            CampaignExperiment response = campaignExperimentServiceClient.GetCampaignExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExperimentAsync</summary>
        public async Task GetCampaignExperimentRequestObjectAsync()
        {
            // Snippet: GetCampaignExperimentAsync(GetCampaignExperimentRequest, CallSettings)
            // Additional: GetCampaignExperimentAsync(GetCampaignExperimentRequest, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            // Make the request
            CampaignExperiment response = await campaignExperimentServiceClient.GetCampaignExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExperiment</summary>
        public void GetCampaignExperiment()
        {
            // Snippet: GetCampaignExperiment(string, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignExperiments/[CAMPAIGN_EXPERIMENT]";
            // Make the request
            CampaignExperiment response = campaignExperimentServiceClient.GetCampaignExperiment(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExperimentAsync</summary>
        public async Task GetCampaignExperimentAsync()
        {
            // Snippet: GetCampaignExperimentAsync(string, CallSettings)
            // Additional: GetCampaignExperimentAsync(string, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignExperiments/[CAMPAIGN_EXPERIMENT]";
            // Make the request
            CampaignExperiment response = await campaignExperimentServiceClient.GetCampaignExperimentAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExperiment</summary>
        public void GetCampaignExperimentResourceNames()
        {
            // Snippet: GetCampaignExperiment(CampaignExperimentName, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            CampaignExperimentName resourceName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]");
            // Make the request
            CampaignExperiment response = campaignExperimentServiceClient.GetCampaignExperiment(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExperimentAsync</summary>
        public async Task GetCampaignExperimentResourceNamesAsync()
        {
            // Snippet: GetCampaignExperimentAsync(CampaignExperimentName, CallSettings)
            // Additional: GetCampaignExperimentAsync(CampaignExperimentName, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignExperimentName resourceName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]");
            // Make the request
            CampaignExperiment response = await campaignExperimentServiceClient.GetCampaignExperimentAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for CreateCampaignExperiment</summary>
        public void CreateCampaignExperimentRequestObject()
        {
            // Snippet: CreateCampaignExperiment(CreateCampaignExperimentRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            CreateCampaignExperimentRequest request = new CreateCampaignExperimentRequest
            {
                CustomerId = "",
                CampaignExperiment = new CampaignExperiment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, CreateCampaignExperimentMetadata> response = campaignExperimentServiceClient.CreateCampaignExperiment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, CreateCampaignExperimentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, CreateCampaignExperimentMetadata> retrievedResponse = campaignExperimentServiceClient.PollOnceCreateCampaignExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCampaignExperimentAsync</summary>
        public async Task CreateCampaignExperimentRequestObjectAsync()
        {
            // Snippet: CreateCampaignExperimentAsync(CreateCampaignExperimentRequest, CallSettings)
            // Additional: CreateCampaignExperimentAsync(CreateCampaignExperimentRequest, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCampaignExperimentRequest request = new CreateCampaignExperimentRequest
            {
                CustomerId = "",
                CampaignExperiment = new CampaignExperiment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, CreateCampaignExperimentMetadata> response = await campaignExperimentServiceClient.CreateCampaignExperimentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, CreateCampaignExperimentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, CreateCampaignExperimentMetadata> retrievedResponse = await campaignExperimentServiceClient.PollOnceCreateCampaignExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCampaignExperiment</summary>
        public void CreateCampaignExperiment()
        {
            // Snippet: CreateCampaignExperiment(string, CampaignExperiment, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            CampaignExperiment campaignExperiment = new CampaignExperiment();
            // Make the request
            Operation<Empty, CreateCampaignExperimentMetadata> response = campaignExperimentServiceClient.CreateCampaignExperiment(customerId, campaignExperiment);

            // Poll until the returned long-running operation is complete
            Operation<Empty, CreateCampaignExperimentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, CreateCampaignExperimentMetadata> retrievedResponse = campaignExperimentServiceClient.PollOnceCreateCampaignExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCampaignExperimentAsync</summary>
        public async Task CreateCampaignExperimentAsync()
        {
            // Snippet: CreateCampaignExperimentAsync(string, CampaignExperiment, CallSettings)
            // Additional: CreateCampaignExperimentAsync(string, CampaignExperiment, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            CampaignExperiment campaignExperiment = new CampaignExperiment();
            // Make the request
            Operation<Empty, CreateCampaignExperimentMetadata> response = await campaignExperimentServiceClient.CreateCampaignExperimentAsync(customerId, campaignExperiment);

            // Poll until the returned long-running operation is complete
            Operation<Empty, CreateCampaignExperimentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, CreateCampaignExperimentMetadata> retrievedResponse = await campaignExperimentServiceClient.PollOnceCreateCampaignExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExperiments</summary>
        public void MutateCampaignExperimentsRequestObject()
        {
            // Snippet: MutateCampaignExperiments(MutateCampaignExperimentsRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignExperimentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignExperimentsResponse response = campaignExperimentServiceClient.MutateCampaignExperiments(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExperimentsAsync</summary>
        public async Task MutateCampaignExperimentsRequestObjectAsync()
        {
            // Snippet: MutateCampaignExperimentsAsync(MutateCampaignExperimentsRequest, CallSettings)
            // Additional: MutateCampaignExperimentsAsync(MutateCampaignExperimentsRequest, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignExperimentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignExperimentsResponse response = await campaignExperimentServiceClient.MutateCampaignExperimentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExperiments</summary>
        public void MutateCampaignExperiments()
        {
            // Snippet: MutateCampaignExperiments(string, IEnumerable<CampaignExperimentOperation>, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignExperimentOperation> operations = new CampaignExperimentOperation[]
            {
                new CampaignExperimentOperation(),
            };
            // Make the request
            MutateCampaignExperimentsResponse response = campaignExperimentServiceClient.MutateCampaignExperiments(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExperimentsAsync</summary>
        public async Task MutateCampaignExperimentsAsync()
        {
            // Snippet: MutateCampaignExperimentsAsync(string, IEnumerable<CampaignExperimentOperation>, CallSettings)
            // Additional: MutateCampaignExperimentsAsync(string, IEnumerable<CampaignExperimentOperation>, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignExperimentOperation> operations = new CampaignExperimentOperation[]
            {
                new CampaignExperimentOperation(),
            };
            // Make the request
            MutateCampaignExperimentsResponse response = await campaignExperimentServiceClient.MutateCampaignExperimentsAsync(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for GraduateCampaignExperiment</summary>
        public void GraduateCampaignExperimentRequestObject()
        {
            // Snippet: GraduateCampaignExperiment(GraduateCampaignExperimentRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = "",
                CampaignBudget = "",
            };
            // Make the request
            GraduateCampaignExperimentResponse response = campaignExperimentServiceClient.GraduateCampaignExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for GraduateCampaignExperimentAsync</summary>
        public async Task GraduateCampaignExperimentRequestObjectAsync()
        {
            // Snippet: GraduateCampaignExperimentAsync(GraduateCampaignExperimentRequest, CallSettings)
            // Additional: GraduateCampaignExperimentAsync(GraduateCampaignExperimentRequest, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = "",
                CampaignBudget = "",
            };
            // Make the request
            GraduateCampaignExperimentResponse response = await campaignExperimentServiceClient.GraduateCampaignExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GraduateCampaignExperiment</summary>
        public void GraduateCampaignExperiment()
        {
            // Snippet: GraduateCampaignExperiment(string, string, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string campaignExperiment = "";
            string campaignBudget = "";
            // Make the request
            GraduateCampaignExperimentResponse response = campaignExperimentServiceClient.GraduateCampaignExperiment(campaignExperiment, campaignBudget);
            // End snippet
        }

        /// <summary>Snippet for GraduateCampaignExperimentAsync</summary>
        public async Task GraduateCampaignExperimentAsync()
        {
            // Snippet: GraduateCampaignExperimentAsync(string, string, CallSettings)
            // Additional: GraduateCampaignExperimentAsync(string, string, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string campaignExperiment = "";
            string campaignBudget = "";
            // Make the request
            GraduateCampaignExperimentResponse response = await campaignExperimentServiceClient.GraduateCampaignExperimentAsync(campaignExperiment, campaignBudget);
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignExperiment</summary>
        public void PromoteCampaignExperimentRequestObject()
        {
            // Snippet: PromoteCampaignExperiment(PromoteCampaignExperimentRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            PromoteCampaignExperimentRequest request = new PromoteCampaignExperimentRequest
            {
                CampaignExperiment = "",
            };
            // Make the request
            Operation<Empty, Empty> response = campaignExperimentServiceClient.PromoteCampaignExperiment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = campaignExperimentServiceClient.PollOncePromoteCampaignExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignExperimentAsync</summary>
        public async Task PromoteCampaignExperimentRequestObjectAsync()
        {
            // Snippet: PromoteCampaignExperimentAsync(PromoteCampaignExperimentRequest, CallSettings)
            // Additional: PromoteCampaignExperimentAsync(PromoteCampaignExperimentRequest, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            PromoteCampaignExperimentRequest request = new PromoteCampaignExperimentRequest
            {
                CampaignExperiment = "",
            };
            // Make the request
            Operation<Empty, Empty> response = await campaignExperimentServiceClient.PromoteCampaignExperimentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await campaignExperimentServiceClient.PollOncePromoteCampaignExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignExperiment</summary>
        public void PromoteCampaignExperiment()
        {
            // Snippet: PromoteCampaignExperiment(string, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string campaignExperiment = "";
            // Make the request
            Operation<Empty, Empty> response = campaignExperimentServiceClient.PromoteCampaignExperiment(campaignExperiment);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = campaignExperimentServiceClient.PollOncePromoteCampaignExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignExperimentAsync</summary>
        public async Task PromoteCampaignExperimentAsync()
        {
            // Snippet: PromoteCampaignExperimentAsync(string, CallSettings)
            // Additional: PromoteCampaignExperimentAsync(string, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string campaignExperiment = "";
            // Make the request
            Operation<Empty, Empty> response = await campaignExperimentServiceClient.PromoteCampaignExperimentAsync(campaignExperiment);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await campaignExperimentServiceClient.PollOncePromoteCampaignExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EndCampaignExperiment</summary>
        public void EndCampaignExperimentRequestObject()
        {
            // Snippet: EndCampaignExperiment(EndCampaignExperimentRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = "",
            };
            // Make the request
            campaignExperimentServiceClient.EndCampaignExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for EndCampaignExperimentAsync</summary>
        public async Task EndCampaignExperimentRequestObjectAsync()
        {
            // Snippet: EndCampaignExperimentAsync(EndCampaignExperimentRequest, CallSettings)
            // Additional: EndCampaignExperimentAsync(EndCampaignExperimentRequest, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = "",
            };
            // Make the request
            await campaignExperimentServiceClient.EndCampaignExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EndCampaignExperiment</summary>
        public void EndCampaignExperiment()
        {
            // Snippet: EndCampaignExperiment(string, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string campaignExperiment = "";
            // Make the request
            campaignExperimentServiceClient.EndCampaignExperiment(campaignExperiment);
            // End snippet
        }

        /// <summary>Snippet for EndCampaignExperimentAsync</summary>
        public async Task EndCampaignExperimentAsync()
        {
            // Snippet: EndCampaignExperimentAsync(string, CallSettings)
            // Additional: EndCampaignExperimentAsync(string, CancellationToken)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string campaignExperiment = "";
            // Make the request
            await campaignExperimentServiceClient.EndCampaignExperimentAsync(campaignExperiment);
            // End snippet
        }

        /// <summary>Snippet for ListCampaignExperimentAsyncErrors</summary>
        public void ListCampaignExperimentAsyncErrorsRequestObject()
        {
            // Snippet: ListCampaignExperimentAsyncErrors(ListCampaignExperimentAsyncErrorsRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            ListCampaignExperimentAsyncErrorsRequest request = new ListCampaignExperimentAsyncErrorsRequest
            {
                ResourceNameAsCampaignExperimentName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            // Make the request
            PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, Status> response = campaignExperimentServiceClient.ListCampaignExperimentAsyncErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCampaignExperimentAsyncErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignExperimentAsyncErrors</summary>
        public async Task ListCampaignExperimentAsyncErrorsRequestObjectAsync()
        {
            // Snippet: ListCampaignExperimentAsyncErrorsAsync(ListCampaignExperimentAsyncErrorsRequest, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCampaignExperimentAsyncErrorsRequest request = new ListCampaignExperimentAsyncErrorsRequest
            {
                ResourceNameAsCampaignExperimentName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, Status> response = campaignExperimentServiceClient.ListCampaignExperimentAsyncErrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCampaignExperimentAsyncErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignExperimentAsyncErrors</summary>
        public void ListCampaignExperimentAsyncErrors()
        {
            // Snippet: ListCampaignExperimentAsyncErrors(string, string, int?, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignExperiments/[CAMPAIGN_EXPERIMENT]";
            // Make the request
            PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, Status> response = campaignExperimentServiceClient.ListCampaignExperimentAsyncErrors(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCampaignExperimentAsyncErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignExperimentAsyncErrors</summary>
        public async Task ListCampaignExperimentAsyncErrorsAsync()
        {
            // Snippet: ListCampaignExperimentAsyncErrorsAsync(string, string, int?, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignExperiments/[CAMPAIGN_EXPERIMENT]";
            // Make the request
            PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, Status> response = campaignExperimentServiceClient.ListCampaignExperimentAsyncErrorsAsync(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCampaignExperimentAsyncErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignExperimentAsyncErrors</summary>
        public void ListCampaignExperimentAsyncErrorsResourceNames()
        {
            // Snippet: ListCampaignExperimentAsyncErrors(CampaignExperimentName, string, int?, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = CampaignExperimentServiceClient.Create();
            // Initialize request argument(s)
            CampaignExperimentName resourceName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]");
            // Make the request
            PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, Status> response = campaignExperimentServiceClient.ListCampaignExperimentAsyncErrors(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCampaignExperimentAsyncErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignExperimentAsyncErrors</summary>
        public async Task ListCampaignExperimentAsyncErrorsResourceNamesAsync()
        {
            // Snippet: ListCampaignExperimentAsyncErrorsAsync(CampaignExperimentName, string, int?, CallSettings)
            // Create client
            CampaignExperimentServiceClient campaignExperimentServiceClient = await CampaignExperimentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignExperimentName resourceName = CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]");
            // Make the request
            PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, Status> response = campaignExperimentServiceClient.ListCampaignExperimentAsyncErrorsAsync(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCampaignExperimentAsyncErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
