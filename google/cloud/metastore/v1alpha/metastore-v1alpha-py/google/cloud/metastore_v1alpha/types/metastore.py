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


from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.metastore.v1alpha',
    manifest={
        'Service',
        'HiveMetastoreConfig',
        'KerberosConfig',
        'Secret',
        'MetadataImport',
        'ListServicesRequest',
        'ListServicesResponse',
        'GetServiceRequest',
        'CreateServiceRequest',
        'UpdateServiceRequest',
        'DeleteServiceRequest',
        'ListMetadataImportsRequest',
        'ListMetadataImportsResponse',
        'GetMetadataImportRequest',
        'CreateMetadataImportRequest',
        'UpdateMetadataImportRequest',
        'OperationMetadata',
        'LocationMetadata',
    },
)


class Service(proto.Message):
    r"""A managed metastore service that serves metadata queries.

    Attributes:
        name (str):
            Immutable. The relative resource name of the metastore
            service, of the form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}".
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time when the metastore
            service was created.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time when the metastore
            service was last updated.
        labels (Sequence[google.cloud.metastore_v1alpha.types.Service.LabelsEntry]):
            User-defined labels for the metastore
            service.
        hive_metastore_config (google.cloud.metastore_v1alpha.types.HiveMetastoreConfig):
            Configuration information specific to running
            Hive metastore software as the metastore
            service.
        network (str):
            Immutable. The relative resource name of the VPC network on
            which the instance can be accessed. The network must belong
            to the same project as the metastore instance. It is
            specified in the following form:

            "projects/{project_id}/global/networks/{network_id}".
        endpoint_uri (str):
            Output only. The URI of the endpoint used to
            access the metastore service.
        port (int):
            The TCP port at which the metastore service
            is reached. Default: 9083.
        state (google.cloud.metastore_v1alpha.types.Service.State):
            Output only. The current state of the
            metastore service.
        state_message (str):
            Output only. Additional information about the
            current state of the metastore service, if
            available.
        artifact_gcs_uri (str):
            Output only. A Cloud Storage URI (starting with ``gs://``)
            that specifies where artifacts related to the metastore
            service are stored.
        tier (google.cloud.metastore_v1alpha.types.Service.Tier):
            The tier of the service.
    """
    class State(proto.Enum):
        r"""The current state of the metastore service."""
        STATE_UNSPECIFIED = 0
        CREATING = 1
        ACTIVE = 2
        SUSPENDING = 3
        SUSPENDED = 4
        UPDATING = 5
        DELETING = 6
        ERROR = 7

    class Tier(proto.Enum):
        r"""Available service tiers."""
        TIER_UNSPECIFIED = 0
        ENTERPRISE = 3

    name = proto.Field(proto.STRING, number=1)

    create_time = proto.Field(proto.MESSAGE, number=2,
        message=timestamp.Timestamp,
    )

    update_time = proto.Field(proto.MESSAGE, number=3,
        message=timestamp.Timestamp,
    )

    labels = proto.MapField(proto.STRING, proto.STRING, number=4)

    hive_metastore_config = proto.Field(proto.MESSAGE, number=5, oneof='metastore_config',
        message='HiveMetastoreConfig',
    )

    network = proto.Field(proto.STRING, number=7)

    endpoint_uri = proto.Field(proto.STRING, number=8)

    port = proto.Field(proto.INT32, number=9)

    state = proto.Field(proto.ENUM, number=10,
        enum=State,
    )

    state_message = proto.Field(proto.STRING, number=11)

    artifact_gcs_uri = proto.Field(proto.STRING, number=12)

    tier = proto.Field(proto.ENUM, number=13,
        enum=Tier,
    )


class HiveMetastoreConfig(proto.Message):
    r"""Specifies configuration information specific to running Hive
    metastore software as the metastore service.

    Attributes:
        version (str):
            Immutable. The Hive metastore schema version.
        config_overrides (Sequence[google.cloud.metastore_v1alpha.types.HiveMetastoreConfig.ConfigOverridesEntry]):
            A mapping of Hive metastore configuration key-value pairs to
            apply to the Hive metastore (configured in
            ``hive-site.xml``). The mappings override system defaults
            (some keys cannot be overridden).
        kerberos_config (google.cloud.metastore_v1alpha.types.KerberosConfig):
            Information used to configure the Hive
            metastore service as a service principal in a
            Kerberos realm.
    """

    version = proto.Field(proto.STRING, number=1)

    config_overrides = proto.MapField(proto.STRING, proto.STRING, number=2)

    kerberos_config = proto.Field(proto.MESSAGE, number=3,
        message='KerberosConfig',
    )


