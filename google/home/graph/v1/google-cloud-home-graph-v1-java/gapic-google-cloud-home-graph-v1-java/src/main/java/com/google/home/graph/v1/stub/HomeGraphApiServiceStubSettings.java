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

package com.google.home.graph.v1.stub;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GaxProperties;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.GrpcTransportChannel;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.retrying.RetrySettings;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.StatusCode;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import com.google.home.graph.v1.HomeGraphApiServiceProto;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link HomeGraphApiServiceStub}.
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
 * HomeGraphApiServiceStubSettings.Builder homeGraphApiServiceSettingsBuilder =
 *     HomeGraphApiServiceStubSettings.newBuilder();
 * homeGraphApiServiceSettingsBuilder
 *     .requestSyncDevicesSettings()
 *     .setRetrySettings(
 *         homeGraphApiServiceSettingsBuilder
 *             .requestSyncDevicesSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * HomeGraphApiServiceStubSettings homeGraphApiServiceSettings =
 *     homeGraphApiServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class HomeGraphApiServiceStubSettings extends StubSettings<HomeGraphApiServiceStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().build();

  private final UnaryCallSettings<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesSettings;
  private final UnaryCallSettings<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationSettings;
  private final UnaryCallSettings<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserSettings;
  private final UnaryCallSettings<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      querySettings;
  private final UnaryCallSettings<
          HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncSettings;

  /** Returns the object with the settings used for calls to requestSyncDevices. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesSettings() {
    return requestSyncDevicesSettings;
  }

  /** Returns the object with the settings used for calls to reportStateAndNotification. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationSettings() {
    return reportStateAndNotificationSettings;
  }

  /** Returns the object with the settings used for calls to deleteAgentUser. */
  public UnaryCallSettings<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserSettings() {
    return deleteAgentUserSettings;
  }

  /** Returns the object with the settings used for calls to query. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      querySettings() {
    return querySettings;
  }

  /** Returns the object with the settings used for calls to sync. */
  public UnaryCallSettings<
          HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncSettings() {
    return syncSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public HomeGraphApiServiceStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcHomeGraphApiServiceStub.create(this);
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
    return "homegraph.googleapis.com:443";
  }

  /** Returns the default mTLS service endpoint. */
  public static String getDefaultMtlsEndpoint() {
    return "homegraph.mtls.googleapis.com:443";
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
            "gapic", GaxProperties.getLibraryVersion(HomeGraphApiServiceStubSettings.class))
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

  protected HomeGraphApiServiceStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    requestSyncDevicesSettings = settingsBuilder.requestSyncDevicesSettings().build();
    reportStateAndNotificationSettings =
        settingsBuilder.reportStateAndNotificationSettings().build();
    deleteAgentUserSettings = settingsBuilder.deleteAgentUserSettings().build();
    querySettings = settingsBuilder.querySettings().build();
    syncSettings = settingsBuilder.syncSettings().build();
  }

  /** Builder for HomeGraphApiServiceStubSettings. */
  public static class Builder
      extends StubSettings.Builder<HomeGraphApiServiceStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.RequestSyncDevicesRequest,
            HomeGraphApiServiceProto.RequestSyncDevicesResponse>
        requestSyncDevicesSettings;
    private final UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
            HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
        reportStateAndNotificationSettings;
    private final UnaryCallSettings.Builder<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
        deleteAgentUserSettings;
    private final UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
        querySettings;
    private final UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
        syncSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put(
          "no_retry_0_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      definitions.put(
          "retry_policy_1_codes",
          ImmutableSet.copyOf(
              Lists.<StatusCode.Code>newArrayList(
                  StatusCode.Code.UNAVAILABLE, StatusCode.Code.DEADLINE_EXCEEDED)));
      RETRYABLE_CODE_DEFINITIONS = definitions.build();
    }

    private static final ImmutableMap<String, RetrySettings> RETRY_PARAM_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, RetrySettings> definitions = ImmutableMap.builder();
      RetrySettings settings = null;
      settings =
          RetrySettings.newBuilder()
              .setInitialRpcTimeout(Duration.ofMillis(10000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(10000L))
              .setTotalTimeout(Duration.ofMillis(10000L))
              .build();
      definitions.put("no_retry_0_params", settings);
      settings =
          RetrySettings.newBuilder()
              .setInitialRetryDelay(Duration.ofMillis(100L))
              .setRetryDelayMultiplier(1.3)
              .setMaxRetryDelay(Duration.ofMillis(60000L))
              .setInitialRpcTimeout(Duration.ofMillis(10000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(10000L))
              .setTotalTimeout(Duration.ofMillis(10000L))
              .build();
      definitions.put("retry_policy_1_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      requestSyncDevicesSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      reportStateAndNotificationSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      deleteAgentUserSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      querySettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      syncSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              requestSyncDevicesSettings,
              reportStateAndNotificationSettings,
              deleteAgentUserSettings,
              querySettings,
              syncSettings);
      initDefaults(this);
    }

    protected Builder(HomeGraphApiServiceStubSettings settings) {
      super(settings);

      requestSyncDevicesSettings = settings.requestSyncDevicesSettings.toBuilder();
      reportStateAndNotificationSettings = settings.reportStateAndNotificationSettings.toBuilder();
      deleteAgentUserSettings = settings.deleteAgentUserSettings.toBuilder();
      querySettings = settings.querySettings.toBuilder();
      syncSettings = settings.syncSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              requestSyncDevicesSettings,
              reportStateAndNotificationSettings,
              deleteAgentUserSettings,
              querySettings,
              syncSettings);
    }

    private static Builder createDefault() {
      Builder builder = new Builder(((ClientContext) null));

      builder.setTransportChannelProvider(defaultTransportChannelProvider());
      builder.setCredentialsProvider(defaultCredentialsProviderBuilder().build());
      builder.setInternalHeaderProvider(defaultApiClientHeaderProviderBuilder().build());
      builder.setEndpoint(getDefaultEndpoint());
      builder.setMtlsEndpoint(getDefaultMtlsEndpoint());
      builder.setSwitchToMtlsEndpointAllowed(true);

      return initDefaults(builder);
    }

    private static Builder initDefaults(Builder builder) {
      builder
          .requestSyncDevicesSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_0_params"));

      builder
          .reportStateAndNotificationSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_0_params"));

      builder
          .deleteAgentUserSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_1_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_1_params"));

      builder
          .querySettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_1_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_1_params"));

      builder
          .syncSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_1_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_1_params"));

      return builder;
    }

    /**
     * Applies the given settings updater function to all of the unary API methods in this service.
     *
     * <p>Note: This method does not support applying settings to streaming methods.
     */
    public Builder applyToAllUnaryMethods(
        ApiFunction<UnaryCallSettings.Builder<?, ?>, Void> settingsUpdater) {
      super.applyToAllUnaryMethods(unaryMethodSettingsBuilders, settingsUpdater);
      return this;
    }

    public ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders() {
      return unaryMethodSettingsBuilders;
    }

    /** Returns the builder for the settings used for calls to requestSyncDevices. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.RequestSyncDevicesRequest,
            HomeGraphApiServiceProto.RequestSyncDevicesResponse>
        requestSyncDevicesSettings() {
      return requestSyncDevicesSettings;
    }

    /** Returns the builder for the settings used for calls to reportStateAndNotification. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
            HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
        reportStateAndNotificationSettings() {
      return reportStateAndNotificationSettings;
    }

    /** Returns the builder for the settings used for calls to deleteAgentUser. */
    public UnaryCallSettings.Builder<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
        deleteAgentUserSettings() {
      return deleteAgentUserSettings;
    }

    /** Returns the builder for the settings used for calls to query. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
        querySettings() {
      return querySettings;
    }

    /** Returns the builder for the settings used for calls to sync. */
    public UnaryCallSettings.Builder<
            HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
        syncSettings() {
      return syncSettings;
    }

    @Override
    public HomeGraphApiServiceStubSettings build() throws IOException {
      return new HomeGraphApiServiceStubSettings(this);
    }
  }
}
