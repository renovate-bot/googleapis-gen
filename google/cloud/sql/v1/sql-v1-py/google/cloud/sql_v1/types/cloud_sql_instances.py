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
import proto  # type: ignore

from google.cloud.sql_v1.types import cloud_sql_resources
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.sql.v1',
    manifest={
        'SqlInstanceType',
        'SqlSuspensionReason',
        'SqlInstancesAddServerCaRequest',
        'SqlInstancesCloneRequest',
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
        'SqlInstancesResetSslConfigRequest',
        'SqlInstancesRestartRequest',
        'SqlInstancesRestoreBackupRequest',
        'SqlInstancesRotateServerCaRequest',
        'SqlInstancesStartReplicaRequest',
        'SqlInstancesStopReplicaRequest',
        'SqlInstancesTruncateLogRequest',
        'SqlInstancesUpdateRequest',
        'SqlInstancesRescheduleMaintenanceRequest',
        'SqlInstancesVerifyExternalSyncSettingsRequest',
        'SqlInstancesStartExternalSyncRequest',
        'SqlInstancesCreateEphemeralCertRequest',
        'InstancesCloneRequest',
        'InstancesDemoteMasterRequest',
        'InstancesExportRequest',
        'InstancesFailoverRequest',
        'SslCertsCreateEphemeralRequest',
        'InstancesImportRequest',
        'InstancesListResponse',
        'InstancesListServerCasResponse',
        'InstancesRestoreBackupRequest',
        'InstancesRotateServerCaRequest',
        'InstancesTruncateLogRequest',
        'SqlInstancesVerifyExternalSyncSettingsResponse',
        'CloneContext',
        'BinLogCoordinates',
        'DatabaseInstance',
        'SqlInstancesRescheduleMaintenanceRequestBody',
        'DemoteMasterContext',
        'FailoverContext',
        'RestoreBackupContext',
        'RotateServerCaContext',
        'TruncateLogContext',
        'SqlExternalSyncSettingError',
        'OnPremisesConfiguration',
        'ReplicaConfiguration',
    },
)


class SqlInstanceType(proto.Enum):
    r""""""
    SQL_INSTANCE_TYPE_UNSPECIFIED = 0
    CLOUD_SQL_INSTANCE = 1
    ON_PREMISES_INSTANCE = 2
    READ_REPLICA_INSTANCE = 3


class SqlSuspensionReason(proto.Enum):
    r"""The suspension reason of the database instance if the state
    is SUSPENDED.
    """
    SQL_SUSPENSION_REASON_UNSPECIFIED = 0
    BILLING_ISSUE = 2
    LEGAL_ISSUE = 3
    OPERATIONAL_ISSUE = 4
    KMS_KEY_ISSUE = 5


class SqlInstancesAddServerCaRequest(proto.Message):
    r"""Instance add server CA request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesCloneRequest(proto.Message):
    r"""Instance clone request.

    Attributes:
        instance (str):
            The ID of the Cloud SQL instance to be cloned
            (source). This does not include the project ID.
        project (str):
            Project ID of the source as well as the clone
            Cloud SQL instance.
        body (google.cloud.sql_v1.types.InstancesCloneRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesCloneRequest',
    )


class SqlInstancesDeleteRequest(proto.Message):
    r"""Instance delete request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance to be deleted.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesDemoteMasterRequest(proto.Message):
    r"""Instance demote master request.

    Attributes:
        instance (str):
            Cloud SQL instance name.
        project (str):
            ID of the project that contains the instance.
        body (google.cloud.sql_v1.types.InstancesDemoteMasterRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesDemoteMasterRequest',
    )


class SqlInstancesExportRequest(proto.Message):
    r"""Instance export request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance to be exported.
        body (google.cloud.sql_v1.types.InstancesExportRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesExportRequest',
    )


class SqlInstancesFailoverRequest(proto.Message):
    r"""Instance failover request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            ID of the project that contains the read
            replica.
        body (google.cloud.sql_v1.types.InstancesFailoverRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesFailoverRequest',
    )


class SqlInstancesGetRequest(proto.Message):
    r"""Instance get request.

    Attributes:
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesImportRequest(proto.Message):
    r"""Instance import request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.InstancesImportRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesImportRequest',
    )


class SqlInstancesInsertRequest(proto.Message):
    r"""Instance insert request.

    Attributes:
        project (str):
            Project ID of the project to which the newly
            created Cloud SQL instances should belong.
        body (google.cloud.sql_v1.types.DatabaseInstance):

    """

    project = proto.Field(
        proto.STRING,
        number=1,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='DatabaseInstance',
    )


