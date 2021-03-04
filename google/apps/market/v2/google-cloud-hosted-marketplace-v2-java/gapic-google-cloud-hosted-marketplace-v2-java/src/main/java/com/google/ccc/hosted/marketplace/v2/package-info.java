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
 * The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= CustomerLicenseServiceClient =======================
 *
 * <p>Sample for CustomerLicenseServiceClient:
 *
 * <pre>{@code
 * try (CustomerLicenseServiceClient customerLicenseServiceClient =
 *     CustomerLicenseServiceClient.create()) {
 *   CustomerLicenseGetRequest request =
 *       CustomerLicenseGetRequest.newBuilder()
 *           .setApplicationId("applicationId-1011352949")
 *           .setCustomerId("customerId-1581184615")
 *           .build();
 *   CustomerLicense response = customerLicenseServiceClient.get(request);
 * }
 * }</pre>
 *
 * <p>======================= LicenseNotificationServiceClient =======================
 *
 * <p>Sample for LicenseNotificationServiceClient:
 *
 * <pre>{@code
 * try (LicenseNotificationServiceClient licenseNotificationServiceClient =
 *     LicenseNotificationServiceClient.create()) {
 *   LicenseNotificationListRequest request =
 *       LicenseNotificationListRequest.newBuilder()
 *           .setApplicationId("applicationId-1011352949")
 *           .setMaxResults(1128457243)
 *           .setStartToken("startToken-1583451465")
 *           .setTimestamp(55126294)
 *           .build();
 *   LicenseNotificationList response = licenseNotificationServiceClient.list(request);
 * }
 * }</pre>
 *
 * <p>======================= UserLicenseServiceClient =======================
 *
 * <p>Sample for UserLicenseServiceClient:
 *
 * <pre>{@code
 * try (UserLicenseServiceClient userLicenseServiceClient = UserLicenseServiceClient.create()) {
 *   UserLicenseGetRequest request =
 *       UserLicenseGetRequest.newBuilder()
 *           .setApplicationId("applicationId-1011352949")
 *           .setUserId("userId-836030906")
 *           .build();
 *   UserLicense response = userLicenseServiceClient.get(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.ccc.hosted.marketplace.v2;

import javax.annotation.Generated;
