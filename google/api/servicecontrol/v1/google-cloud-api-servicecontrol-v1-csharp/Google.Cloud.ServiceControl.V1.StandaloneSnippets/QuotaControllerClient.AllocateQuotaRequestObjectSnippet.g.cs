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

namespace Google.Cloud.ServiceControl.V1.Snippets
{
    public sealed partial class GeneratedQuotaControllerClientStandaloneSnippets
    {
        /// <summary>Snippet for AllocateQuota</summary>
        public void AllocateQuotaRequestObject()
        {
            // Snippet: AllocateQuota(AllocateQuotaRequest, CallSettings)
            // Create client
            QuotaControllerClient quotaControllerClient = QuotaControllerClient.Create();
            // Initialize request argument(s)
            AllocateQuotaRequest request = new AllocateQuotaRequest
            {
                ServiceName = "",
                AllocateOperation = new QuotaOperation(),
                ServiceConfigId = "",
            };
            // Make the request
            AllocateQuotaResponse response = quotaControllerClient.AllocateQuota(request);
            // End snippet
        }
    }
}
