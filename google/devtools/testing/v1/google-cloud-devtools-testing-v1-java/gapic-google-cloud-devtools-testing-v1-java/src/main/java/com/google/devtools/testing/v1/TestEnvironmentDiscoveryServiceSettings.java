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

package com.google.devtools.testing.v1;

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
import com.google.devtools.testing.v1.stub.TestEnvironmentDiscoveryServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link TestEnvironmentDiscoveryServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (testing.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getTestEnvironmentCatalog to 30 seconds:
 *
 * <pre>{@code
 * TestEnvironmentDiscoveryServiceSettings.Builder testEnvironmentDiscoveryServiceSettingsBuilder =
 *     TestEnvironmentDiscoveryServiceSettings.newBuilder();
 * testEnvironmentDiscoveryServiceSettingsBuilder
 *     .getTestEnvironmentCatalogSettings()
 *     .setRetrySettings(
 *         testEnvironmentDiscoveryServiceSettingsBuilder
 *             .getTestEnvironmentCatalogSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * TestEnvironmentDiscoveryServiceSettings testEnvironmentDiscoveryServiceSettings =
 *     testEnvironmentDiscoveryServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class TestEnvironmentDiscoveryServiceSettings
    extends ClientSettings<TestEnvironmentDiscoveryServiceSettings> {

  /** Returns the object with the settings used for calls to getTestEnvironmentCatalog. */
  public UnaryCallSettings<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
      getTestEnvironmentCatalogSettings() {
    return ((TestEnvironmentDiscoveryServiceStubSettings) getStubSettings())
        .getTestEnvironmentCatalogSettings();
  }

  public static final TestEnvironmentDiscoveryServiceSettings create(
      TestEnvironmentDiscoveryServiceStubSettings stub) throws IOException {
    return new TestEnvironmentDiscoveryServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return TestEnvironmentDiscoveryServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return TestEnvironmentDiscoveryServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return TestEnvironmentDiscoveryServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return TestEnvironmentDiscoveryServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return TestEnvironmentDiscoveryServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return TestEnvironmentDiscoveryServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return TestEnvironmentDiscoveryServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected TestEnvironmentDiscoveryServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for TestEnvironmentDiscoveryServiceSettings. */
  public static class Builder
      extends ClientSettings.Builder<TestEnvironmentDiscoveryServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(TestEnvironmentDiscoveryServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(TestEnvironmentDiscoveryServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(TestEnvironmentDiscoveryServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(TestEnvironmentDiscoveryServiceStubSettings.newBuilder());
    }

    public TestEnvironmentDiscoveryServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((TestEnvironmentDiscoveryServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to getTestEnvironmentCatalog. */
    public UnaryCallSettings.Builder<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
        getTestEnvironmentCatalogSettings() {
      return getStubSettingsBuilder().getTestEnvironmentCatalogSettings();
    }

    @Override
    public TestEnvironmentDiscoveryServiceSettings build() throws IOException {
      return new TestEnvironmentDiscoveryServiceSettings(this);
    }
  }
}
