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

from google.cloud.osconfig_v1beta.services.os_config_service.async_client import OsConfigServiceAsyncClient
from google.cloud.osconfig_v1beta.services.os_config_service.client import OsConfigServiceClient
from google.cloud.osconfig_v1beta.types.guest_policies import AptRepository
from google.cloud.osconfig_v1beta.types.guest_policies import Assignment
from google.cloud.osconfig_v1beta.types.guest_policies import CreateGuestPolicyRequest
from google.cloud.osconfig_v1beta.types.guest_policies import DeleteGuestPolicyRequest
from google.cloud.osconfig_v1beta.types.guest_policies import DesiredState
from google.cloud.osconfig_v1beta.types.guest_policies import EffectiveGuestPolicy
from google.cloud.osconfig_v1beta.types.guest_policies import GetGuestPolicyRequest
from google.cloud.osconfig_v1beta.types.guest_policies import GooRepository
from google.cloud.osconfig_v1beta.types.guest_policies import GuestPolicy
from google.cloud.osconfig_v1beta.types.guest_policies import ListGuestPoliciesRequest
from google.cloud.osconfig_v1beta.types.guest_policies import ListGuestPoliciesResponse
from google.cloud.osconfig_v1beta.types.guest_policies import LookupEffectiveGuestPolicyRequest
from google.cloud.osconfig_v1beta.types.guest_policies import Package
from google.cloud.osconfig_v1beta.types.guest_policies import PackageRepository
from google.cloud.osconfig_v1beta.types.guest_policies import SoftwareRecipe
from google.cloud.osconfig_v1beta.types.guest_policies import UpdateGuestPolicyRequest
from google.cloud.osconfig_v1beta.types.guest_policies import YumRepository
from google.cloud.osconfig_v1beta.types.guest_policies import ZypperRepository
from google.cloud.osconfig_v1beta.types.patch_deployments import CreatePatchDeploymentRequest
from google.cloud.osconfig_v1beta.types.patch_deployments import DeletePatchDeploymentRequest
from google.cloud.osconfig_v1beta.types.patch_deployments import GetPatchDeploymentRequest
from google.cloud.osconfig_v1beta.types.patch_deployments import ListPatchDeploymentsRequest
from google.cloud.osconfig_v1beta.types.patch_deployments import ListPatchDeploymentsResponse
from google.cloud.osconfig_v1beta.types.patch_deployments import MonthlySchedule
from google.cloud.osconfig_v1beta.types.patch_deployments import OneTimeSchedule
from google.cloud.osconfig_v1beta.types.patch_deployments import PatchDeployment
from google.cloud.osconfig_v1beta.types.patch_deployments import RecurringSchedule
from google.cloud.osconfig_v1beta.types.patch_deployments import WeekDayOfMonth
from google.cloud.osconfig_v1beta.types.patch_deployments import WeeklySchedule
from google.cloud.osconfig_v1beta.types.patch_jobs import AptSettings
from google.cloud.osconfig_v1beta.types.patch_jobs import CancelPatchJobRequest
from google.cloud.osconfig_v1beta.types.patch_jobs import ExecStep
from google.cloud.osconfig_v1beta.types.patch_jobs import ExecStepConfig
from google.cloud.osconfig_v1beta.types.patch_jobs import ExecutePatchJobRequest
from google.cloud.osconfig_v1beta.types.patch_jobs import GcsObject
from google.cloud.osconfig_v1beta.types.patch_jobs import GetPatchJobRequest
from google.cloud.osconfig_v1beta.types.patch_jobs import GooSettings
from google.cloud.osconfig_v1beta.types.patch_jobs import Instance
from google.cloud.osconfig_v1beta.types.patch_jobs import ListPatchJobInstanceDetailsRequest
from google.cloud.osconfig_v1beta.types.patch_jobs import ListPatchJobInstanceDetailsResponse
from google.cloud.osconfig_v1beta.types.patch_jobs import ListPatchJobsRequest
from google.cloud.osconfig_v1beta.types.patch_jobs import ListPatchJobsResponse
from google.cloud.osconfig_v1beta.types.patch_jobs import PatchConfig
from google.cloud.osconfig_v1beta.types.patch_jobs import PatchInstanceFilter
from google.cloud.osconfig_v1beta.types.patch_jobs import PatchJob
from google.cloud.osconfig_v1beta.types.patch_jobs import PatchJobInstanceDetails
from google.cloud.osconfig_v1beta.types.patch_jobs import WindowsUpdateSettings
from google.cloud.osconfig_v1beta.types.patch_jobs import YumSettings
from google.cloud.osconfig_v1beta.types.patch_jobs import ZypperSettings

__all__ = ('AptRepository',
    'AptSettings',
    'Assignment',
    'CancelPatchJobRequest',
    'CreateGuestPolicyRequest',
    'CreatePatchDeploymentRequest',
    'DeleteGuestPolicyRequest',
    'DeletePatchDeploymentRequest',
    'DesiredState',
    'EffectiveGuestPolicy',
    'ExecStep',
    'ExecStepConfig',
    'ExecutePatchJobRequest',
    'GcsObject',
    'GetGuestPolicyRequest',
    'GetPatchDeploymentRequest',
    'GetPatchJobRequest',
    'GooRepository',
    'GooSettings',
    'GuestPolicy',
    'Instance',
    'ListGuestPoliciesRequest',
    'ListGuestPoliciesResponse',
    'ListPatchDeploymentsRequest',
    'ListPatchDeploymentsResponse',
    'ListPatchJobInstanceDetailsRequest',
    'ListPatchJobInstanceDetailsResponse',
    'ListPatchJobsRequest',
    'ListPatchJobsResponse',
    'LookupEffectiveGuestPolicyRequest',
    'MonthlySchedule',
    'OneTimeSchedule',
    'OsConfigServiceAsyncClient',
    'OsConfigServiceClient',
    'Package',
    'PackageRepository',
    'PatchConfig',
    'PatchDeployment',
    'PatchInstanceFilter',
    'PatchJob',
    'PatchJobInstanceDetails',
    'RecurringSchedule',
    'SoftwareRecipe',
    'UpdateGuestPolicyRequest',
    'WeekDayOfMonth',
    'WeeklySchedule',
    'WindowsUpdateSettings',
    'YumRepository',
    'YumSettings',
    'ZypperRepository',
    'ZypperSettings',
)
