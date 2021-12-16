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

from google.cloud.sql_v1beta4.services.sql_backup_runs_service.client import SqlBackupRunsServiceClient
from google.cloud.sql_v1beta4.services.sql_backup_runs_service.async_client import SqlBackupRunsServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_connect_service.client import SqlConnectServiceClient
from google.cloud.sql_v1beta4.services.sql_connect_service.async_client import SqlConnectServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_databases_service.client import SqlDatabasesServiceClient
from google.cloud.sql_v1beta4.services.sql_databases_service.async_client import SqlDatabasesServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_flags_service.client import SqlFlagsServiceClient
from google.cloud.sql_v1beta4.services.sql_flags_service.async_client import SqlFlagsServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_instances_service.client import SqlInstancesServiceClient
from google.cloud.sql_v1beta4.services.sql_instances_service.async_client import SqlInstancesServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_operations_service.client import SqlOperationsServiceClient
from google.cloud.sql_v1beta4.services.sql_operations_service.async_client import SqlOperationsServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_ssl_certs_service.client import SqlSslCertsServiceClient
from google.cloud.sql_v1beta4.services.sql_ssl_certs_service.async_client import SqlSslCertsServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_tiers_service.client import SqlTiersServiceClient
from google.cloud.sql_v1beta4.services.sql_tiers_service.async_client import SqlTiersServiceAsyncClient
from google.cloud.sql_v1beta4.services.sql_users_service.client import SqlUsersServiceClient
from google.cloud.sql_v1beta4.services.sql_users_service.async_client import SqlUsersServiceAsyncClient

