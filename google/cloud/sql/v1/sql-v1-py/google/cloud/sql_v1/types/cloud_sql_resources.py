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
    package='google.cloud.sql.v1',
    manifest={
        'SqlFileType',
        'SqlBackendType',
        'SqlIpAddressType',
        'SqlDatabaseVersion',
        'SqlPricingPlan',
        'SqlReplicationType',
        'SqlDataDiskType',
        'SqlAvailabilityType',
        'SqlUpdateTrack',
        'AclEntry',
        'ApiWarning',
        'BackupRetentionSettings',
        'BackupConfiguration',
        'BackupContext',
        'Database',
        'SqlServerDatabaseDetails',
        'DatabaseFlags',
        'MySqlSyncConfig',
        'SyncFlags',
        'InstanceReference',
        'DemoteMasterConfiguration',
        'DemoteMasterMySqlReplicaConfiguration',
        'ExportContext',
        'ImportContext',
        'IpConfiguration',
        'LocationPreference',
        'MaintenanceWindow',
        'DenyMaintenancePeriod',
        'InsightsConfig',
        'MySqlReplicaConfiguration',
        'DiskEncryptionConfiguration',
        'DiskEncryptionStatus',
        'IpMapping',
        'Operation',
        'OperationError',
        'OperationErrors',
        'Settings',
        'SslCert',
        'SslCertDetail',
        'SqlActiveDirectoryConfig',
        'SqlServerAuditConfig',
    },
)


class SqlFileType(proto.Enum):
    r""""""
    SQL_FILE_TYPE_UNSPECIFIED = 0
    SQL = 1
    CSV = 2
    BAK = 4


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
    POSTGRES_13 = 23
    SQLSERVER_2019_STANDARD = 26
    SQLSERVER_2019_ENTERPRISE = 27
    SQLSERVER_2019_EXPRESS = 28
    SQLSERVER_2019_WEB = 29


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


class AclEntry(proto.Message):
    r"""An entry for an Access Control list.

    Attributes:
        value (str):
            The allowlisted value for the access control
            list.
        expiration_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when this access control entry expires in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**.
        name (str):
            Optional. A label to identify this entry.
        kind (str):
            This is always **sql#aclEntry**.
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
        code (google.cloud.sql_v1.types.ApiWarning.SqlApiWarningCode):
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
        retention_unit (google.cloud.sql_v1.types.BackupRetentionSettings.RetentionUnit):
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
            Start time for the daily backup configuration in UTC
            timezone in the 24 hour format - **HH:MM**.
        enabled (google.protobuf.wrappers_pb2.BoolValue):
            Whether this configuration is enabled.
        kind (str):
            This is always **sql#backupConfiguration**.
        binary_log_enabled (google.protobuf.wrappers_pb2.BoolValue):
            (MySQL only) Whether binary log is enabled.
            If backup configuration is disabled, binarylog
            must be disabled as well.
        replication_log_archiving_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Reserved for future use.
        location (str):
            Location of the backup
        point_in_time_recovery_enabled (google.protobuf.wrappers_pb2.BoolValue):
            (Postgres only) Whether point in time
            recovery is enabled.
        backup_retention_settings (google.cloud.sql_v1.types.BackupRetentionSettings):
            Backup retention settings.
        transaction_log_retention_days (google.protobuf.wrappers_pb2.Int32Value):
            The number of days of transaction logs we
            retain for point in time restore, from 1-7.
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
    backup_retention_settings = proto.Field(
        proto.MESSAGE,
        number=8,
        message='BackupRetentionSettings',
    )
    transaction_log_retention_days = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.Int32Value,
    )


class BackupContext(proto.Message):
    r"""Backup context.

    Attributes:
        backup_id (int):
            The identifier of the backup.
        kind (str):
            This is always **sql#backupContext**.
    """

    backup_id = proto.Field(
        proto.INT64,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class Database(proto.Message):
    r"""Represents a SQL database on the Cloud SQL instance.

    Attributes:
        kind (str):
            This is always **sql#database**.
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
        sqlserver_database_details (google.cloud.sql_v1.types.SqlServerDatabaseDetails):

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
            The name of the flag. These flags are passed at instance
            startup, so include both server options and system
            variables. Flags are specified with underscores, not
            hyphens. For more information, see `Configuring Database
            Flags <https://cloud.google.com/sql/docs/mysql/flags>`__ in
            the Cloud SQL documentation.
        value (str):
            The value of the flag. Booleans are set to **on** for true
            and **off** for false. This field must be omitted if the
            flag doesn't take a value.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    value = proto.Field(
        proto.STRING,
        number=2,
    )


