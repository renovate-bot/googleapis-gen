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

from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.sql.v1beta4',
    manifest={
        'SqlFileType',
        'SqlBackupRunStatus',
        'SqlBackupRunType',
        'SqlBackupKind',
        'SqlBackendType',
        'SqlIpAddressType',
        'SqlInstanceType',
        'SqlDatabaseVersion',
        'SqlSuspensionReason',
        'SqlPricingPlan',
        'SqlReplicationType',
        'SqlDataDiskType',
        'SqlAvailabilityType',
        'SqlUpdateTrack',
        'SqlFlagType',
        'AclEntry',
        'ApiWarning',
        'BackupRetentionSettings',
        'BackupConfiguration',
        'BackupRun',
        'BackupRunsListResponse',
        'BinLogCoordinates',
        'BackupContext',
        'CloneContext',
        'Database',
        'SqlServerDatabaseDetails',
        'DatabaseFlags',
        'DatabaseInstance',
        'DatabasesListResponse',
        'DemoteMasterConfiguration',
        'DemoteMasterContext',
        'DemoteMasterMySqlReplicaConfiguration',
        'ExportContext',
        'FailoverContext',
        'Flag',
        'FlagsListResponse',
        'ImportContext',
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
        'SqlInstancesVerifyExternalSyncSettingsResponse',
        'SqlExternalSyncSettingError',
        'IpConfiguration',
        'IpMapping',
        'LocationPreference',
        'MaintenanceWindow',
        'DenyMaintenancePeriod',
        'InsightsConfig',
        'MySqlReplicaConfiguration',
        'OnPremisesConfiguration',
        'DiskEncryptionConfiguration',
        'DiskEncryptionStatus',
        'Operation',
        'OperationError',
        'OperationErrors',
        'OperationsListResponse',
        'ReplicaConfiguration',
        'RestoreBackupContext',
        'RotateServerCaContext',
        'Settings',
        'SslCert',
        'SslCertDetail',
        'SslCertsCreateEphemeralRequest',
        'SslCertsInsertRequest',
        'SqlInstancesRescheduleMaintenanceRequestBody',
        'SslCertsInsertResponse',
        'SslCertsListResponse',
        'TruncateLogContext',
        'SqlActiveDirectoryConfig',
    },
)


class SqlFileType(proto.Enum):
    r""""""
    SQL_FILE_TYPE_UNSPECIFIED = 0
    SQL = 1
    CSV = 2
    BAK = 4


class SqlBackupRunStatus(proto.Enum):
    r"""The status of a backup run."""
    SQL_BACKUP_RUN_STATUS_UNSPECIFIED = 0
    ENQUEUED = 1
    OVERDUE = 2
    RUNNING = 3
    FAILED = 4
    SUCCESSFUL = 5
    SKIPPED = 6
    DELETION_PENDING = 7
    DELETION_FAILED = 8
    DELETED = 9


class SqlBackupRunType(proto.Enum):
    r""""""
    SQL_BACKUP_RUN_TYPE_UNSPECIFIED = 0
    AUTOMATED = 1
    ON_DEMAND = 2


class SqlBackupKind(proto.Enum):
    r"""Defines the supported backup kinds"""
    SQL_BACKUP_KIND_UNSPECIFIED = 0
    SNAPSHOT = 1
    PHYSICAL = 2


class SqlBackendType(proto.Enum):
    r""""""
    SQL_BACKEND_TYPE_UNSPECIFIED = 0
    FIRST_GEN = 1
    SECOND_GEN = 2
    EXTERNAL = 3


class SqlIpAddressType(proto.Enum):
    r""""""
    SQL_IP_ADDRESS_TYPE_UNSPECIFIED = 0
    PRIMARY = 1
    OUTGOING = 2
    PRIVATE = 3
    MIGRATED_1ST_GEN = 4


class SqlInstanceType(proto.Enum):
    r""""""
    SQL_INSTANCE_TYPE_UNSPECIFIED = 0
    CLOUD_SQL_INSTANCE = 1
    ON_PREMISES_INSTANCE = 2
    READ_REPLICA_INSTANCE = 3


class SqlDatabaseVersion(proto.Enum):
    r"""The database engine type and version."""
    SQL_DATABASE_VERSION_UNSPECIFIED = 0
    MYSQL_5_1 = 2
    MYSQL_5_5 = 3
    MYSQL_5_6 = 5
    MYSQL_5_7 = 6
    POSTGRES_9_6 = 9
    POSTGRES_11 = 10
    SQLSERVER_2017_STANDARD = 11
    SQLSERVER_2017_ENTERPRISE = 14
    SQLSERVER_2017_EXPRESS = 15
    SQLSERVER_2017_WEB = 16
    POSTGRES_10 = 18
    POSTGRES_12 = 19
    MYSQL_8_0 = 20
    POSTGRES_13 = 23


class SqlSuspensionReason(proto.Enum):
    r"""The suspension reason of the database instance if the state
    is SUSPENDED.
    """
    SQL_SUSPENSION_REASON_UNSPECIFIED = 0
    BILLING_ISSUE = 2
    LEGAL_ISSUE = 3
    OPERATIONAL_ISSUE = 4
    KMS_KEY_ISSUE = 5


class SqlPricingPlan(proto.Enum):
    r"""The pricing plan for this instance."""
    SQL_PRICING_PLAN_UNSPECIFIED = 0
    PACKAGE = 1
    PER_USE = 2


class SqlReplicationType(proto.Enum):
    r""""""
    SQL_REPLICATION_TYPE_UNSPECIFIED = 0
    SYNCHRONOUS = 1
    ASYNCHRONOUS = 2


class SqlDataDiskType(proto.Enum):
    r"""The type of disk that is used for a v2 instance to use."""
    SQL_DATA_DISK_TYPE_UNSPECIFIED = 0
    PD_SSD = 1
    PD_HDD = 2
    OBSOLETE_LOCAL_SSD = 3


class SqlAvailabilityType(proto.Enum):
    r"""The availability type of the given Cloud SQL instance."""
    SQL_AVAILABILITY_TYPE_UNSPECIFIED = 0
    ZONAL = 1
    REGIONAL = 2


class SqlUpdateTrack(proto.Enum):
    r""""""
    SQL_UPDATE_TRACK_UNSPECIFIED = 0
    canary = 1
    stable = 2


class SqlFlagType(proto.Enum):
    r"""LINT.IfChange(sql_flag_type)"""
    SQL_FLAG_TYPE_UNSPECIFIED = 0
    BOOLEAN = 1
    STRING = 2
    INTEGER = 3
    NONE = 4
    MYSQL_TIMEZONE_OFFSET = 5
    FLOAT = 6
    REPEATED_STRING = 7


class AclEntry(proto.Message):
    r"""An entry for an Access Control list.
    Attributes:
        value (str):
            The allowlisted value for the access control
            list.
        expiration_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when this access control entry
            expires in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        name (str):
            Optional. A label to identify this entry.
        kind (str):
            This is always <b>sql#aclEntry</b>.
    """

    value = proto.Field(
        proto.STRING,
        number=1,
    )
    expiration_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    kind = proto.Field(
        proto.STRING,
        number=4,
    )


class ApiWarning(proto.Message):
    r"""An Admin API warning message.
    Attributes:
        code (google.cloud.sql_v1beta4.types.ApiWarning.SqlApiWarningCode):
            Code to uniquely identify the warning type.
        message (str):
            The warning message.
        region (str):
            The region name for REGION_UNREACHABLE warning.
    """
    class SqlApiWarningCode(proto.Enum):
        r""""""
        SQL_API_WARNING_CODE_UNSPECIFIED = 0
        REGION_UNREACHABLE = 1

    code = proto.Field(
        proto.ENUM,
        number=1,
        enum=SqlApiWarningCode,
    )
    message = proto.Field(
        proto.STRING,
        number=2,
    )
    region = proto.Field(
        proto.STRING,
        number=3,
    )


class BackupRetentionSettings(proto.Message):
    r"""We currently only support backup retention by specifying the
    number of backups we will retain.

    Attributes:
        retention_unit (google.cloud.sql_v1beta4.types.BackupRetentionSettings.RetentionUnit):
            The unit that 'retained_backups' represents.
        retained_backups (google.protobuf.wrappers_pb2.Int32Value):
            Depending on the value of retention_unit, this is used to
            determine if a backup needs to be deleted. If retention_unit
            is 'COUNT', we will retain this many backups.
    """
    class RetentionUnit(proto.Enum):
        r"""The units that retained_backups specifies, we only support COUNT."""
        RETENTION_UNIT_UNSPECIFIED = 0
        COUNT = 1

    retention_unit = proto.Field(
        proto.ENUM,
        number=1,
        enum=RetentionUnit,
    )
    retained_backups = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.Int32Value,
    )


