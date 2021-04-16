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

namespace Google.Maps.PlayableLocations.V3.Snippets
{
    using Google.Maps.PlayableLocations.V3.Sample;
    using Google.Maps.Unity;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPlayableLocationsClientSnippets
    {
        /// <summary>Snippet for SamplePlayableLocations</summary>
        public void SamplePlayableLocationsRequestObject()
        {
            // Snippet: SamplePlayableLocations(SamplePlayableLocationsRequest, CallSettings)
            // Create client
            PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.Create();
            // Initialize request argument(s)
            SamplePlayableLocationsRequest request = new SamplePlayableLocationsRequest
            {
                AreaFilter = new AreaFilter(),
                Criteria = { new Criterion(), },
            };
            // Make the request
            SamplePlayableLocationsResponse response = playableLocationsClient.SamplePlayableLocations(request);
            // End snippet
        }

        /// <summary>Snippet for SamplePlayableLocationsAsync</summary>
        public async Task SamplePlayableLocationsRequestObjectAsync()
        {
            // Snippet: SamplePlayableLocationsAsync(SamplePlayableLocationsRequest, CallSettings)
            // Additional: SamplePlayableLocationsAsync(SamplePlayableLocationsRequest, CancellationToken)
            // Create client
            PlayableLocationsClient playableLocationsClient = await PlayableLocationsClient.CreateAsync();
            // Initialize request argument(s)
            SamplePlayableLocationsRequest request = new SamplePlayableLocationsRequest
            {
                AreaFilter = new AreaFilter(),
                Criteria = { new Criterion(), },
            };
            // Make the request
            SamplePlayableLocationsResponse response = await playableLocationsClient.SamplePlayableLocationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LogPlayerReports</summary>
        public void LogPlayerReportsRequestObject()
        {
            // Snippet: LogPlayerReports(LogPlayerReportsRequest, CallSettings)
            // Create client
            PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.Create();
            // Initialize request argument(s)
            LogPlayerReportsRequest request = new LogPlayerReportsRequest
            {
                PlayerReports = { new PlayerReport(), },
                RequestId = "",
                ClientInfo = new ClientInfo(),
            };
            // Make the request
            LogPlayerReportsResponse response = playableLocationsClient.LogPlayerReports(request);
            // End snippet
        }

        /// <summary>Snippet for LogPlayerReportsAsync</summary>
        public async Task LogPlayerReportsRequestObjectAsync()
        {
            // Snippet: LogPlayerReportsAsync(LogPlayerReportsRequest, CallSettings)
            // Additional: LogPlayerReportsAsync(LogPlayerReportsRequest, CancellationToken)
            // Create client
            PlayableLocationsClient playableLocationsClient = await PlayableLocationsClient.CreateAsync();
            // Initialize request argument(s)
            LogPlayerReportsRequest request = new LogPlayerReportsRequest
            {
                PlayerReports = { new PlayerReport(), },
                RequestId = "",
                ClientInfo = new ClientInfo(),
            };
            // Make the request
            LogPlayerReportsResponse response = await playableLocationsClient.LogPlayerReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LogImpressions</summary>
        public void LogImpressionsRequestObject()
        {
            // Snippet: LogImpressions(LogImpressionsRequest, CallSettings)
            // Create client
            PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.Create();
            // Initialize request argument(s)
            LogImpressionsRequest request = new LogImpressionsRequest
            {
                Impressions = { new Impression(), },
                RequestId = "",
                ClientInfo = new ClientInfo(),
            };
            // Make the request
            LogImpressionsResponse response = playableLocationsClient.LogImpressions(request);
            // End snippet
        }

        /// <summary>Snippet for LogImpressionsAsync</summary>
        public async Task LogImpressionsRequestObjectAsync()
        {
            // Snippet: LogImpressionsAsync(LogImpressionsRequest, CallSettings)
            // Additional: LogImpressionsAsync(LogImpressionsRequest, CancellationToken)
            // Create client
            PlayableLocationsClient playableLocationsClient = await PlayableLocationsClient.CreateAsync();
            // Initialize request argument(s)
            LogImpressionsRequest request = new LogImpressionsRequest
            {
                Impressions = { new Impression(), },
                RequestId = "",
                ClientInfo = new ClientInfo(),
            };
            // Make the request
            LogImpressionsResponse response = await playableLocationsClient.LogImpressionsAsync(request);
            // End snippet
        }
    }
}
