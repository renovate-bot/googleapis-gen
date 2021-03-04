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
 * <p>======================= SmartDeviceManagementServiceClient =======================
 *
 * <p>Service Description: A service that allows API consumers to provision and manage Google Home
 * structures and devices for enterprise use cases.
 *
 * <p>Sample for SmartDeviceManagementServiceClient:
 *
 * <pre>{@code
 * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
 *     SmartDeviceManagementServiceClient.create()) {
 *   GetDeviceRequest request = GetDeviceRequest.newBuilder().setName("name3373707").build();
 *   Device response = smartDeviceManagementServiceClient.getDevice(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.home.enterprise.sdm.v1;

import javax.annotation.Generated;
