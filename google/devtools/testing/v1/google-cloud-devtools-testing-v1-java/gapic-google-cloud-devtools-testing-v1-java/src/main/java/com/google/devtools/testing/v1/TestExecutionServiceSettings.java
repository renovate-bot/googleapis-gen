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
import com.google.devtools.testing.v1.stub.TestExecutionServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link TestExecutionServiceClient}.
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
 * <p>For example, to set the total timeout of createTestMatrix to 30 seconds:
 *
 * <pre>{@code
 * TestExecutionServiceSettings.Builder testExecutionServiceSettingsBuilder =
 *     TestExecutionServiceSettings.newBuilder();
 * testExecutionServiceSettingsBuilder
 *     .createTestMatrixSettings()
 *     .setRetrySettings(
 *         testExecutionServiceSettingsBuilder
 *             .createTestMatrixSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * TestExecutionServiceSettings testExecutionServiceSettings =
 *     testExecutionServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class TestExecutionServiceSettings extends ClientSettings<TestExecutionServiceSettings> {

  /** Returns the object with the settings used for calls to createTestMatrix. */
  public UnaryCallSettings<CreateTestMatrixRequest, TestMatrix> createTestMatrixSettings() {
    return ((TestExecutionServiceStubSettings) getStubSettings()).createTestMatrixSettings();
  }

  /** Returns the object with the settings used for calls to getTestMatrix. */
  public UnaryCallSettings<GetTestMatrixRequest, TestMatrix> getTestMatrixSettings() {
    return ((TestExecutionServiceStubSettings) getStubSettings()).getTestMatrixSettings();
  }

  /** Returns the object with the settings used for calls to cancelTestMatrix. */
  public UnaryCallSettings<CancelTestMatrixRequest, CancelTestMatrixResponse>
      cancelTestMatrixSettings() {
    return ((TestExecutionServiceStubSettings) getStubSettings()).cancelTestMatrixSettings();
  }

  public static final TestExecutionServiceSettings create(TestExecutionServiceStubSettings stub)
      throws IOException {
    return new TestExecutionServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return TestExecutionServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return TestExecutionServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return TestExecutionServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return TestExecutionServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return TestExecutionServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return TestExecutionServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return TestExecutionServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected TestExecutionServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for TestExecutionServiceSettings. */
  public static class Builder
      extends ClientSettings.Builder<TestExecutionServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(TestExecutionServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(TestExecutionServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(TestExecutionServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(TestExecutionServiceStubSettings.newBuilder());
    }

    public TestExecutionServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((TestExecutionServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to createTestMatrix. */
    public UnaryCallSettings.Builder<CreateTestMatrixRequest, TestMatrix>
        createTestMatrixSettings() {
      return getStubSettingsBuilder().createTestMatrixSettings();
    }

    /** Returns the builder for the settings used for calls to getTestMatrix. */
    public UnaryCallSettings.Builder<GetTestMatrixRequest, TestMatrix> getTestMatrixSettings() {
      return getStubSettingsBuilder().getTestMatrixSettings();
    }

    /** Returns the builder for the settings used for calls to cancelTestMatrix. */
    public UnaryCallSettings.Builder<CancelTestMatrixRequest, CancelTestMatrixResponse>
        cancelTestMatrixSettings() {
      return getStubSettingsBuilder().cancelTestMatrixSettings();
    }

    @Override
    public TestExecutionServiceSettings build() throws IOException {
      return new TestExecutionServiceSettings(this);
    }
  }
}
