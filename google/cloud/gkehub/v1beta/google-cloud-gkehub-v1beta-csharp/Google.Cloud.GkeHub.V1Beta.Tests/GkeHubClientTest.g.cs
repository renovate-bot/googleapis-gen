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

namespace Google.Cloud.GkeHub.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGkeHubClientTest
    {
        [xunit::FactAttribute]
        public void GetFeatureRequestObject()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                Name = "name1c9368b0",
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ResourceState = new FeatureResourceState(),
                Spec = new CommonFeatureSpec(),
                MembershipSpecs =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureSpec()
                    },
                },
                State = new CommonFeatureState(),
                MembershipStates =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureState()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Feature response = client.GetFeature(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeatureRequestObjectAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                Name = "name1c9368b0",
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ResourceState = new FeatureResourceState(),
                Spec = new CommonFeatureSpec(),
                MembershipSpecs =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureSpec()
                    },
                },
                State = new CommonFeatureState(),
                MembershipStates =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureState()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.GetFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.GetFeatureAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeature()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                Name = "name1c9368b0",
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ResourceState = new FeatureResourceState(),
                Spec = new CommonFeatureSpec(),
                MembershipSpecs =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureSpec()
                    },
                },
                State = new CommonFeatureState(),
                MembershipStates =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureState()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFeature(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Feature response = client.GetFeature(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeatureAsync()
        {
            moq::Mock<GkeHub.GkeHubClient> mockGrpcClient = new moq::Mock<GkeHub.GkeHubClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeatureRequest request = new GetFeatureRequest
            {
                Name = "name1c9368b0",
            };
            Feature expectedResponse = new Feature
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ResourceState = new FeatureResourceState(),
                Spec = new CommonFeatureSpec(),
                MembershipSpecs =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureSpec()
                    },
                },
                State = new CommonFeatureState(),
                MembershipStates =
                {
                    {
                        "key8a0b6e3c",
                        new MembershipFeatureState()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFeatureAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feature>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubClient client = new GkeHubClientImpl(mockGrpcClient.Object, null);
            Feature responseCallSettings = await client.GetFeatureAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feature responseCancellationToken = await client.GetFeatureAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
