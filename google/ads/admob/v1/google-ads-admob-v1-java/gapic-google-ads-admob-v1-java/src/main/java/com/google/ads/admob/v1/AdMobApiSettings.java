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

package com.google.ads.admob.v1;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.ads.admob.v1.stub.AdMobApiStubSettings;
import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ClientSettings;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.ServerStreamingCallSettings;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link AdMobApiClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (admob.googleapis.com) and default port (443) are used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getPublisherAccount to 30 seconds:
 *
 * <pre>{@code
 * AdMobApiSettings.Builder adMobApiSettingsBuilder = AdMobApiSettings.newBuilder();
 * adMobApiSettingsBuilder
 *     .getPublisherAccountSettings()
 *     .setRetrySettings(
 *         adMobApiSettingsBuilder
 *             .getPublisherAccountSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * AdMobApiSettings adMobApiSettings = adMobApiSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class AdMobApiSettings extends ClientSettings<AdMobApiSettings> {

  /** Returns the object with the settings used for calls to getPublisherAccount. */
  public UnaryCallSettings<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountSettings() {
    return ((AdMobApiStubSettings) getStubSettings()).getPublisherAccountSettings();
  }

  /** Returns the object with the settings used for calls to listPublisherAccounts. */
  public PagedCallSettings<
          AdMobApiProto.ListPublisherAccountsRequest,
          AdMobApiProto.ListPublisherAccountsResponse,
          ListPublisherAccountsPagedResponse>
      listPublisherAccountsSettings() {
    return ((AdMobApiStubSettings) getStubSettings()).listPublisherAccountsSettings();
  }

  /** Returns the object with the settings used for calls to generateNetworkReport. */
  public ServerStreamingCallSettings<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportSettings() {
    return ((AdMobApiStubSettings) getStubSettings()).generateNetworkReportSettings();
  }

  /** Returns the object with the settings used for calls to generateMediationReport. */
  public ServerStreamingCallSettings<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportSettings() {
    return ((AdMobApiStubSettings) getStubSettings()).generateMediationReportSettings();
  }

  public static final AdMobApiSettings create(AdMobApiStubSettings stub) throws IOException {
    return new AdMobApiSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return AdMobApiStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return AdMobApiStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return AdMobApiStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return AdMobApiStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return AdMobApiStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return AdMobApiStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return AdMobApiStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected AdMobApiSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for AdMobApiSettings. */
  public static class Builder extends ClientSettings.Builder<AdMobApiSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(AdMobApiStubSettings.newBuilder(clientContext));
    }

    protected Builder(AdMobApiSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(AdMobApiStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(AdMobApiStubSettings.newBuilder());
    }

    public AdMobApiStubSettings.Builder getStubSettingsBuilder() {
      return ((AdMobApiStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to getPublisherAccount. */
    public UnaryCallSettings.Builder<
            AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
        getPublisherAccountSettings() {
      return getStubSettingsBuilder().getPublisherAccountSettings();
    }

    /** Returns the builder for the settings used for calls to listPublisherAccounts. */
    public PagedCallSettings.Builder<
            AdMobApiProto.ListPublisherAccountsRequest,
            AdMobApiProto.ListPublisherAccountsResponse,
            ListPublisherAccountsPagedResponse>
        listPublisherAccountsSettings() {
      return getStubSettingsBuilder().listPublisherAccountsSettings();
    }

    /** Returns the builder for the settings used for calls to generateNetworkReport. */
    public ServerStreamingCallSettings.Builder<
            AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
        generateNetworkReportSettings() {
      return getStubSettingsBuilder().generateNetworkReportSettings();
    }

    /** Returns the builder for the settings used for calls to generateMediationReport. */
    public ServerStreamingCallSettings.Builder<
            AdMobApiProto.GenerateMediationReportRequest,
            AdMobApiProto.GenerateMediationReportResponse>
        generateMediationReportSettings() {
      return getStubSettingsBuilder().generateMediationReportSettings();
    }

    @Override
    public AdMobApiSettings build() throws IOException {
      return new AdMobApiSettings(this);
    }
  }
}