class MySqlSyncConfig(proto.Message):
    r"""MySQL-specific external server sync settings.

    Attributes:
        initial_sync_flags (Sequence[google.cloud.sql_v1.types.SyncFlags]):
            Flags to use for the initial dump.
    """

    initial_sync_flags = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='SyncFlags',
    )


class SyncFlags(proto.Message):
    r"""Initial sync flags for certain Cloud SQL APIs.
    Currently used for the MySQL external server initial dump.

    Attributes:
        name (str):
            The name of the flag.
        value (str):
            The value of the flag. This field must be
            omitted if the flag doesn't take a value.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    value = proto.Field(
        proto.STRING,
        number=2,
    )


class InstanceReference(proto.Message):
    r"""Reference to another Cloud SQL instance.

    Attributes:
        name (str):
            The name of the Cloud SQL instance being
            referenced. This does not include the project
            ID.
        region (str):
            The region of the Cloud SQL instance being
            referenced.
        project (str):
            The project ID of the Cloud SQL instance
            being referenced. The default is the same
            project ID as the instance references it.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    region = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class DemoteMasterConfiguration(proto.Message):
    r"""Read-replica configuration for connecting to the on-premises
    primary instance.

    Attributes:
        kind (str):
            This is always **sql#demoteMasterConfiguration**.
        mysql_replica_configuration (google.cloud.sql_v1.types.DemoteMasterMySqlReplicaConfiguration):
            MySQL specific configuration when replicating from a MySQL
            on-premises primary instance. Replication configuration
            information such as the username, password, certificates,
            and keys are not stored in the instance metadata. The
            configuration information is used only to set up the
            replication connection and is stored by MySQL in a file
            named **master.info** in the data directory.
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


class DemoteMasterMySqlReplicaConfiguration(proto.Message):
    r"""Read-replica configuration specific to MySQL databases.

    Attributes:
        kind (str):
            This is always
            **sql#demoteMasterMysqlReplicaConfiguration**.
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
            The path to the file in Google Cloud Storage where the
            export will be stored. The URI is in the form
            **gs://bucketName/fileName**. If the file already exists,
            the request succeeds, but the operation fails. If
            **fileType** is **SQL** and the filename ends with .gz, the
            contents are compressed.
        databases (Sequence[str]):
            Databases to be exported.

            -  **MySQL instances:** If **fileType** is **SQL** and no
               database is specified, all databases are exported, except
               for the **mysql** system database. If **fileType** is
               **CSV**, you can specify one database, either by using
               this property or by using the
               **csvExportOptions.selectQuery** property, which takes
               precedence over this property.
            -  **PostgreSQL instances:** You must specify one database
               to be exported. If **fileType** is **CSV**, this database
               must match the one specified in the
               **csvExportOptions.selectQuery** property.
            -  **SQL Server instances:** You must specify one database
               to be exported, and the **fileType** must be **BAK**.
        kind (str):
            This is always **sql#exportContext**.
        sql_export_options (google.cloud.sql_v1.types.ExportContext.SqlExportOptions):
            Options for exporting data as SQL statements.
        csv_export_options (google.cloud.sql_v1.types.ExportContext.SqlCsvExportOptions):
            Options for exporting data as CSV. **MySQL** and
            **PostgreSQL** instances only.
        file_type (google.cloud.sql_v1.types.SqlFileType):
            The file type for the specified uri.

            -  **SQL**: The file contains SQL statements.
            -  **CSV**: The file contains CSV data.
            -  **BAK**: The file contains backup data for a SQL Server
               instance.
        offload (google.protobuf.wrappers_pb2.BoolValue):
            Option for export offload.
    """

    class SqlCsvExportOptions(proto.Message):
        r"""

        Attributes:
            select_query (str):
                The select query used to extract the data.
            escape_character (str):
                Specifies the character that should appear
                before a data character that needs to be
                escaped.
            quote_character (str):
                Specifies the quoting character to be used
                when a data value is quoted.
            fields_terminated_by (str):
                Specifies the character that separates
                columns within each row (line) of the file.
            lines_terminated_by (str):
                This is used to separate lines. If a line
                does not contain all fields, the rest of the
                columns are set to their default values.
        """

        select_query = proto.Field(
            proto.STRING,
            number=1,
        )
        escape_character = proto.Field(
            proto.STRING,
            number=2,
        )
        quote_character = proto.Field(
            proto.STRING,
            number=3,
        )
        fields_terminated_by = proto.Field(
            proto.STRING,
            number=4,
        )
        lines_terminated_by = proto.Field(
            proto.STRING,
            number=6,
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
            mysql_export_options (google.cloud.sql_v1.types.ExportContext.SqlExportOptions.MysqlExportOptions):

        """

        class MysqlExportOptions(proto.Message):
            r"""Options for exporting from MySQL.

            Attributes:
                master_data (google.protobuf.wrappers_pb2.Int32Value):
                    Option to include SQL statement required to set up
                    replication.

                    -  If set to **1**, the dump file includes a CHANGE MASTER
                       TO statement with the binary log coordinates, and
                       --set-gtid-purged is set to ON.
                    -  If set to **2**, the CHANGE MASTER TO statement is
                       written as a SQL comment and has no effect.
                    -  If set to any value other than **1**, --set-gtid-purged
                       is set to OFF.
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


class ImportContext(proto.Message):
    r"""Database instance import context.

    Attributes:
        uri (str):
            Path to the import file in Cloud Storage, in the form
            **gs://bucketName/fileName**. Compressed gzip files (.gz)
            are supported when **fileType** is **SQL**. The instance
            must have write permissions to the bucket and read access to
            the file.
        database (str):
            The target database for the import. If **fileType** is
            **SQL**, this field is required only if the import file does
            not specify a database, and is overridden by any database
            specification in the import file. If **fileType** is
            **CSV**, one database must be specified.
        kind (str):
            This is always **sql#importContext**.
        file_type (google.cloud.sql_v1.types.SqlFileType):
            The file type for the specified uri. \ **SQL**: The file
            contains SQL statements. \ **CSV**: The file contains CSV
            data.
        csv_import_options (google.cloud.sql_v1.types.ImportContext.SqlCsvImportOptions):
            Options for importing data as CSV.
        import_user (str):
            The PostgreSQL user for this import
            operation. PostgreSQL instances only.
        bak_import_options (google.cloud.sql_v1.types.ImportContext.SqlBakImportOptions):
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
            escape_character (str):
                Specifies the character that should appear
                before a data character that needs to be
                escaped.
            quote_character (str):
                Specifies the quoting character to be used
                when a data value is quoted.
            fields_terminated_by (str):
                Specifies the character that separates
                columns within each row (line) of the file.
            lines_terminated_by (str):
                This is used to separate lines. If a line
                does not contain all fields, the rest of the
                columns are set to their default values.
        """

        table = proto.Field(
            proto.STRING,
            number=1,
        )
        columns = proto.RepeatedField(
            proto.STRING,
            number=2,
        )
        escape_character = proto.Field(
            proto.STRING,
            number=4,
        )
        quote_character = proto.Field(
            proto.STRING,
            number=5,
        )
        fields_terminated_by = proto.Field(
            proto.STRING,
            number=6,
        )
        lines_terminated_by = proto.Field(
            proto.STRING,
            number=8,
        )

    class SqlBakImportOptions(proto.Message):
        r"""

        Attributes:
            encryption_options (google.cloud.sql_v1.types.ImportContext.SqlBakImportOptions.EncryptionOptions):

        """

        class EncryptionOptions(proto.Message):
            r"""

            Attributes:
                cert_path (str):
                    Path to the Certificate (.cer) in Cloud Storage, in the form
                    **gs://bucketName/fileName**. The instance must have write
                    permissions to the bucket and read access to the file.
                pvk_path (str):
                    Path to the Certificate Private Key (.pvk) in Cloud Storage,
                    in the form **gs://bucketName/fileName**. The instance must
                    have write permissions to the bucket and read access to the
                    file.
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


