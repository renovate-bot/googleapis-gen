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

package com.google.cloud.networkservices.v1beta1;

import static com.google.cloud.networkservices.v1beta1.NetworkServicesClient.ListEndpointPoliciesPagedResponse;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ClientSettings;
import com.google.api.gax.rpc.OperationCallSettings;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.cloud.networkservices.v1beta1.stub.NetworkServicesStubSettings;
import com.google.longrunning.Operation;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link NetworkServicesClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (networkservices.googleapis.com) and default port (443) are
 *       used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getEndpointPolicy to 30 seconds:
 *
 * <pre>{@code
 * NetworkServicesSettings.Builder networkServicesSettingsBuilder =
 *     NetworkServicesSettings.newBuilder();
 * networkServicesSettingsBuilder
 *     .getEndpointPolicySettings()
 *     .setRetrySettings(
 *         networkServicesSettingsBuilder
 *             .getEndpointPolicySettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * NetworkServicesSettings networkServicesSettings = networkServicesSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class NetworkServicesSettings extends ClientSettings<NetworkServicesSettings> {

  /** Returns the object with the settings used for calls to listEndpointPolicies. */
  public PagedCallSettings<
          ListEndpointPoliciesRequest, ListEndpointPoliciesResponse,
          ListEndpointPoliciesPagedResponse>
      listEndpointPoliciesSettings() {
    return ((NetworkServicesStubSettings) getStubSettings()).listEndpointPoliciesSettings();
  }

  /** Returns the object with the settings used for calls to getEndpointPolicy. */
  public UnaryCallSettings<GetEndpointPolicyRequest, EndpointPolicy> getEndpointPolicySettings() {
    return ((NetworkServicesStubSettings) getStubSettings()).getEndpointPolicySettings();
  }

  /** Returns the object with the settings used for calls to createEndpointPolicy. */
  public UnaryCallSettings<CreateEndpointPolicyRequest, Operation> createEndpointPolicySettings() {
    return ((NetworkServicesStubSettings) getStubSettings()).createEndpointPolicySettings();
  }

  /** Returns the object with the settings used for calls to createEndpointPolicy. */
  public OperationCallSettings<CreateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      createEndpointPolicyOperationSettings() {
    return ((NetworkServicesStubSettings) getStubSettings())
        .createEndpointPolicyOperationSettings();
  }

  /** Returns the object with the settings used for calls to updateEndpointPolicy. */
  public UnaryCallSettings<UpdateEndpointPolicyRequest, Operation> updateEndpointPolicySettings() {
    return ((NetworkServicesStubSettings) getStubSettings()).updateEndpointPolicySettings();
  }

  /** Returns the object with the settings used for calls to updateEndpointPolicy. */
  public OperationCallSettings<UpdateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      updateEndpointPolicyOperationSettings() {
    return ((NetworkServicesStubSettings) getStubSettings())
        .updateEndpointPolicyOperationSettings();
  }

  /** Returns the object with the settings used for calls to deleteEndpointPolicy. */
  public UnaryCallSettings<DeleteEndpointPolicyRequest, Operation> deleteEndpointPolicySettings() {
    return ((NetworkServicesStubSettings) getStubSettings()).deleteEndpointPolicySettings();
  }

  /** Returns the object with the settings used for calls to deleteEndpointPolicy. */
  public OperationCallSettings<DeleteEndpointPolicyRequest, Empty, OperationMetadata>
      deleteEndpointPolicyOperationSettings() {
    return ((NetworkServicesStubSettings) getStubSettings())
        .deleteEndpointPolicyOperationSettings();
  }

  public static final NetworkServicesSettings create(NetworkServicesStubSettings stub)
      throws IOException {
    return new NetworkServicesSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return NetworkServicesStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return NetworkServicesStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return NetworkServicesStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return NetworkServicesStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return NetworkServicesStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return NetworkServicesStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return NetworkServicesStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected NetworkServicesSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for NetworkServicesSettings. */
  public static class Builder extends ClientSettings.Builder<NetworkServicesSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(NetworkServicesStubSettings.newBuilder(clientContext));
    }

    protected Builder(NetworkServicesSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(NetworkServicesStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(NetworkServicesStubSettings.newBuilder());
    }

    public NetworkServicesStubSettings.Builder getStubSettingsBuilder() {
      return ((NetworkServicesStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to listEndpointPolicies. */
    public PagedCallSettings.Builder<
            ListEndpointPoliciesRequest, ListEndpointPoliciesResponse,
            ListEndpointPoliciesPagedResponse>
        listEndpointPoliciesSettings() {
      return getStubSettingsBuilder().listEndpointPoliciesSettings();
    }

    /** Returns the builder for the settings used for calls to getEndpointPolicy. */
    public UnaryCallSettings.Builder<GetEndpointPolicyRequest, EndpointPolicy>
        getEndpointPolicySettings() {
      return getStubSettingsBuilder().getEndpointPolicySettings();
    }

    /** Returns the builder for the settings used for calls to createEndpointPolicy. */
    public UnaryCallSettings.Builder<CreateEndpointPolicyRequest, Operation>
        createEndpointPolicySettings() {
      return getStubSettingsBuilder().createEndpointPolicySettings();
    }

    /** Returns the builder for the settings used for calls to createEndpointPolicy. */
    public OperationCallSettings.Builder<
            CreateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
        createEndpointPolicyOperationSettings() {
      return getStubSettingsBuilder().createEndpointPolicyOperationSettings();
    }

    /** Returns the builder for the settings used for calls to updateEndpointPolicy. */
    public UnaryCallSettings.Builder<UpdateEndpointPolicyRequest, Operation>
        updateEndpointPolicySettings() {
      return getStubSettingsBuilder().updateEndpointPolicySettings();
    }

    /** Returns the builder for the settings used for calls to updateEndpointPolicy. */
    public OperationCallSettings.Builder<
            UpdateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
        updateEndpointPolicyOperationSettings() {
      return getStubSettingsBuilder().updateEndpointPolicyOperationSettings();
    }

    /** Returns the builder for the settings used for calls to deleteEndpointPolicy. */
    public UnaryCallSettings.Builder<DeleteEndpointPolicyRequest, Operation>
        deleteEndpointPolicySettings() {
      return getStubSettingsBuilder().deleteEndpointPolicySettings();
    }

    /** Returns the builder for the settings used for calls to deleteEndpointPolicy. */
    public OperationCallSettings.Builder<DeleteEndpointPolicyRequest, Empty, OperationMetadata>
        deleteEndpointPolicyOperationSettings() {
      return getStubSettingsBuilder().deleteEndpointPolicyOperationSettings();
    }

    @Override
    public NetworkServicesSettings build() throws IOException {
      return new NetworkServicesSettings(this);
    }
  }
}
