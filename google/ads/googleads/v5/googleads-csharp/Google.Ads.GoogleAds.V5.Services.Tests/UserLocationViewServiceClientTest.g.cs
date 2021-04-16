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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V5.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUserLocationViewServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetUserLocationViewRequestObject()
        {
            moq::Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new moq::Mock<UserLocationViewService.UserLocationViewServiceClient>(moq::MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            gagvr::UserLocationView expectedResponse = new gagvr::UserLocationView
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
                CountryCriterionId = 7801114990940938649L,
                TargetingLocation = false,
            };
            mockGrpcClient.Setup(x => x.GetUserLocationView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserLocationView response = client.GetUserLocationView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserLocationViewRequestObjectAsync()
        {
            moq::Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new moq::Mock<UserLocationViewService.UserLocationViewServiceClient>(moq::MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            gagvr::UserLocationView expectedResponse = new gagvr::UserLocationView
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
                CountryCriterionId = 7801114990940938649L,
                TargetingLocation = false,
            };
            mockGrpcClient.Setup(x => x.GetUserLocationViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserLocationView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserLocationView responseCallSettings = await client.GetUserLocationViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::UserLocationView responseCancellationToken = await client.GetUserLocationViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserLocationView()
        {
            moq::Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new moq::Mock<UserLocationViewService.UserLocationViewServiceClient>(moq::MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            gagvr::UserLocationView expectedResponse = new gagvr::UserLocationView
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
                CountryCriterionId = 7801114990940938649L,
                TargetingLocation = false,
            };
            mockGrpcClient.Setup(x => x.GetUserLocationView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserLocationView response = client.GetUserLocationView(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserLocationViewAsync()
        {
            moq::Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new moq::Mock<UserLocationViewService.UserLocationViewServiceClient>(moq::MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            gagvr::UserLocationView expectedResponse = new gagvr::UserLocationView
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
                CountryCriterionId = 7801114990940938649L,
                TargetingLocation = false,
            };
            mockGrpcClient.Setup(x => x.GetUserLocationViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserLocationView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserLocationView responseCallSettings = await client.GetUserLocationViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::UserLocationView responseCancellationToken = await client.GetUserLocationViewAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserLocationViewResourceNames()
        {
            moq::Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new moq::Mock<UserLocationViewService.UserLocationViewServiceClient>(moq::MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            gagvr::UserLocationView expectedResponse = new gagvr::UserLocationView
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
                CountryCriterionId = 7801114990940938649L,
                TargetingLocation = false,
            };
            mockGrpcClient.Setup(x => x.GetUserLocationView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserLocationView response = client.GetUserLocationView(request.ResourceNameAsUserLocationViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserLocationViewResourceNamesAsync()
        {
            moq::Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new moq::Mock<UserLocationViewService.UserLocationViewServiceClient>(moq::MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            gagvr::UserLocationView expectedResponse = new gagvr::UserLocationView
            {
                ResourceNameAsUserLocationViewName = gagvr::UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
                CountryCriterionId = 7801114990940938649L,
                TargetingLocation = false,
            };
            mockGrpcClient.Setup(x => x.GetUserLocationViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserLocationView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserLocationView responseCallSettings = await client.GetUserLocationViewAsync(request.ResourceNameAsUserLocationViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::UserLocationView responseCancellationToken = await client.GetUserLocationViewAsync(request.ResourceNameAsUserLocationViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
