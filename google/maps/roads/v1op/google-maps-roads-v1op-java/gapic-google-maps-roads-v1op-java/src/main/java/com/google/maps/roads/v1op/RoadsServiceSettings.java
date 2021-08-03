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

package com.google.maps.roads.v1op;

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
import com.google.maps.roads.v1op.stub.RoadsServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link RoadsServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (roads.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of snapToRoads to 30 seconds:
 *
 * <pre>{@code
 * RoadsServiceSettings.Builder roadsServiceSettingsBuilder = RoadsServiceSettings.newBuilder();
 * roadsServiceSettingsBuilder
 *     .snapToRoadsSettings()
 *     .setRetrySettings(
 *         roadsServiceSettingsBuilder
 *             .snapToRoadsSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * RoadsServiceSettings roadsServiceSettings = roadsServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class RoadsServiceSettings extends ClientSettings<RoadsServiceSettings> {

  /** Returns the object with the settings used for calls to snapToRoads. */
  public UnaryCallSettings<SnapToRoadsRequest, SnapToRoadsResponse> snapToRoadsSettings() {
    return ((RoadsServiceStubSettings) getStubSettings()).snapToRoadsSettings();
  }

  /** Returns the object with the settings used for calls to listNearestRoads. */
  public UnaryCallSettings<ListNearestRoadsRequest, ListNearestRoadsResponse>
      listNearestRoadsSettings() {
    return ((RoadsServiceStubSettings) getStubSettings()).listNearestRoadsSettings();
  }

  public static final RoadsServiceSettings create(RoadsServiceStubSettings stub)
      throws IOException {
    return new RoadsServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return RoadsServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return RoadsServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return RoadsServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return RoadsServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return RoadsServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return RoadsServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return RoadsServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected RoadsServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for RoadsServiceSettings. */
  public static class Builder extends ClientSettings.Builder<RoadsServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(RoadsServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(RoadsServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(RoadsServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(RoadsServiceStubSettings.newBuilder());
    }

    public RoadsServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((RoadsServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to snapToRoads. */
    public UnaryCallSettings.Builder<SnapToRoadsRequest, SnapToRoadsResponse>
        snapToRoadsSettings() {
      return getStubSettingsBuilder().snapToRoadsSettings();
    }

    /** Returns the builder for the settings used for calls to listNearestRoads. */
    public UnaryCallSettings.Builder<ListNearestRoadsRequest, ListNearestRoadsResponse>
        listNearestRoadsSettings() {
      return getStubSettingsBuilder().listNearestRoadsSettings();
    }

    @Override
    public RoadsServiceSettings build() throws IOException {
      return new RoadsServiceSettings(this);
    }
  }
}