from google.cloud.sql_v1beta4.types.cloud_sql import SqlBackupRunsDeleteRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlBackupRunsGetRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlBackupRunsInsertRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlBackupRunsListRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlDatabasesDeleteRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlDatabasesGetRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlDatabasesInsertRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlDatabasesListRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlDatabasesUpdateRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlFlagsListRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesAddServerCaRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesCloneRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesCreateEphemeralCertRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesDeleteRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesDemoteMasterRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesExportRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesFailoverRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesGetRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesImportRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesInsertRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesListRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesListServerCasRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesPatchRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesPromoteReplicaRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesRescheduleMaintenanceRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesResetSslConfigRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesRestartRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesRestoreBackupRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesRotateServerCaRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesStartExternalSyncRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesStartReplicaRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesStopReplicaRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesTruncateLogRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesUpdateRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlInstancesVerifyExternalSyncSettingsRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlOperationsGetRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlOperationsListRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlSslCertsDeleteRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlSslCertsGetRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlSslCertsInsertRequest
from google.cloud.sql_v1beta4.types.cloud_sql import SqlSslCertsListRequest
from google.cloud.sql_v1beta4.types.cloud_sql_connect import ConnectSettings
from google.cloud.sql_v1beta4.types.cloud_sql_connect import GenerateEphemeralCertRequest
from google.cloud.sql_v1beta4.types.cloud_sql_connect import GenerateEphemeralCertResponse
from google.cloud.sql_v1beta4.types.cloud_sql_connect import GetConnectSettingsRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import AclEntry
from google.cloud.sql_v1beta4.types.cloud_sql_resources import ApiWarning
from google.cloud.sql_v1beta4.types.cloud_sql_resources import BackupConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import BackupContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import BackupRetentionSettings
from google.cloud.sql_v1beta4.types.cloud_sql_resources import BackupRun
from google.cloud.sql_v1beta4.types.cloud_sql_resources import BackupRunsListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import BinLogCoordinates
from google.cloud.sql_v1beta4.types.cloud_sql_resources import CloneContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import Database
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DatabaseFlags
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DatabaseInstance
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DatabasesListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DemoteMasterConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DemoteMasterContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DemoteMasterMySqlReplicaConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DenyMaintenancePeriod
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DiskEncryptionConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import DiskEncryptionStatus
from google.cloud.sql_v1beta4.types.cloud_sql_resources import ExportContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import FailoverContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import Flag
from google.cloud.sql_v1beta4.types.cloud_sql_resources import FlagsListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import ImportContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InsightsConfig
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstanceReference
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesCloneRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesDemoteMasterRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesExportRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesFailoverRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesImportRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesListServerCasResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesRestoreBackupRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesRotateServerCaRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import InstancesTruncateLogRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import IpConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import IpMapping
from google.cloud.sql_v1beta4.types.cloud_sql_resources import LocationPreference
from google.cloud.sql_v1beta4.types.cloud_sql_resources import MaintenanceWindow
from google.cloud.sql_v1beta4.types.cloud_sql_resources import MySqlReplicaConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import MySqlSyncConfig
from google.cloud.sql_v1beta4.types.cloud_sql_resources import OnPremisesConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import Operation
from google.cloud.sql_v1beta4.types.cloud_sql_resources import OperationError
from google.cloud.sql_v1beta4.types.cloud_sql_resources import OperationErrors
from google.cloud.sql_v1beta4.types.cloud_sql_resources import OperationsListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import PasswordValidationPolicy
from google.cloud.sql_v1beta4.types.cloud_sql_resources import ReplicaConfiguration
from google.cloud.sql_v1beta4.types.cloud_sql_resources import RestoreBackupContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import RotateServerCaContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import Settings
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlActiveDirectoryConfig
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlExternalSyncSettingError
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlInstancesRescheduleMaintenanceRequestBody
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlInstancesVerifyExternalSyncSettingsResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlServerAuditConfig
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlServerDatabaseDetails
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SslCert
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SslCertDetail
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SslCertsCreateEphemeralRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SslCertsInsertRequest
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SslCertsInsertResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SslCertsListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SyncFlags
from google.cloud.sql_v1beta4.types.cloud_sql_resources import TruncateLogContext
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlAvailabilityType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlBackendType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlBackupKind
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlBackupRunStatus
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlBackupRunType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlDatabaseVersion
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlDataDiskType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlFileType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlFlagType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlInstanceType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlIpAddressType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlPricingPlan
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlReplicationType
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlSuspensionReason
from google.cloud.sql_v1beta4.types.cloud_sql_resources import SqlUpdateTrack
from google.cloud.sql_v1beta4.types.cloud_sql_tiers import SqlTiersListRequest
from google.cloud.sql_v1beta4.types.cloud_sql_tiers import Tier
from google.cloud.sql_v1beta4.types.cloud_sql_tiers import TiersListResponse
from google.cloud.sql_v1beta4.types.cloud_sql_users import PasswordStatus
from google.cloud.sql_v1beta4.types.cloud_sql_users import SqlServerUserDetails
from google.cloud.sql_v1beta4.types.cloud_sql_users import SqlUsersDeleteRequest
from google.cloud.sql_v1beta4.types.cloud_sql_users import SqlUsersInsertRequest
from google.cloud.sql_v1beta4.types.cloud_sql_users import SqlUsersListRequest
from google.cloud.sql_v1beta4.types.cloud_sql_users import SqlUsersUpdateRequest
from google.cloud.sql_v1beta4.types.cloud_sql_users import User
from google.cloud.sql_v1beta4.types.cloud_sql_users import UserPasswordValidationPolicy
from google.cloud.sql_v1beta4.types.cloud_sql_users import UsersListResponse

