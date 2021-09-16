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

from google.cloud.sql_v1.services.sql_backup_runs_service.client import SqlBackupRunsServiceClient
from google.cloud.sql_v1.services.sql_backup_runs_service.async_client import SqlBackupRunsServiceAsyncClient
from google.cloud.sql_v1.services.sql_connect_service.client import SqlConnectServiceClient
from google.cloud.sql_v1.services.sql_connect_service.async_client import SqlConnectServiceAsyncClient
from google.cloud.sql_v1.services.sql_databases_service.client import SqlDatabasesServiceClient
from google.cloud.sql_v1.services.sql_databases_service.async_client import SqlDatabasesServiceAsyncClient
from google.cloud.sql_v1.services.sql_flags_service.client import SqlFlagsServiceClient
from google.cloud.sql_v1.services.sql_flags_service.async_client import SqlFlagsServiceAsyncClient
from google.cloud.sql_v1.services.sql_instance_names_service.client import SqlInstanceNamesServiceClient
from google.cloud.sql_v1.services.sql_instance_names_service.async_client import SqlInstanceNamesServiceAsyncClient
from google.cloud.sql_v1.services.sql_instances_service.client import SqlInstancesServiceClient
from google.cloud.sql_v1.services.sql_instances_service.async_client import SqlInstancesServiceAsyncClient
from google.cloud.sql_v1.services.sql_operations_service.client import SqlOperationsServiceClient
from google.cloud.sql_v1.services.sql_operations_service.async_client import SqlOperationsServiceAsyncClient
from google.cloud.sql_v1.services.sql_ssl_certs_service.client import SqlSslCertsServiceClient
from google.cloud.sql_v1.services.sql_ssl_certs_service.async_client import SqlSslCertsServiceAsyncClient
from google.cloud.sql_v1.services.sql_tiers_service.client import SqlTiersServiceClient
from google.cloud.sql_v1.services.sql_tiers_service.async_client import SqlTiersServiceAsyncClient
from google.cloud.sql_v1.services.sql_users_service.client import SqlUsersServiceClient
from google.cloud.sql_v1.services.sql_users_service.async_client import SqlUsersServiceAsyncClient

