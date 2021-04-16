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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Iam.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedWorkloadIdentityPoolsClientTest
    {
        [xunit::FactAttribute]
        public void GetWorkloadIdentityPoolRequestObject()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            WorkloadIdentityPool expectedResponse = new WorkloadIdentityPool
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPool.Types.State.Unspecified,
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPool response = client.GetWorkloadIdentityPool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadIdentityPoolRequestObjectAsync()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            WorkloadIdentityPool expectedResponse = new WorkloadIdentityPool
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPool.Types.State.Unspecified,
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkloadIdentityPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPool responseCallSettings = await client.GetWorkloadIdentityPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkloadIdentityPool responseCancellationToken = await client.GetWorkloadIdentityPoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadIdentityPool()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            WorkloadIdentityPool expectedResponse = new WorkloadIdentityPool
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPool.Types.State.Unspecified,
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPool response = client.GetWorkloadIdentityPool(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadIdentityPoolAsync()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            WorkloadIdentityPool expectedResponse = new WorkloadIdentityPool
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPool.Types.State.Unspecified,
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkloadIdentityPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPool responseCallSettings = await client.GetWorkloadIdentityPoolAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkloadIdentityPool responseCancellationToken = await client.GetWorkloadIdentityPoolAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadIdentityPoolResourceNames()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            WorkloadIdentityPool expectedResponse = new WorkloadIdentityPool
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPool.Types.State.Unspecified,
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPool response = client.GetWorkloadIdentityPool(request.WorkloadIdentityPoolName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadIdentityPoolResourceNamesAsync()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            WorkloadIdentityPool expectedResponse = new WorkloadIdentityPool
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPool.Types.State.Unspecified,
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkloadIdentityPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPool responseCallSettings = await client.GetWorkloadIdentityPoolAsync(request.WorkloadIdentityPoolName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkloadIdentityPool responseCancellationToken = await client.GetWorkloadIdentityPoolAsync(request.WorkloadIdentityPoolName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadIdentityPoolProviderRequestObject()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            WorkloadIdentityPoolProvider expectedResponse = new WorkloadIdentityPoolProvider
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPoolProvider.Types.State.Unspecified,
                Disabled = false,
                AttributeMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AttributeCondition = "attribute_condition4d679172",
                Aws = new WorkloadIdentityPoolProvider.Types.Aws(),
                Oidc = new WorkloadIdentityPoolProvider.Types.Oidc(),
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolProvider(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPoolProvider response = client.GetWorkloadIdentityPoolProvider(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadIdentityPoolProviderRequestObjectAsync()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            WorkloadIdentityPoolProvider expectedResponse = new WorkloadIdentityPoolProvider
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPoolProvider.Types.State.Unspecified,
                Disabled = false,
                AttributeMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AttributeCondition = "attribute_condition4d679172",
                Aws = new WorkloadIdentityPoolProvider.Types.Aws(),
                Oidc = new WorkloadIdentityPoolProvider.Types.Oidc(),
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolProviderAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkloadIdentityPoolProvider>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPoolProvider responseCallSettings = await client.GetWorkloadIdentityPoolProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkloadIdentityPoolProvider responseCancellationToken = await client.GetWorkloadIdentityPoolProviderAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadIdentityPoolProvider()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            WorkloadIdentityPoolProvider expectedResponse = new WorkloadIdentityPoolProvider
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPoolProvider.Types.State.Unspecified,
                Disabled = false,
                AttributeMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AttributeCondition = "attribute_condition4d679172",
                Aws = new WorkloadIdentityPoolProvider.Types.Aws(),
                Oidc = new WorkloadIdentityPoolProvider.Types.Oidc(),
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolProvider(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPoolProvider response = client.GetWorkloadIdentityPoolProvider(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadIdentityPoolProviderAsync()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            WorkloadIdentityPoolProvider expectedResponse = new WorkloadIdentityPoolProvider
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPoolProvider.Types.State.Unspecified,
                Disabled = false,
                AttributeMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AttributeCondition = "attribute_condition4d679172",
                Aws = new WorkloadIdentityPoolProvider.Types.Aws(),
                Oidc = new WorkloadIdentityPoolProvider.Types.Oidc(),
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolProviderAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkloadIdentityPoolProvider>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPoolProvider responseCallSettings = await client.GetWorkloadIdentityPoolProviderAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkloadIdentityPoolProvider responseCancellationToken = await client.GetWorkloadIdentityPoolProviderAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadIdentityPoolProviderResourceNames()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            WorkloadIdentityPoolProvider expectedResponse = new WorkloadIdentityPoolProvider
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPoolProvider.Types.State.Unspecified,
                Disabled = false,
                AttributeMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AttributeCondition = "attribute_condition4d679172",
                Aws = new WorkloadIdentityPoolProvider.Types.Aws(),
                Oidc = new WorkloadIdentityPoolProvider.Types.Oidc(),
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolProvider(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPoolProvider response = client.GetWorkloadIdentityPoolProvider(request.WorkloadIdentityPoolProviderName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadIdentityPoolProviderResourceNamesAsync()
        {
            moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient> mockGrpcClient = new moq::Mock<WorkloadIdentityPools.WorkloadIdentityPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            WorkloadIdentityPoolProvider expectedResponse = new WorkloadIdentityPoolProvider
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                State = WorkloadIdentityPoolProvider.Types.State.Unspecified,
                Disabled = false,
                AttributeMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AttributeCondition = "attribute_condition4d679172",
                Aws = new WorkloadIdentityPoolProvider.Types.Aws(),
                Oidc = new WorkloadIdentityPoolProvider.Types.Oidc(),
            };
            mockGrpcClient.Setup(x => x.GetWorkloadIdentityPoolProviderAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WorkloadIdentityPoolProvider>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WorkloadIdentityPoolsClient client = new WorkloadIdentityPoolsClientImpl(mockGrpcClient.Object, null);
            WorkloadIdentityPoolProvider responseCallSettings = await client.GetWorkloadIdentityPoolProviderAsync(request.WorkloadIdentityPoolProviderName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WorkloadIdentityPoolProvider responseCancellationToken = await client.GetWorkloadIdentityPoolProviderAsync(request.WorkloadIdentityPoolProviderName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
