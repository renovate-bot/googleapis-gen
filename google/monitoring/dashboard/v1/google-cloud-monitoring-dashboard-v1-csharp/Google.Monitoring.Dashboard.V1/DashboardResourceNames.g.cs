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
using gmdv = Google.Monitoring.Dashboard.V1;
using sys = System;

namespace Google.Monitoring.Dashboard.V1
{
    /// <summary>Resource name for the <c>Dashboard</c> resource.</summary>
    public sealed partial class DashboardName : gax::IResourceName, sys::IEquatable<DashboardName>
    {
        /// <summary>The possible contents of <see cref="DashboardName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/dashboards/{dashboard}</c>.</summary>
            ProjectDashboard = 1,
        }

        private static gax::PathTemplate s_projectDashboard = new gax::PathTemplate("projects/{project}/dashboards/{dashboard}");

        /// <summary>Creates a <see cref="DashboardName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DashboardName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DashboardName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DashboardName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DashboardName"/> with the pattern <c>projects/{project}/dashboards/{dashboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DashboardName"/> constructed from the provided ids.</returns>
        public static DashboardName FromProjectDashboard(string projectId, string dashboardId) =>
            new DashboardName(ResourceNameType.ProjectDashboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dashboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(dashboardId, nameof(dashboardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DashboardName"/> with pattern
        /// <c>projects/{project}/dashboards/{dashboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DashboardName"/> with pattern
        /// <c>projects/{project}/dashboards/{dashboard}</c>.
        /// </returns>
        public static string Format(string projectId, string dashboardId) => FormatProjectDashboard(projectId, dashboardId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DashboardName"/> with pattern
        /// <c>projects/{project}/dashboards/{dashboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DashboardName"/> with pattern
        /// <c>projects/{project}/dashboards/{dashboard}</c>.
        /// </returns>
        public static string FormatProjectDashboard(string projectId, string dashboardId) =>
            s_projectDashboard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dashboardId, nameof(dashboardId)));

        /// <summary>Parses the given resource name string into a new <see cref="DashboardName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dashboards/{dashboard}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DashboardName"/> if successful.</returns>
        public static DashboardName Parse(string dashboardName) => Parse(dashboardName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DashboardName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dashboards/{dashboard}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DashboardName"/> if successful.</returns>
        public static DashboardName Parse(string dashboardName, bool allowUnparsed) =>
            TryParse(dashboardName, allowUnparsed, out DashboardName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DashboardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dashboards/{dashboard}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DashboardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dashboardName, out DashboardName result) => TryParse(dashboardName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DashboardName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dashboards/{dashboard}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DashboardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dashboardName, bool allowUnparsed, out DashboardName result)
        {
            gax::GaxPreconditions.CheckNotNull(dashboardName, nameof(dashboardName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDashboard.TryParseName(dashboardName, out resourceName))
            {
                result = FromProjectDashboard(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dashboardName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DashboardName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dashboardId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DashboardId = dashboardId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DashboardName"/> class from the component parts of pattern
        /// <c>projects/{project}/dashboards/{dashboard}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        public DashboardName(string projectId, string dashboardId) : this(ResourceNameType.ProjectDashboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dashboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(dashboardId, nameof(dashboardId)))
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
        /// The <c>Dashboard</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DashboardId { get; }

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
                case ResourceNameType.ProjectDashboard: return s_projectDashboard.Expand(ProjectId, DashboardId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DashboardName);

        /// <inheritdoc/>
        public bool Equals(DashboardName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DashboardName a, DashboardName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DashboardName a, DashboardName b) => !(a == b);
    }

    public partial class Dashboard
    {
        /// <summary>
        /// <see cref="gmdv::DashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmdv::DashboardName DashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmdv::DashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
