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

package com.google.streetview.publish.v1;

import com.google.api.core.BetaApi;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishServiceGrpc.StreetViewPublishServiceImplBase;
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
public class MockStreetViewPublishServiceImpl extends StreetViewPublishServiceImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockStreetViewPublishServiceImpl() {
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
  public void startUpload(
      Empty request, StreamObserver<StreetViewPublishResources.UploadRef> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishResources.UploadRef) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishResources.UploadRef) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method StartUpload, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishResources.UploadRef.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void createPhoto(
      StreetViewPublishRpcMessages.CreatePhotoRequest request,
      StreamObserver<StreetViewPublishResources.Photo> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishResources.Photo) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishResources.Photo) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method CreatePhoto, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishResources.Photo.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void getPhoto(
      StreetViewPublishRpcMessages.GetPhotoRequest request,
      StreamObserver<StreetViewPublishResources.Photo> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishResources.Photo) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishResources.Photo) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetPhoto, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishResources.Photo.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void batchGetPhotos(
      StreetViewPublishRpcMessages.BatchGetPhotosRequest request,
      StreamObserver<StreetViewPublishRpcMessages.BatchGetPhotosResponse> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishRpcMessages.BatchGetPhotosResponse) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishRpcMessages.BatchGetPhotosResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method BatchGetPhotos, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishRpcMessages.BatchGetPhotosResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void listPhotos(
      StreetViewPublishRpcMessages.ListPhotosRequest request,
      StreamObserver<StreetViewPublishRpcMessages.ListPhotosResponse> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishRpcMessages.ListPhotosResponse) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishRpcMessages.ListPhotosResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ListPhotos, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishRpcMessages.ListPhotosResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void updatePhoto(
      StreetViewPublishRpcMessages.UpdatePhotoRequest request,
      StreamObserver<StreetViewPublishResources.Photo> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishResources.Photo) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishResources.Photo) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method UpdatePhoto, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishResources.Photo.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void batchUpdatePhotos(
      StreetViewPublishRpcMessages.BatchUpdatePhotosRequest request,
      StreamObserver<StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishRpcMessages.BatchUpdatePhotosResponse) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishRpcMessages.BatchUpdatePhotosResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method BatchUpdatePhotos, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishRpcMessages.BatchUpdatePhotosResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void deletePhoto(
      StreetViewPublishRpcMessages.DeletePhotoRequest request,
      StreamObserver<Empty> responseObserver) {
    Object response = responses.poll();
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
                  "Unrecognized response type %s for method DeletePhoto, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  Empty.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void batchDeletePhotos(
      StreetViewPublishRpcMessages.BatchDeletePhotosRequest request,
      StreamObserver<StreetViewPublishRpcMessages.BatchDeletePhotosResponse> responseObserver) {
    Object response = responses.poll();
    if (response instanceof StreetViewPublishRpcMessages.BatchDeletePhotosResponse) {
      requests.add(request);
      responseObserver.onNext(((StreetViewPublishRpcMessages.BatchDeletePhotosResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method BatchDeletePhotos, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  StreetViewPublishRpcMessages.BatchDeletePhotosResponse.class.getName(),
                  Exception.class.getName())));
    }
  }
}
