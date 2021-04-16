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
    public sealed class GeneratedLicenseNotificationServiceClientTest
    {
        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<LicenseNotificationService.LicenseNotificationServiceClient> mockGrpcClient = new moq::Mock<LicenseNotificationService.LicenseNotificationServiceClient>(moq::MockBehavior.Strict);
            LicenseNotificationListRequest request = new LicenseNotificationListRequest
            {
                ApplicationId = "application_ideba4c06b",
                MaxResults = 2806814450U,
                StartToken = "start_token4a4e5304",
                Timestamp = 4440964450091394775UL,
            };
            LicenseNotificationList expectedResponse = new LicenseNotificationList
            {
                Kind = "kindf7aa39d9",
                Notifications =
                {
                    new LicenseNotification(),
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LicenseNotificationServiceClient client = new LicenseNotificationServiceClientImpl(mockGrpcClient.Object, null);
            LicenseNotificationList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<LicenseNotificationService.LicenseNotificationServiceClient> mockGrpcClient = new moq::Mock<LicenseNotificationService.LicenseNotificationServiceClient>(moq::MockBehavior.Strict);
            LicenseNotificationListRequest request = new LicenseNotificationListRequest
            {
                ApplicationId = "application_ideba4c06b",
                MaxResults = 2806814450U,
                StartToken = "start_token4a4e5304",
                Timestamp = 4440964450091394775UL,
            };
            LicenseNotificationList expectedResponse = new LicenseNotificationList
            {
                Kind = "kindf7aa39d9",
                Notifications =
                {
                    new LicenseNotification(),
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LicenseNotificationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LicenseNotificationServiceClient client = new LicenseNotificationServiceClientImpl(mockGrpcClient.Object, null);
            LicenseNotificationList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LicenseNotificationList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
