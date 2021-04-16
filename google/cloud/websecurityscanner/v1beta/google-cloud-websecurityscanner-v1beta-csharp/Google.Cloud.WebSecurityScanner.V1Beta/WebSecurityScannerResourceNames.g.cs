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

using gagr = Google.Api.Gax.ResourceNames;
using gcwv = Google.Cloud.WebSecurityScanner.V1Beta;

namespace Google.Cloud.WebSecurityScanner.V1Beta
{
    public partial class CreateScanConfigRequest
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

    public partial class DeleteScanConfigRequest
    {
        /// <summary>
        /// <see cref="gcwv::ScanConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanConfigName ScanConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetScanConfigRequest
    {
        /// <summary>
        /// <see cref="gcwv::ScanConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanConfigName ScanConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListScanConfigsRequest
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

    public partial class StartScanRunRequest
    {
        /// <summary>
        /// <see cref="gcwv::ScanConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanConfigName ScanConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetScanRunRequest
    {
        /// <summary>
        /// <see cref="gcwv::ScanRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanRunName ScanRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListScanRunsRequest
    {
        /// <summary>
        /// <see cref="ScanConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ScanConfigName ParentAsScanConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScanConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class StopScanRunRequest
    {
        /// <summary>
        /// <see cref="gcwv::ScanRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ScanRunName ScanRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ScanRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCrawledUrlsRequest
    {
        /// <summary>
        /// <see cref="ScanRunName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ScanRunName ParentAsScanRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScanRunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFindingRequest
    {
        /// <summary>
        /// <see cref="gcwv::FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::FindingName FindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::FindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFindingsRequest
    {
        /// <summary>
        /// <see cref="ScanRunName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ScanRunName ParentAsScanRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScanRunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListFindingTypeStatsRequest
    {
        /// <summary>
        /// <see cref="ScanRunName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ScanRunName ParentAsScanRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScanRunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
