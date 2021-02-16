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

package com.google.cloud.bigquery.v2;

import com.google.api.core.BetaApi;
import com.google.cloud.bigquery.v2.ModelServiceGrpc.ModelServiceImplBase;
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
public class MockModelServiceImpl extends ModelServiceImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockModelServiceImpl() {
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
  public void getModel(
      ModelProto.GetModelRequest request, StreamObserver<ModelProto.Model> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ModelProto.Model) {
      requests.add(request);
      responseObserver.onNext(((ModelProto.Model) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetModel, expected %s or %s",
                  response.getClass().getName(),
                  ModelProto.Model.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void listModels(
      ModelProto.ListModelsRequest request,
      StreamObserver<ModelProto.ListModelsResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ModelProto.ListModelsResponse) {
      requests.add(request);
      responseObserver.onNext(((ModelProto.ListModelsResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ListModels, expected %s or %s",
                  response.getClass().getName(),
                  ModelProto.ListModelsResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void patchModel(
      ModelProto.PatchModelRequest request, StreamObserver<ModelProto.Model> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ModelProto.Model) {
      requests.add(request);
      responseObserver.onNext(((ModelProto.Model) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method PatchModel, expected %s or %s",
                  response.getClass().getName(),
                  ModelProto.Model.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void deleteModel(
      ModelProto.DeleteModelRequest request, StreamObserver<Empty> responseObserver) {
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
                  "Unrecognized response type %s for method DeleteModel, expected %s or %s",
                  response.getClass().getName(),
                  Empty.class.getName(),
                  Exception.class.getName())));
    }
  }
}
