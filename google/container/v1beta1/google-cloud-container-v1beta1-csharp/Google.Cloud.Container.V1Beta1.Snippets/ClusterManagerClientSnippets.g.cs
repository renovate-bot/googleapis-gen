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
    using Google.Api.Gax;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedClusterManagerClientSnippets
    {
        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest { Parent = "", };
            // Make the request
            ListClustersResponse response = clusterManagerClient.ListClusters(request);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersRequestObjectAsync()
        {
            // Snippet: ListClustersAsync(ListClustersRequest, CallSettings)
            // Additional: ListClustersAsync(ListClustersRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest { Parent = "", };
            // Make the request
            ListClustersResponse response = await clusterManagerClient.ListClustersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters()
        {
            // Snippet: ListClusters(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
#pragma warning disable CS0612
            ListClustersResponse response = clusterManagerClient.ListClusters(projectId, zone);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync()
        {
            // Snippet: ListClustersAsync(string, string, CallSettings)
            // Additional: ListClustersAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
#pragma warning disable CS0612
            ListClustersResponse response = await clusterManagerClient.ListClustersAsync(projectId, zone);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterRequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest { Name = "", };
            // Make the request
            Cluster response = clusterManagerClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest { Name = "", };
            // Make the request
            Cluster response = await clusterManagerClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Cluster response = clusterManagerClient.GetCluster(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, string, string, CallSettings)
            // Additional: GetClusterAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Cluster response = await clusterManagerClient.GetClusterAsync(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                Cluster = new Cluster(),
                Parent = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CreateCluster(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterRequestObjectAsync()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest, CallSettings)
            // Additional: CreateClusterAsync(CreateClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                Cluster = new Cluster(),
                Parent = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CreateClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster()
        {
            // Snippet: CreateCluster(string, string, Cluster, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            Cluster cluster = new Cluster();
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.CreateCluster(projectId, zone, cluster);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(string, string, Cluster, CallSettings)
            // Additional: CreateClusterAsync(string, string, Cluster, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            Cluster cluster = new Cluster();
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.CreateClusterAsync(projectId, zone, cluster);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateClusterRequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                Update = new ClusterUpdate(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateCluster(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterRequestObjectAsync()
        {
            // Snippet: UpdateClusterAsync(UpdateClusterRequest, CallSettings)
            // Additional: UpdateClusterAsync(UpdateClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                Update = new ClusterUpdate(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster()
        {
            // Snippet: UpdateCluster(string, string, string, ClusterUpdate, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            ClusterUpdate update = new ClusterUpdate();
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.UpdateCluster(projectId, zone, clusterId, update);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync()
        {
            // Snippet: UpdateClusterAsync(string, string, string, ClusterUpdate, CallSettings)
            // Additional: UpdateClusterAsync(string, string, string, ClusterUpdate, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            ClusterUpdate update = new ClusterUpdate();
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.UpdateClusterAsync(projectId, zone, clusterId, update);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateNodePool</summary>
        public void UpdateNodePoolRequestObject()
        {
            // Snippet: UpdateNodePool(UpdateNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                NodeVersion = "",
                ImageType = "",
                Name = "",
                Locations = { "", },
                WorkloadMetadataConfig = new WorkloadMetadataConfig(),
                UpgradeSettings = new NodePool.Types.UpgradeSettings(),
                Tags = new NetworkTags(),
                Taints = new NodeTaints(),
                Labels = new NodeLabels(),
                LinuxNodeConfig = new LinuxNodeConfig(),
                KubeletConfig = new NodeKubeletConfig(),
                Gvnic = new VirtualNIC(),
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNodePoolAsync</summary>
        public async Task UpdateNodePoolRequestObjectAsync()
        {
            // Snippet: UpdateNodePoolAsync(UpdateNodePoolRequest, CallSettings)
            // Additional: UpdateNodePoolAsync(UpdateNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                NodeVersion = "",
                ImageType = "",
                Name = "",
                Locations = { "", },
                WorkloadMetadataConfig = new WorkloadMetadataConfig(),
                UpgradeSettings = new NodePool.Types.UpgradeSettings(),
                Tags = new NetworkTags(),
                Taints = new NodeTaints(),
                Labels = new NodeLabels(),
                LinuxNodeConfig = new LinuxNodeConfig(),
                KubeletConfig = new NodeKubeletConfig(),
                Gvnic = new VirtualNIC(),
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolAutoscaling</summary>
        public void SetNodePoolAutoscalingRequestObject()
        {
            // Snippet: SetNodePoolAutoscaling(SetNodePoolAutoscalingRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                Autoscaling = new NodePoolAutoscaling(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolAutoscaling(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolAutoscalingAsync</summary>
        public async Task SetNodePoolAutoscalingRequestObjectAsync()
        {
            // Snippet: SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest, CallSettings)
            // Additional: SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolAutoscalingRequest request = new SetNodePoolAutoscalingRequest
            {
                Autoscaling = new NodePoolAutoscaling(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolAutoscalingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingServiceRequestObject()
        {
            // Snippet: SetLoggingService(SetLoggingServiceRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                LoggingService = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLoggingService(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingServiceAsync</summary>
        public async Task SetLoggingServiceRequestObjectAsync()
        {
            // Snippet: SetLoggingServiceAsync(SetLoggingServiceRequest, CallSettings)
            // Additional: SetLoggingServiceAsync(SetLoggingServiceRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                LoggingService = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLoggingServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLoggingService</summary>
        public void SetLoggingService()
        {
            // Snippet: SetLoggingService(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string loggingService = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetLoggingService(projectId, zone, clusterId, loggingService);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLoggingServiceAsync</summary>
        public async Task SetLoggingServiceAsync()
        {
            // Snippet: SetLoggingServiceAsync(string, string, string, string, CallSettings)
            // Additional: SetLoggingServiceAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string loggingService = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetLoggingServiceAsync(projectId, zone, clusterId, loggingService);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringServiceRequestObject()
        {
            // Snippet: SetMonitoringService(SetMonitoringServiceRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                MonitoringService = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMonitoringService(request);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringServiceAsync</summary>
        public async Task SetMonitoringServiceRequestObjectAsync()
        {
            // Snippet: SetMonitoringServiceAsync(SetMonitoringServiceRequest, CallSettings)
            // Additional: SetMonitoringServiceAsync(SetMonitoringServiceRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                MonitoringService = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMonitoringServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringService</summary>
        public void SetMonitoringService()
        {
            // Snippet: SetMonitoringService(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string monitoringService = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetMonitoringService(projectId, zone, clusterId, monitoringService);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetMonitoringServiceAsync</summary>
        public async Task SetMonitoringServiceAsync()
        {
            // Snippet: SetMonitoringServiceAsync(string, string, string, string, CallSettings)
            // Additional: SetMonitoringServiceAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string monitoringService = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetMonitoringServiceAsync(projectId, zone, clusterId, monitoringService);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfigRequestObject()
        {
            // Snippet: SetAddonsConfig(SetAddonsConfigRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                AddonsConfig = new AddonsConfig(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetAddonsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfigAsync</summary>
        public async Task SetAddonsConfigRequestObjectAsync()
        {
            // Snippet: SetAddonsConfigAsync(SetAddonsConfigRequest, CallSettings)
            // Additional: SetAddonsConfigAsync(SetAddonsConfigRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                AddonsConfig = new AddonsConfig(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetAddonsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfig</summary>
        public void SetAddonsConfig()
        {
            // Snippet: SetAddonsConfig(string, string, string, AddonsConfig, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            AddonsConfig addonsConfig = new AddonsConfig();
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetAddonsConfig(projectId, zone, clusterId, addonsConfig);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetAddonsConfigAsync</summary>
        public async Task SetAddonsConfigAsync()
        {
            // Snippet: SetAddonsConfigAsync(string, string, string, AddonsConfig, CallSettings)
            // Additional: SetAddonsConfigAsync(string, string, string, AddonsConfig, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            AddonsConfig addonsConfig = new AddonsConfig();
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetAddonsConfigAsync(projectId, zone, clusterId, addonsConfig);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocationsRequestObject()
        {
            // Snippet: SetLocations(SetLocationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLocationsRequest request = new SetLocationsRequest
            {
                Locations = { "", },
                Name = "",
            };
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetLocations(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLocationsAsync</summary>
        public async Task SetLocationsRequestObjectAsync()
        {
            // Snippet: SetLocationsAsync(SetLocationsRequest, CallSettings)
            // Additional: SetLocationsAsync(SetLocationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLocationsRequest request = new SetLocationsRequest
            {
                Locations = { "", },
                Name = "",
            };
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetLocationsAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLocations</summary>
        public void SetLocations()
        {
            // Snippet: SetLocations(string, string, string, IEnumerable<string>, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            IEnumerable<string> locations = new string[] { "", };
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetLocations(projectId, zone, clusterId, locations);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLocationsAsync</summary>
        public async Task SetLocationsAsync()
        {
            // Snippet: SetLocationsAsync(string, string, string, IEnumerable<string>, CallSettings)
            // Additional: SetLocationsAsync(string, string, string, IEnumerable<string>, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            IEnumerable<string> locations = new string[] { "", };
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetLocationsAsync(projectId, zone, clusterId, locations);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMasterRequestObject()
        {
            // Snippet: UpdateMaster(UpdateMasterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                MasterVersion = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.UpdateMaster(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMasterAsync</summary>
        public async Task UpdateMasterRequestObjectAsync()
        {
            // Snippet: UpdateMasterAsync(UpdateMasterRequest, CallSettings)
            // Additional: UpdateMasterAsync(UpdateMasterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                MasterVersion = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateMasterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMaster</summary>
        public void UpdateMaster()
        {
            // Snippet: UpdateMaster(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string masterVersion = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.UpdateMaster(projectId, zone, clusterId, masterVersion);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateMasterAsync</summary>
        public async Task UpdateMasterAsync()
        {
            // Snippet: UpdateMasterAsync(string, string, string, string, CallSettings)
            // Additional: UpdateMasterAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string masterVersion = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.UpdateMasterAsync(projectId, zone, clusterId, masterVersion);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetMasterAuth</summary>
        public void SetMasterAuthRequestObject()
        {
            // Snippet: SetMasterAuth(SetMasterAuthRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                Action = SetMasterAuthRequest.Types.Action.Unknown,
                Update = new MasterAuth(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMasterAuth(request);
            // End snippet
        }

        /// <summary>Snippet for SetMasterAuthAsync</summary>
        public async Task SetMasterAuthRequestObjectAsync()
        {
            // Snippet: SetMasterAuthAsync(SetMasterAuthRequest, CallSettings)
            // Additional: SetMasterAuthAsync(SetMasterAuthRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMasterAuthRequest request = new SetMasterAuthRequest
            {
                Action = SetMasterAuthRequest.Types.Action.Unknown,
                Update = new MasterAuth(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMasterAuthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterRequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.DeleteCluster(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterRequestObjectAsync()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest, CallSettings)
            // Additional: DeleteClusterAsync(DeleteClusterRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.DeleteClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.DeleteCluster(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(string, string, string, CallSettings)
            // Additional: DeleteClusterAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.DeleteClusterAsync(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListOperations</summary>
        public void ListOperationsRequestObject()
        {
            // Snippet: ListOperations(ListOperationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest { Parent = "", };
            // Make the request
            ListOperationsResponse response = clusterManagerClient.ListOperations(request);
            // End snippet
        }

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsRequestObjectAsync()
        {
            // Snippet: ListOperationsAsync(ListOperationsRequest, CallSettings)
            // Additional: ListOperationsAsync(ListOperationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest { Parent = "", };
            // Make the request
            ListOperationsResponse response = await clusterManagerClient.ListOperationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListOperations</summary>
        public void ListOperations()
        {
            // Snippet: ListOperations(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
#pragma warning disable CS0612
            ListOperationsResponse response = clusterManagerClient.ListOperations(projectId, zone);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsAsync()
        {
            // Snippet: ListOperationsAsync(string, string, CallSettings)
            // Additional: ListOperationsAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
#pragma warning disable CS0612
            ListOperationsResponse response = await clusterManagerClient.ListOperationsAsync(projectId, zone);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperationRequestObject()
        {
            // Snippet: GetOperation(GetOperationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.GetOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationRequestObjectAsync()
        {
            // Snippet: GetOperationAsync(GetOperationRequest, CallSettings)
            // Additional: GetOperationAsync(GetOperationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.GetOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperation()
        {
            // Snippet: GetOperation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.GetOperation(projectId, zone, operationId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationAsync()
        {
            // Snippet: GetOperationAsync(string, string, string, CallSettings)
            // Additional: GetOperationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.GetOperationAsync(projectId, zone, operationId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperationRequestObject()
        {
            // Snippet: CancelOperation(CancelOperationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest { Name = "", };
            // Make the request
            clusterManagerClient.CancelOperation(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationRequestObjectAsync()
        {
            // Snippet: CancelOperationAsync(CancelOperationRequest, CallSettings)
            // Additional: CancelOperationAsync(CancelOperationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest { Name = "", };
            // Make the request
            await clusterManagerClient.CancelOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperation()
        {
            // Snippet: CancelOperation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
#pragma warning disable CS0612
            clusterManagerClient.CancelOperation(projectId, zone, operationId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationAsync()
        {
            // Snippet: CancelOperationAsync(string, string, string, CallSettings)
            // Additional: CancelOperationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string operationId = "";
            // Make the request
#pragma warning disable CS0612
            await clusterManagerClient.CancelOperationAsync(projectId, zone, operationId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfigRequestObject()
        {
            // Snippet: GetServerConfig(GetServerConfigRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetServerConfigRequest request = new GetServerConfigRequest { Name = "", };
            // Make the request
            ServerConfig response = clusterManagerClient.GetServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfigAsync</summary>
        public async Task GetServerConfigRequestObjectAsync()
        {
            // Snippet: GetServerConfigAsync(GetServerConfigRequest, CallSettings)
            // Additional: GetServerConfigAsync(GetServerConfigRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServerConfigRequest request = new GetServerConfigRequest { Name = "", };
            // Make the request
            ServerConfig response = await clusterManagerClient.GetServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerConfig</summary>
        public void GetServerConfig()
        {
            // Snippet: GetServerConfig(string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
#pragma warning disable CS0612
            ServerConfig response = clusterManagerClient.GetServerConfig(projectId, zone);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetServerConfigAsync</summary>
        public async Task GetServerConfigAsync()
        {
            // Snippet: GetServerConfigAsync(string, string, CallSettings)
            // Additional: GetServerConfigAsync(string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            // Make the request
#pragma warning disable CS0612
            ServerConfig response = await clusterManagerClient.GetServerConfigAsync(projectId, zone);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePoolsRequestObject()
        {
            // Snippet: ListNodePools(ListNodePoolsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListNodePoolsRequest request = new ListNodePoolsRequest { Parent = "", };
            // Make the request
            ListNodePoolsResponse response = clusterManagerClient.ListNodePools(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePoolsAsync</summary>
        public async Task ListNodePoolsRequestObjectAsync()
        {
            // Snippet: ListNodePoolsAsync(ListNodePoolsRequest, CallSettings)
            // Additional: ListNodePoolsAsync(ListNodePoolsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListNodePoolsRequest request = new ListNodePoolsRequest { Parent = "", };
            // Make the request
            ListNodePoolsResponse response = await clusterManagerClient.ListNodePoolsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodePools</summary>
        public void ListNodePools()
        {
            // Snippet: ListNodePools(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            ListNodePoolsResponse response = clusterManagerClient.ListNodePools(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListNodePoolsAsync</summary>
        public async Task ListNodePoolsAsync()
        {
            // Snippet: ListNodePoolsAsync(string, string, string, CallSettings)
            // Additional: ListNodePoolsAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            ListNodePoolsResponse response = await clusterManagerClient.ListNodePoolsAsync(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetJSONWebKeys</summary>
        public void GetJSONWebKeysRequestObject()
        {
            // Snippet: GetJSONWebKeys(GetJSONWebKeysRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetJSONWebKeysRequest request = new GetJSONWebKeysRequest { Parent = "", };
            // Make the request
            GetJSONWebKeysResponse response = clusterManagerClient.GetJSONWebKeys(request);
            // End snippet
        }

        /// <summary>Snippet for GetJSONWebKeysAsync</summary>
        public async Task GetJSONWebKeysRequestObjectAsync()
        {
            // Snippet: GetJSONWebKeysAsync(GetJSONWebKeysRequest, CallSettings)
            // Additional: GetJSONWebKeysAsync(GetJSONWebKeysRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetJSONWebKeysRequest request = new GetJSONWebKeysRequest { Parent = "", };
            // Make the request
            GetJSONWebKeysResponse response = await clusterManagerClient.GetJSONWebKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePoolRequestObject()
        {
            // Snippet: GetNodePool(GetNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            GetNodePoolRequest request = new GetNodePoolRequest { Name = "", };
            // Make the request
            NodePool response = clusterManagerClient.GetNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePoolAsync</summary>
        public async Task GetNodePoolRequestObjectAsync()
        {
            // Snippet: GetNodePoolAsync(GetNodePoolRequest, CallSettings)
            // Additional: GetNodePoolAsync(GetNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetNodePoolRequest request = new GetNodePoolRequest { Name = "", };
            // Make the request
            NodePool response = await clusterManagerClient.GetNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodePool</summary>
        public void GetNodePool()
        {
            // Snippet: GetNodePool(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            NodePool response = clusterManagerClient.GetNodePool(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetNodePoolAsync</summary>
        public async Task GetNodePoolAsync()
        {
            // Snippet: GetNodePoolAsync(string, string, string, string, CallSettings)
            // Additional: GetNodePoolAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            NodePool response = await clusterManagerClient.GetNodePoolAsync(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePoolRequestObject()
        {
            // Snippet: CreateNodePool(CreateNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                NodePool = new NodePool(),
                Parent = "",
            };
            // Make the request
            Operation response = clusterManagerClient.CreateNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePoolAsync</summary>
        public async Task CreateNodePoolRequestObjectAsync()
        {
            // Snippet: CreateNodePoolAsync(CreateNodePoolRequest, CallSettings)
            // Additional: CreateNodePoolAsync(CreateNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                NodePool = new NodePool(),
                Parent = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.CreateNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNodePool</summary>
        public void CreateNodePool()
        {
            // Snippet: CreateNodePool(string, string, string, NodePool, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NodePool nodePool = new NodePool();
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.CreateNodePool(projectId, zone, clusterId, nodePool);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateNodePoolAsync</summary>
        public async Task CreateNodePoolAsync()
        {
            // Snippet: CreateNodePoolAsync(string, string, string, NodePool, CallSettings)
            // Additional: CreateNodePoolAsync(string, string, string, NodePool, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NodePool nodePool = new NodePool();
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.CreateNodePoolAsync(projectId, zone, clusterId, nodePool);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePoolRequestObject()
        {
            // Snippet: DeleteNodePool(DeleteNodePoolRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            DeleteNodePoolRequest request = new DeleteNodePoolRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.DeleteNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePoolAsync</summary>
        public async Task DeleteNodePoolRequestObjectAsync()
        {
            // Snippet: DeleteNodePoolAsync(DeleteNodePoolRequest, CallSettings)
            // Additional: DeleteNodePoolAsync(DeleteNodePoolRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodePoolRequest request = new DeleteNodePoolRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.DeleteNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePool</summary>
        public void DeleteNodePool()
        {
            // Snippet: DeleteNodePool(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.DeleteNodePool(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteNodePoolAsync</summary>
        public async Task DeleteNodePoolAsync()
        {
            // Snippet: DeleteNodePoolAsync(string, string, string, string, CallSettings)
            // Additional: DeleteNodePoolAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.DeleteNodePoolAsync(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgradeRequestObject()
        {
            // Snippet: RollbackNodePoolUpgrade(RollbackNodePoolUpgradeRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.RollbackNodePoolUpgrade(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        public async Task RollbackNodePoolUpgradeRequestObjectAsync()
        {
            // Snippet: RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest, CallSettings)
            // Additional: RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgrade</summary>
        public void RollbackNodePoolUpgrade()
        {
            // Snippet: RollbackNodePoolUpgrade(string, string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.RollbackNodePoolUpgrade(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        public async Task RollbackNodePoolUpgradeAsync()
        {
            // Snippet: RollbackNodePoolUpgradeAsync(string, string, string, string, CallSettings)
            // Additional: RollbackNodePoolUpgradeAsync(string, string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagement</summary>
        public void SetNodePoolManagementRequestObject()
        {
            // Snippet: SetNodePoolManagement(SetNodePoolManagementRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                Management = new NodeManagement(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolManagement(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagementAsync</summary>
        public async Task SetNodePoolManagementRequestObjectAsync()
        {
            // Snippet: SetNodePoolManagementAsync(SetNodePoolManagementRequest, CallSettings)
            // Additional: SetNodePoolManagementAsync(SetNodePoolManagementRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolManagementRequest request = new SetNodePoolManagementRequest
            {
                Management = new NodeManagement(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolManagementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagement</summary>
        public void SetNodePoolManagement()
        {
            // Snippet: SetNodePoolManagement(string, string, string, string, NodeManagement, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            NodeManagement management = new NodeManagement();
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetNodePoolManagement(projectId, zone, clusterId, nodePoolId, management);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolManagementAsync</summary>
        public async Task SetNodePoolManagementAsync()
        {
            // Snippet: SetNodePoolManagementAsync(string, string, string, string, NodeManagement, CallSettings)
            // Additional: SetNodePoolManagementAsync(string, string, string, string, NodeManagement, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            NodeManagement management = new NodeManagement();
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetNodePoolManagementAsync(projectId, zone, clusterId, nodePoolId, management);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLabelsRequest request = new SetLabelsRequest
            {
                ResourceLabels = { { "", "" }, },
                LabelFingerprint = "",
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRequest request = new SetLabelsRequest
            {
                ResourceLabels = { { "", "" }, },
                LabelFingerprint = "",
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLabelsAsync(request);
            // End snippet
        }

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
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetLabels(projectId, zone, clusterId, resourceLabels, labelFingerprint);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, IDictionary<string,string>, string, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, IDictionary<string,string>, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            IDictionary<string, string> resourceLabels = new Dictionary<string, string> { { "", "" }, };
            string labelFingerprint = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetLabelsAsync(projectId, zone, clusterId, resourceLabels, labelFingerprint);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbacRequestObject()
        {
            // Snippet: SetLegacyAbac(SetLegacyAbacRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                Enabled = false,
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetLegacyAbac(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbacAsync</summary>
        public async Task SetLegacyAbacRequestObjectAsync()
        {
            // Snippet: SetLegacyAbacAsync(SetLegacyAbacRequest, CallSettings)
            // Additional: SetLegacyAbacAsync(SetLegacyAbacRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                Enabled = false,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetLegacyAbacAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbac</summary>
        public void SetLegacyAbac()
        {
            // Snippet: SetLegacyAbac(string, string, string, bool, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            bool enabled = false;
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetLegacyAbac(projectId, zone, clusterId, enabled);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetLegacyAbacAsync</summary>
        public async Task SetLegacyAbacAsync()
        {
            // Snippet: SetLegacyAbacAsync(string, string, string, bool, CallSettings)
            // Additional: SetLegacyAbacAsync(string, string, string, bool, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            bool enabled = false;
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetLegacyAbacAsync(projectId, zone, clusterId, enabled);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotationRequestObject()
        {
            // Snippet: StartIPRotation(StartIPRotationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                Name = "",
                RotateCredentials = false,
            };
            // Make the request
            Operation response = clusterManagerClient.StartIPRotation(request);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotationAsync</summary>
        public async Task StartIPRotationRequestObjectAsync()
        {
            // Snippet: StartIPRotationAsync(StartIPRotationRequest, CallSettings)
            // Additional: StartIPRotationAsync(StartIPRotationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                Name = "",
                RotateCredentials = false,
            };
            // Make the request
            Operation response = await clusterManagerClient.StartIPRotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartIPRotation</summary>
        public void StartIPRotation()
        {
            // Snippet: StartIPRotation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.StartIPRotation(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for StartIPRotationAsync</summary>
        public async Task StartIPRotationAsync()
        {
            // Snippet: StartIPRotationAsync(string, string, string, CallSettings)
            // Additional: StartIPRotationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.StartIPRotationAsync(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotationRequestObject()
        {
            // Snippet: CompleteIPRotation(CompleteIPRotationRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            CompleteIPRotationRequest request = new CompleteIPRotationRequest { Name = "", };
            // Make the request
            Operation response = clusterManagerClient.CompleteIPRotation(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotationAsync</summary>
        public async Task CompleteIPRotationRequestObjectAsync()
        {
            // Snippet: CompleteIPRotationAsync(CompleteIPRotationRequest, CallSettings)
            // Additional: CompleteIPRotationAsync(CompleteIPRotationRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CompleteIPRotationRequest request = new CompleteIPRotationRequest { Name = "", };
            // Make the request
            Operation response = await clusterManagerClient.CompleteIPRotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotation</summary>
        public void CompleteIPRotation()
        {
            // Snippet: CompleteIPRotation(string, string, string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.CompleteIPRotation(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CompleteIPRotationAsync</summary>
        public async Task CompleteIPRotationAsync()
        {
            // Snippet: CompleteIPRotationAsync(string, string, string, CallSettings)
            // Additional: CompleteIPRotationAsync(string, string, string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.CompleteIPRotationAsync(projectId, zone, clusterId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolSize</summary>
        public void SetNodePoolSizeRequestObject()
        {
            // Snippet: SetNodePoolSize(SetNodePoolSizeRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNodePoolSize(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodePoolSizeAsync</summary>
        public async Task SetNodePoolSizeRequestObjectAsync()
        {
            // Snippet: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CallSettings)
            // Additional: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolSizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicyRequestObject()
        {
            // Snippet: SetNetworkPolicy(SetNetworkPolicyRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                NetworkPolicy = new NetworkPolicy(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetNetworkPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicyAsync</summary>
        public async Task SetNetworkPolicyRequestObjectAsync()
        {
            // Snippet: SetNetworkPolicyAsync(SetNetworkPolicyRequest, CallSettings)
            // Additional: SetNetworkPolicyAsync(SetNetworkPolicyRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                NetworkPolicy = new NetworkPolicy(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNetworkPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicy</summary>
        public void SetNetworkPolicy()
        {
            // Snippet: SetNetworkPolicy(string, string, string, NetworkPolicy, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            // Make the request
#pragma warning disable CS0612
            Operation response = clusterManagerClient.SetNetworkPolicy(projectId, zone, clusterId, networkPolicy);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetNetworkPolicyAsync</summary>
        public async Task SetNetworkPolicyAsync()
        {
            // Snippet: SetNetworkPolicyAsync(string, string, string, NetworkPolicy, CallSettings)
            // Additional: SetNetworkPolicyAsync(string, string, string, NetworkPolicy, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.SetNetworkPolicyAsync(projectId, zone, clusterId, networkPolicy);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicy</summary>
        public void SetMaintenancePolicyRequestObject()
        {
            // Snippet: SetMaintenancePolicy(SetMaintenancePolicyRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MaintenancePolicy = new MaintenancePolicy(),
                Name = "",
            };
            // Make the request
            Operation response = clusterManagerClient.SetMaintenancePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicyAsync</summary>
        public async Task SetMaintenancePolicyRequestObjectAsync()
        {
            // Snippet: SetMaintenancePolicyAsync(SetMaintenancePolicyRequest, CallSettings)
            // Additional: SetMaintenancePolicyAsync(SetMaintenancePolicyRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "",
                Zone = "",
                ClusterId = "",
                MaintenancePolicy = new MaintenancePolicy(),
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetMaintenancePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicy</summary>
        public void SetMaintenancePolicy()
        {
            // Snippet: SetMaintenancePolicy(string, string, string, MaintenancePolicy, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            // Make the request
            Operation response = clusterManagerClient.SetMaintenancePolicy(projectId, zone, clusterId, maintenancePolicy);
            // End snippet
        }

        /// <summary>Snippet for SetMaintenancePolicyAsync</summary>
        public async Task SetMaintenancePolicyAsync()
        {
            // Snippet: SetMaintenancePolicyAsync(string, string, string, MaintenancePolicy, CallSettings)
            // Additional: SetMaintenancePolicyAsync(string, string, string, MaintenancePolicy, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            // Make the request
            Operation response = await clusterManagerClient.SetMaintenancePolicyAsync(projectId, zone, clusterId, maintenancePolicy);
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworks</summary>
        public void ListUsableSubnetworksRequestObject()
        {
            // Snippet: ListUsableSubnetworks(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> response = clusterManagerClient.ListUsableSubnetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UsableSubnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableSubnetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworksAsync</summary>
        public async Task ListUsableSubnetworksRequestObjectAsync()
        {
            // Snippet: ListUsableSubnetworksAsync(ListUsableSubnetworksRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> response = clusterManagerClient.ListUsableSubnetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UsableSubnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableSubnetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworks</summary>
        public void ListUsableSubnetworks()
        {
            // Snippet: ListUsableSubnetworks(string, string, int?, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> response = clusterManagerClient.ListUsableSubnetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UsableSubnetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableSubnetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableSubnetworksAsync</summary>
        public async Task ListUsableSubnetworksAsync()
        {
            // Snippet: ListUsableSubnetworksAsync(string, string, int?, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> response = clusterManagerClient.ListUsableSubnetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UsableSubnetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableSubnetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UsableSubnetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UsableSubnetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UsableSubnetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLocations</summary>
        public void ListLocationsRequestObject()
        {
            // Snippet: ListLocations(ListLocationsRequest, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            ListLocationsRequest request = new ListLocationsRequest { Parent = "", };
            // Make the request
            ListLocationsResponse response = clusterManagerClient.ListLocations(request);
            // End snippet
        }

        /// <summary>Snippet for ListLocationsAsync</summary>
        public async Task ListLocationsRequestObjectAsync()
        {
            // Snippet: ListLocationsAsync(ListLocationsRequest, CallSettings)
            // Additional: ListLocationsAsync(ListLocationsRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListLocationsRequest request = new ListLocationsRequest { Parent = "", };
            // Make the request
            ListLocationsResponse response = await clusterManagerClient.ListLocationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListLocations</summary>
        public void ListLocations()
        {
            // Snippet: ListLocations(string, CallSettings)
            // Create client
            ClusterManagerClient clusterManagerClient = ClusterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListLocationsResponse response = clusterManagerClient.ListLocations(parent);
            // End snippet
        }

        /// <summary>Snippet for ListLocationsAsync</summary>
        public async Task ListLocationsAsync()
        {
            // Snippet: ListLocationsAsync(string, CallSettings)
            // Additional: ListLocationsAsync(string, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListLocationsResponse response = await clusterManagerClient.ListLocationsAsync(parent);
            // End snippet
        }
    }
}
