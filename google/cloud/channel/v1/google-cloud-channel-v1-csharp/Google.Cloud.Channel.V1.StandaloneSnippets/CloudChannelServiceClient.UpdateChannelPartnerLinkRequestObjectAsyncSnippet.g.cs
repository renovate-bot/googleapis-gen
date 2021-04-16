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

namespace Google.Cloud.Channel.V1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudChannelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateChannelPartnerLinkAsync</summary>
        public async Task UpdateChannelPartnerLinkRequestObjectAsync()
        {
            // Snippet: UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest, CallSettings)
            // Additional: UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateChannelPartnerLinkRequest request = new UpdateChannelPartnerLinkRequest
            {
                Name = "",
                ChannelPartnerLink = new ChannelPartnerLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChannelPartnerLink response = await cloudChannelServiceClient.UpdateChannelPartnerLinkAsync(request);
            // End snippet
        }
    }
}
