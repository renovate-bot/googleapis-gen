/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/**
 * A client to Identity Toolkit API
 *
 * <p>The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= AccountManagementServiceClient =======================
 *
 * <p>Service Description: Account management for Identity Toolkit
 *
 * <p>Sample for AccountManagementServiceClient:
 *
 * <pre>{@code
 * try (AccountManagementServiceClient accountManagementServiceClient =
 *     AccountManagementServiceClient.create()) {
 *   FinalizeMfaEnrollmentRequest request =
 *       FinalizeMfaEnrollmentRequest.newBuilder()
 *           .setIdToken("idToken1642509726")
 *           .setDisplayName("displayName1714148973")
 *           .setTenantId("tenantId-1306693787")
 *           .build();
 *   FinalizeMfaEnrollmentResponse response =
 *       accountManagementServiceClient.finalizeMfaEnrollment(request);
 * }
 * }</pre>
 *
 * <p>======================= AuthenticationServiceClient =======================
 *
 * <p>Service Description: Authentication for Identity Toolkit
 *
 * <p>Sample for AuthenticationServiceClient:
 *
 * <pre>{@code
 * try (AuthenticationServiceClient authenticationServiceClient =
 *     AuthenticationServiceClient.create()) {
 *   FinalizeMfaSignInRequest request =
 *       FinalizeMfaSignInRequest.newBuilder()
 *           .setMfaPendingCredential("mfaPendingCredential1875551302")
 *           .setTenantId("tenantId-1306693787")
 *           .build();
 *   FinalizeMfaSignInResponse response = authenticationServiceClient.finalizeMfaSignIn(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.cloud.identitytoolkit.v2;

import javax.annotation.Generated;