class KerberosConfig(proto.Message):
    r"""Configuration information for a Kerberos principal.

    Attributes:
        keytab (google.cloud.metastore_v1alpha.types.Secret):
            A Kerberos keytab file that can be used to
            authenticate a service principal with a Kerberos
            Key Distribution Center (KDC).
        principal (str):
            A Kerberos principal that exists in the both
            the keytab the KDC to authenticate as. A typical
            principal is of the form
            "primary/instance@REALM", but there is no exact
            format.
        krb5_config_gcs_uri (str):
            A Cloud Storage URI that specifies the path to a krb5.conf
            file. It is of the form
            gs://{bucket_name}/path/to/krb5.conf, although the file does
            not need to be named krb5.conf explicitly.
    """

    keytab = proto.Field(proto.MESSAGE, number=1,
        message='Secret',
    )

    principal = proto.Field(proto.STRING, number=2)

    krb5_config_gcs_uri = proto.Field(proto.STRING, number=3)


class Secret(proto.Message):
    r"""A securely stored value.

    Attributes:
        cloud_secret (str):
            The relative resource name of a Secret Manager secret
            version, in the following form:

            "projects/{project_id}/secrets/{secret_id}/versions/{version_id}".
    """

    cloud_secret = proto.Field(proto.STRING, number=2, oneof='value')


class MetadataImport(proto.Message):
    r"""A metastore resource that imports metadata.

    Attributes:
        name (str):
            Immutable. The relative resource name of the metadata
            import, of the form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{metadata_import_id}".
        description (str):
            The description of the metadata import.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time when the metadata
            import was created.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time when the metadata
            import was last updated.
        state (google.cloud.metastore_v1alpha.types.MetadataImport.State):
            Output only. The current state of the
            metadata import.
        database_dump (google.cloud.metastore_v1alpha.types.MetadataImport.DatabaseDump):
            Immutable. A database dump from a pre-
            xisting metastore's database.
    """
    class State(proto.Enum):
        r"""The current state of the metadata import."""
        STATE_UNSPECIFIED = 0
        RUNNING = 1
        SUCCEEDED = 2
        UPDATING = 3
        FAILED = 4

    class DatabaseDump(proto.Message):
        r"""A specification of the location of and metadata about a
        database dump from a relational database management system.

        Attributes:
            database_type (google.cloud.metastore_v1alpha.types.MetadataImport.DatabaseDump.DatabaseType):
                The type of the database.
            gcs_uri (str):
                A Cloud Storage object URI that specifies the source from
                which to import metadata. It must begin with ``gs://``.
            source_database (str):
                The name of the source database.
        """
        class DatabaseType(proto.Enum):
            r"""The type of the database."""
            DATABASE_TYPE_UNSPECIFIED = 0
            MYSQL = 1

        database_type = proto.Field(proto.ENUM, number=1,
            enum='MetadataImport.DatabaseDump.DatabaseType',
        )

        gcs_uri = proto.Field(proto.STRING, number=2)

        source_database = proto.Field(proto.STRING, number=3)

    name = proto.Field(proto.STRING, number=1)

    description = proto.Field(proto.STRING, number=2)

    create_time = proto.Field(proto.MESSAGE, number=3,
        message=timestamp.Timestamp,
    )

    update_time = proto.Field(proto.MESSAGE, number=4,
        message=timestamp.Timestamp,
    )

    state = proto.Field(proto.ENUM, number=5,
        enum=State,
    )

    database_dump = proto.Field(proto.MESSAGE, number=6, oneof='metadata',
        message=DatabaseDump,
    )


class ListServicesRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.ListServices][google.cloud.metastore.v1alpha.DataprocMetastore.ListServices].

    Attributes:
        parent (str):
            Required. The relative resource name of the location of
            metastore services to list, in the following form:

            "projects/{project_id}/locations/{location_id}".
        page_size (int):
            Optional. The maximum number of services to
            return. The response may contain less than the
            maximum number. If unspecified, no more than 500
            services are returned. The maximum value is
            1000; values above 1000 are changed to 1000.
        page_token (str):
            Optional. A page token, received from a previous
            [DataprocMetastore.ListServices][google.cloud.metastore.v1alpha.DataprocMetastore.ListServices]
            call. Provide this token to retrieve the subsequent page.

            To retrieve the first page, supply an empty page token.

            When paginating, other parameters provided to
            [DataprocMetastore.ListServices][google.cloud.metastore.v1alpha.DataprocMetastore.ListServices]
            must match the call that provided the page token.
        filter (str):
            Optional. The filter to apply to list
            results.
        order_by (str):
            Optional. Specify the ordering of results as described in
            `Sorting
            Order </apis/design/design_patterns#sorting_order>`__. If
            not specified, the results will be sorted in the default
            order.
    """

    parent = proto.Field(proto.STRING, number=1)

    page_size = proto.Field(proto.INT32, number=2)

    page_token = proto.Field(proto.STRING, number=3)

    filter = proto.Field(proto.STRING, number=4)

    order_by = proto.Field(proto.STRING, number=5)


class ListServicesResponse(proto.Message):
    r"""Response message for
    [DataprocMetastore.ListServices][google.cloud.metastore.v1alpha.DataprocMetastore.ListServices].

    Attributes:
        services (Sequence[google.cloud.metastore_v1alpha.types.Service]):
            The services in the specified location.
        next_page_token (str):
            A token that can be sent as ``page_token`` to retrieve the
            next page. If this field is omitted, there are no subsequent
            pages.
        unreachable (Sequence[str]):
            Locations that could not be reached.
    """

    @property
    def raw_page(self):
        return self

    services = proto.RepeatedField(proto.MESSAGE, number=1,
        message='Service',
    )

    next_page_token = proto.Field(proto.STRING, number=2)

    unreachable = proto.RepeatedField(proto.STRING, number=3)


class GetServiceRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.GetService][google.cloud.metastore.v1alpha.DataprocMetastore.GetService].

    Attributes:
        name (str):
            Required. The relative resource name of the metastore
            service to retrieve, in the following form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}".
    """

    name = proto.Field(proto.STRING, number=1)


class CreateServiceRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.CreateService][google.cloud.metastore.v1alpha.DataprocMetastore.CreateService].

    Attributes:
        parent (str):
            Required. The relative resource name of the location in
            which to create a metastore service, in the following form:

            "projects/{project_id}/locations/{location_id}".
        service_id (str):
            Required. The ID of the metastore service,
            which is used as the final component of the
            metastore service's name.
            This value must be between 1 and 64 characters
            long, begin with a letter, end with a letter or
            number, and consist of alpha-numeric ASCII
            characters or hyphens.
        service (google.cloud.metastore_v1alpha.types.Service):
            Required. The Metastore service to create. The ``name``
            field is ignored. The ID of the created metastore service
            must be provided in the request's ``service_id`` field.
        request_id (str):
            Optional. A request ID. Specify a unique request ID to allow
            the server to ignore the request if it has completed. The
            server will ignore subsequent requests that provide a
            duplicate request ID for at least 60 minutes after the first
            request.

            For example, if an initial request times out, followed by
            another request with the same request ID, the server ignores
            the second request to prevent the creation of duplicate
            commitments.

            The request ID must be a valid
            `UUID <https://en.wikipedia.org/wiki/Universally_unique_identifier#Format>`__
            A zero UUID (00000000-0000-0000-0000-000000000000) is not
            supported.
    """

    parent = proto.Field(proto.STRING, number=1)

    service_id = proto.Field(proto.STRING, number=2)

    service = proto.Field(proto.MESSAGE, number=3,
        message='Service',
    )

    request_id = proto.Field(proto.STRING, number=4)


class UpdateServiceRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.UpdateService][google.cloud.metastore.v1alpha.DataprocMetastore.UpdateService].

    Attributes:
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. A field mask used to specify the fields to be
            overwritten in the metastore service resource by the update.
            Fields specified in the ``update_mask`` are relative to the
            resource (not to the full request). A field is overwritten
            if it is in the mask.
        service (google.cloud.metastore_v1alpha.types.Service):
            Required. The metastore service to update. The server only
            merges fields in the service if they are specified in
            ``update_mask``.

            The metastore service's ``name`` field is used to identify
            the metastore service to be updated.
        request_id (str):
            Optional. A request ID. Specify a unique request ID to allow
            the server to ignore the request if it has completed. The
            server will ignore subsequent requests that provide a
            duplicate request ID for at least 60 minutes after the first
            request.

            For example, if an initial request times out, followed by
            another request with the same request ID, the server ignores
            the second request to prevent the creation of duplicate
            commitments.

            The request ID must be a valid
            `UUID <https://en.wikipedia.org/wiki/Universally_unique_identifier#Format>`__
            A zero UUID (00000000-0000-0000-0000-000000000000) is not
            supported.
    """

    update_mask = proto.Field(proto.MESSAGE, number=1,
        message=field_mask.FieldMask,
    )

    service = proto.Field(proto.MESSAGE, number=2,
        message='Service',
    )

    request_id = proto.Field(proto.STRING, number=3)


class DeleteServiceRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.DeleteService][google.cloud.metastore.v1alpha.DataprocMetastore.DeleteService].

    Attributes:
        name (str):
            Required. The relative resource name of the metastore
            service to delete, in the following form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}".
        request_id (str):
            Optional. A request ID. Specify a unique request ID to allow
            the server to ignore the request if it has completed. The
            server will ignore subsequent requests that provide a
            duplicate request ID for at least 60 minutes after the first
            request.

            For example, if an initial request times out, followed by
            another request with the same request ID, the server ignores
            the second request to prevent the creation of duplicate
            commitments.

            The request ID must be a valid
            `UUID <https://en.wikipedia.org/wiki/Universally_unique_identifier#Format>`__
            A zero UUID (00000000-0000-0000-0000-000000000000) is not
            supported.
    """

    name = proto.Field(proto.STRING, number=1)

    request_id = proto.Field(proto.STRING, number=2)


class ListMetadataImportsRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.ListMetadataImports][google.cloud.metastore.v1alpha.DataprocMetastore.ListMetadataImports].

    Attributes:
        parent (str):
            Required. The relative resource name of the service whose
            metadata imports to list, in the following form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports".
        page_size (int):
            Optional. The maximum number of imports to
            return. The response may contain less than the
            maximum number. If unspecified, no more than 500
            imports are returned. The maximum value is 1000;
            values above 1000 are changed to 1000.
        page_token (str):
            Optional. A page token, received from a previous
            [DataprocMetastore.ListServices][google.cloud.metastore.v1alpha.DataprocMetastore.ListServices]
            call. Provide this token to retrieve the subsequent page.

            To retrieve the first page, supply an empty page token.

            When paginating, other parameters provided to
            [DataprocMetastore.ListServices][google.cloud.metastore.v1alpha.DataprocMetastore.ListServices]
            must match the call that provided the page token.
        filter (str):
            Optional. The filter to apply to list
            results.
        order_by (str):
            Optional. Specify the ordering of results as described in
            `Sorting
            Order </apis/design/design_patterns#sorting_order>`__. If
            not specified, the results will be sorted in the default
            order.
    """

    parent = proto.Field(proto.STRING, number=1)

    page_size = proto.Field(proto.INT32, number=2)

    page_token = proto.Field(proto.STRING, number=3)

    filter = proto.Field(proto.STRING, number=4)

    order_by = proto.Field(proto.STRING, number=5)


class ListMetadataImportsResponse(proto.Message):
    r"""Response message for
    [DataprocMetastore.ListMetadataImports][google.cloud.metastore.v1alpha.DataprocMetastore.ListMetadataImports].

    Attributes:
        metadata_imports (Sequence[google.cloud.metastore_v1alpha.types.MetadataImport]):
            The imports in the specified service.
        next_page_token (str):
            A token that can be sent as ``page_token`` to retrieve the
            next page. If this field is omitted, there are no subsequent
            pages.
        unreachable (Sequence[str]):
            Locations that could not be reached.
    """

    @property
    def raw_page(self):
        return self

    metadata_imports = proto.RepeatedField(proto.MESSAGE, number=1,
        message='MetadataImport',
    )

    next_page_token = proto.Field(proto.STRING, number=2)

    unreachable = proto.RepeatedField(proto.STRING, number=3)


class GetMetadataImportRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.GetMetadataImport][google.cloud.metastore.v1alpha.DataprocMetastore.GetMetadataImport].

    Attributes:
        name (str):
            Required. The relative resource name of the metadata import
            to retrieve, in the following form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}".
    """

    name = proto.Field(proto.STRING, number=1)


class CreateMetadataImportRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.CreateMetadataImport][google.cloud.metastore.v1alpha.DataprocMetastore.CreateMetadataImport].

    Attributes:
        parent (str):
            Required. The relative resource name of the service in which
            to create a metastore import, in the following form:

            "projects/{project_id}/locations/{location_id}/services/{service_id}".
        metadata_import_id (str):
            Required. The ID of the metadata import,
            which is used as the final component of the
            metadata import's name.
            This value must be between 1 and 64 characters
            long, begin with a letter, end with a letter or
            number, and consist of alpha-numeric ASCII
            characters or hyphens.
        metadata_import (google.cloud.metastore_v1alpha.types.MetadataImport):
            Required. The metadata import to create. The ``name`` field
            is ignored. The ID of the created metadata import must be
            provided in the request's ``metadata_import_id`` field.
        request_id (str):
            Optional. A request ID. Specify a unique request ID to allow
            the server to ignore the request if it has completed. The
            server will ignore subsequent requests that provide a
            duplicate request ID for at least 60 minutes after the first
            request.

            For example, if an initial request times out, followed by
            another request with the same request ID, the server ignores
            the second request to prevent the creation of duplicate
            commitments.

            The request ID must be a valid
            `UUID <https://en.wikipedia.org/wiki/Universally_unique_identifier#Format>`__
            A zero UUID (00000000-0000-0000-0000-000000000000) is not
            supported.
    """

    parent = proto.Field(proto.STRING, number=1)

    metadata_import_id = proto.Field(proto.STRING, number=2)

    metadata_import = proto.Field(proto.MESSAGE, number=3,
        message='MetadataImport',
    )

    request_id = proto.Field(proto.STRING, number=4)