class SqlInstancesListRequest(proto.Message):
    r"""Instance list request.

    Attributes:
        filter (str):
            A filter expression that filters resources listed in the
            response. The expression is in the form of field:value. For
            example, 'instanceType:CLOUD_SQL_INSTANCE'. Fields can be
            nested as needed as per their JSON representation, such as
            'settings.userLabels.auto_start:true'.

            Multiple filter queries are space-separated. For example.
            'state:RUNNABLE instanceType:CLOUD_SQL_INSTANCE'. By
            default, each expression is an AND expression. However, you
            can include AND and OR expressions explicitly.
        max_results (int):
            The maximum number of results to return per
            response.
        page_token (str):
            A previously-returned page token representing
            part of the larger set of results to view.
        project (str):
            Project ID of the project for which to list
            Cloud SQL instances.
    """

    filter = proto.Field(
        proto.STRING,
        number=1,
    )
    max_results = proto.Field(
        proto.UINT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    project = proto.Field(
        proto.STRING,
        number=4,
    )


class SqlInstancesListServerCasRequest(proto.Message):
    r"""Instance list server CAs request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesPatchRequest(proto.Message):
    r"""Instance patch request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.DatabaseInstance):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='DatabaseInstance',
    )


class SqlInstancesPromoteReplicaRequest(proto.Message):
    r"""Instance promote replica request.

    Attributes:
        instance (str):
            Cloud SQL read replica instance name.
        project (str):
            ID of the project that contains the read
            replica.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesResetSslConfigRequest(proto.Message):
    r"""Instance reset SSL config request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesRestartRequest(proto.Message):
    r"""Instance restart request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance to be restarted.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesRestoreBackupRequest(proto.Message):
    r"""Instance restore backup request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.InstancesRestoreBackupRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesRestoreBackupRequest',
    )


class SqlInstancesRotateServerCaRequest(proto.Message):
    r"""Instance rotate server CA request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.InstancesRotateServerCaRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesRotateServerCaRequest',
    )


class SqlInstancesStartReplicaRequest(proto.Message):
    r"""Instance start replica request.

    Attributes:
        instance (str):
            Cloud SQL read replica instance name.
        project (str):
            ID of the project that contains the read
            replica.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesStopReplicaRequest(proto.Message):
    r"""Instance stop replica request.

    Attributes:
        instance (str):
            Cloud SQL read replica instance name.
        project (str):
            ID of the project that contains the read
            replica.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlInstancesTruncateLogRequest(proto.Message):
    r"""Instance truncate log request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the Cloud SQL project.
        body (google.cloud.sql_v1.types.InstancesTruncateLogRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='InstancesTruncateLogRequest',
    )


class SqlInstancesUpdateRequest(proto.Message):
    r"""Instance update request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.DatabaseInstance):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='DatabaseInstance',
    )


class SqlInstancesRescheduleMaintenanceRequest(proto.Message):
    r"""Instance reschedule maintenance request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            ID of the project that contains the instance.
        body (google.cloud.sql_v1.types.SqlInstancesRescheduleMaintenanceRequestBody):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='SqlInstancesRescheduleMaintenanceRequestBody',
    )


class SqlInstancesVerifyExternalSyncSettingsRequest(proto.Message):
    r"""Instance verify external sync settings request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        verify_connection_only (bool):
            Flag to enable verifying connection only
        sync_mode (google.cloud.sql_v1.types.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode):
            External sync mode
        verify_replication_only (bool):
            Optional. Flag to verify settings required by
            replication setup only
        mysql_sync_config (google.cloud.sql_v1.types.MySqlSyncConfig):
            Optional. MySQL-specific settings for start
            external sync.
    """
    class ExternalSyncMode(proto.Enum):
        r""""""
        EXTERNAL_SYNC_MODE_UNSPECIFIED = 0
        ONLINE = 1
        OFFLINE = 2

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    verify_connection_only = proto.Field(
        proto.BOOL,
        number=3,
    )
    sync_mode = proto.Field(
        proto.ENUM,
        number=4,
        enum=ExternalSyncMode,
    )
    verify_replication_only = proto.Field(
        proto.BOOL,
        number=5,
    )
    mysql_sync_config = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='sync_config',
        message=cloud_sql_resources.MySqlSyncConfig,
    )


class SqlInstancesStartExternalSyncRequest(proto.Message):
    r"""Instance start external sync request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            ID of the project that contains the instance.
        sync_mode (google.cloud.sql_v1.types.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode):
            External sync mode.
        skip_verification (bool):
            Whether to skip the verification step (VESS).
        mysql_sync_config (google.cloud.sql_v1.types.MySqlSyncConfig):
            MySQL-specific settings for start external
            sync.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    sync_mode = proto.Field(
        proto.ENUM,
        number=3,
        enum='SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode',
    )
    skip_verification = proto.Field(
        proto.BOOL,
        number=4,
    )
    mysql_sync_config = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='sync_config',
        message=cloud_sql_resources.MySqlSyncConfig,
    )


class SqlInstancesCreateEphemeralCertRequest(proto.Message):
    r"""Instance create ephemeral certificate request.

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the Cloud SQL project.
        body (google.cloud.sql_v1.types.SslCertsCreateEphemeralRequest):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='SslCertsCreateEphemeralRequest',
    )