class IpConfiguration(proto.Message):
    r"""IP Management configuration.

    Attributes:
        ipv4_enabled (google.protobuf.wrappers_pb2.BoolValue):
            Whether the instance is assigned a public IP
            address or not.
        private_network (str):
            The resource link for the VPC network from which the Cloud
            SQL instance is accessible for private IP. For example,
            **/projects/myProject/global/networks/default**. This
            setting can be updated, but it cannot be removed after it is
            set.
        require_ssl (google.protobuf.wrappers_pb2.BoolValue):
            Whether SSL connections over IP are enforced
            or not.
        authorized_networks (Sequence[google.cloud.sql_v1.types.AclEntry]):
            The list of external networks that are allowed to connect to
            the instance using the IP. In 'CIDR' notation, also known as
            'slash' notation (for example: **192.168.100.0/24**).
        allocated_ip_range (str):
            The name of the allocated ip range for the private ip
            CloudSQL instance. For example:
            "google-managed-services-default". If set, the instance ip
            will be created in the allocated range. The range name must
            comply with `RFC
            1035 <https://tools.ietf.org/html/rfc1035>`__. Specifically,
            the name must be 1-63 characters long and match the regular
            expression ``[a-z]([-a-z0-9]*[a-z0-9])?.`` Reserved for
            future use.
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
    allocated_ip_range = proto.Field(
        proto.STRING,
        number=6,
    )


class LocationPreference(proto.Message):
    r"""Preferred location. This specifies where a Cloud SQL instance
    is located. Note that if the preferred location is not
    available, the instance will be located as close as possible
    within the region. Only one location may be specified.

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
            This is always **sql#locationPreference**.
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
        update_track (google.cloud.sql_v1.types.SqlUpdateTrack):
            Maintenance timing setting: **canary** (Earlier) or
            **stable** (Later). `Learn
            more <https://cloud.google.com/sql/docs/mysql/instance-settings#maintenance-timing-2ndgen>`__.
        kind (str):
            This is always **sql#maintenanceWindow**.
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
    r"""Deny maintenance Periods. This specifies a date range during
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
            means the no maintenance interval recurs every
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
            Number of query execution plans captured by
            Insights per minute for all queries combined.
            Default is 5.
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
            This is always **sql#mysqlReplicaConfiguration**.
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


class DiskEncryptionConfiguration(proto.Message):
    r"""Disk encryption configuration for an instance.

    Attributes:
        kms_key_name (str):
            Resource name of KMS key for disk encryption
        kind (str):
            This is always **sql#diskEncryptionConfiguration**.
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
            This is always **sql#diskEncryptionStatus**.
    """

    kms_key_version_name = proto.Field(
        proto.STRING,
        number=1,
    )
    kind = proto.Field(
        proto.STRING,
        number=2,
    )


class IpMapping(proto.Message):
    r"""Database instance IP Mapping.

    Attributes:
        type_ (google.cloud.sql_v1.types.SqlIpAddressType):
            The type of this IP address. A **PRIMARY** address is a
            public address that can accept incoming connections. A
            **PRIVATE** address is a private address that can accept
            incoming connections. An **OUTGOING** address is the source
            address of connections originating from the instance, if
            supported.
        ip_address (str):
            The IP address assigned.
        time_to_retire (google.protobuf.timestamp_pb2.Timestamp):
            The due time for this IP to be retired in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**. This field is only
            available when the IP is scheduled to be retired.
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


