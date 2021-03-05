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
 * <p>======================= DriveActivityServiceClient =======================
 *
 * <p>Service Description: Service for querying activity on Drive items. Activity is user or system
 * action on Drive items that happened in the past. A Drive item can be a file or folder, or a Team
 * Drive.
 *
 * <p>Sample for DriveActivityServiceClient:
 *
 * <pre>{@code
 * try (DriveActivityServiceClient driveActivityServiceClient =
 *     DriveActivityServiceClient.create()) {
 *   QueryDriveActivityRequest request =
 *       QueryDriveActivityRequest.newBuilder()
 *           .setConsolidationStrategy(ConsolidationStrategy.newBuilder().build())
 *           .setPageSize(883849137)
 *           .setPageToken("pageToken873572522")
 *           .setFilter("filter-1274492040")
 *           .build();
 *   for (DriveActivity element :
 *       driveActivityServiceClient.queryDriveActivity(request).iterateAll()) {
 *     // doThingsWith(element);
 *   }
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.apps.drive.activity.v2;

import javax.annotation.Generated;