class BackupConfiguration(proto.Message):
    r"""Database instance backup configuration.
    Attributes:
        start_time (str):
            Start time for the daily backup configuration
            in UTC timezone in the 24 hour format -
            <b>HH:MM</b>.
        enabled (google.protobuf.wrappers_pb2.BoolValue):
            Whether this configuration is enabled.
        kind (str):
            This is always
            <b>sql#backupConfiguration</b>.
        binary_log_enabled (google.protobuf.wrappers_pb2.BoolValue):
            (MySQL only) Whether binary log is enabled.
            If backup configuration is disabled, binarylog
            must be disabled as well.
        replication_log_archiving_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Reserved for future use.
        location (str):
            Location of the backup
        point_in_time_recovery_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Reserved for future use.
        transaction_log_retention_days (google.protobuf.wrappers_pb2.Int32Value):
            The number of days of transaction logs we
            retain for point in time restore, from 1-7.
        backup_retention_settings (google.cloud.sql_v1beta4.types.BackupRetentionSettings):
            Backup retention settings.
    """

    start_time = proto.Field(
        proto.STRING,
        number=1,
    )
    enabled = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.BoolValue,
    )
    kind = proto.Field(
        proto.STRING,
        number=3,
    )
    binary_log_enabled = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers_pb2.BoolValue,
    )
    replication_log_archiving_enabled = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.BoolValue,
    )
    location = proto.Field(
        proto.STRING,
        number=6,
    )
    point_in_time_recovery_enabled = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers_pb2.BoolValue,
    )
    transaction_log_retention_days = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.Int32Value,
    )
    backup_retention_settings = proto.Field(
        proto.MESSAGE,
        number=10,
        message='BackupRetentionSettings',
    )


class BackupRun(proto.Message):
    r"""A BackupRun resource.
    Attributes:
        kind (str):
            This is always <b>sql#backupRun</b>.
        status (google.cloud.sql_v1beta4.types.SqlBackupRunStatus):
            The status of this run.
        enqueued_time (google.protobuf.timestamp_pb2.Timestamp):
            The time the run was enqueued in UTC timezone
            in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        id (int):
            The identifier for this backup run. Unique
            only for a specific Cloud SQL instance.
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            The time the backup operation actually
            started in UTC timezone in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            The time the backup operation completed in
            UTC timezone in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        error (google.cloud.sql_v1beta4.types.OperationError):
            Information about why the backup operation
            failed. This is only present if the run has the
            FAILED status.
        type_ (google.cloud.sql_v1beta4.types.SqlBackupRunType):
            The type of this run; can be either "AUTOMATED" or
            "ON_DEMAND". This field defaults to "ON_DEMAND" and is
            ignored, when specified for insert requests.
        description (str):
            The description of this run, only applicable
            to on-demand backups.
        window_start_time (google.protobuf.timestamp_pb2.Timestamp):
            The start time of the backup window during
            which this the backup was attempted in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        instance (str):
            Name of the database instance.
        self_link (str):
            The URI of this resource.
        location (str):
            Location of the backups.
        disk_encryption_configuration (google.cloud.sql_v1beta4.types.DiskEncryptionConfiguration):
            Encryption configuration specific to a
            backup. Applies only to Second Generation
            instances.
        disk_encryption_status (google.cloud.sql_v1beta4.types.DiskEncryptionStatus):
            Encryption status specific to a backup.
            Applies only to Second Generation instances.
        backup_kind (google.cloud.sql_v1beta4.types.SqlBackupKind):
            Specifies the kind of backup, PHYSICAL or DEFAULT_SNAPSHOT.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    status = proto.Field(
        proto.ENUM,
        number=2,
        enum='SqlBackupRunStatus',
    )
    enqueued_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp_pb2.Timestamp,
    )
    id = proto.Field(
        proto.INT64,
        number=4,
    )
    start_time = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    error = proto.Field(
        proto.MESSAGE,
        number=7,
        message='OperationError',
    )
    type_ = proto.Field(
        proto.ENUM,
        number=8,
        enum='SqlBackupRunType',
    )
    description = proto.Field(
        proto.STRING,
        number=9,
    )
    window_start_time = proto.Field(
        proto.MESSAGE,
        number=10,
        message=timestamp_pb2.Timestamp,
    )
    instance = proto.Field(
        proto.STRING,
        number=11,
    )
    self_link = proto.Field(
        proto.STRING,
        number=12,
    )
    location = proto.Field(
        proto.STRING,
        number=13,
    )
    disk_encryption_configuration = proto.Field(
        proto.MESSAGE,
        number=16,
        message='DiskEncryptionConfiguration',
    )
    disk_encryption_status = proto.Field(
        proto.MESSAGE,
        number=17,
        message='DiskEncryptionStatus',
    )
    backup_kind = proto.Field(
        proto.ENUM,
        number=19,
        enum='SqlBackupKind',
    )


class BackupRunsListResponse(proto.Message):
    r"""Backup run list results.
    Attributes:
        kind (str):
            This is always <b>sql#backupRunsList</b>.
        items (Sequence[google.cloud.sql_v1beta4.types.BackupRun]):
            A list of backup runs in reverse
            chronological order of the enqueued time.
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
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='BackupRun',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=3,
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
            This is always <b>sql#binLogCoordinates</b>.
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


