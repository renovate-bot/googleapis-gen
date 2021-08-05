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
using gcmmv = Google.Cloud.Monitoring.MetricsScope.V1;
using sys = System;

namespace Google.Cloud.Monitoring.MetricsScope.V1
{
    /// <summary>Resource name for the <c>MetricsScope</c> resource.</summary>
    public sealed partial class MetricsScopeName : gax::IResourceName, sys::IEquatable<MetricsScopeName>
    {
        /// <summary>The possible contents of <see cref="MetricsScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>locations/global/metricsScope/{metrics_scope}</c>.</summary>
            MetricsScope = 1,
        }

        private static gax::PathTemplate s_metricsScope = new gax::PathTemplate("locations/global/metricsScope/{metrics_scope}");

        /// <summary>Creates a <see cref="MetricsScopeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MetricsScopeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MetricsScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MetricsScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MetricsScopeName"/> with the pattern <c>locations/global/metricsScope/{metrics_scope}</c>
        /// .
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetricsScopeName"/> constructed from the provided ids.</returns>
        public static MetricsScopeName FromMetricsScope(string metricsScopeId) =>
            new MetricsScopeName(ResourceNameType.MetricsScope, metricsScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricsScopeId, nameof(metricsScopeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricsScopeName"/> with pattern
        /// <c>locations/global/metricsScope/{metrics_scope}</c>.
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricsScopeName"/> with pattern
        /// <c>locations/global/metricsScope/{metrics_scope}</c>.
        /// </returns>
        public static string Format(string metricsScopeId) => FormatMetricsScope(metricsScopeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricsScopeName"/> with pattern
        /// <c>locations/global/metricsScope/{metrics_scope}</c>.
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricsScopeName"/> with pattern
        /// <c>locations/global/metricsScope/{metrics_scope}</c>.
        /// </returns>
        public static string FormatMetricsScope(string metricsScopeId) =>
            s_metricsScope.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(metricsScopeId, nameof(metricsScopeId)));

        /// <summary>Parses the given resource name string into a new <see cref="MetricsScopeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>locations/global/metricsScope/{metrics_scope}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricsScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricsScopeName"/> if successful.</returns>
        public static MetricsScopeName Parse(string metricsScopeName) => Parse(metricsScopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetricsScopeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>locations/global/metricsScope/{metrics_scope}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricsScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MetricsScopeName"/> if successful.</returns>
        public static MetricsScopeName Parse(string metricsScopeName, bool allowUnparsed) =>
            TryParse(metricsScopeName, allowUnparsed, out MetricsScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricsScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>locations/global/metricsScope/{metrics_scope}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricsScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricsScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricsScopeName, out MetricsScopeName result) =>
            TryParse(metricsScopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricsScopeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>locations/global/metricsScope/{metrics_scope}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricsScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricsScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricsScopeName, bool allowUnparsed, out MetricsScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(metricsScopeName, nameof(metricsScopeName));
            gax::TemplatedResourceName resourceName;
            if (s_metricsScope.TryParseName(metricsScopeName, out resourceName))
            {
                result = FromMetricsScope(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(metricsScopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MetricsScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string metricsScopeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MetricsScopeId = metricsScopeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MetricsScopeName"/> class from the component parts of pattern
        /// <c>locations/global/metricsScope/{metrics_scope}</c>
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        public MetricsScopeName(string metricsScopeId) : this(ResourceNameType.MetricsScope, metricsScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricsScopeId, nameof(metricsScopeId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>MetricsScope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MetricsScopeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.MetricsScope: return s_metricsScope.Expand(MetricsScopeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetricsScopeName);

        /// <inheritdoc/>
        public bool Equals(MetricsScopeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MetricsScopeName a, MetricsScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MetricsScopeName a, MetricsScopeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MonitoredProject</c> resource.</summary>
    public sealed partial class MonitoredProjectName : gax::IResourceName, sys::IEquatable<MonitoredProjectName>
    {
        /// <summary>The possible contents of <see cref="MonitoredProjectName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>.
            /// </summary>
            MetricsScopeProject = 1,
        }

        private static gax::PathTemplate s_metricsScopeProject = new gax::PathTemplate("locations/global/metricsScopes/{metrics_scope}/projects/{project}");

        /// <summary>Creates a <see cref="MonitoredProjectName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MonitoredProjectName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MonitoredProjectName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MonitoredProjectName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MonitoredProjectName"/> with the pattern
        /// <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>.
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MonitoredProjectName"/> constructed from the provided ids.</returns>
        public static MonitoredProjectName FromMetricsScopeProject(string metricsScopeId, string projectId) =>
            new MonitoredProjectName(ResourceNameType.MetricsScopeProject, metricsScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricsScopeId, nameof(metricsScopeId)), projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredProjectName"/> with pattern
        /// <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>.
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredProjectName"/> with pattern
        /// <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>.
        /// </returns>
        public static string Format(string metricsScopeId, string projectId) =>
            FormatMetricsScopeProject(metricsScopeId, projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredProjectName"/> with pattern
        /// <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>.
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredProjectName"/> with pattern
        /// <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>.
        /// </returns>
        public static string FormatMetricsScopeProject(string metricsScopeId, string projectId) =>
            s_metricsScopeProject.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(metricsScopeId, nameof(metricsScopeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MonitoredProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="monitoredProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MonitoredProjectName"/> if successful.</returns>
        public static MonitoredProjectName Parse(string monitoredProjectName) => Parse(monitoredProjectName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MonitoredProjectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="monitoredProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MonitoredProjectName"/> if successful.</returns>
        public static MonitoredProjectName Parse(string monitoredProjectName, bool allowUnparsed) =>
            TryParse(monitoredProjectName, allowUnparsed, out MonitoredProjectName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MonitoredProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="monitoredProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MonitoredProjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredProjectName, out MonitoredProjectName result) =>
            TryParse(monitoredProjectName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MonitoredProjectName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="monitoredProjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MonitoredProjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredProjectName, bool allowUnparsed, out MonitoredProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(monitoredProjectName, nameof(monitoredProjectName));
            gax::TemplatedResourceName resourceName;
            if (s_metricsScopeProject.TryParseName(monitoredProjectName, out resourceName))
            {
                result = FromMetricsScopeProject(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(monitoredProjectName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MonitoredProjectName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string metricsScopeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MetricsScopeId = metricsScopeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MonitoredProjectName"/> class from the component parts of pattern
        /// <c>locations/global/metricsScopes/{metrics_scope}/projects/{project}</c>
        /// </summary>
        /// <param name="metricsScopeId">The <c>MetricsScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public MonitoredProjectName(string metricsScopeId, string projectId) : this(ResourceNameType.MetricsScopeProject, metricsScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricsScopeId, nameof(metricsScopeId)), projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>MetricsScope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MetricsScopeId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.MetricsScopeProject: return s_metricsScopeProject.Expand(MetricsScopeId, ProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MonitoredProjectName);

        /// <inheritdoc/>
        public bool Equals(MonitoredProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MonitoredProjectName a, MonitoredProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MonitoredProjectName a, MonitoredProjectName b) => !(a == b);
    }

    public partial class MetricsScope
    {
        /// <summary>
        /// <see cref="gcmmv::MetricsScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmmv::MetricsScopeName MetricsScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmmv::MetricsScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MonitoredProject
    {
        /// <summary>
        /// <see cref="gcmmv::MonitoredProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmmv::MonitoredProjectName MonitoredProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmmv::MonitoredProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
