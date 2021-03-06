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
    ReportInventoryRequest,
    ReportInventoryResponse,
    ReportTaskCompleteRequest,
    ReportTaskCompleteResponse,
    ReportTaskProgressRequest,
    ReportTaskProgressResponse,
    StartNextTaskRequest,
    StartNextTaskResponse,
)
from .config_common import (
    OSPolicyResourceCompliance,
    OSPolicyResourceConfigStep,
    OSPolicyComplianceState,
)
from .inventory import (
    Inventory,
)
from .os_policy import (
    OSPolicy,
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
    ApplyConfigTask,
    ApplyConfigTaskOutput,
    ApplyConfigTaskProgress,
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
    'ReportInventoryRequest',
    'ReportInventoryResponse',
    'ReportTaskCompleteRequest',
    'ReportTaskCompleteResponse',
    'ReportTaskProgressRequest',
    'ReportTaskProgressResponse',
    'StartNextTaskRequest',
    'StartNextTaskResponse',
    'OSPolicyResourceCompliance',
    'OSPolicyResourceConfigStep',
    'OSPolicyComplianceState',
    'Inventory',
    'OSPolicy',
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
    'ApplyConfigTask',
    'ApplyConfigTaskOutput',
    'ApplyConfigTaskProgress',
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
