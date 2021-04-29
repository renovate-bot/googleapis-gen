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
    package='google.partner.aistreams.v1alpha1',
    manifest={
        'Cluster',
        'ListClustersRequest',
        'ListClustersResponse',
        'GetClusterRequest',
        'CreateClusterRequest',
        'UpdateClusterRequest',
        'DeleteClusterRequest',
        'Stream',
        'ListStreamsRequest',
        'ListStreamsResponse',
        'GetStreamRequest',
        'CreateStreamRequest',
        'UpdateStreamRequest',
        'DeleteStreamRequest',
        'OperationMetadata',
    },
)


class Cluster(proto.Message):
    r"""Cluster resource.
    Attributes:
        name (str):
            The name of the cluster. The format of
            cluster is:
            projects/<projectid>/locations/<locationid>/clusters/<clusterid>.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time at which this cluster
            was created.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time at which this cluster
            was updated.
        labels (Sequence[google.partner.aistreams_v1alpha1.types.Cluster.LabelsEntry]):
            Labels with user-defined metadata.
        certificate (str):
            Output only. The certificate for creating the
            secure connection between the client and the AI
            Streams data plane.
        service_endpoint (str):
            Output only. The endpoint of the data plane
            cluster.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp.Timestamp,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp.Timestamp,
    )
    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=4,
    )
    certificate = proto.Field(
        proto.STRING,
        number=5,
    )
    service_endpoint = proto.Field(
        proto.STRING,
        number=6,
    )


class ListClustersRequest(proto.Message):
    r"""Request message for 'ListClusters'.
    Attributes:
        parent (str):
            Required. The parent that owns the collection
            of Clusters.
        page_size (int):
            Maximum number of Clusters to return.
        page_token (str):
            Page token received from a previous ``ListClusters`` call.
            Provide this to retrieve the subsequent page. When
            paginating, all other parameters provided to
            ``ListClusters`` must match the call that provided the page
            token.
        filter (str):
            Filter request.
        order_by (str):
            Order by fields for the result.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    filter = proto.Field(
        proto.STRING,
        number=4,
    )
    order_by = proto.Field(
        proto.STRING,
        number=5,
    )


class ListClustersResponse(proto.Message):
    r"""Response message from 'ListClusters'.
    Attributes:
        clusters (Sequence[google.partner.aistreams_v1alpha1.types.Cluster]):
            List of clusters.
        next_page_token (str):
            A token, which can be sent as ``page_token`` to retrieve the
            next page. If this field is omitted, there are no subsequent
            pages.
        unreachable (Sequence[str]):
            Locations that could not be reached.
    """

    @property
    def raw_page(self):
        return self

    clusters = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Cluster',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )
    unreachable = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class GetClusterRequest(proto.Message):
    r"""Request message for 'GetCluster'.
    Attributes:
        name (str):
            Required. The name of the Cluster resource to
            get.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class CreateClusterRequest(proto.Message):
    r"""Request message for 'CreateCluster'.
    Attributes:
        parent (str):
            Required. The parent that owns the collection
            of Clusters.
        cluster_id (str):
            Required. The cluster identifier.
        cluster (google.partner.aistreams_v1alpha1.types.Cluster):
            Required. The cluster resource to create.
        request_id (str):
            Optional. An optional request ID to identify
            requests. Specify a unique request ID so that if
            you must retry your request, the server will
            know to ignore the request if it has already
            been completed. The server will guarantee that
            for at least 60 minutes since the first request.
            For example, consider a situation where you make
            an initial request and the request times out. If
            you make the request again with the same request
            ID, the server can check if original operation
            with the same request ID was received, and if
            so, will ignore the second request. This
            prevents clients from accidentally creating
            duplicate commitments.
            The request ID must be a valid UUID with the
            exception that zero UUID is not supported
            (00000000-0000-0000-0000-000000000000).
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    cluster_id = proto.Field(
        proto.STRING,
        number=2,
    )
    cluster = proto.Field(
        proto.MESSAGE,
        number=3,
        message='Cluster',
    )
    request_id = proto.Field(
        proto.STRING,
        number=4,
    )


