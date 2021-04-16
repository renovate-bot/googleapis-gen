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
using gcwv = Google.Cloud.WebSecurityScanner.V1Beta;
using sys = System;

namespace Google.Cloud.WebSecurityScanner.V1Beta
{
    /// <summary>Resource name for the <c>ScanConfig</c> resource.</summary>
    public sealed partial class ScanConfigName : gax::IResourceName, sys::IEquatable<ScanConfigName>
    {
        /// <summary>The possible contents of <see cref="ScanConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/scanConfigs/{scan_config}</c>.</summary>
            ProjectScanConfig = 1,
        }

        private static gax::PathTemplate s_projectScanConfig = new gax::PathTemplate("projects/{project}/scanConfigs/{scan_config}");

        /// <summary>Creates a <see cref="ScanConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ScanConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ScanConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ScanConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ScanConfigName"/> with the pattern <c>projects/{project}/scanConfigs/{scan_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ScanConfigName"/> constructed from the provided ids.</returns>
        public static ScanConfigName FromProjectScanConfig(string projectId, string scanConfigId) =>
            new ScanConfigName(ResourceNameType.ProjectScanConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), scanConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(scanConfigId, nameof(scanConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScanConfigName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScanConfigName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}</c>.
        /// </returns>
        public static string Format(string projectId, string scanConfigId) => FormatProjectScanConfig(projectId, scanConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScanConfigName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScanConfigName"/> with pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}</c>.
        /// </returns>
        public static string FormatProjectScanConfig(string projectId, string scanConfigId) =>
            s_projectScanConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scanConfigId, nameof(scanConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="ScanConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/scanConfigs/{scan_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scanConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ScanConfigName"/> if successful.</returns>
        public static ScanConfigName Parse(string scanConfigName) => Parse(scanConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScanConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/scanConfigs/{scan_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scanConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ScanConfigName"/> if successful.</returns>
        public static ScanConfigName Parse(string scanConfigName, bool allowUnparsed) =>
            TryParse(scanConfigName, allowUnparsed, out ScanConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScanConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/scanConfigs/{scan_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scanConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScanConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scanConfigName, out ScanConfigName result) =>
            TryParse(scanConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScanConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/scanConfigs/{scan_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scanConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScanConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scanConfigName, bool allowUnparsed, out ScanConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(scanConfigName, nameof(scanConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectScanConfig.TryParseName(scanConfigName, out resourceName))
            {
                result = FromProjectScanConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(scanConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ScanConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string scanConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ScanConfigId = scanConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ScanConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/scanConfigs/{scan_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scanConfigId">The <c>ScanConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ScanConfigName(string projectId, string scanConfigId) : this(ResourceNameType.ProjectScanConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), scanConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(scanConfigId, nameof(scanConfigId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectScanConfig: return s_projectScanConfig.Expand(ProjectId, ScanConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ScanConfigName);

        /// <inheritdoc/>
        public bool Equals(ScanConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ScanConfigName a, ScanConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ScanConfigName a, ScanConfigName b) => !(a == b);
    }

    public partial class ScanConfig
    {
        /// <summary>
        /// <see cref="gcwv::ScanConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanConfigName ScanConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
