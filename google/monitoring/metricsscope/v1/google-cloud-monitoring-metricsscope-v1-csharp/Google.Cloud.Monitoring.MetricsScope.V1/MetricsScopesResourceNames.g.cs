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

using gcmmv = Google.Cloud.Monitoring.MetricsScope.V1;

namespace Google.Cloud.Monitoring.MetricsScope.V1
{
    public partial class GetMetricsScopeRequest
    {
        /// <summary>
        /// <see cref="gcmmv::MetricsScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmmv::MetricsScopeName MetricsScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmmv::MetricsScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMonitoredProjectRequest
    {
        /// <summary>
        /// <see cref="MetricsScopeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MetricsScopeName ParentAsMetricsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetricsScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMonitoredProjectRequest
    {
        /// <summary>
        /// <see cref="gcmmv::MonitoredProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmmv::MonitoredProjectName MonitoredProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmmv::MonitoredProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
