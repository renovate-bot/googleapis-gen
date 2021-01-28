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

package com.google.cloud.api.servicemanagement.v1;

import com.google.api.Service;
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
import com.google.api.servicemanagement.v1.ConfigSource;
import com.google.api.servicemanagement.v1.CreateServiceConfigRequest;
import com.google.api.servicemanagement.v1.CreateServiceRequest;
import com.google.api.servicemanagement.v1.CreateServiceRolloutRequest;
import com.google.api.servicemanagement.v1.DeleteServiceRequest;
import com.google.api.servicemanagement.v1.DisableServiceRequest;
import com.google.api.servicemanagement.v1.DisableServiceResponse;
import com.google.api.servicemanagement.v1.EnableServiceRequest;
import com.google.api.servicemanagement.v1.EnableServiceResponse;
import com.google.api.servicemanagement.v1.GenerateConfigReportRequest;
import com.google.api.servicemanagement.v1.GenerateConfigReportResponse;
import com.google.api.servicemanagement.v1.GetServiceConfigRequest;
import com.google.api.servicemanagement.v1.GetServiceRequest;
import com.google.api.servicemanagement.v1.GetServiceRolloutRequest;
import com.google.api.servicemanagement.v1.ListServiceConfigsRequest;
import com.google.api.servicemanagement.v1.ListServiceConfigsResponse;
import com.google.api.servicemanagement.v1.ListServiceRolloutsRequest;
import com.google.api.servicemanagement.v1.ListServiceRolloutsResponse;
import com.google.api.servicemanagement.v1.ListServicesRequest;
import com.google.api.servicemanagement.v1.ListServicesResponse;
import com.google.api.servicemanagement.v1.ManagedService;
import com.google.api.servicemanagement.v1.OperationMetadata;
import com.google.api.servicemanagement.v1.Rollout;
import com.google.api.servicemanagement.v1.SubmitConfigSourceRequest;
import com.google.api.servicemanagement.v1.SubmitConfigSourceResponse;
import com.google.api.servicemanagement.v1.UndeleteServiceRequest;
import com.google.api.servicemanagement.v1.UndeleteServiceResponse;
import com.google.cloud.api.servicemanagement.v1.stub.ServiceManagerStub;
import com.google.cloud.api.servicemanagement.v1.stub.ServiceManagerStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import com.google.protobuf.Any;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: [Google Service Management API](/service-management/overview)
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <p>Note: close() needs to be called on the ServiceManagerClient object to clean up resources such
 * as threads. In the example above, try-with-resources is used, which automatically calls close().
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
 * <p>This class can be customized by passing in a custom instance of ServiceManagerSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * ServiceManagerSettings serviceManagerSettings =
 *     ServiceManagerSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * ServiceManagerClient serviceManagerClient = ServiceManagerClient.create(serviceManagerSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * ServiceManagerSettings serviceManagerSettings =
 *     ServiceManagerSettings.newBuilder().setEndpoint(myEndpoint).build();
 * ServiceManagerClient serviceManagerClient = ServiceManagerClient.create(serviceManagerSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class ServiceManagerClient implements BackgroundResource {
  private final ServiceManagerSettings settings;
  private final ServiceManagerStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of ServiceManagerClient with default settings. */
  public static final ServiceManagerClient create() throws IOException {
    return create(ServiceManagerSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of ServiceManagerClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final ServiceManagerClient create(ServiceManagerSettings settings)
      throws IOException {
    return new ServiceManagerClient(settings);
  }

  /**
   * Constructs an instance of ServiceManagerClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(ServiceManagerSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final ServiceManagerClient create(ServiceManagerStub stub) {
    return new ServiceManagerClient(stub);
  }

  /**
   * Constructs an instance of ServiceManagerClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected ServiceManagerClient(ServiceManagerSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((ServiceManagerStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected ServiceManagerClient(ServiceManagerStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final ServiceManagerSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ServiceManagerStub getStub() {
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
   * Lists managed services.
   *
   * <p>Returns all public services. For authenticated users, also returns all services the calling
   * user has "servicemanagement.services.get" permission for.
   *
   * <p>&#42;&#42;BETA:&#42;&#42; If the caller specifies the `consumer_id`, it returns only the
   * services enabled on the consumer. The `consumer_id` must have the format of
   * "project:{PROJECT-ID}".
   *
   * @param producerProjectId Include services produced by the specified project.
   * @param consumerId Include services consumed by the specified consumer.
   *     <p>The Google Service Management implementation accepts the following forms: -
   *     project:&lt;project_id&gt;
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServicesPagedResponse listServices(String producerProjectId, String consumerId) {
    ListServicesRequest request =
        ListServicesRequest.newBuilder()
            .setProducerProjectId(producerProjectId)
            .setConsumerId(consumerId)
            .build();
    return listServices(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists managed services.
   *
   * <p>Returns all public services. For authenticated users, also returns all services the calling
   * user has "servicemanagement.services.get" permission for.
   *
   * <p>&#42;&#42;BETA:&#42;&#42; If the caller specifies the `consumer_id`, it returns only the
   * services enabled on the consumer. The `consumer_id` must have the format of
   * "project:{PROJECT-ID}".
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServicesPagedResponse listServices(ListServicesRequest request) {
    return listServicesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists managed services.
   *
   * <p>Returns all public services. For authenticated users, also returns all services the calling
   * user has "servicemanagement.services.get" permission for.
   *
   * <p>&#42;&#42;BETA:&#42;&#42; If the caller specifies the `consumer_id`, it returns only the
   * services enabled on the consumer. The `consumer_id` must have the format of
   * "project:{PROJECT-ID}".
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServicesRequest, ListServicesPagedResponse>
      listServicesPagedCallable() {
    return stub.listServicesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists managed services.
   *
   * <p>Returns all public services. For authenticated users, also returns all services the calling
   * user has "servicemanagement.services.get" permission for.
   *
   * <p>&#42;&#42;BETA:&#42;&#42; If the caller specifies the `consumer_id`, it returns only the
   * services enabled on the consumer. The `consumer_id` must have the format of
   * "project:{PROJECT-ID}".
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServicesRequest, ListServicesResponse> listServicesCallable() {
    return stub.listServicesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a managed service. Authentication is required unless the service is public.
   *
   * @param serviceName Required. The name of the service. See the `ServiceManager` overview for
   *     naming requirements. For example: `example.googleapis.com`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ManagedService getService(String serviceName) {
    GetServiceRequest request = GetServiceRequest.newBuilder().setServiceName(serviceName).build();
    return getService(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a managed service. Authentication is required unless the service is public.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ManagedService getService(GetServiceRequest request) {
    return getServiceCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a managed service. Authentication is required unless the service is public.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetServiceRequest, ManagedService> getServiceCallable() {
    return stub.getServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new managed service. Please note one producer project can own no more than 20
   * services.
   *
   * <p>Operation&lt;response: ManagedService&gt;
   *
   * @param service Required. Initial values for the service resource.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<ManagedService, OperationMetadata> createServiceAsync(
      ManagedService service) {
    CreateServiceRequest request = CreateServiceRequest.newBuilder().setService(service).build();
    return createServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new managed service. Please note one producer project can own no more than 20
   * services.
   *
   * <p>Operation&lt;response: ManagedService&gt;
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<ManagedService, OperationMetadata> createServiceAsync(
      CreateServiceRequest request) {
    return createServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new managed service. Please note one producer project can own no more than 20
   * services.
   *
   * <p>Operation&lt;response: ManagedService&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateServiceRequest, ManagedService, OperationMetadata>
      createServiceOperationCallable() {
    return stub.createServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new managed service. Please note one producer project can own no more than 20
   * services.
   *
   * <p>Operation&lt;response: ManagedService&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateServiceRequest, Operation> createServiceCallable() {
    return stub.createServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a managed service. This method will change the service to the `Soft-Delete` state for
   * 30 days. Within this period, service producers may call
   * [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService] to restore
   * the service. After 30 days, the service will be permanently deleted.
   *
   * <p>Operation&lt;response: google.protobuf.Empty&gt;
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteServiceAsync(String serviceName) {
    DeleteServiceRequest request =
        DeleteServiceRequest.newBuilder().setServiceName(serviceName).build();
    return deleteServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a managed service. This method will change the service to the `Soft-Delete` state for
   * 30 days. Within this period, service producers may call
   * [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService] to restore
   * the service. After 30 days, the service will be permanently deleted.
   *
   * <p>Operation&lt;response: google.protobuf.Empty&gt;
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
   * Deletes a managed service. This method will change the service to the `Soft-Delete` state for
   * 30 days. Within this period, service producers may call
   * [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService] to restore
   * the service. After 30 days, the service will be permanently deleted.
   *
   * <p>Operation&lt;response: google.protobuf.Empty&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<DeleteServiceRequest, Empty, OperationMetadata>
      deleteServiceOperationCallable() {
    return stub.deleteServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a managed service. This method will change the service to the `Soft-Delete` state for
   * 30 days. Within this period, service producers may call
   * [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService] to restore
   * the service. After 30 days, the service will be permanently deleted.
   *
   * <p>Operation&lt;response: google.protobuf.Empty&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteServiceRequest, Operation> deleteServiceCallable() {
    return stub.deleteServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Revives a previously deleted managed service. The method restores the service using the
   * configuration at the time the service was deleted. The target service must exist and must have
   * been deleted within the last 30 days.
   *
   * <p>Operation&lt;response: UndeleteServiceResponse&gt;
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<UndeleteServiceResponse, OperationMetadata> undeleteServiceAsync(
      String serviceName) {
    UndeleteServiceRequest request =
        UndeleteServiceRequest.newBuilder().setServiceName(serviceName).build();
    return undeleteServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Revives a previously deleted managed service. The method restores the service using the
   * configuration at the time the service was deleted. The target service must exist and must have
   * been deleted within the last 30 days.
   *
   * <p>Operation&lt;response: UndeleteServiceResponse&gt;
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<UndeleteServiceResponse, OperationMetadata> undeleteServiceAsync(
      UndeleteServiceRequest request) {
    return undeleteServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Revives a previously deleted managed service. The method restores the service using the
   * configuration at the time the service was deleted. The target service must exist and must have
   * been deleted within the last 30 days.
   *
   * <p>Operation&lt;response: UndeleteServiceResponse&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<UndeleteServiceRequest, UndeleteServiceResponse, OperationMetadata>
      undeleteServiceOperationCallable() {
    return stub.undeleteServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Revives a previously deleted managed service. The method restores the service using the
   * configuration at the time the service was deleted. The target service must exist and must have
   * been deleted within the last 30 days.
   *
   * <p>Operation&lt;response: UndeleteServiceResponse&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UndeleteServiceRequest, Operation> undeleteServiceCallable() {
    return stub.undeleteServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration for a managed service, from the newest to the
   * oldest.
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceConfigsPagedResponse listServiceConfigs(String serviceName) {
    ListServiceConfigsRequest request =
        ListServiceConfigsRequest.newBuilder().setServiceName(serviceName).build();
    return listServiceConfigs(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration for a managed service, from the newest to the
   * oldest.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceConfigsPagedResponse listServiceConfigs(
      ListServiceConfigsRequest request) {
    return listServiceConfigsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration for a managed service, from the newest to the
   * oldest.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceConfigsRequest, ListServiceConfigsPagedResponse>
      listServiceConfigsPagedCallable() {
    return stub.listServiceConfigsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration for a managed service, from the newest to the
   * oldest.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceConfigsRequest, ListServiceConfigsResponse>
      listServiceConfigsCallable() {
    return stub.listServiceConfigsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a service configuration (version) for a managed service.
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @param configId Required. The id of the service configuration resource.
   *     <p>This field must be specified for the server to return all fields, including
   *     `SourceInfo`.
   * @param view Specifies which parts of the Service Config should be returned in the response.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service getServiceConfig(
      String serviceName, String configId, GetServiceConfigRequest.ConfigView view) {
    GetServiceConfigRequest request =
        GetServiceConfigRequest.newBuilder()
            .setServiceName(serviceName)
            .setConfigId(configId)
            .setView(view)
            .build();
    return getServiceConfig(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a service configuration (version) for a managed service.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service getServiceConfig(GetServiceConfigRequest request) {
    return getServiceConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a service configuration (version) for a managed service.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetServiceConfigRequest, Service> getServiceConfigCallable() {
    return stub.getServiceConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service. This method only stores
   * the service configuration. To roll out the service configuration to backend systems please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent service configurations and ones referenced by existing rollouts are
   * kept for each service. The rest will be deleted eventually.
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @param serviceConfig Required. The service configuration resource.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service createServiceConfig(String serviceName, Service serviceConfig) {
    CreateServiceConfigRequest request =
        CreateServiceConfigRequest.newBuilder()
            .setServiceName(serviceName)
            .setServiceConfig(serviceConfig)
            .build();
    return createServiceConfig(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service. This method only stores
   * the service configuration. To roll out the service configuration to backend systems please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent service configurations and ones referenced by existing rollouts are
   * kept for each service. The rest will be deleted eventually.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Service createServiceConfig(CreateServiceConfigRequest request) {
    return createServiceConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service. This method only stores
   * the service configuration. To roll out the service configuration to backend systems please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent service configurations and ones referenced by existing rollouts are
   * kept for each service. The rest will be deleted eventually.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateServiceConfigRequest, Service> createServiceConfigCallable() {
    return stub.createServiceConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service based on user-supplied
   * configuration source files (for example: OpenAPI Specification). This method stores the source
   * configurations as well as the generated service configuration. To rollout the service
   * configuration to other services, please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent configuration sources and ones referenced by existing service
   * configurtions are kept for each service. The rest will be deleted eventually.
   *
   * <p>Operation&lt;response: SubmitConfigSourceResponse&gt;
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @param configSource Required. The source configuration for the service.
   * @param validateOnly Optional. If set, this will result in the generation of a
   *     `google.api.Service` configuration based on the `ConfigSource` provided, but the generated
   *     config and the sources will NOT be persisted.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<SubmitConfigSourceResponse, OperationMetadata>
      submitConfigSourceAsync(String serviceName, ConfigSource configSource, boolean validateOnly) {
    SubmitConfigSourceRequest request =
        SubmitConfigSourceRequest.newBuilder()
            .setServiceName(serviceName)
            .setConfigSource(configSource)
            .setValidateOnly(validateOnly)
            .build();
    return submitConfigSourceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service based on user-supplied
   * configuration source files (for example: OpenAPI Specification). This method stores the source
   * configurations as well as the generated service configuration. To rollout the service
   * configuration to other services, please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent configuration sources and ones referenced by existing service
   * configurtions are kept for each service. The rest will be deleted eventually.
   *
   * <p>Operation&lt;response: SubmitConfigSourceResponse&gt;
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<SubmitConfigSourceResponse, OperationMetadata>
      submitConfigSourceAsync(SubmitConfigSourceRequest request) {
    return submitConfigSourceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service based on user-supplied
   * configuration source files (for example: OpenAPI Specification). This method stores the source
   * configurations as well as the generated service configuration. To rollout the service
   * configuration to other services, please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent configuration sources and ones referenced by existing service
   * configurtions are kept for each service. The rest will be deleted eventually.
   *
   * <p>Operation&lt;response: SubmitConfigSourceResponse&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          SubmitConfigSourceRequest, SubmitConfigSourceResponse, OperationMetadata>
      submitConfigSourceOperationCallable() {
    return stub.submitConfigSourceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration (version) for a managed service based on user-supplied
   * configuration source files (for example: OpenAPI Specification). This method stores the source
   * configurations as well as the generated service configuration. To rollout the service
   * configuration to other services, please call
   * [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
   *
   * <p>Only the 100 most recent configuration sources and ones referenced by existing service
   * configurtions are kept for each service. The rest will be deleted eventually.
   *
   * <p>Operation&lt;response: SubmitConfigSourceResponse&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<SubmitConfigSourceRequest, Operation> submitConfigSourceCallable() {
    return stub.submitConfigSourceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration rollouts for a managed service, from the newest
   * to the oldest.
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @param filter Required. Use `filter` to return subset of rollouts. The following filters are
   *     supported: -- To limit the results to only those in
   *     [status](google.api.servicemanagement.v1.RolloutStatus) 'SUCCESS', use
   *     filter='status=SUCCESS' -- To limit the results to those in
   *     [status](google.api.servicemanagement.v1.RolloutStatus) 'CANCELLED' or 'FAILED', use
   *     filter='status=CANCELLED OR status=FAILED'
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceRolloutsPagedResponse listServiceRollouts(
      String serviceName, String filter) {
    ListServiceRolloutsRequest request =
        ListServiceRolloutsRequest.newBuilder()
            .setServiceName(serviceName)
            .setFilter(filter)
            .build();
    return listServiceRollouts(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration rollouts for a managed service, from the newest
   * to the oldest.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceRolloutsPagedResponse listServiceRollouts(
      ListServiceRolloutsRequest request) {
    return listServiceRolloutsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration rollouts for a managed service, from the newest
   * to the oldest.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceRolloutsRequest, ListServiceRolloutsPagedResponse>
      listServiceRolloutsPagedCallable() {
    return stub.listServiceRolloutsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the history of the service configuration rollouts for a managed service, from the newest
   * to the oldest.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceRolloutsRequest, ListServiceRolloutsResponse>
      listServiceRolloutsCallable() {
    return stub.listServiceRolloutsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a service configuration [rollout][google.api.servicemanagement.v1.Rollout].
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @param rolloutId Required. The id of the rollout resource.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Rollout getServiceRollout(String serviceName, String rolloutId) {
    GetServiceRolloutRequest request =
        GetServiceRolloutRequest.newBuilder()
            .setServiceName(serviceName)
            .setRolloutId(rolloutId)
            .build();
    return getServiceRollout(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a service configuration [rollout][google.api.servicemanagement.v1.Rollout].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Rollout getServiceRollout(GetServiceRolloutRequest request) {
    return getServiceRolloutCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a service configuration [rollout][google.api.servicemanagement.v1.Rollout].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetServiceRolloutRequest, Rollout> getServiceRolloutCallable() {
    return stub.getServiceRolloutCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration rollout. Based on rollout, the Google Service Management
   * will roll out the service configurations to different backend services. For example, the
   * logging configuration will be pushed to Google Cloud Logging.
   *
   * <p>Please note that any previous pending and running Rollouts and associated Operations will be
   * automatically cancelled so that the latest Rollout will not be blocked by previous Rollouts.
   *
   * <p>Only the 100 most recent (in any state) and the last 10 successful (if not already part of
   * the set of 100 most recent) rollouts are kept for each service. The rest will be deleted
   * eventually.
   *
   * <p>Operation&lt;response: Rollout&gt;
   *
   * @param serviceName Required. The name of the service. See the
   *     [overview](/service-management/overview) for naming requirements. For example:
   *     `example.googleapis.com`.
   * @param rollout Required. The rollout resource. The `service_name` field is output only.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Rollout, OperationMetadata> createServiceRolloutAsync(
      String serviceName, Rollout rollout) {
    CreateServiceRolloutRequest request =
        CreateServiceRolloutRequest.newBuilder()
            .setServiceName(serviceName)
            .setRollout(rollout)
            .build();
    return createServiceRolloutAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration rollout. Based on rollout, the Google Service Management
   * will roll out the service configurations to different backend services. For example, the
   * logging configuration will be pushed to Google Cloud Logging.
   *
   * <p>Please note that any previous pending and running Rollouts and associated Operations will be
   * automatically cancelled so that the latest Rollout will not be blocked by previous Rollouts.
   *
   * <p>Only the 100 most recent (in any state) and the last 10 successful (if not already part of
   * the set of 100 most recent) rollouts are kept for each service. The rest will be deleted
   * eventually.
   *
   * <p>Operation&lt;response: Rollout&gt;
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Rollout, OperationMetadata> createServiceRolloutAsync(
      CreateServiceRolloutRequest request) {
    return createServiceRolloutOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration rollout. Based on rollout, the Google Service Management
   * will roll out the service configurations to different backend services. For example, the
   * logging configuration will be pushed to Google Cloud Logging.
   *
   * <p>Please note that any previous pending and running Rollouts and associated Operations will be
   * automatically cancelled so that the latest Rollout will not be blocked by previous Rollouts.
   *
   * <p>Only the 100 most recent (in any state) and the last 10 successful (if not already part of
   * the set of 100 most recent) rollouts are kept for each service. The rest will be deleted
   * eventually.
   *
   * <p>Operation&lt;response: Rollout&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateServiceRolloutRequest, Rollout, OperationMetadata>
      createServiceRolloutOperationCallable() {
    return stub.createServiceRolloutOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new service configuration rollout. Based on rollout, the Google Service Management
   * will roll out the service configurations to different backend services. For example, the
   * logging configuration will be pushed to Google Cloud Logging.
   *
   * <p>Please note that any previous pending and running Rollouts and associated Operations will be
   * automatically cancelled so that the latest Rollout will not be blocked by previous Rollouts.
   *
   * <p>Only the 100 most recent (in any state) and the last 10 successful (if not already part of
   * the set of 100 most recent) rollouts are kept for each service. The rest will be deleted
   * eventually.
   *
   * <p>Operation&lt;response: Rollout&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateServiceRolloutRequest, Operation>
      createServiceRolloutCallable() {
    return stub.createServiceRolloutCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Generates and returns a report (errors, warnings and changes from existing configurations)
   * associated with GenerateConfigReportRequest.new_value
   *
   * <p>If GenerateConfigReportRequest.old_value is specified, GenerateConfigReportRequest will
   * contain a single ChangeReport based on the comparison between
   * GenerateConfigReportRequest.new_value and GenerateConfigReportRequest.old_value. If
   * GenerateConfigReportRequest.old_value is not specified, this method will compare
   * GenerateConfigReportRequest.new_value with the last pushed service configuration.
   *
   * @param newConfig Required. Service configuration for which we want to generate the report. For
   *     this version of API, the supported types are
   *     [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
   *     [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
   *     and [google.api.Service][google.api.Service]
   * @param oldConfig Optional. Service configuration against which the comparison will be done. For
   *     this version of API, the supported types are
   *     [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
   *     [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
   *     and [google.api.Service][google.api.Service]
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final GenerateConfigReportResponse generateConfigReport(Any newConfig, Any oldConfig) {
    GenerateConfigReportRequest request =
        GenerateConfigReportRequest.newBuilder()
            .setNewConfig(newConfig)
            .setOldConfig(oldConfig)
            .build();
    return generateConfigReport(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Generates and returns a report (errors, warnings and changes from existing configurations)
   * associated with GenerateConfigReportRequest.new_value
   *
   * <p>If GenerateConfigReportRequest.old_value is specified, GenerateConfigReportRequest will
   * contain a single ChangeReport based on the comparison between
   * GenerateConfigReportRequest.new_value and GenerateConfigReportRequest.old_value. If
   * GenerateConfigReportRequest.old_value is not specified, this method will compare
   * GenerateConfigReportRequest.new_value with the last pushed service configuration.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final GenerateConfigReportResponse generateConfigReport(
      GenerateConfigReportRequest request) {
    return generateConfigReportCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Generates and returns a report (errors, warnings and changes from existing configurations)
   * associated with GenerateConfigReportRequest.new_value
   *
   * <p>If GenerateConfigReportRequest.old_value is specified, GenerateConfigReportRequest will
   * contain a single ChangeReport based on the comparison between
   * GenerateConfigReportRequest.new_value and GenerateConfigReportRequest.old_value. If
   * GenerateConfigReportRequest.old_value is not specified, this method will compare
   * GenerateConfigReportRequest.new_value with the last pushed service configuration.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GenerateConfigReportRequest, GenerateConfigReportResponse>
      generateConfigReportCallable() {
    return stub.generateConfigReportCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Enables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can be
   * used for the project. See [Cloud Auth Guide](https://cloud.google.com/docs/authentication) for
   * more information.
   *
   * <p>Operation&lt;response: EnableServiceResponse&gt;
   *
   * @param serviceName Required. Name of the service to enable. Specifying an unknown service name
   *     will cause the request to fail.
   * @param consumerId Required. The identity of consumer resource which service enablement will be
   *     applied to.
   *     <p>The Google Service Management implementation accepts the following forms: -
   *     "project:&lt;project_id&gt;"
   *     <p>Note: this is made compatible with google.api.servicecontrol.v1.Operation.consumer_id.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EnableServiceResponse, OperationMetadata> enableServiceAsync(
      String serviceName, String consumerId) {
    EnableServiceRequest request =
        EnableServiceRequest.newBuilder()
            .setServiceName(serviceName)
            .setConsumerId(consumerId)
            .build();
    return enableServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Enables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can be
   * used for the project. See [Cloud Auth Guide](https://cloud.google.com/docs/authentication) for
   * more information.
   *
   * <p>Operation&lt;response: EnableServiceResponse&gt;
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EnableServiceResponse, OperationMetadata> enableServiceAsync(
      EnableServiceRequest request) {
    return enableServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Enables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can be
   * used for the project. See [Cloud Auth Guide](https://cloud.google.com/docs/authentication) for
   * more information.
   *
   * <p>Operation&lt;response: EnableServiceResponse&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<EnableServiceRequest, EnableServiceResponse, OperationMetadata>
      enableServiceOperationCallable() {
    return stub.enableServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Enables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can be
   * used for the project. See [Cloud Auth Guide](https://cloud.google.com/docs/authentication) for
   * more information.
   *
   * <p>Operation&lt;response: EnableServiceResponse&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<EnableServiceRequest, Operation> enableServiceCallable() {
    return stub.enableServiceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Disables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can
   * no longer be be used for the project. It prevents accidental usage that may cause unexpected
   * billing charges or security leaks.
   *
   * <p>Operation&lt;response: DisableServiceResponse&gt;
   *
   * @param serviceName Required. Name of the service to disable. Specifying an unknown service name
   *     will cause the request to fail.
   * @param consumerId Required. The identity of consumer resource which service disablement will be
   *     applied to.
   *     <p>The Google Service Management implementation accepts the following forms: -
   *     "project:&lt;project_id&gt;"
   *     <p>Note: this is made compatible with google.api.servicecontrol.v1.Operation.consumer_id.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<DisableServiceResponse, OperationMetadata> disableServiceAsync(
      String serviceName, String consumerId) {
    DisableServiceRequest request =
        DisableServiceRequest.newBuilder()
            .setServiceName(serviceName)
            .setConsumerId(consumerId)
            .build();
    return disableServiceAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Disables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can
   * no longer be be used for the project. It prevents accidental usage that may cause unexpected
   * billing charges or security leaks.
   *
   * <p>Operation&lt;response: DisableServiceResponse&gt;
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<DisableServiceResponse, OperationMetadata> disableServiceAsync(
      DisableServiceRequest request) {
    return disableServiceOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Disables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can
   * no longer be be used for the project. It prevents accidental usage that may cause unexpected
   * billing charges or security leaks.
   *
   * <p>Operation&lt;response: DisableServiceResponse&gt;
   *
   * <p>Sample code:
   */
  public final OperationCallable<DisableServiceRequest, DisableServiceResponse, OperationMetadata>
      disableServiceOperationCallable() {
    return stub.disableServiceOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Disables a [service][google.api.servicemanagement.v1.ManagedService] for a project, so it can
   * no longer be be used for the project. It prevents accidental usage that may cause unexpected
   * billing charges or security leaks.
   *
   * <p>Operation&lt;response: DisableServiceResponse&gt;
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DisableServiceRequest, Operation> disableServiceCallable() {
    return stub.disableServiceCallable();
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
          ManagedService,
          ListServicesPage,
          ListServicesFixedSizeCollection> {

    public static ApiFuture<ListServicesPagedResponse> createAsync(
        PageContext<ListServicesRequest, ListServicesResponse, ManagedService> context,
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
      extends AbstractPage<
          ListServicesRequest, ListServicesResponse, ManagedService, ListServicesPage> {

    private ListServicesPage(
        PageContext<ListServicesRequest, ListServicesResponse, ManagedService> context,
        ListServicesResponse response) {
      super(context, response);
    }

    private static ListServicesPage createEmptyPage() {
      return new ListServicesPage(null, null);
    }

    @Override
    protected ListServicesPage createPage(
        PageContext<ListServicesRequest, ListServicesResponse, ManagedService> context,
        ListServicesResponse response) {
      return new ListServicesPage(context, response);
    }

    @Override
    public ApiFuture<ListServicesPage> createPageAsync(
        PageContext<ListServicesRequest, ListServicesResponse, ManagedService> context,
        ApiFuture<ListServicesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListServicesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListServicesRequest,
          ListServicesResponse,
          ManagedService,
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

  public static class ListServiceConfigsPagedResponse
      extends AbstractPagedListResponse<
          ListServiceConfigsRequest,
          ListServiceConfigsResponse,
          Service,
          ListServiceConfigsPage,
          ListServiceConfigsFixedSizeCollection> {

    public static ApiFuture<ListServiceConfigsPagedResponse> createAsync(
        PageContext<ListServiceConfigsRequest, ListServiceConfigsResponse, Service> context,
        ApiFuture<ListServiceConfigsResponse> futureResponse) {
      ApiFuture<ListServiceConfigsPage> futurePage =
          ListServiceConfigsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListServiceConfigsPage, ListServiceConfigsPagedResponse>() {
            @Override
            public ListServiceConfigsPagedResponse apply(ListServiceConfigsPage input) {
              return new ListServiceConfigsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListServiceConfigsPagedResponse(ListServiceConfigsPage page) {
      super(page, ListServiceConfigsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListServiceConfigsPage
      extends AbstractPage<
          ListServiceConfigsRequest, ListServiceConfigsResponse, Service, ListServiceConfigsPage> {

    private ListServiceConfigsPage(
        PageContext<ListServiceConfigsRequest, ListServiceConfigsResponse, Service> context,
        ListServiceConfigsResponse response) {
      super(context, response);
    }

    private static ListServiceConfigsPage createEmptyPage() {
      return new ListServiceConfigsPage(null, null);
    }

    @Override
    protected ListServiceConfigsPage createPage(
        PageContext<ListServiceConfigsRequest, ListServiceConfigsResponse, Service> context,
        ListServiceConfigsResponse response) {
      return new ListServiceConfigsPage(context, response);
    }

    @Override
    public ApiFuture<ListServiceConfigsPage> createPageAsync(
        PageContext<ListServiceConfigsRequest, ListServiceConfigsResponse, Service> context,
        ApiFuture<ListServiceConfigsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListServiceConfigsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListServiceConfigsRequest,
          ListServiceConfigsResponse,
          Service,
          ListServiceConfigsPage,
          ListServiceConfigsFixedSizeCollection> {

    private ListServiceConfigsFixedSizeCollection(
        List<ListServiceConfigsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListServiceConfigsFixedSizeCollection createEmptyCollection() {
      return new ListServiceConfigsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListServiceConfigsFixedSizeCollection createCollection(
        List<ListServiceConfigsPage> pages, int collectionSize) {
      return new ListServiceConfigsFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListServiceRolloutsPagedResponse
      extends AbstractPagedListResponse<
          ListServiceRolloutsRequest,
          ListServiceRolloutsResponse,
          Rollout,
          ListServiceRolloutsPage,
          ListServiceRolloutsFixedSizeCollection> {

    public static ApiFuture<ListServiceRolloutsPagedResponse> createAsync(
        PageContext<ListServiceRolloutsRequest, ListServiceRolloutsResponse, Rollout> context,
        ApiFuture<ListServiceRolloutsResponse> futureResponse) {
      ApiFuture<ListServiceRolloutsPage> futurePage =
          ListServiceRolloutsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListServiceRolloutsPage, ListServiceRolloutsPagedResponse>() {
            @Override
            public ListServiceRolloutsPagedResponse apply(ListServiceRolloutsPage input) {
              return new ListServiceRolloutsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListServiceRolloutsPagedResponse(ListServiceRolloutsPage page) {
      super(page, ListServiceRolloutsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListServiceRolloutsPage
      extends AbstractPage<
          ListServiceRolloutsRequest,
          ListServiceRolloutsResponse,
          Rollout,
          ListServiceRolloutsPage> {

    private ListServiceRolloutsPage(
        PageContext<ListServiceRolloutsRequest, ListServiceRolloutsResponse, Rollout> context,
        ListServiceRolloutsResponse response) {
      super(context, response);
    }

    private static ListServiceRolloutsPage createEmptyPage() {
      return new ListServiceRolloutsPage(null, null);
    }

    @Override
    protected ListServiceRolloutsPage createPage(
        PageContext<ListServiceRolloutsRequest, ListServiceRolloutsResponse, Rollout> context,
        ListServiceRolloutsResponse response) {
      return new ListServiceRolloutsPage(context, response);
    }

    @Override
    public ApiFuture<ListServiceRolloutsPage> createPageAsync(
        PageContext<ListServiceRolloutsRequest, ListServiceRolloutsResponse, Rollout> context,
        ApiFuture<ListServiceRolloutsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListServiceRolloutsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListServiceRolloutsRequest,
          ListServiceRolloutsResponse,
          Rollout,
          ListServiceRolloutsPage,
          ListServiceRolloutsFixedSizeCollection> {

    private ListServiceRolloutsFixedSizeCollection(
        List<ListServiceRolloutsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListServiceRolloutsFixedSizeCollection createEmptyCollection() {
      return new ListServiceRolloutsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListServiceRolloutsFixedSizeCollection createCollection(
        List<ListServiceRolloutsPage> pages, int collectionSize) {
      return new ListServiceRolloutsFixedSizeCollection(pages, collectionSize);
    }
  }
}
