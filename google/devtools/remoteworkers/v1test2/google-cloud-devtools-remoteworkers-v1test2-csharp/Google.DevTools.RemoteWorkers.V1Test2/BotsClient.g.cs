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

namespace Google.DevTools.RemoteWorkers.V1Test2
{
    /// <summary>Settings for <see cref="BotsClient"/> instances.</summary>
    public sealed partial class BotsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BotsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BotsSettings"/>.</returns>
        public static BotsSettings GetDefault() => new BotsSettings();

        /// <summary>Constructs a new <see cref="BotsSettings"/> object with default settings.</summary>
        public BotsSettings()
        {
        }

        private BotsSettings(BotsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBotSessionSettings = existing.CreateBotSessionSettings;
            UpdateBotSessionSettings = existing.UpdateBotSessionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BotsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BotsClient.CreateBotSession</c>
        ///  and <c>BotsClient.CreateBotSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBotSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BotsClient.UpdateBotSession</c>
        ///  and <c>BotsClient.UpdateBotSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBotSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BotsSettings"/> object.</returns>
        public BotsSettings Clone() => new BotsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BotsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BotsClientBuilder : gaxgrpc::ClientBuilderBase<BotsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BotsSettings Settings { get; set; }

        partial void InterceptBuild(ref BotsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BotsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BotsClient Build()
        {
            BotsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BotsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BotsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BotsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BotsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BotsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BotsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BotsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BotsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BotsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Bots client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Design doc: https://goo.gl/oojM5H
    /// 
    /// Loosely speaking, the Bots interface monitors a collection of workers (think
    /// of them as "computers" for a moment). This collection is known as a "farm,"
    /// and its purpose is to perform work on behalf of a client.
    /// 
    /// Each worker runs a small program known as a "bot" that allows it to be
    /// controlled by the server. This interface contains only methods that are
    /// called by the bots themselves; admin functionality is out of scope for this
    /// interface.
    /// 
    /// More precisely, we use the term "worker" to refer to the physical "thing"
    /// running the bot. We use the term "worker," and not "machine" or "computer,"
    /// since a worker may consist of more than one machine - e.g., a computer with
    /// multiple attached devices, or even a cluster of computers, with only one of
    /// them running the bot. Conversely, a single machine may host several bots, in
    /// which case each bot has a "worker" corresponding to the slice of the machine
    /// being managed by that bot.
    /// 
    /// The main resource in the Bots interface is not, surprisingly, a Bot - it is a
    /// BotSession, which represents a period of time in which a bot is in continuous
    /// contact with the server (see the BotSession message for more information).
    /// The parent of a bot session can be thought of as an instance of a farm. That
    /// is, one endpoint may be able to manage many farms for many users. For
    /// example, for a farm managed through GCP, the parent resource will typically
    /// take the form "projects/{project_id}". This is referred to below as "the farm
    /// resource."
    /// </remarks>
    public abstract partial class BotsClient
    {
        /// <summary>
        /// The default endpoint for the Bots service, which is a host of "remoteworkers.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "remoteworkers.googleapis.com:443";

        /// <summary>The default Bots scopes.</summary>
        /// <remarks>The default Bots scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BotsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="BotsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BotsClient"/>.</returns>
        public static stt::Task<BotsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BotsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BotsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="BotsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BotsClient"/>.</returns>
        public static BotsClient Create() => new BotsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BotsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BotsSettings"/>.</param>
        /// <returns>The created <see cref="BotsClient"/>.</returns>
        internal static BotsClient Create(grpccore::CallInvoker callInvoker, BotsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Bots.BotsClient grpcClient = new Bots.BotsClient(callInvoker);
            return new BotsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Bots client</summary>
        public virtual Bots.BotsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BotSession CreateBotSession(CreateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> CreateBotSessionAsync(CreateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> CreateBotSessionAsync(CreateBotSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateBotSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="parent">
        /// Required. The farm resource.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session to create. Server-assigned fields like name must be unset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BotSession CreateBotSession(string parent, BotSession botSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateBotSession(new CreateBotSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BotSession = gax::GaxPreconditions.CheckNotNull(botSession, nameof(botSession)),
            }, callSettings);

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="parent">
        /// Required. The farm resource.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session to create. Server-assigned fields like name must be unset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> CreateBotSessionAsync(string parent, BotSession botSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateBotSessionAsync(new CreateBotSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BotSession = gax::GaxPreconditions.CheckNotNull(botSession, nameof(botSession)),
            }, callSettings);

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="parent">
        /// Required. The farm resource.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session to create. Server-assigned fields like name must be unset.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> CreateBotSessionAsync(string parent, BotSession botSession, st::CancellationToken cancellationToken) =>
            CreateBotSessionAsync(parent, botSession, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BotSession UpdateBotSession(UpdateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> UpdateBotSessionAsync(UpdateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> UpdateBotSessionAsync(UpdateBotSessionRequest request, st::CancellationToken cancellationToken) =>
            UpdateBotSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="name">
        /// Required. The bot session name. Must match bot_session.name.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields on the bot that should be updated. See the BotSession resource
        /// for which fields are updatable by which caller.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BotSession UpdateBotSession(string name, BotSession botSession, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBotSession(new UpdateBotSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BotSession = gax::GaxPreconditions.CheckNotNull(botSession, nameof(botSession)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="name">
        /// Required. The bot session name. Must match bot_session.name.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields on the bot that should be updated. See the BotSession resource
        /// for which fields are updatable by which caller.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> UpdateBotSessionAsync(string name, BotSession botSession, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBotSessionAsync(new UpdateBotSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BotSession = gax::GaxPreconditions.CheckNotNull(botSession, nameof(botSession)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="name">
        /// Required. The bot session name. Must match bot_session.name.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields on the bot that should be updated. See the BotSession resource
        /// for which fields are updatable by which caller.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> UpdateBotSessionAsync(string name, BotSession botSession, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBotSessionAsync(name, botSession, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="name">
        /// Required. The bot session name. Must match bot_session.name.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields on the bot that should be updated. See the BotSession resource
        /// for which fields are updatable by which caller.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BotSession UpdateBotSession(BotSessionName name, BotSession botSession, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBotSession(new UpdateBotSessionRequest
            {
                BotSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BotSession = gax::GaxPreconditions.CheckNotNull(botSession, nameof(botSession)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="name">
        /// Required. The bot session name. Must match bot_session.name.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields on the bot that should be updated. See the BotSession resource
        /// for which fields are updatable by which caller.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> UpdateBotSessionAsync(BotSessionName name, BotSession botSession, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBotSessionAsync(new UpdateBotSessionRequest
            {
                BotSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BotSession = gax::GaxPreconditions.CheckNotNull(botSession, nameof(botSession)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="name">
        /// Required. The bot session name. Must match bot_session.name.
        /// </param>
        /// <param name="botSession">
        /// Required. The bot session resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields on the bot that should be updated. See the BotSession resource
        /// for which fields are updatable by which caller.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BotSession> UpdateBotSessionAsync(BotSessionName name, BotSession botSession, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBotSessionAsync(name, botSession, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Bots client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Design doc: https://goo.gl/oojM5H
    /// 
    /// Loosely speaking, the Bots interface monitors a collection of workers (think
    /// of them as "computers" for a moment). This collection is known as a "farm,"
    /// and its purpose is to perform work on behalf of a client.
    /// 
    /// Each worker runs a small program known as a "bot" that allows it to be
    /// controlled by the server. This interface contains only methods that are
    /// called by the bots themselves; admin functionality is out of scope for this
    /// interface.
    /// 
    /// More precisely, we use the term "worker" to refer to the physical "thing"
    /// running the bot. We use the term "worker," and not "machine" or "computer,"
    /// since a worker may consist of more than one machine - e.g., a computer with
    /// multiple attached devices, or even a cluster of computers, with only one of
    /// them running the bot. Conversely, a single machine may host several bots, in
    /// which case each bot has a "worker" corresponding to the slice of the machine
    /// being managed by that bot.
    /// 
    /// The main resource in the Bots interface is not, surprisingly, a Bot - it is a
    /// BotSession, which represents a period of time in which a bot is in continuous
    /// contact with the server (see the BotSession message for more information).
    /// The parent of a bot session can be thought of as an instance of a farm. That
    /// is, one endpoint may be able to manage many farms for many users. For
    /// example, for a farm managed through GCP, the parent resource will typically
    /// take the form "projects/{project_id}". This is referred to below as "the farm
    /// resource."
    /// </remarks>
    public sealed partial class BotsClientImpl : BotsClient
    {
        private readonly gaxgrpc::ApiCall<CreateBotSessionRequest, BotSession> _callCreateBotSession;

        private readonly gaxgrpc::ApiCall<UpdateBotSessionRequest, BotSession> _callUpdateBotSession;

        /// <summary>
        /// Constructs a client wrapper for the Bots service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BotsSettings"/> used within this client.</param>
        public BotsClientImpl(Bots.BotsClient grpcClient, BotsSettings settings)
        {
            GrpcClient = grpcClient;
            BotsSettings effectiveSettings = settings ?? BotsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateBotSession = clientHelper.BuildApiCall<CreateBotSessionRequest, BotSession>(grpcClient.CreateBotSessionAsync, grpcClient.CreateBotSession, effectiveSettings.CreateBotSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBotSession);
            Modify_CreateBotSessionApiCall(ref _callCreateBotSession);
            _callUpdateBotSession = clientHelper.BuildApiCall<UpdateBotSessionRequest, BotSession>(grpcClient.UpdateBotSessionAsync, grpcClient.UpdateBotSession, effectiveSettings.UpdateBotSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateBotSession);
            Modify_UpdateBotSessionApiCall(ref _callUpdateBotSession);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBotSessionApiCall(ref gaxgrpc::ApiCall<CreateBotSessionRequest, BotSession> call);

        partial void Modify_UpdateBotSessionApiCall(ref gaxgrpc::ApiCall<UpdateBotSessionRequest, BotSession> call);

        partial void OnConstruction(Bots.BotsClient grpcClient, BotsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Bots client</summary>
        public override Bots.BotsClient GrpcClient { get; }

        partial void Modify_CreateBotSessionRequest(ref CreateBotSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBotSessionRequest(ref UpdateBotSessionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BotSession CreateBotSession(CreateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBotSessionRequest(ref request, ref callSettings);
            return _callCreateBotSession.Sync(request, callSettings);
        }

        /// <summary>
        /// CreateBotSession is called when the bot first joins the farm, and
        /// establishes a session ID to ensure that multiple machines do not register
        /// using the same name accidentally.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BotSession> CreateBotSessionAsync(CreateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBotSessionRequest(ref request, ref callSettings);
            return _callCreateBotSession.Async(request, callSettings);
        }

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BotSession UpdateBotSession(UpdateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBotSessionRequest(ref request, ref callSettings);
            return _callUpdateBotSession.Sync(request, callSettings);
        }

        /// <summary>
        /// UpdateBotSession must be called periodically by the bot (on a schedule
        /// determined by the server) to let the server know about its status, and to
        /// pick up new lease requests from the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BotSession> UpdateBotSessionAsync(UpdateBotSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBotSessionRequest(ref request, ref callSettings);
            return _callUpdateBotSession.Async(request, callSettings);
        }
    }
}
