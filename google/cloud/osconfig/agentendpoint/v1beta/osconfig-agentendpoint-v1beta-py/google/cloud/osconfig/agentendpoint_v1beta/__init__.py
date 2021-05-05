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

from .services.agent_endpoint_service import AgentEndpointServiceClient
from .services.agent_endpoint_service import AgentEndpointServiceAsyncClient

from .types.agentendpoint import ReceiveTaskNotificationRequest
from .types.agentendpoint import ReceiveTaskNotificationResponse
from .types.agentendpoint import RegisterAgentRequest
from .types.agentendpoint import RegisterAgentResponse
from .types.agentendpoint import ReportTaskCompleteRequest
from .types.agentendpoint import ReportTaskCompleteResponse
from .types.agentendpoint import ReportTaskProgressRequest
from .types.agentendpoint import ReportTaskProgressResponse
from .types.agentendpoint import StartNextTaskRequest
from .types.agentendpoint import StartNextTaskResponse
from .types.guest_policies import AptRepository
from .types.guest_policies import EffectiveGuestPolicy
from .types.guest_policies import GooRepository
from .types.guest_policies import LookupEffectiveGuestPolicyRequest
from .types.guest_policies import Package
from .types.guest_policies import PackageRepository
from .types.guest_policies import SoftwareRecipe
from .types.guest_policies import YumRepository
from .types.guest_policies import ZypperRepository
from .types.guest_policies import DesiredState
from .types.patch_jobs import AptSettings
from .types.patch_jobs import ExecStep
from .types.patch_jobs import ExecStepConfig
from .types.patch_jobs import GcsObject
from .types.patch_jobs import GooSettings
from .types.patch_jobs import PatchConfig
from .types.patch_jobs import RetryStrategy
from .types.patch_jobs import WindowsUpdateSettings
from .types.patch_jobs import YumSettings
from .types.patch_jobs import ZypperSettings
from .types.tasks import ApplyPatchesTask
from .types.tasks import ApplyPatchesTaskOutput
from .types.tasks import ApplyPatchesTaskProgress
from .types.tasks import ExecStepTask
from .types.tasks import ExecStepTaskOutput
from .types.tasks import ExecStepTaskProgress
from .types.tasks import Task
from .types.tasks import TaskDirective
from .types.tasks import TaskType

__all__ = (
'AgentEndpointServiceClient',
'ApplyPatchesTask',
'ApplyPatchesTaskOutput',
'ApplyPatchesTaskProgress',
'AptRepository',
'AptSettings',
'DesiredState',
'EffectiveGuestPolicy',
'ExecStep',
'ExecStepConfig',
'ExecStepTask',
'ExecStepTaskOutput',
'ExecStepTaskProgress',
'GcsObject',
'GooRepository',
'GooSettings',
'LookupEffectiveGuestPolicyRequest',
'Package',
'PackageRepository',
'PatchConfig',
'ReceiveTaskNotificationRequest',
'ReceiveTaskNotificationResponse',
'RegisterAgentRequest',
'RegisterAgentResponse',
'ReportTaskCompleteRequest',
'ReportTaskCompleteResponse',
'ReportTaskProgressRequest',
'ReportTaskProgressResponse',
'RetryStrategy',
'SoftwareRecipe',
'StartNextTaskRequest',
'StartNextTaskResponse',
'Task',
'TaskDirective',
'TaskType',
'WindowsUpdateSettings',
'YumRepository',
'YumSettings',
'ZypperRepository',
'ZypperSettings',
)
