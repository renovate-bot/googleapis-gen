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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DataCatalog.V1
{
    /// <summary>Settings for <see cref="PolicyTagManagerSerializationClient"/> instances.</summary>
    public sealed partial class PolicyTagManagerSerializationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PolicyTagManagerSerializationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PolicyTagManagerSerializationSettings"/>.</returns>
        public static PolicyTagManagerSerializationSettings GetDefault() => new PolicyTagManagerSerializationSettings();

        /// <summary>
        /// Constructs a new <see cref="PolicyTagManagerSerializationSettings"/> object with default settings.
        /// </summary>
        public PolicyTagManagerSerializationSettings()
        {
        }

        private PolicyTagManagerSerializationSettings(PolicyTagManagerSerializationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ImportTaxonomiesSettings = existing.ImportTaxonomiesSettings;
            ExportTaxonomiesSettings = existing.ExportTaxonomiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PolicyTagManagerSerializationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerSerializationClient.ImportTaxonomies</c> and
        /// <c>PolicyTagManagerSerializationClient.ImportTaxonomiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportTaxonomiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerSerializationClient.ExportTaxonomies</c> and
        /// <c>PolicyTagManagerSerializationClient.ExportTaxonomiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportTaxonomiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PolicyTagManagerSerializationSettings"/> object.</returns>
        public PolicyTagManagerSerializationSettings Clone() => new PolicyTagManagerSerializationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PolicyTagManagerSerializationClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class PolicyTagManagerSerializationClientBuilder : gaxgrpc::ClientBuilderBase<PolicyTagManagerSerializationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PolicyTagManagerSerializationSettings Settings { get; set; }

        partial void InterceptBuild(ref PolicyTagManagerSerializationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PolicyTagManagerSerializationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PolicyTagManagerSerializationClient Build()
        {
            PolicyTagManagerSerializationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PolicyTagManagerSerializationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PolicyTagManagerSerializationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PolicyTagManagerSerializationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PolicyTagManagerSerializationClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PolicyTagManagerSerializationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PolicyTagManagerSerializationClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PolicyTagManagerSerializationClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            PolicyTagManagerSerializationClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PolicyTagManagerSerializationClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PolicyTagManagerSerialization client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Policy Tag Manager serialization API service allows clients to manipulate
    /// their policy tags and taxonomies in serialized format, where taxonomy is a
    /// hierarchical group of policy tags.
    /// </remarks>
    public abstract partial class PolicyTagManagerSerializationClient
    {
        /// <summary>
        /// The default endpoint for the PolicyTagManagerSerialization service, which is a host of
        /// "datacatalog.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datacatalog.googleapis.com:443";

        /// <summary>The default PolicyTagManagerSerialization scopes.</summary>
        /// <remarks>
        /// The default PolicyTagManagerSerialization scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PolicyTagManagerSerializationClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PolicyTagManagerSerializationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PolicyTagManagerSerializationClient"/>.</returns>
        public static stt::Task<PolicyTagManagerSerializationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PolicyTagManagerSerializationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PolicyTagManagerSerializationClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PolicyTagManagerSerializationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PolicyTagManagerSerializationClient"/>.</returns>
        public static PolicyTagManagerSerializationClient Create() =>
            new PolicyTagManagerSerializationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PolicyTagManagerSerializationClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PolicyTagManagerSerializationSettings"/>.</param>
        /// <returns>The created <see cref="PolicyTagManagerSerializationClient"/>.</returns>
        internal static PolicyTagManagerSerializationClient Create(grpccore::CallInvoker callInvoker, PolicyTagManagerSerializationSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PolicyTagManagerSerialization.PolicyTagManagerSerializationClient grpcClient = new PolicyTagManagerSerialization.PolicyTagManagerSerializationClient(callInvoker);
            return new PolicyTagManagerSerializationClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PolicyTagManagerSerialization client</summary>
        public virtual PolicyTagManagerSerialization.PolicyTagManagerSerializationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new taxonomies (including their policy tags) by importing from
        /// inlined source or cross-regional source. New taxonomies will be created in
        /// a given parent project.
        /// 
        /// If using the cross-regional source, a new taxonomy is created by copying
        /// from a source in another region.
        /// 
        /// If using the inlined source, this method provides a way to bulk create
        /// taxonomies and policy tags using nested proto structure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportTaxonomiesResponse ImportTaxonomies(ImportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new taxonomies (including their policy tags) by importing from
        /// inlined source or cross-regional source. New taxonomies will be created in
        /// a given parent project.
        /// 
        /// If using the cross-regional source, a new taxonomy is created by copying
        /// from a source in another region.
        /// 
        /// If using the inlined source, this method provides a way to bulk create
        /// taxonomies and policy tags using nested proto structure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportTaxonomiesResponse> ImportTaxonomiesAsync(ImportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new taxonomies (including their policy tags) by importing from
        /// inlined source or cross-regional source. New taxonomies will be created in
        /// a given parent project.
        /// 
        /// If using the cross-regional source, a new taxonomy is created by copying
        /// from a source in another region.
        /// 
        /// If using the inlined source, this method provides a way to bulk create
        /// taxonomies and policy tags using nested proto structure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportTaxonomiesResponse> ImportTaxonomiesAsync(ImportTaxonomiesRequest request, st::CancellationToken cancellationToken) =>
            ImportTaxonomiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports taxonomies as the requested type and returns the taxonomies
        /// including their policy tags. The requested taxonomies must belong to one
        /// project.
        /// 
        /// SerializedTaxonomy protos with nested policy tags that are generated by
        /// this method can be used as input for future ImportTaxonomies calls.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportTaxonomiesResponse ExportTaxonomies(ExportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports taxonomies as the requested type and returns the taxonomies
        /// including their policy tags. The requested taxonomies must belong to one
        /// project.
        /// 
        /// SerializedTaxonomy protos with nested policy tags that are generated by
        /// this method can be used as input for future ImportTaxonomies calls.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportTaxonomiesResponse> ExportTaxonomiesAsync(ExportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports taxonomies as the requested type and returns the taxonomies
        /// including their policy tags. The requested taxonomies must belong to one
        /// project.
        /// 
        /// SerializedTaxonomy protos with nested policy tags that are generated by
        /// this method can be used as input for future ImportTaxonomies calls.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportTaxonomiesResponse> ExportTaxonomiesAsync(ExportTaxonomiesRequest request, st::CancellationToken cancellationToken) =>
            ExportTaxonomiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PolicyTagManagerSerialization client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Policy Tag Manager serialization API service allows clients to manipulate
    /// their policy tags and taxonomies in serialized format, where taxonomy is a
    /// hierarchical group of policy tags.
    /// </remarks>
    public sealed partial class PolicyTagManagerSerializationClientImpl : PolicyTagManagerSerializationClient
    {
        private readonly gaxgrpc::ApiCall<ImportTaxonomiesRequest, ImportTaxonomiesResponse> _callImportTaxonomies;

        private readonly gaxgrpc::ApiCall<ExportTaxonomiesRequest, ExportTaxonomiesResponse> _callExportTaxonomies;

        /// <summary>
        /// Constructs a client wrapper for the PolicyTagManagerSerialization service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PolicyTagManagerSerializationSettings"/> used within this client.
        /// </param>
        public PolicyTagManagerSerializationClientImpl(PolicyTagManagerSerialization.PolicyTagManagerSerializationClient grpcClient, PolicyTagManagerSerializationSettings settings)
        {
            GrpcClient = grpcClient;
            PolicyTagManagerSerializationSettings effectiveSettings = settings ?? PolicyTagManagerSerializationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callImportTaxonomies = clientHelper.BuildApiCall<ImportTaxonomiesRequest, ImportTaxonomiesResponse>(grpcClient.ImportTaxonomiesAsync, grpcClient.ImportTaxonomies, effectiveSettings.ImportTaxonomiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportTaxonomies);
            Modify_ImportTaxonomiesApiCall(ref _callImportTaxonomies);
            _callExportTaxonomies = clientHelper.BuildApiCall<ExportTaxonomiesRequest, ExportTaxonomiesResponse>(grpcClient.ExportTaxonomiesAsync, grpcClient.ExportTaxonomies, effectiveSettings.ExportTaxonomiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportTaxonomies);
            Modify_ExportTaxonomiesApiCall(ref _callExportTaxonomies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ImportTaxonomiesApiCall(ref gaxgrpc::ApiCall<ImportTaxonomiesRequest, ImportTaxonomiesResponse> call);

        partial void Modify_ExportTaxonomiesApiCall(ref gaxgrpc::ApiCall<ExportTaxonomiesRequest, ExportTaxonomiesResponse> call);

        partial void OnConstruction(PolicyTagManagerSerialization.PolicyTagManagerSerializationClient grpcClient, PolicyTagManagerSerializationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PolicyTagManagerSerialization client</summary>
        public override PolicyTagManagerSerialization.PolicyTagManagerSerializationClient GrpcClient { get; }

        partial void Modify_ImportTaxonomiesRequest(ref ImportTaxonomiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportTaxonomiesRequest(ref ExportTaxonomiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates new taxonomies (including their policy tags) by importing from
        /// inlined source or cross-regional source. New taxonomies will be created in
        /// a given parent project.
        /// 
        /// If using the cross-regional source, a new taxonomy is created by copying
        /// from a source in another region.
        /// 
        /// If using the inlined source, this method provides a way to bulk create
        /// taxonomies and policy tags using nested proto structure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportTaxonomiesResponse ImportTaxonomies(ImportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportTaxonomiesRequest(ref request, ref callSettings);
            return _callImportTaxonomies.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new taxonomies (including their policy tags) by importing from
        /// inlined source or cross-regional source. New taxonomies will be created in
        /// a given parent project.
        /// 
        /// If using the cross-regional source, a new taxonomy is created by copying
        /// from a source in another region.
        /// 
        /// If using the inlined source, this method provides a way to bulk create
        /// taxonomies and policy tags using nested proto structure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportTaxonomiesResponse> ImportTaxonomiesAsync(ImportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportTaxonomiesRequest(ref request, ref callSettings);
            return _callImportTaxonomies.Async(request, callSettings);
        }

        /// <summary>
        /// Exports taxonomies as the requested type and returns the taxonomies
        /// including their policy tags. The requested taxonomies must belong to one
        /// project.
        /// 
        /// SerializedTaxonomy protos with nested policy tags that are generated by
        /// this method can be used as input for future ImportTaxonomies calls.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExportTaxonomiesResponse ExportTaxonomies(ExportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportTaxonomiesRequest(ref request, ref callSettings);
            return _callExportTaxonomies.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports taxonomies as the requested type and returns the taxonomies
        /// including their policy tags. The requested taxonomies must belong to one
        /// project.
        /// 
        /// SerializedTaxonomy protos with nested policy tags that are generated by
        /// this method can be used as input for future ImportTaxonomies calls.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExportTaxonomiesResponse> ExportTaxonomiesAsync(ExportTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportTaxonomiesRequest(ref request, ref callSettings);
            return _callExportTaxonomies.Async(request, callSettings);
        }
    }
}
