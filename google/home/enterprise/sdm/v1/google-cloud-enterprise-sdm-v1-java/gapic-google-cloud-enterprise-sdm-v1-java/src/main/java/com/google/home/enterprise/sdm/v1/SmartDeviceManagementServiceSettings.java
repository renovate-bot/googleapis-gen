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

import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListDevicesPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListRoomsPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListStructuresPagedResponse;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ClientSettings;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.home.enterprise.sdm.v1.stub.SmartDeviceManagementServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link SmartDeviceManagementServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (smartdevicemanagement.googleapis.com) and default port (443)
 *       are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getDevice to 30 seconds:
 *
 * <pre>{@code
 * SmartDeviceManagementServiceSettings.Builder smartDeviceManagementServiceSettingsBuilder =
 *     SmartDeviceManagementServiceSettings.newBuilder();
 * smartDeviceManagementServiceSettingsBuilder
 *     .getDeviceSettings()
 *     .setRetrySettings(
 *         smartDeviceManagementServiceSettingsBuilder
 *             .getDeviceSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * SmartDeviceManagementServiceSettings smartDeviceManagementServiceSettings =
 *     smartDeviceManagementServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class SmartDeviceManagementServiceSettings
    extends ClientSettings<SmartDeviceManagementServiceSettings> {

  /** Returns the object with the settings used for calls to getDevice. */
  public UnaryCallSettings<GetDeviceRequest, Device> getDeviceSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings()).getDeviceSettings();
  }

  /** Returns the object with the settings used for calls to listDevices. */
  public PagedCallSettings<ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
      listDevicesSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings()).listDevicesSettings();
  }

  /** Returns the object with the settings used for calls to executeDeviceCommand. */
  public UnaryCallSettings<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings())
        .executeDeviceCommandSettings();
  }

  /** Returns the object with the settings used for calls to getStructure. */
  public UnaryCallSettings<GetStructureRequest, Structure> getStructureSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings()).getStructureSettings();
  }

  /** Returns the object with the settings used for calls to listStructures. */
  public PagedCallSettings<
          ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
      listStructuresSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings()).listStructuresSettings();
  }

  /** Returns the object with the settings used for calls to getRoom. */
  public UnaryCallSettings<GetRoomRequest, Room> getRoomSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings()).getRoomSettings();
  }

  /** Returns the object with the settings used for calls to listRooms. */
  public PagedCallSettings<ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
      listRoomsSettings() {
    return ((SmartDeviceManagementServiceStubSettings) getStubSettings()).listRoomsSettings();
  }

  public static final SmartDeviceManagementServiceSettings create(
      SmartDeviceManagementServiceStubSettings stub) throws IOException {
    return new SmartDeviceManagementServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return SmartDeviceManagementServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return SmartDeviceManagementServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return SmartDeviceManagementServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return SmartDeviceManagementServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return SmartDeviceManagementServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return SmartDeviceManagementServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return SmartDeviceManagementServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected SmartDeviceManagementServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for SmartDeviceManagementServiceSettings. */
  public static class Builder
      extends ClientSettings.Builder<SmartDeviceManagementServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(SmartDeviceManagementServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(SmartDeviceManagementServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(SmartDeviceManagementServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(SmartDeviceManagementServiceStubSettings.newBuilder());
    }

    public SmartDeviceManagementServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((SmartDeviceManagementServiceStubSettings.Builder) getStubSettings());
    }

    // NEXT_MAJOR_VER: remove 'throws Exception'.
    /**
     * Applies the given settings updater function to all of the unary API methods in this service.
     *
     * <p>Note: This method does not support applying settings to streaming methods.
     */
    public Builder applyToAllUnaryMethods(
        ApiFunction<UnaryCallSettings.Builder<?, ?>, Void> settingsUpdater) throws Exception {
      super.applyToAllUnaryMethods(
          getStubSettingsBuilder().unaryMethodSettingsBuilders(), settingsUpdater);
      return this;
    }

    /** Returns the builder for the settings used for calls to getDevice. */
    public UnaryCallSettings.Builder<GetDeviceRequest, Device> getDeviceSettings() {
      return getStubSettingsBuilder().getDeviceSettings();
    }

    /** Returns the builder for the settings used for calls to listDevices. */
    public PagedCallSettings.Builder<
            ListDevicesRequest, ListDevicesResponse, ListDevicesPagedResponse>
        listDevicesSettings() {
      return getStubSettingsBuilder().listDevicesSettings();
    }

    /** Returns the builder for the settings used for calls to executeDeviceCommand. */
    public UnaryCallSettings.Builder<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
        executeDeviceCommandSettings() {
      return getStubSettingsBuilder().executeDeviceCommandSettings();
    }

    /** Returns the builder for the settings used for calls to getStructure. */
    public UnaryCallSettings.Builder<GetStructureRequest, Structure> getStructureSettings() {
      return getStubSettingsBuilder().getStructureSettings();
    }

    /** Returns the builder for the settings used for calls to listStructures. */
    public PagedCallSettings.Builder<
            ListStructuresRequest, ListStructuresResponse, ListStructuresPagedResponse>
        listStructuresSettings() {
      return getStubSettingsBuilder().listStructuresSettings();
    }

    /** Returns the builder for the settings used for calls to getRoom. */
    public UnaryCallSettings.Builder<GetRoomRequest, Room> getRoomSettings() {
      return getStubSettingsBuilder().getRoomSettings();
    }

    /** Returns the builder for the settings used for calls to listRooms. */
    public PagedCallSettings.Builder<ListRoomsRequest, ListRoomsResponse, ListRoomsPagedResponse>
        listRoomsSettings() {
      return getStubSettingsBuilder().listRoomsSettings();
    }

    @Override
    public SmartDeviceManagementServiceSettings build() throws IOException {
      return new SmartDeviceManagementServiceSettings(this);
    }
  }
}
