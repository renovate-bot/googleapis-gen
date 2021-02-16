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

package com.google.cloud.datastore.admin.v1.stub;

import static com.google.cloud.datastore.admin.v1.DatastoreAdminClient.ListIndexesPagedResponse;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.datastore.admin.v1.ExportEntitiesMetadata;
import com.google.datastore.admin.v1.ExportEntitiesRequest;
import com.google.datastore.admin.v1.ExportEntitiesResponse;
import com.google.datastore.admin.v1.GetIndexRequest;
import com.google.datastore.admin.v1.ImportEntitiesMetadata;
import com.google.datastore.admin.v1.ImportEntitiesRequest;
import com.google.datastore.admin.v1.Index;
import com.google.datastore.admin.v1.ListIndexesRequest;
import com.google.datastore.admin.v1.ListIndexesResponse;
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
 * gRPC stub implementation for the DatastoreAdmin service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcDatastoreAdminStub extends DatastoreAdminStub {
  private static final MethodDescriptor<ExportEntitiesRequest, Operation>
      exportEntitiesMethodDescriptor =
          MethodDescriptor.<ExportEntitiesRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.datastore.admin.v1.DatastoreAdmin/ExportEntities")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ExportEntitiesRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ImportEntitiesRequest, Operation>
      importEntitiesMethodDescriptor =
          MethodDescriptor.<ImportEntitiesRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.datastore.admin.v1.DatastoreAdmin/ImportEntities")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ImportEntitiesRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetIndexRequest, Index> getIndexMethodDescriptor =
      MethodDescriptor.<GetIndexRequest, Index>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.datastore.admin.v1.DatastoreAdmin/GetIndex")
          .setRequestMarshaller(ProtoUtils.marshaller(GetIndexRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Index.getDefaultInstance()))
          .build();

  private static final MethodDescriptor<ListIndexesRequest, ListIndexesResponse>
      listIndexesMethodDescriptor =
          MethodDescriptor.<ListIndexesRequest, ListIndexesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.datastore.admin.v1.DatastoreAdmin/ListIndexes")
              .setRequestMarshaller(ProtoUtils.marshaller(ListIndexesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListIndexesResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<ExportEntitiesRequest, Operation> exportEntitiesCallable;
  private final OperationCallable<
          ExportEntitiesRequest, ExportEntitiesResponse, ExportEntitiesMetadata>
      exportEntitiesOperationCallable;
  private final UnaryCallable<ImportEntitiesRequest, Operation> importEntitiesCallable;
  private final OperationCallable<ImportEntitiesRequest, Empty, ImportEntitiesMetadata>
      importEntitiesOperationCallable;
  private final UnaryCallable<GetIndexRequest, Index> getIndexCallable;
  private final UnaryCallable<ListIndexesRequest, ListIndexesResponse> listIndexesCallable;
  private final UnaryCallable<ListIndexesRequest, ListIndexesPagedResponse>
      listIndexesPagedCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcDatastoreAdminStub create(DatastoreAdminStubSettings settings)
      throws IOException {
    return new GrpcDatastoreAdminStub(settings, ClientContext.create(settings));
  }

  public static final GrpcDatastoreAdminStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcDatastoreAdminStub(
        DatastoreAdminStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcDatastoreAdminStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcDatastoreAdminStub(
        DatastoreAdminStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcDatastoreAdminStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcDatastoreAdminStub(DatastoreAdminStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcDatastoreAdminCallableFactory());
  }

  /**
   * Constructs an instance of GrpcDatastoreAdminStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcDatastoreAdminStub(
      DatastoreAdminStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ExportEntitiesRequest, Operation> exportEntitiesTransportSettings =
        GrpcCallSettings.<ExportEntitiesRequest, Operation>newBuilder()
            .setMethodDescriptor(exportEntitiesMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ExportEntitiesRequest>() {
                  @Override
                  public Map<String, String> extract(ExportEntitiesRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ImportEntitiesRequest, Operation> importEntitiesTransportSettings =
        GrpcCallSettings.<ImportEntitiesRequest, Operation>newBuilder()
            .setMethodDescriptor(importEntitiesMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ImportEntitiesRequest>() {
                  @Override
                  public Map<String, String> extract(ImportEntitiesRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetIndexRequest, Index> getIndexTransportSettings =
        GrpcCallSettings.<GetIndexRequest, Index>newBuilder()
            .setMethodDescriptor(getIndexMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetIndexRequest>() {
                  @Override
                  public Map<String, String> extract(GetIndexRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("index_id", String.valueOf(request.getIndexId()));
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListIndexesRequest, ListIndexesResponse> listIndexesTransportSettings =
        GrpcCallSettings.<ListIndexesRequest, ListIndexesResponse>newBuilder()
            .setMethodDescriptor(listIndexesMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ListIndexesRequest>() {
                  @Override
                  public Map<String, String> extract(ListIndexesRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();

    this.exportEntitiesCallable =
        callableFactory.createUnaryCallable(
            exportEntitiesTransportSettings, settings.exportEntitiesSettings(), clientContext);
    this.exportEntitiesOperationCallable =
        callableFactory.createOperationCallable(
            exportEntitiesTransportSettings,
            settings.exportEntitiesOperationSettings(),
            clientContext,
            operationsStub);
    this.importEntitiesCallable =
        callableFactory.createUnaryCallable(
            importEntitiesTransportSettings, settings.importEntitiesSettings(), clientContext);
    this.importEntitiesOperationCallable =
        callableFactory.createOperationCallable(
            importEntitiesTransportSettings,
            settings.importEntitiesOperationSettings(),
            clientContext,
            operationsStub);
    this.getIndexCallable =
        callableFactory.createUnaryCallable(
            getIndexTransportSettings, settings.getIndexSettings(), clientContext);
    this.listIndexesCallable =
        callableFactory.createUnaryCallable(
            listIndexesTransportSettings, settings.listIndexesSettings(), clientContext);
    this.listIndexesPagedCallable =
        callableFactory.createPagedCallable(
            listIndexesTransportSettings, settings.listIndexesSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<ExportEntitiesRequest, Operation> exportEntitiesCallable() {
    return exportEntitiesCallable;
  }

  @Override
  public OperationCallable<ExportEntitiesRequest, ExportEntitiesResponse, ExportEntitiesMetadata>
      exportEntitiesOperationCallable() {
    return exportEntitiesOperationCallable;
  }

  @Override
  public UnaryCallable<ImportEntitiesRequest, Operation> importEntitiesCallable() {
    return importEntitiesCallable;
  }

  @Override
  public OperationCallable<ImportEntitiesRequest, Empty, ImportEntitiesMetadata>
      importEntitiesOperationCallable() {
    return importEntitiesOperationCallable;
  }

  @Override
  public UnaryCallable<GetIndexRequest, Index> getIndexCallable() {
    return getIndexCallable;
  }

  @Override
  public UnaryCallable<ListIndexesRequest, ListIndexesResponse> listIndexesCallable() {
    return listIndexesCallable;
  }

  @Override
  public UnaryCallable<ListIndexesRequest, ListIndexesPagedResponse> listIndexesPagedCallable() {
    return listIndexesPagedCallable;
  }

  @Override
  public final void close() {
    shutdown();
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
