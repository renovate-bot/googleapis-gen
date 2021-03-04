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

package com.google.maps.playablelocations.v3.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.maps.playablelocations.v3.LogImpressionsRequest;
import com.google.maps.playablelocations.v3.LogImpressionsResponse;
import com.google.maps.playablelocations.v3.LogPlayerReportsRequest;
import com.google.maps.playablelocations.v3.LogPlayerReportsResponse;
import com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest;
import com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the PlayableLocations service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class PlayableLocationsStub implements BackgroundResource {

  public UnaryCallable<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsCallable() {
    throw new UnsupportedOperationException("Not implemented: samplePlayableLocationsCallable()");
  }

  public UnaryCallable<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsCallable() {
    throw new UnsupportedOperationException("Not implemented: logPlayerReportsCallable()");
  }

  public UnaryCallable<LogImpressionsRequest, LogImpressionsResponse> logImpressionsCallable() {
    throw new UnsupportedOperationException("Not implemented: logImpressionsCallable()");
  }

  @Override
  public abstract void close();
}
