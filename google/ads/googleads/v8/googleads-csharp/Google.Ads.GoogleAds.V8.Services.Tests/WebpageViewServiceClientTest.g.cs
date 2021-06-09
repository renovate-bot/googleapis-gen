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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V8.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedWebpageViewServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetWebpageViewRequestObject()
        {
            moq::Mock<WebpageViewService.WebpageViewServiceClient> mockGrpcClient = new moq::Mock<WebpageViewService.WebpageViewServiceClient>(moq::MockBehavior.Strict);
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::WebpageView expectedResponse = new gagvr::WebpageView
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetWebpageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebpageViewServiceClient client = new WebpageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::WebpageView response = client.GetWebpageView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebpageViewRequestObjectAsync()
        {
            moq::Mock<WebpageViewService.WebpageViewServiceClient> mockGrpcClient = new moq::Mock<WebpageViewService.WebpageViewServiceClient>(moq::MockBehavior.Strict);
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::WebpageView expectedResponse = new gagvr::WebpageView
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetWebpageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::WebpageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebpageViewServiceClient client = new WebpageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::WebpageView responseCallSettings = await client.GetWebpageViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::WebpageView responseCancellationToken = await client.GetWebpageViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebpageView()
        {
            moq::Mock<WebpageViewService.WebpageViewServiceClient> mockGrpcClient = new moq::Mock<WebpageViewService.WebpageViewServiceClient>(moq::MockBehavior.Strict);
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::WebpageView expectedResponse = new gagvr::WebpageView
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetWebpageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebpageViewServiceClient client = new WebpageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::WebpageView response = client.GetWebpageView(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebpageViewAsync()
        {
            moq::Mock<WebpageViewService.WebpageViewServiceClient> mockGrpcClient = new moq::Mock<WebpageViewService.WebpageViewServiceClient>(moq::MockBehavior.Strict);
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::WebpageView expectedResponse = new gagvr::WebpageView
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetWebpageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::WebpageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebpageViewServiceClient client = new WebpageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::WebpageView responseCallSettings = await client.GetWebpageViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::WebpageView responseCancellationToken = await client.GetWebpageViewAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebpageViewResourceNames()
        {
            moq::Mock<WebpageViewService.WebpageViewServiceClient> mockGrpcClient = new moq::Mock<WebpageViewService.WebpageViewServiceClient>(moq::MockBehavior.Strict);
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::WebpageView expectedResponse = new gagvr::WebpageView
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetWebpageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebpageViewServiceClient client = new WebpageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::WebpageView response = client.GetWebpageView(request.ResourceNameAsWebpageViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebpageViewResourceNamesAsync()
        {
            moq::Mock<WebpageViewService.WebpageViewServiceClient> mockGrpcClient = new moq::Mock<WebpageViewService.WebpageViewServiceClient>(moq::MockBehavior.Strict);
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::WebpageView expectedResponse = new gagvr::WebpageView
            {
                ResourceNameAsWebpageViewName = gagvr::WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetWebpageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::WebpageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebpageViewServiceClient client = new WebpageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::WebpageView responseCallSettings = await client.GetWebpageViewAsync(request.ResourceNameAsWebpageViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::WebpageView responseCancellationToken = await client.GetWebpageViewAsync(request.ResourceNameAsWebpageViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
