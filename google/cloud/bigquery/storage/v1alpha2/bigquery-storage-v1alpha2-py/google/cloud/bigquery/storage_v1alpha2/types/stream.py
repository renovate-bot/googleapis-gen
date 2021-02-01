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


from google.cloud.bigquery.storage_v1alpha2.types import table
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.bigquery.storage.v1alpha2',
    manifest={
        'WriteStream',
    },
)


class WriteStream(proto.Message):
    r"""Information about a single stream that gets data inside the
    storage system.

    Attributes:
        name (str):
            Output only. Name of the stream, in the form
            ``projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}``.
        type_ (google.cloud.bigquery.storage_v1alpha2.types.WriteStream.Type):

        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Create time of the stream.
        commit_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Commit time of the stream. If a stream is of
            ``COMMITTED`` type, then it will have a commit_time same as
            ``create_time``. If the stream is of ``PENDING`` type,
            commit_time being empty means it is not committed.
        table_schema (google.cloud.bigquery.storage_v1alpha2.types.TableSchema):
            Output only. The schema of the destination table. It is only
            returned in ``CreateWriteStream`` response. Caller should
            generate data that's compatible with this schema to send in
            initial ``AppendRowsRequest``. The table schema could go out
            of date during the life time of the stream.
        external_id (str):
            Id set by client to annotate its identity.
    """
    class Type(proto.Enum):
        r""""""
        TYPE_UNSPECIFIED = 0
        COMMITTED = 1
        PENDING = 2
        BUFFERED = 3

    name = proto.Field(proto.STRING, number=1)

    type_ = proto.Field(proto.ENUM, number=2,
        enum=Type,
    )

    create_time = proto.Field(proto.MESSAGE, number=3,
        message=timestamp.Timestamp,
    )

    commit_time = proto.Field(proto.MESSAGE, number=4,
        message=timestamp.Timestamp,
    )

    table_schema = proto.Field(proto.MESSAGE, number=5,
        message=table.TableSchema,
    )

    external_id = proto.Field(proto.STRING, number=6)


__all__ = tuple(sorted(__protobuf__.manifest))
