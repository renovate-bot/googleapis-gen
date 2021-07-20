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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Osconfig.Agentendpoint.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAgentEndpointServiceClientTest
    {
        [xunit::FactAttribute]
        public void StartNextTaskRequestObject()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            StartNextTaskRequest request = new StartNextTaskRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
            };
            StartNextTaskResponse expectedResponse = new StartNextTaskResponse { Task = new Task(), };
            mockGrpcClient.Setup(x => x.StartNextTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            StartNextTaskResponse response = client.StartNextTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartNextTaskRequestObjectAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            StartNextTaskRequest request = new StartNextTaskRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
            };
            StartNextTaskResponse expectedResponse = new StartNextTaskResponse { Task = new Task(), };
            mockGrpcClient.Setup(x => x.StartNextTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StartNextTaskResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            StartNextTaskResponse responseCallSettings = await client.StartNextTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StartNextTaskResponse responseCancellationToken = await client.StartNextTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartNextTask()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            StartNextTaskRequest request = new StartNextTaskRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
            };
            StartNextTaskResponse expectedResponse = new StartNextTaskResponse { Task = new Task(), };
            mockGrpcClient.Setup(x => x.StartNextTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            StartNextTaskResponse response = client.StartNextTask(request.InstanceIdToken);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartNextTaskAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            StartNextTaskRequest request = new StartNextTaskRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
            };
            StartNextTaskResponse expectedResponse = new StartNextTaskResponse { Task = new Task(), };
            mockGrpcClient.Setup(x => x.StartNextTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StartNextTaskResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            StartNextTaskResponse responseCallSettings = await client.StartNextTaskAsync(request.InstanceIdToken, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StartNextTaskResponse responseCancellationToken = await client.StartNextTaskAsync(request.InstanceIdToken, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportTaskProgressRequestObject()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskProgressRequest request = new ReportTaskProgressRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
                ApplyPatchesTaskProgress = new ApplyPatchesTaskProgress(),
                ExecStepTaskProgress = new ExecStepTaskProgress(),
                ApplyConfigTaskProgress = new ApplyConfigTaskProgress(),
            };
            ReportTaskProgressResponse expectedResponse = new ReportTaskProgressResponse
            {
                TaskDirective = TaskDirective.Stop,
            };
            mockGrpcClient.Setup(x => x.ReportTaskProgress(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskProgressResponse response = client.ReportTaskProgress(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportTaskProgressRequestObjectAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskProgressRequest request = new ReportTaskProgressRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
                ApplyPatchesTaskProgress = new ApplyPatchesTaskProgress(),
                ExecStepTaskProgress = new ExecStepTaskProgress(),
                ApplyConfigTaskProgress = new ApplyConfigTaskProgress(),
            };
            ReportTaskProgressResponse expectedResponse = new ReportTaskProgressResponse
            {
                TaskDirective = TaskDirective.Stop,
            };
            mockGrpcClient.Setup(x => x.ReportTaskProgressAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportTaskProgressResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskProgressResponse responseCallSettings = await client.ReportTaskProgressAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportTaskProgressResponse responseCancellationToken = await client.ReportTaskProgressAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportTaskProgress()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskProgressRequest request = new ReportTaskProgressRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
            };
            ReportTaskProgressResponse expectedResponse = new ReportTaskProgressResponse
            {
                TaskDirective = TaskDirective.Stop,
            };
            mockGrpcClient.Setup(x => x.ReportTaskProgress(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskProgressResponse response = client.ReportTaskProgress(request.InstanceIdToken, request.TaskId, request.TaskType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportTaskProgressAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskProgressRequest request = new ReportTaskProgressRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
            };
            ReportTaskProgressResponse expectedResponse = new ReportTaskProgressResponse
            {
                TaskDirective = TaskDirective.Stop,
            };
            mockGrpcClient.Setup(x => x.ReportTaskProgressAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportTaskProgressResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskProgressResponse responseCallSettings = await client.ReportTaskProgressAsync(request.InstanceIdToken, request.TaskId, request.TaskType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportTaskProgressResponse responseCancellationToken = await client.ReportTaskProgressAsync(request.InstanceIdToken, request.TaskId, request.TaskType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportTaskCompleteRequestObject()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskCompleteRequest request = new ReportTaskCompleteRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
                ErrorMessage = "error_messaged73952bd",
                ApplyPatchesTaskOutput = new ApplyPatchesTaskOutput(),
                ExecStepTaskOutput = new ExecStepTaskOutput(),
                ApplyConfigTaskOutput = new ApplyConfigTaskOutput(),
            };
            ReportTaskCompleteResponse expectedResponse = new ReportTaskCompleteResponse { };
            mockGrpcClient.Setup(x => x.ReportTaskComplete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskCompleteResponse response = client.ReportTaskComplete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportTaskCompleteRequestObjectAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskCompleteRequest request = new ReportTaskCompleteRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
                ErrorMessage = "error_messaged73952bd",
                ApplyPatchesTaskOutput = new ApplyPatchesTaskOutput(),
                ExecStepTaskOutput = new ExecStepTaskOutput(),
                ApplyConfigTaskOutput = new ApplyConfigTaskOutput(),
            };
            ReportTaskCompleteResponse expectedResponse = new ReportTaskCompleteResponse { };
            mockGrpcClient.Setup(x => x.ReportTaskCompleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportTaskCompleteResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskCompleteResponse responseCallSettings = await client.ReportTaskCompleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportTaskCompleteResponse responseCancellationToken = await client.ReportTaskCompleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportTaskComplete()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskCompleteRequest request = new ReportTaskCompleteRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
                ErrorMessage = "error_messaged73952bd",
            };
            ReportTaskCompleteResponse expectedResponse = new ReportTaskCompleteResponse { };
            mockGrpcClient.Setup(x => x.ReportTaskComplete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskCompleteResponse response = client.ReportTaskComplete(request.InstanceIdToken, request.TaskId, request.TaskType, request.ErrorMessage);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportTaskCompleteAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportTaskCompleteRequest request = new ReportTaskCompleteRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                TaskId = "task_idc86c7457",
                TaskType = TaskType.ApplyConfigTask,
                ErrorMessage = "error_messaged73952bd",
            };
            ReportTaskCompleteResponse expectedResponse = new ReportTaskCompleteResponse { };
            mockGrpcClient.Setup(x => x.ReportTaskCompleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportTaskCompleteResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportTaskCompleteResponse responseCallSettings = await client.ReportTaskCompleteAsync(request.InstanceIdToken, request.TaskId, request.TaskType, request.ErrorMessage, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportTaskCompleteResponse responseCancellationToken = await client.ReportTaskCompleteAsync(request.InstanceIdToken, request.TaskId, request.TaskType, request.ErrorMessage, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RegisterAgentRequestObject()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            RegisterAgentRequest request = new RegisterAgentRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                AgentVersion = "agent_versioncd5f59a0",
                SupportedCapabilities =
                {
                    "supported_capabilities0e7e5a9c",
                },
                OsLongName = "os_long_namea52c92bd",
                OsShortName = "os_short_name9fb1ea45",
                OsVersion = "os_versionc4976daf",
                OsArchitecture = "os_architecture40da382d",
            };
            RegisterAgentResponse expectedResponse = new RegisterAgentResponse { };
            mockGrpcClient.Setup(x => x.RegisterAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            RegisterAgentResponse response = client.RegisterAgent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RegisterAgentRequestObjectAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            RegisterAgentRequest request = new RegisterAgentRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                AgentVersion = "agent_versioncd5f59a0",
                SupportedCapabilities =
                {
                    "supported_capabilities0e7e5a9c",
                },
                OsLongName = "os_long_namea52c92bd",
                OsShortName = "os_short_name9fb1ea45",
                OsVersion = "os_versionc4976daf",
                OsArchitecture = "os_architecture40da382d",
            };
            RegisterAgentResponse expectedResponse = new RegisterAgentResponse { };
            mockGrpcClient.Setup(x => x.RegisterAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegisterAgentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            RegisterAgentResponse responseCallSettings = await client.RegisterAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegisterAgentResponse responseCancellationToken = await client.RegisterAgentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RegisterAgent()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            RegisterAgentRequest request = new RegisterAgentRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                AgentVersion = "agent_versioncd5f59a0",
                SupportedCapabilities =
                {
                    "supported_capabilities0e7e5a9c",
                },
            };
            RegisterAgentResponse expectedResponse = new RegisterAgentResponse { };
            mockGrpcClient.Setup(x => x.RegisterAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            RegisterAgentResponse response = client.RegisterAgent(request.InstanceIdToken, request.AgentVersion, request.SupportedCapabilities);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RegisterAgentAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            RegisterAgentRequest request = new RegisterAgentRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                AgentVersion = "agent_versioncd5f59a0",
                SupportedCapabilities =
                {
                    "supported_capabilities0e7e5a9c",
                },
            };
            RegisterAgentResponse expectedResponse = new RegisterAgentResponse { };
            mockGrpcClient.Setup(x => x.RegisterAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegisterAgentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            RegisterAgentResponse responseCallSettings = await client.RegisterAgentAsync(request.InstanceIdToken, request.AgentVersion, request.SupportedCapabilities, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegisterAgentResponse responseCancellationToken = await client.RegisterAgentAsync(request.InstanceIdToken, request.AgentVersion, request.SupportedCapabilities, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportInventoryRequestObject()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportInventoryRequest request = new ReportInventoryRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                InventoryChecksum = "inventory_checksum9afabb58",
                Inventory = new Inventory(),
            };
            ReportInventoryResponse expectedResponse = new ReportInventoryResponse
            {
                ReportFullInventory = false,
            };
            mockGrpcClient.Setup(x => x.ReportInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportInventoryResponse response = client.ReportInventory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportInventoryRequestObjectAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportInventoryRequest request = new ReportInventoryRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                InventoryChecksum = "inventory_checksum9afabb58",
                Inventory = new Inventory(),
            };
            ReportInventoryResponse expectedResponse = new ReportInventoryResponse
            {
                ReportFullInventory = false,
            };
            mockGrpcClient.Setup(x => x.ReportInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportInventoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportInventoryResponse responseCallSettings = await client.ReportInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportInventoryResponse responseCancellationToken = await client.ReportInventoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportInventory()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportInventoryRequest request = new ReportInventoryRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                InventoryChecksum = "inventory_checksum9afabb58",
                Inventory = new Inventory(),
            };
            ReportInventoryResponse expectedResponse = new ReportInventoryResponse
            {
                ReportFullInventory = false,
            };
            mockGrpcClient.Setup(x => x.ReportInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportInventoryResponse response = client.ReportInventory(request.InstanceIdToken, request.InventoryChecksum, request.Inventory);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportInventoryAsync()
        {
            moq::Mock<AgentEndpointService.AgentEndpointServiceClient> mockGrpcClient = new moq::Mock<AgentEndpointService.AgentEndpointServiceClient>(moq::MockBehavior.Strict);
            ReportInventoryRequest request = new ReportInventoryRequest
            {
                InstanceIdToken = "instance_id_tokencc7e6ad0",
                InventoryChecksum = "inventory_checksum9afabb58",
                Inventory = new Inventory(),
            };
            ReportInventoryResponse expectedResponse = new ReportInventoryResponse
            {
                ReportFullInventory = false,
            };
            mockGrpcClient.Setup(x => x.ReportInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportInventoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentEndpointServiceClient client = new AgentEndpointServiceClientImpl(mockGrpcClient.Object, null);
            ReportInventoryResponse responseCallSettings = await client.ReportInventoryAsync(request.InstanceIdToken, request.InventoryChecksum, request.Inventory, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportInventoryResponse responseCancellationToken = await client.ReportInventoryAsync(request.InstanceIdToken, request.InventoryChecksum, request.Inventory, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
