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

from google.devtools.testing_v1.services.application_detail_service.client import ApplicationDetailServiceClient
from google.devtools.testing_v1.services.application_detail_service.async_client import ApplicationDetailServiceAsyncClient
from google.devtools.testing_v1.services.test_environment_discovery_service.client import TestEnvironmentDiscoveryServiceClient
from google.devtools.testing_v1.services.test_environment_discovery_service.async_client import TestEnvironmentDiscoveryServiceAsyncClient
from google.devtools.testing_v1.services.test_execution_service.client import TestExecutionServiceClient
from google.devtools.testing_v1.services.test_execution_service.async_client import TestExecutionServiceAsyncClient

from google.devtools.testing_v1.types.application_details import ApkDetail
from google.devtools.testing_v1.types.application_details import ApkManifest
from google.devtools.testing_v1.types.application_details import GetApkDetailsRequest
from google.devtools.testing_v1.types.application_details import GetApkDetailsResponse
from google.devtools.testing_v1.types.application_details import IntentFilter
from google.devtools.testing_v1.types.test_environment_discovery import AndroidDeviceCatalog
from google.devtools.testing_v1.types.test_environment_discovery import AndroidModel
from google.devtools.testing_v1.types.test_environment_discovery import AndroidRuntimeConfiguration
from google.devtools.testing_v1.types.test_environment_discovery import AndroidVersion
from google.devtools.testing_v1.types.test_environment_discovery import DeviceIpBlock
from google.devtools.testing_v1.types.test_environment_discovery import DeviceIpBlockCatalog
from google.devtools.testing_v1.types.test_environment_discovery import Distribution
from google.devtools.testing_v1.types.test_environment_discovery import GetTestEnvironmentCatalogRequest
from google.devtools.testing_v1.types.test_environment_discovery import IosDeviceCatalog
from google.devtools.testing_v1.types.test_environment_discovery import IosModel
from google.devtools.testing_v1.types.test_environment_discovery import IosRuntimeConfiguration
from google.devtools.testing_v1.types.test_environment_discovery import IosVersion
from google.devtools.testing_v1.types.test_environment_discovery import Locale
from google.devtools.testing_v1.types.test_environment_discovery import NetworkConfiguration
from google.devtools.testing_v1.types.test_environment_discovery import NetworkConfigurationCatalog
from google.devtools.testing_v1.types.test_environment_discovery import Orientation
from google.devtools.testing_v1.types.test_environment_discovery import ProvidedSoftwareCatalog
from google.devtools.testing_v1.types.test_environment_discovery import TestEnvironmentCatalog
from google.devtools.testing_v1.types.test_environment_discovery import TrafficRule
from google.devtools.testing_v1.types.test_environment_discovery import XcodeVersion
from google.devtools.testing_v1.types.test_environment_discovery import DeviceForm
from google.devtools.testing_v1.types.test_environment_discovery import DeviceFormFactor
from google.devtools.testing_v1.types.test_execution import Account
from google.devtools.testing_v1.types.test_execution import AndroidDevice
from google.devtools.testing_v1.types.test_execution import AndroidDeviceList
from google.devtools.testing_v1.types.test_execution import AndroidInstrumentationTest
from google.devtools.testing_v1.types.test_execution import AndroidMatrix
from google.devtools.testing_v1.types.test_execution import AndroidRoboTest
from google.devtools.testing_v1.types.test_execution import AndroidTestLoop
from google.devtools.testing_v1.types.test_execution import Apk
from google.devtools.testing_v1.types.test_execution import AppBundle
from google.devtools.testing_v1.types.test_execution import CancelTestMatrixRequest
from google.devtools.testing_v1.types.test_execution import CancelTestMatrixResponse
from google.devtools.testing_v1.types.test_execution import ClientInfo
from google.devtools.testing_v1.types.test_execution import ClientInfoDetail
from google.devtools.testing_v1.types.test_execution import CreateTestMatrixRequest
from google.devtools.testing_v1.types.test_execution import DeviceFile
from google.devtools.testing_v1.types.test_execution import Environment
from google.devtools.testing_v1.types.test_execution import EnvironmentMatrix
from google.devtools.testing_v1.types.test_execution import EnvironmentVariable
from google.devtools.testing_v1.types.test_execution import FileReference
from google.devtools.testing_v1.types.test_execution import GetTestMatrixRequest
from google.devtools.testing_v1.types.test_execution import GoogleAuto
from google.devtools.testing_v1.types.test_execution import GoogleCloudStorage
from google.devtools.testing_v1.types.test_execution import InvalidRequestDetail
from google.devtools.testing_v1.types.test_execution import IosDevice
from google.devtools.testing_v1.types.test_execution import IosDeviceFile
from google.devtools.testing_v1.types.test_execution import IosDeviceList
from google.devtools.testing_v1.types.test_execution import IosTestLoop
from google.devtools.testing_v1.types.test_execution import IosTestSetup
from google.devtools.testing_v1.types.test_execution import IosXcTest
from google.devtools.testing_v1.types.test_execution import LauncherActivityIntent
from google.devtools.testing_v1.types.test_execution import ManualSharding
from google.devtools.testing_v1.types.test_execution import ObbFile
from google.devtools.testing_v1.types.test_execution import RegularFile
from google.devtools.testing_v1.types.test_execution import ResultStorage
from google.devtools.testing_v1.types.test_execution import RoboDirective
from google.devtools.testing_v1.types.test_execution import RoboStartingIntent
from google.devtools.testing_v1.types.test_execution import Shard
from google.devtools.testing_v1.types.test_execution import ShardingOption
from google.devtools.testing_v1.types.test_execution import StartActivityIntent
from google.devtools.testing_v1.types.test_execution import SystraceSetup
from google.devtools.testing_v1.types.test_execution import TestDetails
from google.devtools.testing_v1.types.test_execution import TestExecution
from google.devtools.testing_v1.types.test_execution import TestMatrix
from google.devtools.testing_v1.types.test_execution import TestSetup
from google.devtools.testing_v1.types.test_execution import TestSpecification
from google.devtools.testing_v1.types.test_execution import TestTargetsForShard
from google.devtools.testing_v1.types.test_execution import ToolResultsExecution
from google.devtools.testing_v1.types.test_execution import ToolResultsHistory
from google.devtools.testing_v1.types.test_execution import ToolResultsStep
from google.devtools.testing_v1.types.test_execution import UniformSharding
from google.devtools.testing_v1.types.test_execution import InvalidMatrixDetails
from google.devtools.testing_v1.types.test_execution import OrchestratorOption
from google.devtools.testing_v1.types.test_execution import OutcomeSummary
from google.devtools.testing_v1.types.test_execution import RoboActionType
from google.devtools.testing_v1.types.test_execution import TestState

