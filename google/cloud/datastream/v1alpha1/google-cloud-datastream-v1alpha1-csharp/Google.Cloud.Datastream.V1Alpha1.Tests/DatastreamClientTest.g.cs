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

namespace Google.Cloud.Datastream.V1Alpha1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDatastreamClientTest
    {
        [xunit::FactAttribute]
        public void GetConnectionProfileRequestObject()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                OracleProfile = new OracleProfile(),
                GcsProfile = new GcsProfile(),
                MysqlProfile = new MysqlProfile(),
                NoConnectivity = new NoConnectivitySettings(),
                StaticServiceIpConnectivity = new StaticServiceIpConnectivity(),
                ForwardSshConnectivity = new ForwardSshTunnelConnectivity(),
                PrivateConnectivity = new PrivateConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile response = client.GetConnectionProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionProfileRequestObjectAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                OracleProfile = new OracleProfile(),
                GcsProfile = new GcsProfile(),
                MysqlProfile = new MysqlProfile(),
                NoConnectivity = new NoConnectivitySettings(),
                StaticServiceIpConnectivity = new StaticServiceIpConnectivity(),
                ForwardSshConnectivity = new ForwardSshTunnelConnectivity(),
                PrivateConnectivity = new PrivateConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectionProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile responseCallSettings = await client.GetConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectionProfile responseCancellationToken = await client.GetConnectionProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionProfile()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                OracleProfile = new OracleProfile(),
                GcsProfile = new GcsProfile(),
                MysqlProfile = new MysqlProfile(),
                NoConnectivity = new NoConnectivitySettings(),
                StaticServiceIpConnectivity = new StaticServiceIpConnectivity(),
                ForwardSshConnectivity = new ForwardSshTunnelConnectivity(),
                PrivateConnectivity = new PrivateConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile response = client.GetConnectionProfile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionProfileAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                OracleProfile = new OracleProfile(),
                GcsProfile = new GcsProfile(),
                MysqlProfile = new MysqlProfile(),
                NoConnectivity = new NoConnectivitySettings(),
                StaticServiceIpConnectivity = new StaticServiceIpConnectivity(),
                ForwardSshConnectivity = new ForwardSshTunnelConnectivity(),
                PrivateConnectivity = new PrivateConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectionProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile responseCallSettings = await client.GetConnectionProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectionProfile responseCancellationToken = await client.GetConnectionProfileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionProfileResourceNames()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                OracleProfile = new OracleProfile(),
                GcsProfile = new GcsProfile(),
                MysqlProfile = new MysqlProfile(),
                NoConnectivity = new NoConnectivitySettings(),
                StaticServiceIpConnectivity = new StaticServiceIpConnectivity(),
                ForwardSshConnectivity = new ForwardSshTunnelConnectivity(),
                PrivateConnectivity = new PrivateConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile response = client.GetConnectionProfile(request.ConnectionProfileName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionProfileResourceNamesAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            ConnectionProfile expectedResponse = new ConnectionProfile
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                OracleProfile = new OracleProfile(),
                GcsProfile = new GcsProfile(),
                MysqlProfile = new MysqlProfile(),
                NoConnectivity = new NoConnectivitySettings(),
                StaticServiceIpConnectivity = new StaticServiceIpConnectivity(),
                ForwardSshConnectivity = new ForwardSshTunnelConnectivity(),
                PrivateConnectivity = new PrivateConnectivity(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectionProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            ConnectionProfile responseCallSettings = await client.GetConnectionProfileAsync(request.ConnectionProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectionProfile responseCancellationToken = await client.GetConnectionProfileAsync(request.ConnectionProfileName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DiscoverConnectionProfileRequestObject()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DiscoverConnectionProfileRequest request = new DiscoverConnectionProfileRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Recursive = true,
                RecursionDepth = -1975322556,
                OracleRdbms = new OracleRdbms(),
                MysqlRdbms = new MysqlRdbms(),
                ConnectionProfile = new ConnectionProfile(),
                ConnectionProfileName = "connection_profile_name6b70b941",
            };
            DiscoverConnectionProfileResponse expectedResponse = new DiscoverConnectionProfileResponse
            {
                OracleRdbms = new OracleRdbms(),
                MysqlRdbms = new MysqlRdbms(),
            };
            mockGrpcClient.Setup(x => x.DiscoverConnectionProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            DiscoverConnectionProfileResponse response = client.DiscoverConnectionProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DiscoverConnectionProfileRequestObjectAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DiscoverConnectionProfileRequest request = new DiscoverConnectionProfileRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Recursive = true,
                RecursionDepth = -1975322556,
                OracleRdbms = new OracleRdbms(),
                MysqlRdbms = new MysqlRdbms(),
                ConnectionProfile = new ConnectionProfile(),
                ConnectionProfileName = "connection_profile_name6b70b941",
            };
            DiscoverConnectionProfileResponse expectedResponse = new DiscoverConnectionProfileResponse
            {
                OracleRdbms = new OracleRdbms(),
                MysqlRdbms = new MysqlRdbms(),
            };
            mockGrpcClient.Setup(x => x.DiscoverConnectionProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DiscoverConnectionProfileResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            DiscoverConnectionProfileResponse responseCallSettings = await client.DiscoverConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DiscoverConnectionProfileResponse responseCancellationToken = await client.DiscoverConnectionProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStreamRequestObject()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                SourceConfig = new SourceConfig(),
                DestinationConfig = new DestinationConfig(),
                State = Stream.Types.State.Paused,
                Errors = { new Error(), },
                BackfillAll = new Stream.Types.BackfillAllStrategy(),
                BackfillNone = new Stream.Types.BackfillNoneStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Stream response = client.GetStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStreamRequestObjectAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                SourceConfig = new SourceConfig(),
                DestinationConfig = new DestinationConfig(),
                State = Stream.Types.State.Paused,
                Errors = { new Error(), },
                BackfillAll = new Stream.Types.BackfillAllStrategy(),
                BackfillNone = new Stream.Types.BackfillNoneStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Stream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Stream responseCallSettings = await client.GetStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Stream responseCancellationToken = await client.GetStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStream()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                SourceConfig = new SourceConfig(),
                DestinationConfig = new DestinationConfig(),
                State = Stream.Types.State.Paused,
                Errors = { new Error(), },
                BackfillAll = new Stream.Types.BackfillAllStrategy(),
                BackfillNone = new Stream.Types.BackfillNoneStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Stream response = client.GetStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStreamAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                SourceConfig = new SourceConfig(),
                DestinationConfig = new DestinationConfig(),
                State = Stream.Types.State.Paused,
                Errors = { new Error(), },
                BackfillAll = new Stream.Types.BackfillAllStrategy(),
                BackfillNone = new Stream.Types.BackfillNoneStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Stream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Stream responseCallSettings = await client.GetStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Stream responseCancellationToken = await client.GetStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStreamResourceNames()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                SourceConfig = new SourceConfig(),
                DestinationConfig = new DestinationConfig(),
                State = Stream.Types.State.Paused,
                Errors = { new Error(), },
                BackfillAll = new Stream.Types.BackfillAllStrategy(),
                BackfillNone = new Stream.Types.BackfillNoneStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Stream response = client.GetStream(request.StreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStreamResourceNamesAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationStream("[PROJECT]", "[LOCATION]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                SourceConfig = new SourceConfig(),
                DestinationConfig = new DestinationConfig(),
                State = Stream.Types.State.Paused,
                Errors = { new Error(), },
                BackfillAll = new Stream.Types.BackfillAllStrategy(),
                BackfillNone = new Stream.Types.BackfillNoneStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Stream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Stream responseCallSettings = await client.GetStreamAsync(request.StreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Stream responseCancellationToken = await client.GetStreamAsync(request.StreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPrivateConnectionRequestObject()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            PrivateConnection expectedResponse = new PrivateConnection
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = PrivateConnection.Types.State.Created,
                Error = new Error(),
                VpcPeeringConfig = new VpcPeeringConfig(),
            };
            mockGrpcClient.Setup(x => x.GetPrivateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            PrivateConnection response = client.GetPrivateConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPrivateConnectionRequestObjectAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            PrivateConnection expectedResponse = new PrivateConnection
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = PrivateConnection.Types.State.Created,
                Error = new Error(),
                VpcPeeringConfig = new VpcPeeringConfig(),
            };
            mockGrpcClient.Setup(x => x.GetPrivateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PrivateConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            PrivateConnection responseCallSettings = await client.GetPrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PrivateConnection responseCancellationToken = await client.GetPrivateConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPrivateConnection()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            PrivateConnection expectedResponse = new PrivateConnection
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = PrivateConnection.Types.State.Created,
                Error = new Error(),
                VpcPeeringConfig = new VpcPeeringConfig(),
            };
            mockGrpcClient.Setup(x => x.GetPrivateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            PrivateConnection response = client.GetPrivateConnection(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPrivateConnectionAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            PrivateConnection expectedResponse = new PrivateConnection
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = PrivateConnection.Types.State.Created,
                Error = new Error(),
                VpcPeeringConfig = new VpcPeeringConfig(),
            };
            mockGrpcClient.Setup(x => x.GetPrivateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PrivateConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            PrivateConnection responseCallSettings = await client.GetPrivateConnectionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PrivateConnection responseCancellationToken = await client.GetPrivateConnectionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPrivateConnectionResourceNames()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            PrivateConnection expectedResponse = new PrivateConnection
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = PrivateConnection.Types.State.Created,
                Error = new Error(),
                VpcPeeringConfig = new VpcPeeringConfig(),
            };
            mockGrpcClient.Setup(x => x.GetPrivateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            PrivateConnection response = client.GetPrivateConnection(request.PrivateConnectionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPrivateConnectionResourceNamesAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            PrivateConnection expectedResponse = new PrivateConnection
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                State = PrivateConnection.Types.State.Created,
                Error = new Error(),
                VpcPeeringConfig = new VpcPeeringConfig(),
            };
            mockGrpcClient.Setup(x => x.GetPrivateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PrivateConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            PrivateConnection responseCallSettings = await client.GetPrivateConnectionAsync(request.PrivateConnectionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PrivateConnection responseCancellationToken = await client.GetPrivateConnectionAsync(request.PrivateConnectionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRouteRequestObject()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            Route expectedResponse = new Route
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                DestinationAddress = "destination_addressdf5ed78b",
                DestinationPort = -91432045,
            };
            mockGrpcClient.Setup(x => x.GetRoute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Route response = client.GetRoute(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouteRequestObjectAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            Route expectedResponse = new Route
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                DestinationAddress = "destination_addressdf5ed78b",
                DestinationPort = -91432045,
            };
            mockGrpcClient.Setup(x => x.GetRouteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Route>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Route responseCallSettings = await client.GetRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Route responseCancellationToken = await client.GetRouteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRoute()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            Route expectedResponse = new Route
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                DestinationAddress = "destination_addressdf5ed78b",
                DestinationPort = -91432045,
            };
            mockGrpcClient.Setup(x => x.GetRoute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Route response = client.GetRoute(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouteAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            Route expectedResponse = new Route
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                DestinationAddress = "destination_addressdf5ed78b",
                DestinationPort = -91432045,
            };
            mockGrpcClient.Setup(x => x.GetRouteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Route>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Route responseCallSettings = await client.GetRouteAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Route responseCancellationToken = await client.GetRouteAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRouteResourceNames()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            Route expectedResponse = new Route
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                DestinationAddress = "destination_addressdf5ed78b",
                DestinationPort = -91432045,
            };
            mockGrpcClient.Setup(x => x.GetRoute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Route response = client.GetRoute(request.RouteName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouteResourceNamesAsync()
        {
            moq::Mock<Datastream.DatastreamClient> mockGrpcClient = new moq::Mock<Datastream.DatastreamClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRouteRequest request = new GetRouteRequest
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
            };
            Route expectedResponse = new Route
            {
                RouteName = RouteName.FromProjectLocationPrivateConnectionRoute("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]", "[ROUTE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                DestinationAddress = "destination_addressdf5ed78b",
                DestinationPort = -91432045,
            };
            mockGrpcClient.Setup(x => x.GetRouteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Route>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastreamClient client = new DatastreamClientImpl(mockGrpcClient.Object, null);
            Route responseCallSettings = await client.GetRouteAsync(request.RouteName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Route responseCancellationToken = await client.GetRouteAsync(request.RouteName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
