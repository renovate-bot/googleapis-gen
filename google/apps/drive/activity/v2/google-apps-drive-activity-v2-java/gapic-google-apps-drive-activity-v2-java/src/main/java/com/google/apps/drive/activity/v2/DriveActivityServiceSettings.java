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

package com.google.apps.drive.activity.v2;

import static com.google.apps.drive.activity.v2.DriveActivityServiceClient.QueryDriveActivityPagedResponse;

import com.google.api.core.ApiFunction;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.GoogleCredentialsProvider;
import com.google.api.gax.core.InstantiatingExecutorProvider;
import com.google.api.gax.grpc.InstantiatingGrpcChannelProvider;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ClientSettings;
import com.google.api.gax.rpc.PagedCallSettings;
import com.google.api.gax.rpc.StubSettings;
import com.google.api.gax.rpc.TransportChannelProvider;
import com.google.api.gax.rpc.UnaryCallSettings;
import com.google.apps.drive.activity.v2.stub.DriveActivityServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link DriveActivityServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (driveactivity.googleapis.com) and default port (443) are used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of queryDriveActivity to 30 seconds:
 *
 * <pre>{@code
 * DriveActivityServiceSettings.Builder driveActivityServiceSettingsBuilder =
 *     DriveActivityServiceSettings.newBuilder();
 * driveActivityServiceSettingsBuilder
 *     .queryDriveActivitySettings()
 *     .setRetrySettings(
 *         driveActivityServiceSettingsBuilder
 *             .queryDriveActivitySettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * DriveActivityServiceSettings driveActivityServiceSettings =
 *     driveActivityServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class DriveActivityServiceSettings extends ClientSettings<DriveActivityServiceSettings> {

  /** Returns the object with the settings used for calls to queryDriveActivity. */
  public PagedCallSettings<
          QueryDriveActivityRequest, QueryDriveActivityResponse, QueryDriveActivityPagedResponse>
      queryDriveActivitySettings() {
    return ((DriveActivityServiceStubSettings) getStubSettings()).queryDriveActivitySettings();
  }

  public static final DriveActivityServiceSettings create(DriveActivityServiceStubSettings stub)
      throws IOException {
    return new DriveActivityServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return DriveActivityServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return DriveActivityServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return DriveActivityServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return DriveActivityServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return DriveActivityServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return DriveActivityServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return DriveActivityServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected DriveActivityServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for DriveActivityServiceSettings. */
  public static class Builder
      extends ClientSettings.Builder<DriveActivityServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(DriveActivityServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(DriveActivityServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(DriveActivityServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(DriveActivityServiceStubSettings.newBuilder());
    }

    public DriveActivityServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((DriveActivityServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to queryDriveActivity. */
    public PagedCallSettings.Builder<
            QueryDriveActivityRequest, QueryDriveActivityResponse, QueryDriveActivityPagedResponse>
        queryDriveActivitySettings() {
      return getStubSettingsBuilder().queryDriveActivitySettings();
    }

    @Override
    public DriveActivityServiceSettings build() throws IOException {
      return new DriveActivityServiceSettings(this);
    }
  }
}