class BackupContext(proto.Message):
    r"""Backup context.
    Attributes:
        backup_id (int):
            The identifier of the backup.
        kind (str):
            This is always <b>sql#backupContext</b>.
    """

    backup_id = proto.Field(
        proto.INT64,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class CloneContext(proto.Message):
    r"""Database instance clone context.
    Attributes:
        kind (str):
            This is always <b>sql#cloneContext</b>.
        pitr_timestamp_ms (int):
            Reserved for future use.
        destination_instance_name (str):
            Name of the Cloud SQL instance to be created
            as a clone.
        bin_log_coordinates (google.cloud.sql_v1beta4.types.BinLogCoordinates):
            Binary log coordinates, if specified,
            identify the position up to which the source
            instance is cloned. If not specified, the source
            instance is cloned up to the most recent binary
            log coordinates.
        point_in_time (google.protobuf.timestamp_pb2.Timestamp):
            Reserved for future use.
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


class Database(proto.Message):
    r"""Represents a SQL database on the Cloud SQL instance.
    Attributes:
        kind (str):
            This is always <b>sql#database</b>.
        charset (str):
            The Cloud SQL charset value.
        collation (str):
            The Cloud SQL collation value.
        etag (str):
            This field is deprecated and will be removed
            from a future version of the API.
        name (str):
            The name of the database in the Cloud SQL
            instance. This does not include the project ID
            or instance name.
        instance (str):
            The name of the Cloud SQL instance. This does
            not include the project ID.
        self_link (str):
            The URI of this resource.
        project (str):
            The project ID of the project containing the
            Cloud SQL database. The Google apps domain is
            prefixed if applicable.
        sqlserver_database_details (google.cloud.sql_v1beta4.types.SqlServerDatabaseDetails):

    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    charset = proto.Field(
        proto.STRING,
        number=2,
    )
    collation = proto.Field(
        proto.STRING,
        number=3,
    )
    etag = proto.Field(
        proto.STRING,
        number=4,
    )
    name = proto.Field(
        proto.STRING,
        number=5,
    )
    instance = proto.Field(
        proto.STRING,
        number=6,
    )
    self_link = proto.Field(
        proto.STRING,
        number=7,
    )
    project = proto.Field(
        proto.STRING,
        number=8,
    )
    sqlserver_database_details = proto.Field(
        proto.MESSAGE,
        number=9,
        oneof='database_details',
        message='SqlServerDatabaseDetails',
    )


class SqlServerDatabaseDetails(proto.Message):
    r"""Represents a Sql Server database on the Cloud SQL instance.
    Attributes:
        compatibility_level (int):
            The version of SQL Server with which the
            database is to be made compatible
        recovery_model (str):
            The recovery model of a SQL Server database
    """

    compatibility_level = proto.Field(
        proto.INT32,
        number=1,
    )
    recovery_model = proto.Field(
        proto.STRING,
        number=2,
    )


class DatabaseFlags(proto.Message):
    r"""Database flags for Cloud SQL instances.
    Attributes:
        name (str):
            The name of the flag. These flags are passed
            at instance startup, so include both server
            options and system variables for MySQL. Flags
            are specified with underscores, not hyphens. For
            more information, see <a
            href="/sql/docs/mysql/flags">Configuring
            Database Flags</a> in the Cloud SQL
            documentation.
        value (str):
            The value of the flag. Booleans are set to
            <b>on</b> for true and <b>off</b> for false.
            This field must be omitted if the flag doesn't
            take a value.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    value = proto.Field(
        proto.STRING,
        number=2,
    )


class DatabaseInstance(proto.Message):
    r"""A Cloud SQL instance resource.
    Attributes:
        kind (str):
            This is always <b>sql#instance</b>.
        state (google.cloud.sql_v1beta4.types.DatabaseInstance.SqlInstanceState):
            The current serving state of the Cloud SQL instance. This
            can be one of the following. SQL_INSTANCE_STATE_UNSPECIFIED:
            The state of the instance is unknown. RUNNABLE: The instance
            is running, or has been stopped by owner. SUSPENDED: The
            instance is not available, for example due to problems with
            billing. PENDING_DELETE: The instance is being deleted.
            PENDING_CREATE: The instance is being created. MAINTENANCE:
            The instance is down for maintenance. FAILED: The instance
            creation failed.
        database_version (google.cloud.sql_v1beta4.types.SqlDatabaseVersion):
            The database engine type and version. The databaseVersion
            field cannot be changed after instance creation. MySQL
            instances: MYSQL_8_0, MYSQL_5_7 (default), or MYSQL_5_6.
            PostgreSQL instances: POSTGRES_9_6, POSTGRES_10,
            POSTGRES_11, POSTGRES_12, or POSTGRES_13 (default). SQL
            Server instances: SQLSERVER_2017_STANDARD (default),
            SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, or
            SQLSERVER_2017_WEB.
        settings (google.cloud.sql_v1beta4.types.Settings):
            The user settings.
        etag (str):
            This field is deprecated and will be removed
            from a future version of the API. Use the
            <b>settings.settingsVersion</b> field instead.
        failover_replica (google.cloud.sql_v1beta4.types.DatabaseInstance.SqlFailoverReplica):
            The name and status of the failover replica.
            This property is applicable only to Second
            Generation instances.
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
            Cloud Monitoring API instead. Please see this announcement
            for details.
        ip_addresses (Sequence[google.cloud.sql_v1beta4.types.IpMapping]):
            The assigned IP addresses for the instance.
        server_ca_cert (google.cloud.sql_v1beta4.types.SslCert):
            SSL configuration.
        instance_type (google.cloud.sql_v1beta4.types.SqlInstanceType):
            The instance type. This can be one of the following.
            CLOUD_SQL_INSTANCE: A Cloud SQL instance that is not
            replicating from a primary instance. ON_PREMISES_INSTANCE:
            An instance running on the customer's premises.
            READ_REPLICA_INSTANCE: A Cloud SQL instance configured as a
            read-replica.
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
        on_premises_configuration (google.cloud.sql_v1beta4.types.OnPremisesConfiguration):
            Configuration specific to on-premises
            instances.
        replica_configuration (google.cloud.sql_v1beta4.types.ReplicaConfiguration):
            Configuration specific to failover replicas
            and read replicas.
        backend_type (google.cloud.sql_v1beta4.types.SqlBackendType):
            SECOND_GEN: Cloud SQL database instance. EXTERNAL: A
            database server that is not managed by Google. This property
            is read-only; use the tier property in the settings object
            to determine the database type.
        self_link (str):
            The URI of this resource.
        suspension_reason (Sequence[google.cloud.sql_v1beta4.types.SqlSuspensionReason]):
            If the instance state is SUSPENDED, the
            reason for the suspension.
        connection_name (str):
            Connection name of the Cloud SQL instance
            used in connection strings.
        name (str):
            Name of the Cloud SQL instance. This does not
            include the project ID.
        region (str):
            The geographical region. Can be us-central (FIRST_GEN
            instances only) us-central1 (SECOND_GEN instances only)
            asia-east1 or europe-west1. Defaults to us-central or
            us-central1 depending on the instance type. The region
            cannot be changed after instance creation.
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
        disk_encryption_configuration (google.cloud.sql_v1beta4.types.DiskEncryptionConfiguration):
            Disk encryption configuration specific to an
            instance. Applies only to Second Generation
            instances.
        disk_encryption_status (google.cloud.sql_v1beta4.types.DiskEncryptionStatus):
            Disk encryption status specific to an
            instance. Applies only to Second Generation
            instances.
        root_password (str):
            Initial root password. Use only on creation.
        scheduled_maintenance (google.cloud.sql_v1beta4.types.DatabaseInstance.SqlScheduledMaintenance):
            The start time of any upcoming scheduled
            maintenance for this instance.
        satisfies_pzs (google.protobuf.wrappers_pb2.BoolValue):
            The status indicating if instance
            satisfiesPzs. Reserved for future use.
        out_of_disk_report (google.cloud.sql_v1beta4.types.DatabaseInstance.SqlOutOfDiskReport):
            This field represents the report generated by
            the proactive database wellness job for
            OutOfDisk issues. Writers:
               -- the proactive database wellness job for
            OOD. Readers:
               -- the proactive database wellness job
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

    class SqlFailoverReplica(proto.Message):
        r"""
        Attributes:
            name (str):
                The name of the failover replica. If
                specified at instance creation, a failover
                replica is created for the instance. The name
                doesn't include the project ID. This property is
                applicable only to Second Generation instances.
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

    class SqlOutOfDiskReport(proto.Message):
        r"""This message wraps up the information written by out-of-disk
        detection job.

        Attributes:
            sql_out_of_disk_state (google.cloud.sql_v1beta4.types.DatabaseInstance.SqlOutOfDiskReport.SqlOutOfDiskState):
                This field represents the state generated by
                the proactive database wellness job for
                OutOfDisk issues. Writers:
                   -- the proactive database wellness job for
                OOD. Readers:
                   -- the proactive database wellness job
            sql_min_recommended_increase_size_gb (int):
                The minimum recommended increase size in
                GigaBytes This field is consumed by the frontend
                Writers:
                   -- the proactive database wellness job for
                OOD.
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
        enum='SqlDatabaseVersion',
    )
    settings = proto.Field(
        proto.MESSAGE,
        number=4,
        message='Settings',
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
        message='IpMapping',
    )
    server_ca_cert = proto.Field(
        proto.MESSAGE,
        number=12,
        message='SslCert',
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
        enum='SqlBackendType',
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
        message='DiskEncryptionConfiguration',
    )
    disk_encryption_status = proto.Field(
        proto.MESSAGE,
        number=27,
        message='DiskEncryptionStatus',
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


class DatabasesListResponse(proto.Message):
    r"""Database list response.
    Attributes:
        kind (str):
            This is always <b>sql#databasesList</b>.
        items (Sequence[google.cloud.sql_v1beta4.types.Database]):
            List of database resources in the instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Database',
    )


class DemoteMasterConfiguration(proto.Message):
    r"""Read-replica configuration for connecting to the on-premises
    primary instance.

    Attributes:
        kind (str):
            This is always
            <b>sql#demoteMasterConfiguration</b>.
        mysql_replica_configuration (google.cloud.sql_v1beta4.types.DemoteMasterMySqlReplicaConfiguration):
            MySQL specific configuration when replicating
            from a MySQL on-premises primary instance.
            Replication configuration information such as
            the username, password, certificates, and keys
            are not stored in the instance metadata. The
            configuration information is used only to set up
            the replication connection and is stored by
            MySQL in a file named <b>master.info</b> in the
            data directory.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    mysql_replica_configuration = proto.Field(
        proto.MESSAGE,
        number=2,
        message='DemoteMasterMySqlReplicaConfiguration',
    )


class DemoteMasterContext(proto.Message):
    r"""Database instance demote primary instance context.
    Attributes:
        kind (str):
            This is always
            <b>sql#demoteMasterContext</b>.
        verify_gtid_consistency (google.protobuf.wrappers_pb2.BoolValue):
            Verify GTID consistency for demote operation.
            Default value: <b>True</b>. Second Generation
            instances only.  Setting this flag to false
            enables you to bypass GTID consistency check
            between on-premises primary instance and Cloud
            SQL instance during the demotion operation but
            also exposes you to the risk of future
            replication failures. Change the value only if
            you know the reason for the GTID divergence and
            are confident that doing so will not cause any
            replication issues.
        master_instance_name (str):
            The name of the instance which will act as
            on-premises primary instance in the replication
            setup.
        replica_configuration (google.cloud.sql_v1beta4.types.DemoteMasterConfiguration):
            Configuration specific to read-replicas
            replicating from the on-premises primary
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
        message='DemoteMasterConfiguration',
    )


class DemoteMasterMySqlReplicaConfiguration(proto.Message):
    r"""Read-replica configuration specific to MySQL databases.
    Attributes:
        kind (str):
            This is always
            <b>sql#demoteMasterMysqlReplicaConfiguration</b>.
        username (str):
            The username for the replication connection.
        password (str):
            The password for the replication connection.
        client_key (str):
            PEM representation of the replica's private
            key. The corresponsing public key is encoded in
            the client's certificate. The format of the
            replica's private key can be either PKCS #1 or
            PKCS #8.
        client_certificate (str):
            PEM representation of the replica's x509
            certificate.
        ca_certificate (str):
            PEM representation of the trusted CA's x509
            certificate.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    username = proto.Field(
        proto.STRING,
        number=2,
    )
    password = proto.Field(
        proto.STRING,
        number=3,
    )
    client_key = proto.Field(
        proto.STRING,
        number=4,
    )
    client_certificate = proto.Field(
        proto.STRING,
        number=5,
    )
    ca_certificate = proto.Field(
        proto.STRING,
        number=6,
    )


class ExportContext(proto.Message):
    r"""Database instance export context.
    Attributes:
        uri (str):
            The path to the file in Google Cloud Storage
            where the export will be stored. The URI is in
            the form <b>gs://bucketName/fileName</b>. If the
            file already exists, the request succeeds, but
            the operation fails. <br>If <b>fileType</b> is
            <b>SQL</b> and the filename ends with .gz, the
            contents are compressed.
        databases (Sequence[str]):
            Databases to be exported. <br /> <b>MySQL
            instances:</b> If <b>fileType</b> is <b>SQL</b>
            and no database is specified, all databases are
            exported, except for the <b>mysql</b> system
            database. If <b>fileType</b> is <b>CSV</b>, you
            can specify one database, either by using this
            property or by using the
            <b>csvExportOptions.selectQuery</b> property,
            which takes precedence over this property. <br
            /> <b>PostgreSQL instances:</b> You must specify
            one database to be exported. If <b>fileType</b>
            is <b>CSV</b>, this database must match the one
            specified in the
            <b>csvExportOptions.selectQuery</b> property.
            <br /> <b>SQL Server instances:</b> You must
            specify one database to be exported, and the
            <b>fileType</b> must be <b>BAK</b>.
        kind (str):
            This is always <b>sql#exportContext</b>.
        sql_export_options (google.cloud.sql_v1beta4.types.ExportContext.SqlExportOptions):
            Options for exporting data as SQL statements.
        csv_export_options (google.cloud.sql_v1beta4.types.ExportContext.SqlCsvExportOptions):
            Options for exporting data as CSV.
            <b>MySQL</b> and <b>PostgreSQL</b> instances
            only.
        file_type (google.cloud.sql_v1beta4.types.SqlFileType):
            The file type for the specified uri.
            <br><b>SQL</b>: The file contains SQL
            statements. <br><b>CSV</b>: The file contains
            CSV data. <br><b>BAK</b>: The file contains
            backup data for a SQL Server instance.
        offload (google.protobuf.wrappers_pb2.BoolValue):
            Option for export offload.
    """

    class SqlCsvExportOptions(proto.Message):
        r"""
        Attributes:
            select_query (str):
                The select query used to extract the data.
        """

        select_query = proto.Field(
            proto.STRING,
            number=1,
        )

    class SqlExportOptions(proto.Message):
        r"""
        Attributes:
            tables (Sequence[str]):
                Tables to export, or that were exported, from
                the specified database. If you specify tables,
                specify one and only one database. For
                PostgreSQL instances, you can specify only one
                table.
            schema_only (google.protobuf.wrappers_pb2.BoolValue):
                Export only schemas.
            mysql_export_options (google.cloud.sql_v1beta4.types.ExportContext.SqlExportOptions.MysqlExportOptions):

        """

        class MysqlExportOptions(proto.Message):
            r"""Options for exporting from MySQL.
            Attributes:
                master_data (google.protobuf.wrappers_pb2.Int32Value):
                    Option to include SQL statement required to
                    set up replication. <br>If set to <b>1</b>, the
                    dump file includes  a CHANGE MASTER TO statement
                    with the binary log coordinates,  and --set-
                    gtid-purged is set to ON.
                    <br>If set to <b>2</b>, the CHANGE MASTER TO
                    statement is written as  a SQL comment and has
                    no effect.
                    <br>If set to any value other than <b>1</b>,
                    --set-gtid-purged is set to OFF.
            """

            master_data = proto.Field(
                proto.MESSAGE,
                number=1,
                message=wrappers_pb2.Int32Value,
            )

        tables = proto.RepeatedField(
            proto.STRING,
            number=1,
        )
        schema_only = proto.Field(
            proto.MESSAGE,
            number=2,
            message=wrappers_pb2.BoolValue,
        )
        mysql_export_options = proto.Field(
            proto.MESSAGE,
            number=3,
            message='ExportContext.SqlExportOptions.MysqlExportOptions',
        )

    uri = proto.Field(
        proto.STRING,
        number=1,
    )
    databases = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    kind = proto.Field(
        proto.STRING,
        number=3,
    )
    sql_export_options = proto.Field(
        proto.MESSAGE,
        number=4,
        message=SqlExportOptions,
    )
    csv_export_options = proto.Field(
        proto.MESSAGE,
        number=5,
        message=SqlCsvExportOptions,
    )
    file_type = proto.Field(
        proto.ENUM,
        number=6,
        enum='SqlFileType',
    )
    offload = proto.Field(
        proto.MESSAGE,
        number=8,
        message=wrappers_pb2.BoolValue,
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
            This is always <b>sql#failoverContext</b>.
    """

    settings_version = proto.Field(
        proto.INT64,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class Flag(proto.Message):
    r"""A flag resource.
    Attributes:
        name (str):
            This is the name of the flag. Flag names always use
            underscores, not hyphens, for example: max_allowed_packet
        type_ (google.cloud.sql_v1beta4.types.SqlFlagType):
            The type of the flag. Flags are typed to being BOOLEAN,
            STRING, INTEGER or NONE. NONE is used for flags which do not
            take a value, such as skip_grant_tables.
        applies_to (Sequence[google.cloud.sql_v1beta4.types.SqlDatabaseVersion]):
            The database version this flag applies to. Can be MYSQL_8_0,
            MYSQL_5_6, or MYSQL_5_7.
        allowed_string_values (Sequence[str]):
            For <b>STRING</b> flags, a list of strings
            that the value can be set to.
        min_value (google.protobuf.wrappers_pb2.Int64Value):
            For <b>INTEGER</b> flags, the minimum allowed
            value.
        max_value (google.protobuf.wrappers_pb2.Int64Value):
            For <b>INTEGER</b> flags, the maximum allowed
            value.
        requires_restart (google.protobuf.wrappers_pb2.BoolValue):
            Indicates whether changing this flag will
            trigger a database restart. Only applicable to
            Second Generation instances.
        kind (str):
            This is always <b>sql#flag</b>.
        in_beta (google.protobuf.wrappers_pb2.BoolValue):
            Whether or not the flag is considered in
            beta.
        allowed_int_values (Sequence[int]):
            Use this field if only certain integers are accepted. Can be
            combined with min_value and max_value to add additional
            values.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=2,
        enum='SqlFlagType',
    )
    applies_to = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum='SqlDatabaseVersion',
    )
    allowed_string_values = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    min_value = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.Int64Value,
    )
    max_value = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers_pb2.Int64Value,
    )
    requires_restart = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers_pb2.BoolValue,
    )
    kind = proto.Field(
        proto.STRING,
        number=8,
    )
    in_beta = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.BoolValue,
    )
    allowed_int_values = proto.RepeatedField(
        proto.INT64,
        number=10,
    )


