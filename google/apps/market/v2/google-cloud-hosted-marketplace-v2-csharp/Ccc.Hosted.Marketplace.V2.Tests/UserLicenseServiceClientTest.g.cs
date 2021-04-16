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
    public sealed class GeneratedUserLicenseServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<UserLicenseService.UserLicenseServiceClient> mockGrpcClient = new moq::Mock<UserLicenseService.UserLicenseServiceClient>(moq::MockBehavior.Strict);
            UserLicenseGetRequest request = new UserLicenseGetRequest
            {
                ApplicationId = "application_ideba4c06b",
                UserId = "user_idd41a70e8",
            };
            UserLicense expectedResponse = new UserLicense
            {
                Kind = "kindf7aa39d9",
                Enabled = true,
                State = "state2e9ed39e",
#pragma warning disable CS0612
                EditionId = "edition_idc7d1accf",
#pragma warning restore CS0612
                CustomerId = "customer_id3b3724cb",
                ApplicationId = "application_ideba4c06b",
                Id = "id74b70bb8",
                UserId = "user_idd41a70e8",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserLicenseServiceClient client = new UserLicenseServiceClientImpl(mockGrpcClient.Object, null);
            UserLicense response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<UserLicenseService.UserLicenseServiceClient> mockGrpcClient = new moq::Mock<UserLicenseService.UserLicenseServiceClient>(moq::MockBehavior.Strict);
            UserLicenseGetRequest request = new UserLicenseGetRequest
            {
                ApplicationId = "application_ideba4c06b",
                UserId = "user_idd41a70e8",
            };
            UserLicense expectedResponse = new UserLicense
            {
                Kind = "kindf7aa39d9",
                Enabled = true,
                State = "state2e9ed39e",
#pragma warning disable CS0612
                EditionId = "edition_idc7d1accf",
#pragma warning restore CS0612
                CustomerId = "customer_id3b3724cb",
                ApplicationId = "application_ideba4c06b",
                Id = "id74b70bb8",
                UserId = "user_idd41a70e8",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLicense>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserLicenseServiceClient client = new UserLicenseServiceClientImpl(mockGrpcClient.Object, null);
            UserLicense responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLicense responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
