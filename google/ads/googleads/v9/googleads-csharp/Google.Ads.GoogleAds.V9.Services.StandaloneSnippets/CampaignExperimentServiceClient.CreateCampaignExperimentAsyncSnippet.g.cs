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
    using Google.Ads.GoogleAds.V9.Services;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCampaignExperimentServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateCampaignExperimentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateCampaignExperimentAsync()
        {
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
        }
    }
}
