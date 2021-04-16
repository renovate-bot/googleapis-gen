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

    public sealed partial class GeneratedTransitionRouteGroupsClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateTransitionRouteGroupAsync</summary>
        public async Task UpdateTransitionRouteGroupAsync()
        {
            // Snippet: UpdateTransitionRouteGroupAsync(TransitionRouteGroup, FieldMask, CallSettings)
            // Additional: UpdateTransitionRouteGroupAsync(TransitionRouteGroup, FieldMask, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.UpdateTransitionRouteGroupAsync(transitionRouteGroup, updateMask);
            // End snippet
        }
    }
}
