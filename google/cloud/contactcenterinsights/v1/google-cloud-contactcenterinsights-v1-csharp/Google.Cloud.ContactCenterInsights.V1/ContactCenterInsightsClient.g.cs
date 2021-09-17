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

namespace Google.Cloud.ContactCenterInsights.V1
{
    /// <summary>Settings for <see cref="ContactCenterInsightsClient"/> instances.</summary>
    public sealed partial class ContactCenterInsightsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContactCenterInsightsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContactCenterInsightsSettings"/>.</returns>
        public static ContactCenterInsightsSettings GetDefault() => new ContactCenterInsightsSettings();

        /// <summary>
        /// Constructs a new <see cref="ContactCenterInsightsSettings"/> object with default settings.
        /// </summary>
        public ContactCenterInsightsSettings()
        {
        }

        private ContactCenterInsightsSettings(ContactCenterInsightsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConversationSettings = existing.CreateConversationSettings;
            UpdateConversationSettings = existing.UpdateConversationSettings;
            GetConversationSettings = existing.GetConversationSettings;
            ListConversationsSettings = existing.ListConversationsSettings;
            DeleteConversationSettings = existing.DeleteConversationSettings;
            CreateAnalysisSettings = existing.CreateAnalysisSettings;
            CreateAnalysisOperationsSettings = existing.CreateAnalysisOperationsSettings.Clone();
            GetAnalysisSettings = existing.GetAnalysisSettings;
            ListAnalysesSettings = existing.ListAnalysesSettings;
            DeleteAnalysisSettings = existing.DeleteAnalysisSettings;
            ExportInsightsDataSettings = existing.ExportInsightsDataSettings;
            ExportInsightsDataOperationsSettings = existing.ExportInsightsDataOperationsSettings.Clone();
            CreateIssueModelSettings = existing.CreateIssueModelSettings;
            CreateIssueModelOperationsSettings = existing.CreateIssueModelOperationsSettings.Clone();
            UpdateIssueModelSettings = existing.UpdateIssueModelSettings;
            GetIssueModelSettings = existing.GetIssueModelSettings;
            ListIssueModelsSettings = existing.ListIssueModelsSettings;
            DeleteIssueModelSettings = existing.DeleteIssueModelSettings;
            DeleteIssueModelOperationsSettings = existing.DeleteIssueModelOperationsSettings.Clone();
            DeployIssueModelSettings = existing.DeployIssueModelSettings;
            DeployIssueModelOperationsSettings = existing.DeployIssueModelOperationsSettings.Clone();
            UndeployIssueModelSettings = existing.UndeployIssueModelSettings;
            UndeployIssueModelOperationsSettings = existing.UndeployIssueModelOperationsSettings.Clone();
            GetIssueSettings = existing.GetIssueSettings;
            ListIssuesSettings = existing.ListIssuesSettings;
            UpdateIssueSettings = existing.UpdateIssueSettings;
            CalculateIssueModelStatsSettings = existing.CalculateIssueModelStatsSettings;
            CreatePhraseMatcherSettings = existing.CreatePhraseMatcherSettings;
            GetPhraseMatcherSettings = existing.GetPhraseMatcherSettings;
            ListPhraseMatchersSettings = existing.ListPhraseMatchersSettings;
            DeletePhraseMatcherSettings = existing.DeletePhraseMatcherSettings;
            CalculateStatsSettings = existing.CalculateStatsSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContactCenterInsightsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateConversation</c> and
        /// <c>ContactCenterInsightsClient.CreateConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateConversation</c> and
        /// <c>ContactCenterInsightsClient.UpdateConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetConversation</c> and <c>ContactCenterInsightsClient.GetConversationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListConversations</c> and
        /// <c>ContactCenterInsightsClient.ListConversationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteConversation</c> and
        /// <c>ContactCenterInsightsClient.DeleteConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateAnalysis</c> and <c>ContactCenterInsightsClient.CreateAnalysisAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnalysisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.CreateAnalysis</c> and
        /// <c>ContactCenterInsightsClient.CreateAnalysisAsync</c>.
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
        public lro::OperationsSettings CreateAnalysisOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetAnalysis</c> and <c>ContactCenterInsightsClient.GetAnalysisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnalysisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListAnalyses</c> and <c>ContactCenterInsightsClient.ListAnalysesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnalysesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteAnalysis</c> and <c>ContactCenterInsightsClient.DeleteAnalysisAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAnalysisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ExportInsightsData</c> and
        /// <c>ContactCenterInsightsClient.ExportInsightsDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportInsightsDataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.ExportInsightsData</c> and
        /// <c>ContactCenterInsightsClient.ExportInsightsDataAsync</c>.
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
        public lro::OperationsSettings ExportInsightsDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateIssueModel</c> and <c>ContactCenterInsightsClient.CreateIssueModelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.CreateIssueModel</c> and
        /// <c>ContactCenterInsightsClient.CreateIssueModelAsync</c>.
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
        public lro::OperationsSettings CreateIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateIssueModel</c> and <c>ContactCenterInsightsClient.UpdateIssueModelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetIssueModel</c> and <c>ContactCenterInsightsClient.GetIssueModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListIssueModels</c> and <c>ContactCenterInsightsClient.ListIssueModelsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIssueModelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteIssueModel</c> and <c>ContactCenterInsightsClient.DeleteIssueModelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.DeleteIssueModel</c> and
        /// <c>ContactCenterInsightsClient.DeleteIssueModelAsync</c>.
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
        public lro::OperationsSettings DeleteIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeployIssueModel</c> and <c>ContactCenterInsightsClient.DeployIssueModelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.DeployIssueModel</c> and
        /// <c>ContactCenterInsightsClient.DeployIssueModelAsync</c>.
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
        public lro::OperationsSettings DeployIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UndeployIssueModel</c> and
        /// <c>ContactCenterInsightsClient.UndeployIssueModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeployIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.UndeployIssueModel</c> and
        /// <c>ContactCenterInsightsClient.UndeployIssueModelAsync</c>.
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
        public lro::OperationsSettings UndeployIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetIssue</c> and <c>ContactCenterInsightsClient.GetIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIssueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListIssues</c> and <c>ContactCenterInsightsClient.ListIssuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIssuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateIssue</c> and <c>ContactCenterInsightsClient.UpdateIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIssueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CalculateIssueModelStats</c> and
        /// <c>ContactCenterInsightsClient.CalculateIssueModelStatsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CalculateIssueModelStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreatePhraseMatcher</c> and
        /// <c>ContactCenterInsightsClient.CreatePhraseMatcherAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetPhraseMatcher</c> and <c>ContactCenterInsightsClient.GetPhraseMatcherAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListPhraseMatchers</c> and
        /// <c>ContactCenterInsightsClient.ListPhraseMatchersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPhraseMatchersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeletePhraseMatcher</c> and
        /// <c>ContactCenterInsightsClient.DeletePhraseMatcherAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CalculateStats</c> and <c>ContactCenterInsightsClient.CalculateStatsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CalculateStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetSettings</c> and <c>ContactCenterInsightsClient.GetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateSettings</c> and <c>ContactCenterInsightsClient.UpdateSettingsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContactCenterInsightsSettings"/> object.</returns>
        public ContactCenterInsightsSettings Clone() => new ContactCenterInsightsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContactCenterInsightsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ContactCenterInsightsClientBuilder : gaxgrpc::ClientBuilderBase<ContactCenterInsightsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContactCenterInsightsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContactCenterInsightsClientBuilder()
        {
            UseJwtAccessWithScopes = ContactCenterInsightsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ContactCenterInsightsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContactCenterInsightsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContactCenterInsightsClient Build()
        {
            ContactCenterInsightsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContactCenterInsightsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContactCenterInsightsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContactCenterInsightsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContactCenterInsightsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ContactCenterInsightsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContactCenterInsightsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ContactCenterInsightsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ContactCenterInsightsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContactCenterInsightsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ContactCenterInsights client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An API that lets users analyze and explore their business conversation data.
    /// </remarks>
    public abstract partial class ContactCenterInsightsClient
    {
        /// <summary>
        /// The default endpoint for the ContactCenterInsights service, which is a host of
        /// "contactcenterinsights.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "contactcenterinsights.googleapis.com:443";

        /// <summary>The default ContactCenterInsights scopes.</summary>
        /// <remarks>
        /// The default ContactCenterInsights scopes are:
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
        /// Asynchronously creates a <see cref="ContactCenterInsightsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ContactCenterInsightsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContactCenterInsightsClient"/>.</returns>
        public static stt::Task<ContactCenterInsightsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContactCenterInsightsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContactCenterInsightsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ContactCenterInsightsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContactCenterInsightsClient"/>.</returns>
        public static ContactCenterInsightsClient Create() => new ContactCenterInsightsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContactCenterInsightsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContactCenterInsightsSettings"/>.</param>
        /// <returns>The created <see cref="ContactCenterInsightsClient"/>.</returns>
        internal static ContactCenterInsightsClient Create(grpccore::CallInvoker callInvoker, ContactCenterInsightsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContactCenterInsights.ContactCenterInsightsClient grpcClient = new ContactCenterInsights.ContactCenterInsightsClient(callInvoker);
            return new ContactCenterInsightsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ContactCenterInsights client</summary>
        public virtual ContactCenterInsights.ContactCenterInsightsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-32 characters and must match the regular
        /// expression /^[a-z0-9-]{4,32}$/. Valid characters are /[a-z][0-9]-/
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(string parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-32 characters and must match the regular
        /// expression /^[a-z0-9-]{4,32}$/. Valid characters are /[a-z][0-9]-/
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-32 characters and must match the regular
        /// expression /^[a-z0-9-]{4,32}$/. Valid characters are /[a-z][0-9]-/
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, string conversationId, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, conversationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-32 characters and must match the regular
        /// expression /^[a-z0-9-]{4,32}$/. Valid characters are /[a-z][0-9]-/
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(gagr::LocationName parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-32 characters and must match the regular
        /// expression /^[a-z0-9-]{4,32}$/. Valid characters are /[a-z][0-9]-/
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::LocationName parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-32 characters and must match the regular
        /// expression /^[a-z0-9-]{4,32}$/. Valid characters are /[a-z][0-9]-/
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::LocationName parent, Conversation conversation, string conversationId, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, conversationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation UpdateConversation(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The new values for the conversation.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation UpdateConversation(Conversation conversation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversation(new UpdateConversationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The new values for the conversation.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(Conversation conversation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversationAsync(new UpdateConversationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The new values for the conversation.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(Conversation conversation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversationAsync(conversation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, st::CancellationToken cancellationToken) =>
            GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
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
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversations(new ListConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversationsAsync(new ListConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
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
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversations(new ListConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversationsAsync(new ListConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAnalysis</c>.</summary>
        public virtual lro::OperationsClient CreateAnalysisOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> PollOnceCreateAnalysis(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, CreateAnalysisOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> PollOnceCreateAnalysisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, CreateAnalysisOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(string parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysis(new CreateAnalysisRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(string parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisAsync(new CreateAnalysisRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(string parent, Analysis analysis, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(parent, analysis, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(ConversationName parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysis(new CreateAnalysisRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(ConversationName parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisAsync(new CreateAnalysisRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(ConversationName parent, Analysis analysis, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(parent, analysis, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysis(new GetAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisAsync(new GetAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysis(new GetAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisAsync(new GetAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(AnalysisName name, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
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
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnalyses(new ListAnalysesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnalysesAsync(new ListAnalysesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
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
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnalyses(new ListAnalysesRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnalysesAsync(new ListAnalysesRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysis(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(DeleteAnalysisRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysis(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysis(new DeleteAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisAsync(new DeleteAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysis(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysis(new DeleteAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisAsync(new DeleteAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(AnalysisName name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(ExportInsightsDataRequest request, st::CancellationToken cancellationToken) =>
            ExportInsightsDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportInsightsData</c>.</summary>
        public virtual lro::OperationsClient ExportInsightsDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportInsightsData</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> PollOnceExportInsightsData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInsightsDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportInsightsData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> PollOnceExportInsightsDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInsightsDataOperationsClient, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsData(new ExportInsightsDataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsDataAsync(new ExportInsightsDataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(string parent, st::CancellationToken cancellationToken) =>
            ExportInsightsDataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsData(new ExportInsightsDataRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsDataAsync(new ExportInsightsDataRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ExportInsightsDataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(CreateIssueModelRequest request, st::CancellationToken cancellationToken) =>
            CreateIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIssueModel</c>.</summary>
        public virtual lro::OperationsClient CreateIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> PollOnceCreateIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueModel, CreateIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> PollOnceCreateIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueModel, CreateIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(string parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModel(new CreateIssueModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(string parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModelAsync(new CreateIssueModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(string parent, IssueModel issueModel, st::CancellationToken cancellationToken) =>
            CreateIssueModelAsync(parent, issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(gagr::LocationName parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModel(new CreateIssueModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(gagr::LocationName parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModelAsync(new CreateIssueModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(gagr::LocationName parent, IssueModel issueModel, st::CancellationToken cancellationToken) =>
            CreateIssueModelAsync(parent, issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel UpdateIssueModel(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(UpdateIssueModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The new values for the issue model.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel UpdateIssueModel(IssueModel issueModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueModel(new UpdateIssueModelRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The new values for the issue model.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(IssueModel issueModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueModelAsync(new UpdateIssueModelRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The new values for the issue model.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(IssueModel issueModel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIssueModelAsync(issueModel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel GetIssueModel(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(GetIssueModelRequest request, st::CancellationToken cancellationToken) =>
            GetIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel GetIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModel(new GetIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModelAsync(new GetIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel GetIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModel(new GetIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModelAsync(new GetIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            GetIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssueModelsResponse ListIssueModels(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(ListIssueModelsRequest request, st::CancellationToken cancellationToken) =>
            ListIssueModelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssueModelsResponse ListIssueModels(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModels(new ListIssueModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModelsAsync(new ListIssueModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListIssueModelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssueModelsResponse ListIssueModels(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModels(new ListIssueModelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModelsAsync(new ListIssueModelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ListIssueModelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(DeleteIssueModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIssueModel</c>.</summary>
        public virtual lro::OperationsClient DeleteIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> PollOnceDeleteIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> PollOnceDeleteIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModel(new DeleteIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModelAsync(new DeleteIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModel(new DeleteIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModelAsync(new DeleteIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            DeleteIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(DeployIssueModelRequest request, st::CancellationToken cancellationToken) =>
            DeployIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployIssueModel</c>.</summary>
        public virtual lro::OperationsClient DeployIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> PollOnceDeployIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> PollOnceDeployIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModel(new DeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModelAsync(new DeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModel(new DeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModelAsync(new DeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            DeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(UndeployIssueModelRequest request, st::CancellationToken cancellationToken) =>
            UndeployIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployIssueModel</c>.</summary>
        public virtual lro::OperationsClient UndeployIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployIssueModel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> PollOnceUndeployIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> PollOnceUndeployIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModel(new UndeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModelAsync(new UndeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            UndeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModel(new UndeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModelAsync(new UndeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            UndeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue GetIssue(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(GetIssueRequest request, st::CancellationToken cancellationToken) =>
            GetIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue GetIssue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssue(new GetIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueAsync(new GetIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(string name, st::CancellationToken cancellationToken) =>
            GetIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue GetIssue(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssue(new GetIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueAsync(new GetIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            GetIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssuesResponse ListIssues(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(ListIssuesRequest request, st::CancellationToken cancellationToken) =>
            ListIssuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssuesResponse ListIssues(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssues(new ListIssuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssuesAsync(new ListIssuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListIssuesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssuesResponse ListIssues(IssueModelName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssues(new ListIssuesRequest
            {
                ParentAsIssueModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(IssueModelName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssuesAsync(new ListIssuesRequest
            {
                ParentAsIssueModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(IssueModelName parent, st::CancellationToken cancellationToken) =>
            ListIssuesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue UpdateIssue(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(UpdateIssueRequest request, st::CancellationToken cancellationToken) =>
            UpdateIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The new values for the issue.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue UpdateIssue(Issue issue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssue(new UpdateIssueRequest
            {
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The new values for the issue.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(Issue issue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueAsync(new UpdateIssueRequest
            {
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The new values for the issue.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(Issue issue, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIssueAsync(issue, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateIssueModelStatsResponse CalculateIssueModelStats(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest request, st::CancellationToken cancellationToken) =>
            CalculateIssueModelStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateIssueModelStatsResponse CalculateIssueModelStats(string issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStats(new CalculateIssueModelStatsRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNullOrEmpty(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(string issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStatsAsync(new CalculateIssueModelStatsRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNullOrEmpty(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(string issueModel, st::CancellationToken cancellationToken) =>
            CalculateIssueModelStatsAsync(issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateIssueModelStatsResponse CalculateIssueModelStats(IssueModelName issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStats(new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(IssueModelName issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStatsAsync(new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(IssueModelName issueModel, st::CancellationToken cancellationToken) =>
            CalculateIssueModelStatsAsync(issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher CreatePhraseMatcher(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(CreatePhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            CreatePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location to create
        /// a phrase matcher for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;` or
        /// `projects/&amp;lt;Project Number&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher CreatePhraseMatcher(string parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcher(new CreatePhraseMatcherRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location to create
        /// a phrase matcher for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;` or
        /// `projects/&amp;lt;Project Number&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(string parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcherAsync(new CreatePhraseMatcherRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location to create
        /// a phrase matcher for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;` or
        /// `projects/&amp;lt;Project Number&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(string parent, PhraseMatcher phraseMatcher, st::CancellationToken cancellationToken) =>
            CreatePhraseMatcherAsync(parent, phraseMatcher, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location to create
        /// a phrase matcher for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;` or
        /// `projects/&amp;lt;Project Number&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher CreatePhraseMatcher(gagr::LocationName parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcher(new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location to create
        /// a phrase matcher for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;` or
        /// `projects/&amp;lt;Project Number&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(gagr::LocationName parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcherAsync(new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location to create
        /// a phrase matcher for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;` or
        /// `projects/&amp;lt;Project Number&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(gagr::LocationName parent, PhraseMatcher phraseMatcher, st::CancellationToken cancellationToken) =>
            CreatePhraseMatcherAsync(parent, phraseMatcher, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher GetPhraseMatcher(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(GetPhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            GetPhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher GetPhraseMatcher(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcher(new GetPhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcherAsync(new GetPhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(string name, st::CancellationToken cancellationToken) =>
            GetPhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher GetPhraseMatcher(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcher(new GetPhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcherAsync(new GetPhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(PhraseMatcherName name, st::CancellationToken cancellationToken) =>
            GetPhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
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
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhraseMatchers(new ListPhraseMatchersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhraseMatchersAsync(new ListPhraseMatchersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
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
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhraseMatchers(new ListPhraseMatchersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhraseMatchersAsync(new ListPhraseMatchersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseMatcher(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(DeletePhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            DeletePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseMatcher(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcher(new DeletePhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcherAsync(new DeletePhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseMatcher(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcher(new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcherAsync(new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(PhraseMatcherName name, st::CancellationToken cancellationToken) =>
            DeletePhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateStatsResponse CalculateStats(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(CalculateStatsRequest request, st::CancellationToken cancellationToken) =>
            CalculateStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateStatsResponse CalculateStats(string location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStats(new CalculateStatsRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(string location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStatsAsync(new CalculateStatsRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(string location, st::CancellationToken cancellationToken) =>
            CalculateStatsAsync(location, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateStatsResponse CalculateStats(gagr::LocationName location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStats(new CalculateStatsRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(gagr::LocationName location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStatsAsync(new CalculateStatsRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(gagr::LocationName location, st::CancellationToken cancellationToken) =>
            CalculateStatsAsync(location, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The new settings values.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The new settings values.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The new settings values.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ContactCenterInsights client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An API that lets users analyze and explore their business conversation data.
    /// </remarks>
    public sealed partial class ContactCenterInsightsClientImpl : ContactCenterInsightsClient
    {
        private readonly gaxgrpc::ApiCall<CreateConversationRequest, Conversation> _callCreateConversation;

        private readonly gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> _callUpdateConversation;

        private readonly gaxgrpc::ApiCall<GetConversationRequest, Conversation> _callGetConversation;

        private readonly gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> _callListConversations;

        private readonly gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> _callDeleteConversation;

        private readonly gaxgrpc::ApiCall<CreateAnalysisRequest, lro::Operation> _callCreateAnalysis;

        private readonly gaxgrpc::ApiCall<GetAnalysisRequest, Analysis> _callGetAnalysis;

        private readonly gaxgrpc::ApiCall<ListAnalysesRequest, ListAnalysesResponse> _callListAnalyses;

        private readonly gaxgrpc::ApiCall<DeleteAnalysisRequest, wkt::Empty> _callDeleteAnalysis;

        private readonly gaxgrpc::ApiCall<ExportInsightsDataRequest, lro::Operation> _callExportInsightsData;

        private readonly gaxgrpc::ApiCall<CreateIssueModelRequest, lro::Operation> _callCreateIssueModel;

        private readonly gaxgrpc::ApiCall<UpdateIssueModelRequest, IssueModel> _callUpdateIssueModel;

        private readonly gaxgrpc::ApiCall<GetIssueModelRequest, IssueModel> _callGetIssueModel;

        private readonly gaxgrpc::ApiCall<ListIssueModelsRequest, ListIssueModelsResponse> _callListIssueModels;

        private readonly gaxgrpc::ApiCall<DeleteIssueModelRequest, lro::Operation> _callDeleteIssueModel;

        private readonly gaxgrpc::ApiCall<DeployIssueModelRequest, lro::Operation> _callDeployIssueModel;

        private readonly gaxgrpc::ApiCall<UndeployIssueModelRequest, lro::Operation> _callUndeployIssueModel;

        private readonly gaxgrpc::ApiCall<GetIssueRequest, Issue> _callGetIssue;

        private readonly gaxgrpc::ApiCall<ListIssuesRequest, ListIssuesResponse> _callListIssues;

        private readonly gaxgrpc::ApiCall<UpdateIssueRequest, Issue> _callUpdateIssue;

        private readonly gaxgrpc::ApiCall<CalculateIssueModelStatsRequest, CalculateIssueModelStatsResponse> _callCalculateIssueModelStats;

        private readonly gaxgrpc::ApiCall<CreatePhraseMatcherRequest, PhraseMatcher> _callCreatePhraseMatcher;

        private readonly gaxgrpc::ApiCall<GetPhraseMatcherRequest, PhraseMatcher> _callGetPhraseMatcher;

        private readonly gaxgrpc::ApiCall<ListPhraseMatchersRequest, ListPhraseMatchersResponse> _callListPhraseMatchers;

        private readonly gaxgrpc::ApiCall<DeletePhraseMatcherRequest, wkt::Empty> _callDeletePhraseMatcher;

        private readonly gaxgrpc::ApiCall<CalculateStatsRequest, CalculateStatsResponse> _callCalculateStats;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> _callUpdateSettings;

        /// <summary>
        /// Constructs a client wrapper for the ContactCenterInsights service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContactCenterInsightsSettings"/> used within this client.</param>
        public ContactCenterInsightsClientImpl(ContactCenterInsights.ContactCenterInsightsClient grpcClient, ContactCenterInsightsSettings settings)
        {
            GrpcClient = grpcClient;
            ContactCenterInsightsSettings effectiveSettings = settings ?? ContactCenterInsightsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateAnalysisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAnalysisOperationsSettings);
            ExportInsightsDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportInsightsDataOperationsSettings);
            CreateIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIssueModelOperationsSettings);
            DeleteIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIssueModelOperationsSettings);
            DeployIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployIssueModelOperationsSettings);
            UndeployIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployIssueModelOperationsSettings);
            _callCreateConversation = clientHelper.BuildApiCall<CreateConversationRequest, Conversation>(grpcClient.CreateConversationAsync, grpcClient.CreateConversation, effectiveSettings.CreateConversationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversation);
            Modify_CreateConversationApiCall(ref _callCreateConversation);
            _callUpdateConversation = clientHelper.BuildApiCall<UpdateConversationRequest, Conversation>(grpcClient.UpdateConversationAsync, grpcClient.UpdateConversation, effectiveSettings.UpdateConversationSettings).WithGoogleRequestParam("conversation.name", request => request.Conversation?.Name);
            Modify_ApiCall(ref _callUpdateConversation);
            Modify_UpdateConversationApiCall(ref _callUpdateConversation);
            _callGetConversation = clientHelper.BuildApiCall<GetConversationRequest, Conversation>(grpcClient.GetConversationAsync, grpcClient.GetConversation, effectiveSettings.GetConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversation);
            Modify_GetConversationApiCall(ref _callGetConversation);
            _callListConversations = clientHelper.BuildApiCall<ListConversationsRequest, ListConversationsResponse>(grpcClient.ListConversationsAsync, grpcClient.ListConversations, effectiveSettings.ListConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversations);
            Modify_ListConversationsApiCall(ref _callListConversations);
            _callDeleteConversation = clientHelper.BuildApiCall<DeleteConversationRequest, wkt::Empty>(grpcClient.DeleteConversationAsync, grpcClient.DeleteConversation, effectiveSettings.DeleteConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversation);
            Modify_DeleteConversationApiCall(ref _callDeleteConversation);
            _callCreateAnalysis = clientHelper.BuildApiCall<CreateAnalysisRequest, lro::Operation>(grpcClient.CreateAnalysisAsync, grpcClient.CreateAnalysis, effectiveSettings.CreateAnalysisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnalysis);
            Modify_CreateAnalysisApiCall(ref _callCreateAnalysis);
            _callGetAnalysis = clientHelper.BuildApiCall<GetAnalysisRequest, Analysis>(grpcClient.GetAnalysisAsync, grpcClient.GetAnalysis, effectiveSettings.GetAnalysisSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnalysis);
            Modify_GetAnalysisApiCall(ref _callGetAnalysis);
            _callListAnalyses = clientHelper.BuildApiCall<ListAnalysesRequest, ListAnalysesResponse>(grpcClient.ListAnalysesAsync, grpcClient.ListAnalyses, effectiveSettings.ListAnalysesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyses);
            Modify_ListAnalysesApiCall(ref _callListAnalyses);
            _callDeleteAnalysis = clientHelper.BuildApiCall<DeleteAnalysisRequest, wkt::Empty>(grpcClient.DeleteAnalysisAsync, grpcClient.DeleteAnalysis, effectiveSettings.DeleteAnalysisSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnalysis);
            Modify_DeleteAnalysisApiCall(ref _callDeleteAnalysis);
            _callExportInsightsData = clientHelper.BuildApiCall<ExportInsightsDataRequest, lro::Operation>(grpcClient.ExportInsightsDataAsync, grpcClient.ExportInsightsData, effectiveSettings.ExportInsightsDataSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportInsightsData);
            Modify_ExportInsightsDataApiCall(ref _callExportInsightsData);
            _callCreateIssueModel = clientHelper.BuildApiCall<CreateIssueModelRequest, lro::Operation>(grpcClient.CreateIssueModelAsync, grpcClient.CreateIssueModel, effectiveSettings.CreateIssueModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIssueModel);
            Modify_CreateIssueModelApiCall(ref _callCreateIssueModel);
            _callUpdateIssueModel = clientHelper.BuildApiCall<UpdateIssueModelRequest, IssueModel>(grpcClient.UpdateIssueModelAsync, grpcClient.UpdateIssueModel, effectiveSettings.UpdateIssueModelSettings).WithGoogleRequestParam("issue_model.name", request => request.IssueModel?.Name);
            Modify_ApiCall(ref _callUpdateIssueModel);
            Modify_UpdateIssueModelApiCall(ref _callUpdateIssueModel);
            _callGetIssueModel = clientHelper.BuildApiCall<GetIssueModelRequest, IssueModel>(grpcClient.GetIssueModelAsync, grpcClient.GetIssueModel, effectiveSettings.GetIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIssueModel);
            Modify_GetIssueModelApiCall(ref _callGetIssueModel);
            _callListIssueModels = clientHelper.BuildApiCall<ListIssueModelsRequest, ListIssueModelsResponse>(grpcClient.ListIssueModelsAsync, grpcClient.ListIssueModels, effectiveSettings.ListIssueModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIssueModels);
            Modify_ListIssueModelsApiCall(ref _callListIssueModels);
            _callDeleteIssueModel = clientHelper.BuildApiCall<DeleteIssueModelRequest, lro::Operation>(grpcClient.DeleteIssueModelAsync, grpcClient.DeleteIssueModel, effectiveSettings.DeleteIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIssueModel);
            Modify_DeleteIssueModelApiCall(ref _callDeleteIssueModel);
            _callDeployIssueModel = clientHelper.BuildApiCall<DeployIssueModelRequest, lro::Operation>(grpcClient.DeployIssueModelAsync, grpcClient.DeployIssueModel, effectiveSettings.DeployIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployIssueModel);
            Modify_DeployIssueModelApiCall(ref _callDeployIssueModel);
            _callUndeployIssueModel = clientHelper.BuildApiCall<UndeployIssueModelRequest, lro::Operation>(grpcClient.UndeployIssueModelAsync, grpcClient.UndeployIssueModel, effectiveSettings.UndeployIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployIssueModel);
            Modify_UndeployIssueModelApiCall(ref _callUndeployIssueModel);
            _callGetIssue = clientHelper.BuildApiCall<GetIssueRequest, Issue>(grpcClient.GetIssueAsync, grpcClient.GetIssue, effectiveSettings.GetIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIssue);
            Modify_GetIssueApiCall(ref _callGetIssue);
            _callListIssues = clientHelper.BuildApiCall<ListIssuesRequest, ListIssuesResponse>(grpcClient.ListIssuesAsync, grpcClient.ListIssues, effectiveSettings.ListIssuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIssues);
            Modify_ListIssuesApiCall(ref _callListIssues);
            _callUpdateIssue = clientHelper.BuildApiCall<UpdateIssueRequest, Issue>(grpcClient.UpdateIssueAsync, grpcClient.UpdateIssue, effectiveSettings.UpdateIssueSettings).WithGoogleRequestParam("issue.name", request => request.Issue?.Name);
            Modify_ApiCall(ref _callUpdateIssue);
            Modify_UpdateIssueApiCall(ref _callUpdateIssue);
            _callCalculateIssueModelStats = clientHelper.BuildApiCall<CalculateIssueModelStatsRequest, CalculateIssueModelStatsResponse>(grpcClient.CalculateIssueModelStatsAsync, grpcClient.CalculateIssueModelStats, effectiveSettings.CalculateIssueModelStatsSettings).WithGoogleRequestParam("issue_model", request => request.IssueModel);
            Modify_ApiCall(ref _callCalculateIssueModelStats);
            Modify_CalculateIssueModelStatsApiCall(ref _callCalculateIssueModelStats);
            _callCreatePhraseMatcher = clientHelper.BuildApiCall<CreatePhraseMatcherRequest, PhraseMatcher>(grpcClient.CreatePhraseMatcherAsync, grpcClient.CreatePhraseMatcher, effectiveSettings.CreatePhraseMatcherSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePhraseMatcher);
            Modify_CreatePhraseMatcherApiCall(ref _callCreatePhraseMatcher);
            _callGetPhraseMatcher = clientHelper.BuildApiCall<GetPhraseMatcherRequest, PhraseMatcher>(grpcClient.GetPhraseMatcherAsync, grpcClient.GetPhraseMatcher, effectiveSettings.GetPhraseMatcherSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhraseMatcher);
            Modify_GetPhraseMatcherApiCall(ref _callGetPhraseMatcher);
            _callListPhraseMatchers = clientHelper.BuildApiCall<ListPhraseMatchersRequest, ListPhraseMatchersResponse>(grpcClient.ListPhraseMatchersAsync, grpcClient.ListPhraseMatchers, effectiveSettings.ListPhraseMatchersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPhraseMatchers);
            Modify_ListPhraseMatchersApiCall(ref _callListPhraseMatchers);
            _callDeletePhraseMatcher = clientHelper.BuildApiCall<DeletePhraseMatcherRequest, wkt::Empty>(grpcClient.DeletePhraseMatcherAsync, grpcClient.DeletePhraseMatcher, effectiveSettings.DeletePhraseMatcherSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhraseMatcher);
            Modify_DeletePhraseMatcherApiCall(ref _callDeletePhraseMatcher);
            _callCalculateStats = clientHelper.BuildApiCall<CalculateStatsRequest, CalculateStatsResponse>(grpcClient.CalculateStatsAsync, grpcClient.CalculateStats, effectiveSettings.CalculateStatsSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callCalculateStats);
            Modify_CalculateStatsApiCall(ref _callCalculateStats);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>(grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, Settings>(grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConversationApiCall(ref gaxgrpc::ApiCall<CreateConversationRequest, Conversation> call);

        partial void Modify_UpdateConversationApiCall(ref gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> call);

        partial void Modify_GetConversationApiCall(ref gaxgrpc::ApiCall<GetConversationRequest, Conversation> call);

        partial void Modify_ListConversationsApiCall(ref gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> call);

        partial void Modify_DeleteConversationApiCall(ref gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> call);

        partial void Modify_CreateAnalysisApiCall(ref gaxgrpc::ApiCall<CreateAnalysisRequest, lro::Operation> call);

        partial void Modify_GetAnalysisApiCall(ref gaxgrpc::ApiCall<GetAnalysisRequest, Analysis> call);

        partial void Modify_ListAnalysesApiCall(ref gaxgrpc::ApiCall<ListAnalysesRequest, ListAnalysesResponse> call);

        partial void Modify_DeleteAnalysisApiCall(ref gaxgrpc::ApiCall<DeleteAnalysisRequest, wkt::Empty> call);

        partial void Modify_ExportInsightsDataApiCall(ref gaxgrpc::ApiCall<ExportInsightsDataRequest, lro::Operation> call);

        partial void Modify_CreateIssueModelApiCall(ref gaxgrpc::ApiCall<CreateIssueModelRequest, lro::Operation> call);

        partial void Modify_UpdateIssueModelApiCall(ref gaxgrpc::ApiCall<UpdateIssueModelRequest, IssueModel> call);

        partial void Modify_GetIssueModelApiCall(ref gaxgrpc::ApiCall<GetIssueModelRequest, IssueModel> call);

        partial void Modify_ListIssueModelsApiCall(ref gaxgrpc::ApiCall<ListIssueModelsRequest, ListIssueModelsResponse> call);

        partial void Modify_DeleteIssueModelApiCall(ref gaxgrpc::ApiCall<DeleteIssueModelRequest, lro::Operation> call);

        partial void Modify_DeployIssueModelApiCall(ref gaxgrpc::ApiCall<DeployIssueModelRequest, lro::Operation> call);

        partial void Modify_UndeployIssueModelApiCall(ref gaxgrpc::ApiCall<UndeployIssueModelRequest, lro::Operation> call);

        partial void Modify_GetIssueApiCall(ref gaxgrpc::ApiCall<GetIssueRequest, Issue> call);

        partial void Modify_ListIssuesApiCall(ref gaxgrpc::ApiCall<ListIssuesRequest, ListIssuesResponse> call);

        partial void Modify_UpdateIssueApiCall(ref gaxgrpc::ApiCall<UpdateIssueRequest, Issue> call);

        partial void Modify_CalculateIssueModelStatsApiCall(ref gaxgrpc::ApiCall<CalculateIssueModelStatsRequest, CalculateIssueModelStatsResponse> call);

        partial void Modify_CreatePhraseMatcherApiCall(ref gaxgrpc::ApiCall<CreatePhraseMatcherRequest, PhraseMatcher> call);

        partial void Modify_GetPhraseMatcherApiCall(ref gaxgrpc::ApiCall<GetPhraseMatcherRequest, PhraseMatcher> call);

        partial void Modify_ListPhraseMatchersApiCall(ref gaxgrpc::ApiCall<ListPhraseMatchersRequest, ListPhraseMatchersResponse> call);

        partial void Modify_DeletePhraseMatcherApiCall(ref gaxgrpc::ApiCall<DeletePhraseMatcherRequest, wkt::Empty> call);

        partial void Modify_CalculateStatsApiCall(ref gaxgrpc::ApiCall<CalculateStatsRequest, CalculateStatsResponse> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> call);

        partial void OnConstruction(ContactCenterInsights.ContactCenterInsightsClient grpcClient, ContactCenterInsightsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContactCenterInsights client</summary>
        public override ContactCenterInsights.ContactCenterInsightsClient GrpcClient { get; }

        partial void Modify_CreateConversationRequest(ref CreateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversationRequest(ref UpdateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationRequest(ref GetConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationsRequest(ref ListConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationRequest(ref DeleteConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnalysisRequest(ref CreateAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnalysisRequest(ref GetAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalysesRequest(ref ListAnalysesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnalysisRequest(ref DeleteAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportInsightsDataRequest(ref ExportInsightsDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIssueModelRequest(ref CreateIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIssueModelRequest(ref UpdateIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIssueModelRequest(ref GetIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIssueModelsRequest(ref ListIssueModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIssueModelRequest(ref DeleteIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployIssueModelRequest(ref DeployIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployIssueModelRequest(ref UndeployIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIssueRequest(ref GetIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIssuesRequest(ref ListIssuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIssueRequest(ref UpdateIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateIssueModelStatsRequest(ref CalculateIssueModelStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePhraseMatcherRequest(ref CreatePhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhraseMatcherRequest(ref GetPhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhraseMatchersRequest(ref ListPhraseMatchersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhraseMatcherRequest(ref DeletePhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateStatsRequest(ref CalculateStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationRequest(ref request, ref callSettings);
            return _callCreateConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationRequest(ref request, ref callSettings);
            return _callCreateConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation UpdateConversation(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationRequest(ref request, ref callSettings);
            return _callUpdateConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationRequest(ref request, ref callSettings);
            return _callUpdateConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            _callDeleteConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            return _callDeleteConversation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAnalysis</c>.</summary>
        public override lro::OperationsClient CreateAnalysisOperationsClient { get; }

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, CreateAnalysisOperationMetadata>(_callCreateAnalysis.Sync(request, callSettings), CreateAnalysisOperationsClient);
        }

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, CreateAnalysisOperationMetadata>(await _callCreateAnalysis.Async(request, callSettings).ConfigureAwait(false), CreateAnalysisOperationsClient);
        }

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Analysis GetAnalysis(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRequest(ref request, ref callSettings);
            return _callGetAnalysis.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRequest(ref request, ref callSettings);
            return _callGetAnalysis.Async(request, callSettings);
        }

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalysesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalysesRequest, ListAnalysesResponse, Analysis>(_callListAnalyses, request, callSettings);
        }

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalysesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalysesRequest, ListAnalysesResponse, Analysis>(_callListAnalyses, request, callSettings);
        }

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnalysis(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRequest(ref request, ref callSettings);
            _callDeleteAnalysis.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnalysisAsync(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRequest(ref request, ref callSettings);
            return _callDeleteAnalysis.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportInsightsData</c>.</summary>
        public override lro::OperationsClient ExportInsightsDataOperationsClient { get; }

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInsightsDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>(_callExportInsightsData.Sync(request, callSettings), ExportInsightsDataOperationsClient);
        }

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInsightsDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>(await _callExportInsightsData.Async(request, callSettings).ConfigureAwait(false), ExportInsightsDataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateIssueModel</c>.</summary>
        public override lro::OperationsClient CreateIssueModelOperationsClient { get; }

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<IssueModel, CreateIssueModelMetadata>(_callCreateIssueModel.Sync(request, callSettings), CreateIssueModelOperationsClient);
        }

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<IssueModel, CreateIssueModelMetadata>(await _callCreateIssueModel.Async(request, callSettings).ConfigureAwait(false), CreateIssueModelOperationsClient);
        }

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IssueModel UpdateIssueModel(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueModelRequest(ref request, ref callSettings);
            return _callUpdateIssueModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IssueModel> UpdateIssueModelAsync(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueModelRequest(ref request, ref callSettings);
            return _callUpdateIssueModel.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IssueModel GetIssueModel(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueModelRequest(ref request, ref callSettings);
            return _callGetIssueModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IssueModel> GetIssueModelAsync(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueModelRequest(ref request, ref callSettings);
            return _callGetIssueModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListIssueModelsResponse ListIssueModels(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssueModelsRequest(ref request, ref callSettings);
            return _callListIssueModels.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssueModelsRequest(ref request, ref callSettings);
            return _callListIssueModels.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteIssueModel</c>.</summary>
        public override lro::OperationsClient DeleteIssueModelOperationsClient { get; }

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIssueModelMetadata>(_callDeleteIssueModel.Sync(request, callSettings), DeleteIssueModelOperationsClient);
        }

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIssueModelMetadata>(await _callDeleteIssueModel.Async(request, callSettings).ConfigureAwait(false), DeleteIssueModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployIssueModel</c>.</summary>
        public override lro::OperationsClient DeployIssueModelOperationsClient { get; }

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>(_callDeployIssueModel.Sync(request, callSettings), DeployIssueModelOperationsClient);
        }

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>(await _callDeployIssueModel.Async(request, callSettings).ConfigureAwait(false), DeployIssueModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployIssueModel</c>.</summary>
        public override lro::OperationsClient UndeployIssueModelOperationsClient { get; }

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>(_callUndeployIssueModel.Sync(request, callSettings), UndeployIssueModelOperationsClient);
        }

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>(await _callUndeployIssueModel.Async(request, callSettings).ConfigureAwait(false), UndeployIssueModelOperationsClient);
        }

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Issue GetIssue(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueRequest(ref request, ref callSettings);
            return _callGetIssue.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Issue> GetIssueAsync(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueRequest(ref request, ref callSettings);
            return _callGetIssue.Async(request, callSettings);
        }

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListIssuesResponse ListIssues(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssuesRequest(ref request, ref callSettings);
            return _callListIssues.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListIssuesResponse> ListIssuesAsync(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssuesRequest(ref request, ref callSettings);
            return _callListIssues.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Issue UpdateIssue(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueRequest(ref request, ref callSettings);
            return _callUpdateIssue.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Issue> UpdateIssueAsync(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueRequest(ref request, ref callSettings);
            return _callUpdateIssue.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateIssueModelStatsResponse CalculateIssueModelStats(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateIssueModelStatsRequest(ref request, ref callSettings);
            return _callCalculateIssueModelStats.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateIssueModelStatsRequest(ref request, ref callSettings);
            return _callCalculateIssueModelStats.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseMatcher CreatePhraseMatcher(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseMatcherRequest(ref request, ref callSettings);
            return _callCreatePhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseMatcherRequest(ref request, ref callSettings);
            return _callCreatePhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseMatcher GetPhraseMatcher(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseMatcherRequest(ref request, ref callSettings);
            return _callGetPhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseMatcher> GetPhraseMatcherAsync(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseMatcherRequest(ref request, ref callSettings);
            return _callGetPhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseMatchersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhraseMatchersRequest, ListPhraseMatchersResponse, PhraseMatcher>(_callListPhraseMatchers, request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseMatchersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhraseMatchersRequest, ListPhraseMatchersResponse, PhraseMatcher>(_callListPhraseMatchers, request, callSettings);
        }

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePhraseMatcher(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseMatcherRequest(ref request, ref callSettings);
            _callDeletePhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePhraseMatcherAsync(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseMatcherRequest(ref request, ref callSettings);
            return _callDeletePhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateStatsResponse CalculateStats(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateStatsRequest(ref request, ref callSettings);
            return _callCalculateStats.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateStatsResponse> CalculateStatsAsync(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateStatsRequest(ref request, ref callSettings);
            return _callCalculateStats.Async(request, callSettings);
        }

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Async(request, callSettings);
        }
    }

    public partial class ListConversationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalysesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhraseMatchersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationsResponse : gaxgrpc::IPageResponse<Conversation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Conversation> GetEnumerator() => Conversations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalysesResponse : gaxgrpc::IPageResponse<Analysis>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Analysis> GetEnumerator() => Analyses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPhraseMatchersResponse : gaxgrpc::IPageResponse<PhraseMatcher>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhraseMatcher> GetEnumerator() => PhraseMatchers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ContactCenterInsights
    {
        public partial class ContactCenterInsightsClient
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
