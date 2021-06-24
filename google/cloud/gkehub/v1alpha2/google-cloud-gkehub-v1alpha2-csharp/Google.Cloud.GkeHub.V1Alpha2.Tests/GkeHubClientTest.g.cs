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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.GkeHub.V1Alpha2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGkeHubClientTest
    {
        [xunit::FactAttribute]
        public void GetMembershipRequestObject()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExternalId = "external_id9442680e",
                Authority = new Authority(),
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipRequestObjectAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExternalId = "external_id9442680e",
                Authority = new Authority(),
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMembership()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExternalId = "external_id9442680e",
                Authority = new Authority(),
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExternalId = "external_id9442680e",
                Authority = new Authority(),
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMembershipResourceNames()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExternalId = "external_id9442680e",
                Authority = new Authority(),
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request.MembershipName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipResourceNamesAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExternalId = "external_id9442680e",
                Authority = new Authority(),
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request.MembershipName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request.MembershipName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConnectManifestRequestObject()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                Name = "name1c9368b0",
                Namespace = "namespace9e1e8089",
                Proxy = proto::ByteString.CopyFromUtf8("proxyeb871343"),
                Version = "version102ff72a",
                IsUpgrade = false,
                Registry = "registrycf5d20a9",
                ImagePullSecretContent = proto::ByteString.CopyFromUtf8("image_pull_secret_content89fc8e49"),
            };
            GenerateConnectManifestResponse expectedResponse = new GenerateConnectManifestResponse
            {
                Manifest =
                {
                    new ConnectAgentResource(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateConnectManifest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            GenerateConnectManifestResponse response = client.GenerateConnectManifest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConnectManifestRequestObjectAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                Name = "name1c9368b0",
                Namespace = "namespace9e1e8089",
                Proxy = proto::ByteString.CopyFromUtf8("proxyeb871343"),
                Version = "version102ff72a",
                IsUpgrade = false,
                Registry = "registrycf5d20a9",
                ImagePullSecretContent = proto::ByteString.CopyFromUtf8("image_pull_secret_content89fc8e49"),
            };
            GenerateConnectManifestResponse expectedResponse = new GenerateConnectManifestResponse
            {
                Manifest =
                {
                    new ConnectAgentResource(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateConnectManifestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConnectManifestResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            GenerateConnectManifestResponse responseCallSettings = await client.GenerateConnectManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConnectManifestResponse responseCancellationToken = await client.GenerateConnectManifestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InitializeHubRequestObject()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            InitializeHubRequest request = new InitializeHubRequest
            {
                Project = "projectaa6ff846",
            };
            InitializeHubResponse expectedResponse = new InitializeHubResponse
            {
                ServiceIdentity = "service_identitye998b8ca",
                WorkloadIdentityPool = "workload_identity_pool63099a52",
            };
            mockGrpcClient.Setup(x => x.InitializeHub(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            InitializeHubResponse response = client.InitializeHub(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InitializeHubRequestObjectAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            InitializeHubRequest request = new InitializeHubRequest
            {
                Project = "projectaa6ff846",
            };
            InitializeHubResponse expectedResponse = new InitializeHubResponse
            {
                ServiceIdentity = "service_identitye998b8ca",
                WorkloadIdentityPool = "workload_identity_pool63099a52",
            };
            mockGrpcClient.Setup(x => x.InitializeHubAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InitializeHubResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            InitializeHubResponse responseCallSettings = await client.InitializeHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InitializeHubResponse responseCancellationToken = await client.InitializeHubAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
