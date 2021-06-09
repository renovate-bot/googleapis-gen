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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V8.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPaymentsAccountServiceClientTest
    {
        [xunit::FactAttribute]
        public void ListPaymentsAccountsRequestObject()
        {
            moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient>(moq::MockBehavior.Strict);
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse
            {
                PaymentsAccounts =
                {
                    new gagvr::PaymentsAccount(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPaymentsAccounts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            ListPaymentsAccountsResponse response = client.ListPaymentsAccounts(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPaymentsAccountsRequestObjectAsync()
        {
            moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient>(moq::MockBehavior.Strict);
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse
            {
                PaymentsAccounts =
                {
                    new gagvr::PaymentsAccount(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPaymentsAccountsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListPaymentsAccountsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            ListPaymentsAccountsResponse responseCallSettings = await client.ListPaymentsAccountsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListPaymentsAccountsResponse responseCancellationToken = await client.ListPaymentsAccountsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPaymentsAccounts()
        {
            moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient>(moq::MockBehavior.Strict);
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse
            {
                PaymentsAccounts =
                {
                    new gagvr::PaymentsAccount(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPaymentsAccounts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            ListPaymentsAccountsResponse response = client.ListPaymentsAccounts(request.CustomerId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPaymentsAccountsAsync()
        {
            moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new moq::Mock<PaymentsAccountService.PaymentsAccountServiceClient>(moq::MockBehavior.Strict);
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse
            {
                PaymentsAccounts =
                {
                    new gagvr::PaymentsAccount(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPaymentsAccountsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListPaymentsAccountsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            ListPaymentsAccountsResponse responseCallSettings = await client.ListPaymentsAccountsAsync(request.CustomerId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListPaymentsAccountsResponse responseCancellationToken = await client.ListPaymentsAccountsAsync(request.CustomerId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
