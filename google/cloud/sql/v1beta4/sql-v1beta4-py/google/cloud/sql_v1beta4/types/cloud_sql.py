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

from google.cloud.sql_v1beta4.types import cloud_sql_resources


__protobuf__ = proto.module(
    package='google.cloud.sql.v1beta4',
    manifest={
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
        'SqlOperationsGetRequest',
        'SqlOperationsListRequest',
        'SqlInstancesCreateEphemeralCertRequest',
        'SqlSslCertsDeleteRequest',
        'SqlSslCertsGetRequest',
        'SqlSslCertsInsertRequest',
        'SqlSslCertsListRequest',
    },
)


class SqlBackupRunsDeleteRequest(proto.Message):
    r"""

    Attributes:
        id (int):
            The ID of the backup run to delete. To find a backup run ID,
            use the
            `list <https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1beta4/backupRuns/list>`__
            method.
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    id = proto.Field(
        proto.INT64,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlBackupRunsGetRequest(proto.Message):
    r"""

    Attributes:
        id (int):
            The ID of this backup run.
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    id = proto.Field(
        proto.INT64,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlBackupRunsInsertRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.BackupRun):

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
        message=cloud_sql_resources.BackupRun,
    )


class SqlBackupRunsListRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID, or "-" for all
            instances. This does not include the project ID.
        max_results (int):
            Maximum number of backup runs per response.
        page_token (str):
            A previously-returned page token representing
            part of the larger set of results to view.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    max_results = proto.Field(
        proto.INT32,
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


class SqlDatabasesDeleteRequest(proto.Message):
    r"""

    Attributes:
        database (str):
            Name of the database to be deleted in the
            instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    database = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlDatabasesGetRequest(proto.Message):
    r"""

    Attributes:
        database (str):
            Name of the database in the instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    database = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlDatabasesInsertRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.Database):

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
        message=cloud_sql_resources.Database,
    )


class SqlDatabasesListRequest(proto.Message):
    r"""

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


class SqlDatabasesUpdateRequest(proto.Message):
    r"""

    Attributes:
        database (str):
            Name of the database to be updated in the
            instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.Database):

    """

    database = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message=cloud_sql_resources.Database,
    )


class SqlFlagsListRequest(proto.Message):
    r"""

    Attributes:
        database_version (str):
            Database type and version you want to
            retrieve flags for. By default, this method
            returns flags for all database types and
            versions.
    """

    database_version = proto.Field(
        proto.STRING,
        number=1,
    )


class SqlInstancesAddServerCaRequest(proto.Message):
    r"""

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
    r"""

    Attributes:
        instance (str):
            The ID of the Cloud SQL instance to be cloned
            (source). This does not include the project ID.
        project (str):
            Project ID of the source as well as the clone
            Cloud SQL instance.
        body (google.cloud.sql_v1beta4.types.InstancesCloneRequest):

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
        message=cloud_sql_resources.InstancesCloneRequest,
    )


class SqlInstancesDeleteRequest(proto.Message):
    r"""

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
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance name.
        project (str):
            ID of the project that contains the instance.
        body (google.cloud.sql_v1beta4.types.InstancesDemoteMasterRequest):

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
        message=cloud_sql_resources.InstancesDemoteMasterRequest,
    )


class SqlInstancesExportRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance to be exported.
        body (google.cloud.sql_v1beta4.types.InstancesExportRequest):

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
        message=cloud_sql_resources.InstancesExportRequest,
    )


class SqlInstancesFailoverRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            ID of the project that contains the read
            replica.
        body (google.cloud.sql_v1beta4.types.InstancesFailoverRequest):

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
        message=cloud_sql_resources.InstancesFailoverRequest,
    )


class SqlInstancesGetRequest(proto.Message):
    r"""

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
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.InstancesImportRequest):

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
        message=cloud_sql_resources.InstancesImportRequest,
    )


class SqlInstancesInsertRequest(proto.Message):
    r"""

    Attributes:
        project (str):
            Project ID of the project to which the newly
            created Cloud SQL instances should belong.
        body (google.cloud.sql_v1beta4.types.DatabaseInstance):

    """

    project = proto.Field(
        proto.STRING,
        number=1,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message=cloud_sql_resources.DatabaseInstance,
    )


class SqlInstancesListRequest(proto.Message):
    r"""

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
    r"""

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
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.DatabaseInstance):

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
        message=cloud_sql_resources.DatabaseInstance,
    )


class SqlInstancesPromoteReplicaRequest(proto.Message):
    r"""

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
    r"""

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
    r"""

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
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.InstancesRestoreBackupRequest):

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
        message=cloud_sql_resources.InstancesRestoreBackupRequest,
    )


class SqlInstancesRotateServerCaRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.InstancesRotateServerCaRequest):

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
        message=cloud_sql_resources.InstancesRotateServerCaRequest,
    )


class SqlInstancesStartReplicaRequest(proto.Message):
    r"""

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
    r"""

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
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the Cloud SQL project.
        body (google.cloud.sql_v1beta4.types.InstancesTruncateLogRequest):

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
        message=cloud_sql_resources.InstancesTruncateLogRequest,
    )


class SqlInstancesUpdateRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.DatabaseInstance):

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
        message=cloud_sql_resources.DatabaseInstance,
    )


class SqlInstancesRescheduleMaintenanceRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            ID of the project that contains the instance.
        body (google.cloud.sql_v1beta4.types.SqlInstancesRescheduleMaintenanceRequestBody):

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
        message=cloud_sql_resources.SqlInstancesRescheduleMaintenanceRequestBody,
    )


class SqlInstancesVerifyExternalSyncSettingsRequest(proto.Message):
    r"""

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        verify_connection_only (bool):
            Flag to enable verifying connection only
        sync_mode (google.cloud.sql_v1beta4.types.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode):
            External sync mode
        verify_replication_only (bool):
            Optional. Flag to verify settings required by
            replication setup only
        mysql_sync_config (google.cloud.sql_v1beta4.types.MySqlSyncConfig):
            Optional. MySQL-specific settings for start
            external sync.

            This field is a member of `oneof`_ ``sync_config``.
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
    r"""

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            ID of the project that contains the instance.
        sync_mode (google.cloud.sql_v1beta4.types.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode):
            External sync mode.
        skip_verification (bool):
            Whether to skip the verification step (VESS).
        mysql_sync_config (google.cloud.sql_v1beta4.types.MySqlSyncConfig):
            MySQL-specific settings for start external
            sync.

            This field is a member of `oneof`_ ``sync_config``.
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


class SqlOperationsGetRequest(proto.Message):
    r"""

    Attributes:
        operation (str):
            Instance operation ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    operation = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlOperationsListRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        max_results (int):
            Maximum number of operations per response.
        page_token (str):
            A previously-returned page token representing
            part of the larger set of results to view.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
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


class SqlInstancesCreateEphemeralCertRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the Cloud SQL project.
        body (google.cloud.sql_v1beta4.types.SslCertsCreateEphemeralRequest):

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
        message=cloud_sql_resources.SslCertsCreateEphemeralRequest,
    )


class SqlSslCertsDeleteRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        sha1_fingerprint (str):
            Sha1 FingerPrint.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    sha1_fingerprint = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlSslCertsGetRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        sha1_fingerprint (str):
            Sha1 FingerPrint.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    sha1_fingerprint = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlSslCertsInsertRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.SslCertsInsertRequest):

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
        message=cloud_sql_resources.SslCertsInsertRequest,
    )


class SqlSslCertsListRequest(proto.Message):
    r"""

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


__all__ = tuple(sorted(__protobuf__.manifest))
