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
    public sealed class GeneratedGeoTargetConstantServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGeoTargetConstantRequestObject()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                ParentGeoTargetAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant response = client.GetGeoTargetConstant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGeoTargetConstantRequestObjectAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                ParentGeoTargetAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeoTargetConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant responseCallSettings = await client.GetGeoTargetConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::GeoTargetConstant responseCancellationToken = await client.GetGeoTargetConstantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGeoTargetConstant()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                ParentGeoTargetAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant response = client.GetGeoTargetConstant(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGeoTargetConstantAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                ParentGeoTargetAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeoTargetConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant responseCallSettings = await client.GetGeoTargetConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::GeoTargetConstant responseCancellationToken = await client.GetGeoTargetConstantAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGeoTargetConstantResourceNames()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                ParentGeoTargetAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant response = client.GetGeoTargetConstant(request.ResourceNameAsGeoTargetConstantName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGeoTargetConstantResourceNamesAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                ParentGeoTargetAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeoTargetConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant responseCallSettings = await client.GetGeoTargetConstantAsync(request.ResourceNameAsGeoTargetConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::GeoTargetConstant responseCancellationToken = await client.GetGeoTargetConstantAsync(request.ResourceNameAsGeoTargetConstantName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestGeoTargetConstantsRequestObject()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                GeoTargets = new SuggestGeoTargetConstantsRequest.Types.GeoTargets(),
                Locale = "locale9e6d21fb",
                CountryCode = "country_code8debec55",
            };
            SuggestGeoTargetConstantsResponse expectedResponse = new SuggestGeoTargetConstantsResponse
            {
                GeoTargetConstantSuggestions =
                {
                    new GeoTargetConstantSuggestion(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestGeoTargetConstants(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            SuggestGeoTargetConstantsResponse response = client.SuggestGeoTargetConstants(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestGeoTargetConstantsRequestObjectAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                GeoTargets = new SuggestGeoTargetConstantsRequest.Types.GeoTargets(),
                Locale = "locale9e6d21fb",
                CountryCode = "country_code8debec55",
            };
            SuggestGeoTargetConstantsResponse expectedResponse = new SuggestGeoTargetConstantsResponse
            {
                GeoTargetConstantSuggestions =
                {
                    new GeoTargetConstantSuggestion(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestGeoTargetConstantsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestGeoTargetConstantsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            SuggestGeoTargetConstantsResponse responseCallSettings = await client.SuggestGeoTargetConstantsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestGeoTargetConstantsResponse responseCancellationToken = await client.SuggestGeoTargetConstantsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
