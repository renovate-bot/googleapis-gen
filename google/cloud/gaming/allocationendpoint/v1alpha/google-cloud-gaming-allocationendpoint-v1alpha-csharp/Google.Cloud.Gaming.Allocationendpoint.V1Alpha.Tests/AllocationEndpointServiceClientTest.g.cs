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

namespace Google.Cloud.Gaming.Allocationendpoint.V1Alpha.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAllocationEndpointServiceClientTest
    {
        [xunit::FactAttribute]
        public void AllocateRequestObject()
        {
            moq::Mock<AllocationEndpointService.AllocationEndpointServiceClient> mockGrpcClient = new moq::Mock<AllocationEndpointService.AllocationEndpointServiceClient>(moq::MockBehavior.Strict);
            AllocationRequest request = new AllocationRequest
            {
                Realm = "realmf77e4bb9",
                DefaultGameServerDeployment = "default_game_server_deploymentbc552ce8",
                GameServerSelectors =
                {
                    new GameServerSelector(),
                },
                Metadata = new MetaPatch(),
            };
            AllocationResponse expectedResponse = new AllocationResponse
            {
                GameServerName = "game_server_name74be9a40",
                Ports =
                {
                    new AllocationResponse.Types.GameServerStatusPort(),
                },
                Address = "address04984d88",
                NodeName = "node_name215544e2",
                GameServerClusterName = "game_server_cluster_name1d66cd90",
                DeploymentName = "deployment_name8d1f3bfe",
            };
            mockGrpcClient.Setup(x => x.Allocate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AllocationEndpointServiceClient client = new AllocationEndpointServiceClientImpl(mockGrpcClient.Object, null);
            AllocationResponse response = client.Allocate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AllocateRequestObjectAsync()
        {
            moq::Mock<AllocationEndpointService.AllocationEndpointServiceClient> mockGrpcClient = new moq::Mock<AllocationEndpointService.AllocationEndpointServiceClient>(moq::MockBehavior.Strict);
            AllocationRequest request = new AllocationRequest
            {
                Realm = "realmf77e4bb9",
                DefaultGameServerDeployment = "default_game_server_deploymentbc552ce8",
                GameServerSelectors =
                {
                    new GameServerSelector(),
                },
                Metadata = new MetaPatch(),
            };
            AllocationResponse expectedResponse = new AllocationResponse
            {
                GameServerName = "game_server_name74be9a40",
                Ports =
                {
                    new AllocationResponse.Types.GameServerStatusPort(),
                },
                Address = "address04984d88",
                NodeName = "node_name215544e2",
                GameServerClusterName = "game_server_cluster_name1d66cd90",
                DeploymentName = "deployment_name8d1f3bfe",
            };
            mockGrpcClient.Setup(x => x.AllocateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AllocationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AllocationEndpointServiceClient client = new AllocationEndpointServiceClientImpl(mockGrpcClient.Object, null);
            AllocationResponse responseCallSettings = await client.AllocateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AllocationResponse responseCancellationToken = await client.AllocateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