class InstancesCloneRequest(proto.Message):
    r"""Database instance clone request.

    Attributes:
        clone_context (google.cloud.sql_v1.types.CloneContext):
            Contains details about the clone operation.
    """

    clone_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='CloneContext',
    )


class InstancesDemoteMasterRequest(proto.Message):
    r"""Database demote primary instance request.

    Attributes:
        demote_master_context (google.cloud.sql_v1.types.DemoteMasterContext):
            Contains details about the demoteMaster
            operation.
    """

    demote_master_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='DemoteMasterContext',
    )


class InstancesExportRequest(proto.Message):
    r"""Database instance export request.

    Attributes:
        export_context (google.cloud.sql_v1.types.ExportContext):
            Contains details about the export operation.
    """

    export_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message=cloud_sql_resources.ExportContext,
    )


class InstancesFailoverRequest(proto.Message):
    r"""Instance failover request.

    Attributes:
        failover_context (google.cloud.sql_v1.types.FailoverContext):
            Failover Context.
    """

    failover_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FailoverContext',
    )


class SslCertsCreateEphemeralRequest(proto.Message):
    r"""SslCerts create ephemeral certificate request.

    Attributes:
        public_key (str):
            PEM encoded public key to include in the
            signed certificate.
        access_token (str):
            Access token to include in the signed
            certificate.
    """

    public_key = proto.Field(
        proto.STRING,
        number=1,
    )
    access_token = proto.Field(
        proto.STRING,
        number=2,
    )


class InstancesImportRequest(proto.Message):
    r"""Database instance import request.

    Attributes:
        import_context (google.cloud.sql_v1.types.ImportContext):
            Contains details about the import operation.
    """

    import_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message=cloud_sql_resources.ImportContext,
    )


class InstancesListResponse(proto.Message):
    r"""Database instances list response.

    Attributes:
        kind (str):
            This is always **sql#instancesList**.
        warnings (Sequence[google.cloud.sql_v1.types.ApiWarning]):
            List of warnings that occurred while handling
            the request.
        items (Sequence[google.cloud.sql_v1.types.DatabaseInstance]):
            List of database instance resources.
        next_page_token (str):
            The continuation token, used to page through
            large result sets. Provide this value in a
            subsequent request to return the next page of
            results.
    """

    @property
    def raw_page(self):
        return self

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    warnings = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=cloud_sql_resources.ApiWarning,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='DatabaseInstance',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=4,
    )


class InstancesListServerCasResponse(proto.Message):
    r"""Instances ListServerCas response.

    Attributes:
        certs (Sequence[google.cloud.sql_v1.types.SslCert]):
            List of server CA certificates for the
            instance.
        active_version (str):

        kind (str):
            This is always **sql#instancesListServerCas**.
    """

    certs = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=cloud_sql_resources.SslCert,
    )
    active_version = proto.Field(
        proto.STRING,
        number=2,
    )
    kind = proto.Field(
        proto.STRING,
        number=3,
    )


class InstancesRestoreBackupRequest(proto.Message):
    r"""Database instance restore backup request.

    Attributes:
        restore_backup_context (google.cloud.sql_v1.types.RestoreBackupContext):
            Parameters required to perform the restore
            backup operation.
    """

    restore_backup_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='RestoreBackupContext',
    )


class InstancesRotateServerCaRequest(proto.Message):
    r"""Rotate server CA request.

    Attributes:
        rotate_server_ca_context (google.cloud.sql_v1.types.RotateServerCaContext):
            Contains details about the rotate server CA
            operation.
    """

    rotate_server_ca_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='RotateServerCaContext',
    )


class InstancesTruncateLogRequest(proto.Message):
    r"""Instance truncate log request.

    Attributes:
        truncate_log_context (google.cloud.sql_v1.types.TruncateLogContext):
            Contains details about the truncate log
            operation.
    """

    truncate_log_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='TruncateLogContext',
    )


