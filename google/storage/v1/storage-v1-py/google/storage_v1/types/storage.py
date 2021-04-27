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

from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import wrappers_pb2 as wrappers  # type: ignore
from google.storage_v1.types import storage_resources


__protobuf__ = proto.module(
    package='google.storage.v1',
    manifest={
        'DeleteBucketAccessControlRequest',
        'GetBucketAccessControlRequest',
        'InsertBucketAccessControlRequest',
        'ListBucketAccessControlsRequest',
        'PatchBucketAccessControlRequest',
        'UpdateBucketAccessControlRequest',
        'DeleteBucketRequest',
        'GetBucketRequest',
        'InsertBucketRequest',
        'ListChannelsRequest',
        'ListBucketsRequest',
        'LockRetentionPolicyRequest',
        'PatchBucketRequest',
        'UpdateBucketRequest',
        'StopChannelRequest',
        'DeleteDefaultObjectAccessControlRequest',
        'GetDefaultObjectAccessControlRequest',
        'InsertDefaultObjectAccessControlRequest',
        'ListDefaultObjectAccessControlsRequest',
        'PatchDefaultObjectAccessControlRequest',
        'UpdateDefaultObjectAccessControlRequest',
        'DeleteNotificationRequest',
        'GetNotificationRequest',
        'InsertNotificationRequest',
        'ListNotificationsRequest',
        'DeleteObjectAccessControlRequest',
        'GetObjectAccessControlRequest',
        'InsertObjectAccessControlRequest',
        'ListObjectAccessControlsRequest',
        'PatchObjectAccessControlRequest',
        'UpdateObjectAccessControlRequest',
        'ComposeObjectRequest',
        'CopyObjectRequest',
        'DeleteObjectRequest',
        'GetObjectMediaRequest',
        'GetObjectRequest',
        'GetObjectMediaResponse',
        'InsertObjectSpec',
        'InsertObjectRequest',
        'ListObjectsRequest',
        'QueryWriteStatusRequest',
        'QueryWriteStatusResponse',
        'RewriteObjectRequest',
        'RewriteResponse',
        'StartResumableWriteRequest',
        'StartResumableWriteResponse',
        'PatchObjectRequest',
        'UpdateObjectRequest',
        'WatchAllObjectsRequest',
        'GetProjectServiceAccountRequest',
        'CreateHmacKeyRequest',
        'CreateHmacKeyResponse',
        'DeleteHmacKeyRequest',
        'GetHmacKeyRequest',
        'ListHmacKeysRequest',
        'ListHmacKeysResponse',
        'UpdateHmacKeyRequest',
        'GetIamPolicyRequest',
        'SetIamPolicyRequest',
        'TestIamPermissionsRequest',
        'CommonObjectRequestParams',
        'CommonRequestParams',
        'ServiceConstants',
    },
)


class DeleteBucketAccessControlRequest(proto.Message):
    r"""Request message for DeleteBucketAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class GetBucketAccessControlRequest(proto.Message):
    r"""Request message for GetBucketAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class InsertBucketAccessControlRequest(proto.Message):
    r"""Request message for InsertBucketAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        bucket_access_control (google.storage_v1.types.BucketAccessControl):
            Properties of the new bucket access control
            being inserted.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    bucket_access_control = proto.Field(
        proto.MESSAGE,
        number=3,
        message=storage_resources.BucketAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class ListBucketAccessControlsRequest(proto.Message):
    r"""Request message for ListBucketAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class PatchBucketAccessControlRequest(proto.Message):
    r"""Request for PatchBucketAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        bucket_access_control (google.storage_v1.types.BucketAccessControl):
            The BucketAccessControl for updating.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            List of fields to be updated.

            To specify ALL fields, equivalent to the JSON API's "update"
            function, specify a single field with the value ``*``.

            Not specifying any fields is an error. Not specifying a
            field while setting that field to a non-default value is an
            error.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    bucket_access_control = proto.Field(
        proto.MESSAGE,
        number=4,
        message=storage_resources.BucketAccessControl,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=5,
        message=field_mask.FieldMask,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class UpdateBucketAccessControlRequest(proto.Message):
    r"""Request for UpdateBucketAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        bucket_access_control (google.storage_v1.types.BucketAccessControl):
            The BucketAccessControl for updating.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    bucket_access_control = proto.Field(
        proto.MESSAGE,
        number=4,
        message=storage_resources.BucketAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=5,
        message='CommonRequestParams',
    )


