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

package com.google.cloud.networkservices.v1.stub;

import static com.google.cloud.networkservices.v1.NetworkServicesClient.ListEndpointPoliciesPagedResponse;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.networkservices.v1.CreateEndpointPolicyRequest;
import com.google.cloud.networkservices.v1.DeleteEndpointPolicyRequest;
import com.google.cloud.networkservices.v1.EndpointPolicy;
import com.google.cloud.networkservices.v1.GetEndpointPolicyRequest;
import com.google.cloud.networkservices.v1.ListEndpointPoliciesRequest;
import com.google.cloud.networkservices.v1.ListEndpointPoliciesResponse;
import com.google.cloud.networkservices.v1.OperationMetadata;
import com.google.cloud.networkservices.v1.UpdateEndpointPolicyRequest;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.OperationsStub;
import com.google.protobuf.Empty;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the NetworkServices service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class NetworkServicesStub implements BackgroundResource {

  public OperationsStub getOperationsStub() {
    throw new UnsupportedOperationException("Not implemented: getOperationsStub()");
  }

  public UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesPagedResponse>
      listEndpointPoliciesPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listEndpointPoliciesPagedCallable()");
  }

  public UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>
      listEndpointPoliciesCallable() {
    throw new UnsupportedOperationException("Not implemented: listEndpointPoliciesCallable()");
  }

  public UnaryCallable<GetEndpointPolicyRequest, EndpointPolicy> getEndpointPolicyCallable() {
    throw new UnsupportedOperationException("Not implemented: getEndpointPolicyCallable()");
  }

  public OperationCallable<CreateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      createEndpointPolicyOperationCallable() {
    throw new UnsupportedOperationException(
        "Not implemented: createEndpointPolicyOperationCallable()");
  }

  public UnaryCallable<CreateEndpointPolicyRequest, Operation> createEndpointPolicyCallable() {
    throw new UnsupportedOperationException("Not implemented: createEndpointPolicyCallable()");
  }

  public OperationCallable<UpdateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      updateEndpointPolicyOperationCallable() {
    throw new UnsupportedOperationException(
        "Not implemented: updateEndpointPolicyOperationCallable()");
  }

  public UnaryCallable<UpdateEndpointPolicyRequest, Operation> updateEndpointPolicyCallable() {
    throw new UnsupportedOperationException("Not implemented: updateEndpointPolicyCallable()");
  }

  public OperationCallable<DeleteEndpointPolicyRequest, Empty, OperationMetadata>
      deleteEndpointPolicyOperationCallable() {
    throw new UnsupportedOperationException(
        "Not implemented: deleteEndpointPolicyOperationCallable()");
  }

  public UnaryCallable<DeleteEndpointPolicyRequest, Operation> deleteEndpointPolicyCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteEndpointPolicyCallable()");
  }

  @Override
  public abstract void close();
}