class FlagsListResponse(proto.Message):
    r"""Flags list response.
    Attributes:
        kind (str):
            This is always <b>sql#flagsList</b>.
        items (Sequence[google.cloud.sql_v1beta4.types.Flag]):
            List of flags.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Flag',
    )


class ImportContext(proto.Message):
    r"""Database instance import context.
    Attributes:
        uri (str):
            Path to the import file in Cloud Storage, in
            the form <b>gs://bucketName/fileName</b>.
            Compressed gzip files (.gz) are supported when
            <b>fileType</b> is <b>SQL</b>. The instance must
            have write permissions to the bucket and read
            access to the file.
        database (str):
            The target database for the import. If
            <b>fileType</b> is <b>SQL</b>, this field is
            required only if the import file does not
            specify a database, and is overridden by any
            database specification in the import file. If
            <b>fileType</b> is <b>CSV</b>, one database must
            be specified.
        kind (str):
            This is always <b>sql#importContext</b>.
        file_type (google.cloud.sql_v1beta4.types.SqlFileType):
            The file type for the specified uri.
            <br><b>SQL</b>: The file contains SQL
            statements. <br><b>CSV</b>: The file contains
            CSV data.
        csv_import_options (google.cloud.sql_v1beta4.types.ImportContext.SqlCsvImportOptions):
            Options for importing data as CSV.
        import_user (str):
            The PostgreSQL user for this import
            operation. PostgreSQL instances only.
        bak_import_options (google.cloud.sql_v1beta4.types.ImportContext.SqlBakImportOptions):
            Import parameters specific to SQL Server .BAK
            files
    """

    class SqlCsvImportOptions(proto.Message):
        r"""
        Attributes:
            table (str):
                The table to which CSV data is imported.
            columns (Sequence[str]):
                The columns to which CSV data is imported. If
                not specified, all columns of the database table
                are loaded with CSV data.
        """

        table = proto.Field(
            proto.STRING,
            number=1,
        )
        columns = proto.RepeatedField(
            proto.STRING,
            number=2,
        )

    class SqlBakImportOptions(proto.Message):
        r"""
        Attributes:
            encryption_options (google.cloud.sql_v1beta4.types.ImportContext.SqlBakImportOptions.EncryptionOptions):

        """

        class EncryptionOptions(proto.Message):
            r"""
            Attributes:
                cert_path (str):
                    Path to the Certificate (.cer) in Cloud
                    Storage, in the form
                    <b>gs://bucketName/fileName</b>. The instance
                    must have write permissions to the bucket and
                    read access to the file.
                pvk_path (str):
                    Path to the Certificate Private Key (.pvk)
                    in Cloud Storage, in the form
                    <b>gs://bucketName/fileName</b>. The instance
                    must have write permissions to the bucket and
                    read access to the file.
                pvk_password (str):
                    Password that encrypts the private key
            """

            cert_path = proto.Field(
                proto.STRING,
                number=1,
            )
            pvk_path = proto.Field(
                proto.STRING,
                number=2,
            )
            pvk_password = proto.Field(
                proto.STRING,
                number=3,
            )

        encryption_options = proto.Field(
            proto.MESSAGE,
            number=1,
            message='ImportContext.SqlBakImportOptions.EncryptionOptions',
        )

    uri = proto.Field(
        proto.STRING,
        number=1,
    )
    database = proto.Field(
        proto.STRING,
        number=2,
    )
    kind = proto.Field(
        proto.STRING,
        number=3,
    )
    file_type = proto.Field(
        proto.ENUM,
        number=4,
        enum='SqlFileType',
    )
    csv_import_options = proto.Field(
        proto.MESSAGE,
        number=5,
        message=SqlCsvImportOptions,
    )
    import_user = proto.Field(
        proto.STRING,
        number=6,
    )
    bak_import_options = proto.Field(
        proto.MESSAGE,
        number=7,
        message=SqlBakImportOptions,
    )


class InstancesCloneRequest(proto.Message):
    r"""Database instance clone request.
    Attributes:
        clone_context (google.cloud.sql_v1beta4.types.CloneContext):
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
        demote_master_context (google.cloud.sql_v1beta4.types.DemoteMasterContext):
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
        export_context (google.cloud.sql_v1beta4.types.ExportContext):
            Contains details about the export operation.
    """

    export_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ExportContext',
    )


class InstancesFailoverRequest(proto.Message):
    r"""Instance failover request.
    Attributes:
        failover_context (google.cloud.sql_v1beta4.types.FailoverContext):
            Failover Context.
    """

    failover_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='FailoverContext',
    )


class InstancesImportRequest(proto.Message):
    r"""Database instance import request.
    Attributes:
        import_context (google.cloud.sql_v1beta4.types.ImportContext):
            Contains details about the import operation.
    """

    import_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ImportContext',
    )


class InstancesListResponse(proto.Message):
    r"""Database instances list response.
    Attributes:
        kind (str):
            This is always <b>sql#instancesList</b>.
        warnings (Sequence[google.cloud.sql_v1beta4.types.ApiWarning]):
            List of warnings that occurred while handling
            the request.
        items (Sequence[google.cloud.sql_v1beta4.types.DatabaseInstance]):
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
        message='ApiWarning',
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
        certs (Sequence[google.cloud.sql_v1beta4.types.SslCert]):
            List of server CA certificates for the
            instance.
        active_version (str):

        kind (str):
            This is always
            <b>sql#instancesListServerCas</b>.
    """

    certs = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='SslCert',
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
        restore_backup_context (google.cloud.sql_v1beta4.types.RestoreBackupContext):
            Parameters required to perform the restore
            backup operation.
    """

    restore_backup_context = proto.Field(
        proto.MESSAGE,
        number=1,
        message='RestoreBackupContext',
    )


