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

using gagvc = Google.Ads.GoogleAds.V8.Common;
using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V8.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConversionActionServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetConversionActionRequestObject()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            gagvr::ConversionAction expectedResponse = new gagvr::ConversionAction
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                Status = gagve::ConversionActionStatusEnum.Types.ConversionActionStatus.Hidden,
                Type = gagve::ConversionActionTypeEnum.Types.ConversionActionType.Salesforce,
                Category = gagve::ConversionActionCategoryEnum.Types.ConversionActionCategory.AddToCart,
                ValueSettings = new gagvr::ConversionAction.Types.ValueSettings(),
                CountingType = gagve::ConversionActionCountingTypeEnum.Types.ConversionActionCountingType.Unspecified,
                AttributionModelSettings = new gagvr::ConversionAction.Types.AttributionModelSettings(),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                MobileAppVendor = gagve::MobileAppVendorEnum.Types.MobileAppVendor.GoogleAppStore,
                FirebaseSettings = new gagvr::ConversionAction.Types.FirebaseSettings(),
                ThirdPartyAppAnalyticsSettings = new gagvr::ConversionAction.Types.ThirdPartyAppAnalyticsSettings(),
                Id = -6774108720365892680L,
                ConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                IncludeInConversionsMetric = false,
                ClickThroughLookbackWindowDays = -4831593457096707011L,
                ViewThroughLookbackWindowDays = -8283075401830951626L,
                PhoneCallDurationSeconds = -8070508326407639729L,
                AppId = "app_idfead82f3",
            };
            mockGrpcClient.Setup(x => x.GetConversionAction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionAction response = client.GetConversionAction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionActionRequestObjectAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            gagvr::ConversionAction expectedResponse = new gagvr::ConversionAction
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                Status = gagve::ConversionActionStatusEnum.Types.ConversionActionStatus.Hidden,
                Type = gagve::ConversionActionTypeEnum.Types.ConversionActionType.Salesforce,
                Category = gagve::ConversionActionCategoryEnum.Types.ConversionActionCategory.AddToCart,
                ValueSettings = new gagvr::ConversionAction.Types.ValueSettings(),
                CountingType = gagve::ConversionActionCountingTypeEnum.Types.ConversionActionCountingType.Unspecified,
                AttributionModelSettings = new gagvr::ConversionAction.Types.AttributionModelSettings(),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                MobileAppVendor = gagve::MobileAppVendorEnum.Types.MobileAppVendor.GoogleAppStore,
                FirebaseSettings = new gagvr::ConversionAction.Types.FirebaseSettings(),
                ThirdPartyAppAnalyticsSettings = new gagvr::ConversionAction.Types.ThirdPartyAppAnalyticsSettings(),
                Id = -6774108720365892680L,
                ConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                IncludeInConversionsMetric = false,
                ClickThroughLookbackWindowDays = -4831593457096707011L,
                ViewThroughLookbackWindowDays = -8283075401830951626L,
                PhoneCallDurationSeconds = -8070508326407639729L,
                AppId = "app_idfead82f3",
            };
            mockGrpcClient.Setup(x => x.GetConversionActionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionAction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionAction responseCallSettings = await client.GetConversionActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::ConversionAction responseCancellationToken = await client.GetConversionActionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionAction()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            gagvr::ConversionAction expectedResponse = new gagvr::ConversionAction
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                Status = gagve::ConversionActionStatusEnum.Types.ConversionActionStatus.Hidden,
                Type = gagve::ConversionActionTypeEnum.Types.ConversionActionType.Salesforce,
                Category = gagve::ConversionActionCategoryEnum.Types.ConversionActionCategory.AddToCart,
                ValueSettings = new gagvr::ConversionAction.Types.ValueSettings(),
                CountingType = gagve::ConversionActionCountingTypeEnum.Types.ConversionActionCountingType.Unspecified,
                AttributionModelSettings = new gagvr::ConversionAction.Types.AttributionModelSettings(),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                MobileAppVendor = gagve::MobileAppVendorEnum.Types.MobileAppVendor.GoogleAppStore,
                FirebaseSettings = new gagvr::ConversionAction.Types.FirebaseSettings(),
                ThirdPartyAppAnalyticsSettings = new gagvr::ConversionAction.Types.ThirdPartyAppAnalyticsSettings(),
                Id = -6774108720365892680L,
                ConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                IncludeInConversionsMetric = false,
                ClickThroughLookbackWindowDays = -4831593457096707011L,
                ViewThroughLookbackWindowDays = -8283075401830951626L,
                PhoneCallDurationSeconds = -8070508326407639729L,
                AppId = "app_idfead82f3",
            };
            mockGrpcClient.Setup(x => x.GetConversionAction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionAction response = client.GetConversionAction(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionActionAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            gagvr::ConversionAction expectedResponse = new gagvr::ConversionAction
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                Status = gagve::ConversionActionStatusEnum.Types.ConversionActionStatus.Hidden,
                Type = gagve::ConversionActionTypeEnum.Types.ConversionActionType.Salesforce,
                Category = gagve::ConversionActionCategoryEnum.Types.ConversionActionCategory.AddToCart,
                ValueSettings = new gagvr::ConversionAction.Types.ValueSettings(),
                CountingType = gagve::ConversionActionCountingTypeEnum.Types.ConversionActionCountingType.Unspecified,
                AttributionModelSettings = new gagvr::ConversionAction.Types.AttributionModelSettings(),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                MobileAppVendor = gagve::MobileAppVendorEnum.Types.MobileAppVendor.GoogleAppStore,
                FirebaseSettings = new gagvr::ConversionAction.Types.FirebaseSettings(),
                ThirdPartyAppAnalyticsSettings = new gagvr::ConversionAction.Types.ThirdPartyAppAnalyticsSettings(),
                Id = -6774108720365892680L,
                ConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                IncludeInConversionsMetric = false,
                ClickThroughLookbackWindowDays = -4831593457096707011L,
                ViewThroughLookbackWindowDays = -8283075401830951626L,
                PhoneCallDurationSeconds = -8070508326407639729L,
                AppId = "app_idfead82f3",
            };
            mockGrpcClient.Setup(x => x.GetConversionActionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionAction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionAction responseCallSettings = await client.GetConversionActionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::ConversionAction responseCancellationToken = await client.GetConversionActionAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionActionResourceNames()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            gagvr::ConversionAction expectedResponse = new gagvr::ConversionAction
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                Status = gagve::ConversionActionStatusEnum.Types.ConversionActionStatus.Hidden,
                Type = gagve::ConversionActionTypeEnum.Types.ConversionActionType.Salesforce,
                Category = gagve::ConversionActionCategoryEnum.Types.ConversionActionCategory.AddToCart,
                ValueSettings = new gagvr::ConversionAction.Types.ValueSettings(),
                CountingType = gagve::ConversionActionCountingTypeEnum.Types.ConversionActionCountingType.Unspecified,
                AttributionModelSettings = new gagvr::ConversionAction.Types.AttributionModelSettings(),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                MobileAppVendor = gagve::MobileAppVendorEnum.Types.MobileAppVendor.GoogleAppStore,
                FirebaseSettings = new gagvr::ConversionAction.Types.FirebaseSettings(),
                ThirdPartyAppAnalyticsSettings = new gagvr::ConversionAction.Types.ThirdPartyAppAnalyticsSettings(),
                Id = -6774108720365892680L,
                ConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                IncludeInConversionsMetric = false,
                ClickThroughLookbackWindowDays = -4831593457096707011L,
                ViewThroughLookbackWindowDays = -8283075401830951626L,
                PhoneCallDurationSeconds = -8070508326407639729L,
                AppId = "app_idfead82f3",
            };
            mockGrpcClient.Setup(x => x.GetConversionAction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionAction response = client.GetConversionAction(request.ResourceNameAsConversionActionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionActionResourceNamesAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            gagvr::ConversionAction expectedResponse = new gagvr::ConversionAction
            {
                ResourceNameAsConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                Status = gagve::ConversionActionStatusEnum.Types.ConversionActionStatus.Hidden,
                Type = gagve::ConversionActionTypeEnum.Types.ConversionActionType.Salesforce,
                Category = gagve::ConversionActionCategoryEnum.Types.ConversionActionCategory.AddToCart,
                ValueSettings = new gagvr::ConversionAction.Types.ValueSettings(),
                CountingType = gagve::ConversionActionCountingTypeEnum.Types.ConversionActionCountingType.Unspecified,
                AttributionModelSettings = new gagvr::ConversionAction.Types.AttributionModelSettings(),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                MobileAppVendor = gagve::MobileAppVendorEnum.Types.MobileAppVendor.GoogleAppStore,
                FirebaseSettings = new gagvr::ConversionAction.Types.FirebaseSettings(),
                ThirdPartyAppAnalyticsSettings = new gagvr::ConversionAction.Types.ThirdPartyAppAnalyticsSettings(),
                Id = -6774108720365892680L,
                ConversionActionName = gagvr::ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                IncludeInConversionsMetric = false,
                ClickThroughLookbackWindowDays = -4831593457096707011L,
                ViewThroughLookbackWindowDays = -8283075401830951626L,
                PhoneCallDurationSeconds = -8070508326407639729L,
                AppId = "app_idfead82f3",
            };
            mockGrpcClient.Setup(x => x.GetConversionActionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionAction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionAction responseCallSettings = await client.GetConversionActionAsync(request.ResourceNameAsConversionActionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::ConversionAction responseCancellationToken = await client.GetConversionActionAsync(request.ResourceNameAsConversionActionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateConversionActionsRequestObject()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionActionsResponse response = client.MutateConversionActions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateConversionActionsRequestObjectAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionActionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionActionsResponse responseCallSettings = await client.MutateConversionActionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateConversionActionsResponse responseCancellationToken = await client.MutateConversionActionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateConversionActions()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionActionsResponse response = client.MutateConversionActions(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateConversionActionsAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionActionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionActionsResponse responseCallSettings = await client.MutateConversionActionsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateConversionActionsResponse responseCancellationToken = await client.MutateConversionActionsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
