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

using gaav = Google.Ads.Admob.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.Admob.V1
{
    /// <summary>Resource name for the <c>PublisherAccount</c> resource.</summary>
    public sealed partial class PublisherAccountName : gax::IResourceName, sys::IEquatable<PublisherAccountName>
    {
        /// <summary>The possible contents of <see cref="PublisherAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{publisher}</c>.</summary>
            Publisher = 1,
        }

        private static gax::PathTemplate s_publisher = new gax::PathTemplate("accounts/{publisher}");

        /// <summary>Creates a <see cref="PublisherAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PublisherAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PublisherAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PublisherAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PublisherAccountName"/> with the pattern <c>accounts/{publisher}</c>.
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PublisherAccountName"/> constructed from the provided ids.</returns>
        public static PublisherAccountName FromPublisher(string publisherId) =>
            new PublisherAccountName(ResourceNameType.Publisher, publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublisherAccountName"/> with pattern
        /// <c>accounts/{publisher}</c>.
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublisherAccountName"/> with pattern <c>accounts/{publisher}</c>
        /// .
        /// </returns>
        public static string Format(string publisherId) => FormatPublisher(publisherId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublisherAccountName"/> with pattern
        /// <c>accounts/{publisher}</c>.
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublisherAccountName"/> with pattern <c>accounts/{publisher}</c>
        /// .
        /// </returns>
        public static string FormatPublisher(string publisherId) =>
            s_publisher.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublisherAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{publisher}</c></description></item></list>
        /// </remarks>
        /// <param name="publisherAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PublisherAccountName"/> if successful.</returns>
        public static PublisherAccountName Parse(string publisherAccountName) => Parse(publisherAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublisherAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{publisher}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publisherAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PublisherAccountName"/> if successful.</returns>
        public static PublisherAccountName Parse(string publisherAccountName, bool allowUnparsed) =>
            TryParse(publisherAccountName, allowUnparsed, out PublisherAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublisherAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{publisher}</c></description></item></list>
        /// </remarks>
        /// <param name="publisherAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublisherAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publisherAccountName, out PublisherAccountName result) =>
            TryParse(publisherAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublisherAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>accounts/{publisher}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publisherAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublisherAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publisherAccountName, bool allowUnparsed, out PublisherAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(publisherAccountName, nameof(publisherAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_publisher.TryParseName(publisherAccountName, out resourceName))
            {
                result = FromPublisher(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(publisherAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PublisherAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string publisherId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PublisherId = publisherId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PublisherAccountName"/> class from the component parts of pattern
        /// <c>accounts/{publisher}</c>
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        public PublisherAccountName(string publisherId) : this(ResourceNameType.Publisher, publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)))
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
        /// The <c>Publisher</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PublisherId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Publisher: return s_publisher.Expand(PublisherId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PublisherAccountName);

        /// <inheritdoc/>
        public bool Equals(PublisherAccountName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(PublisherAccountName a, PublisherAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PublisherAccountName a, PublisherAccountName b) => !(a == b);
    }

    public partial class PublisherAccount
    {
        /// <summary>
        /// <see cref="gaav::PublisherAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::PublisherAccountName PublisherAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::PublisherAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
