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

namespace Google.Ads.Admob.V1.Snippets
{
    using Google.Api.Gax.Grpc;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAdMobApiClientStandaloneSnippets
    {
        /// <summary>Snippet for GenerateNetworkReport</summary>
        public async Task GenerateNetworkReportRequestObject()
        {
            // Snippet: GenerateNetworkReport(GenerateNetworkReportRequest, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = AdMobApiClient.Create();
            // Initialize request argument(s)
            GenerateNetworkReportRequest request = new GenerateNetworkReportRequest
            {
                Parent = "",
                ReportSpec = new NetworkReportSpec(),
            };
            // Make the request, returning a streaming response
            AdMobApiClient.GenerateNetworkReportStream response = adMobApiClient.GenerateNetworkReport(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<GenerateNetworkReportResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                GenerateNetworkReportResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
