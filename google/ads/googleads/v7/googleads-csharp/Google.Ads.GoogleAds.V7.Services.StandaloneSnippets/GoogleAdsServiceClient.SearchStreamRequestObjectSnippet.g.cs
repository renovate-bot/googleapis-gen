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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using Google.Ads.GoogleAds.V7.Enums;
    using Google.Ads.GoogleAds.V7.Services;
    using Google.Api.Gax.Grpc;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGoogleAdsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for SearchStream</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SearchStreamRequestObject()
        {
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            SearchGoogleAdsStreamRequest request = new SearchGoogleAdsStreamRequest
            {
                CustomerId = "",
                Query = "",
                SummaryRowSetting = SummaryRowSettingEnum.Types.SummaryRowSetting.Unspecified,
            };
            // Make the request, returning a streaming response
            GoogleAdsServiceClient.SearchStreamStream response = googleAdsServiceClient.SearchStream(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SearchGoogleAdsStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SearchGoogleAdsStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
}
