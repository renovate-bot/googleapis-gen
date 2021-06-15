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

from .services.application_detail_service import ApplicationDetailServiceClient
from .services.application_detail_service import ApplicationDetailServiceAsyncClient
from .services.test_environment_discovery_service import TestEnvironmentDiscoveryServiceClient
from .services.test_environment_discovery_service import TestEnvironmentDiscoveryServiceAsyncClient
from .services.test_execution_service import TestExecutionServiceClient
from .services.test_execution_service import TestExecutionServiceAsyncClient

from .types.application_details import ApkDetail
from .types.application_details import ApkManifest
from .types.application_details import GetApkDetailsRequest
from .types.application_details import GetApkDetailsResponse
from .types.application_details import IntentFilter
from .types.test_environment_discovery import AndroidDeviceCatalog
from .types.test_environment_discovery import AndroidModel
from .types.test_environment_discovery import AndroidRuntimeConfiguration
from .types.test_environment_discovery import AndroidVersion
from .types.test_environment_discovery import DeviceIpBlock
from .types.test_environment_discovery import DeviceIpBlockCatalog
from .types.test_environment_discovery import Distribution
from .types.test_environment_discovery import GetTestEnvironmentCatalogRequest
from .types.test_environment_discovery import IosDeviceCatalog
from .types.test_environment_discovery import IosModel
from .types.test_environment_discovery import IosRuntimeConfiguration
from .types.test_environment_discovery import IosVersion
from .types.test_environment_discovery import Locale
from .types.test_environment_discovery import NetworkConfiguration
from .types.test_environment_discovery import NetworkConfigurationCatalog
from .types.test_environment_discovery import Orientation
from .types.test_environment_discovery import ProvidedSoftwareCatalog
from .types.test_environment_discovery import TestEnvironmentCatalog
from .types.test_environment_discovery import TrafficRule
from .types.test_environment_discovery import XcodeVersion
from .types.test_environment_discovery import DeviceForm
from .types.test_environment_discovery import DeviceFormFactor
from .types.test_execution import Account
from .types.test_execution import AndroidDevice
from .types.test_execution import AndroidDeviceList
from .types.test_execution import AndroidInstrumentationTest
from .types.test_execution import AndroidMatrix
from .types.test_execution import AndroidRoboTest
from .types.test_execution import AndroidTestLoop
from .types.test_execution import Apk
from .types.test_execution import AppBundle
from .types.test_execution import CancelTestMatrixRequest
from .types.test_execution import CancelTestMatrixResponse
from .types.test_execution import ClientInfo
from .types.test_execution import ClientInfoDetail
from .types.test_execution import CreateTestMatrixRequest
from .types.test_execution import DeviceFile
from .types.test_execution import Environment
from .types.test_execution import EnvironmentMatrix
from .types.test_execution import EnvironmentVariable
from .types.test_execution import FileReference
from .types.test_execution import GetTestMatrixRequest
from .types.test_execution import GoogleAuto
from .types.test_execution import GoogleCloudStorage
from .types.test_execution import InvalidRequestDetail
from .types.test_execution import IosDevice
from .types.test_execution import IosDeviceFile
from .types.test_execution import IosDeviceList
from .types.test_execution import IosTestLoop
from .types.test_execution import IosTestSetup
from .types.test_execution import IosXcTest
from .types.test_execution import LauncherActivityIntent
from .types.test_execution import ManualSharding
from .types.test_execution import ObbFile
from .types.test_execution import RegularFile
from .types.test_execution import ResultStorage
from .types.test_execution import RoboDirective
from .types.test_execution import RoboStartingIntent
from .types.test_execution import Shard
from .types.test_execution import ShardingOption
from .types.test_execution import StartActivityIntent
from .types.test_execution import SystraceSetup
from .types.test_execution import TestDetails
from .types.test_execution import TestExecution
from .types.test_execution import TestMatrix
from .types.test_execution import TestSetup
from .types.test_execution import TestSpecification
from .types.test_execution import TestTargetsForShard
from .types.test_execution import ToolResultsExecution
from .types.test_execution import ToolResultsHistory
from .types.test_execution import ToolResultsStep
from .types.test_execution import UniformSharding
from .types.test_execution import InvalidMatrixDetails
from .types.test_execution import OrchestratorOption
from .types.test_execution import OutcomeSummary
from .types.test_execution import RoboActionType
from .types.test_execution import TestState

__all__ = (
    'ApplicationDetailServiceAsyncClient',
    'TestEnvironmentDiscoveryServiceAsyncClient',
    'TestExecutionServiceAsyncClient',
'Account',
'AndroidDevice',
'AndroidDeviceCatalog',
'AndroidDeviceList',
'AndroidInstrumentationTest',
'AndroidMatrix',
'AndroidModel',
'AndroidRoboTest',
'AndroidRuntimeConfiguration',
'AndroidTestLoop',
'AndroidVersion',
'Apk',
'ApkDetail',
'ApkManifest',
'AppBundle',
'ApplicationDetailServiceClient',
'CancelTestMatrixRequest',
'CancelTestMatrixResponse',
'ClientInfo',
'ClientInfoDetail',
'CreateTestMatrixRequest',
'DeviceFile',
'DeviceForm',
'DeviceFormFactor',
'DeviceIpBlock',
'DeviceIpBlockCatalog',
'Distribution',
'Environment',
'EnvironmentMatrix',
'EnvironmentVariable',
'FileReference',
'GetApkDetailsRequest',
'GetApkDetailsResponse',
'GetTestEnvironmentCatalogRequest',
'GetTestMatrixRequest',
'GoogleAuto',
'GoogleCloudStorage',
'IntentFilter',
'InvalidMatrixDetails',
'InvalidRequestDetail',
'IosDevice',
'IosDeviceCatalog',
'IosDeviceFile',
'IosDeviceList',
'IosModel',
'IosRuntimeConfiguration',
'IosTestLoop',
'IosTestSetup',
'IosVersion',
'IosXcTest',
'LauncherActivityIntent',
'Locale',
'ManualSharding',
'NetworkConfiguration',
'NetworkConfigurationCatalog',
'ObbFile',
'OrchestratorOption',
'Orientation',
'OutcomeSummary',
'ProvidedSoftwareCatalog',
'RegularFile',
'ResultStorage',
'RoboActionType',
'RoboDirective',
'RoboStartingIntent',
'Shard',
'ShardingOption',
'StartActivityIntent',
'SystraceSetup',
'TestDetails',
'TestEnvironmentCatalog',
'TestEnvironmentDiscoveryServiceClient',
'TestExecution',
'TestExecutionServiceClient',
'TestMatrix',
'TestSetup',
'TestSpecification',
'TestState',
'TestTargetsForShard',
'ToolResultsExecution',
'ToolResultsHistory',
'ToolResultsStep',
'TrafficRule',
'UniformSharding',
'XcodeVersion',
)
