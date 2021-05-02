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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V7.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupCriterionLabelServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAdGroupCriterionLabelRequestObject()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAdGroupCriterionLabelRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel responseCallSettings = await client.GetAdGroupCriterionLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionLabel responseCancellationToken = await client.GetAdGroupCriterionLabelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAdGroupCriterionLabel()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAdGroupCriterionLabelAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel responseCallSettings = await client.GetAdGroupCriterionLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionLabel responseCancellationToken = await client.GetAdGroupCriterionLabelAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAdGroupCriterionLabelResourceNames()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request.ResourceNameAsAdGroupCriterionLabelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAdGroupCriterionLabelResourceNamesAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel responseCallSettings = await client.GetAdGroupCriterionLabelAsync(request.ResourceNameAsAdGroupCriterionLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionLabel responseCancellationToken = await client.GetAdGroupCriterionLabelAsync(request.ResourceNameAsAdGroupCriterionLabelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateAdGroupCriterionLabelsRequestObject()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateAdGroupCriterionLabelsRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse responseCallSettings = await client.MutateAdGroupCriterionLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateAdGroupCriterionLabelsResponse responseCancellationToken = await client.MutateAdGroupCriterionLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateAdGroupCriterionLabels()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateAdGroupCriterionLabelsAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse responseCallSettings = await client.MutateAdGroupCriterionLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateAdGroupCriterionLabelsResponse responseCancellationToken = await client.MutateAdGroupCriterionLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
