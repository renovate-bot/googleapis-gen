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

namespace Google.Cloud.Monitoring.MetricsScope.V1.Snippets
{
    using Google.Cloud.Monitoring.MetricsScope.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedMetricsScopesClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateMonitoredProject</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateMonitoredProjectResourceNames()
        {
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            MetricsScopeName parent = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]");
            MonitoredProject monitoredProject = new MonitoredProject();
            // Make the request
            Operation<MonitoredProject, OperationMetadata> response = metricsScopesClient.CreateMonitoredProject(parent, monitoredProject);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredProject, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredProject, OperationMetadata> retrievedResponse = metricsScopesClient.PollOnceCreateMonitoredProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredProject retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
