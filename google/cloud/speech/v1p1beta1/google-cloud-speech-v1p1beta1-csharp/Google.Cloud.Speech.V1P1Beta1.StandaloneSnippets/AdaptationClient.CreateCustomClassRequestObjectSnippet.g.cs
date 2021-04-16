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

namespace Google.Cloud.Speech.V1P1Beta1.Snippets
{
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedAdaptationClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClassRequestObject()
        {
            // Snippet: CreateCustomClass(CreateCustomClassRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "",
                CustomClass = new CustomClass(),
            };
            // Make the request
            CustomClass response = adaptationClient.CreateCustomClass(request);
            // End snippet
        }
    }
}
