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

package com.google.maps.playablelocations.v3.stub;

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
import com.google.maps.playablelocations.v3.LogImpressionsRequest;
import com.google.maps.playablelocations.v3.LogImpressionsResponse;
import com.google.maps.playablelocations.v3.LogPlayerReportsRequest;
import com.google.maps.playablelocations.v3.LogPlayerReportsResponse;
import com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest;
import com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link PlayableLocationsStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (playablelocations.googleapis.com) and default port (443) are
 *       used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of samplePlayableLocations to 30 seconds:
 *
 * <pre>{@code
 * PlayableLocationsStubSettings.Builder playableLocationsSettingsBuilder =
 *     PlayableLocationsStubSettings.newBuilder();
 * playableLocationsSettingsBuilder
 *     .samplePlayableLocationsSettings()
 *     .setRetrySettings(
 *         playableLocationsSettingsBuilder
 *             .samplePlayableLocationsSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * PlayableLocationsStubSettings playableLocationsSettings =
 *     playableLocationsSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class PlayableLocationsStubSettings extends StubSettings<PlayableLocationsStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().build();

  private final UnaryCallSettings<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsSettings;
  private final UnaryCallSettings<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsSettings;
  private final UnaryCallSettings<LogImpressionsRequest, LogImpressionsResponse>
      logImpressionsSettings;

  /** Returns the object with the settings used for calls to samplePlayableLocations. */
  public UnaryCallSettings<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsSettings() {
    return samplePlayableLocationsSettings;
  }

  /** Returns the object with the settings used for calls to logPlayerReports. */
  public UnaryCallSettings<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsSettings() {
    return logPlayerReportsSettings;
  }

  /** Returns the object with the settings used for calls to logImpressions. */
  public UnaryCallSettings<LogImpressionsRequest, LogImpressionsResponse> logImpressionsSettings() {
    return logImpressionsSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public PlayableLocationsStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcPlayableLocationsStub.create(this);
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
    return "playablelocations.googleapis.com:443";
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
            "gapic", GaxProperties.getLibraryVersion(PlayableLocationsStubSettings.class))
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

  protected PlayableLocationsStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    samplePlayableLocationsSettings = settingsBuilder.samplePlayableLocationsSettings().build();
    logPlayerReportsSettings = settingsBuilder.logPlayerReportsSettings().build();
    logImpressionsSettings = settingsBuilder.logImpressionsSettings().build();
  }

  /** Builder for PlayableLocationsStubSettings. */
  public static class Builder extends StubSettings.Builder<PlayableLocationsStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final UnaryCallSettings.Builder<
            SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
        samplePlayableLocationsSettings;
    private final UnaryCallSettings.Builder<LogPlayerReportsRequest, LogPlayerReportsResponse>
        logPlayerReportsSettings;
    private final UnaryCallSettings.Builder<LogImpressionsRequest, LogImpressionsResponse>
        logImpressionsSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put("no_retry_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      RETRYABLE_CODE_DEFINITIONS = definitions.build();
    }

    private static final ImmutableMap<String, RetrySettings> RETRY_PARAM_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, RetrySettings> definitions = ImmutableMap.builder();
      RetrySettings settings = null;
      settings = RetrySettings.newBuilder().setRpcTimeoutMultiplier(1.0).build();
      definitions.put("no_retry_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      samplePlayableLocationsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      logPlayerReportsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      logImpressionsSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              samplePlayableLocationsSettings, logPlayerReportsSettings, logImpressionsSettings);
      initDefaults(this);
    }

    protected Builder(PlayableLocationsStubSettings settings) {
      super(settings);

      samplePlayableLocationsSettings = settings.samplePlayableLocationsSettings.toBuilder();
      logPlayerReportsSettings = settings.logPlayerReportsSettings.toBuilder();
      logImpressionsSettings = settings.logImpressionsSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              samplePlayableLocationsSettings, logPlayerReportsSettings, logImpressionsSettings);
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
          .samplePlayableLocationsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_params"));

      builder
          .logPlayerReportsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_params"));

      builder
          .logImpressionsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_params"));

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

    /** Returns the builder for the settings used for calls to samplePlayableLocations. */
    public UnaryCallSettings.Builder<
            SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
        samplePlayableLocationsSettings() {
      return samplePlayableLocationsSettings;
    }

    /** Returns the builder for the settings used for calls to logPlayerReports. */
    public UnaryCallSettings.Builder<LogPlayerReportsRequest, LogPlayerReportsResponse>
        logPlayerReportsSettings() {
      return logPlayerReportsSettings;
    }

    /** Returns the builder for the settings used for calls to logImpressions. */
    public UnaryCallSettings.Builder<LogImpressionsRequest, LogImpressionsResponse>
        logImpressionsSettings() {
      return logImpressionsSettings;
    }

    @Override
    public PlayableLocationsStubSettings build() throws IOException {
      return new PlayableLocationsStubSettings(this);
    }
  }
}
