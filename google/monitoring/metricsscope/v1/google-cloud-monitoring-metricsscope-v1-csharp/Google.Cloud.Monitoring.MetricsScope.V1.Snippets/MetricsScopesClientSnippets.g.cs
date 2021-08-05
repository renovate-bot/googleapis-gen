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
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedMetricsScopesClientSnippets
    {
        /// <summary>Snippet for GetMetricsScope</summary>
        public void GetMetricsScopeRequestObject()
        {
            // Snippet: GetMetricsScope(GetMetricsScopeRequest, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            // Make the request
            MetricsScope response = metricsScopesClient.GetMetricsScope(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsScopeAsync</summary>
        public async Task GetMetricsScopeRequestObjectAsync()
        {
            // Snippet: GetMetricsScopeAsync(GetMetricsScopeRequest, CallSettings)
            // Additional: GetMetricsScopeAsync(GetMetricsScopeRequest, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            GetMetricsScopeRequest request = new GetMetricsScopeRequest
            {
                MetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
            };
            // Make the request
            MetricsScope response = await metricsScopesClient.GetMetricsScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsScope</summary>
        public void GetMetricsScope()
        {
            // Snippet: GetMetricsScope(string, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            string name = "locations/global/metricsScope/[METRICS_SCOPE]";
            // Make the request
            MetricsScope response = metricsScopesClient.GetMetricsScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsScopeAsync</summary>
        public async Task GetMetricsScopeAsync()
        {
            // Snippet: GetMetricsScopeAsync(string, CallSettings)
            // Additional: GetMetricsScopeAsync(string, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "locations/global/metricsScope/[METRICS_SCOPE]";
            // Make the request
            MetricsScope response = await metricsScopesClient.GetMetricsScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsScope</summary>
        public void GetMetricsScopeResourceNames()
        {
            // Snippet: GetMetricsScope(MetricsScopeName, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            MetricsScopeName name = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]");
            // Make the request
            MetricsScope response = metricsScopesClient.GetMetricsScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsScopeAsync</summary>
        public async Task GetMetricsScopeResourceNamesAsync()
        {
            // Snippet: GetMetricsScopeAsync(MetricsScopeName, CallSettings)
            // Additional: GetMetricsScopeAsync(MetricsScopeName, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            MetricsScopeName name = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]");
            // Make the request
            MetricsScope response = await metricsScopesClient.GetMetricsScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMetricsScopesByMonitoredProject</summary>
        public void ListMetricsScopesByMonitoredProjectRequestObject()
        {
            // Snippet: ListMetricsScopesByMonitoredProject(ListMetricsScopesByMonitoredProjectRequest, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            ListMetricsScopesByMonitoredProjectRequest request = new ListMetricsScopesByMonitoredProjectRequest
            {
                MonitoredResourceContainer = "",
            };
            // Make the request
            ListMetricsScopesByMonitoredProjectResponse response = metricsScopesClient.ListMetricsScopesByMonitoredProject(request);
            // End snippet
        }

        /// <summary>Snippet for ListMetricsScopesByMonitoredProjectAsync</summary>
        public async Task ListMetricsScopesByMonitoredProjectRequestObjectAsync()
        {
            // Snippet: ListMetricsScopesByMonitoredProjectAsync(ListMetricsScopesByMonitoredProjectRequest, CallSettings)
            // Additional: ListMetricsScopesByMonitoredProjectAsync(ListMetricsScopesByMonitoredProjectRequest, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            ListMetricsScopesByMonitoredProjectRequest request = new ListMetricsScopesByMonitoredProjectRequest
            {
                MonitoredResourceContainer = "",
            };
            // Make the request
            ListMetricsScopesByMonitoredProjectResponse response = await metricsScopesClient.ListMetricsScopesByMonitoredProjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMonitoredProject</summary>
        public void CreateMonitoredProjectRequestObject()
        {
            // Snippet: CreateMonitoredProject(CreateMonitoredProjectRequest, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            CreateMonitoredProjectRequest request = new CreateMonitoredProjectRequest
            {
                ParentAsMetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                MonitoredProject = new MonitoredProject(),
            };
            // Make the request
            Operation<MonitoredProject, OperationMetadata> response = metricsScopesClient.CreateMonitoredProject(request);

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
            // End snippet
        }

        /// <summary>Snippet for CreateMonitoredProjectAsync</summary>
        public async Task CreateMonitoredProjectRequestObjectAsync()
        {
            // Snippet: CreateMonitoredProjectAsync(CreateMonitoredProjectRequest, CallSettings)
            // Additional: CreateMonitoredProjectAsync(CreateMonitoredProjectRequest, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            CreateMonitoredProjectRequest request = new CreateMonitoredProjectRequest
            {
                ParentAsMetricsScopeName = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]"),
                MonitoredProject = new MonitoredProject(),
            };
            // Make the request
            Operation<MonitoredProject, OperationMetadata> response = await metricsScopesClient.CreateMonitoredProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredProject, OperationMetadata> retrievedResponse = await metricsScopesClient.PollOnceCreateMonitoredProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMonitoredProject</summary>
        public void CreateMonitoredProject()
        {
            // Snippet: CreateMonitoredProject(string, MonitoredProject, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            string parent = "locations/global/metricsScope/[METRICS_SCOPE]";
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
            // End snippet
        }

        /// <summary>Snippet for CreateMonitoredProjectAsync</summary>
        public async Task CreateMonitoredProjectAsync()
        {
            // Snippet: CreateMonitoredProjectAsync(string, MonitoredProject, CallSettings)
            // Additional: CreateMonitoredProjectAsync(string, MonitoredProject, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "locations/global/metricsScope/[METRICS_SCOPE]";
            MonitoredProject monitoredProject = new MonitoredProject();
            // Make the request
            Operation<MonitoredProject, OperationMetadata> response = await metricsScopesClient.CreateMonitoredProjectAsync(parent, monitoredProject);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredProject, OperationMetadata> retrievedResponse = await metricsScopesClient.PollOnceCreateMonitoredProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMonitoredProject</summary>
        public void CreateMonitoredProjectResourceNames()
        {
            // Snippet: CreateMonitoredProject(MetricsScopeName, MonitoredProject, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for CreateMonitoredProjectAsync</summary>
        public async Task CreateMonitoredProjectResourceNamesAsync()
        {
            // Snippet: CreateMonitoredProjectAsync(MetricsScopeName, MonitoredProject, CallSettings)
            // Additional: CreateMonitoredProjectAsync(MetricsScopeName, MonitoredProject, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            MetricsScopeName parent = MetricsScopeName.FromMetricsScope("[METRICS_SCOPE]");
            MonitoredProject monitoredProject = new MonitoredProject();
            // Make the request
            Operation<MonitoredProject, OperationMetadata> response = await metricsScopesClient.CreateMonitoredProjectAsync(parent, monitoredProject);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredProject, OperationMetadata> retrievedResponse = await metricsScopesClient.PollOnceCreateMonitoredProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMonitoredProject</summary>
        public void DeleteMonitoredProjectRequestObject()
        {
            // Snippet: DeleteMonitoredProject(DeleteMonitoredProjectRequest, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            DeleteMonitoredProjectRequest request = new DeleteMonitoredProjectRequest
            {
                MonitoredProjectName = MonitoredProjectName.FromMetricsScopeProject("[METRICS_SCOPE]", "[PROJECT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = metricsScopesClient.DeleteMonitoredProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = metricsScopesClient.PollOnceDeleteMonitoredProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMonitoredProjectAsync</summary>
        public async Task DeleteMonitoredProjectRequestObjectAsync()
        {
            // Snippet: DeleteMonitoredProjectAsync(DeleteMonitoredProjectRequest, CallSettings)
            // Additional: DeleteMonitoredProjectAsync(DeleteMonitoredProjectRequest, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMonitoredProjectRequest request = new DeleteMonitoredProjectRequest
            {
                MonitoredProjectName = MonitoredProjectName.FromMetricsScopeProject("[METRICS_SCOPE]", "[PROJECT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await metricsScopesClient.DeleteMonitoredProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await metricsScopesClient.PollOnceDeleteMonitoredProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMonitoredProject</summary>
        public void DeleteMonitoredProject()
        {
            // Snippet: DeleteMonitoredProject(string, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            string name = "locations/global/metricsScopes/[METRICS_SCOPE]/projects/[PROJECT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = metricsScopesClient.DeleteMonitoredProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = metricsScopesClient.PollOnceDeleteMonitoredProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMonitoredProjectAsync</summary>
        public async Task DeleteMonitoredProjectAsync()
        {
            // Snippet: DeleteMonitoredProjectAsync(string, CallSettings)
            // Additional: DeleteMonitoredProjectAsync(string, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "locations/global/metricsScopes/[METRICS_SCOPE]/projects/[PROJECT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await metricsScopesClient.DeleteMonitoredProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await metricsScopesClient.PollOnceDeleteMonitoredProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMonitoredProject</summary>
        public void DeleteMonitoredProjectResourceNames()
        {
            // Snippet: DeleteMonitoredProject(MonitoredProjectName, CallSettings)
            // Create client
            MetricsScopesClient metricsScopesClient = MetricsScopesClient.Create();
            // Initialize request argument(s)
            MonitoredProjectName name = MonitoredProjectName.FromMetricsScopeProject("[METRICS_SCOPE]", "[PROJECT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = metricsScopesClient.DeleteMonitoredProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = metricsScopesClient.PollOnceDeleteMonitoredProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMonitoredProjectAsync</summary>
        public async Task DeleteMonitoredProjectResourceNamesAsync()
        {
            // Snippet: DeleteMonitoredProjectAsync(MonitoredProjectName, CallSettings)
            // Additional: DeleteMonitoredProjectAsync(MonitoredProjectName, CancellationToken)
            // Create client
            MetricsScopesClient metricsScopesClient = await MetricsScopesClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredProjectName name = MonitoredProjectName.FromMetricsScopeProject("[METRICS_SCOPE]", "[PROJECT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await metricsScopesClient.DeleteMonitoredProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await metricsScopesClient.PollOnceDeleteMonitoredProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
