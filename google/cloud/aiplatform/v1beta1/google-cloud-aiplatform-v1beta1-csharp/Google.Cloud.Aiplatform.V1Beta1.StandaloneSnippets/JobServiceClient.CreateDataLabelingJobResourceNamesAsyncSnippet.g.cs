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
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;

    public sealed partial class GeneratedJobServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateDataLabelingJobAsync</summary>
        public async Task CreateDataLabelingJobResourceNamesAsync()
        {
            // Snippet: CreateDataLabelingJobAsync(LocationName, DataLabelingJob, CallSettings)
            // Additional: CreateDataLabelingJobAsync(LocationName, DataLabelingJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataLabelingJob dataLabelingJob = new DataLabelingJob();
            // Make the request
            DataLabelingJob response = await jobServiceClient.CreateDataLabelingJobAsync(parent, dataLabelingJob);
            // End snippet
        }
    }
}
