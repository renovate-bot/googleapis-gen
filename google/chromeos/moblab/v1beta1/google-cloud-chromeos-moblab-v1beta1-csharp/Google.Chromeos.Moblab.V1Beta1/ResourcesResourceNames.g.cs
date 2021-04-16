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
using gcmv = Google.Chromeos.Moblab.V1Beta1;
using sys = System;

namespace Google.Chromeos.Moblab.V1Beta1
{
    /// <summary>Resource name for the <c>BuildTarget</c> resource.</summary>
    public sealed partial class BuildTargetName : gax::IResourceName, sys::IEquatable<BuildTargetName>
    {
        /// <summary>The possible contents of <see cref="BuildTargetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>buildTargets/{build_target}</c>.</summary>
            BuildTarget = 1,
        }

        private static gax::PathTemplate s_buildTarget = new gax::PathTemplate("buildTargets/{build_target}");

        /// <summary>Creates a <see cref="BuildTargetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BuildTargetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BuildTargetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BuildTargetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BuildTargetName"/> with the pattern <c>buildTargets/{build_target}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildTargetName"/> constructed from the provided ids.</returns>
        public static BuildTargetName FromBuildTarget(string buildTargetId) =>
            new BuildTargetName(ResourceNameType.BuildTarget, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildTargetName"/> with pattern
        /// <c>buildTargets/{build_target}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildTargetName"/> with pattern <c>buildTargets/{build_target}</c>
        /// .
        /// </returns>
        public static string Format(string buildTargetId) => FormatBuildTarget(buildTargetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildTargetName"/> with pattern
        /// <c>buildTargets/{build_target}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildTargetName"/> with pattern <c>buildTargets/{build_target}</c>
        /// .
        /// </returns>
        public static string FormatBuildTarget(string buildTargetId) =>
            s_buildTarget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)));

        /// <summary>Parses the given resource name string into a new <see cref="BuildTargetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>buildTargets/{build_target}</c></description></item></list>
        /// </remarks>
        /// <param name="buildTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BuildTargetName"/> if successful.</returns>
        public static BuildTargetName Parse(string buildTargetName) => Parse(buildTargetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildTargetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>buildTargets/{build_target}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BuildTargetName"/> if successful.</returns>
        public static BuildTargetName Parse(string buildTargetName, bool allowUnparsed) =>
            TryParse(buildTargetName, allowUnparsed, out BuildTargetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildTargetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>buildTargets/{build_target}</c></description></item></list>
        /// </remarks>
        /// <param name="buildTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildTargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildTargetName, out BuildTargetName result) =>
            TryParse(buildTargetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildTargetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>buildTargets/{build_target}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildTargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildTargetName, bool allowUnparsed, out BuildTargetName result)
        {
            gax::GaxPreconditions.CheckNotNull(buildTargetName, nameof(buildTargetName));
            gax::TemplatedResourceName resourceName;
            if (s_buildTarget.TryParseName(buildTargetName, out resourceName))
            {
                result = FromBuildTarget(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(buildTargetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BuildTargetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string buildTargetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BuildTargetId = buildTargetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BuildTargetName"/> class from the component parts of pattern
        /// <c>buildTargets/{build_target}</c>
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        public BuildTargetName(string buildTargetId) : this(ResourceNameType.BuildTarget, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)))
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
        /// The <c>BuildTarget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildTargetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BuildTarget: return s_buildTarget.Expand(BuildTargetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildTargetName);

        /// <inheritdoc/>
        public bool Equals(BuildTargetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BuildTargetName a, BuildTargetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BuildTargetName a, BuildTargetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Model</c> resource.</summary>
    public sealed partial class ModelName : gax::IResourceName, sys::IEquatable<ModelName>
    {
        /// <summary>The possible contents of <see cref="ModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>buildTargets/{build_target}/models/{model}</c>.</summary>
            BuildTargetModel = 1,
        }

        private static gax::PathTemplate s_buildTargetModel = new gax::PathTemplate("buildTargets/{build_target}/models/{model}");

        /// <summary>Creates a <see cref="ModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ModelName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ModelName"/> with the pattern <c>buildTargets/{build_target}/models/{model}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ModelName"/> constructed from the provided ids.</returns>
        public static ModelName FromBuildTargetModel(string buildTargetId, string modelId) =>
            new ModelName(ResourceNameType.BuildTargetModel, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}</c>.
        /// </returns>
        public static string Format(string buildTargetId, string modelId) => FormatBuildTargetModel(buildTargetId, modelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}</c>.
        /// </returns>
        public static string FormatBuildTargetModel(string buildTargetId, string modelId) =>
            s_buildTargetModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>Parses the given resource name string into a new <see cref="ModelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelName"/> if successful.</returns>
        public static ModelName Parse(string modelName) => Parse(modelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ModelName"/> if successful.</returns>
        public static ModelName Parse(string modelName, bool allowUnparsed) =>
            TryParse(modelName, allowUnparsed, out ModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelName, out ModelName result) => TryParse(modelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelName, bool allowUnparsed, out ModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelName, nameof(modelName));
            gax::TemplatedResourceName resourceName;
            if (s_buildTargetModel.TryParseName(modelName, out resourceName))
            {
                result = FromBuildTargetModel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(modelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string buildTargetId = null, string modelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BuildTargetId = buildTargetId;
            ModelId = modelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ModelName"/> class from the component parts of pattern
        /// <c>buildTargets/{build_target}/models/{model}</c>
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        public ModelName(string buildTargetId, string modelId) : this(ResourceNameType.BuildTargetModel, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)))
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
        /// The <c>BuildTarget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildTargetId { get; }

        /// <summary>
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BuildTargetModel: return s_buildTargetModel.Expand(BuildTargetId, ModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ModelName);

        /// <inheritdoc/>
        public bool Equals(ModelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ModelName a, ModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ModelName a, ModelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Milestone</c> resource.</summary>
    public sealed partial class MilestoneName : gax::IResourceName, sys::IEquatable<MilestoneName>
    {
        /// <summary>The possible contents of <see cref="MilestoneName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>milestones/{milestone}</c>.</summary>
            Milestone = 1,
        }

        private static gax::PathTemplate s_milestone = new gax::PathTemplate("milestones/{milestone}");

        /// <summary>Creates a <see cref="MilestoneName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MilestoneName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MilestoneName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MilestoneName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="MilestoneName"/> with the pattern <c>milestones/{milestone}</c>.</summary>
        /// <param name="milestoneId">The <c>Milestone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MilestoneName"/> constructed from the provided ids.</returns>
        public static MilestoneName FromMilestone(string milestoneId) =>
            new MilestoneName(ResourceNameType.Milestone, milestoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(milestoneId, nameof(milestoneId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MilestoneName"/> with pattern
        /// <c>milestones/{milestone}</c>.
        /// </summary>
        /// <param name="milestoneId">The <c>Milestone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MilestoneName"/> with pattern <c>milestones/{milestone}</c>.
        /// </returns>
        public static string Format(string milestoneId) => FormatMilestone(milestoneId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MilestoneName"/> with pattern
        /// <c>milestones/{milestone}</c>.
        /// </summary>
        /// <param name="milestoneId">The <c>Milestone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MilestoneName"/> with pattern <c>milestones/{milestone}</c>.
        /// </returns>
        public static string FormatMilestone(string milestoneId) =>
            s_milestone.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(milestoneId, nameof(milestoneId)));

        /// <summary>Parses the given resource name string into a new <see cref="MilestoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>milestones/{milestone}</c></description></item></list>
        /// </remarks>
        /// <param name="milestoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MilestoneName"/> if successful.</returns>
        public static MilestoneName Parse(string milestoneName) => Parse(milestoneName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MilestoneName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>milestones/{milestone}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="milestoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MilestoneName"/> if successful.</returns>
        public static MilestoneName Parse(string milestoneName, bool allowUnparsed) =>
            TryParse(milestoneName, allowUnparsed, out MilestoneName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MilestoneName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>milestones/{milestone}</c></description></item></list>
        /// </remarks>
        /// <param name="milestoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MilestoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string milestoneName, out MilestoneName result) => TryParse(milestoneName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MilestoneName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>milestones/{milestone}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="milestoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MilestoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string milestoneName, bool allowUnparsed, out MilestoneName result)
        {
            gax::GaxPreconditions.CheckNotNull(milestoneName, nameof(milestoneName));
            gax::TemplatedResourceName resourceName;
            if (s_milestone.TryParseName(milestoneName, out resourceName))
            {
                result = FromMilestone(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(milestoneName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MilestoneName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string milestoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MilestoneId = milestoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MilestoneName"/> class from the component parts of pattern
        /// <c>milestones/{milestone}</c>
        /// </summary>
        /// <param name="milestoneId">The <c>Milestone</c> ID. Must not be <c>null</c> or empty.</param>
        public MilestoneName(string milestoneId) : this(ResourceNameType.Milestone, milestoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(milestoneId, nameof(milestoneId)))
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
        /// The <c>Milestone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MilestoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Milestone: return s_milestone.Expand(MilestoneId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MilestoneName);

        /// <inheritdoc/>
        public bool Equals(MilestoneName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MilestoneName a, MilestoneName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MilestoneName a, MilestoneName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Build</c> resource.</summary>
    public sealed partial class BuildName : gax::IResourceName, sys::IEquatable<BuildName>
    {
        /// <summary>The possible contents of <see cref="BuildName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>.
            /// </summary>
            BuildTargetModelBuild = 1,
        }

        private static gax::PathTemplate s_buildTargetModelBuild = new gax::PathTemplate("buildTargets/{build_target}/models/{model}/builds/{build}");

        /// <summary>Creates a <see cref="BuildName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BuildName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BuildName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BuildName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BuildName"/> with the pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildName"/> constructed from the provided ids.</returns>
        public static BuildName FromBuildTargetModelBuild(string buildTargetId, string modelId, string buildId) =>
            new BuildName(ResourceNameType.BuildTargetModelBuild, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>.
        /// </returns>
        public static string Format(string buildTargetId, string modelId, string buildId) =>
            FormatBuildTargetModelBuild(buildTargetId, modelId, buildId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>.
        /// </returns>
        public static string FormatBuildTargetModelBuild(string buildTargetId, string modelId, string buildId) =>
            s_buildTargetModelBuild.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>Parses the given resource name string into a new <see cref="BuildName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}/builds/{build}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BuildName"/> if successful.</returns>
        public static BuildName Parse(string buildName) => Parse(buildName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}/builds/{build}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BuildName"/> if successful.</returns>
        public static BuildName Parse(string buildName, bool allowUnparsed) =>
            TryParse(buildName, allowUnparsed, out BuildName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}/builds/{build}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildName, out BuildName result) => TryParse(buildName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>buildTargets/{build_target}/models/{model}/builds/{build}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildName, bool allowUnparsed, out BuildName result)
        {
            gax::GaxPreconditions.CheckNotNull(buildName, nameof(buildName));
            gax::TemplatedResourceName resourceName;
            if (s_buildTargetModelBuild.TryParseName(buildName, out resourceName))
            {
                result = FromBuildTargetModelBuild(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(buildName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BuildName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string buildId = null, string buildTargetId = null, string modelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BuildId = buildId;
            BuildTargetId = buildTargetId;
            ModelId = modelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BuildName"/> class from the component parts of pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}</c>
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        public BuildName(string buildTargetId, string modelId, string buildId) : this(ResourceNameType.BuildTargetModelBuild, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)))
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
        /// The <c>Build</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildId { get; }

        /// <summary>
        /// The <c>BuildTarget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildTargetId { get; }

        /// <summary>
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BuildTargetModelBuild: return s_buildTargetModelBuild.Expand(BuildTargetId, ModelId, BuildId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildName);

        /// <inheritdoc/>
        public bool Equals(BuildName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BuildName a, BuildName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BuildName a, BuildName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BuildArtifact</c> resource.</summary>
    public sealed partial class BuildArtifactName : gax::IResourceName, sys::IEquatable<BuildArtifactName>
    {
        /// <summary>The possible contents of <see cref="BuildArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>.
            /// </summary>
            BuildTargetModelBuildArtifact = 1,
        }

        private static gax::PathTemplate s_buildTargetModelBuildArtifact = new gax::PathTemplate("buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}");

        /// <summary>Creates a <see cref="BuildArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BuildArtifactName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BuildArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BuildArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BuildArtifactName"/> with the pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildArtifactName"/> constructed from the provided ids.</returns>
        public static BuildArtifactName FromBuildTargetModelBuildArtifact(string buildTargetId, string modelId, string buildId, string artifactId) =>
            new BuildArtifactName(ResourceNameType.BuildTargetModelBuildArtifact, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildArtifactName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildArtifactName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>.
        /// </returns>
        public static string Format(string buildTargetId, string modelId, string buildId, string artifactId) =>
            FormatBuildTargetModelBuildArtifact(buildTargetId, modelId, buildId, artifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildArtifactName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildArtifactName"/> with pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>.
        /// </returns>
        public static string FormatBuildTargetModelBuildArtifact(string buildTargetId, string modelId, string buildId, string artifactId) =>
            s_buildTargetModelBuildArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="buildArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BuildArtifactName"/> if successful.</returns>
        public static BuildArtifactName Parse(string buildArtifactName) => Parse(buildArtifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BuildArtifactName"/> if successful.</returns>
        public static BuildArtifactName Parse(string buildArtifactName, bool allowUnparsed) =>
            TryParse(buildArtifactName, allowUnparsed, out BuildArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="buildArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildArtifactName, out BuildArtifactName result) =>
            TryParse(buildArtifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildArtifactName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildArtifactName, bool allowUnparsed, out BuildArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(buildArtifactName, nameof(buildArtifactName));
            gax::TemplatedResourceName resourceName;
            if (s_buildTargetModelBuildArtifact.TryParseName(buildArtifactName, out resourceName))
            {
                result = FromBuildTargetModelBuildArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(buildArtifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BuildArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string artifactId = null, string buildId = null, string buildTargetId = null, string modelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ArtifactId = artifactId;
            BuildId = buildId;
            BuildTargetId = buildTargetId;
            ModelId = modelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BuildArtifactName"/> class from the component parts of pattern
        /// <c>buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}</c>
        /// </summary>
        /// <param name="buildTargetId">The <c>BuildTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        public BuildArtifactName(string buildTargetId, string modelId, string buildId, string artifactId) : this(ResourceNameType.BuildTargetModelBuildArtifact, buildTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildTargetId, nameof(buildTargetId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)))
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
        /// The <c>Artifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ArtifactId { get; }

        /// <summary>
        /// The <c>Build</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildId { get; }

        /// <summary>
        /// The <c>BuildTarget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildTargetId { get; }

        /// <summary>
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BuildTargetModelBuildArtifact: return s_buildTargetModelBuildArtifact.Expand(BuildTargetId, ModelId, BuildId, ArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildArtifactName);

        /// <inheritdoc/>
        public bool Equals(BuildArtifactName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BuildArtifactName a, BuildArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BuildArtifactName a, BuildArtifactName b) => !(a == b);
    }

    public partial class BuildTarget
    {
        /// <summary>
        /// <see cref="gcmv::BuildTargetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::BuildTargetName BuildTargetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::BuildTargetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Model
    {
        /// <summary>
        /// <see cref="gcmv::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Milestone
    {
        /// <summary>
        /// <see cref="gcmv::MilestoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::MilestoneName MilestoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::MilestoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Build
    {
        /// <summary>
        /// <see cref="gcmv::BuildName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::BuildName BuildName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::BuildName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MilestoneName"/>-typed view over the <see cref="Milestone"/> resource name property.
        /// </summary>
        public MilestoneName MilestoneAsMilestoneName
        {
            get => string.IsNullOrEmpty(Milestone) ? null : MilestoneName.Parse(Milestone, allowUnparsed: true);
            set => Milestone = value?.ToString() ?? "";
        }
    }

    public partial class BuildArtifact
    {
        /// <summary>
        /// <see cref="gcmv::BuildArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::BuildArtifactName BuildArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::BuildArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="BuildName"/>-typed view over the <see cref="Build"/> resource name property.</summary>
        public BuildName BuildAsBuildName
        {
            get => string.IsNullOrEmpty(Build) ? null : BuildName.Parse(Build, allowUnparsed: true);
            set => Build = value?.ToString() ?? "";
        }
    }
}
