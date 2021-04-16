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
using gcbsv = Google.Cloud.Bigquery.Storage.V1Beta1;
using sys = System;

namespace Google.Cloud.Bigquery.Storage.V1Beta1
{
    /// <summary>Resource name for the <c>Stream</c> resource.</summary>
    public sealed partial class StreamName : gax::IResourceName, sys::IEquatable<StreamName>
    {
        /// <summary>The possible contents of <see cref="StreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/streams/{stream}</c>.
            /// </summary>
            ProjectLocationStream = 1,
        }

        private static gax::PathTemplate s_projectLocationStream = new gax::PathTemplate("projects/{project}/locations/{location}/streams/{stream}");

        /// <summary>Creates a <see cref="StreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StreamName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StreamName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StreamName"/> constructed from the provided ids.</returns>
        public static StreamName FromProjectLocationStream(string projectId, string locationId, string streamId) =>
            new StreamName(ResourceNameType.ProjectLocationStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string streamId) =>
            FormatProjectLocationStream(projectId, locationId, streamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </returns>
        public static string FormatProjectLocationStream(string projectId, string locationId, string streamId) =>
            s_projectLocationStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>Parses the given resource name string into a new <see cref="StreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName) => Parse(streamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StreamName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName, bool allowUnparsed) =>
            TryParse(streamName, allowUnparsed, out StreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, out StreamName result) => TryParse(streamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, bool allowUnparsed, out StreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(streamName, nameof(streamName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationStream.TryParseName(streamName, out resourceName))
            {
                result = FromProjectLocationStream(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(streamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string streamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            StreamId = streamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StreamName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        public StreamName(string projectId, string locationId, string streamId) : this(ResourceNameType.ProjectLocationStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)))
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
        /// The <c>Stream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StreamId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStream: return s_projectLocationStream.Expand(ProjectId, LocationId, StreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StreamName);

        /// <inheritdoc/>
        public bool Equals(StreamName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(StreamName a, StreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(StreamName a, StreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReadSession</c> resource.</summary>
    public sealed partial class ReadSessionName : gax::IResourceName, sys::IEquatable<ReadSessionName>
    {
        /// <summary>The possible contents of <see cref="ReadSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sessions/{session}</c>.
            /// </summary>
            ProjectLocationSession = 1,
        }

        private static gax::PathTemplate s_projectLocationSession = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}");

        /// <summary>Creates a <see cref="ReadSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReadSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReadSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReadSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReadSessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReadSessionName"/> constructed from the provided ids.</returns>
        public static ReadSessionName FromProjectLocationSession(string projectId, string locationId, string sessionId) =>
            new ReadSessionName(ResourceNameType.ProjectLocationSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sessionId) =>
            FormatProjectLocationSession(projectId, locationId, sessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationSession(string projectId, string locationId, string sessionId) =>
            s_projectLocationSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReadSessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReadSessionName"/> if successful.</returns>
        public static ReadSessionName Parse(string readSessionName) => Parse(readSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReadSessionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReadSessionName"/> if successful.</returns>
        public static ReadSessionName Parse(string readSessionName, bool allowUnparsed) =>
            TryParse(readSessionName, allowUnparsed, out ReadSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReadSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readSessionName, out ReadSessionName result) =>
            TryParse(readSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReadSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readSessionName, bool allowUnparsed, out ReadSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(readSessionName, nameof(readSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSession.TryParseName(readSessionName, out resourceName))
            {
                result = FromProjectLocationSession(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(readSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReadSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReadSessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        public ReadSessionName(string projectId, string locationId, string sessionId) : this(ResourceNameType.ProjectLocationSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)))
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
        /// The <c>Session</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSession: return s_projectLocationSession.Expand(ProjectId, LocationId, SessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReadSessionName);

        /// <inheritdoc/>
        public bool Equals(ReadSessionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ReadSessionName a, ReadSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ReadSessionName a, ReadSessionName b) => !(a == b);
    }

    public partial class Stream
    {
        /// <summary>
        /// <see cref="gcbsv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReadSession
    {
        /// <summary>
        /// <see cref="gcbsv::ReadSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::ReadSessionName ReadSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReadSessionRequest
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
}
