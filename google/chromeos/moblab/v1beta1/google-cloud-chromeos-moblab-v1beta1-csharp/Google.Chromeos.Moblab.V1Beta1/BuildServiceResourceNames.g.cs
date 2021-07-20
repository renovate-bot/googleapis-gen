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

using gcmv = Google.Chromeos.Moblab.V1Beta1;

namespace Google.Chromeos.Moblab.V1Beta1
{
    public partial class FindMostStableBuildRequest
    {
        /// <summary>
        /// <see cref="BuildTargetName"/>-typed view over the <see cref="BuildTarget"/> resource name property.
        /// </summary>
        public BuildTargetName BuildTargetAsBuildTargetName
        {
            get => string.IsNullOrEmpty(BuildTarget) ? null : BuildTargetName.Parse(BuildTarget, allowUnparsed: true);
            set => BuildTarget = value?.ToString() ?? "";
        }
    }

    public partial class ListBuildsRequest
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ModelName ParentAsModelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ModelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CheckBuildStageStatusRequest
    {
        /// <summary>
        /// <see cref="gcmv::BuildArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::BuildArtifactName BuildArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::BuildArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StageBuildRequest
    {
        /// <summary>
        /// <see cref="gcmv::BuildArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::BuildArtifactName BuildArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::BuildArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
