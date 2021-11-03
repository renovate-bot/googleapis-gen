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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomConversionGoalServiceClientSnippets
    {
        /// <summary>Snippet for MutateCustomConversionGoals</summary>
        public void MutateCustomConversionGoalsRequestObject()
        {
            // Snippet: MutateCustomConversionGoals(MutateCustomConversionGoalsRequest, CallSettings)
            // Create client
            CustomConversionGoalServiceClient customConversionGoalServiceClient = CustomConversionGoalServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomConversionGoalsRequest request = new MutateCustomConversionGoalsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomConversionGoalOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomConversionGoalsResponse response = customConversionGoalServiceClient.MutateCustomConversionGoals(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomConversionGoalsAsync</summary>
        public async Task MutateCustomConversionGoalsRequestObjectAsync()
        {
            // Snippet: MutateCustomConversionGoalsAsync(MutateCustomConversionGoalsRequest, CallSettings)
            // Additional: MutateCustomConversionGoalsAsync(MutateCustomConversionGoalsRequest, CancellationToken)
            // Create client
            CustomConversionGoalServiceClient customConversionGoalServiceClient = await CustomConversionGoalServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomConversionGoalsRequest request = new MutateCustomConversionGoalsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomConversionGoalOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomConversionGoalsResponse response = await customConversionGoalServiceClient.MutateCustomConversionGoalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomConversionGoals</summary>
        public void MutateCustomConversionGoals()
        {
            // Snippet: MutateCustomConversionGoals(string, IEnumerable<CustomConversionGoalOperation>, CallSettings)
            // Create client
            CustomConversionGoalServiceClient customConversionGoalServiceClient = CustomConversionGoalServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomConversionGoalOperation> operations = new CustomConversionGoalOperation[]
            {
                new CustomConversionGoalOperation(),
            };
            // Make the request
            MutateCustomConversionGoalsResponse response = customConversionGoalServiceClient.MutateCustomConversionGoals(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomConversionGoalsAsync</summary>
        public async Task MutateCustomConversionGoalsAsync()
        {
            // Snippet: MutateCustomConversionGoalsAsync(string, IEnumerable<CustomConversionGoalOperation>, CallSettings)
            // Additional: MutateCustomConversionGoalsAsync(string, IEnumerable<CustomConversionGoalOperation>, CancellationToken)
            // Create client
            CustomConversionGoalServiceClient customConversionGoalServiceClient = await CustomConversionGoalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomConversionGoalOperation> operations = new CustomConversionGoalOperation[]
            {
                new CustomConversionGoalOperation(),
            };
            // Make the request
            MutateCustomConversionGoalsResponse response = await customConversionGoalServiceClient.MutateCustomConversionGoalsAsync(customerId, operations);
            // End snippet
        }
    }
}
