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

package com.google.home.enterprise.sdm.v1.stub;

import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListDevicesPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListRoomsPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListStructuresPagedResponse;

import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GaxProperties;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.GrpcTransportChannel;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.retrying.RetrySettings;
import com.google.api.gax.rpc.ApiCallContext;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.PagedListDescriptor;
import com.google.api.gax.rpc.PagedListResponseFactory;
import com.google.api.gax.rpc.StatusCode;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import com.google.home.enterprise.sdm.v1.Device;
import com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest;
import com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse;
import com.google.home.enterprise.sdm.v1.GetDeviceRequest;
import com.google.home.enterprise.sdm.v1.GetRoomRequest;
import com.google.home.enterprise.sdm.v1.GetStructureRequest;
import com.google.home.enterprise.sdm.v1.ListDevicesRequest;
import com.google.home.enterprise.sdm.v1.ListDevicesResponse;
import com.google.home.enterprise.sdm.v1.ListRoomsRequest;
import com.google.home.enterprise.sdm.v1.ListRoomsResponse;
import com.google.home.enterprise.sdm.v1.ListStructuresRequest;
import com.google.home.enterprise.sdm.v1.ListStructuresResponse;
import com.google.home.enterprise.sdm.v1.Room;
import com.google.home.enterprise.sdm.v1.Structure;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link SmartDeviceManagementServiceStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (smartdevicemanagement.googleapis.com) and default port (443)
 *       are used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getDevice to 30 seconds:
 *
 * <pre>{@code
 * SmartDeviceManagementServiceStubSettings.Builder smartDeviceManagementServiceSettingsBuilder =
 *     SmartDeviceManagementServiceStubSettings.newBuilder();
 * smartDeviceManagementServiceSettingsBuilder
 *     .getDeviceSettings()
 *     .setRetrySettings(
 *         smartDeviceManagementServiceSettingsBuilder
 *             .getDeviceSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * SmartDeviceManagementServiceStubSettings smartDeviceManagementServiceSettings =
 *     smartDeviceManagementServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class SmartDeviceManagementServiceStubSettings
    extends StubSettings<SmartDeviceManagementServiceStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().add("https://www.googleapis.com/auth/sdm.service").build();

  private final UnaryCallSettings<GetDeviceRequest, Device> getDeviceSettings;
  private final PagedCallSettings<ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
      listDevicesSettings;
  private final UnaryCallSettings<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandSettings;
  private final UnaryCallSettings<GetStructureRequest, Structure> getStructureSettings;
  private final PagedCallSettings<
          ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
      listStructuresSettings;
  private final UnaryCallSettings<GetRoomRequest, Room> getRoomSettings;
  private final PagedCallSettings<ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
      listRoomsSettings;

  private static final PagedListDescriptor<ListDevicesRequest, ListDevicesResponse, Device>
      LIST_DEVICES_PAGE_STR_DESC =
          new PagedListDescriptor<ListDevicesRequest, ListDevicesResponse, Device>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public ListDevicesRequest injectToken(ListDevicesRequest payload, String token) {
              return ListDevicesRequest.newBuilder(payload).setPageToken(token).build();
            }

            @Override
            public ListDevicesRequest injectPageSize(ListDevicesRequest payload, int pageSize) {
              return ListDevicesRequest.newBuilder(payload).setPageSize(pageSize).build();
            }

            @Override
            public Integer extractPageSize(ListDevicesRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(ListDevicesResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<Device> extractResources(ListDevicesResponse payload) {
              return payload.getDevicesList() == null
                  ? ImmutableList.<Device>of()
                  : payload.getDevicesList();
            }
          };

  private static final PagedListDescriptor<ListStructuresRequest, ListStructuresResponse, Structure>
      LIST_STRUCTURES_PAGE_STR_DESC =
          new PagedListDescriptor<ListStructuresRequest, ListStructuresResponse, Structure>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public ListStructuresRequest injectToken(ListStructuresRequest payload, String token) {
              return ListStructuresRequest.newBuilder(payload).setPageToken(token).build();
            }

            @Override
            public ListStructuresRequest injectPageSize(
                ListStructuresRequest payload, int pageSize) {
              return ListStructuresRequest.newBuilder(payload).setPageSize(pageSize).build();
            }

            @Override
            public Integer extractPageSize(ListStructuresRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(ListStructuresResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<Structure> extractResources(ListStructuresResponse payload) {
              return payload.getStructuresList() == null
                  ? ImmutableList.<Structure>of()
                  : payload.getStructuresList();
            }
          };

  private static final PagedListDescriptor<ListRoomsRequest, ListRoomsResponse, Room>
      LIST_ROOMS_PAGE_STR_DESC =
          new PagedListDescriptor<ListRoomsRequest, ListRoomsResponse, Room>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public ListRoomsRequest injectToken(ListRoomsRequest payload, String token) {
              return ListRoomsRequest.newBuilder(payload).setPageToken(token).build();
            }

            @Override
            public ListRoomsRequest injectPageSize(ListRoomsRequest payload, int pageSize) {
              return ListRoomsRequest.newBuilder(payload).setPageSize(pageSize).build();
            }

            @Override
            public Integer extractPageSize(ListRoomsRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(ListRoomsResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<Room> extractResources(ListRoomsResponse payload) {
              return payload.getRoomsList() == null
                  ? ImmutableList.<Room>of()
                  : payload.getRoomsList();
            }
          };

  private static final PagedListResponseFactory<
          ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
      LIST_DEVICES_PAGE_STR_FACT =
          new PagedListResponseFactory<
              ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>() {
            @Override
            public ApiFuture<ListDevicesPagedResponse> getFuturePagedResponse(
                UnaryCallable<ListDevicesRequest, ListDevicesResponse> callable,
                ListDevicesRequest request,
                ApiCallContext context,
                ApiFuture<ListDevicesResponse> futureResponse) {
              PageContext<ListDevicesRequest, ListDevicesResponse, Device> pageContext =
                  PageContext.create(callable, LIST_DEVICES_PAGE_STR_DESC, request, context);
              return ListDevicesPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  private static final PagedListResponseFactory<
          ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
      LIST_STRUCTURES_PAGE_STR_FACT =
          new PagedListResponseFactory<
              ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>() {
            @Override
            public ApiFuture<ListStructuresPagedResponse> getFuturePagedResponse(
                UnaryCallable<ListStructuresRequest, ListStructuresResponse> callable,
                ListStructuresRequest request,
                ApiCallContext context,
                ApiFuture<ListStructuresResponse> futureResponse) {
              PageContext<ListStructuresRequest, ListStructuresResponse, Structure> pageContext =
                  PageContext.create(callable, LIST_STRUCTURES_PAGE_STR_DESC, request, context);
              return ListStructuresPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  private static final PagedListResponseFactory<
          ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
      LIST_ROOMS_PAGE_STR_FACT =
          new PagedListResponseFactory<
              ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>() {
            @Override
            public ApiFuture<ListRoomsPagedResponse> getFuturePagedResponse(
                UnaryCallable<ListRoomsRequest, ListRoomsResponse> callable,
                ListRoomsRequest request,
                ApiCallContext context,
                ApiFuture<ListRoomsResponse> futureResponse) {
              PageContext<ListRoomsRequest, ListRoomsResponse, Room> pageContext =
                  PageContext.create(callable, LIST_ROOMS_PAGE_STR_DESC, request, context);
              return ListRoomsPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  /** Returns the object with the settings used for calls to getDevice. */
  public UnaryCallSettings<GetDeviceRequest, Device> getDeviceSettings() {
    return getDeviceSettings;
  }

  /** Returns the object with the settings used for calls to listDevices. */
  public PagedCallSettings<ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
      listDevicesSettings() {
    return listDevicesSettings;
  }

  /** Returns the object with the settings used for calls to executeDeviceCommand. */
  public UnaryCallSettings<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandSettings() {
    return executeDeviceCommandSettings;
  }

  /** Returns the object with the settings used for calls to getStructure. */
  public UnaryCallSettings<GetStructureRequest, Structure> getStructureSettings() {
    return getStructureSettings;
  }

  /** Returns the object with the settings used for calls to listStructures. */
  public PagedCallSettings<
          ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
      listStructuresSettings() {
    return listStructuresSettings;
  }

  /** Returns the object with the settings used for calls to getRoom. */
  public UnaryCallSettings<GetRoomRequest, Room> getRoomSettings() {
    return getRoomSettings;
  }

  /** Returns the object with the settings used for calls to listRooms. */
  public PagedCallSettings<ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
      listRoomsSettings() {
    return listRoomsSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public SmartDeviceManagementServiceStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcSmartDeviceManagementServiceStub.create(this);
    }
    throw new UnsupportedOperationException(
        String.format(
            "Transport not supported: %s", getTransportChannelProvider().getTransportName()));
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return InstantiatingExecutorProvider.newBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return "smartdevicemanagement.googleapis.com:443";
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return DEFAULT_SERVICE_SCOPES;
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return GoogleCredentialsProvider.newBuilder().setScopesToApply(DEFAULT_SERVICE_SCOPES);
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return InstantiatingGrpcChannelProvider.newBuilder()
        .setMaxInboundMessageSize(Integer.MAX_VALUE);
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return defaultGrpcTransportProviderBuilder().build();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return ApiClientHeaderProvider.newBuilder()
        .setGeneratedLibToken(
            "gapic",
            GaxProperties.getLibraryVersion(SmartDeviceManagementServiceStubSettings.class))
        .setTransportToken(
            GaxGrpcProperties.getGrpcTokenName(), GaxGrpcProperties.getGrpcVersion());
  }

  /** Returns a new builder for this class. */
  public static Builder newBuilder() {
    return Builder.createDefault();
  }

  /** Returns a new builder for this class. */
  public static Builder newBuilder(ClientContext clientContext) {
    return new Builder(clientContext);
  }

  /** Returns a builder containing all the values of this settings class. */
  public Builder toBuilder() {
    return new Builder(this);
  }

  protected SmartDeviceManagementServiceStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    getDeviceSettings = settingsBuilder.getDeviceSettings().build();
    listDevicesSettings = settingsBuilder.listDevicesSettings().build();
    executeDeviceCommandSettings = settingsBuilder.executeDeviceCommandSettings().build();
    getStructureSettings = settingsBuilder.getStructureSettings().build();
    listStructuresSettings = settingsBuilder.listStructuresSettings().build();
    getRoomSettings = settingsBuilder.getRoomSettings().build();
    listRoomsSettings = settingsBuilder.listRoomsSettings().build();
  }

  /** Builder for SmartDeviceManagementServiceStubSettings. */
  public static class Builder
      extends StubSettings.Builder<SmartDeviceManagementServiceStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final UnaryCallSettings.Builder<GetDeviceRequest, Device> getDeviceSettings;
    private final PagedCallSettings.Builder<
            ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
        listDevicesSettings;
    private final UnaryCallSettings.Builder<
            ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
        executeDeviceCommandSettings;
    private final UnaryCallSettings.Builder<GetStructureRequest, Structure> getStructureSettings;
    private final PagedCallSettings.Builder<
            ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
        listStructuresSettings;
    private final UnaryCallSettings.Builder<GetRoomRequest, Room> getRoomSettings;
    private final PagedCallSettings.Builder<
            ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
        listRoomsSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put(
          "retry_policy_0_codes",
          ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList(StatusCode.Code.UNAVAILABLE)));
      definitions.put(
          "no_retry_1_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      RETRYABLE_CODE_DEFINITIONS = definitions.build();
    }

    private static final ImmutableMap<String, RetrySettings> RETRY_PARAM_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, RetrySettings> definitions = ImmutableMap.builder();
      RetrySettings settings = null;
      settings =
          RetrySettings.newBuilder()
              .setInitialRetryDelay(Duration.ofMillis(1000L))
              .setRetryDelayMultiplier(1.3)
              .setMaxRetryDelay(Duration.ofMillis(10000L))
              .setInitialRpcTimeout(Duration.ofMillis(60000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(60000L))
              .setTotalTimeout(Duration.ofMillis(60000L))
              .build();
      definitions.put("retry_policy_0_params", settings);
      settings =
          RetrySettings.newBuilder()
              .setInitialRpcTimeout(Duration.ofMillis(60000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(60000L))
              .setTotalTimeout(Duration.ofMillis(60000L))
              .build();
      definitions.put("no_retry_1_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      getDeviceSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      listDevicesSettings = PagedCallSettings.newBuilder(LIST_DEVICES_PAGE_STR_FACT);
      executeDeviceCommandSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      getStructureSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      listStructuresSettings = PagedCallSettings.newBuilder(LIST_STRUCTURES_PAGE_STR_FACT);
      getRoomSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      listRoomsSettings = PagedCallSettings.newBuilder(LIST_ROOMS_PAGE_STR_FACT);

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getDeviceSettings,
              listDevicesSettings,
              executeDeviceCommandSettings,
              getStructureSettings,
              listStructuresSettings,
              getRoomSettings,
              listRoomsSettings);
      initDefaults(this);
    }

    protected Builder(SmartDeviceManagementServiceStubSettings settings) {
      super(settings);

      getDeviceSettings = settings.getDeviceSettings.toBuilder();
      listDevicesSettings = settings.listDevicesSettings.toBuilder();
      executeDeviceCommandSettings = settings.executeDeviceCommandSettings.toBuilder();
      getStructureSettings = settings.getStructureSettings.toBuilder();
      listStructuresSettings = settings.listStructuresSettings.toBuilder();
      getRoomSettings = settings.getRoomSettings.toBuilder();
      listRoomsSettings = settings.listRoomsSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getDeviceSettings,
              listDevicesSettings,
              executeDeviceCommandSettings,
              getStructureSettings,
              listStructuresSettings,
              getRoomSettings,
              listRoomsSettings);
    }

    private static Builder createDefault() {
      Builder builder = new Builder(((ClientContext) null));

      builder.setTransportChannelProvider(defaultTransportChannelProvider());
      builder.setCredentialsProvider(defaultCredentialsProviderBuilder().build());
      builder.setInternalHeaderProvider(defaultApiClientHeaderProviderBuilder().build());
      builder.setEndpoint(getDefaultEndpoint());

      return initDefaults(builder);
    }

    private static Builder initDefaults(Builder builder) {
      builder
          .getDeviceSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .listDevicesSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .executeDeviceCommandSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_1_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_1_params"));

      builder
          .getStructureSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .listStructuresSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .getRoomSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .listRoomsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      return builder;
    }

    // NEXT_MAJOR_VER: remove 'throws Exception'.
    /**
     * Applies the given settings updater function to all of the unary API methods in this service.
     *
     * <p>Note: This method does not support applying settings to streaming methods.
     */
    public Builder applyToAllUnaryMethods(
        ApiFunction<UnaryCallSettings.Builder<?, ?>, Void> settingsUpdater) throws Exception {
      super.applyToAllUnaryMethods(unaryMethodSettingsBuilders, settingsUpdater);
      return this;
    }

    public ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders() {
      return unaryMethodSettingsBuilders;
    }

    /** Returns the builder for the settings used for calls to getDevice. */
    public UnaryCallSettings.Builder<GetDeviceRequest, Device> getDeviceSettings() {
      return getDeviceSettings;
    }

    /** Returns the builder for the settings used for calls to listDevices. */
    public PagedCallSettings.Builder<
            ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
        listDevicesSettings() {
      return listDevicesSettings;
    }

    /** Returns the builder for the settings used for calls to executeDeviceCommand. */
    public UnaryCallSettings.Builder<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
        executeDeviceCommandSettings() {
      return executeDeviceCommandSettings;
    }

    /** Returns the builder for the settings used for calls to getStructure. */
    public UnaryCallSettings.Builder<GetStructureRequest, Structure> getStructureSettings() {
      return getStructureSettings;
    }

    /** Returns the builder for the settings used for calls to listStructures. */
    public PagedCallSettings.Builder<
            ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
        listStructuresSettings() {
      return listStructuresSettings;
    }

    /** Returns the builder for the settings used for calls to getRoom. */
    public UnaryCallSettings.Builder<GetRoomRequest, Room> getRoomSettings() {
      return getRoomSettings;
    }

    /** Returns the builder for the settings used for calls to listRooms. */
    public PagedCallSettings.Builder<ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
        listRoomsSettings() {
      return listRoomsSettings;
    }

    @Override
    public SmartDeviceManagementServiceStubSettings build() throws IOException {
      return new SmartDeviceManagementServiceStubSettings(this);
    }
  }
}
