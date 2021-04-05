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


from google.cloud.bigquery.storage_v1alpha2.types import protobuf
from google.cloud.bigquery.storage_v1alpha2.types import stream
from google.cloud.bigquery.storage_v1alpha2.types import table
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore
from google.protobuf import wrappers_pb2 as wrappers  # type: ignore
from google.rpc import status_pb2 as status  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.bigquery.storage.v1alpha2',
    manifest={
        'CreateWriteStreamRequest',
        'AppendRowsRequest',
        'AppendRowsResponse',
        'GetWriteStreamRequest',
        'BatchCommitWriteStreamsRequest',
        'BatchCommitWriteStreamsResponse',
        'FinalizeWriteStreamRequest',
        'FinalizeWriteStreamResponse',
        'FlushRowsRequest',
        'FlushRowsResponse',
    },
)


class CreateWriteStreamRequest(proto.Message):
    r"""Request message for ``CreateWriteStream``.

    Attributes:
        parent (str):
            Required. Reference to the table to which the stream
            belongs, in the format of
            ``projects/{project}/datasets/{dataset}/tables/{table}``.
        write_stream (google.cloud.bigquery.storage_v1alpha2.types.WriteStream):
            Required. Stream to be created.
    """

    parent = proto.Field(proto.STRING, number=1)

    write_stream = proto.Field(proto.MESSAGE, number=2,
        message=stream.WriteStream,
    )


class AppendRowsRequest(proto.Message):
    r"""Request message for ``AppendRows``.

    Attributes:
        write_stream (str):
            Required. The stream that is the target of the append
            operation. This value must be specified for the initial
            request. If subsequent requests specify the stream name, it
            must equal to the value provided in the first request. To
            write to the \_default stream, populate this field with a
            string in the format
            ``projects/{project}/datasets/{dataset}/tables/{table}/_default``.
        offset (google.protobuf.wrappers_pb2.Int64Value):
            Optional. If present, the write is only performed if the
            next append offset is same as the provided value. If not
            present, the write is performed at the current end of
            stream. Specifying a value for this field is not allowed
            when calling AppendRows for the '_default' stream.
        proto_rows (google.cloud.bigquery.storage_v1alpha2.types.AppendRowsRequest.ProtoData):

        ignore_unknown_fields (bool):
            Only initial request setting is respected. If
            true, drop unknown input fields. Otherwise, the
            extra fields will cause append to fail. Default
            value is false.
    """
    class ProtoData(proto.Message):
        r"""

        Attributes:
            writer_schema (google.cloud.bigquery.storage_v1alpha2.types.ProtoSchema):
                Proto schema used to serialize the data.
            rows (google.cloud.bigquery.storage_v1alpha2.types.ProtoRows):
                Serialized row data in protobuf message
                format.
        """

        writer_schema = proto.Field(proto.MESSAGE, number=1,
            message=protobuf.ProtoSchema,
        )

        rows = proto.Field(proto.MESSAGE, number=2,
            message=protobuf.ProtoRows,
        )

    write_stream = proto.Field(proto.STRING, number=1)

    offset = proto.Field(proto.MESSAGE, number=2,
        message=wrappers.Int64Value,
    )

    proto_rows = proto.Field(proto.MESSAGE, number=4, oneof='rows',
        message=ProtoData,
    )

    ignore_unknown_fields = proto.Field(proto.BOOL, number=5)


class AppendRowsResponse(proto.Message):
    r"""Response message for ``AppendRows``.

    Attributes:
        offset (int):
            The row offset at which the last append
            occurred.
        error (google.rpc.status_pb2.Status):
            Error in case of append failure. If set, it means rows are
            not accepted into the system. Users can retry or continue
            with other requests within the same connection.
            ALREADY_EXISTS: happens when offset is specified, it means
            the row is already appended, it is safe to ignore this
            error. OUT_OF_RANGE: happens when offset is specified, it
            means the specified offset is beyond the end of the stream.
            INVALID_ARGUMENT: error caused by malformed request or data.
            RESOURCE_EXHAUSTED: request rejected due to throttling. Only
            happens when append without offset. ABORTED: request
            processing is aborted because of prior failures, request can
            be retried if previous failure is fixed. INTERNAL: server
            side errors that can be retried.
        updated_schema (google.cloud.bigquery.storage_v1alpha2.types.TableSchema):
            If backend detects a schema update, pass it
            to user so that user can use it to input new
            type of message. It will be empty when there is
            no schema updates.
    """

    offset = proto.Field(proto.INT64, number=1, oneof='response')

    error = proto.Field(proto.MESSAGE, number=2, oneof='response',
        message=status.Status,
    )

    updated_schema = proto.Field(proto.MESSAGE, number=3,
        message=table.TableSchema,
    )


class GetWriteStreamRequest(proto.Message):
    r"""Request message for ``GetWriteStreamRequest``.

    Attributes:
        name (str):
            Required. Name of the stream to get, in the form of
            ``projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}``.
    """

    name = proto.Field(proto.STRING, number=1)


class BatchCommitWriteStreamsRequest(proto.Message):
    r"""Request message for ``BatchCommitWriteStreams``.

    Attributes:
        parent (str):
            Required. Parent table that all the streams should belong
            to, in the form of
            ``projects/{project}/datasets/{dataset}/tables/{table}``.
        write_streams (Sequence[str]):
            Required. The group of streams that will be
            committed atomically.
    """

    parent = proto.Field(proto.STRING, number=1)

    write_streams = proto.RepeatedField(proto.STRING, number=2)


class BatchCommitWriteStreamsResponse(proto.Message):
    r"""Response message for ``BatchCommitWriteStreams``.

    Attributes:
        commit_time (google.protobuf.timestamp_pb2.Timestamp):
            The time at which streams were committed in
            microseconds granularity.
    """

    commit_time = proto.Field(proto.MESSAGE, number=1,
        message=timestamp.Timestamp,
    )


class FinalizeWriteStreamRequest(proto.Message):
    r"""Request message for invoking ``FinalizeWriteStream``.

    Attributes:
        name (str):
            Required. Name of the stream to finalize, in the form of
            ``projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}``.
    """

    name = proto.Field(proto.STRING, number=1)


class FinalizeWriteStreamResponse(proto.Message):
    r"""Response message for ``FinalizeWriteStream``.

    Attributes:
        row_count (int):
            Number of rows in the finalized stream.
    """

    row_count = proto.Field(proto.INT64, number=1)


class FlushRowsRequest(proto.Message):
    r"""Request message for ``FlushRows``.

    Attributes:
        write_stream (str):
            Required. The stream that is the target of
            the flush operation.
        offset (int):
            Ending offset of the flush operation. Rows
            before this offset(including this offset) will
            be flushed.
    """

    write_stream = proto.Field(proto.STRING, number=1)

    offset = proto.Field(proto.INT64, number=2)


class FlushRowsResponse(proto.Message):
    r"""Respond message for ``FlushRows``.

    Attributes:
        offset (int):
            The rows before this offset (including this
            offset) are flushed.
    """

    offset = proto.Field(proto.INT64, number=1)


__all__ = tuple(sorted(__protobuf__.manifest))
