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
using gagr = Google.Api.Gax.ResourceNames;
using giv = Google.Iam.V1Beta;
using sys = System;

namespace Google.Iam.V1Beta
{
    /// <summary>Resource name for the <c>WorkloadIdentityPool</c> resource.</summary>
    public sealed partial class WorkloadIdentityPoolName : gax::IResourceName, sys::IEquatable<WorkloadIdentityPoolName>
    {
        /// <summary>The possible contents of <see cref="WorkloadIdentityPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>.
            /// </summary>
            ProjectLocationWorkloadIdentityPool = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkloadIdentityPool = new gax::PathTemplate("projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}");

        /// <summary>Creates a <see cref="WorkloadIdentityPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkloadIdentityPoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkloadIdentityPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkloadIdentityPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkloadIdentityPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="WorkloadIdentityPoolName"/> constructed from the provided ids.
        /// </returns>
        public static WorkloadIdentityPoolName FromProjectLocationWorkloadIdentityPool(string projectId, string locationId, string workloadIdentityPoolId) =>
            new WorkloadIdentityPoolName(ResourceNameType.ProjectLocationWorkloadIdentityPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadIdentityPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadIdentityPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadIdentityPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workloadIdentityPoolId) =>
            FormatProjectLocationWorkloadIdentityPool(projectId, locationId, workloadIdentityPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadIdentityPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadIdentityPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkloadIdentityPool(string projectId, string locationId, string workloadIdentityPoolId) =>
            s_projectLocationWorkloadIdentityPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkloadIdentityPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadIdentityPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkloadIdentityPoolName"/> if successful.</returns>
        public static WorkloadIdentityPoolName Parse(string workloadIdentityPoolName) =>
            Parse(workloadIdentityPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkloadIdentityPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadIdentityPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkloadIdentityPoolName"/> if successful.</returns>
        public static WorkloadIdentityPoolName Parse(string workloadIdentityPoolName, bool allowUnparsed) =>
            TryParse(workloadIdentityPoolName, allowUnparsed, out WorkloadIdentityPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadIdentityPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadIdentityPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadIdentityPoolName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadIdentityPoolName, out WorkloadIdentityPoolName result) =>
            TryParse(workloadIdentityPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadIdentityPoolName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadIdentityPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadIdentityPoolName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadIdentityPoolName, bool allowUnparsed, out WorkloadIdentityPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolName, nameof(workloadIdentityPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkloadIdentityPool.TryParseName(workloadIdentityPoolName, out resourceName))
            {
                result = FromProjectLocationWorkloadIdentityPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workloadIdentityPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkloadIdentityPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workloadIdentityPoolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkloadIdentityPoolId = workloadIdentityPoolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkloadIdentityPoolName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public WorkloadIdentityPoolName(string projectId, string locationId, string workloadIdentityPoolId) : this(ResourceNameType.ProjectLocationWorkloadIdentityPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadIdentityPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>WorkloadIdentityPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string WorkloadIdentityPoolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkloadIdentityPool: return s_projectLocationWorkloadIdentityPool.Expand(ProjectId, LocationId, WorkloadIdentityPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkloadIdentityPoolName);

        /// <inheritdoc/>
        public bool Equals(WorkloadIdentityPoolName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WorkloadIdentityPoolName a, WorkloadIdentityPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WorkloadIdentityPoolName a, WorkloadIdentityPoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WorkloadIdentityPoolProvider</c> resource.</summary>
    public sealed partial class WorkloadIdentityPoolProviderName : gax::IResourceName, sys::IEquatable<WorkloadIdentityPoolProviderName>
    {
        /// <summary>The possible contents of <see cref="WorkloadIdentityPoolProviderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
            /// .
            /// </summary>
            ProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider = new gax::PathTemplate("projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}");

        /// <summary>
        /// Creates a <see cref="WorkloadIdentityPoolProviderName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkloadIdentityPoolProviderName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkloadIdentityPoolProviderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkloadIdentityPoolProviderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkloadIdentityPoolProviderName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// The <c>WorkloadIdentityPoolProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="WorkloadIdentityPoolProviderName"/> constructed from the provided ids.
        /// </returns>
        public static WorkloadIdentityPoolProviderName FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider(string projectId, string locationId, string workloadIdentityPoolId, string workloadIdentityPoolProviderId) =>
            new WorkloadIdentityPoolProviderName(ResourceNameType.ProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadIdentityPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)), workloadIdentityPoolProviderId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadIdentityPoolProviderName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// The <c>WorkloadIdentityPoolProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadIdentityPoolProviderName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string workloadIdentityPoolId, string workloadIdentityPoolProviderId) =>
            FormatProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider(projectId, locationId, workloadIdentityPoolId, workloadIdentityPoolProviderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadIdentityPoolProviderName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// The <c>WorkloadIdentityPoolProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadIdentityPoolProviderName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider(string projectId, string locationId, string workloadIdentityPoolId, string workloadIdentityPoolProviderId) =>
            s_projectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkloadIdentityPoolProviderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadIdentityPoolProviderName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="WorkloadIdentityPoolProviderName"/> if successful.</returns>
        public static WorkloadIdentityPoolProviderName Parse(string workloadIdentityPoolProviderName) =>
            Parse(workloadIdentityPoolProviderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkloadIdentityPoolProviderName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadIdentityPoolProviderName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkloadIdentityPoolProviderName"/> if successful.</returns>
        public static WorkloadIdentityPoolProviderName Parse(string workloadIdentityPoolProviderName, bool allowUnparsed) =>
            TryParse(workloadIdentityPoolProviderName, allowUnparsed, out WorkloadIdentityPoolProviderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadIdentityPoolProviderName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadIdentityPoolProviderName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadIdentityPoolProviderName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadIdentityPoolProviderName, out WorkloadIdentityPoolProviderName result) =>
            TryParse(workloadIdentityPoolProviderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadIdentityPoolProviderName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadIdentityPoolProviderName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadIdentityPoolProviderName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadIdentityPoolProviderName, bool allowUnparsed, out WorkloadIdentityPoolProviderName result)
        {
            gax::GaxPreconditions.CheckNotNull(workloadIdentityPoolProviderName, nameof(workloadIdentityPoolProviderName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider.TryParseName(workloadIdentityPoolProviderName, out resourceName))
            {
                result = FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workloadIdentityPoolProviderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkloadIdentityPoolProviderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workloadIdentityPoolId = null, string workloadIdentityPoolProviderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkloadIdentityPoolId = workloadIdentityPoolId;
            WorkloadIdentityPoolProviderId = workloadIdentityPoolProviderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkloadIdentityPoolProviderName"/> class from the component parts
        /// of pattern
        /// <c>
        /// projects/{project}/locations/{location}/workloadIdentityPools/{workload_identity_pool}/providers/{workload_identity_pool_provider}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadIdentityPoolId">
        /// The <c>WorkloadIdentityPool</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="workloadIdentityPoolProviderId">
        /// The <c>WorkloadIdentityPoolProvider</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public WorkloadIdentityPoolProviderName(string projectId, string locationId, string workloadIdentityPoolId, string workloadIdentityPoolProviderId) : this(ResourceNameType.ProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadIdentityPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolId, nameof(workloadIdentityPoolId)), workloadIdentityPoolProviderId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadIdentityPoolProviderId, nameof(workloadIdentityPoolProviderId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>WorkloadIdentityPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string WorkloadIdentityPoolId { get; }

        /// <summary>
        /// The <c>WorkloadIdentityPoolProvider</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string WorkloadIdentityPoolProviderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider: return s_projectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider.Expand(ProjectId, LocationId, WorkloadIdentityPoolId, WorkloadIdentityPoolProviderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkloadIdentityPoolProviderName);

        /// <inheritdoc/>
        public bool Equals(WorkloadIdentityPoolProviderName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WorkloadIdentityPoolProviderName a, WorkloadIdentityPoolProviderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WorkloadIdentityPoolProviderName a, WorkloadIdentityPoolProviderName b) => !(a == b);
    }

    public partial class WorkloadIdentityPool
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giv::WorkloadIdentityPoolName WorkloadIdentityPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WorkloadIdentityPoolProvider
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolProviderName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public giv::WorkloadIdentityPoolProviderName WorkloadIdentityPoolProviderName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolProviderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkloadIdentityPoolsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkloadIdentityPoolRequest
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giv::WorkloadIdentityPoolName WorkloadIdentityPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkloadIdentityPoolRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkloadIdentityPoolRequest
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giv::WorkloadIdentityPoolName WorkloadIdentityPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeleteWorkloadIdentityPoolRequest
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giv::WorkloadIdentityPoolName WorkloadIdentityPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkloadIdentityPoolProvidersRequest
    {
        /// <summary>
        /// <see cref="WorkloadIdentityPoolName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkloadIdentityPoolName ParentAsWorkloadIdentityPoolName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkloadIdentityPoolName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkloadIdentityPoolProviderRequest
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolProviderName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public giv::WorkloadIdentityPoolProviderName WorkloadIdentityPoolProviderName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolProviderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkloadIdentityPoolProviderRequest
    {
        /// <summary>
        /// <see cref="WorkloadIdentityPoolName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkloadIdentityPoolName ParentAsWorkloadIdentityPoolName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkloadIdentityPoolName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkloadIdentityPoolProviderRequest
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolProviderName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public giv::WorkloadIdentityPoolProviderName WorkloadIdentityPoolProviderName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolProviderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeleteWorkloadIdentityPoolProviderRequest
    {
        /// <summary>
        /// <see cref="giv::WorkloadIdentityPoolProviderName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public giv::WorkloadIdentityPoolProviderName WorkloadIdentityPoolProviderName
        {
            get => string.IsNullOrEmpty(Name) ? null : giv::WorkloadIdentityPoolProviderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
