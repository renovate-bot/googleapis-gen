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
using gcav = Google.Cloud.Automl.V1Beta1;
using sys = System;

namespace Google.Cloud.Automl.V1Beta1
{
    /// <summary>Resource name for the <c>ColumnSpec</c> resource.</summary>
    public sealed partial class ColumnSpecName : gax::IResourceName, sys::IEquatable<ColumnSpecName>
    {
        /// <summary>The possible contents of <see cref="ColumnSpecName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
            /// .
            /// </summary>
            ProjectLocationDatasetTableSpecColumnSpec = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetTableSpecColumnSpec = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}");

        /// <summary>Creates a <see cref="ColumnSpecName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ColumnSpecName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ColumnSpecName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ColumnSpecName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ColumnSpecName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableSpecId">The <c>TableSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="columnSpecId">The <c>ColumnSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ColumnSpecName"/> constructed from the provided ids.</returns>
        public static ColumnSpecName FromProjectLocationDatasetTableSpecColumnSpec(string projectId, string locationId, string datasetId, string tableSpecId, string columnSpecId) =>
            new ColumnSpecName(ResourceNameType.ProjectLocationDatasetTableSpecColumnSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableSpecId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableSpecId, nameof(tableSpecId)), columnSpecId: gax::GaxPreconditions.CheckNotNullOrEmpty(columnSpecId, nameof(columnSpecId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ColumnSpecName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableSpecId">The <c>TableSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="columnSpecId">The <c>ColumnSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ColumnSpecName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string tableSpecId, string columnSpecId) =>
            FormatProjectLocationDatasetTableSpecColumnSpec(projectId, locationId, datasetId, tableSpecId, columnSpecId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ColumnSpecName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableSpecId">The <c>TableSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="columnSpecId">The <c>ColumnSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ColumnSpecName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDatasetTableSpecColumnSpec(string projectId, string locationId, string datasetId, string tableSpecId, string columnSpecId) =>
            s_projectLocationDatasetTableSpecColumnSpec.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableSpecId, nameof(tableSpecId)), gax::GaxPreconditions.CheckNotNullOrEmpty(columnSpecId, nameof(columnSpecId)));

        /// <summary>Parses the given resource name string into a new <see cref="ColumnSpecName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="columnSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ColumnSpecName"/> if successful.</returns>
        public static ColumnSpecName Parse(string columnSpecName) => Parse(columnSpecName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ColumnSpecName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="columnSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ColumnSpecName"/> if successful.</returns>
        public static ColumnSpecName Parse(string columnSpecName, bool allowUnparsed) =>
            TryParse(columnSpecName, allowUnparsed, out ColumnSpecName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ColumnSpecName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="columnSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ColumnSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string columnSpecName, out ColumnSpecName result) =>
            TryParse(columnSpecName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ColumnSpecName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="columnSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ColumnSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string columnSpecName, bool allowUnparsed, out ColumnSpecName result)
        {
            gax::GaxPreconditions.CheckNotNull(columnSpecName, nameof(columnSpecName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetTableSpecColumnSpec.TryParseName(columnSpecName, out resourceName))
            {
                result = FromProjectLocationDatasetTableSpecColumnSpec(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(columnSpecName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ColumnSpecName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string columnSpecId = null, string datasetId = null, string locationId = null, string projectId = null, string tableSpecId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ColumnSpecId = columnSpecId;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
            TableSpecId = tableSpecId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ColumnSpecName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/tableSpecs/{table_spec}/columnSpecs/{column_spec}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableSpecId">The <c>TableSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="columnSpecId">The <c>ColumnSpec</c> ID. Must not be <c>null</c> or empty.</param>
        public ColumnSpecName(string projectId, string locationId, string datasetId, string tableSpecId, string columnSpecId) : this(ResourceNameType.ProjectLocationDatasetTableSpecColumnSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableSpecId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableSpecId, nameof(tableSpecId)), columnSpecId: gax::GaxPreconditions.CheckNotNullOrEmpty(columnSpecId, nameof(columnSpecId)))
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
        /// The <c>ColumnSpec</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ColumnSpecId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TableSpec</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableSpecId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDatasetTableSpecColumnSpec: return s_projectLocationDatasetTableSpecColumnSpec.Expand(ProjectId, LocationId, DatasetId, TableSpecId, ColumnSpecId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ColumnSpecName);

        /// <inheritdoc/>
        public bool Equals(ColumnSpecName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ColumnSpecName a, ColumnSpecName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ColumnSpecName a, ColumnSpecName b) => !(a == b);
    }

    public partial class ColumnSpec
    {
        /// <summary>
        /// <see cref="gcav::ColumnSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ColumnSpecName ColumnSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ColumnSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
