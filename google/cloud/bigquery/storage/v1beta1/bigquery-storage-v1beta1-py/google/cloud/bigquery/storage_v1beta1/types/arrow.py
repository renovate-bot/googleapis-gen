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


__protobuf__ = proto.module(
    package='google.cloud.bigquery.storage.v1beta1',
    manifest={
        'ArrowSchema',
        'ArrowRecordBatch',
    },
)


class ArrowSchema(proto.Message):
    r"""Arrow schema.

    Attributes:
        serialized_schema (bytes):
            IPC serialized Arrow schema.
    """

    serialized_schema = proto.Field(
        proto.BYTES,
        number=1,
    )


class ArrowRecordBatch(proto.Message):
    r"""Arrow RecordBatch.

    Attributes:
        serialized_record_batch (bytes):
            IPC serialized Arrow RecordBatch.
        row_count (int):
            The count of rows in the returning block.
    """

    serialized_record_batch = proto.Field(
        proto.BYTES,
        number=1,
    )
    row_count = proto.Field(
        proto.INT64,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
