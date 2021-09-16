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


__protobuf__ = proto.module(
    package='google.cloud.sql.v1',
    manifest={
        'GetConnectSettingsRequest',
        'ConnectSettings',
        'GenerateEphemeralCertRequest',
        'GenerateEphemeralCertResponse',
    },
)


class GetConnectSettingsRequest(proto.Message):
    r"""Connect settings retrieval request.
    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        read_time (google.protobuf.timestamp_pb2.Timestamp):
            Optional. Optional snapshot read timestamp to
            trade freshness for performance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    read_time = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )


class ConnectSettings(proto.Message):
    r"""Connect settings retrieval response.
    Attributes:
        kind (str):
            This is always ``sql#connectSettings``.
        server_ca_cert (google.cloud.sql_v1.types.SslCert):
            SSL configuration.
        ip_addresses (Sequence[google.cloud.sql_v1.types.IpMapping]):
            The assigned IP addresses for the instance.
        region (str):
            The cloud region for the instance. e.g. **us-central1**,
            **europe-west1**. The region cannot be changed after
            instance creation.
        database_version (google.cloud.sql_v1.types.SqlDatabaseVersion):
            The database engine type and version. The
            **databaseVersion** field cannot be changed after instance
            creation. MySQL instances: **MYSQL_8_0**, **MYSQL_5_7**
            (default), or **MYSQL_5_6**. PostgreSQL instances:
            **POSTGRES_9_6**, **POSTGRES_10**, **POSTGRES_11** or
            **POSTGRES_12** (default). SQL Server instances:
            **SQLSERVER_2017_STANDARD** (default),
            **SQLSERVER_2017_ENTERPRISE**, **SQLSERVER_2017_EXPRESS**,
            or **SQLSERVER_2017_WEB**.
        backend_type (google.cloud.sql_v1.types.SqlBackendType):
            **SECOND_GEN**: Cloud SQL database instance. **EXTERNAL**: A
            database server that is not managed by Google. This property
            is read-only; use the **tier** property in the **settings**
            object to determine the database type.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    server_ca_cert = proto.Field(
        proto.MESSAGE,
        number=2,
        message=cloud_sql_resources.SslCert,
    )
    ip_addresses = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=cloud_sql_resources.IpMapping,
    )
    region = proto.Field(
        proto.STRING,
        number=4,
    )
    database_version = proto.Field(
        proto.ENUM,
        number=31,
        enum=cloud_sql_resources.SqlDatabaseVersion,
    )
    backend_type = proto.Field(
        proto.ENUM,
        number=32,
        enum=cloud_sql_resources.SqlBackendType,
    )


class GenerateEphemeralCertRequest(proto.Message):
    r"""Ephemeral certificate creation request.
    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        public_key (str):
            PEM encoded public key to include in the
            signed certificate.
        access_token (str):
            Optional. Access token to include in the
            signed certificate.
        read_time (google.protobuf.timestamp_pb2.Timestamp):
            Optional. Optional snapshot read timestamp to
            trade freshness for performance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    public_key = proto.Field(
        proto.STRING,
        number=3,
    )
    access_token = proto.Field(
        proto.STRING,
        number=4,
    )
    read_time = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )


class GenerateEphemeralCertResponse(proto.Message):
    r"""Ephemeral certificate creation request.
    Attributes:
        ephemeral_cert (google.cloud.sql_v1.types.SslCert):
            Generated cert
    """

    ephemeral_cert = proto.Field(
        proto.MESSAGE,
        number=1,
        message=cloud_sql_resources.SslCert,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
