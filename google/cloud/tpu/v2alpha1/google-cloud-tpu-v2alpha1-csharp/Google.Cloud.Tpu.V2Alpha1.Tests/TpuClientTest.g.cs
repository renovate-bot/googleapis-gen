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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Tpu.V2Alpha1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTpuClientTest
    {
        [xunit::FactAttribute]
        public void GetNodeRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                RuntimeVersion = "runtime_version0922b5dc",
                CidrBlock = "cidr_block0fc04814",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.Y,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Id = -6774108720365892680L,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkConfig = new NetworkConfig(),
                ServiceAccount = new ServiceAccount(),
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
                Tags = { "tags52c47ad5", },
                DataDisks = { new AttachedDisk(), },
            };
            mockGrpcClient.Setup(x => x.GetNode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node response = client.GetNode(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodeRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                RuntimeVersion = "runtime_version0922b5dc",
                CidrBlock = "cidr_block0fc04814",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.Y,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Id = -6774108720365892680L,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkConfig = new NetworkConfig(),
                ServiceAccount = new ServiceAccount(),
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
                Tags = { "tags52c47ad5", },
                DataDisks = { new AttachedDisk(), },
            };
            mockGrpcClient.Setup(x => x.GetNodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Node>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node responseCallSettings = await client.GetNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Node responseCancellationToken = await client.GetNodeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNode()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                RuntimeVersion = "runtime_version0922b5dc",
                CidrBlock = "cidr_block0fc04814",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.Y,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Id = -6774108720365892680L,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkConfig = new NetworkConfig(),
                ServiceAccount = new ServiceAccount(),
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
                Tags = { "tags52c47ad5", },
                DataDisks = { new AttachedDisk(), },
            };
            mockGrpcClient.Setup(x => x.GetNode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node response = client.GetNode(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodeAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                RuntimeVersion = "runtime_version0922b5dc",
                CidrBlock = "cidr_block0fc04814",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.Y,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Id = -6774108720365892680L,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkConfig = new NetworkConfig(),
                ServiceAccount = new ServiceAccount(),
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
                Tags = { "tags52c47ad5", },
                DataDisks = { new AttachedDisk(), },
            };
            mockGrpcClient.Setup(x => x.GetNodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Node>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node responseCallSettings = await client.GetNodeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Node responseCancellationToken = await client.GetNodeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNodeResourceNames()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                RuntimeVersion = "runtime_version0922b5dc",
                CidrBlock = "cidr_block0fc04814",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.Y,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Id = -6774108720365892680L,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkConfig = new NetworkConfig(),
                ServiceAccount = new ServiceAccount(),
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
                Tags = { "tags52c47ad5", },
                DataDisks = { new AttachedDisk(), },
            };
            mockGrpcClient.Setup(x => x.GetNode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node response = client.GetNode(request.NodeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodeResourceNamesAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                RuntimeVersion = "runtime_version0922b5dc",
                CidrBlock = "cidr_block0fc04814",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.Y,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Id = -6774108720365892680L,
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkConfig = new NetworkConfig(),
                ServiceAccount = new ServiceAccount(),
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
                Tags = { "tags52c47ad5", },
                DataDisks = { new AttachedDisk(), },
            };
            mockGrpcClient.Setup(x => x.GetNodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Node>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node responseCallSettings = await client.GetNodeAsync(request.NodeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Node responseCancellationToken = await client.GetNodeAsync(request.NodeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateServiceIdentityRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateServiceIdentityRequest request = new GenerateServiceIdentityRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            GenerateServiceIdentityResponse expectedResponse = new GenerateServiceIdentityResponse
            {
                Identity = new ServiceIdentity(),
            };
            mockGrpcClient.Setup(x => x.GenerateServiceIdentity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            GenerateServiceIdentityResponse response = client.GenerateServiceIdentity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateServiceIdentityRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateServiceIdentityRequest request = new GenerateServiceIdentityRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            GenerateServiceIdentityResponse expectedResponse = new GenerateServiceIdentityResponse
            {
                Identity = new ServiceIdentity(),
            };
            mockGrpcClient.Setup(x => x.GenerateServiceIdentityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateServiceIdentityResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            GenerateServiceIdentityResponse responseCallSettings = await client.GenerateServiceIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateServiceIdentityResponse responseCancellationToken = await client.GenerateServiceIdentityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAcceleratorTypeRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.GetAcceleratorType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAcceleratorTypeRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAcceleratorTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAcceleratorTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAcceleratorType()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.GetAcceleratorType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAcceleratorTypeAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAcceleratorTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAcceleratorTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAcceleratorTypeResourceNames()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.GetAcceleratorType(request.AcceleratorTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAcceleratorTypeResourceNamesAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAcceleratorTypeAsync(request.AcceleratorTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAcceleratorTypeAsync(request.AcceleratorTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuntimeVersionRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeVersionRequest request = new GetRuntimeVersionRequest
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
            };
            RuntimeVersion expectedResponse = new RuntimeVersion
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetRuntimeVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            RuntimeVersion response = client.GetRuntimeVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuntimeVersionRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeVersionRequest request = new GetRuntimeVersionRequest
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
            };
            RuntimeVersion expectedResponse = new RuntimeVersion
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetRuntimeVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RuntimeVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            RuntimeVersion responseCallSettings = await client.GetRuntimeVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RuntimeVersion responseCancellationToken = await client.GetRuntimeVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuntimeVersion()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeVersionRequest request = new GetRuntimeVersionRequest
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
            };
            RuntimeVersion expectedResponse = new RuntimeVersion
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetRuntimeVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            RuntimeVersion response = client.GetRuntimeVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuntimeVersionAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeVersionRequest request = new GetRuntimeVersionRequest
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
            };
            RuntimeVersion expectedResponse = new RuntimeVersion
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetRuntimeVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RuntimeVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            RuntimeVersion responseCallSettings = await client.GetRuntimeVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RuntimeVersion responseCancellationToken = await client.GetRuntimeVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuntimeVersionResourceNames()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeVersionRequest request = new GetRuntimeVersionRequest
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
            };
            RuntimeVersion expectedResponse = new RuntimeVersion
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetRuntimeVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            RuntimeVersion response = client.GetRuntimeVersion(request.RuntimeVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuntimeVersionResourceNamesAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuntimeVersionRequest request = new GetRuntimeVersionRequest
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
            };
            RuntimeVersion expectedResponse = new RuntimeVersion
            {
                RuntimeVersionName = RuntimeVersionName.FromProjectLocationRuntimeVersion("[PROJECT]", "[LOCATION]", "[RUNTIME_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetRuntimeVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RuntimeVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            RuntimeVersion responseCallSettings = await client.GetRuntimeVersionAsync(request.RuntimeVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RuntimeVersion responseCancellationToken = await client.GetRuntimeVersionAsync(request.RuntimeVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestAttributesRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGuestAttributesRequest request = new GetGuestAttributesRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                QueryPath = "query_pathf44da93a",
                WorkerIds =
                {
                    "worker_ids919c1929",
                },
            };
            GetGuestAttributesResponse expectedResponse = new GetGuestAttributesResponse
            {
                GuestAttributes =
                {
                    new GuestAttributes(),
                },
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            GetGuestAttributesResponse response = client.GetGuestAttributes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestAttributesRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGuestAttributesRequest request = new GetGuestAttributesRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                QueryPath = "query_pathf44da93a",
                WorkerIds =
                {
                    "worker_ids919c1929",
                },
            };
            GetGuestAttributesResponse expectedResponse = new GetGuestAttributesResponse
            {
                GuestAttributes =
                {
                    new GuestAttributes(),
                },
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetGuestAttributesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            GetGuestAttributesResponse responseCallSettings = await client.GetGuestAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetGuestAttributesResponse responseCancellationToken = await client.GetGuestAttributesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
