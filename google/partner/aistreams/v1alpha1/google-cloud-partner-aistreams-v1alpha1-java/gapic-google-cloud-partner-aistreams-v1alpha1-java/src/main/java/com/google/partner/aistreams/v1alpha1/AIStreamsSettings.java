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

package com.google.partner.aistreams.v1alpha1;

import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListClustersPagedResponse;
import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListStreamsPagedResponse;

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
import com.google.longrunning.Operation;
import com.google.partner.aistreams.v1alpha1.stub.AIStreamsStubSettings;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link AIStreamsClient}.
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
 * AIStreamsSettings.Builder aIStreamsSettingsBuilder = AIStreamsSettings.newBuilder();
 * aIStreamsSettingsBuilder
 *     .getClusterSettings()
 *     .setRetrySettings(
 *         aIStreamsSettingsBuilder
 *             .getClusterSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * AIStreamsSettings aIStreamsSettings = aIStreamsSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class AIStreamsSettings extends ClientSettings<AIStreamsSettings> {

  /** Returns the object with the settings used for calls to listClusters. */
  public PagedCallSettings<ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
      listClustersSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).listClustersSettings();
  }

  /** Returns the object with the settings used for calls to getCluster. */
  public UnaryCallSettings<GetClusterRequest, Cluster> getClusterSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).getClusterSettings();
  }

  /** Returns the object with the settings used for calls to createCluster. */
  public UnaryCallSettings<CreateClusterRequest, Operation> createClusterSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).createClusterSettings();
  }

  /** Returns the object with the settings used for calls to createCluster. */
  public OperationCallSettings<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).createClusterOperationSettings();
  }

  /** Returns the object with the settings used for calls to updateCluster. */
  public UnaryCallSettings<UpdateClusterRequest, Operation> updateClusterSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).updateClusterSettings();
  }

  /** Returns the object with the settings used for calls to updateCluster. */
  public OperationCallSettings<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).updateClusterOperationSettings();
  }

  /** Returns the object with the settings used for calls to deleteCluster. */
  public UnaryCallSettings<DeleteClusterRequest, Operation> deleteClusterSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).deleteClusterSettings();
  }

  /** Returns the object with the settings used for calls to deleteCluster. */
  public OperationCallSettings<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).deleteClusterOperationSettings();
  }

  /** Returns the object with the settings used for calls to listStreams. */
  public PagedCallSettings<ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
      listStreamsSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).listStreamsSettings();
  }

  /** Returns the object with the settings used for calls to getStream. */
  public UnaryCallSettings<GetStreamRequest, Stream> getStreamSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).getStreamSettings();
  }

  /** Returns the object with the settings used for calls to createStream. */
  public UnaryCallSettings<CreateStreamRequest, Operation> createStreamSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).createStreamSettings();
  }

  /** Returns the object with the settings used for calls to createStream. */
  public OperationCallSettings<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).createStreamOperationSettings();
  }

  /** Returns the object with the settings used for calls to updateStream. */
  public UnaryCallSettings<UpdateStreamRequest, Operation> updateStreamSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).updateStreamSettings();
  }

  /** Returns the object with the settings used for calls to updateStream. */
  public OperationCallSettings<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).updateStreamOperationSettings();
  }

  /** Returns the object with the settings used for calls to deleteStream. */
  public UnaryCallSettings<DeleteStreamRequest, Operation> deleteStreamSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).deleteStreamSettings();
  }

  /** Returns the object with the settings used for calls to deleteStream. */
  public OperationCallSettings<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationSettings() {
    return ((AIStreamsStubSettings) getStubSettings()).deleteStreamOperationSettings();
  }

  public static final AIStreamsSettings create(AIStreamsStubSettings stub) throws IOException {
    return new AIStreamsSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return AIStreamsStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return AIStreamsStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return AIStreamsStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return AIStreamsStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return AIStreamsStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return AIStreamsStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return AIStreamsStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected AIStreamsSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for AIStreamsSettings. */
  public static class Builder extends ClientSettings.Builder<AIStreamsSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(AIStreamsStubSettings.newBuilder(clientContext));
    }

    protected Builder(AIStreamsSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(AIStreamsStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(AIStreamsStubSettings.newBuilder());
    }

    public AIStreamsStubSettings.Builder getStubSettingsBuilder() {
      return ((AIStreamsStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to listClusters. */
    public PagedCallSettings.Builder<
            ListClustersRequest, ListClustersResponse, ListClustersPagedResponse>
        listClustersSettings() {
      return getStubSettingsBuilder().listClustersSettings();
    }

    /** Returns the builder for the settings used for calls to getCluster. */
    public UnaryCallSettings.Builder<GetClusterRequest, Cluster> getClusterSettings() {
      return getStubSettingsBuilder().getClusterSettings();
    }

    /** Returns the builder for the settings used for calls to createCluster. */
    public UnaryCallSettings.Builder<CreateClusterRequest, Operation> createClusterSettings() {
      return getStubSettingsBuilder().createClusterSettings();
    }

    /** Returns the builder for the settings used for calls to createCluster. */
    public OperationCallSettings.Builder<CreateClusterRequest, Cluster, OperationMetadata>
        createClusterOperationSettings() {
      return getStubSettingsBuilder().createClusterOperationSettings();
    }

    /** Returns the builder for the settings used for calls to updateCluster. */
    public UnaryCallSettings.Builder<UpdateClusterRequest, Operation> updateClusterSettings() {
      return getStubSettingsBuilder().updateClusterSettings();
    }

    /** Returns the builder for the settings used for calls to updateCluster. */
    public OperationCallSettings.Builder<UpdateClusterRequest, Cluster, OperationMetadata>
        updateClusterOperationSettings() {
      return getStubSettingsBuilder().updateClusterOperationSettings();
    }

    /** Returns the builder for the settings used for calls to deleteCluster. */
    public UnaryCallSettings.Builder<DeleteClusterRequest, Operation> deleteClusterSettings() {
      return getStubSettingsBuilder().deleteClusterSettings();
    }

    /** Returns the builder for the settings used for calls to deleteCluster. */
    public OperationCallSettings.Builder<DeleteClusterRequest, Empty, OperationMetadata>
        deleteClusterOperationSettings() {
      return getStubSettingsBuilder().deleteClusterOperationSettings();
    }

    /** Returns the builder for the settings used for calls to listStreams. */
    public PagedCallSettings.Builder<
            ListStreamsRequest, ListStreamsResponse, ListStreamsPagedResponse>
        listStreamsSettings() {
      return getStubSettingsBuilder().listStreamsSettings();
    }

    /** Returns the builder for the settings used for calls to getStream. */
    public UnaryCallSettings.Builder<GetStreamRequest, Stream> getStreamSettings() {
      return getStubSettingsBuilder().getStreamSettings();
    }

    /** Returns the builder for the settings used for calls to createStream. */
    public UnaryCallSettings.Builder<CreateStreamRequest, Operation> createStreamSettings() {
      return getStubSettingsBuilder().createStreamSettings();
    }

    /** Returns the builder for the settings used for calls to createStream. */
    public OperationCallSettings.Builder<CreateStreamRequest, Stream, OperationMetadata>
        createStreamOperationSettings() {
      return getStubSettingsBuilder().createStreamOperationSettings();
    }

    /** Returns the builder for the settings used for calls to updateStream. */
    public UnaryCallSettings.Builder<UpdateStreamRequest, Operation> updateStreamSettings() {
      return getStubSettingsBuilder().updateStreamSettings();
    }

    /** Returns the builder for the settings used for calls to updateStream. */
    public OperationCallSettings.Builder<UpdateStreamRequest, Stream, OperationMetadata>
        updateStreamOperationSettings() {
      return getStubSettingsBuilder().updateStreamOperationSettings();
    }

    /** Returns the builder for the settings used for calls to deleteStream. */
    public UnaryCallSettings.Builder<DeleteStreamRequest, Operation> deleteStreamSettings() {
      return getStubSettingsBuilder().deleteStreamSettings();
    }

    /** Returns the builder for the settings used for calls to deleteStream. */
    public OperationCallSettings.Builder<DeleteStreamRequest, Empty, OperationMetadata>
        deleteStreamOperationSettings() {
      return getStubSettingsBuilder().deleteStreamOperationSettings();
    }

    @Override
    public AIStreamsSettings build() throws IOException {
      return new AIStreamsSettings(this);
    }
  }
}