class SqlInstancesVerifyExternalSyncSettingsResponse(proto.Message):
    r"""Instance verify external sync settings response.

    Attributes:
        kind (str):
            This is always **sql#migrationSettingErrorList**.
        errors (Sequence[google.cloud.sql_v1.types.SqlExternalSyncSettingError]):
            List of migration violations.
        warnings (Sequence[google.cloud.sql_v1.types.SqlExternalSyncSettingError]):
            List of migration warnings.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    errors = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='SqlExternalSyncSettingError',
    )
    warnings = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='SqlExternalSyncSettingError',
    )


class CloneContext(proto.Message):
    r"""Database instance clone context.

    Attributes:
        kind (str):
            This is always **sql#cloneContext**.
        pitr_timestamp_ms (int):
            Reserved for future use.
        destination_instance_name (str):
            Name of the Cloud SQL instance to be created
            as a clone.
        bin_log_coordinates (google.cloud.sql_v1.types.BinLogCoordinates):
            Binary log coordinates, if specified,
            identify the position up to which the source
            instance is cloned. If not specified, the source
            instance is cloned up to the most recent binary
            log coordinates.
        point_in_time (google.protobuf.timestamp_pb2.Timestamp):
            Timestamp, if specified, identifies the time
            to which the source instance is cloned.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    pitr_timestamp_ms = proto.Field(
        proto.INT64,
        number=2,
    )
    destination_instance_name = proto.Field(
        proto.STRING,
        number=3,
    )
    bin_log_coordinates = proto.Field(
        proto.MESSAGE,
        number=4,
        message='BinLogCoordinates',
    )
    point_in_time = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )


class BinLogCoordinates(proto.Message):
    r"""Binary log coordinates.

    Attributes:
        bin_log_file_name (str):
            Name of the binary log file for a Cloud SQL
            instance.
        bin_log_position (int):
            Position (offset) within the binary log file.
        kind (str):
            This is always **sql#binLogCoordinates**.
    """

    bin_log_file_name = proto.Field(
        proto.STRING,
        number=1,
    )
    bin_log_position = proto.Field(
        proto.INT64,
        number=2,
    )
    kind = proto.Field(
        proto.STRING,
        number=3,
    )


