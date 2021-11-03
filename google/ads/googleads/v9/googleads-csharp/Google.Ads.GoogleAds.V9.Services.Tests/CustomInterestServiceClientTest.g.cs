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
    public sealed class GeneratedCustomInterestServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetCustomInterestRequestObject()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
            };
            gagvr::CustomInterest expectedResponse = new gagvr::CustomInterest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Status = gagve::CustomInterestStatusEnum.Types.CustomInterestStatus.Enabled,
                Type = gagve::CustomInterestTypeEnum.Types.CustomInterestType.CustomIntent,
                Members =
                {
                    new gagvr::CustomInterestMember(),
                },
                Id = -6774108720365892680L,
                CustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomInterest response = client.GetCustomInterest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomInterestRequestObjectAsync()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
            };
            gagvr::CustomInterest expectedResponse = new gagvr::CustomInterest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Status = gagve::CustomInterestStatusEnum.Types.CustomInterestStatus.Enabled,
                Type = gagve::CustomInterestTypeEnum.Types.CustomInterestType.CustomIntent,
                Members =
                {
                    new gagvr::CustomInterestMember(),
                },
                Id = -6774108720365892680L,
                CustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomInterest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomInterest responseCallSettings = await client.GetCustomInterestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CustomInterest responseCancellationToken = await client.GetCustomInterestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomInterest()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
            };
            gagvr::CustomInterest expectedResponse = new gagvr::CustomInterest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Status = gagve::CustomInterestStatusEnum.Types.CustomInterestStatus.Enabled,
                Type = gagve::CustomInterestTypeEnum.Types.CustomInterestType.CustomIntent,
                Members =
                {
                    new gagvr::CustomInterestMember(),
                },
                Id = -6774108720365892680L,
                CustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomInterest response = client.GetCustomInterest(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomInterestAsync()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
            };
            gagvr::CustomInterest expectedResponse = new gagvr::CustomInterest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Status = gagve::CustomInterestStatusEnum.Types.CustomInterestStatus.Enabled,
                Type = gagve::CustomInterestTypeEnum.Types.CustomInterestType.CustomIntent,
                Members =
                {
                    new gagvr::CustomInterestMember(),
                },
                Id = -6774108720365892680L,
                CustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomInterest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomInterest responseCallSettings = await client.GetCustomInterestAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CustomInterest responseCancellationToken = await client.GetCustomInterestAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomInterestResourceNames()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
            };
            gagvr::CustomInterest expectedResponse = new gagvr::CustomInterest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Status = gagve::CustomInterestStatusEnum.Types.CustomInterestStatus.Enabled,
                Type = gagve::CustomInterestTypeEnum.Types.CustomInterestType.CustomIntent,
                Members =
                {
                    new gagvr::CustomInterestMember(),
                },
                Id = -6774108720365892680L,
                CustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomInterest response = client.GetCustomInterest(request.ResourceNameAsCustomInterestName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomInterestResourceNamesAsync()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
            };
            gagvr::CustomInterest expectedResponse = new gagvr::CustomInterest
            {
                ResourceNameAsCustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Status = gagve::CustomInterestStatusEnum.Types.CustomInterestStatus.Enabled,
                Type = gagve::CustomInterestTypeEnum.Types.CustomInterestType.CustomIntent,
                Members =
                {
                    new gagvr::CustomInterestMember(),
                },
                Id = -6774108720365892680L,
                CustomInterestName = gagvr::CustomInterestName.FromCustomerCustomInterest("[CUSTOMER_ID]", "[CUSTOM_INTEREST_ID]"),
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomInterest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomInterest responseCallSettings = await client.GetCustomInterestAsync(request.ResourceNameAsCustomInterestName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CustomInterest responseCancellationToken = await client.GetCustomInterestAsync(request.ResourceNameAsCustomInterestName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateCustomInterestsRequestObject()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomInterestOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse
            {
                Results =
                {
                    new MutateCustomInterestResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomInterests(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomInterestsResponse response = client.MutateCustomInterests(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateCustomInterestsRequestObjectAsync()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomInterestOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse
            {
                Results =
                {
                    new MutateCustomInterestResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomInterestsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomInterestsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomInterestsResponse responseCallSettings = await client.MutateCustomInterestsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateCustomInterestsResponse responseCancellationToken = await client.MutateCustomInterestsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateCustomInterests()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomInterestOperation(),
                },
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse
            {
                Results =
                {
                    new MutateCustomInterestResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomInterests(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomInterestsResponse response = client.MutateCustomInterests(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateCustomInterestsAsync()
        {
            moq::Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new moq::Mock<CustomInterestService.CustomInterestServiceClient>(moq::MockBehavior.Strict);
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomInterestOperation(),
                },
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse
            {
                Results =
                {
                    new MutateCustomInterestResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomInterestsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomInterestsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomInterestsResponse responseCallSettings = await client.MutateCustomInterestsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateCustomInterestsResponse responseCancellationToken = await client.MutateCustomInterestsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
