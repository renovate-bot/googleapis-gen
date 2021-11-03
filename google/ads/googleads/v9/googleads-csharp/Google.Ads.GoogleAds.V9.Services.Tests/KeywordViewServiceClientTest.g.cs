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
    public sealed class GeneratedKeywordViewServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetKeywordViewRequestObject()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView response = client.GetKeywordView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeywordViewRequestObjectAsync()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView responseCallSettings = await client.GetKeywordViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::KeywordView responseCancellationToken = await client.GetKeywordViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeywordView()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView response = client.GetKeywordView(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeywordViewAsync()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView responseCallSettings = await client.GetKeywordViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::KeywordView responseCancellationToken = await client.GetKeywordViewAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeywordViewResourceNames()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView response = client.GetKeywordView(request.ResourceNameAsKeywordViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeywordViewResourceNamesAsync()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView responseCallSettings = await client.GetKeywordViewAsync(request.ResourceNameAsKeywordViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::KeywordView responseCancellationToken = await client.GetKeywordViewAsync(request.ResourceNameAsKeywordViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
