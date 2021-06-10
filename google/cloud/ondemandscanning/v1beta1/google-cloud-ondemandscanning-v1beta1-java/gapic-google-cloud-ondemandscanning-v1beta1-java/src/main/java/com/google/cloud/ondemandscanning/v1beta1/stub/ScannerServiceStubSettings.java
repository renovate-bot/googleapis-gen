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

package com.google.cloud.ondemandscanning.v1beta1.stub;

import static com.google.cloud.ondemandscanning.v1beta1.ScannerServiceClient.ListVulnerabilitiesPagedResponse;

import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GaxProperties;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.GrpcTransportChannel;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.grpc.ProtoOperationTransformers;
import com.google.api.gax.longrunning.OperationSnapshot;
import com.google.api.gax.longrunning.OperationTimedPollAlgorithm;
import com.google.api.gax.retrying.RetrySettings;
import com.google.api.gax.rpc.ApiCallContext;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.OperationCallSettings;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.PagedListDescriptor;
import com.google.api.gax.rpc.PagedListResponseFactory;
import com.google.api.gax.rpc.StatusCode;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesMetadata;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesRequest;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesResponse;
import com.google.cloud.ondemandscanning.v1beta1.ListVulnerabilitiesRequest;
import com.google.cloud.ondemandscanning.v1beta1.ListVulnerabilitiesResponse;
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import com.google.longrunning.Operation;
import io.grafeas.v1.Occurrence;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link ScannerServiceStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (ondemandscanning.googleapis.com) and default port (443) are
 *       used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of analyzePackages to 30 seconds:
 *
 * <pre>{@code
 * ScannerServiceStubSettings.Builder scannerServiceSettingsBuilder =
 *     ScannerServiceStubSettings.newBuilder();
 * scannerServiceSettingsBuilder
 *     .analyzePackagesSettings()
 *     .setRetrySettings(
 *         scannerServiceSettingsBuilder
 *             .analyzePackagesSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * ScannerServiceStubSettings scannerServiceSettings = scannerServiceSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class ScannerServiceStubSettings extends StubSettings<ScannerServiceStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().add("https://www.googleapis.com/auth/cloud-platform").build();

  private final UnaryCallSettings<AnalyzePackagesRequest, Operation> analyzePackagesSettings;
  private final OperationCallSettings<
          AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesOperationSettings;
  private final PagedCallSettings<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, ListVulnerabilitiesPagedResponse>
      listVulnerabilitiesSettings;

  private static final PagedListDescriptor<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence>
      LIST_VULNERABILITIES_PAGE_STR_DESC =
          new PagedListDescriptor<
              ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public ListVulnerabilitiesRequest injectToken(
                ListVulnerabilitiesRequest payload, String token) {
              return ListVulnerabilitiesRequest.newBuilder(payload).setPageToken(token).build();
            }

            @Override
            public ListVulnerabilitiesRequest injectPageSize(
                ListVulnerabilitiesRequest payload, int pageSize) {
              return ListVulnerabilitiesRequest.newBuilder(payload).setPageSize(pageSize).build();
            }

            @Override
            public Integer extractPageSize(ListVulnerabilitiesRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(ListVulnerabilitiesResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<Occurrence> extractResources(ListVulnerabilitiesResponse payload) {
              return payload.getOccurrencesList() == null
                  ? ImmutableList.<Occurrence>of()
                  : payload.getOccurrencesList();
            }
          };

  private static final PagedListResponseFactory<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, ListVulnerabilitiesPagedResponse>
      LIST_VULNERABILITIES_PAGE_STR_FACT =
          new PagedListResponseFactory<
              ListVulnerabilitiesRequest, ListVulnerabilitiesResponse,
              ListVulnerabilitiesPagedResponse>() {
            @Override
            public ApiFuture<ListVulnerabilitiesPagedResponse> getFuturePagedResponse(
                UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse> callable,
                ListVulnerabilitiesRequest request,
                ApiCallContext context,
                ApiFuture<ListVulnerabilitiesResponse> futureResponse) {
              PageContext<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence>
                  pageContext =
                      PageContext.create(
                          callable, LIST_VULNERABILITIES_PAGE_STR_DESC, request, context);
              return ListVulnerabilitiesPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  /** Returns the object with the settings used for calls to analyzePackages. */
  public UnaryCallSettings<AnalyzePackagesRequest, Operation> analyzePackagesSettings() {
    return analyzePackagesSettings;
  }

  /** Returns the object with the settings used for calls to analyzePackages. */
  public OperationCallSettings<
          AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesOperationSettings() {
    return analyzePackagesOperationSettings;
  }

  /** Returns the object with the settings used for calls to listVulnerabilities. */
  public PagedCallSettings<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, ListVulnerabilitiesPagedResponse>
      listVulnerabilitiesSettings() {
    return listVulnerabilitiesSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ScannerServiceStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcScannerServiceStub.create(this);
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
    return "ondemandscanning.googleapis.com:443";
  }

  /** Returns the default mTLS service endpoint. */
  public static String getDefaultMtlsEndpoint() {
    return "ondemandscanning.mtls.googleapis.com:443";
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
            "gapic", GaxProperties.getLibraryVersion(ScannerServiceStubSettings.class))
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

  protected ScannerServiceStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    analyzePackagesSettings = settingsBuilder.analyzePackagesSettings().build();
    analyzePackagesOperationSettings = settingsBuilder.analyzePackagesOperationSettings().build();
    listVulnerabilitiesSettings = settingsBuilder.listVulnerabilitiesSettings().build();
  }

  /** Builder for ScannerServiceStubSettings. */
  public static class Builder extends StubSettings.Builder<ScannerServiceStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final UnaryCallSettings.Builder<AnalyzePackagesRequest, Operation>
        analyzePackagesSettings;
    private final OperationCallSettings.Builder<
            AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
        analyzePackagesOperationSettings;
    private final PagedCallSettings.Builder<
            ListVulnerabilitiesRequest, ListVulnerabilitiesResponse,
            ListVulnerabilitiesPagedResponse>
        listVulnerabilitiesSettings;
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

      analyzePackagesSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      analyzePackagesOperationSettings = OperationCallSettings.newBuilder();
      listVulnerabilitiesSettings =
          PagedCallSettings.newBuilder(LIST_VULNERABILITIES_PAGE_STR_FACT);

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              analyzePackagesSettings, listVulnerabilitiesSettings);
      initDefaults(this);
    }

    protected Builder(ScannerServiceStubSettings settings) {
      super(settings);

      analyzePackagesSettings = settings.analyzePackagesSettings.toBuilder();
      analyzePackagesOperationSettings = settings.analyzePackagesOperationSettings.toBuilder();
      listVulnerabilitiesSettings = settings.listVulnerabilitiesSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              analyzePackagesSettings, listVulnerabilitiesSettings);
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
          .analyzePackagesSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_params"));

      builder
          .listVulnerabilitiesSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_params"));

      builder
          .analyzePackagesOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<AnalyzePackagesRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(AnalyzePackagesResponse.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(AnalyzePackagesMetadata.class))
          .setPollingAlgorithm(
              OperationTimedPollAlgorithm.create(
                  RetrySettings.newBuilder()
                      .setInitialRetryDelay(Duration.ofMillis(5000L))
                      .setRetryDelayMultiplier(1.5)
                      .setMaxRetryDelay(Duration.ofMillis(45000L))
                      .setInitialRpcTimeout(Duration.ZERO)
                      .setRpcTimeoutMultiplier(1.0)
                      .setMaxRpcTimeout(Duration.ZERO)
                      .setTotalTimeout(Duration.ofMillis(300000L))
                      .build()));

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

    /** Returns the builder for the settings used for calls to analyzePackages. */
    public UnaryCallSettings.Builder<AnalyzePackagesRequest, Operation> analyzePackagesSettings() {
      return analyzePackagesSettings;
    }

    /** Returns the builder for the settings used for calls to analyzePackages. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<
            AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
        analyzePackagesOperationSettings() {
      return analyzePackagesOperationSettings;
    }

    /** Returns the builder for the settings used for calls to listVulnerabilities. */
    public PagedCallSettings.Builder<
            ListVulnerabilitiesRequest, ListVulnerabilitiesResponse,
            ListVulnerabilitiesPagedResponse>
        listVulnerabilitiesSettings() {
      return listVulnerabilitiesSettings;
    }

    @Override
    public ScannerServiceStubSettings build() throws IOException {
      return new ScannerServiceStubSettings(this);
    }
  }
}
