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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V7.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerAssetServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetCustomerAssetRequestObject()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::CustomerAsset expectedResponse = new gagvr::CustomerAsset
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerAsset response = client.GetCustomerAsset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomerAssetRequestObjectAsync()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::CustomerAsset expectedResponse = new gagvr::CustomerAsset
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetCustomerAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerAsset responseCallSettings = await client.GetCustomerAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CustomerAsset responseCancellationToken = await client.GetCustomerAssetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomerAsset()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::CustomerAsset expectedResponse = new gagvr::CustomerAsset
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerAsset response = client.GetCustomerAsset(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomerAssetAsync()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::CustomerAsset expectedResponse = new gagvr::CustomerAsset
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetCustomerAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerAsset responseCallSettings = await client.GetCustomerAssetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CustomerAsset responseCancellationToken = await client.GetCustomerAssetAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomerAssetResourceNames()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::CustomerAsset expectedResponse = new gagvr::CustomerAsset
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerAsset response = client.GetCustomerAsset(request.ResourceNameAsCustomerAssetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomerAssetResourceNamesAsync()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::CustomerAsset expectedResponse = new gagvr::CustomerAsset
            {
                ResourceNameAsCustomerAssetName = gagvr::CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetCustomerAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerAsset responseCallSettings = await client.GetCustomerAssetAsync(request.ResourceNameAsCustomerAssetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::CustomerAsset responseCancellationToken = await client.GetCustomerAssetAsync(request.ResourceNameAsCustomerAssetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateCustomerAssetsRequestObject()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerAssetsRequest request = new MutateCustomerAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerAssetsResponse expectedResponse = new MutateCustomerAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCustomerAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerAssetsResponse response = client.MutateCustomerAssets(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateCustomerAssetsRequestObjectAsync()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerAssetsRequest request = new MutateCustomerAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerAssetsResponse expectedResponse = new MutateCustomerAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCustomerAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerAssetsResponse responseCallSettings = await client.MutateCustomerAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateCustomerAssetsResponse responseCancellationToken = await client.MutateCustomerAssetsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateCustomerAssets()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerAssetsRequest request = new MutateCustomerAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerAssetOperation(),
                },
            };
            MutateCustomerAssetsResponse expectedResponse = new MutateCustomerAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCustomerAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerAssetsResponse response = client.MutateCustomerAssets(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateCustomerAssetsAsync()
        {
            moq::Mock<CustomerAssetService.CustomerAssetServiceClient> mockGrpcClient = new moq::Mock<CustomerAssetService.CustomerAssetServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerAssetsRequest request = new MutateCustomerAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerAssetOperation(),
                },
            };
            MutateCustomerAssetsResponse expectedResponse = new MutateCustomerAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateCustomerAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerAssetServiceClient client = new CustomerAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerAssetsResponse responseCallSettings = await client.MutateCustomerAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateCustomerAssetsResponse responseCancellationToken = await client.MutateCustomerAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
