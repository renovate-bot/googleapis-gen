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

package com.google.geo.ugc.streetview.publish.v1.stub;

import static com.google.geo.ugc.streetview.publish.v1.StreetViewPublishServiceClient.ListPhotosPagedResponse;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages;
import com.google.protobuf.Empty;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the StreetViewPublishService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class StreetViewPublishServiceStub implements BackgroundResource {

  public UnaryCallable<Empty, StreetViewPublishResources.UploadRef> startUploadCallable() {
    throw new UnsupportedOperationException("Not implemented: startUploadCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
      createPhotoCallable() {
    throw new UnsupportedOperationException("Not implemented: createPhotoCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
      getPhotoCallable() {
    throw new UnsupportedOperationException("Not implemented: getPhotoCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.BatchGetPhotosRequest,
          StreetViewPublishRpcMessages.BatchGetPhotosResponse>
      batchGetPhotosCallable() {
    throw new UnsupportedOperationException("Not implemented: batchGetPhotosCallable()");
  }

  public UnaryCallable<StreetViewPublishRpcMessages.ListPhotosRequest, ListPhotosPagedResponse>
      listPhotosPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listPhotosPagedCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.ListPhotosRequest,
          StreetViewPublishRpcMessages.ListPhotosResponse>
      listPhotosCallable() {
    throw new UnsupportedOperationException("Not implemented: listPhotosCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
      updatePhotoCallable() {
    throw new UnsupportedOperationException("Not implemented: updatePhotoCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
          StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
      batchUpdatePhotosCallable() {
    throw new UnsupportedOperationException("Not implemented: batchUpdatePhotosCallable()");
  }

  public UnaryCallable<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>
      deletePhotoCallable() {
    throw new UnsupportedOperationException("Not implemented: deletePhotoCallable()");
  }

  public UnaryCallable<
          StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
          StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
      batchDeletePhotosCallable() {
    throw new UnsupportedOperationException("Not implemented: batchDeletePhotosCallable()");
  }

  @Override
  public abstract void close();
}
