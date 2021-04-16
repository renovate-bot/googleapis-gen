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

namespace Google.Cloud.BigQuery.DataTransfer.V1.Snippets
{
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDataTransferServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRuns()
        {
            // Snippet: ScheduleTransferRuns(string, Timestamp, Timestamp, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(parent, startTime, endTime);
            // End snippet
        }
    }
}
