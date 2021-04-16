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
using gelv = Google.Example.Library.V1;
using sys = System;

namespace Google.Example.Library.V1
{
    /// <summary>Resource name for the <c>Book</c> resource.</summary>
    public sealed partial class BookName : gax::IResourceName, sys::IEquatable<BookName>
    {
        /// <summary>The possible contents of <see cref="BookName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>shelves/{shelf}/books/{book}</c>.</summary>
            ShelfBook = 1,
        }

        private static gax::PathTemplate s_shelfBook = new gax::PathTemplate("shelves/{shelf}/books/{book}");

        /// <summary>Creates a <see cref="BookName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BookName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BookName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BookName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="BookName"/> with the pattern <c>shelves/{shelf}/books/{book}</c>.</summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bookId">The <c>Book</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BookName"/> constructed from the provided ids.</returns>
        public static BookName FromShelfBook(string shelfId, string bookId) =>
            new BookName(ResourceNameType.ShelfBook, shelfId: gax::GaxPreconditions.CheckNotNullOrEmpty(shelfId, nameof(shelfId)), bookId: gax::GaxPreconditions.CheckNotNullOrEmpty(bookId, nameof(bookId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BookName"/> with pattern
        /// <c>shelves/{shelf}/books/{book}</c>.
        /// </summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bookId">The <c>Book</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BookName"/> with pattern <c>shelves/{shelf}/books/{book}</c>.
        /// </returns>
        public static string Format(string shelfId, string bookId) => FormatShelfBook(shelfId, bookId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BookName"/> with pattern
        /// <c>shelves/{shelf}/books/{book}</c>.
        /// </summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bookId">The <c>Book</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BookName"/> with pattern <c>shelves/{shelf}/books/{book}</c>.
        /// </returns>
        public static string FormatShelfBook(string shelfId, string bookId) =>
            s_shelfBook.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(shelfId, nameof(shelfId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bookId, nameof(bookId)));

        /// <summary>Parses the given resource name string into a new <see cref="BookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf}/books/{book}</c></description></item></list>
        /// </remarks>
        /// <param name="bookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BookName"/> if successful.</returns>
        public static BookName Parse(string bookName) => Parse(bookName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BookName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf}/books/{book}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BookName"/> if successful.</returns>
        public static BookName Parse(string bookName, bool allowUnparsed) =>
            TryParse(bookName, allowUnparsed, out BookName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="BookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf}/books/{book}</c></description></item></list>
        /// </remarks>
        /// <param name="bookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bookName, out BookName result) => TryParse(bookName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BookName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf}/books/{book}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bookName, bool allowUnparsed, out BookName result)
        {
            gax::GaxPreconditions.CheckNotNull(bookName, nameof(bookName));
            gax::TemplatedResourceName resourceName;
            if (s_shelfBook.TryParseName(bookName, out resourceName))
            {
                result = FromShelfBook(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bookName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BookName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bookId = null, string shelfId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BookId = bookId;
            ShelfId = shelfId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BookName"/> class from the component parts of pattern
        /// <c>shelves/{shelf}/books/{book}</c>
        /// </summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bookId">The <c>Book</c> ID. Must not be <c>null</c> or empty.</param>
        public BookName(string shelfId, string bookId) : this(ResourceNameType.ShelfBook, shelfId: gax::GaxPreconditions.CheckNotNullOrEmpty(shelfId, nameof(shelfId)), bookId: gax::GaxPreconditions.CheckNotNullOrEmpty(bookId, nameof(bookId)))
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
        /// The <c>Book</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BookId { get; }

        /// <summary>
        /// The <c>Shelf</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ShelfId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ShelfBook: return s_shelfBook.Expand(ShelfId, BookId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BookName);

        /// <inheritdoc/>
        public bool Equals(BookName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BookName a, BookName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BookName a, BookName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Shelf</c> resource.</summary>
    public sealed partial class ShelfName : gax::IResourceName, sys::IEquatable<ShelfName>
    {
        /// <summary>The possible contents of <see cref="ShelfName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>shelves/{shelf_id}</c>.</summary>
            Shelf = 1,
        }

        private static gax::PathTemplate s_shelf = new gax::PathTemplate("shelves/{shelf_id}");

        /// <summary>Creates a <see cref="ShelfName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ShelfName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ShelfName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ShelfName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ShelfName"/> with the pattern <c>shelves/{shelf_id}</c>.</summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ShelfName"/> constructed from the provided ids.</returns>
        public static ShelfName FromShelf(string shelfId) =>
            new ShelfName(ResourceNameType.Shelf, shelfId: gax::GaxPreconditions.CheckNotNullOrEmpty(shelfId, nameof(shelfId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShelfName"/> with pattern
        /// <c>shelves/{shelf_id}</c>.
        /// </summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShelfName"/> with pattern <c>shelves/{shelf_id}</c>.
        /// </returns>
        public static string Format(string shelfId) => FormatShelf(shelfId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShelfName"/> with pattern
        /// <c>shelves/{shelf_id}</c>.
        /// </summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShelfName"/> with pattern <c>shelves/{shelf_id}</c>.
        /// </returns>
        public static string FormatShelf(string shelfId) =>
            s_shelf.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(shelfId, nameof(shelfId)));

        /// <summary>Parses the given resource name string into a new <see cref="ShelfName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf_id}</c></description></item></list>
        /// </remarks>
        /// <param name="shelfName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ShelfName"/> if successful.</returns>
        public static ShelfName Parse(string shelfName) => Parse(shelfName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ShelfName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shelfName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ShelfName"/> if successful.</returns>
        public static ShelfName Parse(string shelfName, bool allowUnparsed) =>
            TryParse(shelfName, allowUnparsed, out ShelfName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShelfName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf_id}</c></description></item></list>
        /// </remarks>
        /// <param name="shelfName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShelfName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shelfName, out ShelfName result) => TryParse(shelfName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShelfName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>shelves/{shelf_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shelfName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShelfName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shelfName, bool allowUnparsed, out ShelfName result)
        {
            gax::GaxPreconditions.CheckNotNull(shelfName, nameof(shelfName));
            gax::TemplatedResourceName resourceName;
            if (s_shelf.TryParseName(shelfName, out resourceName))
            {
                result = FromShelf(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(shelfName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ShelfName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string shelfId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ShelfId = shelfId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ShelfName"/> class from the component parts of pattern
        /// <c>shelves/{shelf_id}</c>
        /// </summary>
        /// <param name="shelfId">The <c>Shelf</c> ID. Must not be <c>null</c> or empty.</param>
        public ShelfName(string shelfId) : this(ResourceNameType.Shelf, shelfId: gax::GaxPreconditions.CheckNotNullOrEmpty(shelfId, nameof(shelfId)))
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
        /// The <c>Shelf</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ShelfId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Shelf: return s_shelf.Expand(ShelfId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ShelfName);

        /// <inheritdoc/>
        public bool Equals(ShelfName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ShelfName a, ShelfName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ShelfName a, ShelfName b) => !(a == b);
    }

    public partial class Book
    {
        /// <summary>
        /// <see cref="gelv::BookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::BookName BookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::BookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Shelf
    {
        /// <summary>
        /// <see cref="gelv::ShelfName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::ShelfName ShelfName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::ShelfName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetShelfRequest
    {
        /// <summary>
        /// <see cref="gelv::ShelfName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::ShelfName ShelfName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::ShelfName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteShelfRequest
    {
        /// <summary>
        /// <see cref="gelv::ShelfName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::ShelfName ShelfName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::ShelfName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MergeShelvesRequest
    {
        /// <summary>
        /// <see cref="gelv::ShelfName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::ShelfName ShelfName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::ShelfName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gelv::ShelfName"/>-typed view over the <see cref="OtherShelf"/> resource name property.
        /// </summary>
        public gelv::ShelfName OtherShelfAsShelfName
        {
            get => string.IsNullOrEmpty(OtherShelf) ? null : gelv::ShelfName.Parse(OtherShelf, allowUnparsed: true);
            set => OtherShelf = value?.ToString() ?? "";
        }
    }

    public partial class CreateBookRequest
    {
        /// <summary><see cref="ShelfName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ShelfName ParentAsShelfName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ShelfName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBookRequest
    {
        /// <summary>
        /// <see cref="gelv::BookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::BookName BookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::BookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBooksRequest
    {
        /// <summary><see cref="ShelfName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ShelfName ParentAsShelfName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ShelfName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBookRequest
    {
        /// <summary>
        /// <see cref="gelv::BookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::BookName BookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::BookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MoveBookRequest
    {
        /// <summary>
        /// <see cref="gelv::BookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gelv::BookName BookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gelv::BookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ShelfName"/>-typed view over the <see cref="OtherShelfName"/> resource name property.
        /// </summary>
        public ShelfName OtherShelfNameAsShelfName
        {
            get => string.IsNullOrEmpty(OtherShelfName) ? null : ShelfName.Parse(OtherShelfName, allowUnparsed: true);
            set => OtherShelfName = value?.ToString() ?? "";
        }
    }
}
