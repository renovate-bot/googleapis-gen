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

namespace Google.Cloud.Aiplatform.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedSpecialistPoolServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetSpecialistPoolAsync</summary>
        public async Task GetSpecialistPoolResourceNamesAsync()
        {
            // Snippet: GetSpecialistPoolAsync(SpecialistPoolName, CallSettings)
            // Additional: GetSpecialistPoolAsync(SpecialistPoolName, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpecialistPoolName name = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]");
            // Make the request
            SpecialistPool response = await specialistPoolServiceClient.GetSpecialistPoolAsync(name);
            // End snippet
        }
    }
}
