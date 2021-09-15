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

namespace Google.Cloud.IdentityToolkit.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccountManagementServiceClientTest
    {
        [xunit::FactAttribute]
        public void FinalizeMfaEnrollmentRequestObject()
        {
            moq::Mock<AccountManagementService.AccountManagementServiceClient> mockGrpcClient = new moq::Mock<AccountManagementService.AccountManagementServiceClient>(moq::MockBehavior.Strict);
            FinalizeMfaEnrollmentRequest request = new FinalizeMfaEnrollmentRequest
            {
                IdToken = "id_token74028acf",
                DisplayName = "display_name137f65c2",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            FinalizeMfaEnrollmentResponse expectedResponse = new FinalizeMfaEnrollmentResponse
            {
                IdToken = "id_token74028acf",
                RefreshToken = "refresh_tokendb4179e5",
                PhoneAuthInfo = new FinalizeMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.FinalizeMfaEnrollment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountManagementServiceClient client = new AccountManagementServiceClientImpl(mockGrpcClient.Object, null);
            FinalizeMfaEnrollmentResponse response = client.FinalizeMfaEnrollment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeMfaEnrollmentRequestObjectAsync()
        {
            moq::Mock<AccountManagementService.AccountManagementServiceClient> mockGrpcClient = new moq::Mock<AccountManagementService.AccountManagementServiceClient>(moq::MockBehavior.Strict);
            FinalizeMfaEnrollmentRequest request = new FinalizeMfaEnrollmentRequest
            {
                IdToken = "id_token74028acf",
                DisplayName = "display_name137f65c2",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            FinalizeMfaEnrollmentResponse expectedResponse = new FinalizeMfaEnrollmentResponse
            {
                IdToken = "id_token74028acf",
                RefreshToken = "refresh_tokendb4179e5",
                PhoneAuthInfo = new FinalizeMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.FinalizeMfaEnrollmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FinalizeMfaEnrollmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountManagementServiceClient client = new AccountManagementServiceClientImpl(mockGrpcClient.Object, null);
            FinalizeMfaEnrollmentResponse responseCallSettings = await client.FinalizeMfaEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FinalizeMfaEnrollmentResponse responseCancellationToken = await client.FinalizeMfaEnrollmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartMfaEnrollmentRequestObject()
        {
            moq::Mock<AccountManagementService.AccountManagementServiceClient> mockGrpcClient = new moq::Mock<AccountManagementService.AccountManagementServiceClient>(moq::MockBehavior.Strict);
            StartMfaEnrollmentRequest request = new StartMfaEnrollmentRequest
            {
                IdToken = "id_token74028acf",
                PhoneEnrollmentInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            StartMfaEnrollmentResponse expectedResponse = new StartMfaEnrollmentResponse
            {
                PhoneSessionInfo = new StartMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.StartMfaEnrollment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountManagementServiceClient client = new AccountManagementServiceClientImpl(mockGrpcClient.Object, null);
            StartMfaEnrollmentResponse response = client.StartMfaEnrollment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartMfaEnrollmentRequestObjectAsync()
        {
            moq::Mock<AccountManagementService.AccountManagementServiceClient> mockGrpcClient = new moq::Mock<AccountManagementService.AccountManagementServiceClient>(moq::MockBehavior.Strict);
            StartMfaEnrollmentRequest request = new StartMfaEnrollmentRequest
            {
                IdToken = "id_token74028acf",
                PhoneEnrollmentInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            StartMfaEnrollmentResponse expectedResponse = new StartMfaEnrollmentResponse
            {
                PhoneSessionInfo = new StartMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.StartMfaEnrollmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StartMfaEnrollmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountManagementServiceClient client = new AccountManagementServiceClientImpl(mockGrpcClient.Object, null);
            StartMfaEnrollmentResponse responseCallSettings = await client.StartMfaEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StartMfaEnrollmentResponse responseCancellationToken = await client.StartMfaEnrollmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WithdrawMfaRequestObject()
        {
            moq::Mock<AccountManagementService.AccountManagementServiceClient> mockGrpcClient = new moq::Mock<AccountManagementService.AccountManagementServiceClient>(moq::MockBehavior.Strict);
            WithdrawMfaRequest request = new WithdrawMfaRequest
            {
                IdToken = "id_token74028acf",
                MfaEnrollmentId = "mfa_enrollment_id898a6f5f",
                TenantId = "tenant_id14365438",
            };
            WithdrawMfaResponse expectedResponse = new WithdrawMfaResponse
            {
                IdToken = "id_token74028acf",
                RefreshToken = "refresh_tokendb4179e5",
            };
            mockGrpcClient.Setup(x => x.WithdrawMfa(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountManagementServiceClient client = new AccountManagementServiceClientImpl(mockGrpcClient.Object, null);
            WithdrawMfaResponse response = client.WithdrawMfa(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WithdrawMfaRequestObjectAsync()
        {
            moq::Mock<AccountManagementService.AccountManagementServiceClient> mockGrpcClient = new moq::Mock<AccountManagementService.AccountManagementServiceClient>(moq::MockBehavior.Strict);
            WithdrawMfaRequest request = new WithdrawMfaRequest
            {
                IdToken = "id_token74028acf",
                MfaEnrollmentId = "mfa_enrollment_id898a6f5f",
                TenantId = "tenant_id14365438",
            };
            WithdrawMfaResponse expectedResponse = new WithdrawMfaResponse
            {
                IdToken = "id_token74028acf",
                RefreshToken = "refresh_tokendb4179e5",
            };
            mockGrpcClient.Setup(x => x.WithdrawMfaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WithdrawMfaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountManagementServiceClient client = new AccountManagementServiceClientImpl(mockGrpcClient.Object, null);
            WithdrawMfaResponse responseCallSettings = await client.WithdrawMfaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WithdrawMfaResponse responseCancellationToken = await client.WithdrawMfaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
