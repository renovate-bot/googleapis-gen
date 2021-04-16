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
using gmpvs = Google.Maps.PlayableLocations.V3.Sample;
using gmu = Google.Maps.Unity;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Maps.PlayableLocations.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPlayableLocationsClientTest
    {
        [xunit::FactAttribute]
        public void SamplePlayableLocationsRequestObject()
        {
            moq::Mock<PlayableLocations.PlayableLocationsClient> mockGrpcClient = new moq::Mock<PlayableLocations.PlayableLocationsClient>(moq::MockBehavior.Strict);
            SamplePlayableLocationsRequest request = new SamplePlayableLocationsRequest
            {
                AreaFilter = new gmpvs::AreaFilter(),
                Criteria =
                {
                    new gmpvs::Criterion(),
                },
            };
            SamplePlayableLocationsResponse expectedResponse = new SamplePlayableLocationsResponse
            {
                LocationsPerGameObjectType =
                {
                    {
                        -1978962372,
                        new gmpvs::PlayableLocationList()
                    },
                },
                Ttl = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.SamplePlayableLocations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PlayableLocationsClient client = new PlayableLocationsClientImpl(mockGrpcClient.Object, null);
            SamplePlayableLocationsResponse response = client.SamplePlayableLocations(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SamplePlayableLocationsRequestObjectAsync()
        {
            moq::Mock<PlayableLocations.PlayableLocationsClient> mockGrpcClient = new moq::Mock<PlayableLocations.PlayableLocationsClient>(moq::MockBehavior.Strict);
            SamplePlayableLocationsRequest request = new SamplePlayableLocationsRequest
            {
                AreaFilter = new gmpvs::AreaFilter(),
                Criteria =
                {
                    new gmpvs::Criterion(),
                },
            };
            SamplePlayableLocationsResponse expectedResponse = new SamplePlayableLocationsResponse
            {
                LocationsPerGameObjectType =
                {
                    {
                        -1978962372,
                        new gmpvs::PlayableLocationList()
                    },
                },
                Ttl = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.SamplePlayableLocationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SamplePlayableLocationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PlayableLocationsClient client = new PlayableLocationsClientImpl(mockGrpcClient.Object, null);
            SamplePlayableLocationsResponse responseCallSettings = await client.SamplePlayableLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SamplePlayableLocationsResponse responseCancellationToken = await client.SamplePlayableLocationsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LogPlayerReportsRequestObject()
        {
            moq::Mock<PlayableLocations.PlayableLocationsClient> mockGrpcClient = new moq::Mock<PlayableLocations.PlayableLocationsClient>(moq::MockBehavior.Strict);
            LogPlayerReportsRequest request = new LogPlayerReportsRequest
            {
                PlayerReports = { new PlayerReport(), },
                RequestId = "request_id362c8df6",
                ClientInfo = new gmu::ClientInfo(),
            };
            LogPlayerReportsResponse expectedResponse = new LogPlayerReportsResponse { };
            mockGrpcClient.Setup(x => x.LogPlayerReports(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PlayableLocationsClient client = new PlayableLocationsClientImpl(mockGrpcClient.Object, null);
            LogPlayerReportsResponse response = client.LogPlayerReports(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LogPlayerReportsRequestObjectAsync()
        {
            moq::Mock<PlayableLocations.PlayableLocationsClient> mockGrpcClient = new moq::Mock<PlayableLocations.PlayableLocationsClient>(moq::MockBehavior.Strict);
            LogPlayerReportsRequest request = new LogPlayerReportsRequest
            {
                PlayerReports = { new PlayerReport(), },
                RequestId = "request_id362c8df6",
                ClientInfo = new gmu::ClientInfo(),
            };
            LogPlayerReportsResponse expectedResponse = new LogPlayerReportsResponse { };
            mockGrpcClient.Setup(x => x.LogPlayerReportsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogPlayerReportsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PlayableLocationsClient client = new PlayableLocationsClientImpl(mockGrpcClient.Object, null);
            LogPlayerReportsResponse responseCallSettings = await client.LogPlayerReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogPlayerReportsResponse responseCancellationToken = await client.LogPlayerReportsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LogImpressionsRequestObject()
        {
            moq::Mock<PlayableLocations.PlayableLocationsClient> mockGrpcClient = new moq::Mock<PlayableLocations.PlayableLocationsClient>(moq::MockBehavior.Strict);
            LogImpressionsRequest request = new LogImpressionsRequest
            {
                Impressions = { new Impression(), },
                RequestId = "request_id362c8df6",
                ClientInfo = new gmu::ClientInfo(),
            };
            LogImpressionsResponse expectedResponse = new LogImpressionsResponse { };
            mockGrpcClient.Setup(x => x.LogImpressions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PlayableLocationsClient client = new PlayableLocationsClientImpl(mockGrpcClient.Object, null);
            LogImpressionsResponse response = client.LogImpressions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LogImpressionsRequestObjectAsync()
        {
            moq::Mock<PlayableLocations.PlayableLocationsClient> mockGrpcClient = new moq::Mock<PlayableLocations.PlayableLocationsClient>(moq::MockBehavior.Strict);
            LogImpressionsRequest request = new LogImpressionsRequest
            {
                Impressions = { new Impression(), },
                RequestId = "request_id362c8df6",
                ClientInfo = new gmu::ClientInfo(),
            };
            LogImpressionsResponse expectedResponse = new LogImpressionsResponse { };
            mockGrpcClient.Setup(x => x.LogImpressionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogImpressionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PlayableLocationsClient client = new PlayableLocationsClientImpl(mockGrpcClient.Object, null);
            LogImpressionsResponse responseCallSettings = await client.LogImpressionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogImpressionsResponse responseCancellationToken = await client.LogImpressionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
