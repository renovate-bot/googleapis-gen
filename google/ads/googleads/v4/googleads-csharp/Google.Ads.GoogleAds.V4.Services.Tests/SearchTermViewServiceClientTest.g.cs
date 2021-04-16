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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V4.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSearchTermViewServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetSearchTermViewRequestObject()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView response = client.GetSearchTermView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSearchTermViewRequestObjectAsync()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView responseCallSettings = await client.GetSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::SearchTermView responseCancellationToken = await client.GetSearchTermViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSearchTermView()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView response = client.GetSearchTermView(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSearchTermViewAsync()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView responseCallSettings = await client.GetSearchTermViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::SearchTermView responseCancellationToken = await client.GetSearchTermViewAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSearchTermViewResourceNames()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView response = client.GetSearchTermView(request.ResourceNameAsSearchTermViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSearchTermViewResourceNamesAsync()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView responseCallSettings = await client.GetSearchTermViewAsync(request.ResourceNameAsSearchTermViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::SearchTermView responseCancellationToken = await client.GetSearchTermViewAsync(request.ResourceNameAsSearchTermViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