class DatabaseInstance(proto.Message):
    r"""A Cloud SQL instance resource.

    Attributes:
        kind (str):
            This is always **sql#instance**.
        state (google.cloud.sql_v1.types.DatabaseInstance.SqlInstanceState):
            The current serving state of the Cloud SQL instance. This
            can be one of the following:

            -  **SQL_INSTANCE_STATE_UNSPECIFIED**: The state of the
               instance is unknown.
            -  **RUNNABLE**: The instance is running, or has been
               stopped by owner.
            -  **SUSPENDED**: The instance is not available, for example
               due to problems with billing.
            -  **PENDING_DELETE**: The instance is being deleted.
            -  **PENDING_CREATE**: The instance is being created.
            -  **MAINTENANCE**: The instance is down for maintenance.
            -  **FAILED**: The instance creation failed.
        database_version (google.cloud.sql_v1.types.SqlDatabaseVersion):
            The database engine type and version. The
            **databaseVersion** field cannot be changed after instance
            creation.

            -  **MySQL instances**: MYSQL_8_0, MYSQL_5_7 (default), or
               MYSQL_5_6.
            -  **PostgreSQL instances**: POSTGRES_9_6, POSTGRES_10,
               POSTGRES_11, POSTGRES_12, POSTGRES_13 (default).
            -  **SQL Server instances**: SQLSERVER_2019_STANDARD,
               SQLSERVER_2019_ENTERPRISE, SQLSERVER_2019_EXPRESS, or
               SQLSERVER_2019_WEB, SQLSERVER_2017_STANDARD (default),
               SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, or
               SQLSERVER_2017_WEB.
        settings (google.cloud.sql_v1.types.Settings):
            The user settings.
        etag (str):
            This field is deprecated and will be removed from a future
            version of the API. Use the **settings.settingsVersion**
            field instead.
        failover_replica (google.cloud.sql_v1.types.DatabaseInstance.SqlFailoverReplica):
            The name and status of the failover replica.
        master_instance_name (str):
            The name of the instance which will act as
            primary in the replication setup.
        replica_names (Sequence[str]):
            The replicas of the instance.
        max_disk_size (google.protobuf.wrappers_pb2.Int64Value):
            The maximum disk size of the instance in
            bytes.
        current_disk_size (google.protobuf.wrappers_pb2.Int64Value):
            The current disk usage of the instance in bytes. This
            property has been deprecated. Use the
            "cloudsql.googleapis.com/database/disk/bytes_used" metric in
            Cloud Monitoring API instead. Please see `this
            announcement <https://groups.google.com/d/msg/google-cloud-sql-announce/I_7-F9EBhT0/BtvFtdFeAgAJ>`__
            for details.
        ip_addresses (Sequence[google.cloud.sql_v1.types.IpMapping]):
            The assigned IP addresses for the instance.
        server_ca_cert (google.cloud.sql_v1.types.SslCert):
            SSL configuration.
        instance_type (google.cloud.sql_v1.types.SqlInstanceType):
            The instance type. This can be one of the following:

            -  **CLOUD_SQL_INSTANCE**: A Cloud SQL instance that is not
               replicating from a primary instance.
            -  **ON_PREMISES_INSTANCE**: An instance running on the
               customer's premises.
            -  **READ_REPLICA_INSTANCE**: A Cloud SQL instance
               configured as a read-replica.
        project (str):
            The project ID of the project containing the
            Cloud SQL instance. The Google apps domain is
            prefixed if applicable.
        ipv6_address (str):
            The IPv6 address assigned to the instance.
            (Deprecated) This property was applicable only
            to First Generation instances.
        service_account_email_address (str):
            The service account email address assigned to
            the instance. <br>This property is read-only.
        on_premises_configuration (google.cloud.sql_v1.types.OnPremisesConfiguration):
            Configuration specific to on-premises
            instances.
        replica_configuration (google.cloud.sql_v1.types.ReplicaConfiguration):
            Configuration specific to failover replicas
            and read replicas.
        backend_type (google.cloud.sql_v1.types.SqlBackendType):
            The backend type. **SECOND_GEN**: Cloud SQL database
            instance. **EXTERNAL**: A database server that is not
            managed by Google.

            This property is read-only; use the **tier** property in the
            **settings** object to determine the database type.
        self_link (str):
            The URI of this resource.
        suspension_reason (Sequence[google.cloud.sql_v1.types.SqlSuspensionReason]):
            If the instance state is SUSPENDED, the
            reason for the suspension.
        connection_name (str):
            Connection name of the Cloud SQL instance
            used in connection strings.
        name (str):
            Name of the Cloud SQL instance. This does not
            include the project ID.
        region (str):
            The geographical region. Can be:

            -  **us-central** (**FIRST_GEN** instances only)
            -  **us-central1** (**SECOND_GEN** instances only)
            -  **asia-east1** or **europe-west1**.

            Defaults to **us-central** or **us-central1** depending on
            the instance type. The region cannot be changed after
            instance creation.
        gce_zone (str):
            The Compute Engine zone that the instance is
            currently serving from. This value could be
            different from the zone that was specified when
            the instance was created if the instance has
            failed over to its secondary zone.
        secondary_gce_zone (str):
            The Compute Engine zone that the failover
            instance is currently serving from for a
            regional instance. This value could be different
            from the zone that was specified when the
            instance was created if the instance has failed
            over to its secondary/failover zone. Reserved
            for future use.
        disk_encryption_configuration (google.cloud.sql_v1.types.DiskEncryptionConfiguration):
            Disk encryption configuration specific to an
            instance.
        disk_encryption_status (google.cloud.sql_v1.types.DiskEncryptionStatus):
            Disk encryption status specific to an
            instance.
        root_password (str):
            Initial root password. Use only on creation.
        scheduled_maintenance (google.cloud.sql_v1.types.DatabaseInstance.SqlScheduledMaintenance):
            The start time of any upcoming scheduled
            maintenance for this instance.
        satisfies_pzs (google.protobuf.wrappers_pb2.BoolValue):
            The status indicating if instance
            satisfiesPzs. Reserved for future use.
        out_of_disk_report (google.cloud.sql_v1.types.DatabaseInstance.SqlOutOfDiskReport):
            This field represents the report generated by the proactive
            database wellness job for OutOfDisk issues.

            -  Writers:
            -  the proactive database wellness job for OOD.
            -  Readers:
            -  the proactive database wellness job
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time when the instance was created in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**.
    """
    class SqlInstanceState(proto.Enum):
        r"""The current serving state of the database instance."""
        SQL_INSTANCE_STATE_UNSPECIFIED = 0
        RUNNABLE = 1
        SUSPENDED = 2
        PENDING_DELETE = 3
        PENDING_CREATE = 4
        MAINTENANCE = 5
        FAILED = 6
        ONLINE_MAINTENANCE = 7

    class SqlFailoverReplica(proto.Message):
        r"""

        Attributes:
            name (str):
                The name of the failover replica. If
                specified at instance creation, a failover
                replica is created for the instance. The name
                doesn't include the project ID.
            available (google.protobuf.wrappers_pb2.BoolValue):
                The availability status of the failover
                replica. A false status indicates that the
                failover replica is out of sync. The primary
                instance can only failover to the failover
                replica when the status is true.
        """

        name = proto.Field(
            proto.STRING,
            number=1,
        )
        available = proto.Field(
            proto.MESSAGE,
            number=2,
            message=wrappers_pb2.BoolValue,
        )

    class SqlScheduledMaintenance(proto.Message):
        r"""Any scheduled maintenancce for this instance.

        Attributes:
            start_time (google.protobuf.timestamp_pb2.Timestamp):
                The start time of any upcoming scheduled
                maintenance for this instance.
            can_defer (bool):

            can_reschedule (bool):
                If the scheduled maintenance can be
                rescheduled.
            schedule_deadline_time (google.protobuf.timestamp_pb2.Timestamp):
                Maintenance cannot be rescheduled to start
                beyond this deadline.
        """

        start_time = proto.Field(
            proto.MESSAGE,
            number=1,
            message=timestamp_pb2.Timestamp,
        )
        can_defer = proto.Field(
            proto.BOOL,
            number=2,
        )
        can_reschedule = proto.Field(
            proto.BOOL,
            number=3,
        )
        schedule_deadline_time = proto.Field(
            proto.MESSAGE,
            number=4,
            optional=True,
            message=timestamp_pb2.Timestamp,
        )

    class SqlOutOfDiskReport(proto.Message):
        r"""This message wraps up the information written by out-of-disk
        detection job.

        Attributes:
            sql_out_of_disk_state (google.cloud.sql_v1.types.DatabaseInstance.SqlOutOfDiskReport.SqlOutOfDiskState):
                This field represents the state generated by the proactive
                database wellness job for OutOfDisk issues.

                -  Writers:
                -  the proactive database wellness job for OOD.
                -  Readers:
                -  the proactive database wellness job
            sql_min_recommended_increase_size_gb (int):
                The minimum recommended increase size in GigaBytes This
                field is consumed by the frontend

                -  Writers:
                -  the proactive database wellness job for OOD.
                -  Readers:
        """
        class SqlOutOfDiskState(proto.Enum):
            r"""This enum lists all possible states regarding out-of-disk
            issues.
            """
            SQL_OUT_OF_DISK_STATE_UNSPECIFIED = 0
            NORMAL = 1
            SOFT_SHUTDOWN = 2

        sql_out_of_disk_state = proto.Field(
            proto.ENUM,
            number=1,
            optional=True,
            enum='DatabaseInstance.SqlOutOfDiskReport.SqlOutOfDiskState',
        )
        sql_min_recommended_increase_size_gb = proto.Field(
            proto.INT32,
            number=2,
            optional=True,
        )

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    state = proto.Field(
        proto.ENUM,
        number=2,
        enum=SqlInstanceState,
    )
    database_version = proto.Field(
        proto.ENUM,
        number=3,
        enum=cloud_sql_resources.SqlDatabaseVersion,
    )
    settings = proto.Field(
        proto.MESSAGE,
        number=4,
        message=cloud_sql_resources.Settings,
    )
    etag = proto.Field(
        proto.STRING,
        number=5,
    )
    failover_replica = proto.Field(
        proto.MESSAGE,
        number=6,
        message=SqlFailoverReplica,
    )
    master_instance_name = proto.Field(
        proto.STRING,
        number=7,
    )
    replica_names = proto.RepeatedField(
        proto.STRING,
        number=8,
    )
    max_disk_size = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.Int64Value,
    )
    current_disk_size = proto.Field(
        proto.MESSAGE,
        number=10,
        message=wrappers_pb2.Int64Value,
    )
    ip_addresses = proto.RepeatedField(
        proto.MESSAGE,
        number=11,
        message=cloud_sql_resources.IpMapping,
    )
    server_ca_cert = proto.Field(
        proto.MESSAGE,
        number=12,
        message=cloud_sql_resources.SslCert,
    )
    instance_type = proto.Field(
        proto.ENUM,
        number=13,
        enum='SqlInstanceType',
    )
    project = proto.Field(
        proto.STRING,
        number=14,
    )
    ipv6_address = proto.Field(
        proto.STRING,
        number=15,
    )
    service_account_email_address = proto.Field(
        proto.STRING,
        number=16,
    )
    on_premises_configuration = proto.Field(
        proto.MESSAGE,
        number=17,
        message='OnPremisesConfiguration',
    )
    replica_configuration = proto.Field(
        proto.MESSAGE,
        number=18,
        message='ReplicaConfiguration',
    )
    backend_type = proto.Field(
        proto.ENUM,
        number=19,
        enum=cloud_sql_resources.SqlBackendType,
    )
    self_link = proto.Field(
        proto.STRING,
        number=20,
    )
    suspension_reason = proto.RepeatedField(
        proto.ENUM,
        number=21,
        enum='SqlSuspensionReason',
    )
    connection_name = proto.Field(
        proto.STRING,
        number=22,
    )
    name = proto.Field(
        proto.STRING,
        number=23,
    )
    region = proto.Field(
        proto.STRING,
        number=24,
    )
    gce_zone = proto.Field(
        proto.STRING,
        number=25,
    )
    secondary_gce_zone = proto.Field(
        proto.STRING,
        number=34,
    )
    disk_encryption_configuration = proto.Field(
        proto.MESSAGE,
        number=26,
        message=cloud_sql_resources.DiskEncryptionConfiguration,
    )
    disk_encryption_status = proto.Field(
        proto.MESSAGE,
        number=27,
        message=cloud_sql_resources.DiskEncryptionStatus,
    )
    root_password = proto.Field(
        proto.STRING,
        number=29,
    )
    scheduled_maintenance = proto.Field(
        proto.MESSAGE,
        number=30,
        message=SqlScheduledMaintenance,
    )
    satisfies_pzs = proto.Field(
        proto.MESSAGE,
        number=35,
        message=wrappers_pb2.BoolValue,
    )
    out_of_disk_report = proto.Field(
        proto.MESSAGE,
        number=38,
        optional=True,
        message=SqlOutOfDiskReport,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=39,
        message=timestamp_pb2.Timestamp,
    )


