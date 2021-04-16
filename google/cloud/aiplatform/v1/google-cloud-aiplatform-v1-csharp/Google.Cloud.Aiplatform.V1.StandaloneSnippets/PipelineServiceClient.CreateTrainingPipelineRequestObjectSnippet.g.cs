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

namespace Google.Cloud.Aiplatform.V1.Snippets
{
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedPipelineServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateTrainingPipeline</summary>
        public void CreateTrainingPipelineRequestObject()
        {
            // Snippet: CreateTrainingPipeline(CreateTrainingPipelineRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            // Make the request
            TrainingPipeline response = pipelineServiceClient.CreateTrainingPipeline(request);
            // End snippet
        }
    }
}
