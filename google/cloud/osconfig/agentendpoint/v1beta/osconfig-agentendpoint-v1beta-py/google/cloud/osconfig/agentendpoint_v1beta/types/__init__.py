# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
from .agentendpoint import (
    ReceiveTaskNotificationRequest,
    ReceiveTaskNotificationResponse,
    RegisterAgentRequest,
    RegisterAgentResponse,
    ReportTaskCompleteRequest,
    ReportTaskCompleteResponse,
    ReportTaskProgressRequest,
    ReportTaskProgressResponse,
    StartNextTaskRequest,
    StartNextTaskResponse,
)
from .guest_policies import (
    AptRepository,
    EffectiveGuestPolicy,
    GooRepository,
    LookupEffectiveGuestPolicyRequest,
    Package,
    PackageRepository,
    SoftwareRecipe,
    YumRepository,
    ZypperRepository,
    DesiredState,
)
from .patch_jobs import (
    AptSettings,
    ExecStep,
    ExecStepConfig,
    GcsObject,
    GooSettings,
    PatchConfig,
    RetryStrategy,
    WindowsUpdateSettings,
    YumSettings,
    ZypperSettings,
)
from .tasks import (
    ApplyPatchesTask,
    ApplyPatchesTaskOutput,
    ApplyPatchesTaskProgress,
    ExecStepTask,
    ExecStepTaskOutput,
    ExecStepTaskProgress,
    Task,
    TaskDirective,
    TaskType,
)

__all__ = (
    'ReceiveTaskNotificationRequest',
    'ReceiveTaskNotificationResponse',
    'RegisterAgentRequest',
    'RegisterAgentResponse',
    'ReportTaskCompleteRequest',
    'ReportTaskCompleteResponse',
    'ReportTaskProgressRequest',
    'ReportTaskProgressResponse',
    'StartNextTaskRequest',
    'StartNextTaskResponse',
    'AptRepository',
    'EffectiveGuestPolicy',
    'GooRepository',
    'LookupEffectiveGuestPolicyRequest',
    'Package',
    'PackageRepository',
    'SoftwareRecipe',
    'YumRepository',
    'ZypperRepository',
    'DesiredState',
    'AptSettings',
    'ExecStep',
    'ExecStepConfig',
    'GcsObject',
    'GooSettings',
    'PatchConfig',
    'RetryStrategy',
    'WindowsUpdateSettings',
    'YumSettings',
    'ZypperSettings',
    'ApplyPatchesTask',
    'ApplyPatchesTaskOutput',
    'ApplyPatchesTaskProgress',
    'ExecStepTask',
    'ExecStepTaskOutput',
    'ExecStepTaskProgress',
    'Task',
    'TaskDirective',
    'TaskType',
)
