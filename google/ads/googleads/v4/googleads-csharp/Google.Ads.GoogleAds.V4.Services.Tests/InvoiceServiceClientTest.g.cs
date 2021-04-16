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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Ads.GoogleAds.V4.Services.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedInvoiceServiceClientTest
    {
        [xunit::FactAttribute]
        public void ListInvoicesRequestObject()
        {
            moq::Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new moq::Mock<InvoiceService.InvoiceServiceClient>(moq::MockBehavior.Strict);
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "customer_id3b3724cb",
                BillingSetup = "billing_setupa2c2701f",
                IssueYear = "issue_yeara1ebdef1",
                IssueMonth = gagve::MonthOfYearEnum.Types.MonthOfYear.January,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse
            {
                Invoices =
                {
                    new gagvr::Invoice(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInvoices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            ListInvoicesResponse response = client.ListInvoices(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInvoicesRequestObjectAsync()
        {
            moq::Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new moq::Mock<InvoiceService.InvoiceServiceClient>(moq::MockBehavior.Strict);
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "customer_id3b3724cb",
                BillingSetup = "billing_setupa2c2701f",
                IssueYear = "issue_yeara1ebdef1",
                IssueMonth = gagve::MonthOfYearEnum.Types.MonthOfYear.January,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse
            {
                Invoices =
                {
                    new gagvr::Invoice(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInvoicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInvoicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            ListInvoicesResponse responseCallSettings = await client.ListInvoicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInvoicesResponse responseCancellationToken = await client.ListInvoicesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInvoices()
        {
            moq::Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new moq::Mock<InvoiceService.InvoiceServiceClient>(moq::MockBehavior.Strict);
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "customer_id3b3724cb",
                BillingSetup = "billing_setupa2c2701f",
                IssueYear = "issue_yeara1ebdef1",
                IssueMonth = gagve::MonthOfYearEnum.Types.MonthOfYear.January,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse
            {
                Invoices =
                {
                    new gagvr::Invoice(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInvoices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            ListInvoicesResponse response = client.ListInvoices(request.CustomerId, request.BillingSetup, request.IssueYear, request.IssueMonth);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInvoicesAsync()
        {
            moq::Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new moq::Mock<InvoiceService.InvoiceServiceClient>(moq::MockBehavior.Strict);
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "customer_id3b3724cb",
                BillingSetup = "billing_setupa2c2701f",
                IssueYear = "issue_yeara1ebdef1",
                IssueMonth = gagve::MonthOfYearEnum.Types.MonthOfYear.January,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse
            {
                Invoices =
                {
                    new gagvr::Invoice(),
                },
            };
            mockGrpcClient.Setup(x => x.ListInvoicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInvoicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            ListInvoicesResponse responseCallSettings = await client.ListInvoicesAsync(request.CustomerId, request.BillingSetup, request.IssueYear, request.IssueMonth, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInvoicesResponse responseCancellationToken = await client.ListInvoicesAsync(request.CustomerId, request.BillingSetup, request.IssueYear, request.IssueMonth, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