class SqlInstancesRescheduleMaintenanceRequestBody(proto.Message):
    r"""Reschedule options for maintenance windows.

    Attributes:
        reschedule (google.cloud.sql_v1.types.SqlInstancesRescheduleMaintenanceRequestBody.Reschedule):
            Required. The type of the reschedule the user
            wants.
    """
    class RescheduleType(proto.Enum):
        r""""""
        RESCHEDULE_TYPE_UNSPECIFIED = 0
        IMMEDIATE = 1
        NEXT_AVAILABLE_WINDOW = 2
        SPECIFIC_TIME = 3

    class Reschedule(proto.Message):
        r"""

        Attributes:
            reschedule_type (google.cloud.sql_v1.types.SqlInstancesRescheduleMaintenanceRequestBody.RescheduleType):
                Required. The type of the reschedule.
            schedule_time (google.protobuf.timestamp_pb2.Timestamp):
                Optional. Timestamp when the maintenance shall be
                rescheduled to if reschedule_type=SPECIFIC_TIME, in `RFC
                3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
                example **2012-11-15T16:19:00.094Z**.
        """

        reschedule_type = proto.Field(
            proto.ENUM,
            number=1,
            enum='SqlInstancesRescheduleMaintenanceRequestBody.RescheduleType',
        )
        schedule_time = proto.Field(
            proto.MESSAGE,
            number=2,
            message=timestamp_pb2.Timestamp,
        )

    reschedule = proto.Field(
        proto.MESSAGE,
        number=3,
        message=Reschedule,
    )


