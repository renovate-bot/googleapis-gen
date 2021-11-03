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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V9.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdScheduleViewServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAdScheduleViewRequestObject()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView response = client.GetAdScheduleView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAdScheduleViewRequestObjectAsync()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdScheduleView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView responseCallSettings = await client.GetAdScheduleViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::AdScheduleView responseCancellationToken = await client.GetAdScheduleViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAdScheduleView()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView response = client.GetAdScheduleView(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAdScheduleViewAsync()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdScheduleView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView responseCallSettings = await client.GetAdScheduleViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::AdScheduleView responseCancellationToken = await client.GetAdScheduleViewAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAdScheduleViewResourceNames()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView response = client.GetAdScheduleView(request.ResourceNameAsAdScheduleViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAdScheduleViewResourceNamesAsync()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdScheduleView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView responseCallSettings = await client.GetAdScheduleViewAsync(request.ResourceNameAsAdScheduleViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::AdScheduleView responseCancellationToken = await client.GetAdScheduleViewAsync(request.ResourceNameAsAdScheduleViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
