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
    using Google.Ads.GoogleAds.V5.Resources;

    public sealed partial class GeneratedAdGroupCriterionLabelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetAdGroupCriterionLabel</summary>
        public void GetAdGroupCriterionLabel()
        {
            // Snippet: GetAdGroupCriterionLabel(string, CallSettings)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = AdGroupCriterionLabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroupCriterionLabels/[AD_GROUP_CRITERION_LABEL]";
            // Make the request
            AdGroupCriterionLabel response = adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabel(resourceName);
            // End snippet
        }
    }
}
