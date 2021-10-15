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
using gctv = Google.Cloud.Tpu.V2Alpha1;
using sys = System;

namespace Google.Cloud.Tpu.V2Alpha1
{
    /// <summary>Resource name for the <c>Node</c> resource.</summary>
    public sealed partial class NodeName : gax::IResourceName, sys::IEquatable<NodeName>
    {
        /// <summary>The possible contents of <see cref="NodeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/nodes/{node}</c>.
            /// </summary>
            ProjectLocationNode = 1,
        }

        private static gax::PathTemplate s_projectLocationNode = new gax::PathTemplate("projects/{project}/locations/{location}/nodes/{node}");

        /// <summary>Creates a <see cref="NodeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NodeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NodeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NodeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NodeName"/> with the pattern <c>projects/{project}/locations/{location}/nodes/{node}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NodeName"/> constructed from the provided ids.</returns>
        public static NodeName FromProjectLocationNode(string projectId, string locationId, string nodeId) =>
            new NodeName(ResourceNameType.ProjectLocationNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodes/{node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodes/{node}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string nodeId) =>
            FormatProjectLocationNode(projectId, locationId, nodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodes/{node}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NodeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nodes/{node}</c>.
        /// </returns>
        public static string FormatProjectLocationNode(string projectId, string locationId, string nodeId) =>
            s_projectLocationNode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)));

        /// <summary>Parses the given resource name string into a new <see cref="NodeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nodes/{node}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NodeName"/> if successful.</returns>
        public static NodeName Parse(string nodeName) => Parse(nodeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NodeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nodes/{node}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NodeName"/> if successful.</returns>
        public static NodeName Parse(string nodeName, bool allowUnparsed) =>
            TryParse(nodeName, allowUnparsed, out NodeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="NodeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nodes/{node}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeName, out NodeName result) => TryParse(nodeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NodeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nodes/{node}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nodeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NodeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nodeName, bool allowUnparsed, out NodeName result)
        {
            gax::GaxPreconditions.CheckNotNull(nodeName, nameof(nodeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNode.TryParseName(nodeName, out resourceName))
            {
                result = FromProjectLocationNode(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nodeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NodeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string nodeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NodeId = nodeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NodeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/nodes/{node}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nodeId">The <c>Node</c> ID. Must not be <c>null</c> or empty.</param>
        public NodeName(string projectId, string locationId, string nodeId) : this(ResourceNameType.ProjectLocationNode, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(nodeId, nameof(nodeId)))
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
        /// The <c>Node</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NodeId { get; }

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
                case ResourceNameType.ProjectLocationNode: return s_projectLocationNode.Expand(ProjectId, LocationId, NodeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NodeName);

        /// <inheritdoc/>
        public bool Equals(NodeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(NodeName a, NodeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NodeName a, NodeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AcceleratorType</c> resource.</summary>
    public sealed partial class AcceleratorTypeName : gax::IResourceName, sys::IEquatable<AcceleratorTypeName>
    {
        /// <summary>The possible contents of <see cref="AcceleratorTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>.
            /// </summary>
            ProjectLocationAcceleratorType = 1,
        }

        private static gax::PathTemplate s_projectLocationAcceleratorType = new gax::PathTemplate("projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}");

        /// <summary>Creates a <see cref="AcceleratorTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AcceleratorTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AcceleratorTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AcceleratorTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AcceleratorTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="acceleratorTypeId">The <c>AcceleratorType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AcceleratorTypeName"/> constructed from the provided ids.</returns>
        public static AcceleratorTypeName FromProjectLocationAcceleratorType(string projectId, string locationId, string acceleratorTypeId) =>
            new AcceleratorTypeName(ResourceNameType.ProjectLocationAcceleratorType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), acceleratorTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(acceleratorTypeId, nameof(acceleratorTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AcceleratorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="acceleratorTypeId">The <c>AcceleratorType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AcceleratorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string acceleratorTypeId) =>
            FormatProjectLocationAcceleratorType(projectId, locationId, acceleratorTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AcceleratorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="acceleratorTypeId">The <c>AcceleratorType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AcceleratorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>.
        /// </returns>
        public static string FormatProjectLocationAcceleratorType(string projectId, string locationId, string acceleratorTypeId) =>
            s_projectLocationAcceleratorType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(acceleratorTypeId, nameof(acceleratorTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AcceleratorTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="acceleratorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AcceleratorTypeName"/> if successful.</returns>
        public static AcceleratorTypeName Parse(string acceleratorTypeName) => Parse(acceleratorTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AcceleratorTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="acceleratorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AcceleratorTypeName"/> if successful.</returns>
        public static AcceleratorTypeName Parse(string acceleratorTypeName, bool allowUnparsed) =>
            TryParse(acceleratorTypeName, allowUnparsed, out AcceleratorTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AcceleratorTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="acceleratorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AcceleratorTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string acceleratorTypeName, out AcceleratorTypeName result) =>
            TryParse(acceleratorTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AcceleratorTypeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="acceleratorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AcceleratorTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string acceleratorTypeName, bool allowUnparsed, out AcceleratorTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(acceleratorTypeName, nameof(acceleratorTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAcceleratorType.TryParseName(acceleratorTypeName, out resourceName))
            {
                result = FromProjectLocationAcceleratorType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(acceleratorTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AcceleratorTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string acceleratorTypeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AcceleratorTypeId = acceleratorTypeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AcceleratorTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="acceleratorTypeId">The <c>AcceleratorType</c> ID. Must not be <c>null</c> or empty.</param>
        public AcceleratorTypeName(string projectId, string locationId, string acceleratorTypeId) : this(ResourceNameType.ProjectLocationAcceleratorType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), acceleratorTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(acceleratorTypeId, nameof(acceleratorTypeId)))
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
        /// The <c>AcceleratorType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AcceleratorTypeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationAcceleratorType: return s_projectLocationAcceleratorType.Expand(ProjectId, LocationId, AcceleratorTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AcceleratorTypeName);

        /// <inheritdoc/>
        public bool Equals(AcceleratorTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AcceleratorTypeName a, AcceleratorTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AcceleratorTypeName a, AcceleratorTypeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RuntimeVersion</c> resource.</summary>
    public sealed partial class RuntimeVersionName : gax::IResourceName, sys::IEquatable<RuntimeVersionName>
    {
        /// <summary>The possible contents of <see cref="RuntimeVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>.
            /// </summary>
            ProjectLocationRuntimeVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationRuntimeVersion = new gax::PathTemplate("projects/{project}/locations/{location}/runtimeVersions/{runtime_version}");

        /// <summary>Creates a <see cref="RuntimeVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RuntimeVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RuntimeVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RuntimeVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RuntimeVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeVersionId">The <c>RuntimeVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RuntimeVersionName"/> constructed from the provided ids.</returns>
        public static RuntimeVersionName FromProjectLocationRuntimeVersion(string projectId, string locationId, string runtimeVersionId) =>
            new RuntimeVersionName(ResourceNameType.ProjectLocationRuntimeVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), runtimeVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeVersionId, nameof(runtimeVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuntimeVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeVersionId">The <c>RuntimeVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuntimeVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string runtimeVersionId) =>
            FormatProjectLocationRuntimeVersion(projectId, locationId, runtimeVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuntimeVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeVersionId">The <c>RuntimeVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuntimeVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>.
        /// </returns>
        public static string FormatProjectLocationRuntimeVersion(string projectId, string locationId, string runtimeVersionId) =>
            s_projectLocationRuntimeVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeVersionId, nameof(runtimeVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuntimeVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="runtimeVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RuntimeVersionName"/> if successful.</returns>
        public static RuntimeVersionName Parse(string runtimeVersionName) => Parse(runtimeVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuntimeVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runtimeVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RuntimeVersionName"/> if successful.</returns>
        public static RuntimeVersionName Parse(string runtimeVersionName, bool allowUnparsed) =>
            TryParse(runtimeVersionName, allowUnparsed, out RuntimeVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuntimeVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="runtimeVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuntimeVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runtimeVersionName, out RuntimeVersionName result) =>
            TryParse(runtimeVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuntimeVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runtimeVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuntimeVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runtimeVersionName, bool allowUnparsed, out RuntimeVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(runtimeVersionName, nameof(runtimeVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRuntimeVersion.TryParseName(runtimeVersionName, out resourceName))
            {
                result = FromProjectLocationRuntimeVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(runtimeVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RuntimeVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string runtimeVersionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RuntimeVersionId = runtimeVersionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RuntimeVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/runtimeVersions/{runtime_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeVersionId">The <c>RuntimeVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public RuntimeVersionName(string projectId, string locationId, string runtimeVersionId) : this(ResourceNameType.ProjectLocationRuntimeVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), runtimeVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeVersionId, nameof(runtimeVersionId)))
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
        /// The <c>RuntimeVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RuntimeVersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRuntimeVersion: return s_projectLocationRuntimeVersion.Expand(ProjectId, LocationId, RuntimeVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RuntimeVersionName);

        /// <inheritdoc/>
        public bool Equals(RuntimeVersionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RuntimeVersionName a, RuntimeVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RuntimeVersionName a, RuntimeVersionName b) => !(a == b);
    }

    public partial class Node
    {
        /// <summary>
        /// <see cref="gctv::NodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::NodeName NodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::NodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNodesRequest
    {
        /// <summary><see cref="NodeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public NodeName ParentAsNodeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NodeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetNodeRequest
    {
        /// <summary>
        /// <see cref="gctv::NodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::NodeName NodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::NodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNodeRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNodeRequest
    {
        /// <summary>
        /// <see cref="gctv::NodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::NodeName NodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::NodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateServiceIdentityRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AcceleratorType
    {
        /// <summary>
        /// <see cref="gctv::AcceleratorTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AcceleratorTypeName AcceleratorTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AcceleratorTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAcceleratorTypeRequest
    {
        /// <summary>
        /// <see cref="gctv::AcceleratorTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AcceleratorTypeName AcceleratorTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AcceleratorTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAcceleratorTypesRequest
    {
        /// <summary>
        /// <see cref="AcceleratorTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AcceleratorTypeName ParentAsAcceleratorTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AcceleratorTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RuntimeVersion
    {
        /// <summary>
        /// <see cref="gctv::RuntimeVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::RuntimeVersionName RuntimeVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::RuntimeVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetRuntimeVersionRequest
    {
        /// <summary>
        /// <see cref="gctv::RuntimeVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::RuntimeVersionName RuntimeVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::RuntimeVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRuntimeVersionsRequest
    {
        /// <summary>
        /// <see cref="RuntimeVersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RuntimeVersionName ParentAsRuntimeVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RuntimeVersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGuestAttributesRequest
    {
        /// <summary>
        /// <see cref="gctv::NodeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::NodeName NodeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::NodeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
