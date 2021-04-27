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

from google.cloud.osconfig.agentendpoint_v1.services.agent_endpoint_service.async_client import AgentEndpointServiceAsyncClient
from google.cloud.osconfig.agentendpoint_v1.services.agent_endpoint_service.client import AgentEndpointServiceClient
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReceiveTaskNotificationRequest
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReceiveTaskNotificationResponse
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import RegisterAgentRequest
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import RegisterAgentResponse
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReportInventoryRequest
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReportInventoryResponse
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReportTaskCompleteRequest
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReportTaskCompleteResponse
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReportTaskProgressRequest
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import ReportTaskProgressResponse
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import StartNextTaskRequest
from google.cloud.osconfig.agentendpoint_v1.types.agentendpoint import StartNextTaskResponse
from google.cloud.osconfig.agentendpoint_v1.types.config_common import OSPolicyComplianceState
from google.cloud.osconfig.agentendpoint_v1.types.config_common import OSPolicyResourceCompliance
from google.cloud.osconfig.agentendpoint_v1.types.config_common import OSPolicyResourceConfigStep
from google.cloud.osconfig.agentendpoint_v1.types.inventory import Inventory
from google.cloud.osconfig.agentendpoint_v1.types.os_policy import OSPolicy
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import AptSettings
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import ExecStep
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import ExecStepConfig
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import GcsObject
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import GooSettings
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import PatchConfig
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import RetryStrategy
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import WindowsUpdateSettings
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import YumSettings
from google.cloud.osconfig.agentendpoint_v1.types.patch_jobs import ZypperSettings
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ApplyConfigTask
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ApplyConfigTaskOutput
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ApplyConfigTaskProgress
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ApplyPatchesTask
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ApplyPatchesTaskOutput
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ApplyPatchesTaskProgress
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ExecStepTask
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ExecStepTaskOutput
from google.cloud.osconfig.agentendpoint_v1.types.tasks import ExecStepTaskProgress
from google.cloud.osconfig.agentendpoint_v1.types.tasks import Task
from google.cloud.osconfig.agentendpoint_v1.types.tasks import TaskDirective
from google.cloud.osconfig.agentendpoint_v1.types.tasks import TaskType

__all__ = ('AgentEndpointServiceAsyncClient',
    'AgentEndpointServiceClient',
    'ApplyConfigTask',
    'ApplyConfigTaskOutput',
    'ApplyConfigTaskProgress',
    'ApplyPatchesTask',
    'ApplyPatchesTaskOutput',
    'ApplyPatchesTaskProgress',
    'AptSettings',
    'ExecStep',
    'ExecStepConfig',
    'ExecStepTask',
    'ExecStepTaskOutput',
    'ExecStepTaskProgress',
    'GcsObject',
    'GooSettings',
    'Inventory',
    'OSPolicy',
    'OSPolicyComplianceState',
    'OSPolicyResourceCompliance',
    'OSPolicyResourceConfigStep',
    'PatchConfig',
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
    'RetryStrategy',
    'StartNextTaskRequest',
    'StartNextTaskResponse',
    'Task',
    'TaskDirective',
    'TaskType',
    'WindowsUpdateSettings',
    'YumSettings',
    'ZypperSettings',
)
