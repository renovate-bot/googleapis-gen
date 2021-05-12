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

namespace Google.Cloud.Osconfig.Agentendpoint.V1
{
    /// <summary>Settings for <see cref="AgentEndpointServiceClient"/> instances.</summary>
    public sealed partial class AgentEndpointServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgentEndpointServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgentEndpointServiceSettings"/>.</returns>
        public static AgentEndpointServiceSettings GetDefault() => new AgentEndpointServiceSettings();

        /// <summary>Constructs a new <see cref="AgentEndpointServiceSettings"/> object with default settings.</summary>
        public AgentEndpointServiceSettings()
        {
        }

        private AgentEndpointServiceSettings(AgentEndpointServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReceiveTaskNotificationSettings = existing.ReceiveTaskNotificationSettings;
            StartNextTaskSettings = existing.StartNextTaskSettings;
            ReportTaskProgressSettings = existing.ReportTaskProgressSettings;
            ReportTaskCompleteSettings = existing.ReportTaskCompleteSettings;
            RegisterAgentSettings = existing.RegisterAgentSettings;
            ReportInventorySettings = existing.ReportInventorySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgentEndpointServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentEndpointServiceClient.ReceiveTaskNotification</c> and
        /// <c>AgentEndpointServiceClient.ReceiveTaskNotificationAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 3600 seconds.</remarks>
        public gaxgrpc::CallSettings ReceiveTaskNotificationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentEndpointServiceClient.StartNextTask</c> and <c>AgentEndpointServiceClient.StartNextTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartNextTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentEndpointServiceClient.ReportTaskProgress</c> and
        /// <c>AgentEndpointServiceClient.ReportTaskProgressAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportTaskProgressSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentEndpointServiceClient.ReportTaskComplete</c> and
        /// <c>AgentEndpointServiceClient.ReportTaskCompleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportTaskCompleteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentEndpointServiceClient.RegisterAgent</c> and <c>AgentEndpointServiceClient.RegisterAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegisterAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentEndpointServiceClient.ReportInventory</c> and <c>AgentEndpointServiceClient.ReportInventoryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AgentEndpointServiceSettings"/> object.</returns>
        public AgentEndpointServiceSettings Clone() => new AgentEndpointServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentEndpointServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AgentEndpointServiceClientBuilder : gaxgrpc::ClientBuilderBase<AgentEndpointServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgentEndpointServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AgentEndpointServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgentEndpointServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgentEndpointServiceClient Build()
        {
            AgentEndpointServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgentEndpointServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgentEndpointServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgentEndpointServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentEndpointServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AgentEndpointServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentEndpointServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AgentEndpointServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AgentEndpointServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentEndpointServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AgentEndpointService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// OS Config agent endpoint API.
    /// </remarks>
    public abstract partial class AgentEndpointServiceClient
    {
        /// <summary>
        /// The default endpoint for the AgentEndpointService service, which is a host of "osconfig.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "osconfig.googleapis.com:443";

        /// <summary>The default AgentEndpointService scopes.</summary>
        /// <remarks>The default AgentEndpointService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AgentEndpointServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AgentEndpointServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgentEndpointServiceClient"/>.</returns>
        public static stt::Task<AgentEndpointServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgentEndpointServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgentEndpointServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AgentEndpointServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgentEndpointServiceClient"/>.</returns>
        public static AgentEndpointServiceClient Create() => new AgentEndpointServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgentEndpointServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgentEndpointServiceSettings"/>.</param>
        /// <returns>The created <see cref="AgentEndpointServiceClient"/>.</returns>
        internal static AgentEndpointServiceClient Create(grpccore::CallInvoker callInvoker, AgentEndpointServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AgentEndpointService.AgentEndpointServiceClient grpcClient = new AgentEndpointService.AgentEndpointServiceClient(callInvoker);
            return new AgentEndpointServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AgentEndpointService client</summary>
        public virtual AgentEndpointService.AgentEndpointServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for
        /// <see cref="ReceiveTaskNotification(ReceiveTaskNotificationRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReceiveTaskNotificationStream : gaxgrpc::ServerStreamingBase<ReceiveTaskNotificationResponse>
        {
        }

        /// <summary>
        /// Stream established by client to receive Task notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReceiveTaskNotificationStream ReceiveTaskNotification(ReceiveTaskNotificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stream established by client to receive Task notifications.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="agentVersion">
        /// Required. The version of the agent making the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReceiveTaskNotificationStream ReceiveTaskNotification(string instanceIdToken, string agentVersion, gaxgrpc::CallSettings callSettings = null) =>
            ReceiveTaskNotification(new ReceiveTaskNotificationRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                AgentVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(agentVersion, nameof(agentVersion)),
            }, callSettings);

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartNextTaskResponse StartNextTask(StartNextTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartNextTaskResponse> StartNextTaskAsync(StartNextTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartNextTaskResponse> StartNextTaskAsync(StartNextTaskRequest request, st::CancellationToken cancellationToken) =>
            StartNextTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartNextTaskResponse StartNextTask(string instanceIdToken, gaxgrpc::CallSettings callSettings = null) =>
            StartNextTask(new StartNextTaskRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
            }, callSettings);

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartNextTaskResponse> StartNextTaskAsync(string instanceIdToken, gaxgrpc::CallSettings callSettings = null) =>
            StartNextTaskAsync(new StartNextTaskRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
            }, callSettings);

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartNextTaskResponse> StartNextTaskAsync(string instanceIdToken, st::CancellationToken cancellationToken) =>
            StartNextTaskAsync(instanceIdToken, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, st::CancellationToken cancellationToken) =>
            ReportTaskProgressAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="taskId">
        /// Required. Unique identifier of the task this applies to.
        /// </param>
        /// <param name="taskType">
        /// Required. The type of task to report progress on.
        /// 
        /// Progress must include the appropriate message based on this enum as
        /// specified below:
        /// APPLY_PATCHES = ApplyPatchesTaskProgress
        /// EXEC_STEP = Progress not supported for this type.
        /// APPLY_CONFIG_TASK = ApplyConfigTaskProgress
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportTaskProgressResponse ReportTaskProgress(string instanceIdToken, string taskId, TaskType taskType, gaxgrpc::CallSettings callSettings = null) =>
            ReportTaskProgress(new ReportTaskProgressRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                TaskType = taskType,
            }, callSettings);

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="taskId">
        /// Required. Unique identifier of the task this applies to.
        /// </param>
        /// <param name="taskType">
        /// Required. The type of task to report progress on.
        /// 
        /// Progress must include the appropriate message based on this enum as
        /// specified below:
        /// APPLY_PATCHES = ApplyPatchesTaskProgress
        /// EXEC_STEP = Progress not supported for this type.
        /// APPLY_CONFIG_TASK = ApplyConfigTaskProgress
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskProgressResponse> ReportTaskProgressAsync(string instanceIdToken, string taskId, TaskType taskType, gaxgrpc::CallSettings callSettings = null) =>
            ReportTaskProgressAsync(new ReportTaskProgressRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                TaskType = taskType,
            }, callSettings);

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="taskId">
        /// Required. Unique identifier of the task this applies to.
        /// </param>
        /// <param name="taskType">
        /// Required. The type of task to report progress on.
        /// 
        /// Progress must include the appropriate message based on this enum as
        /// specified below:
        /// APPLY_PATCHES = ApplyPatchesTaskProgress
        /// EXEC_STEP = Progress not supported for this type.
        /// APPLY_CONFIG_TASK = ApplyConfigTaskProgress
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskProgressResponse> ReportTaskProgressAsync(string instanceIdToken, string taskId, TaskType taskType, st::CancellationToken cancellationToken) =>
            ReportTaskProgressAsync(instanceIdToken, taskId, taskType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportTaskCompleteResponse ReportTaskComplete(ReportTaskCompleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskCompleteResponse> ReportTaskCompleteAsync(ReportTaskCompleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskCompleteResponse> ReportTaskCompleteAsync(ReportTaskCompleteRequest request, st::CancellationToken cancellationToken) =>
            ReportTaskCompleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="taskId">
        /// Required. Unique identifier of the task this applies to.
        /// </param>
        /// <param name="taskType">
        /// Required. The type of task to report completed.
        /// 
        /// Output must include the appropriate message based on this enum as
        /// specified below:
        /// APPLY_PATCHES = ApplyPatchesTaskOutput
        /// EXEC_STEP = ExecStepTaskOutput
        /// APPLY_CONFIG_TASK = ApplyConfigTaskOutput
        /// </param>
        /// <param name="errorMessage">
        /// Descriptive error message if the task execution ended in error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportTaskCompleteResponse ReportTaskComplete(string instanceIdToken, string taskId, TaskType taskType, string errorMessage, gaxgrpc::CallSettings callSettings = null) =>
            ReportTaskComplete(new ReportTaskCompleteRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                TaskType = taskType,
                ErrorMessage = errorMessage ?? "",
            }, callSettings);

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="taskId">
        /// Required. Unique identifier of the task this applies to.
        /// </param>
        /// <param name="taskType">
        /// Required. The type of task to report completed.
        /// 
        /// Output must include the appropriate message based on this enum as
        /// specified below:
        /// APPLY_PATCHES = ApplyPatchesTaskOutput
        /// EXEC_STEP = ExecStepTaskOutput
        /// APPLY_CONFIG_TASK = ApplyConfigTaskOutput
        /// </param>
        /// <param name="errorMessage">
        /// Descriptive error message if the task execution ended in error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskCompleteResponse> ReportTaskCompleteAsync(string instanceIdToken, string taskId, TaskType taskType, string errorMessage, gaxgrpc::CallSettings callSettings = null) =>
            ReportTaskCompleteAsync(new ReportTaskCompleteRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                TaskType = taskType,
                ErrorMessage = errorMessage ?? "",
            }, callSettings);

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="taskId">
        /// Required. Unique identifier of the task this applies to.
        /// </param>
        /// <param name="taskType">
        /// Required. The type of task to report completed.
        /// 
        /// Output must include the appropriate message based on this enum as
        /// specified below:
        /// APPLY_PATCHES = ApplyPatchesTaskOutput
        /// EXEC_STEP = ExecStepTaskOutput
        /// APPLY_CONFIG_TASK = ApplyConfigTaskOutput
        /// </param>
        /// <param name="errorMessage">
        /// Descriptive error message if the task execution ended in error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportTaskCompleteResponse> ReportTaskCompleteAsync(string instanceIdToken, string taskId, TaskType taskType, string errorMessage, st::CancellationToken cancellationToken) =>
            ReportTaskCompleteAsync(instanceIdToken, taskId, taskType, errorMessage, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegisterAgentResponse RegisterAgent(RegisterAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterAgentResponse> RegisterAgentAsync(RegisterAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterAgentResponse> RegisterAgentAsync(RegisterAgentRequest request, st::CancellationToken cancellationToken) =>
            RegisterAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="agentVersion">
        /// Required. The version of the agent.
        /// </param>
        /// <param name="supportedCapabilities">
        /// Required. The capabilities supported by the agent. Supported values are:
        /// PATCH_GA
        /// GUEST_POLICY_BETA
        /// CONFIG_V1
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegisterAgentResponse RegisterAgent(string instanceIdToken, string agentVersion, scg::IEnumerable<string> supportedCapabilities, gaxgrpc::CallSettings callSettings = null) =>
            RegisterAgent(new RegisterAgentRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                AgentVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(agentVersion, nameof(agentVersion)),
                SupportedCapabilities =
                {
                    gax::GaxPreconditions.CheckNotNull(supportedCapabilities, nameof(supportedCapabilities)),
                },
            }, callSettings);

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="agentVersion">
        /// Required. The version of the agent.
        /// </param>
        /// <param name="supportedCapabilities">
        /// Required. The capabilities supported by the agent. Supported values are:
        /// PATCH_GA
        /// GUEST_POLICY_BETA
        /// CONFIG_V1
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterAgentResponse> RegisterAgentAsync(string instanceIdToken, string agentVersion, scg::IEnumerable<string> supportedCapabilities, gaxgrpc::CallSettings callSettings = null) =>
            RegisterAgentAsync(new RegisterAgentRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                AgentVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(agentVersion, nameof(agentVersion)),
                SupportedCapabilities =
                {
                    gax::GaxPreconditions.CheckNotNull(supportedCapabilities, nameof(supportedCapabilities)),
                },
            }, callSettings);

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="agentVersion">
        /// Required. The version of the agent.
        /// </param>
        /// <param name="supportedCapabilities">
        /// Required. The capabilities supported by the agent. Supported values are:
        /// PATCH_GA
        /// GUEST_POLICY_BETA
        /// CONFIG_V1
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterAgentResponse> RegisterAgentAsync(string instanceIdToken, string agentVersion, scg::IEnumerable<string> supportedCapabilities, st::CancellationToken cancellationToken) =>
            RegisterAgentAsync(instanceIdToken, agentVersion, supportedCapabilities, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportInventoryResponse ReportInventory(ReportInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportInventoryResponse> ReportInventoryAsync(ReportInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportInventoryResponse> ReportInventoryAsync(ReportInventoryRequest request, st::CancellationToken cancellationToken) =>
            ReportInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="inventoryChecksum">
        /// Required. This is a client created checksum that should be generated based
        /// on the contents of the reported inventory.  This will be used by the
        /// service to determine if it has the latest version of inventory.
        /// </param>
        /// <param name="inventory">
        /// Optional. This is the details of the inventory.  Should only be provided if
        /// the inventory has changed since the last report, or if instructed by the
        /// service to provide full inventory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportInventoryResponse ReportInventory(string instanceIdToken, string inventoryChecksum, Inventory inventory, gaxgrpc::CallSettings callSettings = null) =>
            ReportInventory(new ReportInventoryRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                InventoryChecksum = gax::GaxPreconditions.CheckNotNullOrEmpty(inventoryChecksum, nameof(inventoryChecksum)),
                Inventory = inventory,
            }, callSettings);

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="inventoryChecksum">
        /// Required. This is a client created checksum that should be generated based
        /// on the contents of the reported inventory.  This will be used by the
        /// service to determine if it has the latest version of inventory.
        /// </param>
        /// <param name="inventory">
        /// Optional. This is the details of the inventory.  Should only be provided if
        /// the inventory has changed since the last report, or if instructed by the
        /// service to provide full inventory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportInventoryResponse> ReportInventoryAsync(string instanceIdToken, string inventoryChecksum, Inventory inventory, gaxgrpc::CallSettings callSettings = null) =>
            ReportInventoryAsync(new ReportInventoryRequest
            {
                InstanceIdToken = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceIdToken, nameof(instanceIdToken)),
                InventoryChecksum = gax::GaxPreconditions.CheckNotNullOrEmpty(inventoryChecksum, nameof(inventoryChecksum)),
                Inventory = inventory,
            }, callSettings);

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="instanceIdToken">
        /// Required. This is the Compute Engine instance identity token described in
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// where the audience is 'osconfig.googleapis.com' and the format is 'full'.
        /// </param>
        /// <param name="inventoryChecksum">
        /// Required. This is a client created checksum that should be generated based
        /// on the contents of the reported inventory.  This will be used by the
        /// service to determine if it has the latest version of inventory.
        /// </param>
        /// <param name="inventory">
        /// Optional. This is the details of the inventory.  Should only be provided if
        /// the inventory has changed since the last report, or if instructed by the
        /// service to provide full inventory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportInventoryResponse> ReportInventoryAsync(string instanceIdToken, string inventoryChecksum, Inventory inventory, st::CancellationToken cancellationToken) =>
            ReportInventoryAsync(instanceIdToken, inventoryChecksum, inventory, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AgentEndpointService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// OS Config agent endpoint API.
    /// </remarks>
    public sealed partial class AgentEndpointServiceClientImpl : AgentEndpointServiceClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse> _callReceiveTaskNotification;

        private readonly gaxgrpc::ApiCall<StartNextTaskRequest, StartNextTaskResponse> _callStartNextTask;

        private readonly gaxgrpc::ApiCall<ReportTaskProgressRequest, ReportTaskProgressResponse> _callReportTaskProgress;

        private readonly gaxgrpc::ApiCall<ReportTaskCompleteRequest, ReportTaskCompleteResponse> _callReportTaskComplete;

        private readonly gaxgrpc::ApiCall<RegisterAgentRequest, RegisterAgentResponse> _callRegisterAgent;

        private readonly gaxgrpc::ApiCall<ReportInventoryRequest, ReportInventoryResponse> _callReportInventory;

        /// <summary>
        /// Constructs a client wrapper for the AgentEndpointService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgentEndpointServiceSettings"/> used within this client.</param>
        public AgentEndpointServiceClientImpl(AgentEndpointService.AgentEndpointServiceClient grpcClient, AgentEndpointServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AgentEndpointServiceSettings effectiveSettings = settings ?? AgentEndpointServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callReceiveTaskNotification = clientHelper.BuildApiCall<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>(grpcClient.ReceiveTaskNotification, effectiveSettings.ReceiveTaskNotificationSettings);
            Modify_ApiCall(ref _callReceiveTaskNotification);
            Modify_ReceiveTaskNotificationApiCall(ref _callReceiveTaskNotification);
            _callStartNextTask = clientHelper.BuildApiCall<StartNextTaskRequest, StartNextTaskResponse>(grpcClient.StartNextTaskAsync, grpcClient.StartNextTask, effectiveSettings.StartNextTaskSettings);
            Modify_ApiCall(ref _callStartNextTask);
            Modify_StartNextTaskApiCall(ref _callStartNextTask);
            _callReportTaskProgress = clientHelper.BuildApiCall<ReportTaskProgressRequest, ReportTaskProgressResponse>(grpcClient.ReportTaskProgressAsync, grpcClient.ReportTaskProgress, effectiveSettings.ReportTaskProgressSettings);
            Modify_ApiCall(ref _callReportTaskProgress);
            Modify_ReportTaskProgressApiCall(ref _callReportTaskProgress);
            _callReportTaskComplete = clientHelper.BuildApiCall<ReportTaskCompleteRequest, ReportTaskCompleteResponse>(grpcClient.ReportTaskCompleteAsync, grpcClient.ReportTaskComplete, effectiveSettings.ReportTaskCompleteSettings);
            Modify_ApiCall(ref _callReportTaskComplete);
            Modify_ReportTaskCompleteApiCall(ref _callReportTaskComplete);
            _callRegisterAgent = clientHelper.BuildApiCall<RegisterAgentRequest, RegisterAgentResponse>(grpcClient.RegisterAgentAsync, grpcClient.RegisterAgent, effectiveSettings.RegisterAgentSettings);
            Modify_ApiCall(ref _callRegisterAgent);
            Modify_RegisterAgentApiCall(ref _callRegisterAgent);
            _callReportInventory = clientHelper.BuildApiCall<ReportInventoryRequest, ReportInventoryResponse>(grpcClient.ReportInventoryAsync, grpcClient.ReportInventory, effectiveSettings.ReportInventorySettings);
            Modify_ApiCall(ref _callReportInventory);
            Modify_ReportInventoryApiCall(ref _callReportInventory);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ReceiveTaskNotificationApiCall(ref gaxgrpc::ApiServerStreamingCall<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse> call);

        partial void Modify_StartNextTaskApiCall(ref gaxgrpc::ApiCall<StartNextTaskRequest, StartNextTaskResponse> call);

        partial void Modify_ReportTaskProgressApiCall(ref gaxgrpc::ApiCall<ReportTaskProgressRequest, ReportTaskProgressResponse> call);

        partial void Modify_ReportTaskCompleteApiCall(ref gaxgrpc::ApiCall<ReportTaskCompleteRequest, ReportTaskCompleteResponse> call);

        partial void Modify_RegisterAgentApiCall(ref gaxgrpc::ApiCall<RegisterAgentRequest, RegisterAgentResponse> call);

        partial void Modify_ReportInventoryApiCall(ref gaxgrpc::ApiCall<ReportInventoryRequest, ReportInventoryResponse> call);

        partial void OnConstruction(AgentEndpointService.AgentEndpointServiceClient grpcClient, AgentEndpointServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AgentEndpointService client</summary>
        public override AgentEndpointService.AgentEndpointServiceClient GrpcClient { get; }

        partial void Modify_ReceiveTaskNotificationRequest(ref ReceiveTaskNotificationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartNextTaskRequest(ref StartNextTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportTaskProgressRequest(ref ReportTaskProgressRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportTaskCompleteRequest(ref ReportTaskCompleteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterAgentRequest(ref RegisterAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportInventoryRequest(ref ReportInventoryRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class ReceiveTaskNotificationStreamImpl : ReceiveTaskNotificationStream
        {
            /// <summary>Construct the server streaming method for <c>ReceiveTaskNotification</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReceiveTaskNotificationStreamImpl(grpccore::AsyncServerStreamingCall<ReceiveTaskNotificationResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReceiveTaskNotificationResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Stream established by client to receive Task notifications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override AgentEndpointServiceClient.ReceiveTaskNotificationStream ReceiveTaskNotification(ReceiveTaskNotificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReceiveTaskNotificationRequest(ref request, ref callSettings);
            return new ReceiveTaskNotificationStreamImpl(_callReceiveTaskNotification.Call(request, callSettings));
        }

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartNextTaskResponse StartNextTask(StartNextTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartNextTaskRequest(ref request, ref callSettings);
            return _callStartNextTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Signals the start of a task execution and returns the task info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartNextTaskResponse> StartNextTaskAsync(StartNextTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartNextTaskRequest(ref request, ref callSettings);
            return _callStartNextTask.Async(request, callSettings);
        }

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportTaskProgressRequest(ref request, ref callSettings);
            return _callReportTaskProgress.Sync(request, callSettings);
        }

        /// <summary>
        /// Signals an intermediary progress checkpoint in task execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportTaskProgressRequest(ref request, ref callSettings);
            return _callReportTaskProgress.Async(request, callSettings);
        }

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportTaskCompleteResponse ReportTaskComplete(ReportTaskCompleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportTaskCompleteRequest(ref request, ref callSettings);
            return _callReportTaskComplete.Sync(request, callSettings);
        }

        /// <summary>
        /// Signals that the task execution is complete and optionally returns the next
        /// task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportTaskCompleteResponse> ReportTaskCompleteAsync(ReportTaskCompleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportTaskCompleteRequest(ref request, ref callSettings);
            return _callReportTaskComplete.Async(request, callSettings);
        }

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegisterAgentResponse RegisterAgent(RegisterAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterAgentRequest(ref request, ref callSettings);
            return _callRegisterAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Registers the agent running on the VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegisterAgentResponse> RegisterAgentAsync(RegisterAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterAgentRequest(ref request, ref callSettings);
            return _callRegisterAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportInventoryResponse ReportInventory(ReportInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportInventoryRequest(ref request, ref callSettings);
            return _callReportInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Reports the VMs current inventory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportInventoryResponse> ReportInventoryAsync(ReportInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportInventoryRequest(ref request, ref callSettings);
            return _callReportInventory.Async(request, callSettings);
        }
    }
}
