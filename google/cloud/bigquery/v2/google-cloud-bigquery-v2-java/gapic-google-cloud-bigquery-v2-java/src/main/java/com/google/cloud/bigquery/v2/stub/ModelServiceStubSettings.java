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

package com.google.cloud.bigquery.v2.stub;

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
import com.google.cloud.bigquery.v2.ModelProto;
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link ModelServiceStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (bigquery.googleapis.com) and default port (443) are used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getModel to 30 seconds:
 *
 * <pre>{@code
 * ModelServiceStubSettings.Builder modelServiceSettingsBuilder =
 *     ModelServiceStubSettings.newBuilder();
 * modelServiceSettingsBuilder
 *     .getModelSettings()
 *     .setRetrySettings(
 *         modelServiceSettingsBuilder
 *             .getModelSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * ModelServiceStubSettings modelServiceSettings = modelServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class ModelServiceStubSettings extends StubSettings<ModelServiceStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder()
          .add("https://www.googleapis.com/auth/bigquery")
          .add("https://www.googleapis.com/auth/bigquery.readonly")
          .add("https://www.googleapis.com/auth/cloud-platform")
          .add("https://www.googleapis.com/auth/cloud-platform.read-only")
          .build();

  private final UnaryCallSettings<ModelProto.GetModelRequest, ModelProto.Model> getModelSettings;
  private final UnaryCallSettings<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsSettings;
  private final UnaryCallSettings<ModelProto.PatchModelRequest, ModelProto.Model>
      patchModelSettings;
  private final UnaryCallSettings<ModelProto.DeleteModelRequest, Empty> deleteModelSettings;

  /** Returns the object with the settings used for calls to getModel. */
  public UnaryCallSettings<ModelProto.GetModelRequest, ModelProto.Model> getModelSettings() {
    return getModelSettings;
  }

  /** Returns the object with the settings used for calls to listModels. */
  public UnaryCallSettings<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsSettings() {
    return listModelsSettings;
  }

  /** Returns the object with the settings used for calls to patchModel. */
  public UnaryCallSettings<ModelProto.PatchModelRequest, ModelProto.Model> patchModelSettings() {
    return patchModelSettings;
  }

  /** Returns the object with the settings used for calls to deleteModel. */
  public UnaryCallSettings<ModelProto.DeleteModelRequest, Empty> deleteModelSettings() {
    return deleteModelSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ModelServiceStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcModelServiceStub.create(this);
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
    return "bigquery.googleapis.com:443";
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
            "gapic", GaxProperties.getLibraryVersion(ModelServiceStubSettings.class))
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

  protected ModelServiceStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    getModelSettings = settingsBuilder.getModelSettings().build();
    listModelsSettings = settingsBuilder.listModelsSettings().build();
    patchModelSettings = settingsBuilder.patchModelSettings().build();
    deleteModelSettings = settingsBuilder.deleteModelSettings().build();
  }

  /** Builder for ModelServiceStubSettings. */
  public static class Builder extends StubSettings.Builder<ModelServiceStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final UnaryCallSettings.Builder<ModelProto.GetModelRequest, ModelProto.Model>
        getModelSettings;
    private final UnaryCallSettings.Builder<
            ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
        listModelsSettings;
    private final UnaryCallSettings.Builder<ModelProto.PatchModelRequest, ModelProto.Model>
        patchModelSettings;
    private final UnaryCallSettings.Builder<ModelProto.DeleteModelRequest, Empty>
        deleteModelSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put(
          "no_retry_0_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      RETRYABLE_CODE_DEFINITIONS = definitions.build();
    }

    private static final ImmutableMap<String, RetrySettings> RETRY_PARAM_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, RetrySettings> definitions = ImmutableMap.builder();
      RetrySettings settings = null;
      settings =
          RetrySettings.newBuilder()
              .setInitialRpcTimeout(Duration.ofMillis(600000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(600000L))
              .setTotalTimeout(Duration.ofMillis(600000L))
              .build();
      definitions.put("no_retry_0_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      getModelSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      listModelsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      patchModelSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      deleteModelSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getModelSettings, listModelsSettings, patchModelSettings, deleteModelSettings);
      initDefaults(this);
    }

    protected Builder(ModelServiceStubSettings settings) {
      super(settings);

      getModelSettings = settings.getModelSettings.toBuilder();
      listModelsSettings = settings.listModelsSettings.toBuilder();
      patchModelSettings = settings.patchModelSettings.toBuilder();
      deleteModelSettings = settings.deleteModelSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getModelSettings, listModelsSettings, patchModelSettings, deleteModelSettings);
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
          .getModelSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_0_params"));

      builder
          .listModelsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_0_params"));

      builder
          .patchModelSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_0_params"));

      builder
          .deleteModelSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_0_params"));

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

    /** Returns the builder for the settings used for calls to getModel. */
    public UnaryCallSettings.Builder<ModelProto.GetModelRequest, ModelProto.Model>
        getModelSettings() {
      return getModelSettings;
    }

    /** Returns the builder for the settings used for calls to listModels. */
    public UnaryCallSettings.Builder<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
        listModelsSettings() {
      return listModelsSettings;
    }

    /** Returns the builder for the settings used for calls to patchModel. */
    public UnaryCallSettings.Builder<ModelProto.PatchModelRequest, ModelProto.Model>
        patchModelSettings() {
      return patchModelSettings;
    }

    /** Returns the builder for the settings used for calls to deleteModel. */
    public UnaryCallSettings.Builder<ModelProto.DeleteModelRequest, Empty> deleteModelSettings() {
      return deleteModelSettings;
    }

    @Override
    public ModelServiceStubSettings build() throws IOException {
      return new ModelServiceStubSettings(this);
    }
  }
}
