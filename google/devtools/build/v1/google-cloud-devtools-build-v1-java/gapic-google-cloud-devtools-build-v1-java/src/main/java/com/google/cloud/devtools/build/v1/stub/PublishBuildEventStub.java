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

package com.google.cloud.devtools.build.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.BidiStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.devtools.build.v1.PublishBuildToolEventStreamRequest;
import com.google.devtools.build.v1.PublishBuildToolEventStreamResponse;
import com.google.devtools.build.v1.PublishLifecycleEventRequest;
import com.google.protobuf.Empty;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the PublishBuildEvent service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class PublishBuildEventStub implements BackgroundResource {

  public UnaryCallable<PublishLifecycleEventRequest, Empty> publishLifecycleEventCallable() {
    throw new UnsupportedOperationException("Not implemented: publishLifecycleEventCallable()");
  }

  public BidiStreamingCallable<
          PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
      publishBuildToolEventStreamCallable() {
    throw new UnsupportedOperationException(
        "Not implemented: publishBuildToolEventStreamCallable()");
  }

  @Override
  public abstract void close();
}
