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

package com.google.partner.aistreams.v1alpha1.stub;

import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListClustersPagedResponse;
import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListStreamsPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.OperationsStub;
import com.google.partner.aistreams.v1alpha1.Cluster;
import com.google.partner.aistreams.v1alpha1.CreateClusterRequest;
import com.google.partner.aistreams.v1alpha1.CreateStreamRequest;
import com.google.partner.aistreams.v1alpha1.DeleteClusterRequest;
import com.google.partner.aistreams.v1alpha1.DeleteStreamRequest;
import com.google.partner.aistreams.v1alpha1.GetClusterRequest;
import com.google.partner.aistreams.v1alpha1.GetStreamRequest;
import com.google.partner.aistreams.v1alpha1.ListClustersRequest;
import com.google.partner.aistreams.v1alpha1.ListClustersResponse;
import com.google.partner.aistreams.v1alpha1.ListStreamsRequest;
import com.google.partner.aistreams.v1alpha1.ListStreamsResponse;
import com.google.partner.aistreams.v1alpha1.OperationMetadata;
import com.google.partner.aistreams.v1alpha1.Stream;
import com.google.partner.aistreams.v1alpha1.UpdateClusterRequest;
import com.google.partner.aistreams.v1alpha1.UpdateStreamRequest;
import com.google.protobuf.Empty;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the AIStreams service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public abstract class AIStreamsStub implements BackgroundResource {

  public OperationsStub getOperationsStub() {
    throw new UnsupportedOperationException("Not implemented: getOperationsStub()");
  }

  public UnaryCallable<ListClustersRequest, ListClustersPagedResponse> listClustersPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listClustersPagedCallable()");
  }

  public UnaryCallable<ListClustersRequest, ListClustersResponse> listClustersCallable() {
    throw new UnsupportedOperationException("Not implemented: listClustersCallable()");
  }

  public UnaryCallable<GetClusterRequest, Cluster> getClusterCallable() {
    throw new UnsupportedOperationException("Not implemented: getClusterCallable()");
  }

  public OperationCallable<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: createClusterOperationCallable()");
  }

  public UnaryCallable<CreateClusterRequest, Operation> createClusterCallable() {
    throw new UnsupportedOperationException("Not implemented: createClusterCallable()");
  }

  public OperationCallable<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: updateClusterOperationCallable()");
  }

  public UnaryCallable<UpdateClusterRequest, Operation> updateClusterCallable() {
    throw new UnsupportedOperationException("Not implemented: updateClusterCallable()");
  }

  public OperationCallable<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteClusterOperationCallable()");
  }

  public UnaryCallable<DeleteClusterRequest, Operation> deleteClusterCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteClusterCallable()");
  }

  public UnaryCallable<ListStreamsRequest, ListStreamsPagedResponse> listStreamsPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listStreamsPagedCallable()");
  }

  public UnaryCallable<ListStreamsRequest, ListStreamsResponse> listStreamsCallable() {
    throw new UnsupportedOperationException("Not implemented: listStreamsCallable()");
  }

  public UnaryCallable<GetStreamRequest, Stream> getStreamCallable() {
    throw new UnsupportedOperationException("Not implemented: getStreamCallable()");
  }

  public OperationCallable<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: createStreamOperationCallable()");
  }

  public UnaryCallable<CreateStreamRequest, Operation> createStreamCallable() {
    throw new UnsupportedOperationException("Not implemented: createStreamCallable()");
  }

  public OperationCallable<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: updateStreamOperationCallable()");
  }

  public UnaryCallable<UpdateStreamRequest, Operation> updateStreamCallable() {
    throw new UnsupportedOperationException("Not implemented: updateStreamCallable()");
  }

  public OperationCallable<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteStreamOperationCallable()");
  }

  public UnaryCallable<DeleteStreamRequest, Operation> deleteStreamCallable() {
    throw new UnsupportedOperationException("Not implemented: deleteStreamCallable()");
  }

  @Override
  public abstract void close();
}