from google.cloud.sql_v1.types.cloud_sql_backup_runs import BackupRun
from google.cloud.sql_v1.types.cloud_sql_backup_runs import BackupRunsListResponse
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupRunsDeleteRequest
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupRunsGetRequest
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupRunsInsertRequest
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupRunsListRequest
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupKind
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupRunStatus
from google.cloud.sql_v1.types.cloud_sql_backup_runs import SqlBackupRunType
from google.cloud.sql_v1.types.cloud_sql_connect import ConnectSettings
from google.cloud.sql_v1.types.cloud_sql_connect import GenerateEphemeralCertRequest
from google.cloud.sql_v1.types.cloud_sql_connect import GenerateEphemeralCertResponse
from google.cloud.sql_v1.types.cloud_sql_connect import GetConnectSettingsRequest
from google.cloud.sql_v1.types.cloud_sql_databases import DatabasesListResponse
from google.cloud.sql_v1.types.cloud_sql_databases import SqlDatabasesDeleteRequest
from google.cloud.sql_v1.types.cloud_sql_databases import SqlDatabasesGetRequest
from google.cloud.sql_v1.types.cloud_sql_databases import SqlDatabasesInsertRequest
from google.cloud.sql_v1.types.cloud_sql_databases import SqlDatabasesListRequest
from google.cloud.sql_v1.types.cloud_sql_databases import SqlDatabasesUpdateRequest
from google.cloud.sql_v1.types.cloud_sql_flags import Flag
from google.cloud.sql_v1.types.cloud_sql_flags import FlagsListResponse
from google.cloud.sql_v1.types.cloud_sql_flags import SqlFlagsListRequest
from google.cloud.sql_v1.types.cloud_sql_flags import SqlFlagType
from google.cloud.sql_v1.types.cloud_sql_instances import BinLogCoordinates
from google.cloud.sql_v1.types.cloud_sql_instances import CloneContext
from google.cloud.sql_v1.types.cloud_sql_instances import DatabaseInstance
from google.cloud.sql_v1.types.cloud_sql_instances import DemoteMasterContext
from google.cloud.sql_v1.types.cloud_sql_instances import FailoverContext
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesCloneRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesDemoteMasterRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesExportRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesFailoverRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesImportRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesListResponse
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesListServerCasResponse
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesRestoreBackupRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesRotateServerCaRequest
from google.cloud.sql_v1.types.cloud_sql_instances import InstancesTruncateLogRequest
from google.cloud.sql_v1.types.cloud_sql_instances import OnPremisesConfiguration
from google.cloud.sql_v1.types.cloud_sql_instances import ReplicaConfiguration
from google.cloud.sql_v1.types.cloud_sql_instances import RestoreBackupContext
from google.cloud.sql_v1.types.cloud_sql_instances import RotateServerCaContext
from google.cloud.sql_v1.types.cloud_sql_instances import SqlExternalSyncSettingError
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesAddServerCaRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesCloneRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesCreateEphemeralCertRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesDeleteRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesDemoteMasterRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesExportRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesFailoverRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesGetRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesImportRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesInsertRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesListRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesListServerCasRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesPatchRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesPromoteReplicaRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesRescheduleMaintenanceRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesRescheduleMaintenanceRequestBody
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesResetSslConfigRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesRestartRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesRestoreBackupRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesRotateServerCaRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesStartExternalSyncRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesStartReplicaRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesStopReplicaRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesTruncateLogRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesUpdateRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesVerifyExternalSyncSettingsRequest
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstancesVerifyExternalSyncSettingsResponse
from google.cloud.sql_v1.types.cloud_sql_instances import SslCertsCreateEphemeralRequest
from google.cloud.sql_v1.types.cloud_sql_instances import TruncateLogContext
from google.cloud.sql_v1.types.cloud_sql_instances import SqlInstanceType
from google.cloud.sql_v1.types.cloud_sql_instances import SqlSuspensionReason
from google.cloud.sql_v1.types.cloud_sql_operations import OperationsListResponse
from google.cloud.sql_v1.types.cloud_sql_operations import SqlOperationsGetRequest
from google.cloud.sql_v1.types.cloud_sql_operations import SqlOperationsListRequest
from google.cloud.sql_v1.types.cloud_sql_resources import AclEntry
from google.cloud.sql_v1.types.cloud_sql_resources import ApiWarning
from google.cloud.sql_v1.types.cloud_sql_resources import BackupConfiguration
from google.cloud.sql_v1.types.cloud_sql_resources import BackupContext
from google.cloud.sql_v1.types.cloud_sql_resources import BackupRetentionSettings
from google.cloud.sql_v1.types.cloud_sql_resources import Database
from google.cloud.sql_v1.types.cloud_sql_resources import DatabaseFlags
from google.cloud.sql_v1.types.cloud_sql_resources import DemoteMasterConfiguration
from google.cloud.sql_v1.types.cloud_sql_resources import DemoteMasterMySqlReplicaConfiguration
from google.cloud.sql_v1.types.cloud_sql_resources import DenyMaintenancePeriod
from google.cloud.sql_v1.types.cloud_sql_resources import DiskEncryptionConfiguration
from google.cloud.sql_v1.types.cloud_sql_resources import DiskEncryptionStatus
from google.cloud.sql_v1.types.cloud_sql_resources import ExportContext
from google.cloud.sql_v1.types.cloud_sql_resources import ImportContext
from google.cloud.sql_v1.types.cloud_sql_resources import InsightsConfig
from google.cloud.sql_v1.types.cloud_sql_resources import InstanceReference
from google.cloud.sql_v1.types.cloud_sql_resources import IpConfiguration
from google.cloud.sql_v1.types.cloud_sql_resources import IpMapping
from google.cloud.sql_v1.types.cloud_sql_resources import LocationPreference
from google.cloud.sql_v1.types.cloud_sql_resources import MaintenanceWindow
from google.cloud.sql_v1.types.cloud_sql_resources import MySqlReplicaConfiguration
from google.cloud.sql_v1.types.cloud_sql_resources import MySqlSyncConfig
from google.cloud.sql_v1.types.cloud_sql_resources import Operation
from google.cloud.sql_v1.types.cloud_sql_resources import OperationError
from google.cloud.sql_v1.types.cloud_sql_resources import OperationErrors
from google.cloud.sql_v1.types.cloud_sql_resources import Settings
from google.cloud.sql_v1.types.cloud_sql_resources import SqlActiveDirectoryConfig
from google.cloud.sql_v1.types.cloud_sql_resources import SqlServerAuditConfig
from google.cloud.sql_v1.types.cloud_sql_resources import SqlServerDatabaseDetails
from google.cloud.sql_v1.types.cloud_sql_resources import SslCert
from google.cloud.sql_v1.types.cloud_sql_resources import SslCertDetail
from google.cloud.sql_v1.types.cloud_sql_resources import SyncFlags
from google.cloud.sql_v1.types.cloud_sql_resources import SqlAvailabilityType
from google.cloud.sql_v1.types.cloud_sql_resources import SqlBackendType
from google.cloud.sql_v1.types.cloud_sql_resources import SqlDatabaseVersion
from google.cloud.sql_v1.types.cloud_sql_resources import SqlDataDiskType
from google.cloud.sql_v1.types.cloud_sql_resources import SqlFileType
from google.cloud.sql_v1.types.cloud_sql_resources import SqlIpAddressType
from google.cloud.sql_v1.types.cloud_sql_resources import SqlPricingPlan
from google.cloud.sql_v1.types.cloud_sql_resources import SqlReplicationType
from google.cloud.sql_v1.types.cloud_sql_resources import SqlUpdateTrack
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SqlSslCertsDeleteRequest
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SqlSslCertsGetRequest
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SqlSslCertsInsertRequest
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SqlSslCertsListRequest
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SslCertsInsertRequest
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SslCertsInsertResponse
from google.cloud.sql_v1.types.cloud_sql_ssl_certs import SslCertsListResponse
from google.cloud.sql_v1.types.cloud_sql_tiers import SqlTiersListRequest
from google.cloud.sql_v1.types.cloud_sql_tiers import Tier
from google.cloud.sql_v1.types.cloud_sql_tiers import TiersListResponse
from google.cloud.sql_v1.types.cloud_sql_users import SqlServerUserDetails
from google.cloud.sql_v1.types.cloud_sql_users import SqlUsersDeleteRequest
from google.cloud.sql_v1.types.cloud_sql_users import SqlUsersInsertRequest
from google.cloud.sql_v1.types.cloud_sql_users import SqlUsersListRequest
from google.cloud.sql_v1.types.cloud_sql_users import SqlUsersUpdateRequest
from google.cloud.sql_v1.types.cloud_sql_users import User
from google.cloud.sql_v1.types.cloud_sql_users import UsersListResponse

