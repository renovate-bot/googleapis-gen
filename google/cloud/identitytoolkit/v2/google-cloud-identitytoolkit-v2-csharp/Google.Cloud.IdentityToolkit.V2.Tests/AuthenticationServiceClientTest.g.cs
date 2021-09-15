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
    public sealed class GeneratedAuthenticationServiceClientTest
    {
        [xunit::FactAttribute]
        public void FinalizeMfaSignInRequestObject()
        {
            moq::Mock<AuthenticationService.AuthenticationServiceClient> mockGrpcClient = new moq::Mock<AuthenticationService.AuthenticationServiceClient>(moq::MockBehavior.Strict);
            FinalizeMfaSignInRequest request = new FinalizeMfaSignInRequest
            {
                MfaPendingCredential = "mfa_pending_credential062d552a",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            FinalizeMfaSignInResponse expectedResponse = new FinalizeMfaSignInResponse
            {
                IdToken = "id_token74028acf",
                RefreshToken = "refresh_tokendb4179e5",
                PhoneAuthInfo = new FinalizeMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.FinalizeMfaSignIn(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AuthenticationServiceClient client = new AuthenticationServiceClientImpl(mockGrpcClient.Object, null);
            FinalizeMfaSignInResponse response = client.FinalizeMfaSignIn(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FinalizeMfaSignInRequestObjectAsync()
        {
            moq::Mock<AuthenticationService.AuthenticationServiceClient> mockGrpcClient = new moq::Mock<AuthenticationService.AuthenticationServiceClient>(moq::MockBehavior.Strict);
            FinalizeMfaSignInRequest request = new FinalizeMfaSignInRequest
            {
                MfaPendingCredential = "mfa_pending_credential062d552a",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            FinalizeMfaSignInResponse expectedResponse = new FinalizeMfaSignInResponse
            {
                IdToken = "id_token74028acf",
                RefreshToken = "refresh_tokendb4179e5",
                PhoneAuthInfo = new FinalizeMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.FinalizeMfaSignInAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FinalizeMfaSignInResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AuthenticationServiceClient client = new AuthenticationServiceClientImpl(mockGrpcClient.Object, null);
            FinalizeMfaSignInResponse responseCallSettings = await client.FinalizeMfaSignInAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FinalizeMfaSignInResponse responseCancellationToken = await client.FinalizeMfaSignInAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartMfaSignInRequestObject()
        {
            moq::Mock<AuthenticationService.AuthenticationServiceClient> mockGrpcClient = new moq::Mock<AuthenticationService.AuthenticationServiceClient>(moq::MockBehavior.Strict);
            StartMfaSignInRequest request = new StartMfaSignInRequest
            {
                MfaPendingCredential = "mfa_pending_credential062d552a",
                MfaEnrollmentId = "mfa_enrollment_id898a6f5f",
                PhoneSignInInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            StartMfaSignInResponse expectedResponse = new StartMfaSignInResponse
            {
                PhoneResponseInfo = new StartMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.StartMfaSignIn(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AuthenticationServiceClient client = new AuthenticationServiceClientImpl(mockGrpcClient.Object, null);
            StartMfaSignInResponse response = client.StartMfaSignIn(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartMfaSignInRequestObjectAsync()
        {
            moq::Mock<AuthenticationService.AuthenticationServiceClient> mockGrpcClient = new moq::Mock<AuthenticationService.AuthenticationServiceClient>(moq::MockBehavior.Strict);
            StartMfaSignInRequest request = new StartMfaSignInRequest
            {
                MfaPendingCredential = "mfa_pending_credential062d552a",
                MfaEnrollmentId = "mfa_enrollment_id898a6f5f",
                PhoneSignInInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "tenant_id14365438",
            };
            StartMfaSignInResponse expectedResponse = new StartMfaSignInResponse
            {
                PhoneResponseInfo = new StartMfaPhoneResponseInfo(),
            };
            mockGrpcClient.Setup(x => x.StartMfaSignInAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<StartMfaSignInResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AuthenticationServiceClient client = new AuthenticationServiceClientImpl(mockGrpcClient.Object, null);
            StartMfaSignInResponse responseCallSettings = await client.StartMfaSignInAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            StartMfaSignInResponse responseCancellationToken = await client.StartMfaSignInAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
