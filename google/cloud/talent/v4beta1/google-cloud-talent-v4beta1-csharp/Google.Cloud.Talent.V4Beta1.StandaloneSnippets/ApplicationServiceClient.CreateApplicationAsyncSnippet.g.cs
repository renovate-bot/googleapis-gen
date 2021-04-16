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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedApplicationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationAsync()
        {
            // Snippet: CreateApplicationAsync(string, Application, CallSettings)
            // Additional: CreateApplicationAsync(string, Application, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(parent, application);
            // End snippet
        }
    }
}
