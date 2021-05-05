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

package com.google.cloud.osconfig.agentendpoint.v1beta;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ClientSettings;
import com.google.api.gax.rpc.ServerStreamingCallSettings;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.cloud.osconfig.agentendpoint.v1beta.stub.AgentEndpointServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link AgentEndpointServiceClient}.
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
 * AgentEndpointServiceSettings.Builder agentEndpointServiceSettingsBuilder =
 *     AgentEndpointServiceSettings.newBuilder();
 * agentEndpointServiceSettingsBuilder
 *     .startNextTaskSettings()
 *     .setRetrySettings(
 *         agentEndpointServiceSettingsBuilder
 *             .startNextTaskSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * AgentEndpointServiceSettings agentEndpointServiceSettings =
 *     agentEndpointServiceSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class AgentEndpointServiceSettings extends ClientSettings<AgentEndpointServiceSettings> {

  /** Returns the object with the settings used for calls to receiveTaskNotification. */
  public ServerStreamingCallSettings<
          ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationSettings() {
    return ((AgentEndpointServiceStubSettings) getStubSettings()).receiveTaskNotificationSettings();
  }

  /** Returns the object with the settings used for calls to startNextTask. */
  public UnaryCallSettings<StartNextTaskRequest, StartNextTaskResponse> startNextTaskSettings() {
    return ((AgentEndpointServiceStubSettings) getStubSettings()).startNextTaskSettings();
  }

  /** Returns the object with the settings used for calls to reportTaskProgress. */
  public UnaryCallSettings<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressSettings() {
    return ((AgentEndpointServiceStubSettings) getStubSettings()).reportTaskProgressSettings();
  }

  /** Returns the object with the settings used for calls to reportTaskComplete. */
  public UnaryCallSettings<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteSettings() {
    return ((AgentEndpointServiceStubSettings) getStubSettings()).reportTaskCompleteSettings();
  }

  /** Returns the object with the settings used for calls to lookupEffectiveGuestPolicy. */
  public UnaryCallSettings<
          GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
      lookupEffectiveGuestPolicySettings() {
    return ((AgentEndpointServiceStubSettings) getStubSettings())
        .lookupEffectiveGuestPolicySettings();
  }

  /** Returns the object with the settings used for calls to registerAgent. */
  public UnaryCallSettings<RegisterAgentRequest, RegisterAgentResponse> registerAgentSettings() {
    return ((AgentEndpointServiceStubSettings) getStubSettings()).registerAgentSettings();
  }

  public static final AgentEndpointServiceSettings create(AgentEndpointServiceStubSettings stub)
      throws IOException {
    return new AgentEndpointServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return AgentEndpointServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return AgentEndpointServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return AgentEndpointServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return AgentEndpointServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return AgentEndpointServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return AgentEndpointServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return AgentEndpointServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected AgentEndpointServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for AgentEndpointServiceSettings. */
  public static class Builder
      extends ClientSettings.Builder<AgentEndpointServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(AgentEndpointServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(AgentEndpointServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(AgentEndpointServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(AgentEndpointServiceStubSettings.newBuilder());
    }

    public AgentEndpointServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((AgentEndpointServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to receiveTaskNotification. */
    public ServerStreamingCallSettings.Builder<
            ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
        receiveTaskNotificationSettings() {
      return getStubSettingsBuilder().receiveTaskNotificationSettings();
    }

    /** Returns the builder for the settings used for calls to startNextTask. */
    public UnaryCallSettings.Builder<StartNextTaskRequest, StartNextTaskResponse>
        startNextTaskSettings() {
      return getStubSettingsBuilder().startNextTaskSettings();
    }

    /** Returns the builder for the settings used for calls to reportTaskProgress. */
    public UnaryCallSettings.Builder<ReportTaskProgressRequest, ReportTaskProgressResponse>
        reportTaskProgressSettings() {
      return getStubSettingsBuilder().reportTaskProgressSettings();
    }

    /** Returns the builder for the settings used for calls to reportTaskComplete. */
    public UnaryCallSettings.Builder<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
        reportTaskCompleteSettings() {
      return getStubSettingsBuilder().reportTaskCompleteSettings();
    }

    /** Returns the builder for the settings used for calls to lookupEffectiveGuestPolicy. */
    public UnaryCallSettings.Builder<
            GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
        lookupEffectiveGuestPolicySettings() {
      return getStubSettingsBuilder().lookupEffectiveGuestPolicySettings();
    }

    /** Returns the builder for the settings used for calls to registerAgent. */
    public UnaryCallSettings.Builder<RegisterAgentRequest, RegisterAgentResponse>
        registerAgentSettings() {
      return getStubSettingsBuilder().registerAgentSettings();
    }

    @Override
    public AgentEndpointServiceSettings build() throws IOException {
      return new AgentEndpointServiceSettings(this);
    }
  }
}
