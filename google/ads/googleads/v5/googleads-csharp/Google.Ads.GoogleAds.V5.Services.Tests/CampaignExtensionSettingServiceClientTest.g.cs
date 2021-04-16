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

using gagve = Google.Ads.GoogleAds.V5.Enums;
using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V5.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignExtensionSettingServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetCampaignExtensionSettingRequestObject()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCampaignExtensionSettingRequestObjectAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting responseCallSettings = await client.GetCampaignExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CampaignExtensionSetting responseCancellationToken = await client.GetCampaignExtensionSettingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCampaignExtensionSetting()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCampaignExtensionSettingAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting responseCallSettings = await client.GetCampaignExtensionSettingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CampaignExtensionSetting responseCancellationToken = await client.GetCampaignExtensionSettingAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCampaignExtensionSettingResourceNames()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request.ResourceNameAsCampaignExtensionSettingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCampaignExtensionSettingResourceNamesAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionSetting("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting responseCallSettings = await client.GetCampaignExtensionSettingAsync(request.ResourceNameAsCampaignExtensionSettingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CampaignExtensionSetting responseCancellationToken = await client.GetCampaignExtensionSettingAsync(request.ResourceNameAsCampaignExtensionSettingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateCampaignExtensionSettingsRequestObject()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateCampaignExtensionSettingsRequestObjectAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse responseCallSettings = await client.MutateCampaignExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateCampaignExtensionSettingsResponse responseCancellationToken = await client.MutateCampaignExtensionSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateCampaignExtensionSettings()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateCampaignExtensionSettingsAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse responseCallSettings = await client.MutateCampaignExtensionSettingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateCampaignExtensionSettingsResponse responseCancellationToken = await client.MutateCampaignExtensionSettingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
