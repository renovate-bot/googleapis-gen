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

package com.google.chromeos.moblab.v1beta1.stub;

import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListBuildTargetsPagedResponse;
import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListBuildsPagedResponse;
import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListModelsPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest;
import com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse;
import com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest;
import com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse;
import com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest;
import com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse;
import com.google.chromeos.moblab.v1beta1.ListBuildsRequest;
import com.google.chromeos.moblab.v1beta1.ListBuildsResponse;
import com.google.chromeos.moblab.v1beta1.ListModelsRequest;
import com.google.chromeos.moblab.v1beta1.ListModelsResponse;
import com.google.chromeos.moblab.v1beta1.StageBuildMetadata;
import com.google.chromeos.moblab.v1beta1.StageBuildRequest;
import com.google.chromeos.moblab.v1beta1.StageBuildResponse;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.OperationsStub;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the BuildService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public abstract class BuildServiceStub implements BackgroundResource {

  public OperationsStub getOperationsStub() {
    throw new UnsupportedOperationException("Not implemented: getOperationsStub()");
  }

  public UnaryCallable<ListBuildTargetsRequest, ListBuildTargetsPagedResponse>
      listBuildTargetsPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listBuildTargetsPagedCallable()");
  }

  public UnaryCallable<ListBuildTargetsRequest, ListBuildTargetsResponse>
      listBuildTargetsCallable() {
    throw new UnsupportedOperationException("Not implemented: listBuildTargetsCallable()");
  }

  public UnaryCallable<ListModelsRequest, ListModelsPagedResponse> listModelsPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listModelsPagedCallable()");
  }

  public UnaryCallable<ListModelsRequest, ListModelsResponse> listModelsCallable() {
    throw new UnsupportedOperationException("Not implemented: listModelsCallable()");
  }

  public UnaryCallable<ListBuildsRequest, ListBuildsPagedResponse> listBuildsPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listBuildsPagedCallable()");
  }

  public UnaryCallable<ListBuildsRequest, ListBuildsResponse> listBuildsCallable() {
    throw new UnsupportedOperationException("Not implemented: listBuildsCallable()");
  }

  public UnaryCallable<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
      checkBuildStageStatusCallable() {
    throw new UnsupportedOperationException("Not implemented: checkBuildStageStatusCallable()");
  }

  public OperationCallable<StageBuildRequest, StageBuildResponse, StageBuildMetadata>
      stageBuildOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: stageBuildOperationCallable()");
  }

  public UnaryCallable<StageBuildRequest, Operation> stageBuildCallable() {
    throw new UnsupportedOperationException("Not implemented: stageBuildCallable()");
  }

  public UnaryCallable<FindMostStableBuildRequest, FindMostStableBuildResponse>
      findMostStableBuildCallable() {
    throw new UnsupportedOperationException("Not implemented: findMostStableBuildCallable()");
  }

  @Override
  public abstract void close();
}
