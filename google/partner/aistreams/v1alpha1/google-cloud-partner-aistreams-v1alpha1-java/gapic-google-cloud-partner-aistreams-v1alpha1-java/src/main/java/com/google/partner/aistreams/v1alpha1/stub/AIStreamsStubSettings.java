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

package com.google.partner.aistreams.v1alpha1.stub;

import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListClustersPagedResponse;
import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListStreamsPagedResponse;

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
import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import com.google.common.collect.ImmutableSet;
import com.google.common.collect.Lists;
import com.google.longrunning.Operation;
import com.google.partner.aistreams.v1alpha1.Cluster;
import com.google.partner.aistreams.v1alpha1.CreateClusterRequest;
import com.google.partner.aistreams.v1alpha1.CreateStreamRequest;
import com.google.partner.aistreams.v1alpha1.DeleteClusterRequest;
import com.google.partner.aistreams.v1alpha1.DeleteStreamRequest;
import com.google.partner.aistreams.v1alpha1.GetClusterRequest;
import com.google.partner.aistreams.v1alpha1.GetStreamRequest;
import com.google.partner.aistreams.v1alpha1.ListClustersRequest;
import com.google.partner.aistreams.v1alpha1.ListClustersResponse;
import com.google.partner.aistreams.v1alpha1.ListStreamsRequest;
import com.google.partner.aistreams.v1alpha1.ListStreamsResponse;
import com.google.partner.aistreams.v1alpha1.OperationMetadata;
import com.google.partner.aistreams.v1alpha1.Stream;
import com.google.partner.aistreams.v1alpha1.UpdateClusterRequest;
import com.google.partner.aistreams.v1alpha1.UpdateStreamRequest;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;
import org.threeten.bp.Duration;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link AIStreamsStub}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (aistreams.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getCluster to 30 seconds:
 *
 * <pre>{@code
 * AIStreamsStubSettings.Builder aIStreamsSettingsBuilder = AIStreamsStubSettings.newBuilder();
 * aIStreamsSettingsBuilder
 *     .getClusterSettings()
 *     .setRetrySettings(
 *         aIStreamsSettingsBuilder
 *             .getClusterSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * AIStreamsStubSettings aIStreamsSettings = aIStreamsSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class AIStreamsStubSettings extends StubSettings<AIStreamsStubSettings> {
  /** The default scopes of the service. */
  private static final ImmutableList<String> DEFAULT_SERVICE_SCOPES =
      ImmutableList.<String>builder().add("https://www.googleapis.com/auth/cloud-platform").build();

  private final PagedCallSettings<
          ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
      listClustersSettings;
  private final UnaryCallSettings<GetClusterRequest, Cluster> getClusterSettings;
  private final UnaryCallSettings<CreateClusterRequest, Operation> createClusterSettings;
  private final OperationCallSettings<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationSettings;
  private final UnaryCallSettings<UpdateClusterRequest, Operation> updateClusterSettings;
  private final OperationCallSettings<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationSettings;
  private final UnaryCallSettings<DeleteClusterRequest, Operation> deleteClusterSettings;
  private final OperationCallSettings<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationSettings;
  private final PagedCallSettings<ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
      listStreamsSettings;
  private final UnaryCallSettings<GetStreamRequest, Stream> getStreamSettings;
  private final UnaryCallSettings<CreateStreamRequest, Operation> createStreamSettings;
  private final OperationCallSettings<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationSettings;
  private final UnaryCallSettings<UpdateStreamRequest, Operation> updateStreamSettings;
  private final OperationCallSettings<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationSettings;
  private final UnaryCallSettings<DeleteStreamRequest, Operation> deleteStreamSettings;
  private final OperationCallSettings<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationSettings;

  private static final PagedListDescriptor<ListClustersRequest, ListClustersResponse, Cluster>
      LIST_CLUSTERS_PAGE_STR_DESC =
          new PagedListDescriptor<ListClustersRequest, ListClustersResponse, Cluster>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public ListClustersRequest injectToken(ListClustersRequest payload, String token) {
              return ListClustersRequest.newBuilder(payload).setPageToken(token).build();
            }

            @Override
            public ListClustersRequest injectPageSize(ListClustersRequest payload, int pageSize) {
              return ListClustersRequest.newBuilder(payload).setPageSize(pageSize).build();
            }

            @Override
            public Integer extractPageSize(ListClustersRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(ListClustersResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<Cluster> extractResources(ListClustersResponse payload) {
              return payload.getClustersList() == null
                  ? ImmutableList.<Cluster>of()
                  : payload.getClustersList();
            }
          };

  private static final PagedListDescriptor<ListStreamsRequest, ListStreamsResponse, Stream>
      LIST_STREAMS_PAGE_STR_DESC =
          new PagedListDescriptor<ListStreamsRequest, ListStreamsResponse, Stream>() {
            @Override
            public String emptyToken() {
              return "";
            }

            @Override
            public ListStreamsRequest injectToken(ListStreamsRequest payload, String token) {
              return ListStreamsRequest.newBuilder(payload).setPageToken(token).build();
            }

            @Override
            public ListStreamsRequest injectPageSize(ListStreamsRequest payload, int pageSize) {
              return ListStreamsRequest.newBuilder(payload).setPageSize(pageSize).build();
            }

            @Override
            public Integer extractPageSize(ListStreamsRequest payload) {
              return payload.getPageSize();
            }

            @Override
            public String extractNextToken(ListStreamsResponse payload) {
              return payload.getNextPageToken();
            }

            @Override
            public Iterable<Stream> extractResources(ListStreamsResponse payload) {
              return payload.getStreamsList() == null
                  ? ImmutableList.<Stream>of()
                  : payload.getStreamsList();
            }
          };

  private static final PagedListResponseFactory<
          ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
      LIST_CLUSTERS_PAGE_STR_FACT =
          new PagedListResponseFactory<
              ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>() {
            @Override
            public ApiFuture<ListClustersPagedResponse> getFuturePagedResponse(
                UnaryCallable<ListClustersRequest, ListClustersResponse> callable,
                ListClustersRequest request,
                ApiCallContext context,
                ApiFuture<ListClustersResponse> futureResponse) {
              PageContext<ListClustersRequest, ListClustersResponse, Cluster> pageContext =
                  PageContext.create(callable, LIST_CLUSTERS_PAGE_STR_DESC, request, context);
              return ListClustersPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  private static final PagedListResponseFactory<
          ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
      LIST_STREAMS_PAGE_STR_FACT =
          new PagedListResponseFactory<
              ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>() {
            @Override
            public ApiFuture<ListStreamsPagedResponse> getFuturePagedResponse(
                UnaryCallable<ListStreamsRequest, ListStreamsResponse> callable,
                ListStreamsRequest request,
                ApiCallContext context,
                ApiFuture<ListStreamsResponse> futureResponse) {
              PageContext<ListStreamsRequest, ListStreamsResponse, Stream> pageContext =
                  PageContext.create(callable, LIST_STREAMS_PAGE_STR_DESC, request, context);
              return ListStreamsPagedResponse.createAsync(pageContext, futureResponse);
            }
          };

  /** Returns the object with the settings used for calls to listClusters. */
  public PagedCallSettings<ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
      listClustersSettings() {
    return listClustersSettings;
  }

  /** Returns the object with the settings used for calls to getCluster. */
  public UnaryCallSettings<GetClusterRequest, Cluster> getClusterSettings() {
    return getClusterSettings;
  }

  /** Returns the object with the settings used for calls to createCluster. */
  public UnaryCallSettings<CreateClusterRequest, Operation> createClusterSettings() {
    return createClusterSettings;
  }

  /** Returns the object with the settings used for calls to createCluster. */
  public OperationCallSettings<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationSettings() {
    return createClusterOperationSettings;
  }

  /** Returns the object with the settings used for calls to updateCluster. */
  public UnaryCallSettings<UpdateClusterRequest, Operation> updateClusterSettings() {
    return updateClusterSettings;
  }

  /** Returns the object with the settings used for calls to updateCluster. */
  public OperationCallSettings<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationSettings() {
    return updateClusterOperationSettings;
  }

  /** Returns the object with the settings used for calls to deleteCluster. */
  public UnaryCallSettings<DeleteClusterRequest, Operation> deleteClusterSettings() {
    return deleteClusterSettings;
  }

  /** Returns the object with the settings used for calls to deleteCluster. */
  public OperationCallSettings<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationSettings() {
    return deleteClusterOperationSettings;
  }

  /** Returns the object with the settings used for calls to listStreams. */
  public PagedCallSettings<ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
      listStreamsSettings() {
    return listStreamsSettings;
  }

  /** Returns the object with the settings used for calls to getStream. */
  public UnaryCallSettings<GetStreamRequest, Stream> getStreamSettings() {
    return getStreamSettings;
  }

  /** Returns the object with the settings used for calls to createStream. */
  public UnaryCallSettings<CreateStreamRequest, Operation> createStreamSettings() {
    return createStreamSettings;
  }

  /** Returns the object with the settings used for calls to createStream. */
  public OperationCallSettings<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationSettings() {
    return createStreamOperationSettings;
  }

  /** Returns the object with the settings used for calls to updateStream. */
  public UnaryCallSettings<UpdateStreamRequest, Operation> updateStreamSettings() {
    return updateStreamSettings;
  }

  /** Returns the object with the settings used for calls to updateStream. */
  public OperationCallSettings<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationSettings() {
    return updateStreamOperationSettings;
  }

  /** Returns the object with the settings used for calls to deleteStream. */
  public UnaryCallSettings<DeleteStreamRequest, Operation> deleteStreamSettings() {
    return deleteStreamSettings;
  }

  /** Returns the object with the settings used for calls to deleteStream. */
  public OperationCallSettings<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationSettings() {
    return deleteStreamOperationSettings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AIStreamsStub createStub() throws IOException {
    if (getTransportChannelProvider()
        .getTransportName()
        .equals(GrpcTransportChannel.getGrpcTransportName())) {
      return GrpcAIStreamsStub.create(this);
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
    return "aistreams.googleapis.com:443";
  }

  /** Returns the default mTLS service endpoint. */
  public static String getDefaultMtlsEndpoint() {
    return "aistreams.mtls.googleapis.com:443";
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
        .setGeneratedLibToken("gapic", GaxProperties.getLibraryVersion(AIStreamsStubSettings.class))
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

  protected AIStreamsStubSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);

    listClustersSettings = settingsBuilder.listClustersSettings().build();
    getClusterSettings = settingsBuilder.getClusterSettings().build();
    createClusterSettings = settingsBuilder.createClusterSettings().build();
    createClusterOperationSettings = settingsBuilder.createClusterOperationSettings().build();
    updateClusterSettings = settingsBuilder.updateClusterSettings().build();
    updateClusterOperationSettings = settingsBuilder.updateClusterOperationSettings().build();
    deleteClusterSettings = settingsBuilder.deleteClusterSettings().build();
    deleteClusterOperationSettings = settingsBuilder.deleteClusterOperationSettings().build();
    listStreamsSettings = settingsBuilder.listStreamsSettings().build();
    getStreamSettings = settingsBuilder.getStreamSettings().build();
    createStreamSettings = settingsBuilder.createStreamSettings().build();
    createStreamOperationSettings = settingsBuilder.createStreamOperationSettings().build();
    updateStreamSettings = settingsBuilder.updateStreamSettings().build();
    updateStreamOperationSettings = settingsBuilder.updateStreamOperationSettings().build();
    deleteStreamSettings = settingsBuilder.deleteStreamSettings().build();
    deleteStreamOperationSettings = settingsBuilder.deleteStreamOperationSettings().build();
  }

  /** Builder for AIStreamsStubSettings. */
  public static class Builder extends StubSettings.Builder<AIStreamsStubSettings, Builder> {
    private final ImmutableList<UnaryCallSettings.Builder<?, ?>> unaryMethodSettingsBuilders;
    private final PagedCallSettings.Builder<
            ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
        listClustersSettings;
    private final UnaryCallSettings.Builder<GetClusterRequest, Cluster> getClusterSettings;
    private final UnaryCallSettings.Builder<CreateClusterRequest, Operation> createClusterSettings;
    private final OperationCallSettings.Builder<CreateClusterRequest, Cluster, OperationMetadata>
        createClusterOperationSettings;
    private final UnaryCallSettings.Builder<UpdateClusterRequest, Operation> updateClusterSettings;
    private final OperationCallSettings.Builder<UpdateClusterRequest, Cluster, OperationMetadata>
        updateClusterOperationSettings;
    private final UnaryCallSettings.Builder<DeleteClusterRequest, Operation> deleteClusterSettings;
    private final OperationCallSettings.Builder<DeleteClusterRequest, Empty, OperationMetadata>
        deleteClusterOperationSettings;
    private final PagedCallSettings.Builder<
            ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
        listStreamsSettings;
    private final UnaryCallSettings.Builder<GetStreamRequest, Stream> getStreamSettings;
    private final UnaryCallSettings.Builder<CreateStreamRequest, Operation> createStreamSettings;
    private final OperationCallSettings.Builder<CreateStreamRequest, Stream, OperationMetadata>
        createStreamOperationSettings;
    private final UnaryCallSettings.Builder<UpdateStreamRequest, Operation> updateStreamSettings;
    private final OperationCallSettings.Builder<UpdateStreamRequest, Stream, OperationMetadata>
        updateStreamOperationSettings;
    private final UnaryCallSettings.Builder<DeleteStreamRequest, Operation> deleteStreamSettings;
    private final OperationCallSettings.Builder<DeleteStreamRequest, Empty, OperationMetadata>
        deleteStreamOperationSettings;
    private static final ImmutableMap<String, ImmutableSet<StatusCode.Code>>
        RETRYABLE_CODE_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, ImmutableSet<StatusCode.Code>> definitions =
          ImmutableMap.builder();
      definitions.put(
          "no_retry_3_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      definitions.put(
          "no_retry_1_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      definitions.put(
          "no_retry_2_codes", ImmutableSet.copyOf(Lists.<StatusCode.Code>newArrayList()));
      RETRYABLE_CODE_DEFINITIONS = definitions.build();
    }

    private static final ImmutableMap<String, RetrySettings> RETRY_PARAM_DEFINITIONS;

    static {
      ImmutableMap.Builder<String, RetrySettings> definitions = ImmutableMap.builder();
      RetrySettings settings = null;
      settings =
          RetrySettings.newBuilder()
              .setInitialRpcTimeout(Duration.ofMillis(60000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(60000L))
              .setTotalTimeout(Duration.ofMillis(60000L))
              .build();
      definitions.put("no_retry_3_params", settings);
      settings =
          RetrySettings.newBuilder()
              .setInitialRpcTimeout(Duration.ofMillis(600000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(600000L))
              .setTotalTimeout(Duration.ofMillis(600000L))
              .build();
      definitions.put("no_retry_1_params", settings);
      settings =
          RetrySettings.newBuilder()
              .setInitialRpcTimeout(Duration.ofMillis(300000L))
              .setRpcTimeoutMultiplier(1.0)
              .setMaxRpcTimeout(Duration.ofMillis(300000L))
              .setTotalTimeout(Duration.ofMillis(300000L))
              .build();
      definitions.put("no_retry_2_params", settings);
      RETRY_PARAM_DEFINITIONS = definitions.build();
    }

    protected Builder() {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(clientContext);

      listClustersSettings = PagedCallSettings.newBuilder(LIST_CLUSTERS_PAGE_STR_FACT);
      getClusterSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      createClusterSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      createClusterOperationSettings = OperationCallSettings.newBuilder();
      updateClusterSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      updateClusterOperationSettings = OperationCallSettings.newBuilder();
      deleteClusterSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      deleteClusterOperationSettings = OperationCallSettings.newBuilder();
      listStreamsSettings = PagedCallSettings.newBuilder(LIST_STREAMS_PAGE_STR_FACT);
      getStreamSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      createStreamSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      createStreamOperationSettings = OperationCallSettings.newBuilder();
      updateStreamSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      updateStreamOperationSettings = OperationCallSettings.newBuilder();
      deleteStreamSettings = UnaryCallSettings.newUnaryCallSettingsBuilder();
      deleteStreamOperationSettings = OperationCallSettings.newBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              listClustersSettings,
              getClusterSettings,
              createClusterSettings,
              updateClusterSettings,
              deleteClusterSettings,
              listStreamsSettings,
              getStreamSettings,
              createStreamSettings,
              updateStreamSettings,
              deleteStreamSettings);
      initDefaults(this);
    }

    protected Builder(AIStreamsStubSettings settings) {
      super(settings);

      listClustersSettings = settings.listClustersSettings.toBuilder();
      getClusterSettings = settings.getClusterSettings.toBuilder();
      createClusterSettings = settings.createClusterSettings.toBuilder();
      createClusterOperationSettings = settings.createClusterOperationSettings.toBuilder();
      updateClusterSettings = settings.updateClusterSettings.toBuilder();
      updateClusterOperationSettings = settings.updateClusterOperationSettings.toBuilder();
      deleteClusterSettings = settings.deleteClusterSettings.toBuilder();
      deleteClusterOperationSettings = settings.deleteClusterOperationSettings.toBuilder();
      listStreamsSettings = settings.listStreamsSettings.toBuilder();
      getStreamSettings = settings.getStreamSettings.toBuilder();
      createStreamSettings = settings.createStreamSettings.toBuilder();
      createStreamOperationSettings = settings.createStreamOperationSettings.toBuilder();
      updateStreamSettings = settings.updateStreamSettings.toBuilder();
      updateStreamOperationSettings = settings.updateStreamOperationSettings.toBuilder();
      deleteStreamSettings = settings.deleteStreamSettings.toBuilder();
      deleteStreamOperationSettings = settings.deleteStreamOperationSettings.toBuilder();

      unaryMethodSettingsBuilders =
          ImmutableList.<UnaryCallSettings.Builder<?, ?>>of(
              listClustersSettings,
              getClusterSettings,
              createClusterSettings,
              updateClusterSettings,
              deleteClusterSettings,
              listStreamsSettings,
              getStreamSettings,
              createStreamSettings,
              updateStreamSettings,
              deleteStreamSettings);
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
          .listClustersSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .getClusterSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .createClusterSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_1_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_1_params"));

      builder
          .updateClusterSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .deleteClusterSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .listStreamsSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .getStreamSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .createStreamSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_2_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_2_params"));

      builder
          .updateStreamSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .deleteStreamSettings()
          .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
          .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"));

      builder
          .createClusterOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<CreateClusterRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_1_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_1_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(Cluster.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(OperationMetadata.class))
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

      builder
          .updateClusterOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<UpdateClusterRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(Cluster.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(OperationMetadata.class))
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

      builder
          .deleteClusterOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<DeleteClusterRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(Empty.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(OperationMetadata.class))
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

      builder
          .createStreamOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<CreateStreamRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_2_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_2_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(Stream.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(OperationMetadata.class))
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

      builder
          .updateStreamOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<UpdateStreamRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(Stream.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(OperationMetadata.class))
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

      builder
          .deleteStreamOperationSettings()
          .setInitialCallSettings(
              UnaryCallSettings
                  .<DeleteStreamRequest, OperationSnapshot>newUnaryCallSettingsBuilder()
                  .setRetryableCodes(RETRYABLE_CODE_DEFINITIONS.get("no_retry_3_codes"))
                  .setRetrySettings(RETRY_PARAM_DEFINITIONS.get("no_retry_3_params"))
                  .build())
          .setResponseTransformer(
              ProtoOperationTransformers.ResponseTransformer.create(Empty.class))
          .setMetadataTransformer(
              ProtoOperationTransformers.MetadataTransformer.create(OperationMetadata.class))
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

    /** Returns the builder for the settings used for calls to listClusters. */
    public PagedCallSettings.Builder<
            ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
        listClustersSettings() {
      return listClustersSettings;
    }

    /** Returns the builder for the settings used for calls to getCluster. */
    public UnaryCallSettings.Builder<GetClusterRequest, Cluster> getClusterSettings() {
      return getClusterSettings;
    }

    /** Returns the builder for the settings used for calls to createCluster. */
    public UnaryCallSettings.Builder<CreateClusterRequest, Operation> createClusterSettings() {
      return createClusterSettings;
    }

    /** Returns the builder for the settings used for calls to createCluster. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<CreateClusterRequest, Cluster, OperationMetadata>
        createClusterOperationSettings() {
      return createClusterOperationSettings;
    }

    /** Returns the builder for the settings used for calls to updateCluster. */
    public UnaryCallSettings.Builder<UpdateClusterRequest, Operation> updateClusterSettings() {
      return updateClusterSettings;
    }

    /** Returns the builder for the settings used for calls to updateCluster. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<UpdateClusterRequest, Cluster, OperationMetadata>
        updateClusterOperationSettings() {
      return updateClusterOperationSettings;
    }

    /** Returns the builder for the settings used for calls to deleteCluster. */
    public UnaryCallSettings.Builder<DeleteClusterRequest, Operation> deleteClusterSettings() {
      return deleteClusterSettings;
    }

    /** Returns the builder for the settings used for calls to deleteCluster. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<DeleteClusterRequest, Empty, OperationMetadata>
        deleteClusterOperationSettings() {
      return deleteClusterOperationSettings;
    }

    /** Returns the builder for the settings used for calls to listStreams. */
    public PagedCallSettings.Builder<
            ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
        listStreamsSettings() {
      return listStreamsSettings;
    }

    /** Returns the builder for the settings used for calls to getStream. */
    public UnaryCallSettings.Builder<GetStreamRequest, Stream> getStreamSettings() {
      return getStreamSettings;
    }

    /** Returns the builder for the settings used for calls to createStream. */
    public UnaryCallSettings.Builder<CreateStreamRequest, Operation> createStreamSettings() {
      return createStreamSettings;
    }

    /** Returns the builder for the settings used for calls to createStream. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<CreateStreamRequest, Stream, OperationMetadata>
        createStreamOperationSettings() {
      return createStreamOperationSettings;
    }

    /** Returns the builder for the settings used for calls to updateStream. */
    public UnaryCallSettings.Builder<UpdateStreamRequest, Operation> updateStreamSettings() {
      return updateStreamSettings;
    }

    /** Returns the builder for the settings used for calls to updateStream. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<UpdateStreamRequest, Stream, OperationMetadata>
        updateStreamOperationSettings() {
      return updateStreamOperationSettings;
    }

    /** Returns the builder for the settings used for calls to deleteStream. */
    public UnaryCallSettings.Builder<DeleteStreamRequest, Operation> deleteStreamSettings() {
      return deleteStreamSettings;
    }

    /** Returns the builder for the settings used for calls to deleteStream. */
    @BetaApi(
        "The surface for use by generated code is not stable yet and may change in the future.")
    public OperationCallSettings.Builder<DeleteStreamRequest, Empty, OperationMetadata>
        deleteStreamOperationSettings() {
      return deleteStreamOperationSettings;
    }

    @Override
    public AIStreamsStubSettings build() throws IOException {
      return new AIStreamsStubSettings(this);
    }
  }
}
