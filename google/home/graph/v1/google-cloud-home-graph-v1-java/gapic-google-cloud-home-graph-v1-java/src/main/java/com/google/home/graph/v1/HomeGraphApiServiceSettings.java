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

package com.google.home.graph.v1;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ClientSettings;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.home.graph.v1.stub.HomeGraphApiServiceStubSettings;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link HomeGraphApiServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (homegraph.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of requestSyncDevices to 30 seconds:
 *
 * <pre>{@code
 * HomeGraphApiServiceSettings.Builder homeGraphApiServiceSettingsBuilder =
 *     HomeGraphApiServiceSettings.newBuilder();
 * homeGraphApiServiceSettingsBuilder
 *     .requestSyncDevicesSettings()
 *     .setRetrySettings(
 *         homeGraphApiServiceSettingsBuilder
 *             .requestSyncDevicesSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * HomeGraphApiServiceSettings homeGraphApiServiceSettings =
 *     homeGraphApiServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class HomeGraphApiServiceSettings extends ClientSettings<HomeGraphApiServiceSettings> {

  /** Returns the object with the settings used for calls to requestSyncDevices. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesSettings() {
    return ((HomeGraphApiServiceStubSettings) getStubSettings()).requestSyncDevicesSettings();
  }

  /** Returns the object with the settings used for calls to reportStateAndNotification. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationSettings() {
    return ((HomeGraphApiServiceStubSettings) getStubSettings())
        .reportStateAndNotificationSettings();
  }

  /** Returns the object with the settings used for calls to deleteAgentUser. */
  public UnaryCallSettings<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserSettings() {
    return ((HomeGraphApiServiceStubSettings) getStubSettings()).deleteAgentUserSettings();
  }

  /** Returns the object with the settings used for calls to query. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      querySettings() {
    return ((HomeGraphApiServiceStubSettings) getStubSettings()).querySettings();
  }

  /** Returns the object with the settings used for calls to sync. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncSettings() {
    return ((HomeGraphApiServiceStubSettings) getStubSettings()).syncSettings();
  }

  public static final HomeGraphApiServiceSettings create(HomeGraphApiServiceStubSettings stub)
      throws IOException {
    return new HomeGraphApiServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return HomeGraphApiServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return HomeGraphApiServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return HomeGraphApiServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return HomeGraphApiServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return HomeGraphApiServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return HomeGraphApiServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return HomeGraphApiServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected HomeGraphApiServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for HomeGraphApiServiceSettings. */
  public static class Builder extends ClientSettings.Builder<HomeGraphApiServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(HomeGraphApiServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(HomeGraphApiServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(HomeGraphApiServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(HomeGraphApiServiceStubSettings.newBuilder());
    }

    public HomeGraphApiServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((HomeGraphApiServiceStubSettings.Builder) getStubSettings());
    }

    /**
     * Applies the given settings updater function to all of the unary API methods in this service.
     *
     * <p>Note: This method does not support applying settings to streaming methods.
     */
    public Builder applyToAllUnaryMethods(
        ApiFunction<UnaryCallSettings.Builder<?, ?>, Void> settingsUpdater) {
      super.applyToAllUnaryMethods(
          getStubSettingsBuilder().unaryMethodSettingsBuilders(), settingsUpdater);
      return this;
    }

    /** Returns the builder for the settings used for calls to requestSyncDevices. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.RequestSyncDevicesRequest,
            HomeGraphApiServiceProto.RequestSyncDevicesResponse>
        requestSyncDevicesSettings() {
      return getStubSettingsBuilder().requestSyncDevicesSettings();
    }

    /** Returns the builder for the settings used for calls to reportStateAndNotification. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
            HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
        reportStateAndNotificationSettings() {
      return getStubSettingsBuilder().reportStateAndNotificationSettings();
    }

    /** Returns the builder for the settings used for calls to deleteAgentUser. */
    public UnaryCallSettings.Builder<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
        deleteAgentUserSettings() {
      return getStubSettingsBuilder().deleteAgentUserSettings();
    }

    /** Returns the builder for the settings used for calls to query. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
        querySettings() {
      return getStubSettingsBuilder().querySettings();
    }

    /** Returns the builder for the settings used for calls to sync. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
        syncSettings() {
      return getStubSettingsBuilder().syncSettings();
    }

    @Override
    public HomeGraphApiServiceSettings build() throws IOException {
      return new HomeGraphApiServiceSettings(this);
    }
  }
}
