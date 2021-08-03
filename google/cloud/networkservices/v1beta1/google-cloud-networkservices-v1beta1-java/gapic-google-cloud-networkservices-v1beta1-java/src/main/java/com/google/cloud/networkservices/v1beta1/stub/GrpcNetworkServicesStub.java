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

package com.google.cloud.networkservices.v1beta1.stub;

import static com.google.cloud.networkservices.v1beta1.NetworkServicesClient.ListEndpointPoliciesPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.networkservices.v1beta1.CreateEndpointPolicyRequest;
import com.google.cloud.networkservices.v1beta1.DeleteEndpointPolicyRequest;
import com.google.cloud.networkservices.v1beta1.EndpointPolicy;
import com.google.cloud.networkservices.v1beta1.GetEndpointPolicyRequest;
import com.google.cloud.networkservices.v1beta1.ListEndpointPoliciesRequest;
import com.google.cloud.networkservices.v1beta1.ListEndpointPoliciesResponse;
import com.google.cloud.networkservices.v1beta1.OperationMetadata;
import com.google.cloud.networkservices.v1beta1.UpdateEndpointPolicyRequest;
import com.google.common.collect.ImmutableMap;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.protobuf.Empty;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the NetworkServices service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class GrpcNetworkServicesStub extends NetworkServicesStub {
  private static final MethodDescriptor<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>
      listEndpointPoliciesMethodDescriptor =
          MethodDescriptor.<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.networkservices.v1beta1.NetworkServices/ListEndpointPolicies")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListEndpointPoliciesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListEndpointPoliciesResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetEndpointPolicyRequest, EndpointPolicy>
      getEndpointPolicyMethodDescriptor =
          MethodDescriptor.<GetEndpointPolicyRequest, EndpointPolicy>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.networkservices.v1beta1.NetworkServices/GetEndpointPolicy")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetEndpointPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(EndpointPolicy.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<CreateEndpointPolicyRequest, Operation>
      createEndpointPolicyMethodDescriptor =
          MethodDescriptor.<CreateEndpointPolicyRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.networkservices.v1beta1.NetworkServices/CreateEndpointPolicy")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateEndpointPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<UpdateEndpointPolicyRequest, Operation>
      updateEndpointPolicyMethodDescriptor =
          MethodDescriptor.<UpdateEndpointPolicyRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.networkservices.v1beta1.NetworkServices/UpdateEndpointPolicy")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateEndpointPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<DeleteEndpointPolicyRequest, Operation>
      deleteEndpointPolicyMethodDescriptor =
          MethodDescriptor.<DeleteEndpointPolicyRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.networkservices.v1beta1.NetworkServices/DeleteEndpointPolicy")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(DeleteEndpointPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private final UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>
      listEndpointPoliciesCallable;
  private final UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesPagedResponse>
      listEndpointPoliciesPagedCallable;
  private final UnaryCallable<GetEndpointPolicyRequest, EndpointPolicy> getEndpointPolicyCallable;
  private final UnaryCallable<CreateEndpointPolicyRequest, Operation> createEndpointPolicyCallable;
  private final OperationCallable<CreateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      createEndpointPolicyOperationCallable;
  private final UnaryCallable<UpdateEndpointPolicyRequest, Operation> updateEndpointPolicyCallable;
  private final OperationCallable<UpdateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      updateEndpointPolicyOperationCallable;
  private final UnaryCallable<DeleteEndpointPolicyRequest, Operation> deleteEndpointPolicyCallable;
  private final OperationCallable<DeleteEndpointPolicyRequest, Empty, OperationMetadata>
      deleteEndpointPolicyOperationCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcNetworkServicesStub create(NetworkServicesStubSettings settings)
      throws IOException {
    return new GrpcNetworkServicesStub(settings, ClientContext.create(settings));
  }

  public static final GrpcNetworkServicesStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcNetworkServicesStub(
        NetworkServicesStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcNetworkServicesStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcNetworkServicesStub(
        NetworkServicesStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcNetworkServicesStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcNetworkServicesStub(
      NetworkServicesStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcNetworkServicesCallableFactory());
  }

  /**
   * Constructs an instance of GrpcNetworkServicesStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcNetworkServicesStub(
      NetworkServicesStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>
        listEndpointPoliciesTransportSettings =
            GrpcCallSettings.<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>newBuilder()
                .setMethodDescriptor(listEndpointPoliciesMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ListEndpointPoliciesRequest>() {
                      @Override
                      public Map<String, String> extract(ListEndpointPoliciesRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<GetEndpointPolicyRequest, EndpointPolicy> getEndpointPolicyTransportSettings =
        GrpcCallSettings.<GetEndpointPolicyRequest, EndpointPolicy>newBuilder()
            .setMethodDescriptor(getEndpointPolicyMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetEndpointPolicyRequest>() {
                  @Override
                  public Map<String, String> extract(GetEndpointPolicyRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<CreateEndpointPolicyRequest, Operation> createEndpointPolicyTransportSettings =
        GrpcCallSettings.<CreateEndpointPolicyRequest, Operation>newBuilder()
            .setMethodDescriptor(createEndpointPolicyMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateEndpointPolicyRequest>() {
                  @Override
                  public Map<String, String> extract(CreateEndpointPolicyRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<UpdateEndpointPolicyRequest, Operation> updateEndpointPolicyTransportSettings =
        GrpcCallSettings.<UpdateEndpointPolicyRequest, Operation>newBuilder()
            .setMethodDescriptor(updateEndpointPolicyMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateEndpointPolicyRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateEndpointPolicyRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put(
                        "endpoint_policy.name",
                        String.valueOf(request.getEndpointPolicy().getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<DeleteEndpointPolicyRequest, Operation> deleteEndpointPolicyTransportSettings =
        GrpcCallSettings.<DeleteEndpointPolicyRequest, Operation>newBuilder()
            .setMethodDescriptor(deleteEndpointPolicyMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<DeleteEndpointPolicyRequest>() {
                  @Override
                  public Map<String, String> extract(DeleteEndpointPolicyRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();

    this.listEndpointPoliciesCallable =
        callableFactory.createUnaryCallable(
            listEndpointPoliciesTransportSettings,
            settings.listEndpointPoliciesSettings(),
            clientContext);
    this.listEndpointPoliciesPagedCallable =
        callableFactory.createPagedCallable(
            listEndpointPoliciesTransportSettings,
            settings.listEndpointPoliciesSettings(),
            clientContext);
    this.getEndpointPolicyCallable =
        callableFactory.createUnaryCallable(
            getEndpointPolicyTransportSettings,
            settings.getEndpointPolicySettings(),
            clientContext);
    this.createEndpointPolicyCallable =
        callableFactory.createUnaryCallable(
            createEndpointPolicyTransportSettings,
            settings.createEndpointPolicySettings(),
            clientContext);
    this.createEndpointPolicyOperationCallable =
        callableFactory.createOperationCallable(
            createEndpointPolicyTransportSettings,
            settings.createEndpointPolicyOperationSettings(),
            clientContext,
            operationsStub);
    this.updateEndpointPolicyCallable =
        callableFactory.createUnaryCallable(
            updateEndpointPolicyTransportSettings,
            settings.updateEndpointPolicySettings(),
            clientContext);
    this.updateEndpointPolicyOperationCallable =
        callableFactory.createOperationCallable(
            updateEndpointPolicyTransportSettings,
            settings.updateEndpointPolicyOperationSettings(),
            clientContext,
            operationsStub);
    this.deleteEndpointPolicyCallable =
        callableFactory.createUnaryCallable(
            deleteEndpointPolicyTransportSettings,
            settings.deleteEndpointPolicySettings(),
            clientContext);
    this.deleteEndpointPolicyOperationCallable =
        callableFactory.createOperationCallable(
            deleteEndpointPolicyTransportSettings,
            settings.deleteEndpointPolicyOperationSettings(),
            clientContext,
            operationsStub);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>
      listEndpointPoliciesCallable() {
    return listEndpointPoliciesCallable;
  }

  @Override
  public UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesPagedResponse>
      listEndpointPoliciesPagedCallable() {
    return listEndpointPoliciesPagedCallable;
  }

  @Override
  public UnaryCallable<GetEndpointPolicyRequest, EndpointPolicy> getEndpointPolicyCallable() {
    return getEndpointPolicyCallable;
  }

  @Override
  public UnaryCallable<CreateEndpointPolicyRequest, Operation> createEndpointPolicyCallable() {
    return createEndpointPolicyCallable;
  }

  @Override
  public OperationCallable<CreateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      createEndpointPolicyOperationCallable() {
    return createEndpointPolicyOperationCallable;
  }

  @Override
  public UnaryCallable<UpdateEndpointPolicyRequest, Operation> updateEndpointPolicyCallable() {
    return updateEndpointPolicyCallable;
  }

  @Override
  public OperationCallable<UpdateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      updateEndpointPolicyOperationCallable() {
    return updateEndpointPolicyOperationCallable;
  }

  @Override
  public UnaryCallable<DeleteEndpointPolicyRequest, Operation> deleteEndpointPolicyCallable() {
    return deleteEndpointPolicyCallable;
  }

  @Override
  public OperationCallable<DeleteEndpointPolicyRequest, Empty, OperationMetadata>
      deleteEndpointPolicyOperationCallable() {
    return deleteEndpointPolicyOperationCallable;
  }

  @Override
  public final void close() {
    try {
      backgroundResources.close();
    } catch (RuntimeException e) {
      throw e;
    } catch (Exception e) {
      throw new IllegalStateException("Failed to close resource", e);
    }
  }

  @Override
  public void shutdown() {
    backgroundResources.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return backgroundResources.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return backgroundResources.isTerminated();
  }

  @Override
  public void shutdownNow() {
    backgroundResources.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return backgroundResources.awaitTermination(duration, unit);
  }
}
