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


__protobuf__ = proto.module(
    package='google.cloud.asset.v1p7beta1',
    manifest={
        'ContentType',
        'ExportAssetsRequest',
        'ExportAssetsResponse',
        'OutputConfig',
        'OutputResult',
        'GcsOutputResult',
        'GcsDestination',
        'BigQueryDestination',
        'PartitionSpec',
    },
)


class ContentType(proto.Enum):
    r"""Asset content type."""
    CONTENT_TYPE_UNSPECIFIED = 0
    RESOURCE = 1
    IAM_POLICY = 2
    ORG_POLICY = 4
    ACCESS_POLICY = 5
    RELATIONSHIP = 7


class ExportAssetsRequest(proto.Message):
    r"""Export asset request.

    Attributes:
        parent (str):
            Required. The relative name of the root
            asset. This can only be an organization number
            (such as "organizations/123"), a project ID
            (such as "projects/my-project-id"), or a project
            number (such as "projects/12345"), or a folder
            number (such as "folders/123").
        read_time (google.protobuf.timestamp_pb2.Timestamp):
            Timestamp to take an asset snapshot. This can
            only be set to a timestamp between the current
            time and the current time minus 35 days
            (inclusive). If not specified, the current time
            will be used. Due to delays in resource data
            collection and indexing, there is a volatile
            window during which running the same query may
            get different results.
        asset_types (Sequence[str]):
            A list of asset types to take a snapshot for. For example:
            "compute.googleapis.com/Disk".

            Regular expressions are also supported. For example:

            -  "compute.googleapis.com.*" snapshots resources whose
               asset type starts with "compute.googleapis.com".
            -  ".*Instance" snapshots resources whose asset type ends
               with "Instance".
            -  ".*Instance.*" snapshots resources whose asset type
               contains "Instance".

            See `RE2 <https://github.com/google/re2/wiki/Syntax>`__ for
            all supported regular expression syntax. If the regular
            expression does not match any supported asset type, an
            INVALID_ARGUMENT error will be returned.

            If specified, only matching assets will be returned,
            otherwise, it will snapshot all asset types. See
            `Introduction to Cloud Asset
            Inventory <https://cloud.google.com/asset-inventory/docs/overview>`__
            for all supported asset types.
        content_type (google.cloud.asset_v1p7beta1.types.ContentType):
            Asset content type. If not specified, no
            content but the asset name will be returned.
        output_config (google.cloud.asset_v1p7beta1.types.OutputConfig):
            Required. Output configuration indicating
            where the results will be output to.
        relationship_types (Sequence[str]):
            A list of relationship types to export, for example:
            ``INSTANCE_TO_INSTANCEGROUP``. This field should only be
            specified if content_type=RELATIONSHIP. If specified, it
            will snapshot [asset_types]' specified relationships, or
            give errors if any relationship_types' supported types are
            not in [asset_types]. If not specified, it will snapshot all
            [asset_types]' supported relationships. An unspecified
            [asset_types] field means all supported asset_types. See
            `Introduction to Cloud Asset
            Inventory <https://cloud.google.com/asset-inventory/docs/overview>`__
            for all supported asset types and relationship types.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    read_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )
    asset_types = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    content_type = proto.Field(
        proto.ENUM,
        number=4,
        enum='ContentType',
    )
    output_config = proto.Field(
        proto.MESSAGE,
        number=5,
        message='OutputConfig',
    )
    relationship_types = proto.RepeatedField(
        proto.STRING,
        number=6,
    )


class ExportAssetsResponse(proto.Message):
    r"""The export asset response. This message is returned by the
    [google.longrunning.Operations.GetOperation][google.longrunning.Operations.GetOperation]
    method in the returned
    [google.longrunning.Operation.response][google.longrunning.Operation.response]
    field.

    Attributes:
        read_time (google.protobuf.timestamp_pb2.Timestamp):
            Time the snapshot was taken.
        output_config (google.cloud.asset_v1p7beta1.types.OutputConfig):
            Output configuration indicating where the
            results were output to.
        output_result (google.cloud.asset_v1p7beta1.types.OutputResult):
            Output result indicating where the assets were exported to.
            For example, a set of actual Google Cloud Storage object
            uris where the assets are exported to. The uris can be
            different from what [output_config] has specified, as the
            service will split the output object into multiple ones once
            it exceeds a single Google Cloud Storage object limit.
    """

    read_time = proto.Field(
        proto.MESSAGE,
        number=1,
        message=timestamp_pb2.Timestamp,
    )
    output_config = proto.Field(
        proto.MESSAGE,
        number=2,
        message='OutputConfig',
    )
    output_result = proto.Field(
        proto.MESSAGE,
        number=3,
        message='OutputResult',
    )


class OutputConfig(proto.Message):
    r"""Output configuration for export assets destination.

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        gcs_destination (google.cloud.asset_v1p7beta1.types.GcsDestination):
            Destination on Cloud Storage.

            This field is a member of `oneof`_ ``destination``.
        bigquery_destination (google.cloud.asset_v1p7beta1.types.BigQueryDestination):
            Destination on BigQuery. The output table
            stores the fields in asset proto as columns in
            BigQuery.

            This field is a member of `oneof`_ ``destination``.
    """

    gcs_destination = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='destination',
        message='GcsDestination',
    )
    bigquery_destination = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='destination',
        message='BigQueryDestination',
    )


class OutputResult(proto.Message):
    r"""Output result of export assets.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        gcs_result (google.cloud.asset_v1p7beta1.types.GcsOutputResult):
            Export result on Cloud Storage.

            This field is a member of `oneof`_ ``result``.
    """

    gcs_result = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='result',
        message='GcsOutputResult',
    )


class GcsOutputResult(proto.Message):
    r"""A Cloud Storage output result.

    Attributes:
        uris (Sequence[str]):
            List of uris of the Cloud Storage objects. Example:
            "gs://bucket_name/object_name".
    """

    uris = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


class GcsDestination(proto.Message):
    r"""A Cloud Storage location.

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        uri (str):
            The uri of the Cloud Storage object. It's the same uri that
            is used by gsutil. Example: "gs://bucket_name/object_name".
            See `Viewing and Editing Object
            Metadata <https://cloud.google.com/storage/docs/viewing-editing-metadata>`__
            for more information.

            This field is a member of `oneof`_ ``object_uri``.
        uri_prefix (str):
            The uri prefix of all generated Cloud Storage objects.
            Example: "gs://bucket_name/object_name_prefix". Each object
            uri is in format:
            "gs://bucket_name/object_name_prefix/{ASSET_TYPE}/{SHARD_NUMBER}
            and only contains assets for that type. starts from 0.
            Example:
            "gs://bucket_name/object_name_prefix/compute.googleapis.com/Disk/0"
            is the first shard of output objects containing all
            compute.googleapis.com/Disk assets. An INVALID_ARGUMENT
            error will be returned if file with the same name
            "gs://bucket_name/object_name_prefix" already exists.

            This field is a member of `oneof`_ ``object_uri``.
    """

    uri = proto.Field(
        proto.STRING,
        number=1,
        oneof='object_uri',
    )
    uri_prefix = proto.Field(
        proto.STRING,
        number=2,
        oneof='object_uri',
    )


class BigQueryDestination(proto.Message):
    r"""A BigQuery destination for exporting assets to.

    Attributes:
        dataset (str):
            Required. The BigQuery dataset in format
            "projects/projectId/datasets/datasetId", to which the
            snapshot result should be exported. If this dataset does not
            exist, the export call returns an INVALID_ARGUMENT error.
        table (str):
            Required. The BigQuery table to which the
            snapshot result should be written. If this table
            does not exist, a new table with the given name
            will be created.
        force (bool):
            If the destination table already exists and this flag is
            ``TRUE``, the table will be overwritten by the contents of
            assets snapshot. If the flag is ``FALSE`` or unset and the
            destination table already exists, the export call returns an
            INVALID_ARGUMEMT error.
        partition_spec (google.cloud.asset_v1p7beta1.types.PartitionSpec):
            [partition_spec] determines whether to export to partitioned
            table(s) and how to partition the data.

            If [partition_spec] is unset or
            [partition_spec.partition_key] is unset or
            ``PARTITION_KEY_UNSPECIFIED``, the snapshot results will be
            exported to non-partitioned table(s). [force] will decide
            whether to overwrite existing table(s).

            If [partition_spec] is specified. First, the snapshot
            results will be written to partitioned table(s) with two
            additional timestamp columns, readTime and requestTime, one
            of which will be the partition key. Secondly, in the case
            when any destination table already exists, it will first try
            to update existing table's schema as necessary by appending
            additional columns. Then, if [force] is ``TRUE``, the
            corresponding partition will be overwritten by the snapshot
            results (data in different partitions will remain intact);
            if [force] is unset or ``FALSE``, it will append the data.
            An error will be returned if the schema update or data
            appension fails.
        separate_tables_per_asset_type (bool):
            If this flag is ``TRUE``, the snapshot results will be
            written to one or multiple tables, each of which contains
            results of one asset type. The [force] and [partition_spec]
            fields will apply to each of them.

            Field [table] will be concatenated with "*" and the asset
            type names (see
            https://cloud.google.com/asset-inventory/docs/supported-asset-types
            for supported asset types) to construct per-asset-type table
            names, in which all non-alphanumeric characters like "." and
            "/" will be substituted by "*". Example: if field [table] is
            "mytable" and snapshot results contain
            "storage.googleapis.com/Bucket" assets, the corresponding
            table name will be "mytable_storage_googleapis_com_Bucket".
            If any of these tables does not exist, a new table with the
            concatenated name will be created.

            When [content_type] in the ExportAssetsRequest is
            ``RESOURCE``, the schema of each table will include
            RECORD-type columns mapped to the nested fields in the
            Asset.resource.data field of that asset type (up to the 15
            nested level BigQuery supports
            (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)).
            The fields in >15 nested levels will be stored in JSON
            format string as a child column of its parent RECORD column.

            If error occurs when exporting to any table, the whole
            export call will return an error but the export results that
            already succeed will persist. Example: if exporting to
            table_type_A succeeds when exporting to table_type_B fails
            during one export call, the results in table_type_A will
            persist and there will not be partial results persisting in
            a table.
    """

    dataset = proto.Field(
        proto.STRING,
        number=1,
    )
    table = proto.Field(
        proto.STRING,
        number=2,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    partition_spec = proto.Field(
        proto.MESSAGE,
        number=4,
        message='PartitionSpec',
    )
    separate_tables_per_asset_type = proto.Field(
        proto.BOOL,
        number=5,
    )


class PartitionSpec(proto.Message):
    r"""Specifications of BigQuery partitioned table as export
    destination.

    Attributes:
        partition_key (google.cloud.asset_v1p7beta1.types.PartitionSpec.PartitionKey):
            The partition key for BigQuery partitioned
            table.
    """
    class PartitionKey(proto.Enum):
        r"""This enum is used to determine the partition key column when
        exporting assets to BigQuery partitioned table(s). Note that, if the
        partition key is a timestamp column, the actual partition is based
        on its date value (expressed in UTC. see details in
        https://cloud.google.com/bigquery/docs/partitioned-tables#date_timestamp_partitioned_tables).
        """
        PARTITION_KEY_UNSPECIFIED = 0
        READ_TIME = 1
        REQUEST_TIME = 2

    partition_key = proto.Field(
        proto.ENUM,
        number=1,
        enum=PartitionKey,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
