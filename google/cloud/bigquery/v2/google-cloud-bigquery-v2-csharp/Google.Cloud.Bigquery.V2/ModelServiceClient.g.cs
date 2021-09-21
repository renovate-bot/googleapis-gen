// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Bigquery.V2
{
    /// <summary>Settings for <see cref="ModelServiceClient"/> instances.</summary>
    public sealed partial class ModelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ModelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ModelServiceSettings"/>.</returns>
        public static ModelServiceSettings GetDefault() => new ModelServiceSettings();

        /// <summary>Constructs a new <see cref="ModelServiceSettings"/> object with default settings.</summary>
        public ModelServiceSettings()
        {
        }

        private ModelServiceSettings(ModelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetModelSettings = existing.GetModelSettings;
            ListModelsSettings = existing.ListModelsSettings;
            PatchModelSettings = existing.PatchModelSettings;
            DeleteModelSettings = existing.DeleteModelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ModelServiceClient.GetModel</c>
        ///  and <c>ModelServiceClient.GetModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModels</c> and <c>ModelServiceClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.PatchModel</c> and <c>ModelServiceClient.PatchModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.DeleteModel</c> and <c>ModelServiceClient.DeleteModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ModelServiceSettings"/> object.</returns>
        public ModelServiceSettings Clone() => new ModelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ModelServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ModelServiceClientBuilder : gaxgrpc::ClientBuilderBase<ModelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ModelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ModelServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ModelServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ModelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ModelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ModelServiceClient Build()
        {
            ModelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ModelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ModelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ModelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ModelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ModelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ModelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ModelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ModelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public abstract partial class ModelServiceClient
    {
        /// <summary>
        /// The default endpoint for the ModelService service, which is a host of "bigquery.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigquery.googleapis.com:443";

        /// <summary>The default ModelService scopes.</summary>
        /// <remarks>
        /// The default ModelService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigquery.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/bigquery.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ModelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ModelServiceClient"/>.</returns>
        public static stt::Task<ModelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ModelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ModelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        public static ModelServiceClient Create() => new ModelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ModelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ModelServiceSettings"/>.</param>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        internal static ModelServiceClient Create(grpccore::CallInvoker callInvoker, ModelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelService.ModelServiceClient grpcClient = new ModelService.ModelServiceClient(callInvoker);
            return new ModelServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ModelService client</summary>
        public virtual ModelService.ModelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, st::CancellationToken cancellationToken) =>
            GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the requested model.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the requested model.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the requested model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(string projectId, string datasetId, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
            }, callSettings);

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the requested model.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the requested model.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the requested model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string projectId, string datasetId, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
            }, callSettings);

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the requested model.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the requested model.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the requested model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string projectId, string datasetId, string modelId, st::CancellationToken cancellationToken) =>
            GetModelAsync(projectId, datasetId, modelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListModelsResponse ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, st::CancellationToken cancellationToken) =>
            ListModelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the models to list.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the models to list.
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return in a single response page.
        /// Leverage the page tokens to iterate through the entire collection.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListModelsResponse ListModels(string projectId, string datasetId, uint? maxResults, gaxgrpc::CallSettings callSettings = null) =>
            ListModels(new ListModelsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                MaxResults = maxResults,
            }, callSettings);

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the models to list.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the models to list.
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return in a single response page.
        /// Leverage the page tokens to iterate through the entire collection.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListModelsResponse> ListModelsAsync(string projectId, string datasetId, uint? maxResults, gaxgrpc::CallSettings callSettings = null) =>
            ListModelsAsync(new ListModelsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                MaxResults = maxResults,
            }, callSettings);

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the models to list.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the models to list.
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return in a single response page.
        /// Leverage the page tokens to iterate through the entire collection.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListModelsResponse> ListModelsAsync(string projectId, string datasetId, uint? maxResults, st::CancellationToken cancellationToken) =>
            ListModelsAsync(projectId, datasetId, maxResults, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model PatchModel(PatchModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PatchModelAsync(PatchModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PatchModelAsync(PatchModelRequest request, st::CancellationToken cancellationToken) =>
            PatchModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the model to patch.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the model to patch.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the model to patch.
        /// </param>
        /// <param name="model">
        /// Required. Patched model.
        /// Follows RFC5789 patch semantics. Missing fields are not updated.
        /// To clear a field, explicitly set to default value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model PatchModel(string projectId, string datasetId, string modelId, Model model, gaxgrpc::CallSettings callSettings = null) =>
            PatchModel(new PatchModelRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the model to patch.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the model to patch.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the model to patch.
        /// </param>
        /// <param name="model">
        /// Required. Patched model.
        /// Follows RFC5789 patch semantics. Missing fields are not updated.
        /// To clear a field, explicitly set to default value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PatchModelAsync(string projectId, string datasetId, string modelId, Model model, gaxgrpc::CallSettings callSettings = null) =>
            PatchModelAsync(new PatchModelRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the model to patch.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the model to patch.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the model to patch.
        /// </param>
        /// <param name="model">
        /// Required. Patched model.
        /// Follows RFC5789 patch semantics. Missing fields are not updated.
        /// To clear a field, explicitly set to default value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PatchModelAsync(string projectId, string datasetId, string modelId, Model model, st::CancellationToken cancellationToken) =>
            PatchModelAsync(projectId, datasetId, modelId, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(DeleteModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the model to delete.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the model to delete.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteModel(string projectId, string datasetId, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
            }, callSettings);

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the model to delete.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the model to delete.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(string projectId, string datasetId, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
            }, callSettings);

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID of the model to delete.
        /// </param>
        /// <param name="datasetId">
        /// Required. Dataset ID of the model to delete.
        /// </param>
        /// <param name="modelId">
        /// Required. Model ID of the model to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(string projectId, string datasetId, string modelId, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(projectId, datasetId, modelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ModelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public sealed partial class ModelServiceClientImpl : ModelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetModelRequest, Model> _callGetModel;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<PatchModelRequest, Model> _callPatchModel;

        private readonly gaxgrpc::ApiCall<DeleteModelRequest, wkt::Empty> _callDeleteModel;

        /// <summary>
        /// Constructs a client wrapper for the ModelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ModelServiceSettings"/> used within this client.</param>
        public ModelServiceClientImpl(ModelService.ModelServiceClient grpcClient, ModelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ModelServiceSettings effectiveSettings = settings ?? ModelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>(grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("dataset_id", request => request.DatasetId).WithGoogleRequestParam("model_id", request => request.ModelId);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>(grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("dataset_id", request => request.DatasetId);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callPatchModel = clientHelper.BuildApiCall<PatchModelRequest, Model>(grpcClient.PatchModelAsync, grpcClient.PatchModel, effectiveSettings.PatchModelSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("dataset_id", request => request.DatasetId).WithGoogleRequestParam("model_id", request => request.ModelId);
            Modify_ApiCall(ref _callPatchModel);
            Modify_PatchModelApiCall(ref _callPatchModel);
            _callDeleteModel = clientHelper.BuildApiCall<DeleteModelRequest, wkt::Empty>(grpcClient.DeleteModelAsync, grpcClient.DeleteModel, effectiveSettings.DeleteModelSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("dataset_id", request => request.DatasetId).WithGoogleRequestParam("model_id", request => request.ModelId);
            Modify_ApiCall(ref _callDeleteModel);
            Modify_DeleteModelApiCall(ref _callDeleteModel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_PatchModelApiCall(ref gaxgrpc::ApiCall<PatchModelRequest, Model> call);

        partial void Modify_DeleteModelApiCall(ref gaxgrpc::ApiCall<DeleteModelRequest, wkt::Empty> call);

        partial void OnConstruction(ModelService.ModelServiceClient grpcClient, ModelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelService client</summary>
        public override ModelService.ModelServiceClient GrpcClient { get; }

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchModelRequest(ref PatchModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelRequest(ref DeleteModelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified model resource by model ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListModelsResponse ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return _callListModels.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all models in the specified dataset. Requires the READER dataset
        /// role. After retrieving the list of models, you can get information about a
        /// particular model by calling the models.get method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return _callListModels.Async(request, callSettings);
        }

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model PatchModel(PatchModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchModelRequest(ref request, ref callSettings);
            return _callPatchModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Patch specific fields in the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> PatchModelAsync(PatchModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchModelRequest(ref request, ref callSettings);
            return _callPatchModel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            _callDeleteModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the model specified by modelId from the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return _callDeleteModel.Async(request, callSettings);
        }
    }
}
