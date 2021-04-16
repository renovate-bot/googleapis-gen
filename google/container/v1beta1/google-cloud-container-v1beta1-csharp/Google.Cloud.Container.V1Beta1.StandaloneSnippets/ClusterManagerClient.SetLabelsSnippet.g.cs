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

namespace Google.Cloud.Container.V1Beta1.Snippets
{
    using System.Collections.Generic;

    public sealed partial class GeneratedClusterManagerClientStandaloneSnippets
    {
        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, IDictionary<string,string>, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            IDictionary<string, string> resourceLabels = new Dictionary<string, string> { { "", "" }, };
            string labelFingerprint = "";
            // Make the request
            Operation response = clusterManagerClient.SetLabels(projectId, zone, clusterId, resourceLabels, labelFingerprint);
            // End snippet
        }
    }
}
