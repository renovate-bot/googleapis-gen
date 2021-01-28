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

package com.google.cloud.osconfig.agentendpoint.v1beta;

import com.google.api.core.BetaApi;
import com.google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointServiceGrpc.AgentEndpointServiceImplBase;
import com.google.protobuf.AbstractMessage;
import io.grpc.stub.StreamObserver;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import javax.annotation.Generated;

@BetaApi
@Generated("by gapic-generator-java")
public class MockAgentEndpointServiceImpl extends AgentEndpointServiceImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockAgentEndpointServiceImpl() {
    requests = new ArrayList<>();
    responses = new LinkedList<>();
  }

  public List<AbstractMessage> getRequests() {
    return requests;
  }

  public void addResponse(AbstractMessage response) {
    responses.add(response);
  }

  public void setResponses(List<AbstractMessage> responses) {
    this.responses = new LinkedList<Object>(responses);
  }

  public void addException(Exception exception) {
    responses.add(exception);
  }

  public void reset() {
    requests = new ArrayList<>();
    responses = new LinkedList<>();
  }

  @Override
  public void receiveTaskNotification(
      ReceiveTaskNotificationRequest request,
      StreamObserver<ReceiveTaskNotificationResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ReceiveTaskNotificationResponse) {
      requests.add(request);
      responseObserver.onNext(((ReceiveTaskNotificationResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void startNextTask(
      StartNextTaskRequest request, StreamObserver<StartNextTaskResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof StartNextTaskResponse) {
      requests.add(request);
      responseObserver.onNext(((StartNextTaskResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void reportTaskProgress(
      ReportTaskProgressRequest request,
      StreamObserver<ReportTaskProgressResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ReportTaskProgressResponse) {
      requests.add(request);
      responseObserver.onNext(((ReportTaskProgressResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void reportTaskComplete(
      ReportTaskCompleteRequest request,
      StreamObserver<ReportTaskCompleteResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ReportTaskCompleteResponse) {
      requests.add(request);
      responseObserver.onNext(((ReportTaskCompleteResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void lookupEffectiveGuestPolicy(
      GuestPolicies.LookupEffectiveGuestPolicyRequest request,
      StreamObserver<GuestPolicies.EffectiveGuestPolicy> responseObserver) {
    Object response = responses.remove();
    if (response instanceof GuestPolicies.EffectiveGuestPolicy) {
      requests.add(request);
      responseObserver.onNext(((GuestPolicies.EffectiveGuestPolicy) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }

  @Override
  public void registerAgent(
      RegisterAgentRequest request, StreamObserver<RegisterAgentResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof RegisterAgentResponse) {
      requests.add(request);
      responseObserver.onNext(((RegisterAgentResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(new IllegalArgumentException("Unrecognized response type"));
    }
  }
}
