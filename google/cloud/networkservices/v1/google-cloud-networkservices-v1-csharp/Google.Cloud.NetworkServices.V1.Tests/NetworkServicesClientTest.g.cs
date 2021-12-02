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

namespace Google.Cloud.NetworkServices.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedNetworkServicesClientTest
    {
        [xunit::FactAttribute]
        public void GetEndpointPolicyRequestObject()
        {
            moq::Mock<NetworkServices.NetworkServicesClient> mockGrpcClient = new moq::Mock<NetworkServices.NetworkServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            EndpointPolicy expectedResponse = new EndpointPolicy
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = EndpointPolicy.Types.EndpointPolicyType.Unspecified,
                AuthorizationPolicyAsAuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                EndpointMatcher = new EndpointMatcher(),
                TrafficPortSelector = new TrafficPortSelector(),
                Description = "description2cf9da67",
                ServerTlsPolicyAsServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                ClientTlsPolicyAsClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkServicesClient client = new NetworkServicesClientImpl(mockGrpcClient.Object, null);
            EndpointPolicy response = client.GetEndpointPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointPolicyRequestObjectAsync()
        {
            moq::Mock<NetworkServices.NetworkServicesClient> mockGrpcClient = new moq::Mock<NetworkServices.NetworkServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            EndpointPolicy expectedResponse = new EndpointPolicy
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = EndpointPolicy.Types.EndpointPolicyType.Unspecified,
                AuthorizationPolicyAsAuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                EndpointMatcher = new EndpointMatcher(),
                TrafficPortSelector = new TrafficPortSelector(),
                Description = "description2cf9da67",
                ServerTlsPolicyAsServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                ClientTlsPolicyAsClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EndpointPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkServicesClient client = new NetworkServicesClientImpl(mockGrpcClient.Object, null);
            EndpointPolicy responseCallSettings = await client.GetEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EndpointPolicy responseCancellationToken = await client.GetEndpointPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpointPolicy()
        {
            moq::Mock<NetworkServices.NetworkServicesClient> mockGrpcClient = new moq::Mock<NetworkServices.NetworkServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            EndpointPolicy expectedResponse = new EndpointPolicy
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = EndpointPolicy.Types.EndpointPolicyType.Unspecified,
                AuthorizationPolicyAsAuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                EndpointMatcher = new EndpointMatcher(),
                TrafficPortSelector = new TrafficPortSelector(),
                Description = "description2cf9da67",
                ServerTlsPolicyAsServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                ClientTlsPolicyAsClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkServicesClient client = new NetworkServicesClientImpl(mockGrpcClient.Object, null);
            EndpointPolicy response = client.GetEndpointPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointPolicyAsync()
        {
            moq::Mock<NetworkServices.NetworkServicesClient> mockGrpcClient = new moq::Mock<NetworkServices.NetworkServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            EndpointPolicy expectedResponse = new EndpointPolicy
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = EndpointPolicy.Types.EndpointPolicyType.Unspecified,
                AuthorizationPolicyAsAuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                EndpointMatcher = new EndpointMatcher(),
                TrafficPortSelector = new TrafficPortSelector(),
                Description = "description2cf9da67",
                ServerTlsPolicyAsServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                ClientTlsPolicyAsClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EndpointPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkServicesClient client = new NetworkServicesClientImpl(mockGrpcClient.Object, null);
            EndpointPolicy responseCallSettings = await client.GetEndpointPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EndpointPolicy responseCancellationToken = await client.GetEndpointPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpointPolicyResourceNames()
        {
            moq::Mock<NetworkServices.NetworkServicesClient> mockGrpcClient = new moq::Mock<NetworkServices.NetworkServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            EndpointPolicy expectedResponse = new EndpointPolicy
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = EndpointPolicy.Types.EndpointPolicyType.Unspecified,
                AuthorizationPolicyAsAuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                EndpointMatcher = new EndpointMatcher(),
                TrafficPortSelector = new TrafficPortSelector(),
                Description = "description2cf9da67",
                ServerTlsPolicyAsServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                ClientTlsPolicyAsClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkServicesClient client = new NetworkServicesClientImpl(mockGrpcClient.Object, null);
            EndpointPolicy response = client.GetEndpointPolicy(request.EndpointPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointPolicyResourceNamesAsync()
        {
            moq::Mock<NetworkServices.NetworkServicesClient> mockGrpcClient = new moq::Mock<NetworkServices.NetworkServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            EndpointPolicy expectedResponse = new EndpointPolicy
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = EndpointPolicy.Types.EndpointPolicyType.Unspecified,
                AuthorizationPolicyAsAuthorizationPolicyName = AuthorizationPolicyName.FromProjectLocationAuthorizationPolicy("[PROJECT]", "[LOCATION]", "[AUTHORIZATION_POLICY]"),
                EndpointMatcher = new EndpointMatcher(),
                TrafficPortSelector = new TrafficPortSelector(),
                Description = "description2cf9da67",
                ServerTlsPolicyAsServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
                ClientTlsPolicyAsClientTlsPolicyName = ClientTlsPolicyName.FromProjectLocationClientTlsPolicy("[PROJECT]", "[LOCATION]", "[CLIENT_TLS_POLICY]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EndpointPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkServicesClient client = new NetworkServicesClientImpl(mockGrpcClient.Object, null);
            EndpointPolicy responseCallSettings = await client.GetEndpointPolicyAsync(request.EndpointPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EndpointPolicy responseCancellationToken = await client.GetEndpointPolicyAsync(request.EndpointPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
