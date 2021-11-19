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

namespace Google.Streetview.Publish.V1.Snippets
{
    using Google.Streetview.Publish.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedStreetViewPublishServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for BatchGetPhotosAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task BatchGetPhotosAsync()
        {
            // Create client
            StreetViewPublishServiceClient streetViewPublishServiceClient = await StreetViewPublishServiceClient.CreateAsync();
            // Initialize request argument(s)
            PhotoView view = PhotoView.Basic;
            IEnumerable<string> photoIds = new string[] { "", };
            // Make the request
            BatchGetPhotosResponse response = await streetViewPublishServiceClient.BatchGetPhotosAsync(view, photoIds);
        }
    }
}
