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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Ccc.Hosted.Marketplace.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerLicenseServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<CustomerLicenseService.CustomerLicenseServiceClient> mockGrpcClient = new moq::Mock<CustomerLicenseService.CustomerLicenseServiceClient>(moq::MockBehavior.Strict);
            CustomerLicenseGetRequest request = new CustomerLicenseGetRequest
            {
                ApplicationId = "application_ideba4c06b",
                CustomerId = "customer_id3b3724cb",
            };
            CustomerLicense expectedResponse = new CustomerLicense
            {
                Kind = "kindf7aa39d9",
                State = "state2e9ed39e",
                ApplicationId = "application_ideba4c06b",
#pragma warning disable CS0612
                Editions =
#pragma warning restore CS0612
                {
                    new CustomerLicense.Types.Editions(),
                },
                Id = "id74b70bb8",
                CustomerId = "customer_id3b3724cb",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerLicenseServiceClient client = new CustomerLicenseServiceClientImpl(mockGrpcClient.Object, null);
            CustomerLicense response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<CustomerLicenseService.CustomerLicenseServiceClient> mockGrpcClient = new moq::Mock<CustomerLicenseService.CustomerLicenseServiceClient>(moq::MockBehavior.Strict);
            CustomerLicenseGetRequest request = new CustomerLicenseGetRequest
            {
                ApplicationId = "application_ideba4c06b",
                CustomerId = "customer_id3b3724cb",
            };
            CustomerLicense expectedResponse = new CustomerLicense
            {
                Kind = "kindf7aa39d9",
                State = "state2e9ed39e",
                ApplicationId = "application_ideba4c06b",
#pragma warning disable CS0612
                Editions =
#pragma warning restore CS0612
                {
                    new CustomerLicense.Types.Editions(),
                },
                Id = "id74b70bb8",
                CustomerId = "customer_id3b3724cb",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomerLicense>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLicenseServiceClient client = new CustomerLicenseServiceClientImpl(mockGrpcClient.Object, null);
            CustomerLicense responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomerLicense responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
