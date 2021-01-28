/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/**
 * A client to Playable Locations API.
 *
 * <p>The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= PlayableLocationsClient =======================
 *
 * <p>Service Description: The Playable Locations API for v3.
 *
 * <p>Sample for PlayableLocationsClient:
 *
 * <pre>
 * <code>
 * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
 *   AreaFilter areaFilter = AreaFilter.newBuilder().build();
 *   List&lt;Criterion&gt; criteria = new ArrayList&lt;&gt;();
 *   SamplePlayableLocationsRequest request = SamplePlayableLocationsRequest.newBuilder()
 *     .setAreaFilter(areaFilter)
 *     .addAllCriteria(criteria)
 *     .build();
 *   SamplePlayableLocationsResponse response = playableLocationsClient.samplePlayableLocations(request);
 * }
 * </code>
 * </pre>
 */
@Generated("by gapic-generator")
package com.google.maps.playablelocations.v3;

import javax.annotation.Generated;
