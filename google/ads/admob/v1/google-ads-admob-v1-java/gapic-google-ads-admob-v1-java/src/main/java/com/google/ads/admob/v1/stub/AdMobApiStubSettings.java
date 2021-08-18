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

package com.google.ads.admob.v1.stub;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.ads.admob.v1.AdMobApiProto;
import com.google.ads.admob.v1.AdMobResourcesProto;
import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GaxProperties;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.GrpcTransportChannel;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.retrying.RetrySettings;
import com.google.api.gax.rpc.ApiCallContext;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.PagedListDescriptor;
import com.google.api.gax.rpc.PagedListResponseFactory;
import com.google.api.gax.rpc.ServerStreamingCallSettings;
import com.google.api.gax.rpc.StatusCode;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.api.gax.rpc.UnaryCallable;
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
 * Settings class to configure an instance of {@link AdMobApiStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (admob.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getPublisherAccount to 30 seconds:
 *
 * <pre>{@code
 * AdMobApiStubSettings.Builder adMobApiSettingsBuilder = AdMobApiStubSettings.newBuilder();
 * adMobApiSettingsBuilder
 *     .getPublisherAccountSettings()
 *     .setRetrySettings(
 *         adMobApiSettingsBuilder
 *             .getPublisherAccountSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * AdMobApiStubSettings adMobApiSettings = adMobApiSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class AdMobApiStubSettings extends StubSettings<AdMobApiStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().add("https://www.googleapis.com/auth/admob.report").build();

  private final UnaryCallSettings<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountSettings;
  private final PagedCallSettings<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          ListPublisherAccountsPagedResponse>
      listPublisherAccountsSettings;
  private final ServerStreamingCallSettings<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportSettings;
  private final ServerStreamingCallSettings<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportSettings;

  private static final PagedListDescriptor<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          AdMobResourcesProto.PublisherAccount>
      LIST_PUBLISHER_ACCOUNTS_PAGE_STR_DESC =
          new PagedListDescriptor<
              AdMobApiProto.ListPublisherAccountsRequest,
              AdMobApiProto.ListPublisherAccountsResponse, AdMobResourcesProto.PublisherAccount>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public AdMobApiProto.ListPublisherAccountsRequest injectToken(
                AdMobApiProto.ListPublisherAccountsRequest payload, String token) {
              return AdMobApiProto.ListPublisherAccountsRequest.newBuilder(payload)
                  .setPageToken(token)
                  .build();
            }

            @Override
            public AdMobApiProto.ListPublisherAccountsRequest injectPageSize(
                AdMobApiProto.ListPublisherAccountsRequest payload, int pageSize) {
              return AdMobApiProto.ListPublisherAccountsRequest.newBuilder(payload)
                  .setPageSize(pageSize)
                  .build();
            }

            @Override
            public Integer extractPageSize(AdMobApiProto.ListPublisherAccountsRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(AdMobApiProto.ListPublisherAccountsResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<AdMobResourcesProto.PublisherAccount> extractResources(
                AdMobApiProto.ListPublisherAccountsResponse payload) {
              return payload.getAccountList() == null
                  ? ImmutableList.<AdMobResourcesProto.PublisherAccount>of()
                  : payload.getAccountList();
            }
          };

  private static final PagedListResponseFactory<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          ListPublisherAccountsPagedResponse>
      LIST_PUBLISHER_ACCOUNTS_PAGE_STR_FACT =
          new PagedListResponseFactory<
              AdMobApiProto.ListPublisherAccountsRequest,
              AdMobApiProto.ListPublisherAccountsResponse, ListPublisherAccountsPagedResponse>() {
            @Override
            public ApiFuture<ListPublisherAccountsPagedResponse> getFuturePagedResponse(
                UnaryCallable<
                        AdMobApiProto.ListPublisherAccountsRequest,
                        AdMobApiProto.ListPublisherAccountsResponse>
                    callable,
                AdMobApiProto.ListPublisherAccountsRequest request,
                ApiCallContext context,
                ApiFuture<AdMobApiProto.ListPublisherAccountsResponse> futureResponse) {
              PageContext<
                      AdMobApiProto.ListPublisherAccountsRequest,
                      AdMobApiProto.ListPublisherAccountsResponse,
                      AdMobResourcesProto.PublisherAccount>
                  pageContext =
                      PageContext.create(
                          callable, LIST_PUBLISHER_ACCOUNTS_PAGE_STR_DESC, request, context);
              return ListPublisherAccountsPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  /** Returns the object with the settings used for calls to getPublisherAccount. */
  public UnaryCallSettings<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountSettings() {
    return getPublisherAccountSettings;
  }

  /** Returns the object with the settings used for calls to listPublisherAccounts. */
  public PagedCallSettings<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          ListPublisherAccountsPagedResponse>
      listPublisherAccountsSettings() {
    return listPublisherAccountsSettings;
  }

  /** Returns the object with the settings used for calls to generateNetworkReport. */
  public ServerStreamingCallSettings<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportSettings() {
    return generateNetworkReportSettings;
  }

  /** Returns the object with the settings used for calls to generateMediationReport. */
  public ServerStreamingCallSettings<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportSettings() {
    return generateMediationReportSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AdMobApiStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcAdMobApiStub.create(this);
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
    return "admob.googleapis.com:443";
  }

  /** Returns the default mTLS service endpoint. */
  public static String getDefaultMtlsEndpoint() {
    return "admob.mtls.googleapis.com:443";
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return DEFAULT_SERVICE_SCOPES;
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return GoogleCredentialsProvider.newBuilder()
        .setScopesToApply(DEFAULT_SERVICE_SCOPES)
        .setUseJwtAccessWithScope(true);
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
        .setGeneratedLibToken("gapic", GaxProperties.getLibraryVersion(AdMobApiStubSettings.class))
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

  protected AdMobApiStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    getPublisherAccountSettings = settingsBuilder.getPublisherAccountSettings().build();
    listPublisherAccountsSettings = settingsBuilder.listPublisherAccountsSettings().build();
    generateNetworkReportSettings = settingsBuilder.generateNetworkReportSettings().build();
    generateMediationReportSettings = settingsBuilder.generateMediationReportSettings().build();
  }

  /** Builder for AdMobApiStubSettings. */
  public static class Builder extends StubSettings.Builder<AdMobApiStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final UnaryCallSettings.Builder<
            AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
        getPublisherAccountSettings;
    private final PagedCallSettings.Builder<
            AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
            ListPublisherAccountsPagedResponse>
        listPublisherAccountsSettings;
    private final ServerStreamingCallSettings.Builder<
            AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
        generateNetworkReportSettings;
    private final ServerStreamingCallSettings.Builder<
            AdMobApiProto.GenerateMediationReportRequest,
            AdMobApiProto.GenerateMediationReportResponse>
        generateMediationReportSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
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
              .setMaxRetryDelay(Duration.ofMillis(10000L))
              .setInitialRpcTimeout(Duration.ofMillis(120000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(120000L))
              .setTotalTimeout(Duration.ofMillis(120000L))
              .build();
      definitions.put("retry_policy_0_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      getPublisherAccountSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      listPublisherAccountsSettings =
          PagedCallSettings.newBuilder(LIST_PUBLISHER_ACCOUNTS_PAGE_STR_FACT);
      generateNetworkReportSettings = ServerStreamingCallSettings.newBuilder();
      generateMediationReportSettings = ServerStreamingCallSettings.newBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getPublisherAccountSettings, listPublisherAccountsSettings);
      initDefaults(this);
    }

    protected Builder(AdMobApiStubSettings settings) {
      super(settings);

      getPublisherAccountSettings = settings.getPublisherAccountSettings.toBuilder();
      listPublisherAccountsSettings = settings.listPublisherAccountsSettings.toBuilder();
      generateNetworkReportSettings = settings.generateNetworkReportSettings.toBuilder();
      generateMediationReportSettings = settings.generateMediationReportSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              getPublisherAccountSettings, listPublisherAccountsSettings);
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
          .getPublisherAccountSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .listPublisherAccountsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .generateNetworkReportSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("retry_policy_0_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("retry_policy_0_params"));

      builder
          .generateMediationReportSettings()
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

    /** Returns the builder for the settings used for calls to getPublisherAccount. */
    public UnaryCallSettings.Builder<
            AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
        getPublisherAccountSettings() {
      return getPublisherAccountSettings;
    }

    /** Returns the builder for the settings used for calls to listPublisherAccounts. */
    public PagedCallSettings.Builder<
            AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
            ListPublisherAccountsPagedResponse>
        listPublisherAccountsSettings() {
      return listPublisherAccountsSettings;
    }

    /** Returns the builder for the settings used for calls to generateNetworkReport. */
    public ServerStreamingCallSettings.Builder<
            AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
        generateNetworkReportSettings() {
      return generateNetworkReportSettings;
    }

    /** Returns the builder for the settings used for calls to generateMediationReport. */
    public ServerStreamingCallSettings.Builder<
            AdMobApiProto.GenerateMediationReportRequest,
            AdMobApiProto.GenerateMediationReportResponse>
        generateMediationReportSettings() {
      return generateMediationReportSettings;
    }

    @Override
    public AdMobApiStubSettings build() throws IOException {
      return new AdMobApiStubSettings(this);
    }
  }
}
