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

using gagve = Google.Ads.GoogleAds.V8.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V8.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGoogleAdsServiceClientTest
    {
        [xunit::FactAttribute]
        public void MutateRequestObject()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.Mutate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse response = client.Mutate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateRequestObjectAsync()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateGoogleAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse responseCallSettings = await client.MutateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateGoogleAdsResponse responseCancellationToken = await client.MutateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Mutate()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.Mutate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse response = client.Mutate(request.CustomerId, request.MutateOperations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateAsync()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateGoogleAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse responseCallSettings = await client.MutateAsync(request.CustomerId, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateGoogleAdsResponse responseCancellationToken = await client.MutateAsync(request.CustomerId, request.MutateOperations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
