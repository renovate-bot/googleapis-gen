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

package com.google.cloud.bigquery.v2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.bigquery.v2.ModelProto;
import com.google.protobuf.Empty;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the ModelService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class ModelServiceStub implements BackgroundResource {

  public UnaryCallable<ModelProto.GetModelRequest, ModelProto.Model> getModelCallable() {
    throw new UnsupportedOperationException("Not implemented: getModelCallable()");
  }

  public UnaryCallable<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsCallable() {
    throw new UnsupportedOperationException("Not implemented: listModelsCallable()");
  }

  public UnaryCallable<ModelProto.PatchModelRequest, ModelProto.Model> patchModelCallable() {
    throw new UnsupportedOperationException("Not implemented: patchModelCallable()");
  }

  public UnaryCallable<ModelProto.DeleteModelRequest, Empty> deleteModelCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteModelCallable()");
  }

  @Override
  public abstract void close();
}