class DemoteMasterContext(proto.Message):
    r"""Database instance demote primary instance context.

    Attributes:
        kind (str):
            This is always **sql#demoteMasterContext**.
        verify_gtid_consistency (google.protobuf.wrappers_pb2.BoolValue):
            Verify GTID consistency for demote operation. Default value:
            **True**. Setting this flag to false enables you to bypass
            GTID consistency check between on-premises primary instance
            and Cloud SQL instance during the demotion operation but
            also exposes you to the risk of future replication failures.
            Change the value only if you know the reason for the GTID
            divergence and are confident that doing so will not cause
            any replication issues.
        master_instance_name (str):
            The name of the instance which will act as
            on-premises primary instance in the replication
            setup.
        replica_configuration (google.cloud.sql_v1.types.DemoteMasterConfiguration):
            Configuration specific to read-replicas
            replicating from the on-premises primary
            instance.
        skip_replication_setup (bool):
            Flag to skip replication setup on the
            instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    verify_gtid_consistency = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.BoolValue,
    )
    master_instance_name = proto.Field(
        proto.STRING,
        number=3,
    )
    replica_configuration = proto.Field(
        proto.MESSAGE,
        number=4,
        message=cloud_sql_resources.DemoteMasterConfiguration,
    )
    skip_replication_setup = proto.Field(
        proto.BOOL,
        number=5,
    )


class FailoverContext(proto.Message):
    r"""Database instance failover context.

    Attributes:
        settings_version (int):
            The current settings version of this
            instance. Request will be rejected if this
            version doesn't match the current settings
            version.
        kind (str):
            This is always **sql#failoverContext**.
    """

    settings_version = proto.Field(
        proto.INT64,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class RestoreBackupContext(proto.Message):
    r"""Database instance restore from backup context.
    Backup context contains source instance id and project id.

    Attributes:
        kind (str):
            This is always **sql#restoreBackupContext**.
        backup_run_id (int):
            The ID of the backup run to restore from.
        instance_id (str):
            The ID of the instance that the backup was
            taken from.
        project (str):
            The full project ID of the source instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    backup_run_id = proto.Field(
        proto.INT64,
        number=2,
    )
    instance_id = proto.Field(
        proto.STRING,
        number=3,
    )
    project = proto.Field(
        proto.STRING,
        number=4,
    )


