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
package com.google.maps.roads.v1op.stub;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.maps.roads.v1op.ListNearestRoadsRequest;
import com.google.maps.roads.v1op.ListNearestRoadsResponse;
import com.google.maps.roads.v1op.SnapToRoadsRequest;
import com.google.maps.roads.v1op.SnapToRoadsResponse;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS
/**
 * Base stub class for Roads API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator")
@BetaApi("A restructuring of stub classes is planned, so this may break in the future")
public abstract class RoadsServiceStub implements BackgroundResource {

  public UnaryCallable<SnapToRoadsRequest, SnapToRoadsResponse> snapToRoadsCallable() {
    throw new UnsupportedOperationException("Not implemented: snapToRoadsCallable()");
  }

  public UnaryCallable<ListNearestRoadsRequest, ListNearestRoadsResponse>
      listNearestRoadsCallable() {
    throw new UnsupportedOperationException("Not implemented: listNearestRoadsCallable()");
  }

  @Override
  public abstract void close();
}