__all__ = ('ApplicationDetailServiceClient',
    'ApplicationDetailServiceAsyncClient',
    'TestEnvironmentDiscoveryServiceClient',
    'TestEnvironmentDiscoveryServiceAsyncClient',
    'TestExecutionServiceClient',
    'TestExecutionServiceAsyncClient',
    'ApkDetail',
    'ApkManifest',
    'GetApkDetailsRequest',
    'GetApkDetailsResponse',
    'IntentFilter',
    'AndroidDeviceCatalog',
    'AndroidModel',
    'AndroidRuntimeConfiguration',
    'AndroidVersion',
    'DeviceIpBlock',
    'DeviceIpBlockCatalog',
    'Distribution',
    'GetTestEnvironmentCatalogRequest',
    'IosDeviceCatalog',
    'IosModel',
    'IosRuntimeConfiguration',
    'IosVersion',
    'Locale',
    'NetworkConfiguration',
    'NetworkConfigurationCatalog',
    'Orientation',
    'ProvidedSoftwareCatalog',
    'TestEnvironmentCatalog',
    'TrafficRule',
    'XcodeVersion',
    'DeviceForm',
    'DeviceFormFactor',
    'Account',
    'AndroidDevice',
    'AndroidDeviceList',
    'AndroidInstrumentationTest',
    'AndroidMatrix',
    'AndroidRoboTest',
    'AndroidTestLoop',
    'Apk',
    'AppBundle',
    'CancelTestMatrixRequest',
    'CancelTestMatrixResponse',
    'ClientInfo',
    'ClientInfoDetail',
    'CreateTestMatrixRequest',
    'DeviceFile',
    'Environment',
    'EnvironmentMatrix',
    'EnvironmentVariable',
    'FileReference',
    'GetTestMatrixRequest',
    'GoogleAuto',
    'GoogleCloudStorage',
    'InvalidRequestDetail',
    'IosDevice',
    'IosDeviceFile',
    'IosDeviceList',
    'IosTestLoop',
    'IosTestSetup',
    'IosXcTest',
    'LauncherActivityIntent',
    'ManualSharding',
    'ObbFile',
    'RegularFile',
    'ResultStorage',
    'RoboDirective',
    'RoboStartingIntent',
    'Shard',
    'ShardingOption',
    'StartActivityIntent',
    'SystraceSetup',
    'TestDetails',
    'TestExecution',
    'TestMatrix',
    'TestSetup',
    'TestSpecification',
    'TestTargetsForShard',
    'ToolResultsExecution',
    'ToolResultsHistory',
    'ToolResultsStep',
    'UniformSharding',
    'InvalidMatrixDetails',
    'OrchestratorOption',
    'OutcomeSummary',
    'RoboActionType',
    'TestState',
)
