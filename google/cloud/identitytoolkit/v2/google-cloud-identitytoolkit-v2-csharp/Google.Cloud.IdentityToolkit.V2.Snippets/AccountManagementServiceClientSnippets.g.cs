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

namespace Google.Cloud.IdentityToolkit.V2.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAccountManagementServiceClientSnippets
    {
        /// <summary>Snippet for FinalizeMfaEnrollment</summary>
        public void FinalizeMfaEnrollmentRequestObject()
        {
            // Snippet: FinalizeMfaEnrollment(FinalizeMfaEnrollmentRequest, CallSettings)
            // Create client
            AccountManagementServiceClient accountManagementServiceClient = AccountManagementServiceClient.Create();
            // Initialize request argument(s)
            FinalizeMfaEnrollmentRequest request = new FinalizeMfaEnrollmentRequest
            {
                IdToken = "",
                DisplayName = "",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            FinalizeMfaEnrollmentResponse response = accountManagementServiceClient.FinalizeMfaEnrollment(request);
            // End snippet
        }

        /// <summary>Snippet for FinalizeMfaEnrollmentAsync</summary>
        public async Task FinalizeMfaEnrollmentRequestObjectAsync()
        {
            // Snippet: FinalizeMfaEnrollmentAsync(FinalizeMfaEnrollmentRequest, CallSettings)
            // Additional: FinalizeMfaEnrollmentAsync(FinalizeMfaEnrollmentRequest, CancellationToken)
            // Create client
            AccountManagementServiceClient accountManagementServiceClient = await AccountManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeMfaEnrollmentRequest request = new FinalizeMfaEnrollmentRequest
            {
                IdToken = "",
                DisplayName = "",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            FinalizeMfaEnrollmentResponse response = await accountManagementServiceClient.FinalizeMfaEnrollmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartMfaEnrollment</summary>
        public void StartMfaEnrollmentRequestObject()
        {
            // Snippet: StartMfaEnrollment(StartMfaEnrollmentRequest, CallSettings)
            // Create client
            AccountManagementServiceClient accountManagementServiceClient = AccountManagementServiceClient.Create();
            // Initialize request argument(s)
            StartMfaEnrollmentRequest request = new StartMfaEnrollmentRequest
            {
                IdToken = "",
                PhoneEnrollmentInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            StartMfaEnrollmentResponse response = accountManagementServiceClient.StartMfaEnrollment(request);
            // End snippet
        }

        /// <summary>Snippet for StartMfaEnrollmentAsync</summary>
        public async Task StartMfaEnrollmentRequestObjectAsync()
        {
            // Snippet: StartMfaEnrollmentAsync(StartMfaEnrollmentRequest, CallSettings)
            // Additional: StartMfaEnrollmentAsync(StartMfaEnrollmentRequest, CancellationToken)
            // Create client
            AccountManagementServiceClient accountManagementServiceClient = await AccountManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartMfaEnrollmentRequest request = new StartMfaEnrollmentRequest
            {
                IdToken = "",
                PhoneEnrollmentInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            StartMfaEnrollmentResponse response = await accountManagementServiceClient.StartMfaEnrollmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WithdrawMfa</summary>
        public void WithdrawMfaRequestObject()
        {
            // Snippet: WithdrawMfa(WithdrawMfaRequest, CallSettings)
            // Create client
            AccountManagementServiceClient accountManagementServiceClient = AccountManagementServiceClient.Create();
            // Initialize request argument(s)
            WithdrawMfaRequest request = new WithdrawMfaRequest
            {
                IdToken = "",
                MfaEnrollmentId = "",
                TenantId = "",
            };
            // Make the request
            WithdrawMfaResponse response = accountManagementServiceClient.WithdrawMfa(request);
            // End snippet
        }

        /// <summary>Snippet for WithdrawMfaAsync</summary>
        public async Task WithdrawMfaRequestObjectAsync()
        {
            // Snippet: WithdrawMfaAsync(WithdrawMfaRequest, CallSettings)
            // Additional: WithdrawMfaAsync(WithdrawMfaRequest, CancellationToken)
            // Create client
            AccountManagementServiceClient accountManagementServiceClient = await AccountManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            WithdrawMfaRequest request = new WithdrawMfaRequest
            {
                IdToken = "",
                MfaEnrollmentId = "",
                TenantId = "",
            };
            // Make the request
            WithdrawMfaResponse response = await accountManagementServiceClient.WithdrawMfaAsync(request);
            // End snippet
        }
    }
}
