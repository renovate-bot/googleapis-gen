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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V9.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupCustomizerServiceClientTest
    {
        [xunit::FactAttribute]
        public void MutateAdGroupCustomizersRequestObject()
        {
            moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCustomizersRequest request = new MutateAdGroupCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCustomizersResponse expectedResponse = new MutateAdGroupCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCustomizerServiceClient client = new AdGroupCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCustomizersResponse response = client.MutateAdGroupCustomizers(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateAdGroupCustomizersRequestObjectAsync()
        {
            moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCustomizersRequest request = new MutateAdGroupCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCustomizersResponse expectedResponse = new MutateAdGroupCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCustomizerServiceClient client = new AdGroupCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCustomizersResponse responseCallSettings = await client.MutateAdGroupCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateAdGroupCustomizersResponse responseCancellationToken = await client.MutateAdGroupCustomizersAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateAdGroupCustomizers()
        {
            moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCustomizersRequest request = new MutateAdGroupCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCustomizerOperation(),
                },
            };
            MutateAdGroupCustomizersResponse expectedResponse = new MutateAdGroupCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCustomizerServiceClient client = new AdGroupCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCustomizersResponse response = client.MutateAdGroupCustomizers(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateAdGroupCustomizersAsync()
        {
            moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCustomizerService.AdGroupCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCustomizersRequest request = new MutateAdGroupCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCustomizerOperation(),
                },
            };
            MutateAdGroupCustomizersResponse expectedResponse = new MutateAdGroupCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCustomizerServiceClient client = new AdGroupCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCustomizersResponse responseCallSettings = await client.MutateAdGroupCustomizersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateAdGroupCustomizersResponse responseCancellationToken = await client.MutateAdGroupCustomizersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
