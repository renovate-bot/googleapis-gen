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

namespace Google.Cloud.DataLabeling.V1Beta1.Snippets
{
    public sealed partial class GeneratedDataLabelingServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetAnnotationSpecSet</summary>
        public void GetAnnotationSpecSet()
        {
            // Snippet: GetAnnotationSpecSet(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/annotationSpecSets/[ANNOTATION_SPEC_SET]";
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.GetAnnotationSpecSet(name);
            // End snippet
        }
    }
}
