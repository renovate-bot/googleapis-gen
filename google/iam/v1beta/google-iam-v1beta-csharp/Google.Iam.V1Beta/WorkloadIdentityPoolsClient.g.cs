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

namespace Google.Iam.V1Beta
{
    /// <summary>Settings for <see cref="WorkloadIdentityPoolsClient"/> instances.</summary>
    public sealed partial class WorkloadIdentityPoolsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkloadIdentityPoolsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkloadIdentityPoolsSettings"/>.</returns>
        public static WorkloadIdentityPoolsSettings GetDefault() => new WorkloadIdentityPoolsSettings();

        /// <summary>
        /// Constructs a new <see cref="WorkloadIdentityPoolsSettings"/> object with default settings.
        /// </summary>
        public WorkloadIdentityPoolsSettings()
        {
        }

        private WorkloadIdentityPoolsSettings(WorkloadIdentityPoolsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListWorkloadIdentityPoolsSettings = existing.ListWorkloadIdentityPoolsSettings;
            GetWorkloadIdentityPoolSettings = existing.GetWorkloadIdentityPoolSettings;
            CreateWorkloadIdentityPoolSettings = existing.CreateWorkloadIdentityPoolSettings;
            CreateWorkloadIdentityPoolOperationsSettings = existing.CreateWorkloadIdentityPoolOperationsSettings.Clone();
            UpdateWorkloadIdentityPoolSettings = existing.UpdateWorkloadIdentityPoolSettings;
            UpdateWorkloadIdentityPoolOperationsSettings = existing.UpdateWorkloadIdentityPoolOperationsSettings.Clone();
            DeleteWorkloadIdentityPoolSettings = existing.DeleteWorkloadIdentityPoolSettings;
            DeleteWorkloadIdentityPoolOperationsSettings = existing.DeleteWorkloadIdentityPoolOperationsSettings.Clone();
            UndeleteWorkloadIdentityPoolSettings = existing.UndeleteWorkloadIdentityPoolSettings;
            UndeleteWorkloadIdentityPoolOperationsSettings = existing.UndeleteWorkloadIdentityPoolOperationsSettings.Clone();
            ListWorkloadIdentityPoolProvidersSettings = existing.ListWorkloadIdentityPoolProvidersSettings;
            GetWorkloadIdentityPoolProviderSettings = existing.GetWorkloadIdentityPoolProviderSettings;
            CreateWorkloadIdentityPoolProviderSettings = existing.CreateWorkloadIdentityPoolProviderSettings;
            CreateWorkloadIdentityPoolProviderOperationsSettings = existing.CreateWorkloadIdentityPoolProviderOperationsSettings.Clone();
            UpdateWorkloadIdentityPoolProviderSettings = existing.UpdateWorkloadIdentityPoolProviderSettings;
            UpdateWorkloadIdentityPoolProviderOperationsSettings = existing.UpdateWorkloadIdentityPoolProviderOperationsSettings.Clone();
            DeleteWorkloadIdentityPoolProviderSettings = existing.DeleteWorkloadIdentityPoolProviderSettings;
            DeleteWorkloadIdentityPoolProviderOperationsSettings = existing.DeleteWorkloadIdentityPoolProviderOperationsSettings.Clone();
            UndeleteWorkloadIdentityPoolProviderSettings = existing.UndeleteWorkloadIdentityPoolProviderSettings;
            UndeleteWorkloadIdentityPoolProviderOperationsSettings = existing.UndeleteWorkloadIdentityPoolProviderOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(WorkloadIdentityPoolsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.ListWorkloadIdentityPools</c> and
        /// <c>WorkloadIdentityPoolsClient.ListWorkloadIdentityPoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkloadIdentityPoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.GetWorkloadIdentityPool</c> and
        /// <c>WorkloadIdentityPoolsClient.GetWorkloadIdentityPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkloadIdentityPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPool</c> and
        /// <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkloadIdentityPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPool</c>
        /// and <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPoolAsync</c>.
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
        public lro::OperationsSettings CreateWorkloadIdentityPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPool</c> and
        /// <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkloadIdentityPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPool</c>
        /// and <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPoolAsync</c>.
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
        public lro::OperationsSettings UpdateWorkloadIdentityPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPool</c> and
        /// <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkloadIdentityPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPool</c>
        /// and <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPoolAsync</c>.
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
        public lro::OperationsSettings DeleteWorkloadIdentityPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPool</c> and
        /// <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteWorkloadIdentityPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPool</c>
        /// and <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolAsync</c>.
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
        public lro::OperationsSettings UndeleteWorkloadIdentityPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.ListWorkloadIdentityPoolProviders</c> and
        /// <c>WorkloadIdentityPoolsClient.ListWorkloadIdentityPoolProvidersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkloadIdentityPoolProvidersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.GetWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.GetWorkloadIdentityPoolProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkloadIdentityPoolProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPoolProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkloadIdentityPoolProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.CreateWorkloadIdentityPoolProviderAsync</c>.
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
        public lro::OperationsSettings CreateWorkloadIdentityPoolProviderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkloadIdentityPoolProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProviderAsync</c>.
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
        public lro::OperationsSettings UpdateWorkloadIdentityPoolProviderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkloadIdentityPoolProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProviderAsync</c>.
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
        public lro::OperationsSettings DeleteWorkloadIdentityPoolProviderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteWorkloadIdentityPoolProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProvider</c> and
        /// <c>WorkloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProviderAsync</c>.
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
        public lro::OperationsSettings UndeleteWorkloadIdentityPoolProviderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkloadIdentityPoolsSettings"/> object.</returns>
        public WorkloadIdentityPoolsSettings Clone() => new WorkloadIdentityPoolsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkloadIdentityPoolsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class WorkloadIdentityPoolsClientBuilder : gaxgrpc::ClientBuilderBase<WorkloadIdentityPoolsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkloadIdentityPoolsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkloadIdentityPoolsClientBuilder()
        {
            UseJwtAccessWithScopes = WorkloadIdentityPoolsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref WorkloadIdentityPoolsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkloadIdentityPoolsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkloadIdentityPoolsClient Build()
        {
            WorkloadIdentityPoolsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkloadIdentityPoolsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkloadIdentityPoolsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkloadIdentityPoolsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkloadIdentityPoolsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<WorkloadIdentityPoolsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkloadIdentityPoolsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => WorkloadIdentityPoolsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => WorkloadIdentityPoolsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkloadIdentityPoolsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>WorkloadIdentityPools client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages WorkloadIdentityPools.
    /// </remarks>
    public abstract partial class WorkloadIdentityPoolsClient
    {
        /// <summary>
        /// The default endpoint for the WorkloadIdentityPools service, which is a host of "iam.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam.googleapis.com:443";

        /// <summary>The default WorkloadIdentityPools scopes.</summary>
        /// <remarks>
        /// The default WorkloadIdentityPools scopes are:
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
        /// Asynchronously creates a <see cref="WorkloadIdentityPoolsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WorkloadIdentityPoolsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkloadIdentityPoolsClient"/>.</returns>
        public static stt::Task<WorkloadIdentityPoolsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkloadIdentityPoolsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkloadIdentityPoolsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WorkloadIdentityPoolsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkloadIdentityPoolsClient"/>.</returns>
        public static WorkloadIdentityPoolsClient Create() => new WorkloadIdentityPoolsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkloadIdentityPoolsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkloadIdentityPoolsSettings"/>.</param>
        /// <returns>The created <see cref="WorkloadIdentityPoolsClient"/>.</returns>
        internal static WorkloadIdentityPoolsClient Create(grpccore::CallInvoker callInvoker, WorkloadIdentityPoolsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkloadIdentityPools.WorkloadIdentityPoolsClient grpcClient = new WorkloadIdentityPools.WorkloadIdentityPoolsClient(callInvoker);
            return new WorkloadIdentityPoolsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC WorkloadIdentityPools client</summary>
        public virtual WorkloadIdentityPools.WorkloadIdentityPoolsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPools(ListWorkloadIdentityPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPoolsAsync(ListWorkloadIdentityPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to list pools for.
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
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPools(new ListWorkloadIdentityPoolsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to list pools for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPoolsAsync(new ListWorkloadIdentityPoolsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to list pools for.
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
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPools(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPools(new ListWorkloadIdentityPoolsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to list pools for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPoolsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPoolsAsync(new ListWorkloadIdentityPoolsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadIdentityPool GetWorkloadIdentityPool(GetWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(GetWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(GetWorkloadIdentityPoolRequest request, st::CancellationToken cancellationToken) =>
            GetWorkloadIdentityPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadIdentityPool GetWorkloadIdentityPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPool(new GetWorkloadIdentityPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPoolAsync(new GetWorkloadIdentityPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkloadIdentityPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadIdentityPool GetWorkloadIdentityPool(WorkloadIdentityPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPool(new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPoolAsync(new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name, st::CancellationToken cancellationToken) =>
            GetWorkloadIdentityPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> CreateWorkloadIdentityPool(CreateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(CreateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(CreateWorkloadIdentityPoolRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkloadIdentityPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkloadIdentityPool</c>.</summary>
        public virtual lro::OperationsClient CreateWorkloadIdentityPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> PollOnceCreateWorkloadIdentityPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> PollOnceCreateWorkloadIdentityPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create the pool in. The only supported
        /// location is `global`.
        /// </param>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to create.
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// Required. The ID to use for the pool, which becomes the
        /// final component of the resource name. This value should be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> CreateWorkloadIdentityPool(string parent, WorkloadIdentityPool workloadIdentityPool, string workloadIdentityPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPool(new CreateWorkloadIdentityPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkloadIdentityPool = gax::GaxPreconditions.CheckNotNull(workloadIdentityPool, nameof(workloadIdentityPool)),
                WorkloadIdentityPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create the pool in. The only supported
        /// location is `global`.
        /// </param>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to create.
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// Required. The ID to use for the pool, which becomes the
        /// final component of the resource name. This value should be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(string parent, WorkloadIdentityPool workloadIdentityPool, string workloadIdentityPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPoolAsync(new CreateWorkloadIdentityPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkloadIdentityPool = gax::GaxPreconditions.CheckNotNull(workloadIdentityPool, nameof(workloadIdentityPool)),
                WorkloadIdentityPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create the pool in. The only supported
        /// location is `global`.
        /// </param>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to create.
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// Required. The ID to use for the pool, which becomes the
        /// final component of the resource name. This value should be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(string parent, WorkloadIdentityPool workloadIdentityPool, string workloadIdentityPoolId, st::CancellationToken cancellationToken) =>
            CreateWorkloadIdentityPoolAsync(parent, workloadIdentityPool, workloadIdentityPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create the pool in. The only supported
        /// location is `global`.
        /// </param>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to create.
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// Required. The ID to use for the pool, which becomes the
        /// final component of the resource name. This value should be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> CreateWorkloadIdentityPool(gagr::ProjectName parent, WorkloadIdentityPool workloadIdentityPool, string workloadIdentityPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPool(new CreateWorkloadIdentityPoolRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkloadIdentityPool = gax::GaxPreconditions.CheckNotNull(workloadIdentityPool, nameof(workloadIdentityPool)),
                WorkloadIdentityPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create the pool in. The only supported
        /// location is `global`.
        /// </param>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to create.
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// Required. The ID to use for the pool, which becomes the
        /// final component of the resource name. This value should be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(gagr::ProjectName parent, WorkloadIdentityPool workloadIdentityPool, string workloadIdentityPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPoolAsync(new CreateWorkloadIdentityPoolRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkloadIdentityPool = gax::GaxPreconditions.CheckNotNull(workloadIdentityPool, nameof(workloadIdentityPool)),
                WorkloadIdentityPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create the pool in. The only supported
        /// location is `global`.
        /// </param>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to create.
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// Required. The ID to use for the pool, which becomes the
        /// final component of the resource name. This value should be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(gagr::ProjectName parent, WorkloadIdentityPool workloadIdentityPool, string workloadIdentityPoolId, st::CancellationToken cancellationToken) =>
            CreateWorkloadIdentityPoolAsync(parent, workloadIdentityPool, workloadIdentityPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UpdateWorkloadIdentityPool(UpdateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UpdateWorkloadIdentityPoolAsync(UpdateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UpdateWorkloadIdentityPoolAsync(UpdateWorkloadIdentityPoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkloadIdentityPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkloadIdentityPool</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkloadIdentityPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> PollOnceUpdateWorkloadIdentityPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> PollOnceUpdateWorkloadIdentityPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to update. The `name` field is used to identify the pool.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UpdateWorkloadIdentityPool(WorkloadIdentityPool workloadIdentityPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkloadIdentityPool(new UpdateWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPool = gax::GaxPreconditions.CheckNotNull(workloadIdentityPool, nameof(workloadIdentityPool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to update. The `name` field is used to identify the pool.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UpdateWorkloadIdentityPoolAsync(WorkloadIdentityPool workloadIdentityPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkloadIdentityPoolAsync(new UpdateWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPool = gax::GaxPreconditions.CheckNotNull(workloadIdentityPool, nameof(workloadIdentityPool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="workloadIdentityPool">
        /// Required. The pool to update. The `name` field is used to identify the pool.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UpdateWorkloadIdentityPoolAsync(WorkloadIdentityPool workloadIdentityPool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkloadIdentityPoolAsync(workloadIdentityPool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> DeleteWorkloadIdentityPool(DeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(DeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(DeleteWorkloadIdentityPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkloadIdentityPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkloadIdentityPool</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkloadIdentityPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> PollOnceDeleteWorkloadIdentityPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> PollOnceDeleteWorkloadIdentityPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> DeleteWorkloadIdentityPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPool(new DeleteWorkloadIdentityPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPoolAsync(new DeleteWorkloadIdentityPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadIdentityPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> DeleteWorkloadIdentityPool(WorkloadIdentityPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPool(new DeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPoolAsync(new DeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadIdentityPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UndeleteWorkloadIdentityPool(UndeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(UndeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(UndeleteWorkloadIdentityPoolRequest request, st::CancellationToken cancellationToken) =>
            UndeleteWorkloadIdentityPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteWorkloadIdentityPool</c>.</summary>
        public virtual lro::OperationsClient UndeleteWorkloadIdentityPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> PollOnceUndeleteWorkloadIdentityPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteWorkloadIdentityPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> PollOnceUndeleteWorkloadIdentityPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteWorkloadIdentityPoolOperationsClient, callSettings);

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UndeleteWorkloadIdentityPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPool(new UndeleteWorkloadIdentityPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPoolAsync(new UndeleteWorkloadIdentityPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to undelete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteWorkloadIdentityPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UndeleteWorkloadIdentityPool(WorkloadIdentityPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPool(new UndeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPoolAsync(new UndeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pool to undelete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name, st::CancellationToken cancellationToken) =>
            UndeleteWorkloadIdentityPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProviders(ListWorkloadIdentityPoolProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProvidersAsync(ListWorkloadIdentityPoolProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to list providers for.
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
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProviders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPoolProviders(new ListWorkloadIdentityPoolProvidersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to list providers for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProvidersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPoolProvidersAsync(new ListWorkloadIdentityPoolProvidersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to list providers for.
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
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProviders(WorkloadIdentityPoolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPoolProviders(new ListWorkloadIdentityPoolProvidersRequest
            {
                ParentAsWorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to list providers for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProvidersAsync(WorkloadIdentityPoolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListWorkloadIdentityPoolProvidersAsync(new ListWorkloadIdentityPoolProvidersRequest
            {
                ParentAsWorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadIdentityPoolProvider GetWorkloadIdentityPoolProvider(GetWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(GetWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(GetWorkloadIdentityPoolProviderRequest request, st::CancellationToken cancellationToken) =>
            GetWorkloadIdentityPoolProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadIdentityPoolProvider GetWorkloadIdentityPoolProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPoolProvider(new GetWorkloadIdentityPoolProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPoolProviderAsync(new GetWorkloadIdentityPoolProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkloadIdentityPoolProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadIdentityPoolProvider GetWorkloadIdentityPoolProvider(WorkloadIdentityPoolProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPoolProvider(new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadIdentityPoolProviderAsync(new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name, st::CancellationToken cancellationToken) =>
            GetWorkloadIdentityPoolProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> CreateWorkloadIdentityPoolProvider(CreateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(CreateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(CreateWorkloadIdentityPoolProviderRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkloadIdentityPoolProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkloadIdentityPoolProvider</c>.</summary>
        public virtual lro::OperationsClient CreateWorkloadIdentityPoolProviderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> PollOnceCreateWorkloadIdentityPoolProvider(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> PollOnceCreateWorkloadIdentityPoolProviderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to create this provider in.
        /// </param>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to create.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// Required. The ID for the provider, which becomes the
        /// final component of the resource name. This value must be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> CreateWorkloadIdentityPoolProvider(string parent, WorkloadIdentityPoolProvider workloadIdentityPoolProvider, string workloadIdentityPoolProviderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPoolProvider(new CreateWorkloadIdentityPoolProviderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkloadIdentityPoolProvider = gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProvider, nameof(workloadIdentityPoolProvider)),
                WorkloadIdentityPoolProviderId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to create this provider in.
        /// </param>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to create.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// Required. The ID for the provider, which becomes the
        /// final component of the resource name. This value must be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(string parent, WorkloadIdentityPoolProvider workloadIdentityPoolProvider, string workloadIdentityPoolProviderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPoolProviderAsync(new CreateWorkloadIdentityPoolProviderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkloadIdentityPoolProvider = gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProvider, nameof(workloadIdentityPoolProvider)),
                WorkloadIdentityPoolProviderId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to create this provider in.
        /// </param>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to create.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// Required. The ID for the provider, which becomes the
        /// final component of the resource name. This value must be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(string parent, WorkloadIdentityPoolProvider workloadIdentityPoolProvider, string workloadIdentityPoolProviderId, st::CancellationToken cancellationToken) =>
            CreateWorkloadIdentityPoolProviderAsync(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to create this provider in.
        /// </param>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to create.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// Required. The ID for the provider, which becomes the
        /// final component of the resource name. This value must be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> CreateWorkloadIdentityPoolProvider(WorkloadIdentityPoolName parent, WorkloadIdentityPoolProvider workloadIdentityPoolProvider, string workloadIdentityPoolProviderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPoolProvider(new CreateWorkloadIdentityPoolProviderRequest
            {
                ParentAsWorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkloadIdentityPoolProvider = gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProvider, nameof(workloadIdentityPoolProvider)),
                WorkloadIdentityPoolProviderId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to create this provider in.
        /// </param>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to create.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// Required. The ID for the provider, which becomes the
        /// final component of the resource name. This value must be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolName parent, WorkloadIdentityPoolProvider workloadIdentityPoolProvider, string workloadIdentityPoolProviderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadIdentityPoolProviderAsync(new CreateWorkloadIdentityPoolProviderRequest
            {
                ParentAsWorkloadIdentityPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkloadIdentityPoolProvider = gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProvider, nameof(workloadIdentityPoolProvider)),
                WorkloadIdentityPoolProviderId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="parent">
        /// Required. The pool to create this provider in.
        /// </param>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to create.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// Required. The ID for the provider, which becomes the
        /// final component of the resource name. This value must be 4-32 characters,
        /// and may contain the characters [a-z0-9-]. The prefix `gcp-` is
        /// reserved for use by Google, and may not be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolName parent, WorkloadIdentityPoolProvider workloadIdentityPoolProvider, string workloadIdentityPoolProviderId, st::CancellationToken cancellationToken) =>
            CreateWorkloadIdentityPoolProviderAsync(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UpdateWorkloadIdentityPoolProvider(UpdateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UpdateWorkloadIdentityPoolProviderAsync(UpdateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UpdateWorkloadIdentityPoolProviderAsync(UpdateWorkloadIdentityPoolProviderRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkloadIdentityPoolProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkloadIdentityPoolProvider</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkloadIdentityPoolProviderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> PollOnceUpdateWorkloadIdentityPoolProvider(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> PollOnceUpdateWorkloadIdentityPoolProviderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UpdateWorkloadIdentityPoolProvider(WorkloadIdentityPoolProvider workloadIdentityPoolProvider, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkloadIdentityPoolProvider(new UpdateWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProvider = gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProvider, nameof(workloadIdentityPoolProvider)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UpdateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProvider workloadIdentityPoolProvider, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkloadIdentityPoolProviderAsync(new UpdateWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProvider = gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProvider, nameof(workloadIdentityPoolProvider)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="workloadIdentityPoolProvider">
        /// Required. The provider to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UpdateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProvider workloadIdentityPoolProvider, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkloadIdentityPoolProviderAsync(workloadIdentityPoolProvider, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> DeleteWorkloadIdentityPoolProvider(DeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(DeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(DeleteWorkloadIdentityPoolProviderRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkloadIdentityPoolProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkloadIdentityPoolProvider</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkloadIdentityPoolProviderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> PollOnceDeleteWorkloadIdentityPoolProvider(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> PollOnceDeleteWorkloadIdentityPoolProviderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> DeleteWorkloadIdentityPoolProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPoolProvider(new DeleteWorkloadIdentityPoolProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPoolProviderAsync(new DeleteWorkloadIdentityPoolProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadIdentityPoolProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> DeleteWorkloadIdentityPoolProvider(WorkloadIdentityPoolProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPoolProvider(new DeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadIdentityPoolProviderAsync(new DeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadIdentityPoolProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UndeleteWorkloadIdentityPoolProvider(UndeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(UndeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(UndeleteWorkloadIdentityPoolProviderRequest request, st::CancellationToken cancellationToken) =>
            UndeleteWorkloadIdentityPoolProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteWorkloadIdentityPoolProvider</c>.</summary>
        public virtual lro::OperationsClient UndeleteWorkloadIdentityPoolProviderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> PollOnceUndeleteWorkloadIdentityPoolProvider(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteWorkloadIdentityPoolProvider</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> PollOnceUndeleteWorkloadIdentityPoolProviderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteWorkloadIdentityPoolProviderOperationsClient, callSettings);

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UndeleteWorkloadIdentityPoolProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPoolProvider(new UndeleteWorkloadIdentityPoolProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPoolProviderAsync(new UndeleteWorkloadIdentityPoolProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to undelete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteWorkloadIdentityPoolProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UndeleteWorkloadIdentityPoolProvider(WorkloadIdentityPoolProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPoolProvider(new UndeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to undelete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteWorkloadIdentityPoolProviderAsync(new UndeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to undelete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name, st::CancellationToken cancellationToken) =>
            UndeleteWorkloadIdentityPoolProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WorkloadIdentityPools client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages WorkloadIdentityPools.
    /// </remarks>
    public sealed partial class WorkloadIdentityPoolsClientImpl : WorkloadIdentityPoolsClient
    {
        private readonly gaxgrpc::ApiCall<ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsResponse> _callListWorkloadIdentityPools;

        private readonly gaxgrpc::ApiCall<GetWorkloadIdentityPoolRequest, WorkloadIdentityPool> _callGetWorkloadIdentityPool;

        private readonly gaxgrpc::ApiCall<CreateWorkloadIdentityPoolRequest, lro::Operation> _callCreateWorkloadIdentityPool;

        private readonly gaxgrpc::ApiCall<UpdateWorkloadIdentityPoolRequest, lro::Operation> _callUpdateWorkloadIdentityPool;

        private readonly gaxgrpc::ApiCall<DeleteWorkloadIdentityPoolRequest, lro::Operation> _callDeleteWorkloadIdentityPool;

        private readonly gaxgrpc::ApiCall<UndeleteWorkloadIdentityPoolRequest, lro::Operation> _callUndeleteWorkloadIdentityPool;

        private readonly gaxgrpc::ApiCall<ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersResponse> _callListWorkloadIdentityPoolProviders;

        private readonly gaxgrpc::ApiCall<GetWorkloadIdentityPoolProviderRequest, WorkloadIdentityPoolProvider> _callGetWorkloadIdentityPoolProvider;

        private readonly gaxgrpc::ApiCall<CreateWorkloadIdentityPoolProviderRequest, lro::Operation> _callCreateWorkloadIdentityPoolProvider;

        private readonly gaxgrpc::ApiCall<UpdateWorkloadIdentityPoolProviderRequest, lro::Operation> _callUpdateWorkloadIdentityPoolProvider;

        private readonly gaxgrpc::ApiCall<DeleteWorkloadIdentityPoolProviderRequest, lro::Operation> _callDeleteWorkloadIdentityPoolProvider;

        private readonly gaxgrpc::ApiCall<UndeleteWorkloadIdentityPoolProviderRequest, lro::Operation> _callUndeleteWorkloadIdentityPoolProvider;

        /// <summary>
        /// Constructs a client wrapper for the WorkloadIdentityPools service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkloadIdentityPoolsSettings"/> used within this client.</param>
        public WorkloadIdentityPoolsClientImpl(WorkloadIdentityPools.WorkloadIdentityPoolsClient grpcClient, WorkloadIdentityPoolsSettings settings)
        {
            GrpcClient = grpcClient;
            WorkloadIdentityPoolsSettings effectiveSettings = settings ?? WorkloadIdentityPoolsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateWorkloadIdentityPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkloadIdentityPoolOperationsSettings);
            UpdateWorkloadIdentityPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkloadIdentityPoolOperationsSettings);
            DeleteWorkloadIdentityPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkloadIdentityPoolOperationsSettings);
            UndeleteWorkloadIdentityPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteWorkloadIdentityPoolOperationsSettings);
            CreateWorkloadIdentityPoolProviderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkloadIdentityPoolProviderOperationsSettings);
            UpdateWorkloadIdentityPoolProviderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkloadIdentityPoolProviderOperationsSettings);
            DeleteWorkloadIdentityPoolProviderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkloadIdentityPoolProviderOperationsSettings);
            UndeleteWorkloadIdentityPoolProviderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteWorkloadIdentityPoolProviderOperationsSettings);
            _callListWorkloadIdentityPools = clientHelper.BuildApiCall<ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsResponse>(grpcClient.ListWorkloadIdentityPoolsAsync, grpcClient.ListWorkloadIdentityPools, effectiveSettings.ListWorkloadIdentityPoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkloadIdentityPools);
            Modify_ListWorkloadIdentityPoolsApiCall(ref _callListWorkloadIdentityPools);
            _callGetWorkloadIdentityPool = clientHelper.BuildApiCall<GetWorkloadIdentityPoolRequest, WorkloadIdentityPool>(grpcClient.GetWorkloadIdentityPoolAsync, grpcClient.GetWorkloadIdentityPool, effectiveSettings.GetWorkloadIdentityPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkloadIdentityPool);
            Modify_GetWorkloadIdentityPoolApiCall(ref _callGetWorkloadIdentityPool);
            _callCreateWorkloadIdentityPool = clientHelper.BuildApiCall<CreateWorkloadIdentityPoolRequest, lro::Operation>(grpcClient.CreateWorkloadIdentityPoolAsync, grpcClient.CreateWorkloadIdentityPool, effectiveSettings.CreateWorkloadIdentityPoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkloadIdentityPool);
            Modify_CreateWorkloadIdentityPoolApiCall(ref _callCreateWorkloadIdentityPool);
            _callUpdateWorkloadIdentityPool = clientHelper.BuildApiCall<UpdateWorkloadIdentityPoolRequest, lro::Operation>(grpcClient.UpdateWorkloadIdentityPoolAsync, grpcClient.UpdateWorkloadIdentityPool, effectiveSettings.UpdateWorkloadIdentityPoolSettings).WithGoogleRequestParam("workload_identity_pool.name", request => request.WorkloadIdentityPool?.Name);
            Modify_ApiCall(ref _callUpdateWorkloadIdentityPool);
            Modify_UpdateWorkloadIdentityPoolApiCall(ref _callUpdateWorkloadIdentityPool);
            _callDeleteWorkloadIdentityPool = clientHelper.BuildApiCall<DeleteWorkloadIdentityPoolRequest, lro::Operation>(grpcClient.DeleteWorkloadIdentityPoolAsync, grpcClient.DeleteWorkloadIdentityPool, effectiveSettings.DeleteWorkloadIdentityPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkloadIdentityPool);
            Modify_DeleteWorkloadIdentityPoolApiCall(ref _callDeleteWorkloadIdentityPool);
            _callUndeleteWorkloadIdentityPool = clientHelper.BuildApiCall<UndeleteWorkloadIdentityPoolRequest, lro::Operation>(grpcClient.UndeleteWorkloadIdentityPoolAsync, grpcClient.UndeleteWorkloadIdentityPool, effectiveSettings.UndeleteWorkloadIdentityPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteWorkloadIdentityPool);
            Modify_UndeleteWorkloadIdentityPoolApiCall(ref _callUndeleteWorkloadIdentityPool);
            _callListWorkloadIdentityPoolProviders = clientHelper.BuildApiCall<ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersResponse>(grpcClient.ListWorkloadIdentityPoolProvidersAsync, grpcClient.ListWorkloadIdentityPoolProviders, effectiveSettings.ListWorkloadIdentityPoolProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkloadIdentityPoolProviders);
            Modify_ListWorkloadIdentityPoolProvidersApiCall(ref _callListWorkloadIdentityPoolProviders);
            _callGetWorkloadIdentityPoolProvider = clientHelper.BuildApiCall<GetWorkloadIdentityPoolProviderRequest, WorkloadIdentityPoolProvider>(grpcClient.GetWorkloadIdentityPoolProviderAsync, grpcClient.GetWorkloadIdentityPoolProvider, effectiveSettings.GetWorkloadIdentityPoolProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkloadIdentityPoolProvider);
            Modify_GetWorkloadIdentityPoolProviderApiCall(ref _callGetWorkloadIdentityPoolProvider);
            _callCreateWorkloadIdentityPoolProvider = clientHelper.BuildApiCall<CreateWorkloadIdentityPoolProviderRequest, lro::Operation>(grpcClient.CreateWorkloadIdentityPoolProviderAsync, grpcClient.CreateWorkloadIdentityPoolProvider, effectiveSettings.CreateWorkloadIdentityPoolProviderSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkloadIdentityPoolProvider);
            Modify_CreateWorkloadIdentityPoolProviderApiCall(ref _callCreateWorkloadIdentityPoolProvider);
            _callUpdateWorkloadIdentityPoolProvider = clientHelper.BuildApiCall<UpdateWorkloadIdentityPoolProviderRequest, lro::Operation>(grpcClient.UpdateWorkloadIdentityPoolProviderAsync, grpcClient.UpdateWorkloadIdentityPoolProvider, effectiveSettings.UpdateWorkloadIdentityPoolProviderSettings).WithGoogleRequestParam("workload_identity_pool_provider.name", request => request.WorkloadIdentityPoolProvider?.Name);
            Modify_ApiCall(ref _callUpdateWorkloadIdentityPoolProvider);
            Modify_UpdateWorkloadIdentityPoolProviderApiCall(ref _callUpdateWorkloadIdentityPoolProvider);
            _callDeleteWorkloadIdentityPoolProvider = clientHelper.BuildApiCall<DeleteWorkloadIdentityPoolProviderRequest, lro::Operation>(grpcClient.DeleteWorkloadIdentityPoolProviderAsync, grpcClient.DeleteWorkloadIdentityPoolProvider, effectiveSettings.DeleteWorkloadIdentityPoolProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkloadIdentityPoolProvider);
            Modify_DeleteWorkloadIdentityPoolProviderApiCall(ref _callDeleteWorkloadIdentityPoolProvider);
            _callUndeleteWorkloadIdentityPoolProvider = clientHelper.BuildApiCall<UndeleteWorkloadIdentityPoolProviderRequest, lro::Operation>(grpcClient.UndeleteWorkloadIdentityPoolProviderAsync, grpcClient.UndeleteWorkloadIdentityPoolProvider, effectiveSettings.UndeleteWorkloadIdentityPoolProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteWorkloadIdentityPoolProvider);
            Modify_UndeleteWorkloadIdentityPoolProviderApiCall(ref _callUndeleteWorkloadIdentityPoolProvider);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListWorkloadIdentityPoolsApiCall(ref gaxgrpc::ApiCall<ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsResponse> call);

        partial void Modify_GetWorkloadIdentityPoolApiCall(ref gaxgrpc::ApiCall<GetWorkloadIdentityPoolRequest, WorkloadIdentityPool> call);

        partial void Modify_CreateWorkloadIdentityPoolApiCall(ref gaxgrpc::ApiCall<CreateWorkloadIdentityPoolRequest, lro::Operation> call);

        partial void Modify_UpdateWorkloadIdentityPoolApiCall(ref gaxgrpc::ApiCall<UpdateWorkloadIdentityPoolRequest, lro::Operation> call);

        partial void Modify_DeleteWorkloadIdentityPoolApiCall(ref gaxgrpc::ApiCall<DeleteWorkloadIdentityPoolRequest, lro::Operation> call);

        partial void Modify_UndeleteWorkloadIdentityPoolApiCall(ref gaxgrpc::ApiCall<UndeleteWorkloadIdentityPoolRequest, lro::Operation> call);

        partial void Modify_ListWorkloadIdentityPoolProvidersApiCall(ref gaxgrpc::ApiCall<ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersResponse> call);

        partial void Modify_GetWorkloadIdentityPoolProviderApiCall(ref gaxgrpc::ApiCall<GetWorkloadIdentityPoolProviderRequest, WorkloadIdentityPoolProvider> call);

        partial void Modify_CreateWorkloadIdentityPoolProviderApiCall(ref gaxgrpc::ApiCall<CreateWorkloadIdentityPoolProviderRequest, lro::Operation> call);

        partial void Modify_UpdateWorkloadIdentityPoolProviderApiCall(ref gaxgrpc::ApiCall<UpdateWorkloadIdentityPoolProviderRequest, lro::Operation> call);

        partial void Modify_DeleteWorkloadIdentityPoolProviderApiCall(ref gaxgrpc::ApiCall<DeleteWorkloadIdentityPoolProviderRequest, lro::Operation> call);

        partial void Modify_UndeleteWorkloadIdentityPoolProviderApiCall(ref gaxgrpc::ApiCall<UndeleteWorkloadIdentityPoolProviderRequest, lro::Operation> call);

        partial void OnConstruction(WorkloadIdentityPools.WorkloadIdentityPoolsClient grpcClient, WorkloadIdentityPoolsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WorkloadIdentityPools client</summary>
        public override WorkloadIdentityPools.WorkloadIdentityPoolsClient GrpcClient { get; }

        partial void Modify_ListWorkloadIdentityPoolsRequest(ref ListWorkloadIdentityPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkloadIdentityPoolRequest(ref GetWorkloadIdentityPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkloadIdentityPoolRequest(ref CreateWorkloadIdentityPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkloadIdentityPoolRequest(ref UpdateWorkloadIdentityPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkloadIdentityPoolRequest(ref DeleteWorkloadIdentityPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteWorkloadIdentityPoolRequest(ref UndeleteWorkloadIdentityPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkloadIdentityPoolProvidersRequest(ref ListWorkloadIdentityPoolProvidersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkloadIdentityPoolProviderRequest(ref GetWorkloadIdentityPoolProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkloadIdentityPoolProviderRequest(ref CreateWorkloadIdentityPoolProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkloadIdentityPoolProviderRequest(ref UpdateWorkloadIdentityPoolProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkloadIdentityPoolProviderRequest(ref DeleteWorkloadIdentityPoolProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteWorkloadIdentityPoolProviderRequest(ref UndeleteWorkloadIdentityPoolProviderRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPools(ListWorkloadIdentityPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadIdentityPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool>(_callListWorkloadIdentityPools, request, callSettings);
        }

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
        /// project. If `show_deleted` is set to `true`, then deleted pools are also
        /// listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> ListWorkloadIdentityPoolsAsync(ListWorkloadIdentityPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadIdentityPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool>(_callListWorkloadIdentityPools, request, callSettings);
        }

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkloadIdentityPool GetWorkloadIdentityPool(GetWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return _callGetWorkloadIdentityPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkloadIdentityPool> GetWorkloadIdentityPoolAsync(GetWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return _callGetWorkloadIdentityPool.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkloadIdentityPool</c>.</summary>
        public override lro::OperationsClient CreateWorkloadIdentityPoolOperationsClient { get; }

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> CreateWorkloadIdentityPool(CreateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(_callCreateWorkloadIdentityPool.Sync(request, callSettings), CreateWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted pool until 30 days after deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> CreateWorkloadIdentityPoolAsync(CreateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(await _callCreateWorkloadIdentityPool.Async(request, callSettings).ConfigureAwait(false), CreateWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkloadIdentityPool</c>.</summary>
        public override lro::OperationsClient UpdateWorkloadIdentityPoolOperationsClient { get; }

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UpdateWorkloadIdentityPool(UpdateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(_callUpdateWorkloadIdentityPool.Sync(request, callSettings), UpdateWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UpdateWorkloadIdentityPoolAsync(UpdateWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(await _callUpdateWorkloadIdentityPool.Async(request, callSettings).ConfigureAwait(false), UpdateWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkloadIdentityPool</c>.</summary>
        public override lro::OperationsClient DeleteWorkloadIdentityPoolOperationsClient { get; }

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> DeleteWorkloadIdentityPool(DeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(_callDeleteWorkloadIdentityPool.Sync(request, callSettings), DeleteWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot use a deleted pool to exchange external
        /// credentials for Google Cloud credentials. However, deletion does
        /// not revoke credentials that have already been issued.
        /// Credentials issued for a deleted pool do not grant access to resources.
        /// If the pool is undeleted, and the credentials are not expired, they
        /// grant access again.
        /// You can undelete a pool for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted pools. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> DeleteWorkloadIdentityPoolAsync(DeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(await _callDeleteWorkloadIdentityPool.Async(request, callSettings).ConfigureAwait(false), DeleteWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteWorkloadIdentityPool</c>.</summary>
        public override lro::OperationsClient UndeleteWorkloadIdentityPoolOperationsClient { get; }

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> UndeleteWorkloadIdentityPool(UndeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(_callUndeleteWorkloadIdentityPool.Sync(request, callSettings), UndeleteWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>
        /// Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>> UndeleteWorkloadIdentityPoolAsync(UndeleteWorkloadIdentityPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteWorkloadIdentityPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>(await _callUndeleteWorkloadIdentityPool.Async(request, callSettings).ConfigureAwait(false), UndeleteWorkloadIdentityPoolOperationsClient);
        }

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProviders(ListWorkloadIdentityPoolProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadIdentityPoolProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider>(_callListWorkloadIdentityPoolProviders, request, callSettings);
        }

        /// <summary>
        /// Lists all non-deleted
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// If `show_deleted` is set to `true`, then deleted providers are also listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkloadIdentityPoolProvider"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> ListWorkloadIdentityPoolProvidersAsync(ListWorkloadIdentityPoolProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadIdentityPoolProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider>(_callListWorkloadIdentityPoolProviders, request, callSettings);
        }

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkloadIdentityPoolProvider GetWorkloadIdentityPoolProvider(GetWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return _callGetWorkloadIdentityPoolProvider.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an individual
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkloadIdentityPoolProvider> GetWorkloadIdentityPoolProviderAsync(GetWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return _callGetWorkloadIdentityPoolProvider.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkloadIdentityPoolProvider</c>.</summary>
        public override lro::OperationsClient CreateWorkloadIdentityPoolProviderOperationsClient { get; }

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> CreateWorkloadIdentityPoolProvider(CreateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(_callCreateWorkloadIdentityPoolProvider.Sync(request, callSettings), CreateWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>
        /// Creates a new
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
        /// in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
        /// 
        /// You cannot reuse the name of a deleted provider until 30 days after
        /// deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> CreateWorkloadIdentityPoolProviderAsync(CreateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(await _callCreateWorkloadIdentityPoolProvider.Async(request, callSettings).ConfigureAwait(false), CreateWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkloadIdentityPoolProvider</c>.</summary>
        public override lro::OperationsClient UpdateWorkloadIdentityPoolProviderOperationsClient { get; }

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UpdateWorkloadIdentityPoolProvider(UpdateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(_callUpdateWorkloadIdentityPoolProvider.Sync(request, callSettings), UpdateWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>
        /// Updates an existing
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UpdateWorkloadIdentityPoolProviderAsync(UpdateWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(await _callUpdateWorkloadIdentityPoolProvider.Async(request, callSettings).ConfigureAwait(false), UpdateWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkloadIdentityPoolProvider</c>.</summary>
        public override lro::OperationsClient DeleteWorkloadIdentityPoolProviderOperationsClient { get; }

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> DeleteWorkloadIdentityPoolProvider(DeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(_callDeleteWorkloadIdentityPoolProvider.Sync(request, callSettings), DeleteWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>
        /// Deletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
        /// Deleting a provider does not revoke credentials that have already been
        /// issued; they continue to grant access.
        /// You can undelete a provider for 30 days. After 30 days, deletion is
        /// permanent.
        /// You cannot update deleted providers. However, you can view and list them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> DeleteWorkloadIdentityPoolProviderAsync(DeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(await _callDeleteWorkloadIdentityPoolProvider.Async(request, callSettings).ConfigureAwait(false), DeleteWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteWorkloadIdentityPoolProvider</c>.</summary>
        public override lro::OperationsClient UndeleteWorkloadIdentityPoolProviderOperationsClient { get; }

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> UndeleteWorkloadIdentityPoolProvider(UndeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(_callUndeleteWorkloadIdentityPoolProvider.Sync(request, callSettings), UndeleteWorkloadIdentityPoolProviderOperationsClient);
        }

        /// <summary>
        /// Undeletes a
        /// [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
        /// as long as it was deleted fewer than 30 days ago.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>> UndeleteWorkloadIdentityPoolProviderAsync(UndeleteWorkloadIdentityPoolProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteWorkloadIdentityPoolProviderRequest(ref request, ref callSettings);
            return new lro::Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>(await _callUndeleteWorkloadIdentityPoolProvider.Async(request, callSettings).ConfigureAwait(false), UndeleteWorkloadIdentityPoolProviderOperationsClient);
        }
    }

    public partial class ListWorkloadIdentityPoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkloadIdentityPoolProvidersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkloadIdentityPoolsResponse : gaxgrpc::IPageResponse<WorkloadIdentityPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkloadIdentityPool> GetEnumerator() => WorkloadIdentityPools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkloadIdentityPoolProvidersResponse : gaxgrpc::IPageResponse<WorkloadIdentityPoolProvider>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkloadIdentityPoolProvider> GetEnumerator() =>
            WorkloadIdentityPoolProviders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class WorkloadIdentityPools
    {
        public partial class WorkloadIdentityPoolsClient
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
