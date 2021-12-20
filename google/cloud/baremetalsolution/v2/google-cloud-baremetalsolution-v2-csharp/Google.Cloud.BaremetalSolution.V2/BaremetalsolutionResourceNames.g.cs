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
using gcbv = Google.Cloud.BaremetalSolution.V2;
using sys = System;

namespace Google.Cloud.BaremetalSolution.V2
{
    /// <summary>Resource name for the <c>Volume</c> resource.</summary>
    public sealed partial class VolumeName : gax::IResourceName, sys::IEquatable<VolumeName>
    {
        /// <summary>The possible contents of <see cref="VolumeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
            /// </summary>
            ProjectLocationVolume = 1,
        }

        private static gax::PathTemplate s_projectLocationVolume = new gax::PathTemplate("projects/{project}/locations/{location}/volumes/{volume}");

        /// <summary>Creates a <see cref="VolumeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeName"/> constructed from the provided ids.</returns>
        public static VolumeName FromProjectLocationVolume(string projectId, string locationId, string volumeId) =>
            new VolumeName(ResourceNameType.ProjectLocationVolume, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeId) =>
            FormatProjectLocationVolume(projectId, locationId, volumeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </returns>
        public static string FormatProjectLocationVolume(string projectId, string locationId, string volumeId) =>
            s_projectLocationVolume.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)));

        /// <summary>Parses the given resource name string into a new <see cref="VolumeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeName"/> if successful.</returns>
        public static VolumeName Parse(string volumeName) => Parse(volumeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeName"/> if successful.</returns>
        public static VolumeName Parse(string volumeName, bool allowUnparsed) =>
            TryParse(volumeName, allowUnparsed, out VolumeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeName, out VolumeName result) => TryParse(volumeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeName, bool allowUnparsed, out VolumeName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeName, nameof(volumeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolume.TryParseName(volumeName, out resourceName))
            {
                result = FromProjectLocationVolume(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string volumeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VolumeId = volumeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeName(string projectId, string locationId, string volumeId) : this(ResourceNameType.ProjectLocationVolume, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)))
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
        /// The <c>Volume</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VolumeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVolume: return s_projectLocationVolume.Expand(ProjectId, LocationId, VolumeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeName);

        /// <inheritdoc/>
        public bool Equals(VolumeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(VolumeName a, VolumeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(VolumeName a, VolumeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Lun</c> resource.</summary>
    public sealed partial class LunName : gax::IResourceName, sys::IEquatable<LunName>
    {
        /// <summary>The possible contents of <see cref="LunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>.
            /// </summary>
            ProjectLocationVolumeLun = 1,
        }

        private static gax::PathTemplate s_projectLocationVolumeLun = new gax::PathTemplate("projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}");

        /// <summary>Creates a <see cref="LunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LunName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LunName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lunId">The <c>Lun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LunName"/> constructed from the provided ids.</returns>
        public static LunName FromProjectLocationVolumeLun(string projectId, string locationId, string volumeId, string lunId) =>
            new LunName(ResourceNameType.ProjectLocationVolumeLun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), lunId: gax::GaxPreconditions.CheckNotNullOrEmpty(lunId, nameof(lunId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lunId">The <c>Lun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeId, string lunId) =>
            FormatProjectLocationVolumeLun(projectId, locationId, volumeId, lunId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lunId">The <c>Lun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>.
        /// </returns>
        public static string FormatProjectLocationVolumeLun(string projectId, string locationId, string volumeId, string lunId) =>
            s_projectLocationVolumeLun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lunId, nameof(lunId)));

        /// <summary>Parses the given resource name string into a new <see cref="LunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LunName"/> if successful.</returns>
        public static LunName Parse(string lunName) => Parse(lunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LunName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LunName"/> if successful.</returns>
        public static LunName Parse(string lunName, bool allowUnparsed) =>
            TryParse(lunName, allowUnparsed, out LunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="LunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lunName, out LunName result) => TryParse(lunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LunName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lunName, bool allowUnparsed, out LunName result)
        {
            gax::GaxPreconditions.CheckNotNull(lunName, nameof(lunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolumeLun.TryParseName(lunName, out resourceName))
            {
                result = FromProjectLocationVolumeLun(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string lunId = null, string projectId = null, string volumeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            LunId = lunId;
            ProjectId = projectId;
            VolumeId = volumeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LunName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lunId">The <c>Lun</c> ID. Must not be <c>null</c> or empty.</param>
        public LunName(string projectId, string locationId, string volumeId, string lunId) : this(ResourceNameType.ProjectLocationVolumeLun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), lunId: gax::GaxPreconditions.CheckNotNullOrEmpty(lunId, nameof(lunId)))
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
        /// The <c>Lun</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LunId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Volume</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VolumeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVolumeLun: return s_projectLocationVolumeLun.Expand(ProjectId, LocationId, VolumeId, LunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LunName);

        /// <inheritdoc/>
        public bool Equals(LunName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(LunName a, LunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(LunName a, LunName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/networks/{network}</c>.
            /// </summary>
            ProjectLocationNetwork = 1,
        }

        private static gax::PathTemplate s_projectLocationNetwork = new gax::PathTemplate("projects/{project}/locations/{location}/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectLocationNetwork(string projectId, string locationId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectLocationNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string networkId) =>
            FormatProjectLocationNetwork(projectId, locationId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectLocationNetwork(string projectId, string locationId, string networkId) =>
            s_projectLocationNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectLocationNetwork(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string locationId, string networkId) : this(ResourceNameType.ProjectLocationNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

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
                case ResourceNameType.ProjectLocationNetwork: return s_projectLocationNetwork.Expand(ProjectId, LocationId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        /// <summary>The possible contents of <see cref="InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/instances/{instance}</c>.
            /// </summary>
            ProjectLocationInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationInstance = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}");

        /// <summary>Creates a <see cref="InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceName"/> constructed from the provided ids.</returns>
        public static InstanceName FromProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            new InstanceName(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId) =>
            FormatProjectLocationInstance(projectId, locationId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            s_projectLocationInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="InstanceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName) => Parse(instanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName, bool allowUnparsed) =>
            TryParse(instanceName, allowUnparsed, out InstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result) => TryParse(instanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, bool allowUnparsed, out InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectLocationInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string locationId, string instanceId) : this(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstance: return s_projectLocationInstance.Expand(ProjectId, LocationId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc/>
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>VolumeSnapshot</c> resource.</summary>
    public sealed partial class VolumeSnapshotName : gax::IResourceName, sys::IEquatable<VolumeSnapshotName>
    {
        /// <summary>The possible contents of <see cref="VolumeSnapshotName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
            /// </summary>
            ProjectLocationVolumeSnapshot = 1,
        }

        private static gax::PathTemplate s_projectLocationVolumeSnapshot = new gax::PathTemplate("projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}");

        /// <summary>Creates a <see cref="VolumeSnapshotName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeSnapshotName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeSnapshotName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeSnapshotName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeSnapshotName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeSnapshotName"/> constructed from the provided ids.</returns>
        public static VolumeSnapshotName FromProjectLocationVolumeSnapshot(string projectId, string locationId, string volumeId, string snapshotId) =>
            new VolumeSnapshotName(ResourceNameType.ProjectLocationVolumeSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeId, string snapshotId) =>
            FormatProjectLocationVolumeSnapshot(projectId, locationId, volumeId, snapshotId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string FormatProjectLocationVolumeSnapshot(string projectId, string locationId, string volumeId, string snapshotId) =>
            s_projectLocationVolumeSnapshot.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeSnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeSnapshotName"/> if successful.</returns>
        public static VolumeSnapshotName Parse(string volumeSnapshotName) => Parse(volumeSnapshotName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeSnapshotName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeSnapshotName"/> if successful.</returns>
        public static VolumeSnapshotName Parse(string volumeSnapshotName, bool allowUnparsed) =>
            TryParse(volumeSnapshotName, allowUnparsed, out VolumeSnapshotName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeSnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeSnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeSnapshotName, out VolumeSnapshotName result) =>
            TryParse(volumeSnapshotName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeSnapshotName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeSnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeSnapshotName, bool allowUnparsed, out VolumeSnapshotName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeSnapshotName, nameof(volumeSnapshotName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolumeSnapshot.TryParseName(volumeSnapshotName, out resourceName))
            {
                result = FromProjectLocationVolumeSnapshot(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeSnapshotName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeSnapshotName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string snapshotId = null, string volumeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SnapshotId = snapshotId;
            VolumeId = volumeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeSnapshotName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeSnapshotName(string projectId, string locationId, string volumeId, string snapshotId) : this(ResourceNameType.ProjectLocationVolumeSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)))
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
        /// The <c>Snapshot</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SnapshotId { get; }

        /// <summary>
        /// The <c>Volume</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VolumeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVolumeSnapshot: return s_projectLocationVolumeSnapshot.Expand(ProjectId, LocationId, VolumeId, SnapshotId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeSnapshotName);

        /// <inheritdoc/>
        public bool Equals(VolumeSnapshotName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(VolumeSnapshotName a, VolumeSnapshotName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(VolumeSnapshotName a, VolumeSnapshotName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SnapshotSchedulePolicy</c> resource.</summary>
    public sealed partial class SnapshotSchedulePolicyName : gax::IResourceName, sys::IEquatable<SnapshotSchedulePolicyName>
    {
        /// <summary>The possible contents of <see cref="SnapshotSchedulePolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>.
            /// </summary>
            ProjectLocationSnapshotSchedulePolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationSnapshotSchedulePolicy = new gax::PathTemplate("projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}");

        /// <summary>Creates a <see cref="SnapshotSchedulePolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SnapshotSchedulePolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SnapshotSchedulePolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SnapshotSchedulePolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SnapshotSchedulePolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotSchedulePolicyId">
        /// The <c>SnapshotSchedulePolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SnapshotSchedulePolicyName"/> constructed from the provided ids.
        /// </returns>
        public static SnapshotSchedulePolicyName FromProjectLocationSnapshotSchedulePolicy(string projectId, string locationId, string snapshotSchedulePolicyId) =>
            new SnapshotSchedulePolicyName(ResourceNameType.ProjectLocationSnapshotSchedulePolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), snapshotSchedulePolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotSchedulePolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotSchedulePolicyId">
        /// The <c>SnapshotSchedulePolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotSchedulePolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string snapshotSchedulePolicyId) =>
            FormatProjectLocationSnapshotSchedulePolicy(projectId, locationId, snapshotSchedulePolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotSchedulePolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotSchedulePolicyId">
        /// The <c>SnapshotSchedulePolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotSchedulePolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationSnapshotSchedulePolicy(string projectId, string locationId, string snapshotSchedulePolicyId) =>
            s_projectLocationSnapshotSchedulePolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SnapshotSchedulePolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="snapshotSchedulePolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SnapshotSchedulePolicyName"/> if successful.</returns>
        public static SnapshotSchedulePolicyName Parse(string snapshotSchedulePolicyName) =>
            Parse(snapshotSchedulePolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SnapshotSchedulePolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snapshotSchedulePolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SnapshotSchedulePolicyName"/> if successful.</returns>
        public static SnapshotSchedulePolicyName Parse(string snapshotSchedulePolicyName, bool allowUnparsed) =>
            TryParse(snapshotSchedulePolicyName, allowUnparsed, out SnapshotSchedulePolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnapshotSchedulePolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="snapshotSchedulePolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnapshotSchedulePolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotSchedulePolicyName, out SnapshotSchedulePolicyName result) =>
            TryParse(snapshotSchedulePolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnapshotSchedulePolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snapshotSchedulePolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnapshotSchedulePolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotSchedulePolicyName, bool allowUnparsed, out SnapshotSchedulePolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicyName, nameof(snapshotSchedulePolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSnapshotSchedulePolicy.TryParseName(snapshotSchedulePolicyName, out resourceName))
            {
                result = FromProjectLocationSnapshotSchedulePolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(snapshotSchedulePolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SnapshotSchedulePolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string snapshotSchedulePolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SnapshotSchedulePolicyId = snapshotSchedulePolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SnapshotSchedulePolicyName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotSchedulePolicyId">
        /// The <c>SnapshotSchedulePolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SnapshotSchedulePolicyName(string projectId, string locationId, string snapshotSchedulePolicyId) : this(ResourceNameType.ProjectLocationSnapshotSchedulePolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), snapshotSchedulePolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)))
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
        /// The <c>SnapshotSchedulePolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SnapshotSchedulePolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSnapshotSchedulePolicy: return s_projectLocationSnapshotSchedulePolicy.Expand(ProjectId, LocationId, SnapshotSchedulePolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SnapshotSchedulePolicyName);

        /// <inheritdoc/>
        public bool Equals(SnapshotSchedulePolicyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SnapshotSchedulePolicyName a, SnapshotSchedulePolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SnapshotSchedulePolicyName a, SnapshotSchedulePolicyName b) => !(a == b);
    }

    public partial class Volume
    {
        /// <summary>
        /// <see cref="gcbv::VolumeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeName VolumeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SnapshotSchedulePolicyName"/>-typed view over the <see cref="SnapshotSchedulePolicy"/> resource
        /// name property.
        /// </summary>
        public SnapshotSchedulePolicyName SnapshotSchedulePolicyAsSnapshotSchedulePolicyName
        {
            get => string.IsNullOrEmpty(SnapshotSchedulePolicy) ? null : SnapshotSchedulePolicyName.Parse(SnapshotSchedulePolicy, allowUnparsed: true);
            set => SnapshotSchedulePolicy = value?.ToString() ?? "";
        }
    }

    public partial class ListVolumesRequest
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

    public partial class GetVolumeRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeName VolumeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Lun
    {
        /// <summary>
        /// <see cref="gcbv::LunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::LunName LunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::LunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VolumeName"/>-typed view over the <see cref="StorageVolume"/> resource name property.
        /// </summary>
        public VolumeName StorageVolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(StorageVolume) ? null : VolumeName.Parse(StorageVolume, allowUnparsed: true);
            set => StorageVolume = value?.ToString() ?? "";
        }
    }

    public partial class Network
    {
        /// <summary>
        /// <see cref="gcbv::NetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NetworkName NetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNetworksRequest
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

    public partial class GetNetworkRequest
    {
        /// <summary>
        /// <see cref="gcbv::NetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NetworkName NetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSnapshotSchedulePolicyRequest
    {
        /// <summary>
        /// <see cref="gcbv::SnapshotSchedulePolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::SnapshotSchedulePolicyName SnapshotSchedulePolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::SnapshotSchedulePolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcbv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
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

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcbv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcbv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetVolumeSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeSnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeSnapshotName VolumeSnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeSnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVolumeSnapshotsRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVolumeSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeSnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeSnapshotName VolumeSnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeSnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class VolumeSnapshot
    {
        /// <summary>
        /// <see cref="gcbv::VolumeSnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeSnapshotName VolumeSnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeSnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VolumeName"/>-typed view over the <see cref="StorageVolume"/> resource name property.
        /// </summary>
        public VolumeName StorageVolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(StorageVolume) ? null : VolumeName.Parse(StorageVolume, allowUnparsed: true);
            set => StorageVolume = value?.ToString() ?? "";
        }
    }

    public partial class SnapshotSchedulePolicy
    {
        /// <summary>
        /// <see cref="gcbv::SnapshotSchedulePolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::SnapshotSchedulePolicyName SnapshotSchedulePolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::SnapshotSchedulePolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSnapshotSchedulePoliciesRequest
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

    public partial class CreateSnapshotSchedulePolicyRequest
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

    public partial class DeleteSnapshotSchedulePolicyRequest
    {
        /// <summary>
        /// <see cref="gcbv::SnapshotSchedulePolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::SnapshotSchedulePolicyName SnapshotSchedulePolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::SnapshotSchedulePolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetLunRequest
    {
        /// <summary>
        /// <see cref="gcbv::LunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::LunName LunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::LunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLunsRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateVolumeSnapshotRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RestoreVolumeSnapshotRequest
    {
        /// <summary>
        /// <see cref="VolumeSnapshotName"/>-typed view over the <see cref="VolumeSnapshot"/> resource name property.
        /// </summary>
        public VolumeSnapshotName VolumeSnapshotAsVolumeSnapshotName
        {
            get => string.IsNullOrEmpty(VolumeSnapshot) ? null : VolumeSnapshotName.Parse(VolumeSnapshot, allowUnparsed: true);
            set => VolumeSnapshot = value?.ToString() ?? "";
        }
    }
}
