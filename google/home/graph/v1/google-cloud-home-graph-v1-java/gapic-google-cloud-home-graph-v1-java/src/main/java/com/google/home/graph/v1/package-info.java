/*
 * Copyright 2020 Google LLC
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
 * <p>======================= HomeGraphApiServiceClient =======================
 *
 * <p>Service Description: Google Home Graph API service. The Home Graph service provides support
 * for accessing first-party and third-party devices stored in Google's Home Graph. The Home Graph
 * database provides contextual data about the relationships between devices and the home.
 *
 * <p>For more details, see the [Home Graph developer
 * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
 *
 * <p>Sample for HomeGraphApiServiceClient:
 *
 * <pre>{@code
 * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
 *   String agentUserId = "agentUserId1708672427";
 *   HomeGraphApiServiceProto.RequestSyncDevicesResponse response =
 *       homeGraphApiServiceClient.requestSyncDevices(agentUserId);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.home.graph.v1;

import javax.annotation.Generated;
