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
    public sealed class GeneratedConversionCustomVariableServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetConversionCustomVariableRequestObject()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            gagvr::ConversionCustomVariable expectedResponse = new gagvr::ConversionCustomVariable
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Id = -6774108720365892680L,
                ConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Tag = "tag843ed2e4",
                Status = gagve::ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Paused,
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetConversionCustomVariable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionCustomVariable response = client.GetConversionCustomVariable(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionCustomVariableRequestObjectAsync()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            gagvr::ConversionCustomVariable expectedResponse = new gagvr::ConversionCustomVariable
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Id = -6774108720365892680L,
                ConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Tag = "tag843ed2e4",
                Status = gagve::ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Paused,
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetConversionCustomVariableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionCustomVariable>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionCustomVariable responseCallSettings = await client.GetConversionCustomVariableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::ConversionCustomVariable responseCancellationToken = await client.GetConversionCustomVariableAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionCustomVariable()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            gagvr::ConversionCustomVariable expectedResponse = new gagvr::ConversionCustomVariable
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Id = -6774108720365892680L,
                ConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Tag = "tag843ed2e4",
                Status = gagve::ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Paused,
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetConversionCustomVariable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionCustomVariable response = client.GetConversionCustomVariable(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionCustomVariableAsync()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            gagvr::ConversionCustomVariable expectedResponse = new gagvr::ConversionCustomVariable
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Id = -6774108720365892680L,
                ConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Tag = "tag843ed2e4",
                Status = gagve::ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Paused,
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetConversionCustomVariableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionCustomVariable>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionCustomVariable responseCallSettings = await client.GetConversionCustomVariableAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::ConversionCustomVariable responseCancellationToken = await client.GetConversionCustomVariableAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionCustomVariableResourceNames()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            gagvr::ConversionCustomVariable expectedResponse = new gagvr::ConversionCustomVariable
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Id = -6774108720365892680L,
                ConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Tag = "tag843ed2e4",
                Status = gagve::ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Paused,
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetConversionCustomVariable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionCustomVariable response = client.GetConversionCustomVariable(request.ResourceNameAsConversionCustomVariableName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionCustomVariableResourceNamesAsync()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            gagvr::ConversionCustomVariable expectedResponse = new gagvr::ConversionCustomVariable
            {
                ResourceNameAsConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Id = -6774108720365892680L,
                ConversionCustomVariableName = gagvr::ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
                Tag = "tag843ed2e4",
                Status = gagve::ConversionCustomVariableStatusEnum.Types.ConversionCustomVariableStatus.Paused,
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetConversionCustomVariableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionCustomVariable>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionCustomVariable responseCallSettings = await client.GetConversionCustomVariableAsync(request.ResourceNameAsConversionCustomVariableName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gagvr::ConversionCustomVariable responseCancellationToken = await client.GetConversionCustomVariableAsync(request.ResourceNameAsConversionCustomVariableName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateConversionCustomVariablesRequestObject()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            MutateConversionCustomVariablesRequest request = new MutateConversionCustomVariablesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionCustomVariableOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionCustomVariablesResponse expectedResponse = new MutateConversionCustomVariablesResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateConversionCustomVariableResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionCustomVariables(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionCustomVariablesResponse response = client.MutateConversionCustomVariables(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateConversionCustomVariablesRequestObjectAsync()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            MutateConversionCustomVariablesRequest request = new MutateConversionCustomVariablesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionCustomVariableOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionCustomVariablesResponse expectedResponse = new MutateConversionCustomVariablesResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateConversionCustomVariableResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionCustomVariablesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionCustomVariablesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionCustomVariablesResponse responseCallSettings = await client.MutateConversionCustomVariablesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateConversionCustomVariablesResponse responseCancellationToken = await client.MutateConversionCustomVariablesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateConversionCustomVariables()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            MutateConversionCustomVariablesRequest request = new MutateConversionCustomVariablesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionCustomVariableOperation(),
                },
            };
            MutateConversionCustomVariablesResponse expectedResponse = new MutateConversionCustomVariablesResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateConversionCustomVariableResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionCustomVariables(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionCustomVariablesResponse response = client.MutateConversionCustomVariables(request.CustomerId, request.Operations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateConversionCustomVariablesAsync()
        {
            moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient> mockGrpcClient = new moq::Mock<ConversionCustomVariableService.ConversionCustomVariableServiceClient>(moq::MockBehavior.Strict);
            MutateConversionCustomVariablesRequest request = new MutateConversionCustomVariablesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionCustomVariableOperation(),
                },
            };
            MutateConversionCustomVariablesResponse expectedResponse = new MutateConversionCustomVariablesResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateConversionCustomVariableResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionCustomVariablesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionCustomVariablesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionCustomVariableServiceClient client = new ConversionCustomVariableServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionCustomVariablesResponse responseCallSettings = await client.MutateConversionCustomVariablesAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateConversionCustomVariablesResponse responseCancellationToken = await client.MutateConversionCustomVariablesAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
