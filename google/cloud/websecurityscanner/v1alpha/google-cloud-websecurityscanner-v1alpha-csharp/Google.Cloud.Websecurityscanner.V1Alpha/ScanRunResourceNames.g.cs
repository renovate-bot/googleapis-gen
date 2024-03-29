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
using gcwv = Google.Cloud.Websecurityscanner.V1Alpha;
using sys = System;

namespace Google.Cloud.Websecurityscanner.V1Alpha
{
    /// <summary>Resource name for the <c>ScanRun</c> resource.</summary>
    public sealed partial class ScanRunName : gax::IResourceName, sys::IEquatable<ScanRunName>
    {
        /// <summary>The possible contents of <see cref="ScanRunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>.
            /// </summary>
            ProjectScanConfigScanRun = 1,
        }

        private static gax::PathTemplate s_projectScanConfigScanRun = new gax::PathTemplate("projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}");

        /// <summary>Creates a <see cref="ScanRunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ScanRunName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ScanRunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ScanRunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ScanRunName"/> with the pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanRunId">The <c>ScanRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ScanRunName"/> constructed from the provided ids.</returns>
        public static ScanRunName FromProjectScanConfigScanRun(string projectId, string scanConfigId, string scanRunId) =>
            new ScanRunName(ResourceNameType.ProjectScanConfigScanRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), scanConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(scanConfigId, nameof(scanConfigId)), scanRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(scanRunId, nameof(scanRunId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScanRunName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanRunId">The <c>ScanRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScanRunName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>.
        /// </returns>
        public static string Format(string projectId, string scanConfigId, string scanRunId) =>
            FormatProjectScanConfigScanRun(projectId, scanConfigId, scanRunId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScanRunName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanRunId">The <c>ScanRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScanRunName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>.
        /// </returns>
        public static string FormatProjectScanConfigScanRun(string projectId, string scanConfigId, string scanRunId) =>
            s_projectScanConfigScanRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scanConfigId, nameof(scanConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scanRunId, nameof(scanRunId)));

        /// <summary>Parses the given resource name string into a new <see cref="ScanRunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="scanRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ScanRunName"/> if successful.</returns>
        public static ScanRunName Parse(string scanRunName) => Parse(scanRunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScanRunName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scanRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ScanRunName"/> if successful.</returns>
        public static ScanRunName Parse(string scanRunName, bool allowUnparsed) =>
            TryParse(scanRunName, allowUnparsed, out ScanRunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScanRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="scanRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScanRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scanRunName, out ScanRunName result) => TryParse(scanRunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScanRunName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scanRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScanRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scanRunName, bool allowUnparsed, out ScanRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(scanRunName, nameof(scanRunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectScanConfigScanRun.TryParseName(scanRunName, out resourceName))
            {
                result = FromProjectScanConfigScanRun(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(scanRunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ScanRunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string scanConfigId = null, string scanRunId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ScanConfigId = scanConfigId;
            ScanRunId = scanRunId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ScanRunName"/> class from the component parts of pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanRunId">The <c>ScanRun</c> ID. Must not be <c>null</c> or empty.</param>
        public ScanRunName(string projectId, string scanConfigId, string scanRunId) : this(ResourceNameType.ProjectScanConfigScanRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), scanConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(scanConfigId, nameof(scanConfigId)), scanRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(scanRunId, nameof(scanRunId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ScanConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScanConfigId { get; }

        /// <summary>
        /// The <c>ScanRun</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScanRunId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectScanConfigScanRun: return s_projectScanConfigScanRun.Expand(ProjectId, ScanConfigId, ScanRunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ScanRunName);

        /// <inheritdoc/>
        public bool Equals(ScanRunName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ScanRunName a, ScanRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ScanRunName a, ScanRunName b) => !(a == b);
    }

    public partial class ScanRun
    {
        /// <summary>
        /// <see cref="gcwv::ScanRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanRunName ScanRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
