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

namespace Google.Maps.Roads.V1Op.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRoadsServiceClientTest
    {
        [xunit::FactAttribute]
        public void SnapToRoadsRequestObject()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            SnapToRoadsRequest request = new SnapToRoadsRequest
            {
                Path = "path0b1dfed6",
                Interpolate = false,
                AssetId = "asset_iddbd5c651",
                TravelMode = TravelMode.Walking,
            };
            SnapToRoadsResponse expectedResponse = new SnapToRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
                WarningMessage = "warning_message2fa1e4a9",
            };
            mockGrpcClient.Setup(x => x.SnapToRoads(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            SnapToRoadsResponse response = client.SnapToRoads(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SnapToRoadsRequestObjectAsync()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            SnapToRoadsRequest request = new SnapToRoadsRequest
            {
                Path = "path0b1dfed6",
                Interpolate = false,
                AssetId = "asset_iddbd5c651",
                TravelMode = TravelMode.Walking,
            };
            SnapToRoadsResponse expectedResponse = new SnapToRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
                WarningMessage = "warning_message2fa1e4a9",
            };
            mockGrpcClient.Setup(x => x.SnapToRoadsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapToRoadsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            SnapToRoadsResponse responseCallSettings = await client.SnapToRoadsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapToRoadsResponse responseCancellationToken = await client.SnapToRoadsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SnapToRoads()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            SnapToRoadsRequest request = new SnapToRoadsRequest
            {
                Path = "path0b1dfed6",
            };
            SnapToRoadsResponse expectedResponse = new SnapToRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
                WarningMessage = "warning_message2fa1e4a9",
            };
            mockGrpcClient.Setup(x => x.SnapToRoads(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            SnapToRoadsResponse response = client.SnapToRoads(request.Path);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SnapToRoadsAsync()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            SnapToRoadsRequest request = new SnapToRoadsRequest
            {
                Path = "path0b1dfed6",
            };
            SnapToRoadsResponse expectedResponse = new SnapToRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
                WarningMessage = "warning_message2fa1e4a9",
            };
            mockGrpcClient.Setup(x => x.SnapToRoadsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SnapToRoadsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            SnapToRoadsResponse responseCallSettings = await client.SnapToRoadsAsync(request.Path, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SnapToRoadsResponse responseCancellationToken = await client.SnapToRoadsAsync(request.Path, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNearestRoadsRequestObject()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            ListNearestRoadsRequest request = new ListNearestRoadsRequest
            {
                Points = "pointsde81ab0a",
                TravelMode = TravelMode.Walking,
            };
            ListNearestRoadsResponse expectedResponse = new ListNearestRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
            };
            mockGrpcClient.Setup(x => x.ListNearestRoads(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            ListNearestRoadsResponse response = client.ListNearestRoads(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNearestRoadsRequestObjectAsync()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            ListNearestRoadsRequest request = new ListNearestRoadsRequest
            {
                Points = "pointsde81ab0a",
                TravelMode = TravelMode.Walking,
            };
            ListNearestRoadsResponse expectedResponse = new ListNearestRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
            };
            mockGrpcClient.Setup(x => x.ListNearestRoadsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNearestRoadsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            ListNearestRoadsResponse responseCallSettings = await client.ListNearestRoadsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNearestRoadsResponse responseCancellationToken = await client.ListNearestRoadsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNearestRoads()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            ListNearestRoadsRequest request = new ListNearestRoadsRequest
            {
                Points = "pointsde81ab0a",
            };
            ListNearestRoadsResponse expectedResponse = new ListNearestRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
            };
            mockGrpcClient.Setup(x => x.ListNearestRoads(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            ListNearestRoadsResponse response = client.ListNearestRoads(request.Points);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNearestRoadsAsync()
        {
            moq::Mock<RoadsService.RoadsServiceClient> mockGrpcClient = new moq::Mock<RoadsService.RoadsServiceClient>(moq::MockBehavior.Strict);
            ListNearestRoadsRequest request = new ListNearestRoadsRequest
            {
                Points = "pointsde81ab0a",
            };
            ListNearestRoadsResponse expectedResponse = new ListNearestRoadsResponse
            {
                SnappedPoints = { new SnappedPoint(), },
            };
            mockGrpcClient.Setup(x => x.ListNearestRoadsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListNearestRoadsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoadsServiceClient client = new RoadsServiceClientImpl(mockGrpcClient.Object, null);
            ListNearestRoadsResponse responseCallSettings = await client.ListNearestRoadsAsync(request.Points, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListNearestRoadsResponse responseCancellationToken = await client.ListNearestRoadsAsync(request.Points, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
