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

from google.cloud.osconfig.agentendpoint_v1beta.services.agent_endpoint_service.async_client import AgentEndpointServiceAsyncClient
from google.cloud.osconfig.agentendpoint_v1beta.services.agent_endpoint_service.client import AgentEndpointServiceClient
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import ReceiveTaskNotificationRequest
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import ReceiveTaskNotificationResponse
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import RegisterAgentRequest
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import RegisterAgentResponse
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import ReportTaskCompleteRequest
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import ReportTaskCompleteResponse
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import ReportTaskProgressRequest
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import ReportTaskProgressResponse
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import StartNextTaskRequest
from google.cloud.osconfig.agentendpoint_v1beta.types.agentendpoint import StartNextTaskResponse
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import AptRepository
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import DesiredState
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import EffectiveGuestPolicy
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import GooRepository
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import LookupEffectiveGuestPolicyRequest
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import Package
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import PackageRepository
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import SoftwareRecipe
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import YumRepository
from google.cloud.osconfig.agentendpoint_v1beta.types.guest_policies import ZypperRepository
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import AptSettings
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import ExecStep
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import ExecStepConfig
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import GcsObject
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import GooSettings
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import PatchConfig
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import RetryStrategy
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import WindowsUpdateSettings
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import YumSettings
from google.cloud.osconfig.agentendpoint_v1beta.types.patch_jobs import ZypperSettings
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import ApplyPatchesTask
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import ApplyPatchesTaskOutput
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import ApplyPatchesTaskProgress
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import ExecStepTask
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import ExecStepTaskOutput
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import ExecStepTaskProgress
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import Task
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import TaskDirective
from google.cloud.osconfig.agentendpoint_v1beta.types.tasks import TaskType

__all__ = (
    'AgentEndpointServiceAsyncClient',
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
