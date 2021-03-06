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
 * <p>======================= RoutesPreferredClient =======================
 *
 * <p>Service Description: The Routes Preferred API.
 *
 * <p>Sample for RoutesPreferredClient:
 *
 * <pre>{@code
 * try (RoutesPreferredClient routesPreferredClient = RoutesPreferredClient.create()) {
 *   ComputeRoutesRequest request =
 *       ComputeRoutesRequest.newBuilder()
 *           .setOrigin(Waypoint.newBuilder().build())
 *           .setDestination(Waypoint.newBuilder().build())
 *           .addAllIntermediates(new ArrayList<Waypoint>())
 *           .setTravelMode(RouteTravelMode.forNumber(0))
 *           .setRoutingPreference(RoutingPreference.forNumber(0))
 *           .setPolylineQuality(PolylineQuality.forNumber(0))
 *           .setPolylineEncoding(PolylineEncoding.forNumber(0))
 *           .setDepartureTime(Timestamp.newBuilder().build())
 *           .setComputeAlternativeRoutes(true)
 *           .setRouteModifiers(RouteModifiers.newBuilder().build())
 *           .setLanguageCode("languageCode-2092349083")
 *           .setUnits(Units.forNumber(0))
 *           .build();
 *   ComputeRoutesResponse response = routesPreferredClient.computeRoutes(request);
 * }
 * }</pre>
 */
@Generated("by gapic-generator-java")
package com.google.maps.routespreferred.v1;

import javax.annotation.Generated;