class InstancesRotateServerCaRequest(proto.Message):
    r"""Rotate Server CA request.
    Attributes:
        rotate_server_ca_context (google.cloud.sql_v1beta4.types.RotateServerCaContext):
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
        truncate_log_context (google.cloud.sql_v1beta4.types.TruncateLogContext):
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
            This is always
            <b>sql#migrationSettingErrorList</b>.
        errors (Sequence[google.cloud.sql_v1beta4.types.SqlExternalSyncSettingError]):
            List of migration violations.
        warnings (Sequence[google.cloud.sql_v1beta4.types.SqlExternalSyncSettingError]):
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


class SqlExternalSyncSettingError(proto.Message):
    r"""External primary instance migration setting error/warning.
    Attributes:
        kind (str):
            Can be <b>sql#externalSyncSettingError</b> or
            <b>sql#externalSyncSettingWarning</b>.
        type_ (google.cloud.sql_v1beta4.types.SqlExternalSyncSettingError.SqlExternalSyncSettingErrorType):
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


class IpConfiguration(proto.Message):
    r"""IP Management configuration.
    Attributes:
        ipv4_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Whether the instance is assigned a public IP
            address or not.
        private_network (str):
            The resource link for the VPC network from
            which the Cloud SQL instance is accessible for
            private IP. For example,
            <b>/projects/myProject/global/networks/default</b>.
            This setting can be updated, but it cannot be
            removed after it is set.
        require_ssl (google.protobuf.wrappers_pb2.BoolValue):
            Whether SSL connections over IP are enforced
            or not.
        authorized_networks (Sequence[google.cloud.sql_v1beta4.types.AclEntry]):
            The list of external networks that are
            allowed to connect to the instance using the IP.
            In 'CIDR' notation, also known as 'slash'
            notation (for example: <b>192.168.100.0/24</b>).
    """

    ipv4_enabled = proto.Field(
        proto.MESSAGE,
        number=1,
        message=wrappers_pb2.BoolValue,
    )
    private_network = proto.Field(
        proto.STRING,
        number=2,
    )
    require_ssl = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers_pb2.BoolValue,
    )
    authorized_networks = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message='AclEntry',
    )


class IpMapping(proto.Message):
    r"""Database instance IP Mapping.
    Attributes:
        type_ (google.cloud.sql_v1beta4.types.SqlIpAddressType):
            The type of this IP address. A <b>PRIMARY</b>
            address is a public address that can accept
            incoming connections. A <b>PRIVATE</b> address
            is a private address that can accept incoming
            connections. An <b>OUTGOING</b> address is the
            source address of connections originating from
            the instance, if supported.
        ip_address (str):
            The IP address assigned.
        time_to_retire (google.protobuf.timestamp_pb2.Timestamp):
            The due time for this IP to be retired in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>. This field is
            only available when the IP is scheduled to be
            retired.
    """

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum='SqlIpAddressType',
    )
    ip_address = proto.Field(
        proto.STRING,
        number=2,
    )
    time_to_retire = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp_pb2.Timestamp,
    )


class LocationPreference(proto.Message):
    r"""Preferred location. This specifies where a Cloud SQL instance
    is located, either in a specific Compute Engine zone, or co-
    located with an App Engine application. Note that if the
    preferred location is not available, the instance will be
    located as close as possible within the region. Only one
    location may be specified.

    Attributes:
        follow_gae_application (str):
            The App Engine application to follow, it must
            be in the same region as the Cloud SQL instance.
        zone (str):
            The preferred Compute Engine zone (for
            example: us-central1-a, us-central1-b, etc.).
        secondary_zone (str):
            The preferred Compute Engine zone for the
            secondary/failover (for example: us-central1-a,
            us-central1-b, etc.). Reserved for future use.
        kind (str):
            This is always <b>sql#locationPreference</b>.
    """

    follow_gae_application = proto.Field(
        proto.STRING,
        number=1,
    )
    zone = proto.Field(
        proto.STRING,
        number=2,
    )
    secondary_zone = proto.Field(
        proto.STRING,
        number=4,
    )
    kind = proto.Field(
        proto.STRING,
        number=3,
    )


