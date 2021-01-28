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

package com.google.cloud.metastore.v1alpha;

import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.longrunning.OperationFuture;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.metastore.v1alpha.stub.DataprocMetastoreStub;
import com.google.cloud.metastore.v1alpha.stub.DataprocMetastoreStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import com.google.protobuf.Empty;
import com.google.protobuf.FieldMask;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Configures and manages metastore services. Metastore services are fully
 * managed, highly available, auto-scaled, auto-healing, OSS-native deployments of technical
 * metadata management software. Each metastore service exposes a network endpoint through which
 * metadata queries are served. Metadata queries can originate from a variety of sources, including
 * Apache Hive, Apache Presto, and Apache Spark.
 *
 * <p>The Dataproc Metastore API defines the following resource model:
 *
 * <ul>
 *   <li>The service works with a collection of Google Cloud projects, named: `/projects/&#42;`
 *   <li>Each project has a collection of available locations, named: `/locations/&#42;` (a location
 *       must refer to a Google Cloud `region`)
 *   <li>Each location has a collection of services, named: `/services/&#42;`
 *   <li>Dataproc Metastore services are resources with names of the form:
 * </ul>
 *
 * <p>`/projects/{project_id}/locations/{location_id}/services/{service_id}`.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <p>Note: close() needs to be called on the DataprocMetastoreClient object to clean up resources
 * such as threads. In the example above, try-with-resources is used, which automatically calls
 * close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li>A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li>A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li>A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of DataprocMetastoreSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * DataprocMetastoreSettings dataprocMetastoreSettings =
 *     DataprocMetastoreSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * DataprocMetastoreClient dataprocMetastoreClient =
 *     DataprocMetastoreClient.create(dataprocMetastoreSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * DataprocMetastoreSettings dataprocMetastoreSettings =
 *     DataprocMetastoreSettings.newBuilder().setEndpoint(myEndpoint).build();
 * DataprocMetastoreClient dataprocMetastoreClient =
 *     DataprocMetastoreClient.create(dataprocMetastoreSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class DataprocMetastoreClient implements BackgroundResource {
  private final DataprocMetastoreSettings settings;
  private final DataprocMetastoreStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of DataprocMetastoreClient with default settings. */
  public static final DataprocMetastoreClient create() throws IOException {
    return create(DataprocMetastoreSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of DataprocMetastoreClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final DataprocMetastoreClient create(DataprocMetastoreSettings settings)
      throws IOException {
    return new DataprocMetastoreClient(settings);
  }

  /**
   * Constructs an instance of DataprocMetastoreClient, using the given stub for making calls. This
   * is for advanced usage - prefer using create(DataprocMetastoreSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final DataprocMetastoreClient create(DataprocMetastoreStub stub) {
    return new DataprocMetastoreClient(stub);
  }

  /**
   * Constructs an instance of DataprocMetastoreClient, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected DataprocMetastoreClient(DataprocMetastoreSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((DataprocMetastoreStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected DataprocMetastoreClient(DataprocMetastoreStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final DataprocMetastoreSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public DataprocMetastoreStub getStub() {
    return stub;
  }

  /**
   * Returns the OperationsClient that can be used to query the status of a long-running operation
   * returned by another API method call.
   */
  public final OperationsClient getOperationsClient() {
    return operationsClient;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists services in a project and location.
   *
   * @param parent Required. The relative resource name of the location of metastore services to
   *     list, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServicesPagedResponse listServices(LocationName parent) {
    ListServicesRequest request =
        ListServicesRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listServices(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists services in a project and location.
   *
   * @param parent Required. The relative resource name of the location of metastore services to
   *     list, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServicesPagedResponse listServices(String parent) {
    ListServicesRequest request = ListServicesRequest.newBuilder().setParent(parent).build();
    return listServices(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists services in a project and location.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServicesPagedResponse listServices(ListServicesRequest request) {
    return listServicesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists services in a project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServicesRequest, ListServicesPagedResponse>
      listServicesPagedCallable() {
    return stub.listServicesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists services in a project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServicesRequest, ListServicesResponse> listServicesCallable() {
    return stub.listServicesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the details of a single service.
   *
   * @param name Required. The relative resource name of the metastore service to retrieve, in the
   *     following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service getService(ServiceName name) {
    GetServiceRequest request =
        GetServiceRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return getService(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the details of a single service.
   *
   * @param name Required. The relative resource name of the metastore service to retrieve, in the
   *     following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service getService(String name) {
    GetServiceRequest request = GetServiceRequest.newBuilder().setName(name).build();
    return getService(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the details of a single service.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service getService(GetServiceRequest request) {
    return getServiceCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the details of a single service.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetServiceRequest, Service> getServiceCallable() {
    return stub.getServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a metastore service in a project and location.
   *
   * @param parent Required. The relative resource name of the location in which to create a
   *     metastore service, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}".
   * @param service Required. The Metastore service to create. The `name` field is ignored. The ID
   *     of the created metastore service must be provided in the request's `service_id` field.
   * @param serviceId Required. The ID of the metastore service, which is used as the final
   *     component of the metastore service's name.
   *     <p>This value must be between 1 and 64 characters long, begin with a letter, end with a
   *     letter or number, and consist of alpha-numeric ASCII characters or hyphens.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Service, OperationMetadata> createServiceAsync(
      LocationName parent, Service service, String serviceId) {
    CreateServiceRequest request =
        CreateServiceRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setService(service)
            .setServiceId(serviceId)
            .build();
    return createServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a metastore service in a project and location.
   *
   * @param parent Required. The relative resource name of the location in which to create a
   *     metastore service, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}".
   * @param service Required. The Metastore service to create. The `name` field is ignored. The ID
   *     of the created metastore service must be provided in the request's `service_id` field.
   * @param serviceId Required. The ID of the metastore service, which is used as the final
   *     component of the metastore service's name.
   *     <p>This value must be between 1 and 64 characters long, begin with a letter, end with a
   *     letter or number, and consist of alpha-numeric ASCII characters or hyphens.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Service, OperationMetadata> createServiceAsync(
      String parent, Service service, String serviceId) {
    CreateServiceRequest request =
        CreateServiceRequest.newBuilder()
            .setParent(parent)
            .setService(service)
            .setServiceId(serviceId)
            .build();
    return createServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a metastore service in a project and location.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Service, OperationMetadata> createServiceAsync(
      CreateServiceRequest request) {
    return createServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a metastore service in a project and location.
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateServiceRequest, Service, OperationMetadata>
      createServiceOperationCallable() {
    return stub.createServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a metastore service in a project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateServiceRequest, Operation> createServiceCallable() {
    return stub.createServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single service.
   *
   * @param service Required. The metastore service to update. The server only merges fields in the
   *     service if they are specified in `update_mask`.
   *     <p>The metastore service's `name` field is used to identify the metastore service to be
   *     updated.
   * @param updateMask Required. A field mask used to specify the fields to be overwritten in the
   *     metastore service resource by the update. Fields specified in the `update_mask` are
   *     relative to the resource (not to the full request). A field is overwritten if it is in the
   *     mask.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Service, OperationMetadata> updateServiceAsync(
      Service service, FieldMask updateMask) {
    UpdateServiceRequest request =
        UpdateServiceRequest.newBuilder().setService(service).setUpdateMask(updateMask).build();
    return updateServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single service.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Service, OperationMetadata> updateServiceAsync(
      UpdateServiceRequest request) {
    return updateServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single service.
   *
   * <p>Sample code:
   */
  public final OperationCallable<UpdateServiceRequest, Service, OperationMetadata>
      updateServiceOperationCallable() {
    return stub.updateServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single service.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateServiceRequest, Operation> updateServiceCallable() {
    return stub.updateServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single service.
   *
   * @param name Required. The relative resource name of the metastore service to delete, in the
   *     following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteServiceAsync(ServiceName name) {
    DeleteServiceRequest request =
        DeleteServiceRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return deleteServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single service.
   *
   * @param name Required. The relative resource name of the metastore service to delete, in the
   *     following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteServiceAsync(String name) {
    DeleteServiceRequest request = DeleteServiceRequest.newBuilder().setName(name).build();
    return deleteServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single service.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteServiceAsync(
      DeleteServiceRequest request) {
    return deleteServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single service.
   *
   * <p>Sample code:
   */
  public final OperationCallable<DeleteServiceRequest, Empty, OperationMetadata>
      deleteServiceOperationCallable() {
    return stub.deleteServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single service.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteServiceRequest, Operation> deleteServiceCallable() {
    return stub.deleteServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists imports in a service.
   *
   * @param parent Required. The relative resource name of the service whose metadata imports to
   *     list, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListMetadataImportsPagedResponse listMetadataImports(ServiceName parent) {
    ListMetadataImportsRequest request =
        ListMetadataImportsRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listMetadataImports(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists imports in a service.
   *
   * @param parent Required. The relative resource name of the service whose metadata imports to
   *     list, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListMetadataImportsPagedResponse listMetadataImports(String parent) {
    ListMetadataImportsRequest request =
        ListMetadataImportsRequest.newBuilder().setParent(parent).build();
    return listMetadataImports(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists imports in a service.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListMetadataImportsPagedResponse listMetadataImports(
      ListMetadataImportsRequest request) {
    return listMetadataImportsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists imports in a service.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListMetadataImportsRequest, ListMetadataImportsPagedResponse>
      listMetadataImportsPagedCallable() {
    return stub.listMetadataImportsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists imports in a service.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListMetadataImportsRequest, ListMetadataImportsResponse>
      listMetadataImportsCallable() {
    return stub.listMetadataImportsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single import.
   *
   * @param name Required. The relative resource name of the metadata import to retrieve, in the
   *     following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final MetadataImport getMetadataImport(MetadataImportName name) {
    GetMetadataImportRequest request =
        GetMetadataImportRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return getMetadataImport(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single import.
   *
   * @param name Required. The relative resource name of the metadata import to retrieve, in the
   *     following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final MetadataImport getMetadataImport(String name) {
    GetMetadataImportRequest request = GetMetadataImportRequest.newBuilder().setName(name).build();
    return getMetadataImport(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single import.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final MetadataImport getMetadataImport(GetMetadataImportRequest request) {
    return getMetadataImportCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single import.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetMetadataImportRequest, MetadataImport> getMetadataImportCallable() {
    return stub.getMetadataImportCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new MetadataImport in a given project and location.
   *
   * @param parent Required. The relative resource name of the service in which to create a
   *     metastore import, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}"
   * @param metadataImport Required. The metadata import to create. The `name` field is ignored. The
   *     ID of the created metadata import must be provided in the request's `metadata_import_id`
   *     field.
   * @param metadataImportId Required. The ID of the metadata import, which is used as the final
   *     component of the metadata import's name.
   *     <p>This value must be between 1 and 64 characters long, begin with a letter, end with a
   *     letter or number, and consist of alpha-numeric ASCII characters or hyphens.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<MetadataImport, OperationMetadata> createMetadataImportAsync(
      ServiceName parent, MetadataImport metadataImport, String metadataImportId) {
    CreateMetadataImportRequest request =
        CreateMetadataImportRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setMetadataImport(metadataImport)
            .setMetadataImportId(metadataImportId)
            .build();
    return createMetadataImportAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new MetadataImport in a given project and location.
   *
   * @param parent Required. The relative resource name of the service in which to create a
   *     metastore import, in the following form:
   *     <p>"projects/{project_id}/locations/{location_id}/services/{service_id}"
   * @param metadataImport Required. The metadata import to create. The `name` field is ignored. The
   *     ID of the created metadata import must be provided in the request's `metadata_import_id`
   *     field.
   * @param metadataImportId Required. The ID of the metadata import, which is used as the final
   *     component of the metadata import's name.
   *     <p>This value must be between 1 and 64 characters long, begin with a letter, end with a
   *     letter or number, and consist of alpha-numeric ASCII characters or hyphens.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<MetadataImport, OperationMetadata> createMetadataImportAsync(
      String parent, MetadataImport metadataImport, String metadataImportId) {
    CreateMetadataImportRequest request =
        CreateMetadataImportRequest.newBuilder()
            .setParent(parent)
            .setMetadataImport(metadataImport)
            .setMetadataImportId(metadataImportId)
            .build();
    return createMetadataImportAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new MetadataImport in a given project and location.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<MetadataImport, OperationMetadata> createMetadataImportAsync(
      CreateMetadataImportRequest request) {
    return createMetadataImportOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new MetadataImport in a given project and location.
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateMetadataImportRequest, MetadataImport, OperationMetadata>
      createMetadataImportOperationCallable() {
    return stub.createMetadataImportOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new MetadataImport in a given project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateMetadataImportRequest, Operation>
      createMetadataImportCallable() {
    return stub.createMetadataImportCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a single import. Only the description field of MetadataImport is supported to be
   * updated.
   *
   * @param metadataImport Required. The metadata import to update. The server only merges fields in
   *     the import if they are specified in `update_mask`.
   *     <p>The metadata import's `name` field is used to identify the metastore import to be
   *     updated.
   * @param updateMask Required. A field mask used to specify the fields to be overwritten in the
   *     metadata import resource by the update. Fields specified in the `update_mask` are relative
   *     to the resource (not to the full request). A field is overwritten if it is in the mask.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<MetadataImport, OperationMetadata> updateMetadataImportAsync(
      MetadataImport metadataImport, FieldMask updateMask) {
    UpdateMetadataImportRequest request =
        UpdateMetadataImportRequest.newBuilder()
            .setMetadataImport(metadataImport)
            .setUpdateMask(updateMask)
            .build();
    return updateMetadataImportAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a single import. Only the description field of MetadataImport is supported to be
   * updated.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<MetadataImport, OperationMetadata> updateMetadataImportAsync(
      UpdateMetadataImportRequest request) {
    return updateMetadataImportOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a single import. Only the description field of MetadataImport is supported to be
   * updated.
   *
   * <p>Sample code:
   */
  public final OperationCallable<UpdateMetadataImportRequest, MetadataImport, OperationMetadata>
      updateMetadataImportOperationCallable() {
    return stub.updateMetadataImportOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a single import. Only the description field of MetadataImport is supported to be
   * updated.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateMetadataImportRequest, Operation>
      updateMetadataImportCallable() {
    return stub.updateMetadataImportCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }

  public static class ListServicesPagedResponse
      extends AbstractPagedListResponse<
          ListServicesRequest,
          ListServicesResponse,
          Service,
          ListServicesPage,
          ListServicesFixedSizeCollection> {

    public static ApiFuture<ListServicesPagedResponse> createAsync(
        PageContext<ListServicesRequest, ListServicesResponse, Service> context,
        ApiFuture<ListServicesResponse> futureResponse) {
      ApiFuture<ListServicesPage> futurePage =
          ListServicesPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListServicesPage, ListServicesPagedResponse>() {
            @Override
            public ListServicesPagedResponse apply(ListServicesPage input) {
              return new ListServicesPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListServicesPagedResponse(ListServicesPage page) {
      super(page, ListServicesFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListServicesPage
      extends AbstractPage<ListServicesRequest, ListServicesResponse, Service, ListServicesPage> {

    private ListServicesPage(
        PageContext<ListServicesRequest, ListServicesResponse, Service> context,
        ListServicesResponse response) {
      super(context, response);
    }

    private static ListServicesPage createEmptyPage() {
      return new ListServicesPage(null, null);
    }

    @Override
    protected ListServicesPage createPage(
        PageContext<ListServicesRequest, ListServicesResponse, Service> context,
        ListServicesResponse response) {
      return new ListServicesPage(context, response);
    }

    @Override
    public ApiFuture<ListServicesPage> createPageAsync(
        PageContext<ListServicesRequest, ListServicesResponse, Service> context,
        ApiFuture<ListServicesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListServicesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListServicesRequest,
          ListServicesResponse,
          Service,
          ListServicesPage,
          ListServicesFixedSizeCollection> {

    private ListServicesFixedSizeCollection(List<ListServicesPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListServicesFixedSizeCollection createEmptyCollection() {
      return new ListServicesFixedSizeCollection(null, 0);
    }

    @Override
    protected ListServicesFixedSizeCollection createCollection(
        List<ListServicesPage> pages, int collectionSize) {
      return new ListServicesFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListMetadataImportsPagedResponse
      extends AbstractPagedListResponse<
          ListMetadataImportsRequest,
          ListMetadataImportsResponse,
          MetadataImport,
          ListMetadataImportsPage,
          ListMetadataImportsFixedSizeCollection> {

    public static ApiFuture<ListMetadataImportsPagedResponse> createAsync(
        PageContext<ListMetadataImportsRequest, ListMetadataImportsResponse, MetadataImport>
            context,
        ApiFuture<ListMetadataImportsResponse> futureResponse) {
      ApiFuture<ListMetadataImportsPage> futurePage =
          ListMetadataImportsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListMetadataImportsPage, ListMetadataImportsPagedResponse>() {
            @Override
            public ListMetadataImportsPagedResponse apply(ListMetadataImportsPage input) {
              return new ListMetadataImportsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListMetadataImportsPagedResponse(ListMetadataImportsPage page) {
      super(page, ListMetadataImportsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListMetadataImportsPage
      extends AbstractPage<
          ListMetadataImportsRequest,
          ListMetadataImportsResponse,
          MetadataImport,
          ListMetadataImportsPage> {

    private ListMetadataImportsPage(
        PageContext<ListMetadataImportsRequest, ListMetadataImportsResponse, MetadataImport>
            context,
        ListMetadataImportsResponse response) {
      super(context, response);
    }

    private static ListMetadataImportsPage createEmptyPage() {
      return new ListMetadataImportsPage(null, null);
    }

    @Override
    protected ListMetadataImportsPage createPage(
        PageContext<ListMetadataImportsRequest, ListMetadataImportsResponse, MetadataImport>
            context,
        ListMetadataImportsResponse response) {
      return new ListMetadataImportsPage(context, response);
    }

    @Override
    public ApiFuture<ListMetadataImportsPage> createPageAsync(
        PageContext<ListMetadataImportsRequest, ListMetadataImportsResponse, MetadataImport>
            context,
        ApiFuture<ListMetadataImportsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListMetadataImportsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListMetadataImportsRequest,
          ListMetadataImportsResponse,
          MetadataImport,
          ListMetadataImportsPage,
          ListMetadataImportsFixedSizeCollection> {

    private ListMetadataImportsFixedSizeCollection(
        List<ListMetadataImportsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListMetadataImportsFixedSizeCollection createEmptyCollection() {
      return new ListMetadataImportsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListMetadataImportsFixedSizeCollection createCollection(
        List<ListMetadataImportsPage> pages, int collectionSize) {
      return new ListMetadataImportsFixedSizeCollection(pages, collectionSize);
    }
  }
}