class UpdateMetadataImportRequest(proto.Message):
    r"""Request message for
    [DataprocMetastore.UpdateMetadataImport][google.cloud.metastore.v1alpha.DataprocMetastore.UpdateMetadataImport].

    Attributes:
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. A field mask used to specify the fields to be
            overwritten in the metadata import resource by the update.
            Fields specified in the ``update_mask`` are relative to the
            resource (not to the full request). A field is overwritten
            if it is in the mask.
        metadata_import (google.cloud.metastore_v1alpha.types.MetadataImport):
            Required. The metadata import to update. The server only
            merges fields in the import if they are specified in
            ``update_mask``.

            The metadata import's ``name`` field is used to identify the
            metastore import to be updated.
        request_id (str):
            Optional. A request ID. Specify a unique request ID to allow
            the server to ignore the request if it has completed. The
            server will ignore subsequent requests that provide a
            duplicate request ID for at least 60 minutes after the first
            request.

            For example, if an initial request times out, followed by
            another request with the same request ID, the server ignores
            the second request to prevent the creation of duplicate
            commitments.

            The request ID must be a valid
            `UUID <https://en.wikipedia.org/wiki/Universally_unique_identifier#Format>`__
            A zero UUID (00000000-0000-0000-0000-000000000000) is not
            supported.
    """

    update_mask = proto.Field(proto.MESSAGE, number=1,
        message=field_mask.FieldMask,
    )

    metadata_import = proto.Field(proto.MESSAGE, number=2,
        message='MetadataImport',
    )

    request_id = proto.Field(proto.STRING, number=3)


class OperationMetadata(proto.Message):
    r"""Represents the metadata of a long-running operation.

    Attributes:
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time the operation was
            created.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time the operation finished
            running.
        target (str):
            Output only. Server-defined resource path for
            the target of the operation.
        verb (str):
            Output only. Name of the verb executed by the
            operation.
        status_message (str):
            Output only. Human-readable status of the
            operation, if any.
        requested_cancellation (bool):
            Output only. Identifies whether the caller has requested
            cancellation of the operation. Operations that have
            successfully been cancelled have [Operation.error][] value
            with a [google.rpc.Status.code][google.rpc.Status.code] of
            1, corresponding to ``Code.CANCELLED``.
        api_version (str):
            Output only. API version used to start the
            operation.
    """

    create_time = proto.Field(proto.MESSAGE, number=1,
        message=timestamp.Timestamp,
    )

    end_time = proto.Field(proto.MESSAGE, number=2,
        message=timestamp.Timestamp,
    )

    target = proto.Field(proto.STRING, number=3)

    verb = proto.Field(proto.STRING, number=4)

    status_message = proto.Field(proto.STRING, number=5)

    requested_cancellation = proto.Field(proto.BOOL, number=6)

    api_version = proto.Field(proto.STRING, number=7)


class LocationMetadata(proto.Message):
    r"""Metadata about the service in a location.

    Attributes:
        supported_hive_metastore_versions (Sequence[google.cloud.metastore_v1alpha.types.LocationMetadata.HiveMetastoreVersion]):
            The versions of Hive Metastore that can be used when
            creating a new metastore service in this location. The
            server guarantees that exactly one ``HiveMetastoreVersion``
            in the list will set ``is_default``.
    """
    class HiveMetastoreVersion(proto.Message):
        r"""A specification of a supported version of the Hive Metastore
        software.

        Attributes:
            version (str):
                The semantic version of the Hive Metastore
                software.
            is_default (bool):
                Whether ``version`` will be chosen by the server if a
                metastore service is created with a ``HiveMetastoreConfig``
                that omits the ``version``.
        """

        version = proto.Field(proto.STRING, number=1)

        is_default = proto.Field(proto.BOOL, number=2)

    supported_hive_metastore_versions = proto.RepeatedField(proto.MESSAGE, number=1,
        message=HiveMetastoreVersion,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