class UpdateClusterRequest(proto.Message):
    r"""Request message for 'UpdateCluster'.
    Attributes:
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. Field mask is used to specify the fields to be
            overwritten in the Cluster resource by the update. The
            fields specified in the update_mask are relative to the
            resource, not the full request. A field will be overwritten
            if it is in the mask. If the user does not provide a mask
            then all fields will be overwritten.
        cluster (google.partner.aistreams_v1alpha1.types.Cluster):
            Required. The Cluster resource to update.
        request_id (str):
            Optional. An optional request ID to identify
            requests. Specify a unique request ID so that if
            you must retry your request, the server will
            know to ignore the request if it has already
            been completed. The server will guarantee that
            for at least 60 minutes since the first request.
            For example, consider a situation where you make
            an initial request and the request times out. If
            you make the request again with the same request
            ID, the server can check if original operation
            with the same request ID was received, and if
            so, will ignore the second request. This
            prevents clients from accidentally creating
            duplicate commitments.
            The request ID must be a valid UUID with the
            exception that zero UUID is not supported
            (00000000-0000-0000-0000-000000000000).
    """

    update_mask = proto.Field(
        proto.MESSAGE,
        number=1,
        message=field_mask.FieldMask,
    )
    cluster = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Cluster',
    )
    request_id = proto.Field(
        proto.STRING,
        number=3,
    )


class DeleteClusterRequest(proto.Message):
    r"""Request message for 'DeleteCluster'.
    Attributes:
        name (str):
            Required. The name of cluster to delete.
        request_id (str):
            Optional. An optional request ID to identify
            requests. Specify a unique request ID so that if
            you must retry your request, the server will
            know to ignore the request if it has already
            been completed. The server will guarantee that
            for at least 60 minutes after the first request.
            For example, consider a situation where you make
            an initial request and the request times out. If
            you make the request again with the same request
            ID, the server can check if original operation
            with the same request ID was received, and if
            so, will ignore the second request. This
            prevents clients from accidentally creating
            duplicate commitments.
            The request ID must be a valid UUID with the
            exception that zero UUID is not supported
            (00000000-0000-0000-0000-000000000000).
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    request_id = proto.Field(
        proto.STRING,
        number=2,
    )


class Stream(proto.Message):
    r"""Stream resource.
    Attributes:
        name (str):
            The name of the stream. The format for the
            full name is:
            projects/<projectid>/location/<locationid>/clusters/<clusterid>/streams/<streamid>.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time at which this Stream
            was created.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time at which this Stream
            was updated.
        labels (Sequence[google.partner.aistreams_v1alpha1.types.Stream.LabelsEntry]):
            The labels of the stream.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp.Timestamp,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp.Timestamp,
    )
    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=4,
    )