__all__ = ('SqlBackupRunsServiceClient',
    'SqlBackupRunsServiceAsyncClient',
    'SqlConnectServiceClient',
    'SqlConnectServiceAsyncClient',
    'SqlDatabasesServiceClient',
    'SqlDatabasesServiceAsyncClient',
    'SqlFlagsServiceClient',
    'SqlFlagsServiceAsyncClient',
    'SqlInstancesServiceClient',
    'SqlInstancesServiceAsyncClient',
    'SqlOperationsServiceClient',
    'SqlOperationsServiceAsyncClient',
    'SqlSslCertsServiceClient',
    'SqlSslCertsServiceAsyncClient',
    'SqlTiersServiceClient',
    'SqlTiersServiceAsyncClient',
    'SqlUsersServiceClient',
    'SqlUsersServiceAsyncClient',
    'SqlBackupRunsDeleteRequest',
    'SqlBackupRunsGetRequest',
    'SqlBackupRunsInsertRequest',
    'SqlBackupRunsListRequest',
    'SqlDatabasesDeleteRequest',
    'SqlDatabasesGetRequest',
    'SqlDatabasesInsertRequest',
    'SqlDatabasesListRequest',
    'SqlDatabasesUpdateRequest',
    'SqlFlagsListRequest',
    'SqlInstancesAddServerCaRequest',
    'SqlInstancesCloneRequest',
    'SqlInstancesCreateEphemeralCertRequest',
    'SqlInstancesDeleteRequest',
    'SqlInstancesDemoteMasterRequest',
    'SqlInstancesExportRequest',
    'SqlInstancesFailoverRequest',
    'SqlInstancesGetRequest',
    'SqlInstancesImportRequest',
    'SqlInstancesInsertRequest',
    'SqlInstancesListRequest',
    'SqlInstancesListServerCasRequest',
    'SqlInstancesPatchRequest',
    'SqlInstancesPromoteReplicaRequest',
    'SqlInstancesRescheduleMaintenanceRequest',
    'SqlInstancesResetSslConfigRequest',
    'SqlInstancesRestartRequest',
    'SqlInstancesRestoreBackupRequest',
    'SqlInstancesRotateServerCaRequest',
    'SqlInstancesStartExternalSyncRequest',
    'SqlInstancesStartReplicaRequest',
    'SqlInstancesStopReplicaRequest',
    'SqlInstancesTruncateLogRequest',
    'SqlInstancesUpdateRequest',
    'SqlInstancesVerifyExternalSyncSettingsRequest',
    'SqlOperationsGetRequest',
    'SqlOperationsListRequest',
    'SqlSslCertsDeleteRequest',
    'SqlSslCertsGetRequest',
    'SqlSslCertsInsertRequest',
    'SqlSslCertsListRequest',
    'ConnectSettings',
    'GenerateEphemeralCertRequest',
    'GenerateEphemeralCertResponse',
    'GetConnectSettingsRequest',
    'AclEntry',
    'ApiWarning',
    'BackupConfiguration',
    'BackupContext',
    'BackupRetentionSettings',
    'BackupRun',
    'BackupRunsListResponse',
    'BinLogCoordinates',
    'CloneContext',
    'Database',
    'DatabaseFlags',
    'DatabaseInstance',
    'DatabasesListResponse',
    'DemoteMasterConfiguration',
    'DemoteMasterContext',
    'DemoteMasterMySqlReplicaConfiguration',
    'DenyMaintenancePeriod',
    'DiskEncryptionConfiguration',
    'DiskEncryptionStatus',
    'ExportContext',
    'FailoverContext',
    'Flag',
    'FlagsListResponse',
    'ImportContext',
    'InsightsConfig',
    'InstanceReference',
    'InstancesCloneRequest',
    'InstancesDemoteMasterRequest',
    'InstancesExportRequest',
    'InstancesFailoverRequest',
    'InstancesImportRequest',
    'InstancesListResponse',
    'InstancesListServerCasResponse',
    'InstancesRestoreBackupRequest',
    'InstancesRotateServerCaRequest',
    'InstancesTruncateLogRequest',
    'IpConfiguration',
    'IpMapping',
    'LocationPreference',
    'MaintenanceWindow',
    'MySqlReplicaConfiguration',
    'MySqlSyncConfig',
    'OnPremisesConfiguration',
    'Operation',
    'OperationError',
    'OperationErrors',
    'OperationsListResponse',
    'PasswordValidationPolicy',
    'ReplicaConfiguration',
    'RestoreBackupContext',
    'RotateServerCaContext',
    'Settings',
    'SqlActiveDirectoryConfig',
    'SqlExternalSyncSettingError',
    'SqlInstancesRescheduleMaintenanceRequestBody',
    'SqlInstancesVerifyExternalSyncSettingsResponse',
    'SqlServerAuditConfig',
    'SqlServerDatabaseDetails',
    'SslCert',
    'SslCertDetail',
    'SslCertsCreateEphemeralRequest',
    'SslCertsInsertRequest',
    'SslCertsInsertResponse',
    'SslCertsListResponse',
    'SyncFlags',
    'TruncateLogContext',
    'SqlAvailabilityType',
    'SqlBackendType',
    'SqlBackupKind',
    'SqlBackupRunStatus',
    'SqlBackupRunType',
    'SqlDatabaseVersion',
    'SqlDataDiskType',
    'SqlFileType',
    'SqlFlagType',
    'SqlInstanceType',
    'SqlIpAddressType',
    'SqlPricingPlan',
    'SqlReplicationType',
    'SqlSuspensionReason',
    'SqlUpdateTrack',
    'SqlTiersListRequest',
    'Tier',
    'TiersListResponse',
    'PasswordStatus',
    'SqlServerUserDetails',
    'SqlUsersDeleteRequest',
    'SqlUsersInsertRequest',
    'SqlUsersListRequest',
    'SqlUsersUpdateRequest',
    'User',
    'UserPasswordValidationPolicy',
    'UsersListResponse',
)