__all__ = ('SqlBackupRunsServiceClient',
    'SqlBackupRunsServiceAsyncClient',
    'SqlConnectServiceClient',
    'SqlConnectServiceAsyncClient',
    'SqlDatabasesServiceClient',
    'SqlDatabasesServiceAsyncClient',
    'SqlFlagsServiceClient',
    'SqlFlagsServiceAsyncClient',
    'SqlInstanceNamesServiceClient',
    'SqlInstanceNamesServiceAsyncClient',
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
    'BackupRun',
    'BackupRunsListResponse',
    'SqlBackupRunsDeleteRequest',
    'SqlBackupRunsGetRequest',
    'SqlBackupRunsInsertRequest',
    'SqlBackupRunsListRequest',
    'SqlBackupKind',
    'SqlBackupRunStatus',
    'SqlBackupRunType',
    'ConnectSettings',
    'GenerateEphemeralCertRequest',
    'GenerateEphemeralCertResponse',
    'GetConnectSettingsRequest',
    'DatabasesListResponse',
    'SqlDatabasesDeleteRequest',
    'SqlDatabasesGetRequest',
    'SqlDatabasesInsertRequest',
    'SqlDatabasesListRequest',
    'SqlDatabasesUpdateRequest',
    'Flag',
    'FlagsListResponse',
    'SqlFlagsListRequest',
    'SqlFlagType',
    'BinLogCoordinates',
    'CloneContext',
    'DatabaseInstance',
    'DemoteMasterContext',
    'FailoverContext',
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
    'OnPremisesConfiguration',
    'ReplicaConfiguration',
    'RestoreBackupContext',
    'RotateServerCaContext',
    'SqlExternalSyncSettingError',
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
    'SqlInstancesRescheduleMaintenanceRequestBody',
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
    'SqlInstancesVerifyExternalSyncSettingsResponse',
    'SslCertsCreateEphemeralRequest',
    'TruncateLogContext',
    'SqlInstanceType',
    'SqlSuspensionReason',
    'OperationsListResponse',
    'SqlOperationsGetRequest',
    'SqlOperationsListRequest',
    'AclEntry',
    'ApiWarning',
    'BackupConfiguration',
    'BackupContext',
    'BackupRetentionSettings',
    'Database',
    'DatabaseFlags',
    'DemoteMasterConfiguration',
    'DemoteMasterMySqlReplicaConfiguration',
    'DenyMaintenancePeriod',
    'DiskEncryptionConfiguration',
    'DiskEncryptionStatus',
    'ExportContext',
    'ImportContext',
    'InsightsConfig',
    'InstanceReference',
    'IpConfiguration',
    'IpMapping',
    'LocationPreference',
    'MaintenanceWindow',
    'MySqlReplicaConfiguration',
    'MySqlSyncConfig',
    'Operation',
    'OperationError',
    'OperationErrors',
    'Settings',
    'SqlActiveDirectoryConfig',
    'SqlServerAuditConfig',
    'SqlServerDatabaseDetails',
    'SslCert',
    'SslCertDetail',
    'SyncFlags',
    'SqlAvailabilityType',
    'SqlBackendType',
    'SqlDatabaseVersion',
    'SqlDataDiskType',
    'SqlFileType',
    'SqlIpAddressType',
    'SqlPricingPlan',
    'SqlReplicationType',
    'SqlUpdateTrack',
    'SqlSslCertsDeleteRequest',
    'SqlSslCertsGetRequest',
    'SqlSslCertsInsertRequest',
    'SqlSslCertsListRequest',
    'SslCertsInsertRequest',
    'SslCertsInsertResponse',
    'SslCertsListResponse',
    'SqlTiersListRequest',
    'Tier',
    'TiersListResponse',
    'SqlServerUserDetails',
    'SqlUsersDeleteRequest',
    'SqlUsersInsertRequest',
    'SqlUsersListRequest',
    'SqlUsersUpdateRequest',
    'User',
    'UsersListResponse',
)