class ListStreamsRequest(proto.Message):
    r"""Request message for 'ListStreams'.
    Attributes:
        parent (str):
            Required. The parent that owns the collection
            of the Streams.
        page_size (int):
            Maximum number of Streams to return.
        page_token (str):
            Page token received from a previous ``ListStreams`` call.
            Provide this to retrieve the subsequent page. When
            paginating, all other parameters provided to
            ``ListClusters`` must match the call that provided the page
            token.
        filter (str):
            Filter request.
        order_by (str):
            Order by fields for the result.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    filter = proto.Field(
        proto.STRING,
        number=4,
    )
    order_by = proto.Field(
        proto.STRING,
        number=5,
    )


class ListStreamsResponse(proto.Message):
    r"""Response message from 'ListStreams'.
    Attributes:
        streams (Sequence[google.partner.aistreams_v1alpha1.types.Stream]):
            List of the streams.
        next_page_token (str):
            A token, which can be sent as ``page_token`` to retrieve the
            next page. If this field is omitted, there are no subsequent
            pages.
        unreachable (Sequence[str]):
            Locations that could not be reached.
    """

    @property
    def raw_page(self):
        return self

    streams = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Stream',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )
    unreachable = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class GetStreamRequest(proto.Message):
    r"""Request message for 'GetStream'.
    Attributes:
        name (str):
            Required. The name of the stream.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class CreateStreamRequest(proto.Message):
    r"""Request message for 'CreateStream'.
    Attributes:
        parent (str):
            Required. The parent that owns the collection
            of streams.
        stream_id (str):
            Required. The stream identifier.
        stream (google.partner.aistreams_v1alpha1.types.Stream):
            Required. The stream to create.
        request_id (str):
            Optional. An optional request ID to identify
            requests. Specify a unique request ID so that if
            you must retry your request, the server will
            know to ignore the request if it has already
            been completed. The server will guarantee that
            for at least 60 minutes since the first request.
            For example, consider a situation where you make
            an initial request and t he request times out.
            If you make the request again with the same
            request ID, the server can check if original
            operation with the same request ID was received,
            and if so, will ignore the second request. This
            prevents clients from accidentally creating
            duplicate commitments.
            The request ID must be a valid UUID with the
            exception that zero UUID is not supported
            (00000000-0000-0000-0000-000000000000).
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    stream_id = proto.Field(
        proto.STRING,
        number=2,
    )
    stream = proto.Field(
        proto.MESSAGE,
        number=3,
        message='Stream',
    )
    request_id = proto.Field(
        proto.STRING,
        number=4,
    )


class UpdateStreamRequest(proto.Message):
    r"""Request message for 'UpdateStream'.
    Attributes:
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. Field mask is used to specify the fields to be
            overwritten in the Stream resource by the update. The fields
            specified in the update_mask are relative to the resource,
            not the full request. A field will be overwritten if it is
            in the mask. If the user does not provide a mask then all
            fields will be overwritten.
        stream (google.partner.aistreams_v1alpha1.types.Stream):
            Required. The stream resource to update.
        request_id (str):
            Optional. An optional request ID to identify
            requests. Specify a unique request ID so that if
            you must retry your request, the server will
            know to ignore the request if it has already
            been completed. The server will guarantee that
            for at least 60 minutes since the first request.
            For example, consider a situation where you make
            an initial request and t he request times out.
            If you make the request again with the same
            request ID, the server can check if original
            operation with the same request ID was received,
            and if so, will ignore the second request. This
            prevents clients from accidentally creating
            duplicate commitments.
            The request ID must be a valid UUID with the
            exception that zero UUID is not supported
            (00000000-0000-0000-0000-000000000000).
    """

    update_mask = proto.Field(
        proto.MESSAGE,
        number=1,
        message=field_mask.FieldMask,
    )
    stream = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Stream',
    )
    request_id = proto.Field(
        proto.STRING,
        number=3,
    )


class DeleteStreamRequest(proto.Message):
    r"""Request message for 'DeleteStream'.
    Attributes:
        name (str):
            Required. The name of the stream.
        request_id (str):
            Optional. An optional request ID to identify
            requests. Specify a unique request ID so that if
            you must retry your request, the server will
            know to ignore the request if it has already
            been completed. The server will guarantee that
            for at least 60 minutes after the first request.
            For example, consider a situation where you make
            an initial request and t he request times out.
            If you make the request again with the same
            request ID, the server can check if original
            operation with the same request ID was received,
            and if so, will ignore the second request. This
            prevents clients from accidentally creating
            duplicate commitments.
            The request ID must be a valid UUID with the
            exception that zero UUID is not supported
            (00000000-0000-0000-0000-000000000000).
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    request_id = proto.Field(
        proto.STRING,
        number=2,
    )


class OperationMetadata(proto.Message):
    r"""Represents the metadata of the long-running operation.
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
            Output only. Identifies whether the user has requested
            cancellation of the operation. Operations that have
            successfully been cancelled have [Operation.error][] value
            with a [google.rpc.Status.code][google.rpc.Status.code] of
            1, corresponding to ``Code.CANCELLED``.
        api_version (str):
            Output only. API version used to start the
            operation.
    """

    create_time = proto.Field(
        proto.MESSAGE,
        number=1,
        message=timestamp.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp.Timestamp,
    )
    target = proto.Field(
        proto.STRING,
        number=3,
    )
    verb = proto.Field(
        proto.STRING,
        number=4,
    )
    status_message = proto.Field(
        proto.STRING,
        number=5,
    )
    requested_cancellation = proto.Field(
        proto.BOOL,
        number=6,
    )
    api_version = proto.Field(
        proto.STRING,
        number=7,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
