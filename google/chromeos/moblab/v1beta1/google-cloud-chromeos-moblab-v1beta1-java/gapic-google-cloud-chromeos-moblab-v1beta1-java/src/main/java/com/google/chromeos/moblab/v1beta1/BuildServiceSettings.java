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

package com.google.chromeos.moblab.v1beta1;

import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListBuildTargetsPagedResponse;
import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListBuildsPagedResponse;

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
import com.google.chromeos.moblab.v1beta1.stub.BuildServiceStubSettings;
import com.google.longrunning.Operation;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link BuildServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (chromeosmoblab.googleapis.com) and default port (443) are
 *       used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of checkBuildStageStatus to 30 seconds:
 *
 * <pre>{@code
 * BuildServiceSettings.Builder buildServiceSettingsBuilder = BuildServiceSettings.newBuilder();
 * buildServiceSettingsBuilder
 *     .checkBuildStageStatusSettings()
 *     .setRetrySettings(
 *         buildServiceSettingsBuilder
 *             .checkBuildStageStatusSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * BuildServiceSettings buildServiceSettings = buildServiceSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class BuildServiceSettings extends ClientSettings<BuildServiceSettings> {

  /** Returns the object with the settings used for calls to listBuildTargets. */
  public PagedCallSettings<
          ListBuildTargetsRequest, ListBuildTargetsResponse, ListBuildTargetsPagedResponse>
      listBuildTargetsSettings() {
    return ((BuildServiceStubSettings) getStubSettings()).listBuildTargetsSettings();
  }

  /** Returns the object with the settings used for calls to listBuilds. */
  public PagedCallSettings<ListBuildsRequest, ListBuildsResponse, ListBuildsPagedResponse>
      listBuildsSettings() {
    return ((BuildServiceStubSettings) getStubSettings()).listBuildsSettings();
  }

  /** Returns the object with the settings used for calls to checkBuildStageStatus. */
  public UnaryCallSettings<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
      checkBuildStageStatusSettings() {
    return ((BuildServiceStubSettings) getStubSettings()).checkBuildStageStatusSettings();
  }

  /** Returns the object with the settings used for calls to stageBuild. */
  public UnaryCallSettings<StageBuildRequest, Operation> stageBuildSettings() {
    return ((BuildServiceStubSettings) getStubSettings()).stageBuildSettings();
  }

  /** Returns the object with the settings used for calls to stageBuild. */
  public OperationCallSettings<StageBuildRequest, StageBuildResponse, StageBuildMetadata>
      stageBuildOperationSettings() {
    return ((BuildServiceStubSettings) getStubSettings()).stageBuildOperationSettings();
  }

  /** Returns the object with the settings used for calls to findMostStableBuild. */
  public UnaryCallSettings<FindMostStableBuildRequest, FindMostStableBuildResponse>
      findMostStableBuildSettings() {
    return ((BuildServiceStubSettings) getStubSettings()).findMostStableBuildSettings();
  }

  public static final BuildServiceSettings create(BuildServiceStubSettings stub)
      throws IOException {
    return new BuildServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return BuildServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return BuildServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return BuildServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return BuildServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return BuildServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return BuildServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return BuildServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected BuildServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for BuildServiceSettings. */
  public static class Builder extends ClientSettings.Builder<BuildServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(BuildServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(BuildServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(BuildServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(BuildServiceStubSettings.newBuilder());
    }

    public BuildServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((BuildServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to listBuildTargets. */
    public PagedCallSettings.Builder<
            ListBuildTargetsRequest, ListBuildTargetsResponse, ListBuildTargetsPagedResponse>
        listBuildTargetsSettings() {
      return getStubSettingsBuilder().listBuildTargetsSettings();
    }

    /** Returns the builder for the settings used for calls to listBuilds. */
    public PagedCallSettings.Builder<ListBuildsRequest, ListBuildsResponse, ListBuildsPagedResponse>
        listBuildsSettings() {
      return getStubSettingsBuilder().listBuildsSettings();
    }

    /** Returns the builder for the settings used for calls to checkBuildStageStatus. */
    public UnaryCallSettings.Builder<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
        checkBuildStageStatusSettings() {
      return getStubSettingsBuilder().checkBuildStageStatusSettings();
    }

    /** Returns the builder for the settings used for calls to stageBuild. */
    public UnaryCallSettings.Builder<StageBuildRequest, Operation> stageBuildSettings() {
      return getStubSettingsBuilder().stageBuildSettings();
    }

    /** Returns the builder for the settings used for calls to stageBuild. */
    public OperationCallSettings.Builder<StageBuildRequest, StageBuildResponse, StageBuildMetadata>
        stageBuildOperationSettings() {
      return getStubSettingsBuilder().stageBuildOperationSettings();
    }

    /** Returns the builder for the settings used for calls to findMostStableBuild. */
    public UnaryCallSettings.Builder<FindMostStableBuildRequest, FindMostStableBuildResponse>
        findMostStableBuildSettings() {
      return getStubSettingsBuilder().findMostStableBuildSettings();
    }

    @Override
    public BuildServiceSettings build() throws IOException {
      return new BuildServiceSettings(this);
    }
  }
}