class MaintenanceWindow(proto.Message):
    r"""Maintenance window. This specifies when a Cloud SQL instance
    is restarted for system maintenance purposes.

    Attributes:
        hour (google.protobuf.wrappers_pb2.Int32Value):
            hour of day - 0 to 23.
        day (google.protobuf.wrappers_pb2.Int32Value):
            day of week (1-7), starting on Monday.
        update_track (google.cloud.sql_v1beta4.types.SqlUpdateTrack):
            Maintenance timing setting: canary (Earlier) or stable
            (Later). Learn more.
        kind (str):
            This is always <b>sql#maintenanceWindow</b>.
    """

    hour = proto.Field(
        proto.MESSAGE,
        number=1,
        message=wrappers_pb2.Int32Value,
    )
    day = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.Int32Value,
    )
    update_track = proto.Field(
        proto.ENUM,
        number=3,
        enum='SqlUpdateTrack',
    )
    kind = proto.Field(
        proto.STRING,
        number=4,
    )


class DenyMaintenancePeriod(proto.Message):
    r"""Deny Maintenance Periods. This specifies a date range during
    when all CSA rollout will be denied.

    Attributes:
        start_date (str):
            "deny maintenance period" start date. If the
            year of the start date is empty, the year of the
            end date also must be empty. In this case, it
            means the deny maintenance period recurs every
            year. The date is in format yyyy-mm-dd i.e.,
            2020-11-01, or mm-dd, i.e., 11-01
        end_date (str):
            "deny maintenance period" end date. If the
            year of the end date is empty, the year of the
            start date also must be empty. In this case, it
            means the deny maintenance period recurs every
            year. The date is in format yyyy-mm-dd i.e.,
            2020-11-01, or mm-dd, i.e., 11-01
        time (str):
            Time in UTC when the "deny maintenance period" starts on
            start_date and ends on end_date. The time is in format:
            HH:mm:SS, i.e., 00:00:00
    """

    start_date = proto.Field(
        proto.STRING,
        number=1,
    )
    end_date = proto.Field(
        proto.STRING,
        number=2,
    )
    time = proto.Field(
        proto.STRING,
        number=3,
    )


class InsightsConfig(proto.Message):
    r"""Insights configuration. This specifies when Cloud SQL
    Insights feature is enabled and optional configuration.

    Attributes:
        query_insights_enabled (bool):
            Whether Query Insights feature is enabled.
        record_client_address (bool):
            Whether Query Insights will record client
            address when enabled.
        record_application_tags (bool):
            Whether Query Insights will record
            application tags from query when enabled.
        query_string_length (google.protobuf.wrappers_pb2.Int32Value):
            Maximum query length stored in bytes. Default
            value: 1024 bytes. Range: 256-4500 bytes. Query
            length more than this field value will be
            truncated to this value. When unset, query
            length will be the default value. Changing query
            length will restart the database.
        query_plans_per_minute (google.protobuf.wrappers_pb2.Int32Value):
            Number of query plans generated by Insights
            per minute. Default is 5. Changing this will
            restart the database.
    """

    query_insights_enabled = proto.Field(
        proto.BOOL,
        number=1,
    )
    record_client_address = proto.Field(
        proto.BOOL,
        number=2,
    )
    record_application_tags = proto.Field(
        proto.BOOL,
        number=3,
    )
    query_string_length = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers_pb2.Int32Value,
    )
    query_plans_per_minute = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.Int32Value,
    )


class MySqlReplicaConfiguration(proto.Message):
    r"""Read-replica configuration specific to MySQL databases.
    Attributes:
        dump_file_path (str):
            Path to a SQL dump file in Google Cloud
            Storage from which the replica instance is to be
            created. The URI is in the form
            gs://bucketName/fileName. Compressed gzip files
            (.gz) are also supported. Dumps have the binlog
            co-ordinates from which replication begins. This
            can be accomplished by setting --master-data to
            1 when using mysqldump.
        username (str):
            The username for the replication connection.
        password (str):
            The password for the replication connection.
        connect_retry_interval (google.protobuf.wrappers_pb2.Int32Value):
            Seconds to wait between connect retries.
            MySQL's default is 60 seconds.
        master_heartbeat_period (google.protobuf.wrappers_pb2.Int64Value):
            Interval in milliseconds between replication
            heartbeats.
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
        ssl_cipher (str):
            A list of permissible ciphers to use for SSL
            encryption.
        verify_server_certificate (google.protobuf.wrappers_pb2.BoolValue):
            Whether or not to check the primary
            instance's Common Name value in the certificate
            that it sends during the SSL handshake.
        kind (str):
            This is always
            <b>sql#mysqlReplicaConfiguration</b>.
    """

    dump_file_path = proto.Field(
        proto.STRING,
        number=1,
    )
    username = proto.Field(
        proto.STRING,
        number=2,
    )
    password = proto.Field(
        proto.STRING,
        number=3,
    )
    connect_retry_interval = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers_pb2.Int32Value,
    )
    master_heartbeat_period = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.Int64Value,
    )
    ca_certificate = proto.Field(
        proto.STRING,
        number=6,
    )
    client_certificate = proto.Field(
        proto.STRING,
        number=7,
    )
    client_key = proto.Field(
        proto.STRING,
        number=8,
    )
    ssl_cipher = proto.Field(
        proto.STRING,
        number=9,
    )
    verify_server_certificate = proto.Field(
        proto.MESSAGE,
        number=10,
        message=wrappers_pb2.BoolValue,
    )
    kind = proto.Field(
        proto.STRING,
        number=11,
    )


