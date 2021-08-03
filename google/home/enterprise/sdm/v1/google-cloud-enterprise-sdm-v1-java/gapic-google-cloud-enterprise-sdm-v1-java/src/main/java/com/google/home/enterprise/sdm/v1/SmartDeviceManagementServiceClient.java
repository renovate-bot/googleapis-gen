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

package com.google.home.enterprise.sdm.v1;

import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.home.enterprise.sdm.v1.stub.SmartDeviceManagementServiceStub;
import com.google.home.enterprise.sdm.v1.stub.SmartDeviceManagementServiceStubSettings;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: A service that allows API consumers to provision and manage Google Home
 * structures and devices for enterprise use cases.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
 *     SmartDeviceManagementServiceClient.create()) {
 *   GetDeviceRequest request = GetDeviceRequest.newBuilder().setName("name3373707").build();
 *   Device response = smartDeviceManagementServiceClient.getDevice(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the SmartDeviceManagementServiceClient object to clean up
 * resources such as threads. In the example above, try-with-resources is used, which automatically
 * calls close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li> A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li> A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li> A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of
 * SmartDeviceManagementServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * SmartDeviceManagementServiceSettings smartDeviceManagementServiceSettings =
 *     SmartDeviceManagementServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
 *     SmartDeviceManagementServiceClient.create(smartDeviceManagementServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * SmartDeviceManagementServiceSettings smartDeviceManagementServiceSettings =
 *     SmartDeviceManagementServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
 *     SmartDeviceManagementServiceClient.create(smartDeviceManagementServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class SmartDeviceManagementServiceClient implements BackgroundResource {
  private final SmartDeviceManagementServiceSettings settings;
  private final SmartDeviceManagementServiceStub stub;

  /** Constructs an instance of SmartDeviceManagementServiceClient with default settings. */
  public static final SmartDeviceManagementServiceClient create() throws IOException {
    return create(SmartDeviceManagementServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of SmartDeviceManagementServiceClient, using the given settings. The
   * channels are created based on the settings passed in, or defaults for any settings that are not
   * set.
   */
  public static final SmartDeviceManagementServiceClient create(
      SmartDeviceManagementServiceSettings settings) throws IOException {
    return new SmartDeviceManagementServiceClient(settings);
  }

  /**
   * Constructs an instance of SmartDeviceManagementServiceClient, using the given stub for making
   * calls. This is for advanced usage - prefer using create(SmartDeviceManagementServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final SmartDeviceManagementServiceClient create(
      SmartDeviceManagementServiceStub stub) {
    return new SmartDeviceManagementServiceClient(stub);
  }

  /**
   * Constructs an instance of SmartDeviceManagementServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected SmartDeviceManagementServiceClient(SmartDeviceManagementServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub =
        ((SmartDeviceManagementServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected SmartDeviceManagementServiceClient(SmartDeviceManagementServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final SmartDeviceManagementServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public SmartDeviceManagementServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a device managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   GetDeviceRequest request = GetDeviceRequest.newBuilder().setName("name3373707").build();
   *   Device response = smartDeviceManagementServiceClient.getDevice(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Device getDevice(GetDeviceRequest request) {
    return getDeviceCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a device managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   GetDeviceRequest request = GetDeviceRequest.newBuilder().setName("name3373707").build();
   *   ApiFuture<Device> future =
   *       smartDeviceManagementServiceClient.getDeviceCallable().futureCall(request);
   *   // Do something.
   *   Device response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetDeviceRequest, Device> getDeviceCallable() {
    return stub.getDeviceCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists devices managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListDevicesRequest request =
   *       ListDevicesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   for (Device element : smartDeviceManagementServiceClient.listDevices(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListDevicesPagedResponse listDevices(ListDevicesRequest request) {
    return listDevicesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists devices managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListDevicesRequest request =
   *       ListDevicesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   ApiFuture<Device> future =
   *       smartDeviceManagementServiceClient.listDevicesPagedCallable().futureCall(request);
   *   // Do something.
   *   for (Device element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListDevicesRequest, ListDevicesPagedResponse>
      listDevicesPagedCallable() {
    return stub.listDevicesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists devices managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListDevicesRequest request =
   *       ListDevicesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   while (true) {
   *     ListDevicesResponse response =
   *         smartDeviceManagementServiceClient.listDevicesCallable().call(request);
   *     for (Device element : response.getResponsesList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListDevicesRequest, ListDevicesResponse> listDevicesCallable() {
    return stub.listDevicesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Executes a command to device managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ExecuteDeviceCommandRequest request =
   *       ExecuteDeviceCommandRequest.newBuilder()
   *           .setName("name3373707")
   *           .setCommand("command950394699")
   *           .setParams(Struct.newBuilder().build())
   *           .build();
   *   ExecuteDeviceCommandResponse response =
   *       smartDeviceManagementServiceClient.executeDeviceCommand(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ExecuteDeviceCommandResponse executeDeviceCommand(
      ExecuteDeviceCommandRequest request) {
    return executeDeviceCommandCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Executes a command to device managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ExecuteDeviceCommandRequest request =
   *       ExecuteDeviceCommandRequest.newBuilder()
   *           .setName("name3373707")
   *           .setCommand("command950394699")
   *           .setParams(Struct.newBuilder().build())
   *           .build();
   *   ApiFuture<ExecuteDeviceCommandResponse> future =
   *       smartDeviceManagementServiceClient.executeDeviceCommandCallable().futureCall(request);
   *   // Do something.
   *   ExecuteDeviceCommandResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandCallable() {
    return stub.executeDeviceCommandCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a structure managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   GetStructureRequest request = GetStructureRequest.newBuilder().setName("name3373707").build();
   *   Structure response = smartDeviceManagementServiceClient.getStructure(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Structure getStructure(GetStructureRequest request) {
    return getStructureCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a structure managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   GetStructureRequest request = GetStructureRequest.newBuilder().setName("name3373707").build();
   *   ApiFuture<Structure> future =
   *       smartDeviceManagementServiceClient.getStructureCallable().futureCall(request);
   *   // Do something.
   *   Structure response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetStructureRequest, Structure> getStructureCallable() {
    return stub.getStructureCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists structures managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListStructuresRequest request =
   *       ListStructuresRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   for (Structure element :
   *       smartDeviceManagementServiceClient.listStructures(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListStructuresPagedResponse listStructures(ListStructuresRequest request) {
    return listStructuresPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists structures managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListStructuresRequest request =
   *       ListStructuresRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   ApiFuture<Structure> future =
   *       smartDeviceManagementServiceClient.listStructuresPagedCallable().futureCall(request);
   *   // Do something.
   *   for (Structure element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListStructuresRequest, ListStructuresPagedResponse>
      listStructuresPagedCallable() {
    return stub.listStructuresPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists structures managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListStructuresRequest request =
   *       ListStructuresRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   while (true) {
   *     ListStructuresResponse response =
   *         smartDeviceManagementServiceClient.listStructuresCallable().call(request);
   *     for (Structure element : response.getResponsesList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListStructuresRequest, ListStructuresResponse>
      listStructuresCallable() {
    return stub.listStructuresCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a room managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   GetRoomRequest request = GetRoomRequest.newBuilder().setName("name3373707").build();
   *   Room response = smartDeviceManagementServiceClient.getRoom(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Room getRoom(GetRoomRequest request) {
    return getRoomCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a room managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   GetRoomRequest request = GetRoomRequest.newBuilder().setName("name3373707").build();
   *   ApiFuture<Room> future =
   *       smartDeviceManagementServiceClient.getRoomCallable().futureCall(request);
   *   // Do something.
   *   Room response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetRoomRequest, Room> getRoomCallable() {
    return stub.getRoomCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists rooms managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListRoomsRequest request =
   *       ListRoomsRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   for (Room element : smartDeviceManagementServiceClient.listRooms(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListRoomsPagedResponse listRooms(ListRoomsRequest request) {
    return listRoomsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists rooms managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListRoomsRequest request =
   *       ListRoomsRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ApiFuture<Room> future =
   *       smartDeviceManagementServiceClient.listRoomsPagedCallable().futureCall(request);
   *   // Do something.
   *   for (Room element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListRoomsRequest, ListRoomsPagedResponse> listRoomsPagedCallable() {
    return stub.listRoomsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists rooms managed by the enterprise.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (SmartDeviceManagementServiceClient smartDeviceManagementServiceClient =
   *     SmartDeviceManagementServiceClient.create()) {
   *   ListRoomsRequest request =
   *       ListRoomsRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   while (true) {
   *     ListRoomsResponse response =
   *         smartDeviceManagementServiceClient.listRoomsCallable().call(request);
   *     for (Room element : response.getResponsesList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListRoomsRequest, ListRoomsResponse> listRoomsCallable() {
    return stub.listRoomsCallable();
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

  public static class ListDevicesPagedResponse
      extends AbstractPagedListResponse<
          ListDevicesRequest, ListDevicesResponse, Device, ListDevicesPage,
          ListDevicesFixedSizeCollection> {

    public static ApiFuture<ListDevicesPagedResponse> createAsync(
        PageContext<ListDevicesRequest, ListDevicesResponse, Device> context,
        ApiFuture<ListDevicesResponse> futureResponse) {
      ApiFuture<ListDevicesPage> futurePage =
          ListDevicesPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage, input -> new ListDevicesPagedResponse(input), MoreExecutors.directExecutor());
    }

    private ListDevicesPagedResponse(ListDevicesPage page) {
      super(page, ListDevicesFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListDevicesPage
      extends AbstractPage<ListDevicesRequest, ListDevicesResponse, Device, ListDevicesPage> {

    private ListDevicesPage(
        PageContext<ListDevicesRequest, ListDevicesResponse, Device> context,
        ListDevicesResponse response) {
      super(context, response);
    }

    private static ListDevicesPage createEmptyPage() {
      return new ListDevicesPage(null, null);
    }

    @Override
    protected ListDevicesPage createPage(
        PageContext<ListDevicesRequest, ListDevicesResponse, Device> context,
        ListDevicesResponse response) {
      return new ListDevicesPage(context, response);
    }

    @Override
    public ApiFuture<ListDevicesPage> createPageAsync(
        PageContext<ListDevicesRequest, ListDevicesResponse, Device> context,
        ApiFuture<ListDevicesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListDevicesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListDevicesRequest, ListDevicesResponse, Device, ListDevicesPage,
          ListDevicesFixedSizeCollection> {

    private ListDevicesFixedSizeCollection(List<ListDevicesPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListDevicesFixedSizeCollection createEmptyCollection() {
      return new ListDevicesFixedSizeCollection(null, 0);
    }

    @Override
    protected ListDevicesFixedSizeCollection createCollection(
        List<ListDevicesPage> pages, int collectionSize) {
      return new ListDevicesFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListStructuresPagedResponse
      extends AbstractPagedListResponse<
          ListStructuresRequest, ListStructuresResponse, Structure, ListStructuresPage,
          ListStructuresFixedSizeCollection> {

    public static ApiFuture<ListStructuresPagedResponse> createAsync(
        PageContext<ListStructuresRequest, ListStructuresResponse, Structure> context,
        ApiFuture<ListStructuresResponse> futureResponse) {
      ApiFuture<ListStructuresPage> futurePage =
          ListStructuresPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          input -> new ListStructuresPagedResponse(input),
          MoreExecutors.directExecutor());
    }

    private ListStructuresPagedResponse(ListStructuresPage page) {
      super(page, ListStructuresFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListStructuresPage
      extends AbstractPage<
          ListStructuresRequest, ListStructuresResponse, Structure, ListStructuresPage> {

    private ListStructuresPage(
        PageContext<ListStructuresRequest, ListStructuresResponse, Structure> context,
        ListStructuresResponse response) {
      super(context, response);
    }

    private static ListStructuresPage createEmptyPage() {
      return new ListStructuresPage(null, null);
    }

    @Override
    protected ListStructuresPage createPage(
        PageContext<ListStructuresRequest, ListStructuresResponse, Structure> context,
        ListStructuresResponse response) {
      return new ListStructuresPage(context, response);
    }

    @Override
    public ApiFuture<ListStructuresPage> createPageAsync(
        PageContext<ListStructuresRequest, ListStructuresResponse, Structure> context,
        ApiFuture<ListStructuresResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListStructuresFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListStructuresRequest, ListStructuresResponse, Structure, ListStructuresPage,
          ListStructuresFixedSizeCollection> {

    private ListStructuresFixedSizeCollection(List<ListStructuresPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListStructuresFixedSizeCollection createEmptyCollection() {
      return new ListStructuresFixedSizeCollection(null, 0);
    }

    @Override
    protected ListStructuresFixedSizeCollection createCollection(
        List<ListStructuresPage> pages, int collectionSize) {
      return new ListStructuresFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListRoomsPagedResponse
      extends AbstractPagedListResponse<
          ListRoomsRequest, ListRoomsResponse, Room, ListRoomsPage, ListRoomsFixedSizeCollection> {

    public static ApiFuture<ListRoomsPagedResponse> createAsync(
        PageContext<ListRoomsRequest, ListRoomsResponse, Room> context,
        ApiFuture<ListRoomsResponse> futureResponse) {
      ApiFuture<ListRoomsPage> futurePage =
          ListRoomsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage, input -> new ListRoomsPagedResponse(input), MoreExecutors.directExecutor());
    }

    private ListRoomsPagedResponse(ListRoomsPage page) {
      super(page, ListRoomsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListRoomsPage
      extends AbstractPage<ListRoomsRequest, ListRoomsResponse, Room, ListRoomsPage> {

    private ListRoomsPage(
        PageContext<ListRoomsRequest, ListRoomsResponse, Room> context,
        ListRoomsResponse response) {
      super(context, response);
    }

    private static ListRoomsPage createEmptyPage() {
      return new ListRoomsPage(null, null);
    }

    @Override
    protected ListRoomsPage createPage(
        PageContext<ListRoomsRequest, ListRoomsResponse, Room> context,
        ListRoomsResponse response) {
      return new ListRoomsPage(context, response);
    }

    @Override
    public ApiFuture<ListRoomsPage> createPageAsync(
        PageContext<ListRoomsRequest, ListRoomsResponse, Room> context,
        ApiFuture<ListRoomsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListRoomsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListRoomsRequest, ListRoomsResponse, Room, ListRoomsPage, ListRoomsFixedSizeCollection> {

    private ListRoomsFixedSizeCollection(List<ListRoomsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListRoomsFixedSizeCollection createEmptyCollection() {
      return new ListRoomsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListRoomsFixedSizeCollection createCollection(
        List<ListRoomsPage> pages, int collectionSize) {
      return new ListRoomsFixedSizeCollection(pages, collectionSize);
    }
  }
}
