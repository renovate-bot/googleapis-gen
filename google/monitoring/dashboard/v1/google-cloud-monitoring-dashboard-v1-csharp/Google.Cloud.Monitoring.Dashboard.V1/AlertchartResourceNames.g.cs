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
using gcmdv = Google.Cloud.Monitoring.Dashboard.V1;
using sys = System;

namespace Google.Cloud.Monitoring.Dashboard.V1
{
    /// <summary>Resource name for the <c>AlertPolicy</c> resource.</summary>
    public sealed partial class AlertPolicyName : gax::IResourceName, sys::IEquatable<AlertPolicyName>
    {
        /// <summary>The possible contents of <see cref="AlertPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/alertPolicies/{alert_policy}</c>.</summary>
            ProjectAlertPolicy = 1,
        }

        private static gax::PathTemplate s_projectAlertPolicy = new gax::PathTemplate("projects/{project}/alertPolicies/{alert_policy}");

        /// <summary>Creates a <see cref="AlertPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AlertPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AlertPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AlertPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyName"/> with the pattern <c>projects/{project}/alertPolicies/{alert_policy}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AlertPolicyName"/> constructed from the provided ids.</returns>
        public static AlertPolicyName FromProjectAlertPolicy(string projectId, string alertPolicyId) =>
            new AlertPolicyName(ResourceNameType.ProjectAlertPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string alertPolicyId) =>
            FormatProjectAlertPolicy(projectId, alertPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </returns>
        public static string FormatProjectAlertPolicy(string projectId, string alertPolicyId) =>
            s_projectAlertPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>Parses the given resource name string into a new <see cref="AlertPolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AlertPolicyName"/> if successful.</returns>
        public static AlertPolicyName Parse(string alertPolicyName) => Parse(alertPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AlertPolicyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AlertPolicyName"/> if successful.</returns>
        public static AlertPolicyName Parse(string alertPolicyName, bool allowUnparsed) =>
            TryParse(alertPolicyName, allowUnparsed, out AlertPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AlertPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AlertPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyName, out AlertPolicyName result) =>
            TryParse(alertPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AlertPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AlertPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyName, bool allowUnparsed, out AlertPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyName, nameof(alertPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAlertPolicy.TryParseName(alertPolicyName, out resourceName))
            {
                result = FromProjectAlertPolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(alertPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AlertPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string alertPolicyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AlertPolicyId = alertPolicyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AlertPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public AlertPolicyName(string projectId, string alertPolicyId) : this(ResourceNameType.ProjectAlertPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)))
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
        /// The <c>AlertPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AlertPolicyId { get; }

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
                case ResourceNameType.ProjectAlertPolicy: return s_projectAlertPolicy.Expand(ProjectId, AlertPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AlertPolicyName);

        /// <inheritdoc/>
        public bool Equals(AlertPolicyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AlertPolicyName a, AlertPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AlertPolicyName a, AlertPolicyName b) => !(a == b);
    }

    public partial class AlertChart
    {
        /// <summary>
        /// <see cref="gcmdv::AlertPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmdv::AlertPolicyName AlertPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmdv::AlertPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
