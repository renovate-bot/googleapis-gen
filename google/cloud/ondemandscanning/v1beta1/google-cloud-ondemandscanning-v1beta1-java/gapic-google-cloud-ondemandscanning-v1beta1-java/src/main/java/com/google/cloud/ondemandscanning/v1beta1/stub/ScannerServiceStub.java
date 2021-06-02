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

package com.google.cloud.ondemandscanning.v1beta1.stub;

import static com.google.cloud.ondemandscanning.v1beta1.ScannerServiceClient.ListVulnerabilitiesPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesMetadata;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesRequest;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesResponse;
import com.google.cloud.ondemandscanning.v1beta1.ListVulnerabilitiesRequest;
import com.google.cloud.ondemandscanning.v1beta1.ListVulnerabilitiesResponse;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.OperationsStub;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the ScannerService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public abstract class ScannerServiceStub implements BackgroundResource {

  public OperationsStub getOperationsStub() {
    throw new UnsupportedOperationException("Not implemented: getOperationsStub()");
  }

  public OperationCallable<AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: analyzePackagesOperationCallable()");
  }

  public UnaryCallable<AnalyzePackagesRequest, Operation> analyzePackagesCallable() {
    throw new UnsupportedOperationException("Not implemented: analyzePackagesCallable()");
  }

  public UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesPagedResponse>
      listVulnerabilitiesPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listVulnerabilitiesPagedCallable()");
  }

  public UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>
      listVulnerabilitiesCallable() {
    throw new UnsupportedOperationException("Not implemented: listVulnerabilitiesCallable()");
  }

  @Override
  public abstract void close();
}
