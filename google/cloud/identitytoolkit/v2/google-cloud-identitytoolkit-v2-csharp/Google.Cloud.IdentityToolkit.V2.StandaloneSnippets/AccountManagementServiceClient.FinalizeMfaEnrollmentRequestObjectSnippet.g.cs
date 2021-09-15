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
    using Google.Cloud.IdentityToolkit.V2;

    public sealed partial class GeneratedAccountManagementServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for FinalizeMfaEnrollment</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void FinalizeMfaEnrollmentRequestObject()
        {
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
        }
    }
}