class OnPremisesConfiguration(proto.Message):
    r"""On-premises instance configuration.
    Attributes:
        host_port (str):
            The host and port of the on-premises instance
            in host:port format
        kind (str):
            This is always
            <b>sql#onPremisesConfiguration</b>.
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


class DiskEncryptionConfiguration(proto.Message):
    r"""Disk encryption configuration for an instance.
    Attributes:
        kms_key_name (str):
            Resource name of KMS key for disk encryption
        kind (str):
            This is always
            <b>sql#diskEncryptionConfiguration</b>.
    """

    kms_key_name = proto.Field(
        proto.STRING,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class DiskEncryptionStatus(proto.Message):
    r"""Disk encryption status for an instance.
    Attributes:
        kms_key_version_name (str):
            KMS key version used to encrypt the Cloud SQL
            instance resource
        kind (str):
            This is always
            <b>sql#diskEncryptionStatus</b>.
    """

    kms_key_version_name = proto.Field(
        proto.STRING,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class Operation(proto.Message):
    r"""An Operation resource.&nbsp;For successful operations that
    return an Operation resource, only the fields relevant to the
    operation are populated in the resource.

    Attributes:
        kind (str):
            This is always <b>sql#operation</b>.
        target_link (str):

        status (google.cloud.sql_v1beta4.types.Operation.SqlOperationStatus):
            The status of an operation. Valid values are: PENDING
            RUNNING DONE SQL_OPERATION_STATUS_UNSPECIFIED
        user (str):
            The email address of the user who initiated
            this operation.
        insert_time (google.protobuf.timestamp_pb2.Timestamp):
            The time this operation was enqueued in UTC
            timezone in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            The time this operation actually started in
            UTC timezone in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            The time this operation finished in UTC
            timezone in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        error (google.cloud.sql_v1beta4.types.OperationErrors):
            If errors occurred during processing of this
            operation, this field will be populated.
        operation_type (google.cloud.sql_v1beta4.types.Operation.SqlOperationType):
            The type of the operation. Valid values are: CREATE DELETE
            UPDATE RESTART IMPORT EXPORT BACKUP_VOLUME RESTORE_VOLUME
            CREATE_USER DELETE_USER CREATE_DATABASE DELETE_DATABASE
        import_context (google.cloud.sql_v1beta4.types.ImportContext):
            The context for import operation, if
            applicable.
        export_context (google.cloud.sql_v1beta4.types.ExportContext):
            The context for export operation, if
            applicable.
        backup_context (google.cloud.sql_v1beta4.types.BackupContext):
            The context for backup operation, if
            applicable.
        name (str):
            An identifier that uniquely identifies the
            operation. You can use this identifier to
            retrieve the Operations resource that has
            information about the operation.
        target_id (str):
            Name of the database instance related to this
            operation.
        self_link (str):
            The URI of this resource.
        target_project (str):
            The project ID of the target instance related
            to this operation.
    """
    class SqlOperationType(proto.Enum):
        r"""The type of Cloud SQL operation."""
        SQL_OPERATION_TYPE_UNSPECIFIED = 0
        IMPORT = 1
        EXPORT = 2
        CREATE = 3
        UPDATE = 4
        DELETE = 5
        RESTART = 6
        BACKUP = 7
        SNAPSHOT = 8
        BACKUP_VOLUME = 9
        DELETE_VOLUME = 10
        RESTORE_VOLUME = 11
        INJECT_USER = 12
        CLONE = 14
        STOP_REPLICA = 15
        START_REPLICA = 16
        PROMOTE_REPLICA = 17
        CREATE_REPLICA = 18
        CREATE_USER = 19
        DELETE_USER = 20
        UPDATE_USER = 21
        CREATE_DATABASE = 22
        DELETE_DATABASE = 23
        UPDATE_DATABASE = 24
        FAILOVER = 25
        DELETE_BACKUP = 26
        RECREATE_REPLICA = 27
        TRUNCATE_LOG = 28
        DEMOTE_MASTER = 29
        MAINTENANCE = 30
        ENABLE_PRIVATE_IP = 31
        DEFER_MAINTENANCE = 32
        CREATE_CLONE = 33
        RESCHEDULE_MAINTENANCE = 34
        START_EXTERNAL_SYNC = 35

    class SqlOperationStatus(proto.Enum):
        r"""The status of an operation."""
        SQL_OPERATION_STATUS_UNSPECIFIED = 0
        PENDING = 1
        RUNNING = 2
        DONE = 3

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    target_link = proto.Field(
        proto.STRING,
        number=2,
    )
    status = proto.Field(
        proto.ENUM,
        number=3,
        enum=SqlOperationStatus,
    )
    user = proto.Field(
        proto.STRING,
        number=4,
    )
    insert_time = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )
    start_time = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )
    error = proto.Field(
        proto.MESSAGE,
        number=8,
        message='OperationErrors',
    )
    operation_type = proto.Field(
        proto.ENUM,
        number=9,
        enum=SqlOperationType,
    )
    import_context = proto.Field(
        proto.MESSAGE,
        number=10,
        message='ImportContext',
    )
    export_context = proto.Field(
        proto.MESSAGE,
        number=11,
        message='ExportContext',
    )
    backup_context = proto.Field(
        proto.MESSAGE,
        number=17,
        message='BackupContext',
    )
    name = proto.Field(
        proto.STRING,
        number=12,
    )
    target_id = proto.Field(
        proto.STRING,
        number=13,
    )
    self_link = proto.Field(
        proto.STRING,
        number=14,
    )
    target_project = proto.Field(
        proto.STRING,
        number=15,
    )


class OperationError(proto.Message):
    r"""Database instance operation error.
    Attributes:
        kind (str):
            This is always <b>sql#operationError</b>.
        code (str):
            Identifies the specific error that occurred.
        message (str):
            Additional information about the error
            encountered.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    code = proto.Field(
        proto.STRING,
        number=2,
    )
    message = proto.Field(
        proto.STRING,
        number=3,
    )


class OperationErrors(proto.Message):
    r"""Database instance operation errors list wrapper.
    Attributes:
        kind (str):
            This is always <b>sql#operationErrors</b>.
        errors (Sequence[google.cloud.sql_v1beta4.types.OperationError]):
            The list of errors encountered while
            processing this operation.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    errors = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='OperationError',
    )


class OperationsListResponse(proto.Message):
    r"""Database instance list operations response.
    Attributes:
        kind (str):
            This is always <b>sql#operationsList</b>.
        items (Sequence[google.cloud.sql_v1beta4.types.Operation]):
            List of operation resources.
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
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Operation',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class ReplicaConfiguration(proto.Message):
    r"""Read-replica configuration for connecting to the primary
    instance.

    Attributes:
        kind (str):
            This is always
            <b>sql#replicaConfiguration</b>.
        mysql_replica_configuration (google.cloud.sql_v1beta4.types.MySqlReplicaConfiguration):
            MySQL specific configuration when replicating
            from a MySQL on-premises primary instance.
            Replication configuration information such as
            the username, password, certificates, and keys
            are not stored in the instance metadata. The
            configuration information is used only to set up
            the replication connection and is stored by
            MySQL in a file named <b>master.info</b> in the
            data directory.
        failover_target (google.protobuf.wrappers_pb2.BoolValue):
            Specifies if the replica is the failover
            target. If the field is set to <b>true</b> the
            replica will be designated as a failover
            replica. In case the primary instance fails, the
            replica instance will be promoted as the new
            primary instance.  <p>Only one replica can be
            specified as failover target, and the replica
            has to be in different zone with the primary
            instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    mysql_replica_configuration = proto.Field(
        proto.MESSAGE,
        number=2,
        message='MySqlReplicaConfiguration',
    )
    failover_target = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers_pb2.BoolValue,
    )


class RestoreBackupContext(proto.Message):
    r"""Database instance restore from backup context.
    Backup context contains source instance id and project id.

    Attributes:
        kind (str):
            This is always
            <b>sql#restoreBackupContext</b>.
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
            This is always
            <b>sql#rotateServerCaContext</b>.
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


