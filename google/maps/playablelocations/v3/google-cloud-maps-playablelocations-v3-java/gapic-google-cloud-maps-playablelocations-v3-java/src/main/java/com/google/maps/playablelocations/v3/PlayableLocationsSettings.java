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

package com.google.maps.playablelocations.v3;

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
import com.google.maps.playablelocations.v3.stub.PlayableLocationsStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link PlayableLocationsClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (playablelocations.googleapis.com) and default port (443) are
 *       used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of samplePlayableLocations to 30 seconds:
 *
 * <pre>{@code
 * PlayableLocationsSettings.Builder playableLocationsSettingsBuilder =
 *     PlayableLocationsSettings.newBuilder();
 * playableLocationsSettingsBuilder
 *     .samplePlayableLocationsSettings()
 *     .setRetrySettings(
 *         playableLocationsSettingsBuilder
 *             .samplePlayableLocationsSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * PlayableLocationsSettings playableLocationsSettings = playableLocationsSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class PlayableLocationsSettings extends ClientSettings<PlayableLocationsSettings> {

  /** Returns the object with the settings used for calls to samplePlayableLocations. */
  public UnaryCallSettings<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsSettings() {
    return ((PlayableLocationsStubSettings) getStubSettings()).samplePlayableLocationsSettings();
  }

  /** Returns the object with the settings used for calls to logPlayerReports. */
  public UnaryCallSettings<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsSettings() {
    return ((PlayableLocationsStubSettings) getStubSettings()).logPlayerReportsSettings();
  }

  /** Returns the object with the settings used for calls to logImpressions. */
  public UnaryCallSettings<LogImpressionsRequest, LogImpressionsResponse> logImpressionsSettings() {
    return ((PlayableLocationsStubSettings) getStubSettings()).logImpressionsSettings();
  }

  public static final PlayableLocationsSettings create(PlayableLocationsStubSettings stub)
      throws IOException {
    return new PlayableLocationsSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return PlayableLocationsStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return PlayableLocationsStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return PlayableLocationsStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return PlayableLocationsStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return PlayableLocationsStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return PlayableLocationsStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return PlayableLocationsStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected PlayableLocationsSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for PlayableLocationsSettings. */
  public static class Builder extends ClientSettings.Builder<PlayableLocationsSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(PlayableLocationsStubSettings.newBuilder(clientContext));
    }

    protected Builder(PlayableLocationsSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(PlayableLocationsStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(PlayableLocationsStubSettings.newBuilder());
    }

    public PlayableLocationsStubSettings.Builder getStubSettingsBuilder() {
      return ((PlayableLocationsStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to samplePlayableLocations. */
    public UnaryCallSettings.Builder<
            SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
        samplePlayableLocationsSettings() {
      return getStubSettingsBuilder().samplePlayableLocationsSettings();
    }

    /** Returns the builder for the settings used for calls to logPlayerReports. */
    public UnaryCallSettings.Builder<LogPlayerReportsRequest, LogPlayerReportsResponse>
        logPlayerReportsSettings() {
      return getStubSettingsBuilder().logPlayerReportsSettings();
    }

    /** Returns the builder for the settings used for calls to logImpressions. */
    public UnaryCallSettings.Builder<LogImpressionsRequest, LogImpressionsResponse>
        logImpressionsSettings() {
      return getStubSettingsBuilder().logImpressionsSettings();
    }

    @Override
    public PlayableLocationsSettings build() throws IOException {
      return new PlayableLocationsSettings(this);
    }
  }
}
