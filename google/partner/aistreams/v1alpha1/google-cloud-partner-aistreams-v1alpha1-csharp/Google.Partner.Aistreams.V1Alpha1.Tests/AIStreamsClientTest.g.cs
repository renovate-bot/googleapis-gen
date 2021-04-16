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

namespace Google.Partner.Aistreams.V1Alpha1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAIStreamsClientTest
    {
        [xunit::FactAttribute]
        public void GetClusterRequestObject()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Certificate = "certificateef0cd3e0",
                ServiceEndpoint = "service_endpoint15ef9910",
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterRequestObjectAsync()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Certificate = "certificateef0cd3e0",
                ServiceEndpoint = "service_endpoint15ef9910",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCluster()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Certificate = "certificateef0cd3e0",
                ServiceEndpoint = "service_endpoint15ef9910",
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterAsync()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Certificate = "certificateef0cd3e0",
                ServiceEndpoint = "service_endpoint15ef9910",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClusterResourceNames()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Certificate = "certificateef0cd3e0",
                ServiceEndpoint = "service_endpoint15ef9910",
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.ClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterResourceNamesAsync()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Certificate = "certificateef0cd3e0",
                ServiceEndpoint = "service_endpoint15ef9910",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.ClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.ClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStreamRequestObject()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Stream response = client.GetStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStreamRequestObjectAsync()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Stream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Stream responseCallSettings = await client.GetStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Stream responseCancellationToken = await client.GetStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStream()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Stream response = client.GetStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStreamAsync()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Stream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Stream responseCallSettings = await client.GetStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Stream responseCancellationToken = await client.GetStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStreamResourceNames()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Stream response = client.GetStream(request.StreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStreamResourceNamesAsync()
        {
            moq::Mock<AIStreams.AIStreamsClient> mockGrpcClient = new moq::Mock<AIStreams.AIStreamsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            Stream expectedResponse = new Stream
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Stream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AIStreamsClient client = new AIStreamsClientImpl(mockGrpcClient.Object, null);
            Stream responseCallSettings = await client.GetStreamAsync(request.StreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Stream responseCancellationToken = await client.GetStreamAsync(request.StreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
