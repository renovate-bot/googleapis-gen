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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DocumentAI.V1Beta3
{
    /// <summary>Settings for <see cref="DocumentProcessorServiceClient"/> instances.</summary>
    public sealed partial class DocumentProcessorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DocumentProcessorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DocumentProcessorServiceSettings"/>.</returns>
        public static DocumentProcessorServiceSettings GetDefault() => new DocumentProcessorServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DocumentProcessorServiceSettings"/> object with default settings.
        /// </summary>
        public DocumentProcessorServiceSettings()
        {
        }

        private DocumentProcessorServiceSettings(DocumentProcessorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ProcessDocumentSettings = existing.ProcessDocumentSettings;
            BatchProcessDocumentsSettings = existing.BatchProcessDocumentsSettings;
            BatchProcessDocumentsOperationsSettings = existing.BatchProcessDocumentsOperationsSettings.Clone();
            FetchProcessorTypesSettings = existing.FetchProcessorTypesSettings;
            ListProcessorsSettings = existing.ListProcessorsSettings;
            CreateProcessorSettings = existing.CreateProcessorSettings;
            DeleteProcessorSettings = existing.DeleteProcessorSettings;
            DeleteProcessorOperationsSettings = existing.DeleteProcessorOperationsSettings.Clone();
            EnableProcessorSettings = existing.EnableProcessorSettings;
            EnableProcessorOperationsSettings = existing.EnableProcessorOperationsSettings.Clone();
            DisableProcessorSettings = existing.DisableProcessorSettings;
            DisableProcessorOperationsSettings = existing.DisableProcessorOperationsSettings.Clone();
            ReviewDocumentSettings = existing.ReviewDocumentSettings;
            ReviewDocumentOperationsSettings = existing.ReviewDocumentOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(DocumentProcessorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ProcessDocument</c> and
        /// <c>DocumentProcessorServiceClient.ProcessDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProcessDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentProcessorServiceClient.BatchProcessDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchProcessDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentProcessorServiceClient.BatchProcessDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchProcessDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.FetchProcessorTypes</c> and
        /// <c>DocumentProcessorServiceClient.FetchProcessorTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchProcessorTypesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ListProcessors</c> and
        /// <c>DocumentProcessorServiceClient.ListProcessorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.CreateProcessor</c> and
        /// <c>DocumentProcessorServiceClient.CreateProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.DeleteProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DeleteProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.DeleteProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DeleteProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.EnableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.EnableProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.EnableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.EnableProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings EnableProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.DisableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DisableProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.DisableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DisableProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DisableProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ReviewDocument</c> and
        /// <c>DocumentProcessorServiceClient.ReviewDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReviewDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.ReviewDocument</c> and
        /// <c>DocumentProcessorServiceClient.ReviewDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ReviewDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DocumentProcessorServiceSettings"/> object.</returns>
        public DocumentProcessorServiceSettings Clone() => new DocumentProcessorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DocumentProcessorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DocumentProcessorServiceClientBuilder : gaxgrpc::ClientBuilderBase<DocumentProcessorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DocumentProcessorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DocumentProcessorServiceClientBuilder()
        {
            UseJwtAccessWithScopes = DocumentProcessorServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref DocumentProcessorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DocumentProcessorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DocumentProcessorServiceClient Build()
        {
            DocumentProcessorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DocumentProcessorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DocumentProcessorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DocumentProcessorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DocumentProcessorServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DocumentProcessorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentProcessorServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DocumentProcessorServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DocumentProcessorServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DocumentProcessorServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DocumentProcessorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to call Cloud DocumentAI to process documents according to the
    /// processor's definition. Processors are built using state-of-the-art Google
    /// AI such as natural language, computer vision, and translation to extract
    /// structured information from unstructured or semi-structured documents.
    /// </remarks>
    public abstract partial class DocumentProcessorServiceClient
    {
        /// <summary>
        /// The default endpoint for the DocumentProcessorService service, which is a host of
        /// "documentai.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "documentai.googleapis.com:443";

        /// <summary>The default DocumentProcessorService scopes.</summary>
        /// <remarks>
        /// The default DocumentProcessorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
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
        /// Asynchronously creates a <see cref="DocumentProcessorServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentProcessorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DocumentProcessorServiceClient"/>.</returns>
        public static stt::Task<DocumentProcessorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DocumentProcessorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DocumentProcessorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentProcessorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DocumentProcessorServiceClient"/>.</returns>
        public static DocumentProcessorServiceClient Create() => new DocumentProcessorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DocumentProcessorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DocumentProcessorServiceSettings"/>.</param>
        /// <returns>The created <see cref="DocumentProcessorServiceClient"/>.</returns>
        internal static DocumentProcessorServiceClient Create(grpccore::CallInvoker callInvoker, DocumentProcessorServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DocumentProcessorService.DocumentProcessorServiceClient grpcClient = new DocumentProcessorService.DocumentProcessorServiceClient(callInvoker);
            return new DocumentProcessorServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DocumentProcessorService client</summary>
        public virtual DocumentProcessorService.DocumentProcessorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(ProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocument(new ProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocumentAsync(new ProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocument(new ProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocumentAsync(new ProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public virtual lro::OperationsClient BatchProcessDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchProcessDocuments</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> PollOnceBatchProcessDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessResponse, BatchProcessMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchProcessDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> PollOnceBatchProcessDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessResponse, BatchProcessMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(string name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(string name, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(FetchProcessorTypesRequest request, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(string parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypes(new FetchProcessorTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypesAsync(new FetchProcessorTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(string parent, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypes(new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypesAsync(new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(LocationName parent, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypes(new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypesAsync(new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="parent">
        /// Required. The project of processor type to list.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of Processors.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProcessors(new ListProcessorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of Processors.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProcessorsAsync(new ListProcessorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of Processors.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProcessors(new ListProcessorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of Processors.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProcessorsAsync(new ListProcessorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of Processors.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProcessors(new ListProcessorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of Processors.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProcessorsAsync(new ListProcessorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(CreateProcessorRequest request, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(string parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(string parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(string parent, Processor processor, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(LocationName parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(LocationName parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(LocationName parent, Processor processor, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(gagr::LocationName parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(gagr::LocationName parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the processor.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires [processor_type] and [display_name]
        /// to be set. Also, the processor is under CMEK if CMEK fields are set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(gagr::LocationName parent, Processor processor, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProcessor</c>.</summary>
        public virtual lro::OperationsClient DeleteProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> PollOnceDeleteProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteProcessorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> PollOnceDeleteProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteProcessorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorOperationsClient, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessor(new DeleteProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorAsync(new DeleteProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessor(new DeleteProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorAsync(new DeleteProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableProcessorResponse, EnableProcessorMetadata> EnableProcessor(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> EnableProcessorAsync(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> EnableProcessorAsync(EnableProcessorRequest request, st::CancellationToken cancellationToken) =>
            EnableProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableProcessor</c>.</summary>
        public virtual lro::OperationsClient EnableProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EnableProcessorResponse, EnableProcessorMetadata> PollOnceEnableProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> PollOnceEnableProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableProcessorResponse, DisableProcessorMetadata> DisableProcessor(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> DisableProcessorAsync(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> DisableProcessorAsync(DisableProcessorRequest request, st::CancellationToken cancellationToken) =>
            DisableProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableProcessor</c>.</summary>
        public virtual lro::OperationsClient DisableProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DisableProcessorResponse, DisableProcessorMetadata> PollOnceDisableProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> PollOnceDisableProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReviewDocument</c>.</summary>
        public virtual lro::OperationsClient ReviewDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReviewDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> PollOnceReviewDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReviewDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReviewDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> PollOnceReviewDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReviewDocumentOperationsClient, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(string humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocument(new ReviewDocumentRequest
            {
                HumanReviewConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(string humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocumentAsync(new ReviewDocumentRequest
            {
                HumanReviewConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(string humanReviewConfig, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(humanReviewConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(HumanReviewConfigName humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocument(new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gax::GaxPreconditions.CheckNotNull(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(HumanReviewConfigName humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocumentAsync(new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gax::GaxPreconditions.CheckNotNull(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(HumanReviewConfigName humanReviewConfig, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(humanReviewConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DocumentProcessorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to call Cloud DocumentAI to process documents according to the
    /// processor's definition. Processors are built using state-of-the-art Google
    /// AI such as natural language, computer vision, and translation to extract
    /// structured information from unstructured or semi-structured documents.
    /// </remarks>
    public sealed partial class DocumentProcessorServiceClientImpl : DocumentProcessorServiceClient
    {
        private readonly gaxgrpc::ApiCall<ProcessRequest, ProcessResponse> _callProcessDocument;

        private readonly gaxgrpc::ApiCall<BatchProcessRequest, lro::Operation> _callBatchProcessDocuments;

        private readonly gaxgrpc::ApiCall<FetchProcessorTypesRequest, FetchProcessorTypesResponse> _callFetchProcessorTypes;

        private readonly gaxgrpc::ApiCall<ListProcessorsRequest, ListProcessorsResponse> _callListProcessors;

        private readonly gaxgrpc::ApiCall<CreateProcessorRequest, Processor> _callCreateProcessor;

        private readonly gaxgrpc::ApiCall<DeleteProcessorRequest, lro::Operation> _callDeleteProcessor;

        private readonly gaxgrpc::ApiCall<EnableProcessorRequest, lro::Operation> _callEnableProcessor;

        private readonly gaxgrpc::ApiCall<DisableProcessorRequest, lro::Operation> _callDisableProcessor;

        private readonly gaxgrpc::ApiCall<ReviewDocumentRequest, lro::Operation> _callReviewDocument;

        /// <summary>
        /// Constructs a client wrapper for the DocumentProcessorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DocumentProcessorServiceSettings"/> used within this client.
        /// </param>
        public DocumentProcessorServiceClientImpl(DocumentProcessorService.DocumentProcessorServiceClient grpcClient, DocumentProcessorServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DocumentProcessorServiceSettings effectiveSettings = settings ?? DocumentProcessorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchProcessDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchProcessDocumentsOperationsSettings);
            DeleteProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProcessorOperationsSettings);
            EnableProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableProcessorOperationsSettings);
            DisableProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableProcessorOperationsSettings);
            ReviewDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReviewDocumentOperationsSettings);
            _callProcessDocument = clientHelper.BuildApiCall<ProcessRequest, ProcessResponse>(grpcClient.ProcessDocumentAsync, grpcClient.ProcessDocument, effectiveSettings.ProcessDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callProcessDocument);
            Modify_ProcessDocumentApiCall(ref _callProcessDocument);
            _callBatchProcessDocuments = clientHelper.BuildApiCall<BatchProcessRequest, lro::Operation>(grpcClient.BatchProcessDocumentsAsync, grpcClient.BatchProcessDocuments, effectiveSettings.BatchProcessDocumentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBatchProcessDocuments);
            Modify_BatchProcessDocumentsApiCall(ref _callBatchProcessDocuments);
            _callFetchProcessorTypes = clientHelper.BuildApiCall<FetchProcessorTypesRequest, FetchProcessorTypesResponse>(grpcClient.FetchProcessorTypesAsync, grpcClient.FetchProcessorTypes, effectiveSettings.FetchProcessorTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchProcessorTypes);
            Modify_FetchProcessorTypesApiCall(ref _callFetchProcessorTypes);
            _callListProcessors = clientHelper.BuildApiCall<ListProcessorsRequest, ListProcessorsResponse>(grpcClient.ListProcessorsAsync, grpcClient.ListProcessors, effectiveSettings.ListProcessorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcessors);
            Modify_ListProcessorsApiCall(ref _callListProcessors);
            _callCreateProcessor = clientHelper.BuildApiCall<CreateProcessorRequest, Processor>(grpcClient.CreateProcessorAsync, grpcClient.CreateProcessor, effectiveSettings.CreateProcessorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProcessor);
            Modify_CreateProcessorApiCall(ref _callCreateProcessor);
            _callDeleteProcessor = clientHelper.BuildApiCall<DeleteProcessorRequest, lro::Operation>(grpcClient.DeleteProcessorAsync, grpcClient.DeleteProcessor, effectiveSettings.DeleteProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProcessor);
            Modify_DeleteProcessorApiCall(ref _callDeleteProcessor);
            _callEnableProcessor = clientHelper.BuildApiCall<EnableProcessorRequest, lro::Operation>(grpcClient.EnableProcessorAsync, grpcClient.EnableProcessor, effectiveSettings.EnableProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableProcessor);
            Modify_EnableProcessorApiCall(ref _callEnableProcessor);
            _callDisableProcessor = clientHelper.BuildApiCall<DisableProcessorRequest, lro::Operation>(grpcClient.DisableProcessorAsync, grpcClient.DisableProcessor, effectiveSettings.DisableProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableProcessor);
            Modify_DisableProcessorApiCall(ref _callDisableProcessor);
            _callReviewDocument = clientHelper.BuildApiCall<ReviewDocumentRequest, lro::Operation>(grpcClient.ReviewDocumentAsync, grpcClient.ReviewDocument, effectiveSettings.ReviewDocumentSettings).WithGoogleRequestParam("human_review_config", request => request.HumanReviewConfig);
            Modify_ApiCall(ref _callReviewDocument);
            Modify_ReviewDocumentApiCall(ref _callReviewDocument);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ProcessDocumentApiCall(ref gaxgrpc::ApiCall<ProcessRequest, ProcessResponse> call);

        partial void Modify_BatchProcessDocumentsApiCall(ref gaxgrpc::ApiCall<BatchProcessRequest, lro::Operation> call);

        partial void Modify_FetchProcessorTypesApiCall(ref gaxgrpc::ApiCall<FetchProcessorTypesRequest, FetchProcessorTypesResponse> call);

        partial void Modify_ListProcessorsApiCall(ref gaxgrpc::ApiCall<ListProcessorsRequest, ListProcessorsResponse> call);

        partial void Modify_CreateProcessorApiCall(ref gaxgrpc::ApiCall<CreateProcessorRequest, Processor> call);

        partial void Modify_DeleteProcessorApiCall(ref gaxgrpc::ApiCall<DeleteProcessorRequest, lro::Operation> call);

        partial void Modify_EnableProcessorApiCall(ref gaxgrpc::ApiCall<EnableProcessorRequest, lro::Operation> call);

        partial void Modify_DisableProcessorApiCall(ref gaxgrpc::ApiCall<DisableProcessorRequest, lro::Operation> call);

        partial void Modify_ReviewDocumentApiCall(ref gaxgrpc::ApiCall<ReviewDocumentRequest, lro::Operation> call);

        partial void OnConstruction(DocumentProcessorService.DocumentProcessorServiceClient grpcClient, DocumentProcessorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentProcessorService client</summary>
        public override DocumentProcessorService.DocumentProcessorServiceClient GrpcClient { get; }

        partial void Modify_ProcessRequest(ref ProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchProcessRequest(ref BatchProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchProcessorTypesRequest(ref FetchProcessorTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessorsRequest(ref ListProcessorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProcessorRequest(ref CreateProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProcessorRequest(ref DeleteProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableProcessorRequest(ref EnableProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableProcessorRequest(ref DisableProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReviewDocumentRequest(ref ReviewDocumentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProcessResponse ProcessDocument(ProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessRequest(ref request, ref callSettings);
            return _callProcessDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessRequest(ref request, ref callSettings);
            return _callProcessDocument.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public override lro::OperationsClient BatchProcessDocumentsOperationsClient { get; }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessResponse, BatchProcessMetadata>(_callBatchProcessDocuments.Sync(request, callSettings), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessResponse, BatchProcessMetadata>(await _callBatchProcessDocuments.Async(request, callSettings).ConfigureAwait(false), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchProcessorTypesResponse FetchProcessorTypes(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchProcessorTypesRequest(ref request, ref callSettings);
            return _callFetchProcessorTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches processor types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchProcessorTypesRequest(ref request, ref callSettings);
            return _callFetchProcessorTypes.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessorsRequest, ListProcessorsResponse, Processor>(_callListProcessors, request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessorsRequest, ListProcessorsResponse, Processor>(_callListProcessors, request, callSettings);
        }

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Processor CreateProcessor(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessorRequest(ref request, ref callSettings);
            return _callCreateProcessor.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a processor from the type processor that the user chose.
        /// The processor will be at "ENABLED" state by default after its creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Processor> CreateProcessorAsync(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessorRequest(ref request, ref callSettings);
            return _callCreateProcessor.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteProcessor</c>.</summary>
        public override lro::OperationsClient DeleteProcessorOperationsClient { get; }

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteProcessorMetadata>(_callDeleteProcessor.Sync(request, callSettings), DeleteProcessorOperationsClient);
        }

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteProcessorMetadata>(await _callDeleteProcessor.Async(request, callSettings).ConfigureAwait(false), DeleteProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EnableProcessor</c>.</summary>
        public override lro::OperationsClient EnableProcessorOperationsClient { get; }

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EnableProcessorResponse, EnableProcessorMetadata> EnableProcessor(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>(_callEnableProcessor.Sync(request, callSettings), EnableProcessorOperationsClient);
        }

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> EnableProcessorAsync(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>(await _callEnableProcessor.Async(request, callSettings).ConfigureAwait(false), EnableProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableProcessor</c>.</summary>
        public override lro::OperationsClient DisableProcessorOperationsClient { get; }

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DisableProcessorResponse, DisableProcessorMetadata> DisableProcessor(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>(_callDisableProcessor.Sync(request, callSettings), DisableProcessorOperationsClient);
        }

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> DisableProcessorAsync(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>(await _callDisableProcessor.Async(request, callSettings).ConfigureAwait(false), DisableProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReviewDocument</c>.</summary>
        public override lro::OperationsClient ReviewDocumentOperationsClient { get; }

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReviewDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>(_callReviewDocument.Sync(request, callSettings), ReviewDocumentOperationsClient);
        }

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReviewDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>(await _callReviewDocument.Async(request, callSettings).ConfigureAwait(false), ReviewDocumentOperationsClient);
        }
    }

    public partial class ListProcessorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessorsResponse : gaxgrpc::IPageResponse<Processor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Processor> GetEnumerator() => Processors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DocumentProcessorService
    {
        public partial class DocumentProcessorServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
