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
using ghesv = Google.Home.Enterprise.Sdm.V1;
using sys = System;

namespace Google.Home.Enterprise.Sdm.V1
{
    /// <summary>Resource name for the <c>Structure</c> resource.</summary>
    public sealed partial class StructureName : gax::IResourceName, sys::IEquatable<StructureName>
    {
        /// <summary>The possible contents of <see cref="StructureName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>enterprises/{enterprise}/structures/{structure}</c>.</summary>
            EnterpriseStructure = 1,
        }

        private static gax::PathTemplate s_enterpriseStructure = new gax::PathTemplate("enterprises/{enterprise}/structures/{structure}");

        /// <summary>Creates a <see cref="StructureName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StructureName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StructureName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StructureName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StructureName"/> with the pattern <c>enterprises/{enterprise}/structures/{structure}</c>
        /// .
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StructureName"/> constructed from the provided ids.</returns>
        public static StructureName FromEnterpriseStructure(string enterpriseId, string structureId) =>
            new StructureName(ResourceNameType.EnterpriseStructure, enterpriseId: gax::GaxPreconditions.CheckNotNullOrEmpty(enterpriseId, nameof(enterpriseId)), structureId: gax::GaxPreconditions.CheckNotNullOrEmpty(structureId, nameof(structureId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StructureName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}</c>.
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StructureName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}</c>.
        /// </returns>
        public static string Format(string enterpriseId, string structureId) =>
            FormatEnterpriseStructure(enterpriseId, structureId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StructureName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}</c>.
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StructureName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}</c>.
        /// </returns>
        public static string FormatEnterpriseStructure(string enterpriseId, string structureId) =>
            s_enterpriseStructure.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(enterpriseId, nameof(enterpriseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(structureId, nameof(structureId)));

        /// <summary>Parses the given resource name string into a new <see cref="StructureName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="structureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StructureName"/> if successful.</returns>
        public static StructureName Parse(string structureName) => Parse(structureName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StructureName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="structureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StructureName"/> if successful.</returns>
        public static StructureName Parse(string structureName, bool allowUnparsed) =>
            TryParse(structureName, allowUnparsed, out StructureName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StructureName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="structureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StructureName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string structureName, out StructureName result) => TryParse(structureName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StructureName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="structureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StructureName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string structureName, bool allowUnparsed, out StructureName result)
        {
            gax::GaxPreconditions.CheckNotNull(structureName, nameof(structureName));
            gax::TemplatedResourceName resourceName;
            if (s_enterpriseStructure.TryParseName(structureName, out resourceName))
            {
                result = FromEnterpriseStructure(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(structureName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StructureName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string enterpriseId = null, string structureId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnterpriseId = enterpriseId;
            StructureId = structureId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StructureName"/> class from the component parts of pattern
        /// <c>enterprises/{enterprise}/structures/{structure}</c>
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        public StructureName(string enterpriseId, string structureId) : this(ResourceNameType.EnterpriseStructure, enterpriseId: gax::GaxPreconditions.CheckNotNullOrEmpty(enterpriseId, nameof(enterpriseId)), structureId: gax::GaxPreconditions.CheckNotNullOrEmpty(structureId, nameof(structureId)))
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
        /// The <c>Enterprise</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnterpriseId { get; }

        /// <summary>
        /// The <c>Structure</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StructureId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.EnterpriseStructure: return s_enterpriseStructure.Expand(EnterpriseId, StructureId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StructureName);

        /// <inheritdoc/>
        public bool Equals(StructureName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(StructureName a, StructureName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(StructureName a, StructureName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Room</c> resource.</summary>
    public sealed partial class RoomName : gax::IResourceName, sys::IEquatable<RoomName>
    {
        /// <summary>The possible contents of <see cref="RoomName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>.
            /// </summary>
            EnterpriseStructureRoom = 1,
        }

        private static gax::PathTemplate s_enterpriseStructureRoom = new gax::PathTemplate("enterprises/{enterprise}/structures/{structure}/rooms/{room}");

        /// <summary>Creates a <see cref="RoomName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RoomName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RoomName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RoomName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RoomName"/> with the pattern
        /// <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>.
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roomId">The <c>Room</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RoomName"/> constructed from the provided ids.</returns>
        public static RoomName FromEnterpriseStructureRoom(string enterpriseId, string structureId, string roomId) =>
            new RoomName(ResourceNameType.EnterpriseStructureRoom, enterpriseId: gax::GaxPreconditions.CheckNotNullOrEmpty(enterpriseId, nameof(enterpriseId)), structureId: gax::GaxPreconditions.CheckNotNullOrEmpty(structureId, nameof(structureId)), roomId: gax::GaxPreconditions.CheckNotNullOrEmpty(roomId, nameof(roomId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoomName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>.
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roomId">The <c>Room</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoomName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>.
        /// </returns>
        public static string Format(string enterpriseId, string structureId, string roomId) =>
            FormatEnterpriseStructureRoom(enterpriseId, structureId, roomId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RoomName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>.
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roomId">The <c>Room</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RoomName"/> with pattern
        /// <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>.
        /// </returns>
        public static string FormatEnterpriseStructureRoom(string enterpriseId, string structureId, string roomId) =>
            s_enterpriseStructureRoom.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(enterpriseId, nameof(enterpriseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(structureId, nameof(structureId)), gax::GaxPreconditions.CheckNotNullOrEmpty(roomId, nameof(roomId)));

        /// <summary>Parses the given resource name string into a new <see cref="RoomName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="roomName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RoomName"/> if successful.</returns>
        public static RoomName Parse(string roomName) => Parse(roomName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RoomName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="roomName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RoomName"/> if successful.</returns>
        public static RoomName Parse(string roomName, bool allowUnparsed) =>
            TryParse(roomName, allowUnparsed, out RoomName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="RoomName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="roomName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoomName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roomName, out RoomName result) => TryParse(roomName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RoomName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="roomName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RoomName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roomName, bool allowUnparsed, out RoomName result)
        {
            gax::GaxPreconditions.CheckNotNull(roomName, nameof(roomName));
            gax::TemplatedResourceName resourceName;
            if (s_enterpriseStructureRoom.TryParseName(roomName, out resourceName))
            {
                result = FromEnterpriseStructureRoom(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(roomName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RoomName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string enterpriseId = null, string roomId = null, string structureId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnterpriseId = enterpriseId;
            RoomId = roomId;
            StructureId = structureId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RoomName"/> class from the component parts of pattern
        /// <c>enterprises/{enterprise}/structures/{structure}/rooms/{room}</c>
        /// </summary>
        /// <param name="enterpriseId">The <c>Enterprise</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="structureId">The <c>Structure</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="roomId">The <c>Room</c> ID. Must not be <c>null</c> or empty.</param>
        public RoomName(string enterpriseId, string structureId, string roomId) : this(ResourceNameType.EnterpriseStructureRoom, enterpriseId: gax::GaxPreconditions.CheckNotNullOrEmpty(enterpriseId, nameof(enterpriseId)), structureId: gax::GaxPreconditions.CheckNotNullOrEmpty(structureId, nameof(structureId)), roomId: gax::GaxPreconditions.CheckNotNullOrEmpty(roomId, nameof(roomId)))
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
        /// The <c>Enterprise</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnterpriseId { get; }

        /// <summary>
        /// The <c>Room</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RoomId { get; }

        /// <summary>
        /// The <c>Structure</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StructureId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.EnterpriseStructureRoom: return s_enterpriseStructureRoom.Expand(EnterpriseId, StructureId, RoomId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RoomName);

        /// <inheritdoc/>
        public bool Equals(RoomName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RoomName a, RoomName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RoomName a, RoomName b) => !(a == b);
    }

    public partial class Structure
    {
        /// <summary>
        /// <see cref="ghesv::StructureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ghesv::StructureName StructureName
        {
            get => string.IsNullOrEmpty(Name) ? null : ghesv::StructureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Room
    {
        /// <summary>
        /// <see cref="ghesv::RoomName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ghesv::RoomName RoomName
        {
            get => string.IsNullOrEmpty(Name) ? null : ghesv::RoomName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
