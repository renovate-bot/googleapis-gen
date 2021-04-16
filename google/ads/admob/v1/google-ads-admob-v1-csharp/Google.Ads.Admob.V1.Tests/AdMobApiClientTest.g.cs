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

namespace Google.Ads.Admob.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdMobApiClientTest
    {
        [xunit::FactAttribute]
        public void GetPublisherAccountRequestObject()
        {
            moq::Mock<AdMobApi.AdMobApiClient> mockGrpcClient = new moq::Mock<AdMobApi.AdMobApiClient>(moq::MockBehavior.Strict);
            GetPublisherAccountRequest request = new GetPublisherAccountRequest
            {
                Name = "name1c9368b0",
            };
            PublisherAccount expectedResponse = new PublisherAccount
            {
                PublisherAccountName = PublisherAccountName.FromPublisher("[PUBLISHER]"),
                PublisherId = "publisher_ideacb0426",
                ReportingTimeZone = "reporting_time_zonee4c984d5",
                CurrencyCode = "currency_code7f81e352",
            };
            mockGrpcClient.Setup(x => x.GetPublisherAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdMobApiClient client = new AdMobApiClientImpl(mockGrpcClient.Object, null);
            PublisherAccount response = client.GetPublisherAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPublisherAccountRequestObjectAsync()
        {
            moq::Mock<AdMobApi.AdMobApiClient> mockGrpcClient = new moq::Mock<AdMobApi.AdMobApiClient>(moq::MockBehavior.Strict);
            GetPublisherAccountRequest request = new GetPublisherAccountRequest
            {
                Name = "name1c9368b0",
            };
            PublisherAccount expectedResponse = new PublisherAccount
            {
                PublisherAccountName = PublisherAccountName.FromPublisher("[PUBLISHER]"),
                PublisherId = "publisher_ideacb0426",
                ReportingTimeZone = "reporting_time_zonee4c984d5",
                CurrencyCode = "currency_code7f81e352",
            };
            mockGrpcClient.Setup(x => x.GetPublisherAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublisherAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdMobApiClient client = new AdMobApiClientImpl(mockGrpcClient.Object, null);
            PublisherAccount responseCallSettings = await client.GetPublisherAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublisherAccount responseCancellationToken = await client.GetPublisherAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPublisherAccount()
        {
            moq::Mock<AdMobApi.AdMobApiClient> mockGrpcClient = new moq::Mock<AdMobApi.AdMobApiClient>(moq::MockBehavior.Strict);
            GetPublisherAccountRequest request = new GetPublisherAccountRequest
            {
                Name = "name1c9368b0",
            };
            PublisherAccount expectedResponse = new PublisherAccount
            {
                PublisherAccountName = PublisherAccountName.FromPublisher("[PUBLISHER]"),
                PublisherId = "publisher_ideacb0426",
                ReportingTimeZone = "reporting_time_zonee4c984d5",
                CurrencyCode = "currency_code7f81e352",
            };
            mockGrpcClient.Setup(x => x.GetPublisherAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdMobApiClient client = new AdMobApiClientImpl(mockGrpcClient.Object, null);
            PublisherAccount response = client.GetPublisherAccount(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPublisherAccountAsync()
        {
            moq::Mock<AdMobApi.AdMobApiClient> mockGrpcClient = new moq::Mock<AdMobApi.AdMobApiClient>(moq::MockBehavior.Strict);
            GetPublisherAccountRequest request = new GetPublisherAccountRequest
            {
                Name = "name1c9368b0",
            };
            PublisherAccount expectedResponse = new PublisherAccount
            {
                PublisherAccountName = PublisherAccountName.FromPublisher("[PUBLISHER]"),
                PublisherId = "publisher_ideacb0426",
                ReportingTimeZone = "reporting_time_zonee4c984d5",
                CurrencyCode = "currency_code7f81e352",
            };
            mockGrpcClient.Setup(x => x.GetPublisherAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublisherAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdMobApiClient client = new AdMobApiClientImpl(mockGrpcClient.Object, null);
            PublisherAccount responseCallSettings = await client.GetPublisherAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublisherAccount responseCancellationToken = await client.GetPublisherAccountAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
