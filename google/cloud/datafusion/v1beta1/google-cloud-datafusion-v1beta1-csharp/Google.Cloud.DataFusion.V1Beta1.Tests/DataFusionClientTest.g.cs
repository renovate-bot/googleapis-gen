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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataFusion.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataFusionClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                Type = Instance.Types.Type.Developer,
                EnableStackdriverLogging = false,
                EnableStackdriverMonitoring = true,
                PrivateInstance = false,
                NetworkConfig = new NetworkConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Options =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.AutoUpdating,
                StateMessage = "state_message46cf28c0",
                ServiceEndpoint = "service_endpoint15ef9910",
                Zone = "zone255f4ea8",
                Version = "version102ff72a",
#pragma warning disable CS0612
                ServiceAccount = "service_accounta3c1b923",
#pragma warning restore CS0612
                DisplayName = "display_name137f65c2",
                AvailableVersion = { new Version(), },
                ApiEndpoint = "api_endpoint8841b40d",
                GcsBucket = "gcs_bucket69bbfa63",
                Accelerators = { new Accelerator(), },
                P4ServiceAccount = "p4_service_account45918d1c",
                TenantProjectId = "tenant_project_id70b9cf27",
                DataprocServiceAccount = "dataproc_service_account07295e86",
                EnableRbac = true,
                CryptoKeyConfig = new CryptoKeyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Description = "description2cf9da67",
                Type = Instance.Types.Type.Developer,
                EnableStackdriverLogging = false,
                EnableStackdriverMonitoring = true,
                PrivateInstance = false,
                NetworkConfig = new NetworkConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Options =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Instance.Types.State.AutoUpdating,
                StateMessage = "state_message46cf28c0",
                ServiceEndpoint = "service_endpoint15ef9910",
                Zone = "zone255f4ea8",
                Version = "version102ff72a",
#pragma warning disable CS0612
                ServiceAccount = "service_accounta3c1b923",
#pragma warning restore CS0612
                DisplayName = "display_name137f65c2",
                AvailableVersion = { new Version(), },
                ApiEndpoint = "api_endpoint8841b40d",
                GcsBucket = "gcs_bucket69bbfa63",
                Accelerators = { new Accelerator(), },
                P4ServiceAccount = "p4_service_account45918d1c",
                TenantProjectId = "tenant_project_id70b9cf27",
                DataprocServiceAccount = "dataproc_service_account07295e86",
                EnableRbac = true,
                CryptoKeyConfig = new CryptoKeyConfig(),
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveIamPolicyRequestObject()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveIamPolicyRequest request = new RemoveIamPolicyRequest
            {
                Resource = "resource164eab96",
            };
            RemoveIamPolicyResponse expectedResponse = new RemoveIamPolicyResponse { };
            mockGrpcClient.Setup(x => x.RemoveIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            RemoveIamPolicyResponse response = client.RemoveIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveIamPolicyRequestObjectAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveIamPolicyRequest request = new RemoveIamPolicyRequest
            {
                Resource = "resource164eab96",
            };
            RemoveIamPolicyResponse expectedResponse = new RemoveIamPolicyResponse { };
            mockGrpcClient.Setup(x => x.RemoveIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RemoveIamPolicyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            RemoveIamPolicyResponse responseCallSettings = await client.RemoveIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RemoveIamPolicyResponse responseCancellationToken = await client.RemoveIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddDnsPeeringRequestObject()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddDnsPeeringRequest request = new AddDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
                DnsPeering = new DnsPeering(),
            };
            AddDnsPeeringResponse expectedResponse = new AddDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.AddDnsPeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            AddDnsPeeringResponse response = client.AddDnsPeering(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddDnsPeeringRequestObjectAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddDnsPeeringRequest request = new AddDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
                DnsPeering = new DnsPeering(),
            };
            AddDnsPeeringResponse expectedResponse = new AddDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.AddDnsPeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddDnsPeeringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            AddDnsPeeringResponse responseCallSettings = await client.AddDnsPeeringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddDnsPeeringResponse responseCancellationToken = await client.AddDnsPeeringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddDnsPeering()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddDnsPeeringRequest request = new AddDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
            };
            AddDnsPeeringResponse expectedResponse = new AddDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.AddDnsPeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            AddDnsPeeringResponse response = client.AddDnsPeering(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddDnsPeeringAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddDnsPeeringRequest request = new AddDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
            };
            AddDnsPeeringResponse expectedResponse = new AddDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.AddDnsPeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddDnsPeeringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            AddDnsPeeringResponse responseCallSettings = await client.AddDnsPeeringAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddDnsPeeringResponse responseCancellationToken = await client.AddDnsPeeringAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveDnsPeeringRequestObject()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveDnsPeeringRequest request = new RemoveDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
                Zone = "zone255f4ea8",
            };
            RemoveDnsPeeringResponse expectedResponse = new RemoveDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.RemoveDnsPeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            RemoveDnsPeeringResponse response = client.RemoveDnsPeering(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveDnsPeeringRequestObjectAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveDnsPeeringRequest request = new RemoveDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
                Zone = "zone255f4ea8",
            };
            RemoveDnsPeeringResponse expectedResponse = new RemoveDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.RemoveDnsPeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RemoveDnsPeeringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            RemoveDnsPeeringResponse responseCallSettings = await client.RemoveDnsPeeringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RemoveDnsPeeringResponse responseCancellationToken = await client.RemoveDnsPeeringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveDnsPeering()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveDnsPeeringRequest request = new RemoveDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
            };
            RemoveDnsPeeringResponse expectedResponse = new RemoveDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.RemoveDnsPeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            RemoveDnsPeeringResponse response = client.RemoveDnsPeering(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveDnsPeeringAsync()
        {
            moq::Mock<DataFusion.DataFusionClient> mockGrpcClient = new moq::Mock<DataFusion.DataFusionClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveDnsPeeringRequest request = new RemoveDnsPeeringRequest
            {
                Parent = "parent7858e4d0",
            };
            RemoveDnsPeeringResponse expectedResponse = new RemoveDnsPeeringResponse { };
            mockGrpcClient.Setup(x => x.RemoveDnsPeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RemoveDnsPeeringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataFusionClient client = new DataFusionClientImpl(mockGrpcClient.Object, null);
            RemoveDnsPeeringResponse responseCallSettings = await client.RemoveDnsPeeringAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RemoveDnsPeeringResponse responseCancellationToken = await client.RemoveDnsPeeringAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
