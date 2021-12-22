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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Chromeos.Uidetection.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUiDetectionServiceClientTest
    {
        [xunit::FactAttribute]
        public void ExecuteDetectionRequestObject()
        {
            moq::Mock<UiDetectionService.UiDetectionServiceClient> mockGrpcClient = new moq::Mock<UiDetectionService.UiDetectionServiceClient>(moq::MockBehavior.Strict);
            UiDetectionRequest request = new UiDetectionRequest
            {
                ImagePng = proto::ByteString.CopyFromUtf8("image_png451493e7"),
                Request = new DetectionRequest(),
            };
            UiDetectionResponse expectedResponse = new UiDetectionResponse
            {
                BoundingBoxes = { new BoundingBox(), },
            };
            mockGrpcClient.Setup(x => x.ExecuteDetection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UiDetectionServiceClient client = new UiDetectionServiceClientImpl(mockGrpcClient.Object, null);
            UiDetectionResponse response = client.ExecuteDetection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecuteDetectionRequestObjectAsync()
        {
            moq::Mock<UiDetectionService.UiDetectionServiceClient> mockGrpcClient = new moq::Mock<UiDetectionService.UiDetectionServiceClient>(moq::MockBehavior.Strict);
            UiDetectionRequest request = new UiDetectionRequest
            {
                ImagePng = proto::ByteString.CopyFromUtf8("image_png451493e7"),
                Request = new DetectionRequest(),
            };
            UiDetectionResponse expectedResponse = new UiDetectionResponse
            {
                BoundingBoxes = { new BoundingBox(), },
            };
            mockGrpcClient.Setup(x => x.ExecuteDetectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UiDetectionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UiDetectionServiceClient client = new UiDetectionServiceClientImpl(mockGrpcClient.Object, null);
            UiDetectionResponse responseCallSettings = await client.ExecuteDetectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UiDetectionResponse responseCancellationToken = await client.ExecuteDetectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
