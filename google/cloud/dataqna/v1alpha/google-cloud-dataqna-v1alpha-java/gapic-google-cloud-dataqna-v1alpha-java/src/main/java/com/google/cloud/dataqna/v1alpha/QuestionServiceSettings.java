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

package com.google.cloud.dataqna.v1alpha;

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
import com.google.cloud.dataqna.v1alpha.stub.QuestionServiceStubSettings;
import java.io.IOException;
import java.util.List;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Settings class to configure an instance of {@link QuestionServiceClient}.
 *
 * <p>The default instance has everything set to sensible defaults:
 *
 * <ul>
 *   <li>The default service address (dataqna.googleapis.com) and default port (443) are used.
 *   <li>Credentials are acquired automatically through Application Default Credentials.
 *   <li>Retries are configured for idempotent methods but not for non-idempotent methods.
 * </ul>
 *
 * <p>The builder of this class is recursive, so contained classes are themselves builders. When
 * build() is called, the tree of builders is called to create the complete settings object.
 *
 * <p>For example, to set the total timeout of getQuestion to 30 seconds:
 *
 * <pre>{@code
 * QuestionServiceSettings.Builder questionServiceSettingsBuilder =
 *     QuestionServiceSettings.newBuilder();
 * questionServiceSettingsBuilder
 *     .getQuestionSettings()
 *     .setRetrySettings(
 *         questionServiceSettingsBuilder
 *             .getQuestionSettings()
 *             .getRetrySettings()
 *             .toBuilder()
 *             .setTotalTimeout(Duration.ofSeconds(30))
 *             .build());
 * QuestionServiceSettings questionServiceSettings = questionServiceSettingsBuilder.build();
 * }</pre>
 */
@BetaApi
@Generated("by gapic-generator-java")
public class QuestionServiceSettings extends ClientSettings<QuestionServiceSettings> {

  /** Returns the object with the settings used for calls to getQuestion. */
  public UnaryCallSettings<GetQuestionRequest, Question> getQuestionSettings() {
    return ((QuestionServiceStubSettings) getStubSettings()).getQuestionSettings();
  }

  /** Returns the object with the settings used for calls to createQuestion. */
  public UnaryCallSettings<CreateQuestionRequest, Question> createQuestionSettings() {
    return ((QuestionServiceStubSettings) getStubSettings()).createQuestionSettings();
  }

  /** Returns the object with the settings used for calls to executeQuestion. */
  public UnaryCallSettings<ExecuteQuestionRequest, Question> executeQuestionSettings() {
    return ((QuestionServiceStubSettings) getStubSettings()).executeQuestionSettings();
  }

  /** Returns the object with the settings used for calls to getUserFeedback. */
  public UnaryCallSettings<GetUserFeedbackRequest, UserFeedback> getUserFeedbackSettings() {
    return ((QuestionServiceStubSettings) getStubSettings()).getUserFeedbackSettings();
  }

  /** Returns the object with the settings used for calls to updateUserFeedback. */
  public UnaryCallSettings<UpdateUserFeedbackRequest, UserFeedback> updateUserFeedbackSettings() {
    return ((QuestionServiceStubSettings) getStubSettings()).updateUserFeedbackSettings();
  }

  public static final QuestionServiceSettings create(QuestionServiceStubSettings stub)
      throws IOException {
    return new QuestionServiceSettings.Builder(stub.toBuilder()).build();
  }

  /** Returns a builder for the default ExecutorProvider for this service. */
  public static InstantiatingExecutorProvider.Builder defaultExecutorProviderBuilder() {
    return QuestionServiceStubSettings.defaultExecutorProviderBuilder();
  }

  /** Returns the default service endpoint. */
  public static String getDefaultEndpoint() {
    return QuestionServiceStubSettings.getDefaultEndpoint();
  }

  /** Returns the default service scopes. */
  public static List<String> getDefaultServiceScopes() {
    return QuestionServiceStubSettings.getDefaultServiceScopes();
  }

  /** Returns a builder for the default credentials for this service. */
  public static GoogleCredentialsProvider.Builder defaultCredentialsProviderBuilder() {
    return QuestionServiceStubSettings.defaultCredentialsProviderBuilder();
  }

  /** Returns a builder for the default ChannelProvider for this service. */
  public static InstantiatingGrpcChannelProvider.Builder defaultGrpcTransportProviderBuilder() {
    return QuestionServiceStubSettings.defaultGrpcTransportProviderBuilder();
  }

  public static TransportChannelProvider defaultTransportChannelProvider() {
    return QuestionServiceStubSettings.defaultTransportChannelProvider();
  }

  @BetaApi("The surface for customizing headers is not stable yet and may change in the future.")
  public static ApiClientHeaderProvider.Builder defaultApiClientHeaderProviderBuilder() {
    return QuestionServiceStubSettings.defaultApiClientHeaderProviderBuilder();
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

  protected QuestionServiceSettings(Builder settingsBuilder) throws IOException {
    super(settingsBuilder);
  }

  /** Builder for QuestionServiceSettings. */
  public static class Builder extends ClientSettings.Builder<QuestionServiceSettings, Builder> {

    protected Builder() throws IOException {
      this(((ClientContext) null));
    }

    protected Builder(ClientContext clientContext) {
      super(QuestionServiceStubSettings.newBuilder(clientContext));
    }

    protected Builder(QuestionServiceSettings settings) {
      super(settings.getStubSettings().toBuilder());
    }

    protected Builder(QuestionServiceStubSettings.Builder stubSettings) {
      super(stubSettings);
    }

    private static Builder createDefault() {
      return new Builder(QuestionServiceStubSettings.newBuilder());
    }

    public QuestionServiceStubSettings.Builder getStubSettingsBuilder() {
      return ((QuestionServiceStubSettings.Builder) getStubSettings());
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

    /** Returns the builder for the settings used for calls to getQuestion. */
    public UnaryCallSettings.Builder<GetQuestionRequest, Question> getQuestionSettings() {
      return getStubSettingsBuilder().getQuestionSettings();
    }

    /** Returns the builder for the settings used for calls to createQuestion. */
    public UnaryCallSettings.Builder<CreateQuestionRequest, Question> createQuestionSettings() {
      return getStubSettingsBuilder().createQuestionSettings();
    }

    /** Returns the builder for the settings used for calls to executeQuestion. */
    public UnaryCallSettings.Builder<ExecuteQuestionRequest, Question> executeQuestionSettings() {
      return getStubSettingsBuilder().executeQuestionSettings();
    }

    /** Returns the builder for the settings used for calls to getUserFeedback. */
    public UnaryCallSettings.Builder<GetUserFeedbackRequest, UserFeedback>
        getUserFeedbackSettings() {
      return getStubSettingsBuilder().getUserFeedbackSettings();
    }

    /** Returns the builder for the settings used for calls to updateUserFeedback. */
    public UnaryCallSettings.Builder<UpdateUserFeedbackRequest, UserFeedback>
        updateUserFeedbackSettings() {
      return getStubSettingsBuilder().updateUserFeedbackSettings();
    }

    @Override
    public QuestionServiceSettings build() throws IOException {
      return new QuestionServiceSettings(this);
    }
  }
}
