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

using gagve = Google.Ads.GoogleAds.V7.Enums;
using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V7.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedPlaceholderViewServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetFeedPlaceholderViewRequestObject()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView response = client.GetFeedPlaceholderView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedPlaceholderViewRequestObjectAsync()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedPlaceholderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView responseCallSettings = await client.GetFeedPlaceholderViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::FeedPlaceholderView responseCancellationToken = await client.GetFeedPlaceholderViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeedPlaceholderView()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView response = client.GetFeedPlaceholderView(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedPlaceholderViewAsync()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedPlaceholderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView responseCallSettings = await client.GetFeedPlaceholderViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::FeedPlaceholderView responseCancellationToken = await client.GetFeedPlaceholderViewAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeedPlaceholderViewResourceNames()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView response = client.GetFeedPlaceholderView(request.ResourceNameAsFeedPlaceholderViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedPlaceholderViewResourceNamesAsync()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.App,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedPlaceholderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView responseCallSettings = await client.GetFeedPlaceholderViewAsync(request.ResourceNameAsFeedPlaceholderViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::FeedPlaceholderView responseCancellationToken = await client.GetFeedPlaceholderViewAsync(request.ResourceNameAsFeedPlaceholderViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