class Settings(proto.Message):
    r"""Database instance settings.
    Attributes:
        settings_version (google.protobuf.wrappers_pb2.Int64Value):
            The version of instance settings. This is a
            required field for update method to make sure
            concurrent updates are handled properly. During
            update, use the most recent settingsVersion
            value for this instance and do not try to update
            this value.
        authorized_gae_applications (Sequence[str]):
            The App Engine app IDs that can access this
            instance. (Deprecated) Applied to First
            Generation instances only.
        tier (str):
            The tier (or machine type) for this instance,
            for example <b>db-custom-1-3840</b>.
        kind (str):
            This is always <b>sql#settings</b>.
        user_labels (Sequence[google.cloud.sql_v1beta4.types.Settings.UserLabelsEntry]):
            User-provided labels, represented as a
            dictionary where each label is a single key
            value pair.
        availability_type (google.cloud.sql_v1beta4.types.SqlAvailabilityType):
            Availability type. Potential values:
            <br><b>ZONAL</b>: The instance serves data from
            only one zone. Outages in that zone affect data
            accessibility.   <br><b>REGIONAL</b>: The
            instance can serve data from more than one zone
            in a region
            (it is highly available). <br>For more
            information, see <a
            href="/sql/docs/postgres/high-availability">
            Overview of the High Availability
            Configuration</a>.
        pricing_plan (google.cloud.sql_v1beta4.types.SqlPricingPlan):
            The pricing plan for this instance. This can be either
            PER_USE or PACKAGE. Only PER_USE is supported for Second
            Generation instances.
        replication_type (google.cloud.sql_v1beta4.types.SqlReplicationType):
            The type of replication this instance uses. This can be
            either ASYNCHRONOUS or SYNCHRONOUS. (Deprecated\_ This
            property was only applicable to First Generation instances.
        storage_auto_resize_limit (google.protobuf.wrappers_pb2.Int64Value):
            The maximum size to which storage capacity
            can be automatically increased. The default
            value is 0, which specifies that there is no
            limit.
        activation_policy (google.cloud.sql_v1beta4.types.Settings.SqlActivationPolicy):
            The activation policy specifies when the
            instance is activated; it is applicable only
            when the instance state is RUNNABLE. Valid
            values:   <br><b>ALWAYS</b>: The instance is on,
            and remains so even in the absence of connection
            requests.
              <br><b>NEVER</b>: The instance is off; it is
            not activated, even if a   connection request
            arrives.
        ip_configuration (google.cloud.sql_v1beta4.types.IpConfiguration):
            The settings for IP Management. This allows
            to enable or disable the instance IP and manage
            which external networks can connect to the
            instance. The IPv4 address cannot be disabled
            for Second Generation instances.
        storage_auto_resize (google.protobuf.wrappers_pb2.BoolValue):
            Configuration to increase storage size
            automatically. The default value is true.
        location_preference (google.cloud.sql_v1beta4.types.LocationPreference):
            The location preference settings. This allows
            the instance to be located as near as possible
            to either an App Engine app or Compute Engine
            zone for better performance. App Engine co-
            location was only applicable to First Generation
            instances.
        database_flags (Sequence[google.cloud.sql_v1beta4.types.DatabaseFlags]):
            The database flags passed to the instance at
            startup.
        data_disk_type (google.cloud.sql_v1beta4.types.SqlDataDiskType):
            The type of data disk: PD_SSD (default) or PD_HDD. Not used
            for First Generation instances.
        maintenance_window (google.cloud.sql_v1beta4.types.MaintenanceWindow):
            The maintenance window for this instance.
            This specifies when the instance can be
            restarted for maintenance purposes.
        backup_configuration (google.cloud.sql_v1beta4.types.BackupConfiguration):
            The daily backup configuration for the
            instance.
        database_replication_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Configuration specific to read replica
            instances. Indicates whether replication is
            enabled or not.
        crash_safe_replication_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Configuration specific to read replica
            instances. Indicates whether database flags for
            crash-safe replication are enabled. This
            property was only applicable to First Generation
            instances.
        data_disk_size_gb (google.protobuf.wrappers_pb2.Int64Value):
            The size of data disk, in GB. The data disk
            size minimum is 10GB.
        active_directory_config (google.cloud.sql_v1beta4.types.SqlActiveDirectoryConfig):
            Active Directory configuration, relevant only
            for Cloud SQL for SQL Server.
        collation (str):
            The name of server Instance collation.
        deny_maintenance_periods (Sequence[google.cloud.sql_v1beta4.types.DenyMaintenancePeriod]):
            Deny maintenance periods
        insights_config (google.cloud.sql_v1beta4.types.InsightsConfig):
            Insights configuration, for now relevant only
            for Postgres.
    """
    class SqlActivationPolicy(proto.Enum):
        r"""Specifies when the instance is activated."""
        SQL_ACTIVATION_POLICY_UNSPECIFIED = 0
        ALWAYS = 1
        NEVER = 2
        ON_DEMAND = 3

    settings_version = proto.Field(
        proto.MESSAGE,
        number=1,
        message=wrappers_pb2.Int64Value,
    )
    authorized_gae_applications = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    tier = proto.Field(
        proto.STRING,
        number=3,
    )
    kind = proto.Field(
        proto.STRING,
        number=4,
    )
    user_labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=5,
    )
    availability_type = proto.Field(
        proto.ENUM,
        number=6,
        enum='SqlAvailabilityType',
    )
    pricing_plan = proto.Field(
        proto.ENUM,
        number=7,
        enum='SqlPricingPlan',
    )
    replication_type = proto.Field(
        proto.ENUM,
        number=8,
        enum='SqlReplicationType',
    )
    storage_auto_resize_limit = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.Int64Value,
    )
    activation_policy = proto.Field(
        proto.ENUM,
        number=10,
        enum=SqlActivationPolicy,
    )
    ip_configuration = proto.Field(
        proto.MESSAGE,
        number=11,
        message='IpConfiguration',
    )
    storage_auto_resize = proto.Field(
        proto.MESSAGE,
        number=12,
        message=wrappers_pb2.BoolValue,
    )
    location_preference = proto.Field(
        proto.MESSAGE,
        number=13,
        message='LocationPreference',
    )
    database_flags = proto.RepeatedField(
        proto.MESSAGE,
        number=14,
        message='DatabaseFlags',
    )
    data_disk_type = proto.Field(
        proto.ENUM,
        number=15,
        enum='SqlDataDiskType',
    )
    maintenance_window = proto.Field(
        proto.MESSAGE,
        number=16,
        message='MaintenanceWindow',
    )
    backup_configuration = proto.Field(
        proto.MESSAGE,
        number=17,
        message='BackupConfiguration',
    )
    database_replication_enabled = proto.Field(
        proto.MESSAGE,
        number=18,
        message=wrappers_pb2.BoolValue,
    )
    crash_safe_replication_enabled = proto.Field(
        proto.MESSAGE,
        number=19,
        message=wrappers_pb2.BoolValue,
    )
    data_disk_size_gb = proto.Field(
        proto.MESSAGE,
        number=20,
        message=wrappers_pb2.Int64Value,
    )
    active_directory_config = proto.Field(
        proto.MESSAGE,
        number=22,
        message='SqlActiveDirectoryConfig',
    )
    collation = proto.Field(
        proto.STRING,
        number=23,
    )
    deny_maintenance_periods = proto.RepeatedField(
        proto.MESSAGE,
        number=24,
        message='DenyMaintenancePeriod',
    )
    insights_config = proto.Field(
        proto.MESSAGE,
        number=25,
        message='InsightsConfig',
    )


class SslCert(proto.Message):
    r"""SslCerts Resource
    Attributes:
        kind (str):
            This is always <b>sql#sslCert</b>.
        cert_serial_number (str):
            Serial number, as extracted from the
            certificate.
        cert (str):
            PEM representation.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when the certificate was created in
            <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>
        common_name (str):
            User supplied name. Constrained to [a-zA-Z.-\_ ]+.
        expiration_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when the certificate expires in <a
            href="https://tools.ietf.org/html/rfc3339">RFC
            3339</a> format, for example
            <b>2012-11-15T16:19:00.094Z</b>.
        sha1_fingerprint (str):
            Sha1 Fingerprint.
        instance (str):
            Name of the database instance.
        self_link (str):
            The URI of this resource.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    cert_serial_number = proto.Field(
        proto.STRING,
        number=2,
    )
    cert = proto.Field(
        proto.STRING,
        number=3,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    common_name = proto.Field(
        proto.STRING,
        number=5,
    )
    expiration_time = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    sha1_fingerprint = proto.Field(
        proto.STRING,
        number=7,
    )
    instance = proto.Field(
        proto.STRING,
        number=8,
    )
    self_link = proto.Field(
        proto.STRING,
        number=9,
    )


class SslCertDetail(proto.Message):
    r"""SslCertDetail.
    Attributes:
        cert_info (google.cloud.sql_v1beta4.types.SslCert):
            The public information about the cert.
        cert_private_key (str):
            The private key for the client cert, in pem
            format.  Keep private in order to protect your
            security.
    """

    cert_info = proto.Field(
        proto.MESSAGE,
        number=1,
        message='SslCert',
    )
    cert_private_key = proto.Field(
        proto.STRING,
        number=2,
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


class SslCertsInsertRequest(proto.Message):
    r"""SslCerts insert request.
    Attributes:
        common_name (str):
            User supplied name.  Must be a distinct name
            from the other certificates for this instance.
    """

    common_name = proto.Field(
        proto.STRING,
        number=1,
    )


class SqlInstancesRescheduleMaintenanceRequestBody(proto.Message):
    r"""Reschedule options for maintenance windows.
    Attributes:
        reschedule (google.cloud.sql_v1beta4.types.SqlInstancesRescheduleMaintenanceRequestBody.Reschedule):
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
            reschedule_type (google.cloud.sql_v1beta4.types.SqlInstancesRescheduleMaintenanceRequestBody.RescheduleType):
                Required. The type of the reschedule.
            schedule_time (google.protobuf.timestamp_pb2.Timestamp):
                Optional. Timestamp when the maintenance shall be
                rescheduled to if reschedule_type=SPECIFIC_TIME, in RFC 3339
                format, for example 2012-11-15T16:19:00.094Z.
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


class SslCertsInsertResponse(proto.Message):
    r"""SslCert insert response.
    Attributes:
        kind (str):
            This is always <b>sql#sslCertsInsert</b>.
        operation (google.cloud.sql_v1beta4.types.Operation):
            The operation to track the ssl certs insert
            request.
        server_ca_cert (google.cloud.sql_v1beta4.types.SslCert):
            The server Certificate Authority's
            certificate.  If this is missing you can force a
            new one to be generated by calling
            resetSslConfig method on instances resource.
        client_cert (google.cloud.sql_v1beta4.types.SslCertDetail):
            The new client certificate and private key.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    operation = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Operation',
    )
    server_ca_cert = proto.Field(
        proto.MESSAGE,
        number=3,
        message='SslCert',
    )
    client_cert = proto.Field(
        proto.MESSAGE,
        number=4,
        message='SslCertDetail',
    )


class SslCertsListResponse(proto.Message):
    r"""SslCerts list response.
    Attributes:
        kind (str):
            This is always <b>sql#sslCertsList</b>.
        items (Sequence[google.cloud.sql_v1beta4.types.SslCert]):
            List of client certificates for the instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='SslCert',
    )


class TruncateLogContext(proto.Message):
    r"""Database Instance truncate log context.
    Attributes:
        kind (str):
            This is always <b>sql#truncateLogContext</b>.
        log_type (str):
            The type of log to truncate. Valid values are
            MYSQL_GENERAL_TABLE and MYSQL_SLOW_TABLE.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    log_type = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlActiveDirectoryConfig(proto.Message):
    r"""Active Directory configuration, relevant only for Cloud SQL
    for SQL Server.

    Attributes:
        kind (str):
            This is always sql#activeDirectoryConfig.
        domain (str):
            The name of the domain (e.g., mydomain.com).
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    domain = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
