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

package com.google.cloud.iap.v1;

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
import com.google.cloud.iap.v1.stub.IdentityAwareProxyAdminServiceStubSettings;
import com.google.iam.v1.GetIamPolicyRequest;
import com.google.iam.v1.Policy;
import com.google.iam.v1.SetIamPolicyRequest;
import com.google.iam.v1.TestIamPermissionsRequest;
import com.google.iam.v1.TestIamPermissionsResponse;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link IdentityAwareProxyAdminServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li> The default service address (iap.googleapis.com) and default port (443) are used.
 *   <li> Credentials are acquired automatically through Application Default Credentials.
 *   <li> Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of setIamPolicy to 30 seconds:
 *
 * <pre>{@code
 * IdentityAwareProxyAdminServiceSettings.Builder identityAwareProxyAdminServiceSettingsBuilder =
 *     IdentityAwareProxyAdminServiceSettings.newBuilder();
 * identityAwareProxyAdminServiceSettingsBuilder
 *     .setIamPolicySettings()
 *     .setRetrySettings(
 *         identityAwareProxyAdminServiceSettingsBuilder
 *             .setIamPolicySettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * IdentityAwareProxyAdminServiceSettings identityAwareProxyAdminServiceSettings =
 *     identityAwareProxyAdminServiceSettingsBuilder.build();
 * }</pre>
 */
@Generated("by gapic-generator-java")
public class IdentityAwareProxyAdminServiceSettings
    extends ClientSettings<IdentityAwareProxyAdminServiceSettings> {

  /** Returns the object with the settings used for calls to setIamPolicy. */
  public UnaryCallSettings<SetIamPolicyRequest, Policy> setIamPolicySettings() {
    return ((IdentityAwareProxyAdminServiceStubSettings) getStubSettings()).setIamPolicySettings();
  }

  /** Returns the object with the settings used for calls to getIamPolicy. */
  public UnaryCallSettings<GetIamPolicyRequest, Policy> getIamPolicySettings() {
    return ((IdentityAwareProxyAdminServiceStubSettings) getStubSettings()).getIamPolicySettings();
  }

  /** Returns the object with the settings used for calls to testIamPermissions. */
  public UnaryCallSettings<TestIamPermissionsRequest, TestIamPermissionsResponse>
      testIamPermissionsSettings() {
    return ((IdentityAwareProxyAdminServiceStubSettings) getStubSettings())
        .testIamPermissionsSettings();
  }

  /** Returns the object with the settings used for calls to getIapSettings. */
  public UnaryCallSettings<GetIapSettingsRequest, IapSettings> getIapSettingsSettings() {
    return ((IdentityAwareProxyAdminServiceStubSettings) getStubSettings())
        .getIapSettingsSettings();
  }

  /** Returns the object with the settings used for calls to updateIapSettings. */
  public UnaryCallSettings<UpdateIapSettingsRequest, IapSettings> updateIapSettingsSettings() {
    return ((IdentityAwareProxyAdminServiceStubSettings) getStubSettings())
        .updateIapSettingsSettings();
  }

  public static final IdentityAwareProxyAdminServiceSettings create(
      IdentityAwareProxyAdminServiceStubSettings stub) throws IOException {
    return new IdentityAwareProxyAdminServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return IdentityAwareProxyAdminServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return IdentityAwareProxyAdminServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return IdentityAwareProxyAdminServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return IdentityAwareProxyAdminServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return IdentityAwareProxyAdminServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return IdentityAwareProxyAdminServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return IdentityAwareProxyAdminServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected IdentityAwareProxyAdminServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for IdentityAwareProxyAdminServiceSettings. */
  public static class Builder
      extends ClientSettings.Builder<IdentityAwareProxyAdminServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(IdentityAwareProxyAdminServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(IdentityAwareProxyAdminServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(IdentityAwareProxyAdminServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(IdentityAwareProxyAdminServiceStubSettings.newBuilder());
    }

    public IdentityAwareProxyAdminServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((IdentityAwareProxyAdminServiceStubSettings.Builder) getStubSettings());
    }

    /**
     * Applies the given settings updater function to all of the unary API methods in this service.
     *
     * <p>Note: This method does not support applying settings to streaming methods.
     */
    public Builder applyToAllUnaryMethods(
        ApiFunction<UnaryCallSettings.Builder<?, ?>, Void> settingsUpdater) {
      super.applyToAllUnaryMethods(
          getStubSettingsBuilder().unaryMethodSettingsBuilders(), settingsUpdater);
      return this;
    }

    /** Returns the builder for the settings used for calls to setIamPolicy. */
    public UnaryCallSettings.Builder<SetIamPolicyRequest, Policy> setIamPolicySettings() {
      return getStubSettingsBuilder().setIamPolicySettings();
    }

    /** Returns the builder for the settings used for calls to getIamPolicy. */
    public UnaryCallSettings.Builder<GetIamPolicyRequest, Policy> getIamPolicySettings() {
      return getStubSettingsBuilder().getIamPolicySettings();
    }

    /** Returns the builder for the settings used for calls to testIamPermissions. */
    public UnaryCallSettings.Builder<TestIamPermissionsRequest, TestIamPermissionsResponse>
        testIamPermissionsSettings() {
      return getStubSettingsBuilder().testIamPermissionsSettings();
    }

    /** Returns the builder for the settings used for calls to getIapSettings. */
    public UnaryCallSettings.Builder<GetIapSettingsRequest, IapSettings> getIapSettingsSettings() {
      return getStubSettingsBuilder().getIapSettingsSettings();
    }

    /** Returns the builder for the settings used for calls to updateIapSettings. */
    public UnaryCallSettings.Builder<UpdateIapSettingsRequest, IapSettings>
        updateIapSettingsSettings() {
      return getStubSettingsBuilder().updateIapSettingsSettings();
    }

    @Override
    public IdentityAwareProxyAdminServiceSettings build() throws IOException {
      return new IdentityAwareProxyAdminServiceSettings(this);
    }
  }
}