class Operation(proto.Message):
    r"""An Operation resource.&nbsp;For successful operations that
    return an Operation resource, only the fields relevant to the
    operation are populated in the resource.

    Attributes:
        kind (str):
            This is always **sql#operation**.
        target_link (str):

        status (google.cloud.sql_v1.types.Operation.SqlOperationStatus):
            The status of an operation. Valid values are:

            -  **PENDING**
            -  **RUNNING**
            -  **DONE**
            -  **SQL_OPERATION_STATUS_UNSPECIFIED**
        user (str):
            The email address of the user who initiated
            this operation.
        insert_time (google.protobuf.timestamp_pb2.Timestamp):
            The time this operation was enqueued in UTC timezone in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**.
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            The time this operation actually started in UTC timezone in
            `RFC 3339 <https://tools.ietf.org/html/rfc3339>`__ format,
            for example **2012-11-15T16:19:00.094Z**.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            The time this operation finished in UTC timezone in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**.
        error (google.cloud.sql_v1.types.OperationErrors):
            If errors occurred during processing of this
            operation, this field will be populated.
        operation_type (google.cloud.sql_v1.types.Operation.SqlOperationType):
            The type of the operation. Valid values are:

            -  **CREATE**
            -  **DELETE**
            -  **UPDATE**
            -  **RESTART**
            -  **IMPORT**
            -  **EXPORT**
            -  **BACKUP_VOLUME**
            -  **RESTORE_VOLUME**
            -  **CREATE_USER**
            -  **DELETE_USER**
            -  **CREATE_DATABASE**
            -  **DELETE_DATABASE**
        import_context (google.cloud.sql_v1.types.ImportContext):
            The context for import operation, if
            applicable.
        export_context (google.cloud.sql_v1.types.ExportContext):
            The context for export operation, if
            applicable.
        backup_context (google.cloud.sql_v1.types.BackupContext):
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
            This is always **sql#operationError**.
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
            This is always **sql#operationErrors**.
        errors (Sequence[google.cloud.sql_v1.types.OperationError]):
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
            The tier (or machine type) for this instance, for example
            **db-custom-1-3840**.
        kind (str):
            This is always **sql#settings**.
        user_labels (Sequence[google.cloud.sql_v1.types.Settings.UserLabelsEntry]):
            User-provided labels, represented as a
            dictionary where each label is a single key
            value pair.
        availability_type (google.cloud.sql_v1.types.SqlAvailabilityType):
            Availability type. Potential values:

            -  **ZONAL**: The instance serves data from only one zone.
               Outages in that zone affect data accessibility.
            -  **REGIONAL**: The instance can serve data from more than
               one zone in a region (it is highly available)./

            For more information, see `Overview of the High Availability
            Configuration <https://cloud.google.com/sql/docs/mysql/high-availability>`__.
        pricing_plan (google.cloud.sql_v1.types.SqlPricingPlan):
            The pricing plan for this instance. This can be either
            **PER_USE** or **PACKAGE**. Only **PER_USE** is supported
            for Second Generation instances.
        replication_type (google.cloud.sql_v1.types.SqlReplicationType):
            The type of replication this instance uses. This can be
            either **ASYNCHRONOUS** or **SYNCHRONOUS**. (Deprecated)
            This property was only applicable to First Generation
            instances.
        storage_auto_resize_limit (google.protobuf.wrappers_pb2.Int64Value):
            The maximum size to which storage capacity
            can be automatically increased. The default
            value is 0, which specifies that there is no
            limit.
        activation_policy (google.cloud.sql_v1.types.Settings.SqlActivationPolicy):
            The activation policy specifies when the instance is
            activated; it is applicable only when the instance state is
            RUNNABLE. Valid values:

            -  **ALWAYS**: The instance is on, and remains so even in
               the absence of connection requests.
            -  **NEVER**: The instance is off; it is not activated, even
               if a connection request arrives.
        ip_configuration (google.cloud.sql_v1.types.IpConfiguration):
            The settings for IP Management. This allows
            to enable or disable the instance IP and manage
            which external networks can connect to the
            instance. The IPv4 address cannot be disabled
            for Second Generation instances.
        storage_auto_resize (google.protobuf.wrappers_pb2.BoolValue):
            Configuration to increase storage size
            automatically. The default value is true.
        location_preference (google.cloud.sql_v1.types.LocationPreference):
            The location preference settings. This allows
            the instance to be located as near as possible
            to either an App Engine app or Compute Engine
            zone for better performance. App Engine co-
            location was only applicable to First Generation
            instances.
        database_flags (Sequence[google.cloud.sql_v1.types.DatabaseFlags]):
            The database flags passed to the instance at
            startup.
        data_disk_type (google.cloud.sql_v1.types.SqlDataDiskType):
            The type of data disk: **PD_SSD** (default) or **PD_HDD**.
            Not used for First Generation instances.
        maintenance_window (google.cloud.sql_v1.types.MaintenanceWindow):
            The maintenance window for this instance.
            This specifies when the instance can be
            restarted for maintenance purposes.
        backup_configuration (google.cloud.sql_v1.types.BackupConfiguration):
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
        active_directory_config (google.cloud.sql_v1.types.SqlActiveDirectoryConfig):
            Active Directory configuration, relevant only
            for Cloud SQL for SQL Server.
        collation (str):
            The name of server Instance collation.
        deny_maintenance_periods (Sequence[google.cloud.sql_v1.types.DenyMaintenancePeriod]):
            Deny maintenance periods
        insights_config (google.cloud.sql_v1.types.InsightsConfig):
            Insights configuration, for now relevant only
            for Postgres.
        sql_server_audit_config (google.cloud.sql_v1.types.SqlServerAuditConfig):
            SQL Server specific audit configuration.
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
    sql_server_audit_config = proto.Field(
        proto.MESSAGE,
        number=29,
        message='SqlServerAuditConfig',
    )


class SslCert(proto.Message):
    r"""SslCerts Resource

    Attributes:
        kind (str):
            This is always **sql#sslCert**.
        cert_serial_number (str):
            Serial number, as extracted from the
            certificate.
        cert (str):
            PEM representation.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when the certificate was created in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**
        common_name (str):
            User supplied name. Constrained to [a-zA-Z.-\_ ]+.
        expiration_time (google.protobuf.timestamp_pb2.Timestamp):
            The time when the certificate expires in `RFC
            3339 <https://tools.ietf.org/html/rfc3339>`__ format, for
            example **2012-11-15T16:19:00.094Z**.
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
        cert_info (google.cloud.sql_v1.types.SslCert):
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


class SqlServerAuditConfig(proto.Message):
    r"""SQL Server specific audit configuration.

    Attributes:
        kind (str):
            This is always sql#sqlServerAuditConfig
        bucket (str):
            The name of the destination bucket (e.g.,
            gs://mybucket).
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    bucket = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