class DeleteBucketRequest(proto.Message):
    r"""Request message for DeleteBucket.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            If set, only deletes the bucket if its
            metageneration matches this value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            If set, only deletes the bucket if its
            metageneration does not match this value.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers.Int64Value,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=5,
        message='CommonRequestParams',
    )


class GetBucketRequest(proto.Message):
    r"""Request message for GetBucket.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the return of the bucket metadata
            conditional on whether the bucket's current
            metageneration matches the given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the return of the bucket metadata
            conditional on whether the bucket's current
            metageneration does not match the given value.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers.Int64Value,
    )
    projection = proto.Field(
        proto.ENUM,
        number=4,
        enum=storage_resources.CommonEnums.Projection,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class InsertBucketRequest(proto.Message):
    r"""Request message for InsertBucket.
    Attributes:
        predefined_acl (google.storage_v1.types.CommonEnums.PredefinedBucketAcl):
            Apply a predefined set of access controls to
            this bucket.
        predefined_default_object_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of default object
            access controls to this bucket.
        project (str):
            Required. A valid API project identifier.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``, unless
            the bucket resource specifies ``acl`` or
            ``defaultObjectAcl`` properties, when it defaults to
            ``FULL``.
        bucket (google.storage_v1.types.Bucket):
            Properties of the new bucket being inserted,
            including its name.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    predefined_acl = proto.Field(
        proto.ENUM,
        number=1,
        enum=storage_resources.CommonEnums.PredefinedBucketAcl,
    )
    predefined_default_object_acl = proto.Field(
        proto.ENUM,
        number=2,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )
    projection = proto.Field(
        proto.ENUM,
        number=4,
        enum=storage_resources.CommonEnums.Projection,
    )
    bucket = proto.Field(
        proto.MESSAGE,
        number=6,
        message=storage_resources.Bucket,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=7,
        message='CommonRequestParams',
    )


class ListChannelsRequest(proto.Message):
    r"""Request message for ListChannels.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class ListBucketsRequest(proto.Message):
    r"""Request message for ListBuckets.
    Attributes:
        max_results (int):
            Maximum number of buckets to return in a
            single response. The service will use this
            parameter or 1,000 items, whichever is smaller.
        page_token (str):
            A previously-returned page token representing
            part of the larger set of results to view.
        prefix (str):
            Filter results to buckets whose names begin
            with this prefix.
        project (str):
            Required. A valid API project identifier.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    max_results = proto.Field(
        proto.INT32,
        number=1,
    )
    page_token = proto.Field(
        proto.STRING,
        number=2,
    )
    prefix = proto.Field(
        proto.STRING,
        number=3,
    )
    project = proto.Field(
        proto.STRING,
        number=4,
    )
    projection = proto.Field(
        proto.ENUM,
        number=5,
        enum=storage_resources.CommonEnums.Projection,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=7,
        message='CommonRequestParams',
    )


class LockRetentionPolicyRequest(proto.Message):
    r"""Request message for LockRetentionPolicy.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        if_metageneration_match (int):
            Makes the operation conditional on whether
            bucket's current metageneration matches the
            given value. Must be positive.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    if_metageneration_match = proto.Field(
        proto.INT64,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class PatchBucketRequest(proto.Message):
    r"""Request for PatchBucket method.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the return of the bucket metadata
            conditional on whether the bucket's current
            metageneration matches the given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the return of the bucket metadata
            conditional on whether the bucket's current
            metageneration does not match the given value.
        predefined_acl (google.storage_v1.types.CommonEnums.PredefinedBucketAcl):
            Apply a predefined set of access controls to
            this bucket.
        predefined_default_object_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of default object
            access controls to this bucket.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``FULL``.
        metadata (google.storage_v1.types.Bucket):
            The Bucket metadata for updating.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            List of fields to be updated.

            To specify ALL fields, equivalent to the JSON API's "update"
            function, specify a single field with the value ``*``. Note:
            not recommended. If a new field is introduced at a later
            time, an older client updating with the ``*`` may
            accidentally reset the new field's value.

            Not specifying any fields is an error. Not specifying a
            field while setting that field to a non-default value is an
            error.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers.Int64Value,
    )
    predefined_acl = proto.Field(
        proto.ENUM,
        number=4,
        enum=storage_resources.CommonEnums.PredefinedBucketAcl,
    )
    predefined_default_object_acl = proto.Field(
        proto.ENUM,
        number=5,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    projection = proto.Field(
        proto.ENUM,
        number=6,
        enum=storage_resources.CommonEnums.Projection,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=8,
        message=storage_resources.Bucket,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=9,
        message=field_mask.FieldMask,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=10,
        message='CommonRequestParams',
    )


class UpdateBucketRequest(proto.Message):
    r"""Request for UpdateBucket method.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the return of the bucket metadata
            conditional on whether the bucket's current
            metageneration matches the given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the return of the bucket metadata
            conditional on whether the bucket's current
            metageneration does not match the given value.
        predefined_acl (google.storage_v1.types.CommonEnums.PredefinedBucketAcl):
            Apply a predefined set of access controls to
            this bucket.
        predefined_default_object_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of default object
            access controls to this bucket.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``FULL``.
        metadata (google.storage_v1.types.Bucket):
            The Bucket metadata for updating.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers.Int64Value,
    )
    predefined_acl = proto.Field(
        proto.ENUM,
        number=4,
        enum=storage_resources.CommonEnums.PredefinedBucketAcl,
    )
    predefined_default_object_acl = proto.Field(
        proto.ENUM,
        number=5,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    projection = proto.Field(
        proto.ENUM,
        number=6,
        enum=storage_resources.CommonEnums.Projection,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=8,
        message=storage_resources.Bucket,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=9,
        message='CommonRequestParams',
    )


class StopChannelRequest(proto.Message):
    r"""Request message for StopChannel.
    Attributes:
        channel (google.storage_v1.types.Channel):
            The channel to be stopped.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    channel = proto.Field(
        proto.MESSAGE,
        number=1,
        message=storage_resources.Channel,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=2,
        message='CommonRequestParams',
    )


class DeleteDefaultObjectAccessControlRequest(proto.Message):
    r"""Request message for DeleteDefaultObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class GetDefaultObjectAccessControlRequest(proto.Message):
    r"""Request message for GetDefaultObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class InsertDefaultObjectAccessControlRequest(proto.Message):
    r"""Request message for InsertDefaultObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        object_access_control (google.storage_v1.types.ObjectAccessControl):
            Properties of the object access control being
            inserted.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_access_control = proto.Field(
        proto.MESSAGE,
        number=3,
        message=storage_resources.ObjectAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class ListDefaultObjectAccessControlsRequest(proto.Message):
    r"""Request message for ListDefaultObjectAccessControls.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            If present, only return default ACL listing
            if the bucket's current metageneration matches
            this value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            If present, only return default ACL listing
            if the bucket's current metageneration does not
            match the given value.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers.Int64Value,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=5,
        message='CommonRequestParams',
    )


class PatchDefaultObjectAccessControlRequest(proto.Message):
    r"""Request message for PatchDefaultObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        object_access_control (google.storage_v1.types.ObjectAccessControl):
            The ObjectAccessControl for updating.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            List of fields to be updated.

            To specify ALL fields, equivalent to the JSON API's "update"
            function, specify a single field with the value ``*``. Note:
            not recommended. If a new field is introduced at a later
            time, an older client updating with the ``*`` may
            accidentally reset the new field's value.

            Not specifying any fields is an error. Not specifying a
            field while setting that field to a non-default value is an
            error.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    object_access_control = proto.Field(
        proto.MESSAGE,
        number=4,
        message=storage_resources.ObjectAccessControl,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=5,
        message=field_mask.FieldMask,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class UpdateDefaultObjectAccessControlRequest(proto.Message):
    r"""Request message for UpdateDefaultObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        object_access_control (google.storage_v1.types.ObjectAccessControl):
            The ObjectAccessControl for updating.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    object_access_control = proto.Field(
        proto.MESSAGE,
        number=4,
        message=storage_resources.ObjectAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=5,
        message='CommonRequestParams',
    )


class DeleteNotificationRequest(proto.Message):
    r"""Request message for DeleteNotification.
    Attributes:
        bucket (str):
            Required. The parent bucket of the
            notification.
        notification (str):
            Required. ID of the notification to delete.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    notification = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class GetNotificationRequest(proto.Message):
    r"""Request message for GetNotification.
    Attributes:
        bucket (str):
            Required. The parent bucket of the
            notification.
        notification (str):
            Required. Notification ID.
            Required.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    notification = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class InsertNotificationRequest(proto.Message):
    r"""Request message for InsertNotification.
    Attributes:
        bucket (str):
            Required. The parent bucket of the
            notification.
        notification (google.storage_v1.types.Notification):
            Properties of the notification to be
            inserted.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    notification = proto.Field(
        proto.MESSAGE,
        number=3,
        message=storage_resources.Notification,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class ListNotificationsRequest(proto.Message):
    r"""Request message for ListNotifications.
    Attributes:
        bucket (str):
            Required. Name of a Google Cloud Storage
            bucket.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class DeleteObjectAccessControlRequest(proto.Message):
    r"""Request message for DeleteObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    object_ = proto.Field(
        proto.STRING,
        number=3,
    )
    generation = proto.Field(
        proto.INT64,
        number=4,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class GetObjectAccessControlRequest(proto.Message):
    r"""Request message for GetObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    object_ = proto.Field(
        proto.STRING,
        number=3,
    )
    generation = proto.Field(
        proto.INT64,
        number=4,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class InsertObjectAccessControlRequest(proto.Message):
    r"""Request message for InsertObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        object_access_control (google.storage_v1.types.ObjectAccessControl):
            Properties of the object access control to be
            inserted.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    object_access_control = proto.Field(
        proto.MESSAGE,
        number=5,
        message=storage_resources.ObjectAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class ListObjectAccessControlsRequest(proto.Message):
    r"""Request message for ListObjectAccessControls.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=5,
        message='CommonRequestParams',
    )


class PatchObjectAccessControlRequest(proto.Message):
    r"""Request message for PatchObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        object_ (str):
            Required. Name of the object.
            Required.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        object_access_control (google.storage_v1.types.ObjectAccessControl):
            The ObjectAccessControl for updating.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            List of fields to be updated.

            To specify ALL fields, equivalent to the JSON API's "update"
            function, specify a single field with the value ``*``. Note:
            not recommended. If a new field is introduced at a later
            time, an older client updating with the ``*`` may
            accidentally reset the new field's value.

            Not specifying any fields is an error. Not specifying a
            field while setting that field to a non-default value is an
            error.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    object_ = proto.Field(
        proto.STRING,
        number=3,
    )
    generation = proto.Field(
        proto.INT64,
        number=4,
    )
    object_access_control = proto.Field(
        proto.MESSAGE,
        number=5,
        message=storage_resources.ObjectAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=7,
        message=field_mask.FieldMask,
    )


class UpdateObjectAccessControlRequest(proto.Message):
    r"""Request message for UpdateObjectAccessControl.
    Attributes:
        bucket (str):
            Required. Name of a bucket.
        entity (str):
            Required. The entity holding the permission. Can be one of:

            -  ``user-``\ *userId*
            -  ``user-``\ *emailAddress*
            -  ``group-``\ *groupId*
            -  ``group-``\ *emailAddress*
            -  ``allUsers``
            -  ``allAuthenticatedUsers``
        object_ (str):
            Required. Name of the object.
            Required.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        object_access_control (google.storage_v1.types.ObjectAccessControl):
            The ObjectAccessControl for updating.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            List of fields to be updated.

            To specify ALL fields, equivalent to the JSON API's "update"
            function, specify a single field with the value ``*``. Note:
            not recommended. If a new field is introduced at a later
            time, an older client updating with the ``*`` may
            accidentally reset the new field's value.

            Not specifying any fields is an error. Not specifying a
            field while setting that field to a non-default value is an
            error.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    entity = proto.Field(
        proto.STRING,
        number=2,
    )
    object_ = proto.Field(
        proto.STRING,
        number=3,
    )
    generation = proto.Field(
        proto.INT64,
        number=4,
    )
    object_access_control = proto.Field(
        proto.MESSAGE,
        number=6,
        message=storage_resources.ObjectAccessControl,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=7,
        message='CommonRequestParams',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=8,
        message=field_mask.FieldMask,
    )


class ComposeObjectRequest(proto.Message):
    r"""Request message for ComposeObject.
    Attributes:
        destination_bucket (str):
            Required. Name of the bucket containing the
            source objects. The destination object is stored
            in this bucket.
        destination_object (str):
            Required. Name of the new object.
        destination_predefined_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            the destination object.
        destination (google.storage_v1.types.Object):
            Properties of the resulting object.
        source_objects (Sequence[google.storage_v1.types.ComposeObjectRequest.SourceObjects]):
            The list of source objects that will be
            concatenated into a single object.
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        kms_key_name (str):
            Resource name of the Cloud KMS key, of the form
            ``projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key``,
            that will be used to encrypt the object. Overrides the
            object metadata's ``kms_key_name`` value, if any.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    class SourceObjects(proto.Message):
        r"""Description of a source object for a composition request.
        Attributes:
            name (str):
                The source object's name. All source objects
                must reside in the same bucket.
            generation (int):
                The generation of this object to use as the
                source.
            object_preconditions (google.storage_v1.types.ComposeObjectRequest.SourceObjects.ObjectPreconditions):
                Conditions that must be met for this
                operation to execute.
        """

        class ObjectPreconditions(proto.Message):
            r"""Preconditions for a source object of a composition request.
            Attributes:
                if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
                    Only perform the composition if the
                    generation of the source object that would be
                    used matches this value.  If this value and a
                    generation are both specified, they must be the
                    same value or the call will fail.
            """

            if_generation_match = proto.Field(
                proto.MESSAGE,
                number=1,
                message=wrappers.Int64Value,
            )

        name = proto.Field(
            proto.STRING,
            number=1,
        )
        generation = proto.Field(
            proto.INT64,
            number=2,
        )
        object_preconditions = proto.Field(
            proto.MESSAGE,
            number=3,
            message='ComposeObjectRequest.SourceObjects.ObjectPreconditions',
        )

    destination_bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    destination_object = proto.Field(
        proto.STRING,
        number=2,
    )
    destination_predefined_acl = proto.Field(
        proto.ENUM,
        number=3,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    destination = proto.Field(
        proto.MESSAGE,
        number=11,
        message=storage_resources.Object,
    )
    source_objects = proto.RepeatedField(
        proto.MESSAGE,
        number=12,
        message=SourceObjects,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    kms_key_name = proto.Field(
        proto.STRING,
        number=6,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=9,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=10,
        message='CommonRequestParams',
    )


class CopyObjectRequest(proto.Message):
    r"""Request message for CopyObject.
    Attributes:
        destination_bucket (str):
            Required. Name of the bucket in which to store the new
            object. Overrides the provided object metadata's ``bucket``
            value, if any.
        destination_object (str):
            Required. Name of the new object. Required when the object
            metadata is not otherwise provided. Overrides the object
            metadata's ``name`` value, if any.
        destination_predefined_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            the destination object.
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the destination object's current generation
            matches the given value. Setting to 0 makes the
            operation succeed only if there are no live
            versions of the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the destination object's current generation does
            not match the given value. If no live object
            exists, the precondition fails. Setting to 0
            makes the operation succeed only if there is a
            live version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the destination object's current metageneration
            matches the given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the destination object's current metageneration
            does not match the given value.
        if_source_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current generation matches
            the given value.
        if_source_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current generation does not
            match the given value.
        if_source_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current metageneration
            matches the given value.
        if_source_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current metageneration does
            not match the given value.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``, unless
            the object resource specifies the ``acl`` property, when it
            defaults to ``full``.
        source_bucket (str):
            Required. Name of the bucket in which to find
            the source object.
        source_object (str):
            Required. Name of the source object.
        source_generation (int):
            If present, selects a specific revision of
            the source object (as opposed to the latest
            version, the default).
        destination (google.storage_v1.types.Object):
            Properties of the resulting object. If not
            set, duplicate properties of source object.
        destination_kms_key_name (str):
            Resource name of the Cloud KMS key, of the form
            ``projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key``,
            that will be used to encrypt the object. Overrides the
            object metadata's ``kms_key_name`` value, if any.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    destination_bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    destination_object = proto.Field(
        proto.STRING,
        number=2,
    )
    destination_predefined_acl = proto.Field(
        proto.ENUM,
        number=3,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    if_source_generation_match = proto.Field(
        proto.MESSAGE,
        number=8,
        message=wrappers.Int64Value,
    )
    if_source_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers.Int64Value,
    )
    if_source_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=10,
        message=wrappers.Int64Value,
    )
    if_source_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=11,
        message=wrappers.Int64Value,
    )
    projection = proto.Field(
        proto.ENUM,
        number=12,
        enum=storage_resources.CommonEnums.Projection,
    )
    source_bucket = proto.Field(
        proto.STRING,
        number=13,
    )
    source_object = proto.Field(
        proto.STRING,
        number=14,
    )
    source_generation = proto.Field(
        proto.INT64,
        number=15,
    )
    destination = proto.Field(
        proto.MESSAGE,
        number=17,
        message=storage_resources.Object,
    )
    destination_kms_key_name = proto.Field(
        proto.STRING,
        number=20,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=18,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=19,
        message='CommonRequestParams',
    )


class DeleteObjectRequest(proto.Message):
    r"""Message for deleting an object. Either ``bucket`` and ``object``
    *or* ``upload_id`` **must** be set (but not both).

    Attributes:
        bucket (str):
            Required. Name of the bucket in which the
            object resides.
        object_ (str):
            Required. The name of the object to delete
            (when not using a resumable write).
        upload_id (str):
            The resumable upload_id of the object to delete (when using
            a resumable write). This should be copied from the
            ``upload_id`` field of ``StartResumableWriteResponse``.
        generation (int):
            If present, permanently deletes a specific
            revision of this object (as opposed to the
            latest version, the default).
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    upload_id = proto.Field(
        proto.STRING,
        number=3,
    )
    generation = proto.Field(
        proto.INT64,
        number=4,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=8,
        message=wrappers.Int64Value,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=10,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=11,
        message='CommonRequestParams',
    )


class GetObjectMediaRequest(proto.Message):
    r"""Request message for GetObjectMedia.
    Attributes:
        bucket (str):
            The name of the bucket containing the object
            to read.
        object_ (str):
            The name of the object to read.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        read_offset (int):
            The offset for the first byte to return in the read,
            relative to the start of the object.

            A negative ``read_offset`` value will be interpreted as the
            number of bytes back from the end of the object to be
            returned. For example, if an object's length is 15 bytes, a
            GetObjectMediaRequest with ``read_offset`` = -5 and
            ``read_limit`` = 3 would return bytes 10 through 12 of the
            object.
        read_limit (int):
            The maximum number of ``data`` bytes the server is allowed
            to return in the sum of all ``Object`` messages. A
            ``read_limit`` of zero indicates that there is no limit, and
            a negative ``read_limit`` will cause an error.

            If the stream returns fewer bytes than allowed by the
            ``read_limit`` and no error occurred, the stream includes
            all data from the ``read_offset`` to the end of the
            resource.
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    read_offset = proto.Field(
        proto.INT64,
        number=4,
    )
    read_limit = proto.Field(
        proto.INT64,
        number=5,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=8,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers.Int64Value,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=11,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=12,
        message='CommonRequestParams',
    )


class GetObjectRequest(proto.Message):
    r"""Request message for GetObject.
    Attributes:
        bucket (str):
            Required. Name of the bucket in which the
            object resides.
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    projection = proto.Field(
        proto.ENUM,
        number=8,
        enum=storage_resources.CommonEnums.Projection,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=10,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=11,
        message='CommonRequestParams',
    )


class GetObjectMediaResponse(proto.Message):
    r"""Response message for GetObject.
    Attributes:
        checksummed_data (google.storage_v1.types.ChecksummedData):
            A portion of the data for the object. The service **may**
            leave ``data`` empty for any given ``ReadResponse``. This
            enables the service to inform the client that the request is
            still live while it is running an operation to generate more
            data.
        object_checksums (google.storage_v1.types.ObjectChecksums):
            The checksums of the complete object. The
            client should compute one of these checksums
            over the downloaded object and compare it
            against the value provided here.
        content_range (google.storage_v1.types.ContentRange):
            If read_offset and or read_limit was specified on the
            GetObjectMediaRequest, ContentRange will be populated on the
            first GetObjectMediaResponse message of the read stream.
        metadata (google.storage_v1.types.Object):
            Metadata of the object whose media is being
            returned. Only populated in the first response
            in the stream.
    """

    checksummed_data = proto.Field(
        proto.MESSAGE,
        number=1,
        message=storage_resources.ChecksummedData,
    )
    object_checksums = proto.Field(
        proto.MESSAGE,
        number=2,
        message=storage_resources.ObjectChecksums,
    )
    content_range = proto.Field(
        proto.MESSAGE,
        number=3,
        message=storage_resources.ContentRange,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=4,
        message=storage_resources.Object,
    )


class InsertObjectSpec(proto.Message):
    r"""Describes an attempt to insert an object, possibly over
    multiple requests.

    Attributes:
        resource (google.storage_v1.types.Object):
            Destination object, including its name and
            its metadata.
        predefined_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            this object.
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``, unless
            the object resource specifies the ``acl`` property, when it
            defaults to ``full``.
    """

    resource = proto.Field(
        proto.MESSAGE,
        number=1,
        message=storage_resources.Object,
    )
    predefined_acl = proto.Field(
        proto.ENUM,
        number=2,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=3,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    projection = proto.Field(
        proto.ENUM,
        number=7,
        enum=storage_resources.CommonEnums.Projection,
    )


class InsertObjectRequest(proto.Message):
    r"""Message for writing an object.
    Attributes:
        upload_id (str):
            For resumable uploads. This should be the ``upload_id``
            returned from a call to ``StartResumableWriteResponse``.
        insert_object_spec (google.storage_v1.types.InsertObjectSpec):
            For non-resumable uploads. Describes the
            overall upload, including the destination bucket
            and object name, preconditions, etc.
        write_offset (int):
            Required. The offset from the beginning of the object at
            which the data should be written.

            In the first ``InsertObjectRequest`` of a ``InsertObject()``
            action, it indicates the initial offset for the ``Insert()``
            call. The value **must** be equal to the ``committed_size``
            that a call to ``QueryWriteStatus()`` would return (0 if
            this is the first write to the object).

            On subsequent calls, this value **must** be no larger than
            the sum of the first ``write_offset`` and the sizes of all
            ``data`` chunks sent previously on this stream.

            An incorrect value will cause an error.
        checksummed_data (google.storage_v1.types.ChecksummedData):
            The data to insert. If a crc32c checksum is
            provided that doesn't match the checksum
            computed by the service, the request will fail.
        reference (google.storage_v1.types.GetObjectMediaRequest):
            A reference to an existing object. This can
            be used to support several use cases:
              - Writing a sequence of data buffers supports
            the basic use case of     uploading a complete
            object, chunk by chunk.   - Writing a sequence
            of references to existing objects allows an
            object to be composed from a collection of
            objects, which can be     used to support
            parallel object writes.
              - Writing a single reference with a given
            offset and size can be used     to create an
            object from a slice of an existing object.   -
            Writing an object referencing a object slice
            (created as noted     above) followed by a data
            buffer followed by another object     slice can
            be used to support delta upload functionality.
        object_checksums (google.storage_v1.types.ObjectChecksums):
            Checksums for the complete object. If the checksums computed
            by the service don't match the specifified checksums the
            call will fail. May only be provided in the first or last
            request (either with first_message, or finish_write set).
        finish_write (bool):
            If ``true``, this indicates that the write is complete.
            Sending any ``InsertObjectRequest``\ s subsequent to one in
            which ``finish_write`` is ``true`` will cause an error. For
            a non-resumable write (where the upload_id was not set in
            the first message), it is an error not to set this field in
            the final message of the stream.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    upload_id = proto.Field(
        proto.STRING,
        number=1,
        oneof='first_message',
    )
    insert_object_spec = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='first_message',
        message='InsertObjectSpec',
    )
    write_offset = proto.Field(
        proto.INT64,
        number=3,
    )
    checksummed_data = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='data',
        message=storage_resources.ChecksummedData,
    )
    reference = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='data',
        message='GetObjectMediaRequest',
    )
    object_checksums = proto.Field(
        proto.MESSAGE,
        number=6,
        message=storage_resources.ObjectChecksums,
    )
    finish_write = proto.Field(
        proto.BOOL,
        number=7,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=8,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=9,
        message='CommonRequestParams',
    )


class ListObjectsRequest(proto.Message):
    r"""Request message for ListObjects.
    Attributes:
        bucket (str):
            Required. Name of the bucket in which to look
            for objects.
        delimiter (str):
            Returns results in a directory-like mode. ``items`` will
            contain only objects whose names, aside from the ``prefix``,
            do not contain ``delimiter``. Objects whose names, aside
            from the ``prefix``, contain ``delimiter`` will have their
            name, truncated after the ``delimiter``, returned in
            ``prefixes``. Duplicate ``prefixes`` are omitted.
        include_trailing_delimiter (bool):
            If true, objects that end in exactly one instance of
            ``delimiter`` will have their metadata included in ``items``
            in addition to ``prefixes``.
        max_results (int):
            Maximum number of ``items`` plus ``prefixes`` to return in a
            single page of responses. As duplicate ``prefixes`` are
            omitted, fewer total results may be returned than requested.
            The service will use this parameter or 1,000 items,
            whichever is smaller.
        page_token (str):
            A previously-returned page token representing
            part of the larger set of results to view.
        prefix (str):
            Filter results to objects whose names begin
            with this prefix.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``.
        versions (bool):
            If ``true``, lists all versions of an object as distinct
            results. The default is ``false``. For more information, see
            `Object
            Versioning <https://cloud.google.com/storage/docs/object-versioning>`__.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    delimiter = proto.Field(
        proto.STRING,
        number=2,
    )
    include_trailing_delimiter = proto.Field(
        proto.BOOL,
        number=3,
    )
    max_results = proto.Field(
        proto.INT32,
        number=4,
    )
    page_token = proto.Field(
        proto.STRING,
        number=5,
    )
    prefix = proto.Field(
        proto.STRING,
        number=6,
    )
    projection = proto.Field(
        proto.ENUM,
        number=7,
        enum=storage_resources.CommonEnums.Projection,
    )
    versions = proto.Field(
        proto.BOOL,
        number=9,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=10,
        message='CommonRequestParams',
    )


class QueryWriteStatusRequest(proto.Message):
    r"""Request object for ``ByteStream.QueryWriteStatus``.
    Attributes:
        upload_id (str):
            Required. The name of the resume token for
            the object whose write status is being
            requested.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    upload_id = proto.Field(
        proto.STRING,
        number=1,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=2,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class QueryWriteStatusResponse(proto.Message):
    r"""Response object for ``ByteStream.QueryWriteStatus``.
    Attributes:
        committed_size (int):
            The number of bytes that have been processed
            for the given object.
        complete (bool):
            ``complete`` is ``true`` only if the client has sent a
            ``InsertObjectRequest`` with ``finish_write`` set to true,
            and the server has processed that request.
    """

    committed_size = proto.Field(
        proto.INT64,
        number=1,
    )
    complete = proto.Field(
        proto.BOOL,
        number=2,
    )


class RewriteObjectRequest(proto.Message):
    r"""Request message for RewriteObject.
    Attributes:
        destination_bucket (str):
            Required. Name of the bucket in which to store the new
            object. Overrides the provided object metadata's ``bucket``
            value, if any.
        destination_object (str):
            Required. Name of the new object. Required when the object
            metadata is not otherwise provided. Overrides the object
            metadata's ``name`` value, if any.
        destination_kms_key_name (str):
            Resource name of the Cloud KMS key, of the form
            ``projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key``,
            that will be used to encrypt the object. Overrides the
            object metadata's ``kms_key_name`` value, if any.
        destination_predefined_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            the destination object.
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the destination object's current metageneration
            matches the given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the destination object's current metageneration
            does not match the given value.
        if_source_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current generation matches
            the given value.
        if_source_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current generation does not
            match the given value.
        if_source_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current metageneration
            matches the given value.
        if_source_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the source object's current metageneration does
            not match the given value.
        max_bytes_rewritten_per_call (int):
            The maximum number of bytes that will be rewritten per
            rewrite request. Most callers shouldn't need to specify this
            parameter - it is primarily in place to support testing. If
            specified the value must be an integral multiple of 1 MiB
            (1048576). Also, this only applies to requests where the
            source and destination span locations and/or storage
            classes. Finally, this value must not change across rewrite
            calls else you'll get an error that the ``rewriteToken`` is
            invalid.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``, unless
            the object resource specifies the ``acl`` property, when it
            defaults to ``full``.
        rewrite_token (str):
            Include this field (from the previous rewrite
            response) on each rewrite request after the
            first one, until the rewrite response 'done'
            flag is true. Calls that provide a rewriteToken
            can omit all other request fields, but if
            included those fields must match the values
            provided in the first rewrite request.
        source_bucket (str):
            Required. Name of the bucket in which to find
            the source object.
        source_object (str):
            Required. Name of the source object.
        source_generation (int):
            If present, selects a specific revision of
            the source object (as opposed to the latest
            version, the default).
        object_ (google.storage_v1.types.Object):
            Properties of the destination, post-rewrite
            object.
        copy_source_encryption_algorithm (str):
            The algorithm used to encrypt the source
            object, if any.
        copy_source_encryption_key (str):
            The encryption key used to encrypt the source
            object, if any.
        copy_source_encryption_key_sha256 (str):
            The SHA-256 hash of the key used to encrypt
            the source object, if any.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    destination_bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    destination_object = proto.Field(
        proto.STRING,
        number=2,
    )
    destination_kms_key_name = proto.Field(
        proto.STRING,
        number=3,
    )
    destination_predefined_acl = proto.Field(
        proto.ENUM,
        number=4,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=8,
        message=wrappers.Int64Value,
    )
    if_source_generation_match = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers.Int64Value,
    )
    if_source_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=10,
        message=wrappers.Int64Value,
    )
    if_source_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=11,
        message=wrappers.Int64Value,
    )
    if_source_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=12,
        message=wrappers.Int64Value,
    )
    max_bytes_rewritten_per_call = proto.Field(
        proto.INT64,
        number=13,
    )
    projection = proto.Field(
        proto.ENUM,
        number=14,
        enum=storage_resources.CommonEnums.Projection,
    )
    rewrite_token = proto.Field(
        proto.STRING,
        number=15,
    )
    source_bucket = proto.Field(
        proto.STRING,
        number=16,
    )
    source_object = proto.Field(
        proto.STRING,
        number=17,
    )
    source_generation = proto.Field(
        proto.INT64,
        number=18,
    )
    object_ = proto.Field(
        proto.MESSAGE,
        number=20,
        message=storage_resources.Object,
    )
    copy_source_encryption_algorithm = proto.Field(
        proto.STRING,
        number=21,
    )
    copy_source_encryption_key = proto.Field(
        proto.STRING,
        number=22,
    )
    copy_source_encryption_key_sha256 = proto.Field(
        proto.STRING,
        number=23,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=24,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=25,
        message='CommonRequestParams',
    )


class RewriteResponse(proto.Message):
    r"""A rewrite response.
    Attributes:
        total_bytes_rewritten (int):
            The total bytes written so far, which can be
            used to provide a waiting user with a progress
            indicator. This property is always present in
            the response.
        object_size (int):
            The total size of the object being copied in
            bytes. This property is always present in the
            response.
        done (bool):
            ``true`` if the copy is finished; otherwise, ``false`` if
            the copy is in progress. This property is always present in
            the response.
        rewrite_token (str):
            A token to use in subsequent requests to
            continue copying data. This token is present in
            the response only when there is more data to
            copy.
        resource (google.storage_v1.types.Object):
            A resource containing the metadata for the
            copied-to object. This property is present in
            the response only when copying completes.
    """

    total_bytes_rewritten = proto.Field(
        proto.INT64,
        number=1,
    )
    object_size = proto.Field(
        proto.INT64,
        number=2,
    )
    done = proto.Field(
        proto.BOOL,
        number=3,
    )
    rewrite_token = proto.Field(
        proto.STRING,
        number=4,
    )
    resource = proto.Field(
        proto.MESSAGE,
        number=5,
        message=storage_resources.Object,
    )


class StartResumableWriteRequest(proto.Message):
    r"""Request message StartResumableWrite.
    Attributes:
        insert_object_spec (google.storage_v1.types.InsertObjectSpec):
            The destination bucket, object, and metadata,
            as well as any preconditions.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    insert_object_spec = proto.Field(
        proto.MESSAGE,
        number=1,
        message='InsertObjectSpec',
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=4,
        message='CommonRequestParams',
    )


class StartResumableWriteResponse(proto.Message):
    r"""Response object for ByteStream.StartResumableWrite.
    Attributes:
        upload_id (str):
            The upload_id of the newly started resumable write
            operation. This value should be copied into the
            ``InsertObjectRequest.upload_id`` field.
    """

    upload_id = proto.Field(
        proto.STRING,
        number=1,
    )


class PatchObjectRequest(proto.Message):
    r"""Request message for PatchObject.
    Attributes:
        bucket (str):
            Required. Name of the bucket in which the
            object resides.
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        predefined_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            this object.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``FULL``.
        metadata (google.storage_v1.types.Object):
            The Object metadata for updating.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            List of fields to be updated.

            To specify ALL fields, equivalent to the JSON API's "update"
            function, specify a single field with the value ``*``. Note:
            not recommended. If a new field is introduced at a later
            time, an older client updating with the ``*`` may
            accidentally reset the new field's value.

            Not specifying any fields is an error. Not specifying a
            field while setting that field to a non-default value is an
            error.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    predefined_acl = proto.Field(
        proto.ENUM,
        number=8,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    projection = proto.Field(
        proto.ENUM,
        number=9,
        enum=storage_resources.CommonEnums.Projection,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=11,
        message=storage_resources.Object,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=12,
        message=field_mask.FieldMask,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=13,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=14,
        message='CommonRequestParams',
    )


class UpdateObjectRequest(proto.Message):
    r"""Request message for UpdateObject.
    Attributes:
        bucket (str):
            Required. Name of the bucket in which the
            object resides.
        object_ (str):
            Required. Name of the object.
        generation (int):
            If present, selects a specific revision of
            this object (as opposed to the latest version,
            the default).
        if_generation_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (google.protobuf.wrappers_pb2.Int64Value):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        predefined_acl (google.storage_v1.types.CommonEnums.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            this object.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``FULL``.
        metadata (google.storage_v1.types.Object):
            The Object metadata for updating.
        common_object_request_params (google.storage_v1.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    object_ = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    if_generation_match = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int64Value,
    )
    if_generation_not_match = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers.Int64Value,
    )
    if_metageneration_match = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers.Int64Value,
    )
    if_metageneration_not_match = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers.Int64Value,
    )
    predefined_acl = proto.Field(
        proto.ENUM,
        number=8,
        enum=storage_resources.CommonEnums.PredefinedObjectAcl,
    )
    projection = proto.Field(
        proto.ENUM,
        number=9,
        enum=storage_resources.CommonEnums.Projection,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=11,
        message=storage_resources.Object,
    )
    common_object_request_params = proto.Field(
        proto.MESSAGE,
        number=12,
        message='CommonObjectRequestParams',
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=13,
        message='CommonRequestParams',
    )


class WatchAllObjectsRequest(proto.Message):
    r"""Request message for WatchAllObjects.
    Attributes:
        bucket (str):
            Name of the bucket in which to look for
            objects.
        versions (bool):
            If ``true``, lists all versions of an object as distinct
            results. The default is ``false``. For more information, see
            `Object
            Versioning <https://cloud.google.com/storage/docs/object-versioning>`__.
        delimiter (str):
            Returns results in a directory-like mode. ``items`` will
            contain only objects whose names, aside from the ``prefix``,
            do not contain ``delimiter``. Objects whose names, aside
            from the ``prefix``, contain ``delimiter`` will have their
            name, truncated after the ``delimiter``, returned in
            ``prefixes``. Duplicate ``prefixes`` are omitted.
        max_results (int):
            Maximum number of ``items`` plus ``prefixes`` to return in a
            single page of responses. As duplicate ``prefixes`` are
            omitted, fewer total results may be returned than requested.
            The service will use this parameter or 1,000 items,
            whichever is smaller.
        prefix (str):
            Filter results to objects whose names begin
            with this prefix.
        include_trailing_delimiter (bool):
            If true, objects that end in exactly one instance of
            ``delimiter`` will have their metadata included in ``items``
            in addition to ``prefixes``.
        page_token (str):
            A previously-returned page token representing
            part of the larger set of results to view.
        projection (google.storage_v1.types.CommonEnums.Projection):
            Set of properties to return. Defaults to ``NO_ACL``.
        channel (google.storage_v1.types.Channel):
            Properties of the channel to be inserted.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    bucket = proto.Field(
        proto.STRING,
        number=1,
    )
    versions = proto.Field(
        proto.BOOL,
        number=2,
    )
    delimiter = proto.Field(
        proto.STRING,
        number=3,
    )
    max_results = proto.Field(
        proto.INT32,
        number=4,
    )
    prefix = proto.Field(
        proto.STRING,
        number=5,
    )
    include_trailing_delimiter = proto.Field(
        proto.BOOL,
        number=6,
    )
    page_token = proto.Field(
        proto.STRING,
        number=7,
    )
    projection = proto.Field(
        proto.ENUM,
        number=8,
        enum=storage_resources.CommonEnums.Projection,
    )
    channel = proto.Field(
        proto.MESSAGE,
        number=10,
        message=storage_resources.Channel,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=11,
        message='CommonRequestParams',
    )


class GetProjectServiceAccountRequest(proto.Message):
    r"""Request message for GetProjectServiceAccount.
    Attributes:
        project_id (str):
            Required. Project ID.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class CreateHmacKeyRequest(proto.Message):
    r"""
    Attributes:
        project_id (str):
            Required. The project that the HMAC-owning
            service account lives in.
        service_account_email (str):
            Required. The service account to create the
            HMAC for.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    service_account_email = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class CreateHmacKeyResponse(proto.Message):
    r"""Create hmac response.  The only time the secret for an HMAC
    will be returned.

    Attributes:
        metadata (google.storage_v1.types.HmacKeyMetadata):
            Key metadata.
        secret (str):
            HMAC key secret material.
    """

    metadata = proto.Field(
        proto.MESSAGE,
        number=1,
        message=storage_resources.HmacKeyMetadata,
    )
    secret = proto.Field(
        proto.STRING,
        number=2,
    )


class DeleteHmacKeyRequest(proto.Message):
    r"""Request object to delete a given HMAC key.
    Attributes:
        access_id (str):
            Required. The identifying key for the HMAC to
            delete.
        project_id (str):
            Required. The project id the HMAC key lies
            in.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    access_id = proto.Field(
        proto.STRING,
        number=1,
    )
    project_id = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class GetHmacKeyRequest(proto.Message):
    r"""Request object to get metadata on a given HMAC key.
    Attributes:
        access_id (str):
            Required. The identifying key for the HMAC to
            delete.
        project_id (str):
            Required. The project id the HMAC key lies
            in.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    access_id = proto.Field(
        proto.STRING,
        number=1,
    )
    project_id = proto.Field(
        proto.STRING,
        number=2,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=3,
        message='CommonRequestParams',
    )


class ListHmacKeysRequest(proto.Message):
    r"""Request to fetch a list of HMAC keys under a given project.
    Attributes:
        project_id (str):
            Required. The project id to list HMAC keys
            for.
        service_account_email (str):
            An optional filter to only return HMAC keys
            for one service account.
        show_deleted_keys (bool):
            An optional bool to return deleted keys that
            have not been wiped out yet.
        max_results (int):
            The maximum number of keys to return.
        page_token (str):
            A previously returned token from
            ListHmacKeysResponse to get the next page.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    service_account_email = proto.Field(
        proto.STRING,
        number=2,
    )
    show_deleted_keys = proto.Field(
        proto.BOOL,
        number=3,
    )
    max_results = proto.Field(
        proto.INT32,
        number=4,
    )
    page_token = proto.Field(
        proto.STRING,
        number=5,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=6,
        message='CommonRequestParams',
    )


class ListHmacKeysResponse(proto.Message):
    r"""Hmac key list response with next page information.
    Attributes:
        next_page_token (str):
            The continuation token, used to page through
            large result sets. Provide this value in a
            subsequent request to return the next page of
            results.
        items (Sequence[google.storage_v1.types.HmacKeyMetadata]):
            The list of items.
    """

    @property
    def raw_page(self):
        return self

    next_page_token = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=storage_resources.HmacKeyMetadata,
    )


class UpdateHmacKeyRequest(proto.Message):
    r"""Request object to update an HMAC key state.
    Attributes:
        access_id (str):
            Required. The id of the HMAC key.
        project_id (str):
            Required. The project id the HMAC's service
            account lies in.
        metadata (google.storage_v1.types.HmacKeyMetadata):
            Required. The service account owner of the
            HMAC key.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    access_id = proto.Field(
        proto.STRING,
        number=1,
    )
    project_id = proto.Field(
        proto.STRING,
        number=2,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=3,
        message=storage_resources.HmacKeyMetadata,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=5,
        message='CommonRequestParams',
    )


class GetIamPolicyRequest(proto.Message):
    r"""A wrapper around the IAM get policy request to support our
    common_request_params.

    Attributes:
        iam_request (google.iam.v1.iam_policy_pb2.GetIamPolicyRequest):
            The request sent to IAM.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    iam_request = proto.Field(
        proto.MESSAGE,
        number=1,
        message=iam_policy.GetIamPolicyRequest,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=2,
        message='CommonRequestParams',
    )


class SetIamPolicyRequest(proto.Message):
    r"""A wrapper around the IAM set policy request to support our
    common_request_params.

    Attributes:
        iam_request (google.iam.v1.iam_policy_pb2.SetIamPolicyRequest):
            The request sent to IAM.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    iam_request = proto.Field(
        proto.MESSAGE,
        number=1,
        message=iam_policy.SetIamPolicyRequest,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=2,
        message='CommonRequestParams',
    )


class TestIamPermissionsRequest(proto.Message):
    r"""A wrapper around the IAM test iam permissions request to support our
    common_request_params.

    Attributes:
        iam_request (google.iam.v1.iam_policy_pb2.TestIamPermissionsRequest):
            The request sent to IAM.
        common_request_params (google.storage_v1.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    iam_request = proto.Field(
        proto.MESSAGE,
        number=1,
        message=iam_policy.TestIamPermissionsRequest,
    )
    common_request_params = proto.Field(
        proto.MESSAGE,
        number=2,
        message='CommonRequestParams',
    )


class CommonObjectRequestParams(proto.Message):
    r"""Parameters that can be passed to any object request.
    Attributes:
        encryption_algorithm (str):
            Encryption algorithm used with Customer-
            upplied Encryption Keys feature.
        encryption_key (str):
            Encryption key used with Customer-Supplied
            Encryption Keys feature.
        encryption_key_sha256 (str):
            SHA256 hash of encryption key used with
            Customer-Supplied Encryption Keys feature.
    """

    encryption_algorithm = proto.Field(
        proto.STRING,
        number=1,
    )
    encryption_key = proto.Field(
        proto.STRING,
        number=2,
    )
    encryption_key_sha256 = proto.Field(
        proto.STRING,
        number=3,
    )


class CommonRequestParams(proto.Message):
    r"""Parameters that can be passed to any request.
    Attributes:
        user_project (str):
            Required. Required when using buckets with
            Requestor Pays feature enabled.
        quota_user (str):
            Lets you enforce per-user quotas from a server-side
            application even in cases when the user's IP address is
            unknown. This can occur, for example, with applications that
            run cron jobs on App Engine on a user's behalf. You can
            choose any arbitrary string that uniquely identifies a user,
            but it is limited to 40 characters. Overrides user_ip if
            both are provided.
        fields (google.protobuf.field_mask_pb2.FieldMask):
            Subset of fields to include in the response.
    """

    user_project = proto.Field(
        proto.STRING,
        number=1,
    )
    quota_user = proto.Field(
        proto.STRING,
        number=2,
    )
    fields = proto.Field(
        proto.MESSAGE,
        number=4,
        message=field_mask.FieldMask,
    )


class ServiceConstants(proto.Message):
    r"""Shared constants.    """
    class Values(proto.Enum):
        r"""A collection of constant values meaningful to the Storage
        API.
        """
         _pb_options = {'allow_alias': True}
        VALUES_UNSPECIFIED = 0
        MAX_READ_CHUNK_BYTES = 2097152
        MAX_WRITE_CHUNK_BYTES = 2097152
        MAX_OBJECT_SIZE_MB = 5242880
        MAX_CUSTOM_METADATA_FIELD_NAME_BYTES = 1024
        MAX_CUSTOM_METADATA_FIELD_VALUE_BYTES = 4096
        MAX_CUSTOM_METADATA_TOTAL_SIZE_BYTES = 8192
        MAX_BUCKET_METADATA_TOTAL_SIZE_BYTES = 20480
        MAX_NOTIFICATION_CONFIGS_PER_BUCKET = 100
        MAX_LIFECYCLE_RULES_PER_BUCKET = 100
        MAX_NOTIFICATION_CUSTOM_ATTRIBUTES = 5
        MAX_NOTIFICATION_CUSTOM_ATTRIBUTE_KEY_LENGTH = 256
        MAX_NOTIFICATION_CUSTOM_ATTRIBUTE_VALUE_LENGTH = 1024
        MAX_LABELS_ENTRIES_COUNT = 64
        MAX_LABELS_KEY_VALUE_LENGTH = 63
        MAX_LABELS_KEY_VALUE_BYTES = 128
        MAX_OBJECT_IDS_PER_DELETE_OBJECTS_REQUEST = 1000
        SPLIT_TOKEN_MAX_VALID_DAYS = 14


__all__ = tuple(sorted(__protobuf__.manifest))
