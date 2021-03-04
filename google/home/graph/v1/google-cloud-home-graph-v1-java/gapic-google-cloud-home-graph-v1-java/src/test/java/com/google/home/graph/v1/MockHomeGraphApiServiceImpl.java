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

package com.google.home.graph.v1;

import com.google.api.core.BetaApi;
import com.google.home.graph.v1.HomeGraphApiServiceGrpc.HomeGraphApiServiceImplBase;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Empty;
import io.grpc.stub.StreamObserver;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import javax.annotation.Generated;

@BetaApi
@Generated("by gapic-generator-java")
public class MockHomeGraphApiServiceImpl extends HomeGraphApiServiceImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockHomeGraphApiServiceImpl() {
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
  public void requestSyncDevices(
      HomeGraphApiServiceProto.RequestSyncDevicesRequest request,
      StreamObserver<HomeGraphApiServiceProto.RequestSyncDevicesResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof HomeGraphApiServiceProto.RequestSyncDevicesResponse) {
      requests.add(request);
      responseObserver.onNext(((HomeGraphApiServiceProto.RequestSyncDevicesResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method RequestSyncDevices, expected %s or %s",
                  response.getClass().getName(),
                  HomeGraphApiServiceProto.RequestSyncDevicesResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void reportStateAndNotification(
      HomeGraphApiServiceProto.ReportStateAndNotificationRequest request,
      StreamObserver<HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
          responseObserver) {
    Object response = responses.remove();
    if (response instanceof HomeGraphApiServiceProto.ReportStateAndNotificationResponse) {
      requests.add(request);
      responseObserver.onNext(
          ((HomeGraphApiServiceProto.ReportStateAndNotificationResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ReportStateAndNotification, expected %s or %s",
                  response.getClass().getName(),
                  HomeGraphApiServiceProto.ReportStateAndNotificationResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void deleteAgentUser(
      HomeGraphApiServiceProto.DeleteAgentUserRequest request,
      StreamObserver<Empty> responseObserver) {
    Object response = responses.remove();
    if (response instanceof Empty) {
      requests.add(request);
      responseObserver.onNext(((Empty) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method DeleteAgentUser, expected %s or %s",
                  response.getClass().getName(),
                  Empty.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void query(
      HomeGraphApiServiceProto.QueryRequest request,
      StreamObserver<HomeGraphApiServiceProto.QueryResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof HomeGraphApiServiceProto.QueryResponse) {
      requests.add(request);
      responseObserver.onNext(((HomeGraphApiServiceProto.QueryResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method Query, expected %s or %s",
                  response.getClass().getName(),
                  HomeGraphApiServiceProto.QueryResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void sync(
      HomeGraphApiServiceProto.SyncRequest request,
      StreamObserver<HomeGraphApiServiceProto.SyncResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof HomeGraphApiServiceProto.SyncResponse) {
      requests.add(request);
      responseObserver.onNext(((HomeGraphApiServiceProto.SyncResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method Sync, expected %s or %s",
                  response.getClass().getName(),
                  HomeGraphApiServiceProto.SyncResponse.class.getName(),
                  Exception.class.getName())));
    }
  }
}
