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
 * <p>======================= PlayableLocationsClient =======================
 *
 * <p>Service Description: The Playable Locations API for v3.
 *
 * <p>Sample for PlayableLocationsClient:
 *
 * <pre>{@code
 * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
 *   SamplePlayableLocationsRequest request =
 *       SamplePlayableLocationsRequest.newBuilder()
 *           .setAreaFilter(AreaFilter.newBuilder().build())
 *           .addAllCriteria(new ArrayList<Criterion>())
 *           .build();
 *   SamplePlayableLocationsResponse response =
 *       playableLocationsClient.samplePlayableLocations(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.maps.playablelocations.v3;

import javax.annotation.Generated;
