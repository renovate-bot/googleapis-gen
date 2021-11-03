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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V9.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCombinedAudienceServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetCombinedAudienceRequestObject()
        {
            moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient> mockGrpcClient = new moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            gagvr::CombinedAudience expectedResponse = new gagvr::CombinedAudience
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CombinedAudienceStatusEnum.Types.CombinedAudienceStatus.Enabled,
                CombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCombinedAudience(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CombinedAudienceServiceClient client = new CombinedAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CombinedAudience response = client.GetCombinedAudience(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCombinedAudienceRequestObjectAsync()
        {
            moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient> mockGrpcClient = new moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            gagvr::CombinedAudience expectedResponse = new gagvr::CombinedAudience
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CombinedAudienceStatusEnum.Types.CombinedAudienceStatus.Enabled,
                CombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCombinedAudienceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CombinedAudience>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CombinedAudienceServiceClient client = new CombinedAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CombinedAudience responseCallSettings = await client.GetCombinedAudienceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CombinedAudience responseCancellationToken = await client.GetCombinedAudienceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCombinedAudience()
        {
            moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient> mockGrpcClient = new moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            gagvr::CombinedAudience expectedResponse = new gagvr::CombinedAudience
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CombinedAudienceStatusEnum.Types.CombinedAudienceStatus.Enabled,
                CombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCombinedAudience(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CombinedAudienceServiceClient client = new CombinedAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CombinedAudience response = client.GetCombinedAudience(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCombinedAudienceAsync()
        {
            moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient> mockGrpcClient = new moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            gagvr::CombinedAudience expectedResponse = new gagvr::CombinedAudience
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CombinedAudienceStatusEnum.Types.CombinedAudienceStatus.Enabled,
                CombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCombinedAudienceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CombinedAudience>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CombinedAudienceServiceClient client = new CombinedAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CombinedAudience responseCallSettings = await client.GetCombinedAudienceAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CombinedAudience responseCancellationToken = await client.GetCombinedAudienceAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCombinedAudienceResourceNames()
        {
            moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient> mockGrpcClient = new moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            gagvr::CombinedAudience expectedResponse = new gagvr::CombinedAudience
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CombinedAudienceStatusEnum.Types.CombinedAudienceStatus.Enabled,
                CombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCombinedAudience(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CombinedAudienceServiceClient client = new CombinedAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CombinedAudience response = client.GetCombinedAudience(request.ResourceNameAsCombinedAudienceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCombinedAudienceResourceNamesAsync()
        {
            moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient> mockGrpcClient = new moq::Mock<CombinedAudienceService.CombinedAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            gagvr::CombinedAudience expectedResponse = new gagvr::CombinedAudience
            {
                ResourceNameAsCombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CombinedAudienceStatusEnum.Types.CombinedAudienceStatus.Enabled,
                CombinedAudienceName = gagvr::CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCombinedAudienceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CombinedAudience>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CombinedAudienceServiceClient client = new CombinedAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CombinedAudience responseCallSettings = await client.GetCombinedAudienceAsync(request.ResourceNameAsCombinedAudienceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CombinedAudience responseCancellationToken = await client.GetCombinedAudienceAsync(request.ResourceNameAsCombinedAudienceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
