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
 * A client to ChromeOS UI Detection API
 *
 * <p>The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= UiDetectionServiceClient =======================
 *
 * <p>Service Description: Provides image-based UI detection service.
 *
 * <p>Sample for UiDetectionServiceClient:
 *
 * <pre>{@code
 * try (UiDetectionServiceClient uiDetectionServiceClient = UiDetectionServiceClient.create()) {
 *   UiDetectionRequest request =
 *       UiDetectionRequest.newBuilder()
 *           .setImagePng(ByteString.EMPTY)
 *           .setRequest(DetectionRequest.newBuilder().build())
 *           .build();
 *   UiDetectionResponse response = uiDetectionServiceClient.executeDetection(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.chromeos.uidetection.v1;

import javax.annotation.Generated;
