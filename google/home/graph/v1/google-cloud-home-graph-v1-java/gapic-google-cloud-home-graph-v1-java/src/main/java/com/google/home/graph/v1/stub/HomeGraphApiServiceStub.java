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

package com.google.home.graph.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.home.graph.v1.HomeGraphApiServiceProto;
import com.google.protobuf.Empty;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the HomeGraphApiService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class HomeGraphApiServiceStub implements BackgroundResource {

  public UnaryCallable<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesCallable() {
    throw new UnsupportedOperationException("Not implemented: requestSyncDevicesCallable()");
  }

  public UnaryCallable<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationCallable() {
    throw new UnsupportedOperationException(
        "Not implemented: reportStateAndNotificationCallable()");
  }

  public UnaryCallable<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteAgentUserCallable()");
  }

  public UnaryCallable<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      queryCallable() {
    throw new UnsupportedOperationException("Not implemented: queryCallable()");
  }

  public UnaryCallable<HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncCallable() {
    throw new UnsupportedOperationException("Not implemented: syncCallable()");
  }

  @Override
  public abstract void close();
}
