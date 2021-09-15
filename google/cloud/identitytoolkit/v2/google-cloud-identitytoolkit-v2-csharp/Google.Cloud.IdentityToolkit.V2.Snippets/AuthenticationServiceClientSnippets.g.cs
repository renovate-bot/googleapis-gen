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
    public sealed class GeneratedAuthenticationServiceClientSnippets
    {
        /// <summary>Snippet for FinalizeMfaSignIn</summary>
        public void FinalizeMfaSignInRequestObject()
        {
            // Snippet: FinalizeMfaSignIn(FinalizeMfaSignInRequest, CallSettings)
            // Create client
            AuthenticationServiceClient authenticationServiceClient = AuthenticationServiceClient.Create();
            // Initialize request argument(s)
            FinalizeMfaSignInRequest request = new FinalizeMfaSignInRequest
            {
                MfaPendingCredential = "",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            FinalizeMfaSignInResponse response = authenticationServiceClient.FinalizeMfaSignIn(request);
            // End snippet
        }

        /// <summary>Snippet for FinalizeMfaSignInAsync</summary>
        public async Task FinalizeMfaSignInRequestObjectAsync()
        {
            // Snippet: FinalizeMfaSignInAsync(FinalizeMfaSignInRequest, CallSettings)
            // Additional: FinalizeMfaSignInAsync(FinalizeMfaSignInRequest, CancellationToken)
            // Create client
            AuthenticationServiceClient authenticationServiceClient = await AuthenticationServiceClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeMfaSignInRequest request = new FinalizeMfaSignInRequest
            {
                MfaPendingCredential = "",
                PhoneVerificationInfo = new FinalizeMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            FinalizeMfaSignInResponse response = await authenticationServiceClient.FinalizeMfaSignInAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartMfaSignIn</summary>
        public void StartMfaSignInRequestObject()
        {
            // Snippet: StartMfaSignIn(StartMfaSignInRequest, CallSettings)
            // Create client
            AuthenticationServiceClient authenticationServiceClient = AuthenticationServiceClient.Create();
            // Initialize request argument(s)
            StartMfaSignInRequest request = new StartMfaSignInRequest
            {
                MfaPendingCredential = "",
                MfaEnrollmentId = "",
                PhoneSignInInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            StartMfaSignInResponse response = authenticationServiceClient.StartMfaSignIn(request);
            // End snippet
        }

        /// <summary>Snippet for StartMfaSignInAsync</summary>
        public async Task StartMfaSignInRequestObjectAsync()
        {
            // Snippet: StartMfaSignInAsync(StartMfaSignInRequest, CallSettings)
            // Additional: StartMfaSignInAsync(StartMfaSignInRequest, CancellationToken)
            // Create client
            AuthenticationServiceClient authenticationServiceClient = await AuthenticationServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartMfaSignInRequest request = new StartMfaSignInRequest
            {
                MfaPendingCredential = "",
                MfaEnrollmentId = "",
                PhoneSignInInfo = new StartMfaPhoneRequestInfo(),
                TenantId = "",
            };
            // Make the request
            StartMfaSignInResponse response = await authenticationServiceClient.StartMfaSignInAsync(request);
            // End snippet
        }
    }
}
