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

package com.google.cloud.osconfig.agentendpoint.v1beta.stub;

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
import com.google.api.gax.rpc.ServerStreamingCallSettings;
import com.google.api.gax.rpc.StatusCode;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse;
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link AgentEndpointServiceStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (osconfig.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of startNextTask to 30 seconds:
 *
 * <pre>{@code
 * AgentEndpointServiceStubSettings.Builder agentEndpointServiceSettingsBuilder =
 *     AgentEndpointServiceStubSettings.newBuilder();
 * agentEndpointServiceSettingsBuilder
 *     .startNextTaskSettings()
 *     .setRetrySettings(
 *         agentEndpointServiceSettingsBuilder
 *             .startNextTaskSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * AgentEndpointServiceStubSettings agentEndpointServiceSettings =
 *     agentEndpointServiceSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class AgentEndpointServiceStubSettings
    extends StubSettings<AgentEndpointServiceStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().build();

  private final ServerStreamingCallSettings<
          ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationSettings;
  private final UnaryCallSettings<StartNextTaskRequest, StartNextTaskResponse>
      startNextTaskSettings;
  private final UnaryCallSettings<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressSettings;
  private final UnaryCallSettings<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteSettings;
  private final UnaryCallSettings<
          GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
      lookupEffectiveGuestPolicySettings;
  private final UnaryCallSettings<RegisterAgentRequest, RegisterAgentResponse>
      registerAgentSettings;

  /** Returns the object with the settings used for calls to receiveTaskNotification. */
  public ServerStreamingCallSettings<
          ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationSettings() {
    return receiveTaskNotificationSettings;
  }

  /** Returns the object with the settings used for calls to startNextTask. */
  public UnaryCallSettings<StartNextTaskRequest, StartNextTaskResponse> startNextTaskSettings() {
    return startNextTaskSettings;
  }

  /** Returns the object with the settings used for calls to reportTaskProgress. */
  public UnaryCallSettings<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressSettings() {
    return reportTaskProgressSettings;
  }

  /** Returns the object with the settings used for calls to reportTaskComplete. */
  public UnaryCallSettings<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteSettings() {
    return reportTaskCompleteSettings;
  }

  /** Returns the object with the settings used for calls to lookupEffectiveGuestPolicy. */
  public UnaryCallSettings<
          GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
      lookupEffectiveGuestPolicySettings() {
    return lookupEffectiveGuestPolicySettings;
  }

  /** Returns the object with the settings used for calls to registerAgent. */
  public UnaryCallSettings<RegisterAgentRequest, RegisterAgentResponse> registerAgentSettings() {
    return registerAgentSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AgentEndpointServiceStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcAgentEndpointServiceStub.create(this);
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
    return "osconfig.googleapis.com:443";
  }

  /** Returns the default mTLS service endpoint. */
  public static String getDefaultMtlsEndpoint() {
    return "osconfig.mtls.googleapis.com:443";
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
            "gapic", GaxProperties.getLibraryVersion(AgentEndpointServiceStubSettings.class))
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

  protected AgentEndpointServiceStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    receiveTaskNotificationSettings = settingsBuilder.receiveTaskNotificationSettings().build();
    startNextTaskSettings = settingsBuilder.startNextTaskSettings().build();
    reportTaskProgressSettings = settingsBuilder.reportTaskProgressSettings().build();
    reportTaskCompleteSettings = settingsBuilder.reportTaskCompleteSettings().build();
    lookupEffectiveGuestPolicySettings =
        settingsBuilder.lookupEffectiveGuestPolicySettings().build();
    registerAgentSettings = settingsBuilder.registerAgentSettings().build();
  }

  /** Builder for AgentEndpointServiceStubSettings. */
  public static class Builder
      extends StubSettings.Builder<AgentEndpointServiceStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final ServerStreamingCallSettings.Builder<
            ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
        receiveTaskNotificationSettings;
    private final UnaryCallSettings.Builder<StartNextTaskRequest, StartNextTaskResponse>
        startNextTaskSettings;
    private final UnaryCallSettings.Builder<ReportTaskProgressRequest, ReportTaskProgressResponse>
        reportTaskProgressSettings;
    private final UnaryCallSettings.Builder<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
        reportTaskCompleteSettings;
    private final UnaryCallSettings.Builder<
            GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
        lookupEffectiveGuestPolicySettings;
    private final UnaryCallSettings.Builder<RegisterAgentRequest, RegisterAgentResponse>
        registerAgentSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put(
          "retry_policy_1_codes",
          ImmutableSet.copyOf(
              Lists.<StatusCode.Code>newArrayList(
                  StatusCode.Code.DEADLINE_EXCEEDED,
                  StatusCode.Code.CANCELLED,
                  StatusCode.Code.ABORTED,
                  StatusCode.Code.INTERNAL,
                  StatusCode.Code.UNAVAILABLE)));
      definitions.put(
          "retry_policy_0_codes",
          ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList(StatusCode.Code.UNAVAILABLE)));
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
              .setMaxRetryDelay(Duration.ofMillis(60000L))
              .setInitialRpcTimeout(Duration.ofMillis(3600000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(3600000L))
              .setTotalTimeout(Duration.ofMillis(3600000L))
              .build();
      definitions.put("retry_policy_1_params", settings);
      settings =
          RetrySettings.newBuilder()
              .setInitialRetryDelay(Duration.ofMillis(1000L))
              .setRetryDelayMultiplier(1.3)
              .setMaxRetryDelay(Duration.ofMillis(60000L))
              .setInitialRpcTimeout(Duration.ofMillis(60000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(60000L))
              .setTotalTimeout(Duration.ofMillis(60000L))
              .build();
      definitions.put("retry_policy_0_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      receiveTaskNotificationSettings = ServerStreamingCallSettings.newBuilder();
      startNextTaskSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      reportTaskProgressSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      reportTaskCompleteSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      lookupEffectiveGuestPolicySettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      registerAgentSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              startNextTaskSettings,
              reportTaskProgressSettings,
              reportTaskCompleteSettings,
              lookupEffectiveGuestPolicySettings,
              registerAgentSettings);
      initDefaults(this);
    }

    protected Builder(AgentEndpointServiceStubSettings settings) {
      super(settings);

      receiveTaskNotificationSettings = settings.receiveTaskNotificationSettings.toBuilder();
      startNextTaskSettings = settings.startNextTaskSettings.toBuilder();
      reportTaskProgressSettings = settings.reportTaskProgressSettings.toBuilder();
      reportTaskCompleteSettings = settings.reportTaskCompleteSettings.toBuilder();
      lookupEffectiveGuestPolicySettings = settings.lookupEffectiveGuestPolicySettings.toBuilder();
      registerAgentSettings = settings.registerAgentSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              startNextTaskSettings,
              reportTaskProgressSettings,
              reportTaskCompleteSettings,
              lookupEffectiveGuestPolicySettings,
              registerAgentSettings);
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
          .receiveTaskNotificationSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_1_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_1_params"));

      builder
          .startNextTaskSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .reportTaskProgressSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .reportTaskCompleteSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .lookupEffectiveGuestPolicySettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .registerAgentSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

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

    /** Returns the builder for the settings used for calls to receiveTaskNotification. */
    public ServerStreamingCallSettings.Builder<
            ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
        receiveTaskNotificationSettings() {
      return receiveTaskNotificationSettings;
    }

    /** Returns the builder for the settings used for calls to startNextTask. */
    public UnaryCallSettings.Builder<StartNextTaskRequest, StartNextTaskResponse>
        startNextTaskSettings() {
      return startNextTaskSettings;
    }

    /** Returns the builder for the settings used for calls to reportTaskProgress. */
    public UnaryCallSettings.Builder<ReportTaskProgressRequest, ReportTaskProgressResponse>
        reportTaskProgressSettings() {
      return reportTaskProgressSettings;
    }

    /** Returns the builder for the settings used for calls to reportTaskComplete. */
    public UnaryCallSettings.Builder<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
        reportTaskCompleteSettings() {
      return reportTaskCompleteSettings;
    }

    /** Returns the builder for the settings used for calls to lookupEffectiveGuestPolicy. */
    public UnaryCallSettings.Builder<
            GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
        lookupEffectiveGuestPolicySettings() {
      return lookupEffectiveGuestPolicySettings;
    }

    /** Returns the builder for the settings used for calls to registerAgent. */
    public UnaryCallSettings.Builder<RegisterAgentRequest, RegisterAgentResponse>
        registerAgentSettings() {
      return registerAgentSettings;
    }

    @Override
    public AgentEndpointServiceStubSettings build() throws IOException {
      return new AgentEndpointServiceStubSettings(this);
    }
  }
}
