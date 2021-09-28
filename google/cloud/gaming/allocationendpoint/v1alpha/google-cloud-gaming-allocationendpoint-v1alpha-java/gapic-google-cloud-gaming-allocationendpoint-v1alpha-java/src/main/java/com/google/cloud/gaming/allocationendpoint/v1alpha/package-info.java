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
 * A client to Allocation Endpoint API
 *
 * <p>The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= AllocationEndpointServiceClient =======================
 *
 * <p>Sample for AllocationEndpointServiceClient:
 *
 * <pre>{@code
 * try (AllocationEndpointServiceClient allocationEndpointServiceClient =
 *     AllocationEndpointServiceClient.create()) {
 *   AllocationRequest request =
 *       AllocationRequest.newBuilder()
 *           .setRealm("realm108386959")
 *           .setDefaultGameServerDeployment("defaultGameServerDeployment-1315595685")
 *           .addAllGameServerSelectors(new ArrayList<GameServerSelector>())
 *           .setMetadata(MetaPatch.newBuilder().build())
 *           .build();
 *   AllocationResponse response = allocationEndpointServiceClient.allocate(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.cloud.gaming.allocationendpoint.v1alpha;

import javax.annotation.Generated;
