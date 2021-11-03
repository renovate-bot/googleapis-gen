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
using gagvr = Google.Ads.GoogleAds.V9.Resources;
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
    public sealed class GeneratedFeedMappingServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetFeedMappingRequestObject()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping response = client.GetFeedMapping(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedMappingRequestObjectAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping responseCallSettings = await client.GetFeedMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::FeedMapping responseCancellationToken = await client.GetFeedMappingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeedMapping()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping response = client.GetFeedMapping(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedMappingAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping responseCallSettings = await client.GetFeedMappingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::FeedMapping responseCancellationToken = await client.GetFeedMappingAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeedMappingResourceNames()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping response = client.GetFeedMapping(request.ResourceNameAsFeedMappingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedMappingResourceNamesAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping responseCallSettings = await client.GetFeedMappingAsync(request.ResourceNameAsFeedMappingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::FeedMapping responseCancellationToken = await client.GetFeedMappingAsync(request.ResourceNameAsFeedMappingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateFeedMappingsRequestObject()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse response = client.MutateFeedMappings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateFeedMappingsRequestObjectAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedMappingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse responseCallSettings = await client.MutateFeedMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateFeedMappingsResponse responseCancellationToken = await client.MutateFeedMappingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateFeedMappings()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse response = client.MutateFeedMappings(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateFeedMappingsAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedMappingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse responseCallSettings = await client.MutateFeedMappingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateFeedMappingsResponse responseCancellationToken = await client.MutateFeedMappingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
