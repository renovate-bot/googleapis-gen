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
    using Google.Maps.PlayableLocations.V3;
    using Google.Maps.PlayableLocations.V3.Sample;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPlayableLocationsClientStandaloneSnippets
    {
        /// <summary>Snippet for SamplePlayableLocationsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SamplePlayableLocationsRequestObjectAsync()
        {
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
        }
    }
}
