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

package com.google.cloud.osconfig.agentendpoint.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest;
import com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse;
import com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest;
import com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse;
import com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest;
import com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse;
import com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest;
import com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse;
import com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest;
import com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse;
import com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest;
import com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the AgentEndpointService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class AgentEndpointServiceStub implements BackgroundResource {

  public ServerStreamingCallable<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationCallable() {
    throw new UnsupportedOperationException("Not implemented: receiveTaskNotificationCallable()");
  }

  public UnaryCallable<StartNextTaskRequest, StartNextTaskResponse> startNextTaskCallable() {
    throw new UnsupportedOperationException("Not implemented: startNextTaskCallable()");
  }

  public UnaryCallable<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressCallable() {
    throw new UnsupportedOperationException("Not implemented: reportTaskProgressCallable()");
  }

  public UnaryCallable<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteCallable() {
    throw new UnsupportedOperationException("Not implemented: reportTaskCompleteCallable()");
  }

  public UnaryCallable<RegisterAgentRequest, RegisterAgentResponse> registerAgentCallable() {
    throw new UnsupportedOperationException("Not implemented: registerAgentCallable()");
  }

  public UnaryCallable<ReportInventoryRequest, ReportInventoryResponse> reportInventoryCallable() {
    throw new UnsupportedOperationException("Not implemented: reportInventoryCallable()");
  }

  @Override
  public abstract void close();
}