class RotateServerCaContext(proto.Message):
    r"""Instance rotate server CA context.

    Attributes:
        kind (str):
            This is always **sql#rotateServerCaContext**.
        next_version (str):
            The fingerprint of the next version to be
            rotated to. If left unspecified, will be rotated
            to the most recently added server CA version.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    next_version = proto.Field(
        proto.STRING,
        number=2,
    )


class TruncateLogContext(proto.Message):
    r"""Database Instance truncate log context.

    Attributes:
        kind (str):
            This is always **sql#truncateLogContext**.
        log_type (str):
            The type of log to truncate. Valid values are
            **MYSQL_GENERAL_TABLE** and **MYSQL_SLOW_TABLE**.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    log_type = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlExternalSyncSettingError(proto.Message):
    r"""External primary instance migration setting error/warning.

    Attributes:
        kind (str):
            Can be **sql#externalSyncSettingError** or
            **sql#externalSyncSettingWarning**.
        type_ (google.cloud.sql_v1.types.SqlExternalSyncSettingError.SqlExternalSyncSettingErrorType):
            Identifies the specific error that occurred.
        detail (str):
            Additional information about the error
            encountered.
    """
    class SqlExternalSyncSettingErrorType(proto.Enum):
        r""""""
        SQL_EXTERNAL_SYNC_SETTING_ERROR_TYPE_UNSPECIFIED = 0
        CONNECTION_FAILURE = 1
        BINLOG_NOT_ENABLED = 2
        INCOMPATIBLE_DATABASE_VERSION = 3
        REPLICA_ALREADY_SETUP = 4
        INSUFFICIENT_PRIVILEGE = 5
        UNSUPPORTED_MIGRATION_TYPE = 6
        NO_PGLOGICAL_INSTALLED = 7
        PGLOGICAL_NODE_ALREADY_EXISTS = 8
        INVALID_WAL_LEVEL = 9
        INVALID_SHARED_PRELOAD_LIBRARY = 10
        INSUFFICIENT_MAX_REPLICATION_SLOTS = 11
        INSUFFICIENT_MAX_WAL_SENDERS = 12
        INSUFFICIENT_MAX_WORKER_PROCESSES = 13
        UNSUPPORTED_EXTENSIONS = 14
        INVALID_RDS_LOGICAL_REPLICATION = 15
        INVALID_LOGGING_SETUP = 16
        INVALID_DB_PARAM = 17
        UNSUPPORTED_GTID_MODE = 18
        SQLSERVER_AGENT_NOT_RUNNING = 19
        UNSUPPORTED_TABLE_DEFINITION = 20
        UNSUPPORTED_DEFINER = 21
        SQLSERVER_SERVERNAME_MISMATCH = 22
        PRIMARY_ALREADY_SETUP = 23
        UNSUPPORTED_BINLOG_FORMAT = 24
        BINLOG_RETENTION_SETTING = 25

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=2,
        enum=SqlExternalSyncSettingErrorType,
    )
    detail = proto.Field(
        proto.STRING,
        number=3,
    )


class OnPremisesConfiguration(proto.Message):
    r"""On-premises instance configuration.

    Attributes:
        host_port (str):
            The host and port of the on-premises instance
            in host:port format
        kind (str):
            This is always **sql#onPremisesConfiguration**.
        username (str):
            The username for connecting to on-premises
            instance.
        password (str):
            The password for connecting to on-premises
            instance.
        ca_certificate (str):
            PEM representation of the trusted CA's x509
            certificate.
        client_certificate (str):
            PEM representation of the replica's x509
            certificate.
        client_key (str):
            PEM representation of the replica's private
            key. The corresponsing public key is encoded in
            the client's certificate.
        dump_file_path (str):
            The dump file to create the Cloud SQL
            replica.
        source_instance (google.cloud.sql_v1.types.InstanceReference):
            The reference to Cloud SQL instance if the
            source is Cloud SQL.
    """

    host_port = proto.Field(
        proto.STRING,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )
    username = proto.Field(
        proto.STRING,
        number=3,
    )
    password = proto.Field(
        proto.STRING,
        number=4,
    )
    ca_certificate = proto.Field(
        proto.STRING,
        number=5,
    )
    client_certificate = proto.Field(
        proto.STRING,
        number=6,
    )
    client_key = proto.Field(
        proto.STRING,
        number=7,
    )
    dump_file_path = proto.Field(
        proto.STRING,
        number=8,
    )
    source_instance = proto.Field(
        proto.MESSAGE,
        number=15,
        message=cloud_sql_resources.InstanceReference,
    )


class ReplicaConfiguration(proto.Message):
    r"""Read-replica configuration for connecting to the primary
    instance.

    Attributes:
        kind (str):
            This is always **sql#replicaConfiguration**.
        mysql_replica_configuration (google.cloud.sql_v1.types.MySqlReplicaConfiguration):
            MySQL specific configuration when replicating from a MySQL
            on-premises primary instance. Replication configuration
            information such as the username, password, certificates,
            and keys are not stored in the instance metadata. The
            configuration information is used only to set up the
            replication connection and is stored by MySQL in a file
            named **master.info** in the data directory.
        failover_target (google.protobuf.wrappers_pb2.BoolValue):
            Specifies if the replica is the failover target. If the
            field is set to **true** the replica will be designated as a
            failover replica. In case the primary instance fails, the
            replica instance will be promoted as the new primary
            instance. Only one replica can be specified as failover
            target, and the replica has to be in different zone with the
            primary instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    mysql_replica_configuration = proto.Field(
        proto.MESSAGE,
        number=2,
        message=cloud_sql_resources.MySqlReplicaConfiguration,
    )
    failover_target = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers_pb2.BoolValue,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
