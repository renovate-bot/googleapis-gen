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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedVersionsClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateVersionAsync</summary>
        public async Task UpdateVersionAsync()
        {
            // Snippet: UpdateVersionAsync(Version, FieldMask, CallSettings)
            // Additional: UpdateVersionAsync(Version, FieldMask, CancellationToken)
            // Create client
            VersionsClient versionsClient = await VersionsClient.CreateAsync();
            // Initialize request argument(s)
            Version version = new Version();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Version response = await versionsClient.UpdateVersionAsync(version, updateMask);
            // End snippet
        }
    }
}
