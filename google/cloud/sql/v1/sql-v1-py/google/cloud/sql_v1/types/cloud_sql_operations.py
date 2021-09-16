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


__protobuf__ = proto.module(
    package='google.cloud.sql.v1',
    manifest={
        'SqlOperationsGetRequest',
        'SqlOperationsListRequest',
        'OperationsListResponse',
    },
)


class SqlOperationsGetRequest(proto.Message):
    r"""Operations get request.
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
    r"""Operations list request.
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


class OperationsListResponse(proto.Message):
    r"""Operations list response.
    Attributes:
        kind (str):
            This is always **sql#operationsList**.
        items (Sequence[google.cloud.sql_v1.types.Operation]):
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
        message=cloud_sql_resources.Operation,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=3,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
