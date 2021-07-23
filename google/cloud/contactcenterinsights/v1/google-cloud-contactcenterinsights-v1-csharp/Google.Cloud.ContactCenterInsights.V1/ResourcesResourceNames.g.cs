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
using gccv = Google.Cloud.ContactCenterInsights.V1;
using sys = System;

namespace Google.Cloud.ContactCenterInsights.V1
{
    /// <summary>Resource name for the <c>Conversation</c> resource.</summary>
    public sealed partial class ConversationName : gax::IResourceName, sys::IEquatable<ConversationName>
    {
        /// <summary>The possible contents of <see cref="ConversationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/conversations/{conversation}</c>
            /// .
            /// </summary>
            ProjectLocationConversation = 1,
        }

        private static gax::PathTemplate s_projectLocationConversation = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}");

        /// <summary>Creates a <see cref="ConversationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConversationName"/> constructed from the provided ids.</returns>
        public static ConversationName FromProjectLocationConversation(string projectId, string locationId, string conversationId) =>
            new ConversationName(ResourceNameType.ProjectLocationConversation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationId) =>
            FormatProjectLocationConversation(projectId, locationId, conversationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </returns>
        public static string FormatProjectLocationConversation(string projectId, string locationId, string conversationId) =>
            s_projectLocationConversation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConversationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversationName"/> if successful.</returns>
        public static ConversationName Parse(string conversationName) => Parse(conversationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationName"/> if successful.</returns>
        public static ConversationName Parse(string conversationName, bool allowUnparsed) =>
            TryParse(conversationName, allowUnparsed, out ConversationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationName, out ConversationName result) =>
            TryParse(conversationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationName, bool allowUnparsed, out ConversationName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationName, nameof(conversationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversation.TryParseName(conversationName, out resourceName))
            {
                result = FromProjectLocationConversation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationId = conversationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversationName(string projectId, string locationId, string conversationId) : this(ResourceNameType.ProjectLocationConversation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)))
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
        /// The <c>Conversation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversationId { get; }

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
                case ResourceNameType.ProjectLocationConversation: return s_projectLocationConversation.Expand(ProjectId, LocationId, ConversationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationName);

        /// <inheritdoc/>
        public bool Equals(ConversationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConversationName a, ConversationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConversationName a, ConversationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Analysis</c> resource.</summary>
    public sealed partial class AnalysisName : gax::IResourceName, sys::IEquatable<AnalysisName>
    {
        /// <summary>The possible contents of <see cref="AnalysisName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
            /// </summary>
            ProjectLocationConversationAnalysis = 1,
        }

        private static gax::PathTemplate s_projectLocationConversationAnalysis = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}");

        /// <summary>Creates a <see cref="AnalysisName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnalysisName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static AnalysisName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnalysisName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnalysisName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnalysisName"/> constructed from the provided ids.</returns>
        public static AnalysisName FromProjectLocationConversationAnalysis(string projectId, string locationId, string conversationId, string analysisId) =>
            new AnalysisName(ResourceNameType.ProjectLocationConversationAnalysis, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), analysisId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationId, string analysisId) =>
            FormatProjectLocationConversationAnalysis(projectId, locationId, conversationId, analysisId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationAnalysis(string projectId, string locationId, string conversationId, string analysisId) =>
            s_projectLocationConversationAnalysis.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnalysisName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnalysisName"/> if successful.</returns>
        public static AnalysisName Parse(string analysisName) => Parse(analysisName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalysisName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnalysisName"/> if successful.</returns>
        public static AnalysisName Parse(string analysisName, bool allowUnparsed) =>
            TryParse(analysisName, allowUnparsed, out AnalysisName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisName, out AnalysisName result) => TryParse(analysisName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisName, bool allowUnparsed, out AnalysisName result)
        {
            gax::GaxPreconditions.CheckNotNull(analysisName, nameof(analysisName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversationAnalysis.TryParseName(analysisName, out resourceName))
            {
                result = FromProjectLocationConversationAnalysis(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(analysisName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnalysisName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string analysisId = null, string conversationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnalysisId = analysisId;
            ConversationId = conversationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnalysisName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        public AnalysisName(string projectId, string locationId, string conversationId, string analysisId) : this(ResourceNameType.ProjectLocationConversationAnalysis, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), analysisId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)))
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
        /// The <c>Analysis</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AnalysisId { get; }

        /// <summary>
        /// The <c>Conversation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversationId { get; }

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
                case ResourceNameType.ProjectLocationConversationAnalysis: return s_projectLocationConversationAnalysis.Expand(ProjectId, LocationId, ConversationId, AnalysisId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnalysisName);

        /// <inheritdoc/>
        public bool Equals(AnalysisName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AnalysisName a, AnalysisName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AnalysisName a, AnalysisName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IssueModel</c> resource.</summary>
    public sealed partial class IssueModelName : gax::IResourceName, sys::IEquatable<IssueModelName>
    {
        /// <summary>The possible contents of <see cref="IssueModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
            /// </summary>
            ProjectLocationIssueModel = 1,
        }

        private static gax::PathTemplate s_projectLocationIssueModel = new gax::PathTemplate("projects/{project}/locations/{location}/issueModels/{issue_model}");

        /// <summary>Creates a <see cref="IssueModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IssueModelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IssueModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IssueModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IssueModelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IssueModelName"/> constructed from the provided ids.</returns>
        public static IssueModelName FromProjectLocationIssueModel(string projectId, string locationId, string issueModelId) =>
            new IssueModelName(ResourceNameType.ProjectLocationIssueModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string issueModelId) =>
            FormatProjectLocationIssueModel(projectId, locationId, issueModelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </returns>
        public static string FormatProjectLocationIssueModel(string projectId, string locationId, string issueModelId) =>
            s_projectLocationIssueModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)));

        /// <summary>Parses the given resource name string into a new <see cref="IssueModelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IssueModelName"/> if successful.</returns>
        public static IssueModelName Parse(string issueModelName) => Parse(issueModelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IssueModelName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IssueModelName"/> if successful.</returns>
        public static IssueModelName Parse(string issueModelName, bool allowUnparsed) =>
            TryParse(issueModelName, allowUnparsed, out IssueModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueModelName, out IssueModelName result) =>
            TryParse(issueModelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueModelName, bool allowUnparsed, out IssueModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(issueModelName, nameof(issueModelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationIssueModel.TryParseName(issueModelName, out resourceName))
            {
                result = FromProjectLocationIssueModel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(issueModelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IssueModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string issueModelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IssueModelId = issueModelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IssueModelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        public IssueModelName(string projectId, string locationId, string issueModelId) : this(ResourceNameType.ProjectLocationIssueModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)))
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
        /// The <c>IssueModel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueModelId { get; }

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
                case ResourceNameType.ProjectLocationIssueModel: return s_projectLocationIssueModel.Expand(ProjectId, LocationId, IssueModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IssueModelName);

        /// <inheritdoc/>
        public bool Equals(IssueModelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(IssueModelName a, IssueModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(IssueModelName a, IssueModelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Issue</c> resource.</summary>
    public sealed partial class IssueName : gax::IResourceName, sys::IEquatable<IssueName>
    {
        /// <summary>The possible contents of <see cref="IssueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
            /// </summary>
            ProjectLocationIssueModelIssue = 1,
        }

        private static gax::PathTemplate s_projectLocationIssueModelIssue = new gax::PathTemplate("projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}");

        /// <summary>Creates a <see cref="IssueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IssueName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IssueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IssueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IssueName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IssueName"/> constructed from the provided ids.</returns>
        public static IssueName FromProjectLocationIssueModelIssue(string projectId, string locationId, string issueModelId, string issueId) =>
            new IssueName(ResourceNameType.ProjectLocationIssueModelIssue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string issueModelId, string issueId) =>
            FormatProjectLocationIssueModelIssue(projectId, locationId, issueModelId, issueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </returns>
        public static string FormatProjectLocationIssueModelIssue(string projectId, string locationId, string issueModelId, string issueId) =>
            s_projectLocationIssueModelIssue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>Parses the given resource name string into a new <see cref="IssueName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IssueName"/> if successful.</returns>
        public static IssueName Parse(string issueName) => Parse(issueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IssueName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IssueName"/> if successful.</returns>
        public static IssueName Parse(string issueName, bool allowUnparsed) =>
            TryParse(issueName, allowUnparsed, out IssueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueName, out IssueName result) => TryParse(issueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueName, bool allowUnparsed, out IssueName result)
        {
            gax::GaxPreconditions.CheckNotNull(issueName, nameof(issueName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationIssueModelIssue.TryParseName(issueName, out resourceName))
            {
                result = FromProjectLocationIssueModelIssue(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(issueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IssueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string issueId = null, string issueModelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IssueId = issueId;
            IssueModelId = issueModelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IssueName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        public IssueName(string projectId, string locationId, string issueModelId, string issueId) : this(ResourceNameType.ProjectLocationIssueModelIssue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)))
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
        /// The <c>Issue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueId { get; }

        /// <summary>
        /// The <c>IssueModel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueModelId { get; }

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
                case ResourceNameType.ProjectLocationIssueModelIssue: return s_projectLocationIssueModelIssue.Expand(ProjectId, LocationId, IssueModelId, IssueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IssueName);

        /// <inheritdoc/>
        public bool Equals(IssueName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(IssueName a, IssueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(IssueName a, IssueName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PhraseMatcher</c> resource.</summary>
    public sealed partial class PhraseMatcherName : gax::IResourceName, sys::IEquatable<PhraseMatcherName>
    {
        /// <summary>The possible contents of <see cref="PhraseMatcherName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>
            /// .
            /// </summary>
            ProjectLocationPhraseMatcher = 1,
        }

        private static gax::PathTemplate s_projectLocationPhraseMatcher = new gax::PathTemplate("projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}");

        /// <summary>Creates a <see cref="PhraseMatcherName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PhraseMatcherName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PhraseMatcherName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PhraseMatcherName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PhraseMatcherName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PhraseMatcherName"/> constructed from the provided ids.</returns>
        public static PhraseMatcherName FromProjectLocationPhraseMatcher(string projectId, string locationId, string phraseMatcherId) =>
            new PhraseMatcherName(ResourceNameType.ProjectLocationPhraseMatcher, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phraseMatcherId: gax::GaxPreconditions.CheckNotNullOrEmpty(phraseMatcherId, nameof(phraseMatcherId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string phraseMatcherId) =>
            FormatProjectLocationPhraseMatcher(projectId, locationId, phraseMatcherId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </returns>
        public static string FormatProjectLocationPhraseMatcher(string projectId, string locationId, string phraseMatcherId) =>
            s_projectLocationPhraseMatcher.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(phraseMatcherId, nameof(phraseMatcherId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhraseMatcherName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PhraseMatcherName"/> if successful.</returns>
        public static PhraseMatcherName Parse(string phraseMatcherName) => Parse(phraseMatcherName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhraseMatcherName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PhraseMatcherName"/> if successful.</returns>
        public static PhraseMatcherName Parse(string phraseMatcherName, bool allowUnparsed) =>
            TryParse(phraseMatcherName, allowUnparsed, out PhraseMatcherName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhraseMatcherName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhraseMatcherName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phraseMatcherName, out PhraseMatcherName result) =>
            TryParse(phraseMatcherName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhraseMatcherName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhraseMatcherName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phraseMatcherName, bool allowUnparsed, out PhraseMatcherName result)
        {
            gax::GaxPreconditions.CheckNotNull(phraseMatcherName, nameof(phraseMatcherName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPhraseMatcher.TryParseName(phraseMatcherName, out resourceName))
            {
                result = FromProjectLocationPhraseMatcher(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(phraseMatcherName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PhraseMatcherName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string phraseMatcherId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PhraseMatcherId = phraseMatcherId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PhraseMatcherName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        public PhraseMatcherName(string projectId, string locationId, string phraseMatcherId) : this(ResourceNameType.ProjectLocationPhraseMatcher, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phraseMatcherId: gax::GaxPreconditions.CheckNotNullOrEmpty(phraseMatcherId, nameof(phraseMatcherId)))
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
        /// The <c>PhraseMatcher</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PhraseMatcherId { get; }

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
                case ResourceNameType.ProjectLocationPhraseMatcher: return s_projectLocationPhraseMatcher.Expand(ProjectId, LocationId, PhraseMatcherId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PhraseMatcherName);

        /// <inheritdoc/>
        public bool Equals(PhraseMatcherName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(PhraseMatcherName a, PhraseMatcherName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PhraseMatcherName a, PhraseMatcherName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}/settings</c>.</summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>projects/{project}/locations/{location}/settings</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectLocation(string projectId, string locationId) =>
            new SettingsName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/settings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Participant</c> resource.</summary>
    public sealed partial class ParticipantName : gax::IResourceName, sys::IEquatable<ParticipantName>
    {
        /// <summary>The possible contents of <see cref="ParticipantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
            /// </summary>
            ProjectConversationParticipant = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
            /// </summary>
            ProjectLocationConversationParticipant = 2,
        }

        private static gax::PathTemplate s_projectConversationParticipant = new gax::PathTemplate("projects/{project}/conversations/{conversation}/participants/{participant}");

        private static gax::PathTemplate s_projectLocationConversationParticipant = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}");

        /// <summary>Creates a <see cref="ParticipantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParticipantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParticipantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParticipantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParticipantName"/> with the pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParticipantName"/> constructed from the provided ids.</returns>
        public static ParticipantName FromProjectConversationParticipant(string projectId, string conversationId, string participantId) =>
            new ParticipantName(ResourceNameType.ProjectConversationParticipant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Creates a <see cref="ParticipantName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParticipantName"/> constructed from the provided ids.</returns>
        public static ParticipantName FromProjectLocationConversationParticipant(string projectId, string locationId, string conversationId, string participantId) =>
            new ParticipantName(ResourceNameType.ProjectLocationConversationParticipant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </returns>
        public static string Format(string projectId, string conversationId, string participantId) =>
            FormatProjectConversationParticipant(projectId, conversationId, participantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </returns>
        public static string FormatProjectConversationParticipant(string projectId, string conversationId, string participantId) =>
            s_projectConversationParticipant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationParticipant(string projectId, string locationId, string conversationId, string participantId) =>
            s_projectLocationConversationParticipant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>Parses the given resource name string into a new <see cref="ParticipantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParticipantName"/> if successful.</returns>
        public static ParticipantName Parse(string participantName) => Parse(participantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParticipantName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParticipantName"/> if successful.</returns>
        public static ParticipantName Parse(string participantName, bool allowUnparsed) =>
            TryParse(participantName, allowUnparsed, out ParticipantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantName, out ParticipantName result) =>
            TryParse(participantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantName, bool allowUnparsed, out ParticipantName result)
        {
            gax::GaxPreconditions.CheckNotNull(participantName, nameof(participantName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConversationParticipant.TryParseName(participantName, out resourceName))
            {
                result = FromProjectConversationParticipant(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationConversationParticipant.TryParseName(participantName, out resourceName))
            {
                result = FromProjectLocationConversationParticipant(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(participantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParticipantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationId = null, string locationId = null, string participantId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationId = conversationId;
            LocationId = locationId;
            ParticipantId = participantId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParticipantName"/> class from the component parts of pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        public ParticipantName(string projectId, string conversationId, string participantId) : this(ResourceNameType.ProjectConversationParticipant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)))
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
        /// The <c>Conversation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConversationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Participant</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ParticipantId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectConversationParticipant: return s_projectConversationParticipant.Expand(ProjectId, ConversationId, ParticipantId);
                case ResourceNameType.ProjectLocationConversationParticipant: return s_projectLocationConversationParticipant.Expand(ProjectId, LocationId, ConversationId, ParticipantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParticipantName);

        /// <inheritdoc/>
        public bool Equals(ParticipantName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ParticipantName a, ParticipantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ParticipantName a, ParticipantName b) => !(a == b);
    }

    public partial class Conversation
    {
        /// <summary>
        /// <see cref="gccv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Analysis
    {
        /// <summary>
        /// <see cref="gccv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IssueModel
    {
        /// <summary>
        /// <see cref="gccv::IssueModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueModelName IssueModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Issue
    {
        /// <summary>
        /// <see cref="gccv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PhraseMatcher
    {
        /// <summary>
        /// <see cref="gccv::PhraseMatcherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PhraseMatcherName PhraseMatcherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PhraseMatcherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gccv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
