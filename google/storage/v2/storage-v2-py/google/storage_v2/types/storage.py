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

from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.storage.v2',
    manifest={
        'PredefinedObjectAcl',
        'ReadObjectRequest',
        'GetObjectRequest',
        'ReadObjectResponse',
        'WriteObjectSpec',
        'WriteObjectRequest',
        'WriteObjectResponse',
        'QueryWriteStatusRequest',
        'QueryWriteStatusResponse',
        'StartResumableWriteRequest',
        'StartResumableWriteResponse',
        'CommonObjectRequestParams',
        'CommonRequestParams',
        'ServiceConstants',
        'Bucket',
        'BucketAccessControl',
        'ChecksummedData',
        'ObjectChecksums',
        'Object',
        'ObjectAccessControl',
        'ProjectTeam',
        'Owner',
        'ContentRange',
    },
)


class PredefinedObjectAcl(proto.Enum):
    r"""Predefined or "canned" aliases for sets of specific object
    ACL entries.
    """
    PREDEFINED_OBJECT_ACL_UNSPECIFIED = 0
    OBJECT_ACL_AUTHENTICATED_READ = 1
    OBJECT_ACL_BUCKET_OWNER_FULL_CONTROL = 2
    OBJECT_ACL_BUCKET_OWNER_READ = 3
    OBJECT_ACL_PRIVATE = 4
    OBJECT_ACL_PROJECT_PRIVATE = 5
    OBJECT_ACL_PUBLIC_READ = 6


class ReadObjectRequest(proto.Message):
    r"""Request message for ReadObject.
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
            ReadObjectRequest with ``read_offset`` = -5 and
            ``read_limit`` = 3 would return bytes 10 through 12 of the
            object. Requesting a negative offset whose magnitude is
            larger than the size of the object will result in an error.
        read_limit (int):
            The maximum number of ``data`` bytes the server is allowed
            to return in the sum of all ``Object`` messages. A
            ``read_limit`` of zero indicates that there is no limit, and
            a negative ``read_limit`` will cause an error.

            If the stream returns fewer bytes than allowed by the
            ``read_limit`` and no error occurred, the stream includes
            all data from the ``read_offset`` to the end of the
            resource.
        if_generation_match (int):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (int):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (int):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (int):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        common_object_request_params (google.storage_v2.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v2.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
        read_mask (google.protobuf.field_mask_pb2.FieldMask):
            Mask specifying which fields to read. The checksummed_data
            field and its children will always be present. If no mask is
            specified, will default to all fields except metadata.owner
            and metadata.acl.

            -  may be used to mean "all fields".
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
        proto.INT64,
        number=6,
        optional=True,
    )
    if_generation_not_match = proto.Field(
        proto.INT64,
        number=7,
        optional=True,
    )
    if_metageneration_match = proto.Field(
        proto.INT64,
        number=8,
        optional=True,
    )
    if_metageneration_not_match = proto.Field(
        proto.INT64,
        number=9,
        optional=True,
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
    read_mask = proto.Field(
        proto.MESSAGE,
        number=12,
        optional=True,
        message=field_mask_pb2.FieldMask,
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
        if_generation_match (int):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (int):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (int):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (int):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
        common_object_request_params (google.storage_v2.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v2.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
        read_mask (google.protobuf.field_mask_pb2.FieldMask):
            Mask specifying which fields to read. If no mask is
            specified, will default to all fields except metadata.acl
            and metadata.owner.

            -  may be used to mean "all fields".
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
        proto.INT64,
        number=4,
        optional=True,
    )
    if_generation_not_match = proto.Field(
        proto.INT64,
        number=5,
        optional=True,
    )
    if_metageneration_match = proto.Field(
        proto.INT64,
        number=6,
        optional=True,
    )
    if_metageneration_not_match = proto.Field(
        proto.INT64,
        number=7,
        optional=True,
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
    read_mask = proto.Field(
        proto.MESSAGE,
        number=10,
        optional=True,
        message=field_mask_pb2.FieldMask,
    )


class ReadObjectResponse(proto.Message):
    r"""Response message for GetObject.
    Attributes:
        checksummed_data (google.storage_v2.types.ChecksummedData):
            A portion of the data for the object. The service **may**
            leave ``data`` empty for any given ``ReadResponse``. This
            enables the service to inform the client that the request is
            still live while it is running an operation to generate more
            data.
        object_checksums (google.storage_v2.types.ObjectChecksums):
            The checksums of the complete object. The
            client should compute one of these checksums
            over the downloaded object and compare it
            against the value provided here.
        content_range (google.storage_v2.types.ContentRange):
            If read_offset and or read_limit was specified on the
            ReadObjectRequest, ContentRange will be populated on the
            first ReadObjectResponse message of the read stream.
        metadata (google.storage_v2.types.Object):
            Metadata of the object whose media is being
            returned. Only populated in the first response
            in the stream.
    """

    checksummed_data = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ChecksummedData',
    )
    object_checksums = proto.Field(
        proto.MESSAGE,
        number=2,
        message='ObjectChecksums',
    )
    content_range = proto.Field(
        proto.MESSAGE,
        number=3,
        message='ContentRange',
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=4,
        message='Object',
    )


class WriteObjectSpec(proto.Message):
    r"""Describes an attempt to insert an object, possibly over
    multiple requests.

    Attributes:
        resource (google.storage_v2.types.Object):
            Destination object, including its name and
            its metadata.
        predefined_acl (google.storage_v2.types.PredefinedObjectAcl):
            Apply a predefined set of access controls to
            this object.
        if_generation_match (int):
            Makes the operation conditional on whether
            the object's current generation matches the
            given value. Setting to 0 makes the operation
            succeed only if there are no live versions of
            the object.
        if_generation_not_match (int):
            Makes the operation conditional on whether
            the object's current generation does not match
            the given value. If no live object exists, the
            precondition fails. Setting to 0 makes the
            operation succeed only if there is a live
            version of the object.
        if_metageneration_match (int):
            Makes the operation conditional on whether
            the object's current metageneration matches the
            given value.
        if_metageneration_not_match (int):
            Makes the operation conditional on whether
            the object's current metageneration does not
            match the given value.
    """

    resource = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Object',
    )
    predefined_acl = proto.Field(
        proto.ENUM,
        number=2,
        enum='PredefinedObjectAcl',
    )
    if_generation_match = proto.Field(
        proto.INT64,
        number=3,
        optional=True,
    )
    if_generation_not_match = proto.Field(
        proto.INT64,
        number=4,
        optional=True,
    )
    if_metageneration_match = proto.Field(
        proto.INT64,
        number=5,
        optional=True,
    )
    if_metageneration_not_match = proto.Field(
        proto.INT64,
        number=6,
        optional=True,
    )


class WriteObjectRequest(proto.Message):
    r"""Request message for WriteObject.
    Attributes:
        upload_id (str):
            For resumable uploads. This should be the ``upload_id``
            returned from a call to ``StartResumableWriteResponse``.
        write_object_spec (google.storage_v2.types.WriteObjectSpec):
            For non-resumable uploads. Describes the
            overall upload, including the destination bucket
            and object name, preconditions, etc.
        write_offset (int):
            Required. The offset from the beginning of the object at
            which the data should be written.

            In the first ``WriteObjectRequest`` of a ``WriteObject()``
            action, it indicates the initial offset for the ``Write()``
            call. The value **must** be equal to the ``committed_size``
            that a call to ``QueryWriteStatus()`` would return (0 if
            this is the first write to the object).

            On subsequent calls, this value **must** be no larger than
            the sum of the first ``write_offset`` and the sizes of all
            ``data`` chunks sent previously on this stream.

            An incorrect value will cause an error.
        checksummed_data (google.storage_v2.types.ChecksummedData):
            The data to insert. If a crc32c checksum is
            provided that doesn't match the checksum
            computed by the service, the request will fail.
        object_checksums (google.storage_v2.types.ObjectChecksums):
            Checksums for the complete object. If the checksums computed
            by the service don't match the specifified checksums the
            call will fail. May only be provided in the first or last
            request (either with first_message, or finish_write set).
        finish_write (bool):
            If ``true``, this indicates that the write is complete.
            Sending any ``WriteObjectRequest``\ s subsequent to one in
            which ``finish_write`` is ``true`` will cause an error. For
            a non-resumable write (where the upload_id was not set in
            the first message), it is an error not to set this field in
            the final message of the stream.
        common_object_request_params (google.storage_v2.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v2.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    upload_id = proto.Field(
        proto.STRING,
        number=1,
        oneof='first_message',
    )
    write_object_spec = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='first_message',
        message='WriteObjectSpec',
    )
    write_offset = proto.Field(
        proto.INT64,
        number=3,
    )
    checksummed_data = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='data',
        message='ChecksummedData',
    )
    object_checksums = proto.Field(
        proto.MESSAGE,
        number=6,
        message='ObjectChecksums',
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


class WriteObjectResponse(proto.Message):
    r"""Response message for WriteObject.
    Attributes:
        committed_size (int):
            The total number of bytes that have been processed for the
            given object from all ``WriteObject`` calls. Only set if the
            upload has not finalized.
        resource (google.storage_v2.types.Object):
            A resource containing the metadata for the
            uploaded object. Only set if the upload has
            finalized.
    """

    committed_size = proto.Field(
        proto.INT64,
        number=1,
        oneof='write_status',
    )
    resource = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='write_status',
        message='Object',
    )


class QueryWriteStatusRequest(proto.Message):
    r"""Request object for ``QueryWriteStatus``.
    Attributes:
        upload_id (str):
            Required. The name of the resume token for
            the object whose write status is being
            requested.
        common_object_request_params (google.storage_v2.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v2.types.CommonRequestParams):
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
    r"""Response object for ``QueryWriteStatus``.
    Attributes:
        committed_size (int):
            The total number of bytes that have been processed for the
            given object from all ``WriteObject`` calls. This is the
            correct value for the 'write_offset' field to use when
            resuming the ``WriteObject`` operation. Only set if the
            upload has not finalized.
        resource (google.storage_v2.types.Object):
            A resource containing the metadata for the
            uploaded object. Only set if the upload has
            finalized.
    """

    committed_size = proto.Field(
        proto.INT64,
        number=1,
        oneof='write_status',
    )
    resource = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='write_status',
        message='Object',
    )


class StartResumableWriteRequest(proto.Message):
    r"""Request message StartResumableWrite.
    Attributes:
        write_object_spec (google.storage_v2.types.WriteObjectSpec):
            The destination bucket, object, and metadata,
            as well as any preconditions.
        common_object_request_params (google.storage_v2.types.CommonObjectRequestParams):
            A set of parameters common to Storage API
            requests concerning an object.
        common_request_params (google.storage_v2.types.CommonRequestParams):
            A set of parameters common to all Storage API
            requests.
    """

    write_object_spec = proto.Field(
        proto.MESSAGE,
        number=1,
        message='WriteObjectSpec',
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
    r"""Response object for ``StartResumableWrite``.
    Attributes:
        upload_id (str):
            The upload_id of the newly started resumable write
            operation. This value should be copied into the
            ``WriteObjectRequest.upload_id`` field.
    """

    upload_id = proto.Field(
        proto.STRING,
        number=1,
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
            Required. Required when using buckets with Requestor Pays
            feature enabled. Example: ``projects/123456``.
    """

    user_project = proto.Field(
        proto.STRING,
        number=1,
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


class Bucket(proto.Message):
    r"""A bucket.
    Attributes:
        name (str):
            Immutable. The name of the bucket. Global buckets will be of
            the format ``projects/{project}/buckets/{bucket}``. Other
            sorts of buckets in the future are not guaranteed to follow
            this pattern. For globally unique bucket names, a ``_`` may
            be substituted for the project ID.
        bucket_id (str):
            Output only. The user-chosen part of the bucket name. The
            ``{bucket}`` portion of the ``name`` field. For globally
            unique buckets, this is equal to the "bucket name" of other
            Cloud Storage APIs. Example: "pub".
        project (str):
            Immutable. The project which owns this bucket. Format:
            projects/{project_number} Example: ``projects/123456``.
        metageneration (int):
            Output only. The metadata generation of this bucket.
            Attempting to set or update this field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        location (str):
            Immutable. The location of the bucket. Object data for
            objects in the bucket resides in physical storage within
            this region. Defaults to ``US``. See the
            [https://developers.google.com/storage/docs/concepts-techniques#specifyinglocations"][developer's
            guide] for the authoritative list. Attempting to update this
            field after the bucket is created will result in an error.
        location_type (str):
            Output only. The location type of the bucket
            (region, dual-region, multi-region, etc).
        storage_class (str):
            The bucket's default storage class, used whenever no
            storageClass is specified for a newly-created object. This
            defines how objects in the bucket are stored and determines
            the SLA and the cost of storage. If this value is not
            specified when the bucket is created, it will default to
            ``STANDARD``. For more information, see
            https://developers.google.com/storage/docs/storage-classes.
        acl (Sequence[google.storage_v2.types.BucketAccessControl]):
            Access controls on the bucket.
            If iamConfig.uniformBucketLevelAccess is enabled
            on this bucket, requests to set, read, or modify
            acl is an error.
        default_object_acl (Sequence[google.storage_v2.types.ObjectAccessControl]):
            Default access controls to apply to new
            objects when no ACL is provided. If
            iamConfig.uniformBucketLevelAccess is enabled on
            this bucket, requests to set, read, or modify
            acl is an error.
        lifecycle (google.storage_v2.types.Bucket.Lifecycle):
            The bucket's lifecycle config. See
            [https://developers.google.com/storage/docs/lifecycle]Lifecycle
            Management] for more information.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The creation time of the bucket in
            [https://tools.ietf.org/html/rfc3339][RFC 3339] format.
            Attempting to set or update this field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        cors (Sequence[google.storage_v2.types.Bucket.Cors]):
            The bucket's [https://www.w3.org/TR/cors/][Cross-Origin
            Resource Sharing] (CORS) config.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The modification time of the bucket. Attempting
            to set or update this field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        default_event_based_hold (bool):
            The default value for event-based hold on
            newly created objects in this bucket.  Event-
            based hold is a way to retain objects
            indefinitely until an event occurs, signified by
            the
            hold's release. After being released, such
            objects will be subject to bucket-level
            retention (if any).  One sample use case of this
            flag is for banks to hold loan documents for at
            least 3 years after loan is paid in full. Here,
            bucket-level retention is 3 years and the event
            is loan being paid in full. In this example,
            these objects will be held intact for any number
            of years until the event has occurred (event-
            based hold on the object is released) and then 3
            more years after that. That means retention
            duration of the objects begins from the moment
            event-based hold transitioned from true to
            false.  Objects under event-based hold cannot be
            deleted, overwritten or archived until the hold
            is removed.
        labels (Sequence[google.storage_v2.types.Bucket.LabelsEntry]):
            User-provided labels, in key/value pairs.
        website (google.storage_v2.types.Bucket.Website):
            The bucket's website config, controlling how the service
            behaves when accessing bucket contents as a web site. See
            the
            [https://cloud.google.com/storage/docs/static-website][Static
            Website Examples] for more information.
        versioning (google.storage_v2.types.Bucket.Versioning):
            The bucket's versioning config.
        logging (google.storage_v2.types.Bucket.Logging):
            The bucket's logging config, which defines
            the destination bucket and name prefix (if any)
            for the current bucket's logs.
        owner (google.storage_v2.types.Owner):
            Output only. The owner of the bucket. This is
            always the project team's owner group.
        encryption (google.storage_v2.types.Bucket.Encryption):
            Encryption config for a bucket.
        billing (google.storage_v2.types.Bucket.Billing):
            The bucket's billing config.
        retention_policy (google.storage_v2.types.Bucket.RetentionPolicy):
            The bucket's retention policy. The retention policy enforces
            a minimum retention time for all objects contained in the
            bucket, based on their creation time. Any attempt to
            overwrite or delete objects younger than the retention
            period will result in a PERMISSION_DENIED error. An unlocked
            retention policy can be modified or removed from the bucket
            via a storage.buckets.update operation. A locked retention
            policy cannot be removed or shortened in duration for the
            lifetime of the bucket. Attempting to remove or decrease
            period of a locked retention policy will result in a
            PERMISSION_DENIED error.
        iam_config (google.storage_v2.types.Bucket.IamConfig):
            The bucket's IAM config.
        zone_affinity (Sequence[str]):
            Immutable. The zone or zones from which the
            bucket is intended to use zonal quota. Requests
            for data from outside the specified affinities
            are still allowed but won't be able to use zonal
            quota. The values are case-insensitive.
            Attempting to update this field after bucket is
            created will result in an error.
        satisfies_pzs (bool):
            Reserved for future use.
    """

    class Billing(proto.Message):
        r"""Billing properties of a bucket.
        Attributes:
            requester_pays (bool):
                When set to true, Requester Pays is enabled
                for this bucket.
        """

        requester_pays = proto.Field(
            proto.BOOL,
            number=1,
        )

    class Cors(proto.Message):
        r"""Cross-Origin Response sharing (CORS) properties for a bucket.
        For more on Cloud Storage and CORS, see
        https://cloud.google.com/storage/docs/cross-origin. For more on
        CORS in general, see https://tools.ietf.org/html/rfc6454.

        Attributes:
            origin (Sequence[str]):
                The list of Origins eligible to receive CORS response
                headers. See [https://tools.ietf.org/html/rfc6454][RFC 6454]
                for more on origins. Note: "*" is permitted in the list of
                origins, and means "any Origin".
            method (Sequence[str]):
                The list of HTTP methods on which to include CORS response
                headers, (``GET``, ``OPTIONS``, ``POST``, etc) Note: "*" is
                permitted in the list of methods, and means "any method".
            response_header (Sequence[str]):
                The list of HTTP headers other than the
                [https://www.w3.org/TR/cors/#simple-response-header][simple
                response headers] to give permission for the user-agent to
                share across domains.
            max_age_seconds (int):
                The value, in seconds, to return in the
                [https://www.w3.org/TR/cors/#access-control-max-age-response-header][Access-Control-Max-Age
                header] used in preflight responses.
        """

        origin = proto.RepeatedField(
            proto.STRING,
            number=1,
        )
        method = proto.RepeatedField(
            proto.STRING,
            number=2,
        )
        response_header = proto.RepeatedField(
            proto.STRING,
            number=3,
        )
        max_age_seconds = proto.Field(
            proto.INT32,
            number=4,
        )

    class Encryption(proto.Message):
        r"""Encryption properties of a bucket.
        Attributes:
            default_kms_key (str):
                A Cloud KMS key that will be used to encrypt
                objects inserted into this bucket, if no
                encryption method is specified.
        """

        default_kms_key = proto.Field(
            proto.STRING,
            number=1,
        )

    class IamConfig(proto.Message):
        r"""Bucket restriction options.
        Attributes:
            uniform_bucket_level_access (google.storage_v2.types.Bucket.IamConfig.UniformBucketLevelAccess):
                Bucket restriction options currently enforced
                on the bucket.
            public_access_prevention (google.storage_v2.types.Bucket.IamConfig.PublicAccessPrevention):
                Whether IAM will enforce public access
                prevention.
        """
        class PublicAccessPrevention(proto.Enum):
            r"""Public Access Prevention config values."""
            PUBLIC_ACCESS_PREVENTION_UNSPECIFIED = 0
            ENFORCED = 1

        class UniformBucketLevelAccess(proto.Message):
            r"""Settings for Uniform Bucket level access.
            See https://cloud.google.com/storage/docs/uniform-bucket-level-
            access.

            Attributes:
                enabled (bool):
                    If set, access checks only use bucket-level
                    IAM policies or above.
                lock_time (google.protobuf.timestamp_pb2.Timestamp):
                    The deadline time for changing
                    ``iamConfig.uniformBucketLevelAccess.enabled`` from true to
                    false in `RFC 3339 <https://tools.ietf.org/html/rfc3339>`__.
                    Mutable until the specified deadline is reached, but not
                    afterward.
            """

            enabled = proto.Field(
                proto.BOOL,
                number=1,
            )
            lock_time = proto.Field(
                proto.MESSAGE,
                number=2,
                message=timestamp_pb2.Timestamp,
            )

        uniform_bucket_level_access = proto.Field(
            proto.MESSAGE,
            number=1,
            message='Bucket.IamConfig.UniformBucketLevelAccess',
        )
        public_access_prevention = proto.Field(
            proto.ENUM,
            number=2,
            enum='Bucket.IamConfig.PublicAccessPrevention',
        )

    class Lifecycle(proto.Message):
        r"""Lifecycle properties of a bucket.
        For more information, see
        https://cloud.google.com/storage/docs/lifecycle.

        Attributes:
            rule (Sequence[google.storage_v2.types.Bucket.Lifecycle.Rule]):
                A lifecycle management rule, which is made of
                an action to take and the condition(s) under
                which the action will be taken.
        """

        class Rule(proto.Message):
            r"""A lifecycle Rule, combining an action to take on an object
            and a condition which will trigger that action.

            Attributes:
                action (google.storage_v2.types.Bucket.Lifecycle.Rule.Action):
                    The action to take.
                condition (google.storage_v2.types.Bucket.Lifecycle.Rule.Condition):
                    The condition(s) under which the action will
                    be taken.
            """

            class Action(proto.Message):
                r"""An action to take on an object.
                Attributes:
                    type_ (str):
                        Type of the action. Currently, only ``Delete`` and
                        ``SetStorageClass`` are supported.
                    storage_class (str):
                        Target storage class. Required iff the type
                        of the action is SetStorageClass.
                """

                type_ = proto.Field(
                    proto.STRING,
                    number=1,
                )
                storage_class = proto.Field(
                    proto.STRING,
                    number=2,
                )

            class Condition(proto.Message):
                r"""A condition of an object which triggers some action.
                Attributes:
                    age_days (int):
                        Age of an object (in days). This condition is
                        satisfied when an object reaches the specified
                        age.
                    created_before_time (google.protobuf.timestamp_pb2.Timestamp):
                        A date in [RFC 3339][1] format with only the date part (for
                        instance, "2013-01-15"). This condition is satisfied when an
                        object is created before midnight of the specified date in
                        UTC. [1]: https://tools.ietf.org/html/rfc3339
                    is_live (bool):
                        Relevant only for versioned objects. If the value is
                        ``true``, this condition matches live objects; if the value
                        is ``false``, it matches archived objects.
                    num_newer_versions (int):
                        Relevant only for versioned objects. If the
                        value is N, this condition is satisfied when
                        there are at least N versions (including the
                        live version) newer than this version of the
                        object.
                    matches_storage_class (Sequence[str]):
                        Objects having any of the storage classes specified by this
                        condition will be matched. Values include
                        ``MULTI_REGIONAL``, ``REGIONAL``, ``NEARLINE``,
                        ``COLDLINE``, ``STANDARD``, and
                        ``DURABLE_REDUCED_AVAILABILITY``.
                    matches_pattern (str):
                        A regular expression that satisfies the RE2
                        syntax. This condition is satisfied when the
                        name of the object matches the RE2 pattern.
                        Note: This feature is currently in the "Early
                        Access" launch stage and is only available to an
                        allowlisted set of users; that means that this
                        feature may be changed in backward-incompatible
                        ways and that it is not guaranteed to be
                        released.
                    days_since_custom_time (int):
                        Number of days that has elapsed since the
                        custom timestamp set on an object.
                    custom_time_before_time (google.protobuf.timestamp_pb2.Timestamp):
                        An object matches this condition if the
                        custom timestamp set on the object is before
                        this timestamp.
                    days_since_noncurrent_time (int):
                        This condition is relevant only for versioned
                        objects. An object version satisfies this
                        condition only if these many days have been
                        passed since it became noncurrent. The value of
                        the field must be a nonnegative integer. If it's
                        zero, the object version will become eligible
                        for Lifecycle action as soon as it becomes
                        noncurrent.
                    noncurrent_time_before_time (google.protobuf.timestamp_pb2.Timestamp):
                        This condition is relevant only for versioned
                        objects. An object version satisfies this
                        condition only if it became noncurrent before
                        the specified timestamp.
                """

                age_days = proto.Field(
                    proto.INT32,
                    number=1,
                )
                created_before_time = proto.Field(
                    proto.MESSAGE,
                    number=2,
                    message=timestamp_pb2.Timestamp,
                )
                is_live = proto.Field(
                    proto.BOOL,
                    number=3,
                    optional=True,
                )
                num_newer_versions = proto.Field(
                    proto.INT32,
                    number=4,
                )
                matches_storage_class = proto.RepeatedField(
                    proto.STRING,
                    number=5,
                )
                matches_pattern = proto.Field(
                    proto.STRING,
                    number=6,
                )
                days_since_custom_time = proto.Field(
                    proto.INT32,
                    number=7,
                )
                custom_time_before_time = proto.Field(
                    proto.MESSAGE,
                    number=8,
                    message=timestamp_pb2.Timestamp,
                )
                days_since_noncurrent_time = proto.Field(
                    proto.INT32,
                    number=9,
                )
                noncurrent_time_before_time = proto.Field(
                    proto.MESSAGE,
                    number=10,
                    message=timestamp_pb2.Timestamp,
                )

            action = proto.Field(
                proto.MESSAGE,
                number=1,
                message='Bucket.Lifecycle.Rule.Action',
            )
            condition = proto.Field(
                proto.MESSAGE,
                number=2,
                message='Bucket.Lifecycle.Rule.Condition',
            )

        rule = proto.RepeatedField(
            proto.MESSAGE,
            number=1,
            message='Bucket.Lifecycle.Rule',
        )

    class Logging(proto.Message):
        r"""Logging-related properties of a bucket.
        Attributes:
            log_bucket (str):
                The destination bucket where the current
                bucket's logs should be placed.
            log_object_prefix (str):
                A prefix for log object names.
        """

        log_bucket = proto.Field(
            proto.STRING,
            number=1,
        )
        log_object_prefix = proto.Field(
            proto.STRING,
            number=2,
        )

    class RetentionPolicy(proto.Message):
        r"""Retention policy properties of a bucket.
        Attributes:
            effective_time (google.protobuf.timestamp_pb2.Timestamp):
                Server-determined value that indicates the time from which
                policy was enforced and effective. This value is in
                [https://tools.ietf.org/html/rfc3339][RFC 3339] format.
            is_locked (bool):
                Once locked, an object retention policy
                cannot be modified.
            retention_period (int):
                The duration in seconds that objects need to
                be retained. Retention duration must be greater
                than zero and less than 100 years. Note that
                enforcement of retention periods less than a day
                is not guaranteed. Such periods should only be
                used for testing purposes.
        """

        effective_time = proto.Field(
            proto.MESSAGE,
            number=1,
            message=timestamp_pb2.Timestamp,
        )
        is_locked = proto.Field(
            proto.BOOL,
            number=2,
        )
        retention_period = proto.Field(
            proto.INT64,
            number=3,
        )

    class Versioning(proto.Message):
        r"""Properties of a bucket related to versioning.
        For more on Cloud Storage versioning, see
        https://cloud.google.com/storage/docs/object-versioning.

        Attributes:
            enabled (bool):
                While set to true, versioning is fully
                enabled for this bucket.
        """

        enabled = proto.Field(
            proto.BOOL,
            number=1,
        )

    class Website(proto.Message):
        r"""Properties of a bucket related to accessing the contents as a
        static website. For more on hosting a static website via Cloud
        Storage, see https://cloud.google.com/storage/docs/hosting-
        static-website.

        Attributes:
            main_page_suffix (str):
                If the requested object path is missing, the service will
                ensure the path has a trailing '/', append this suffix, and
                attempt to retrieve the resulting object. This allows the
                creation of ``index.html`` objects to represent directory
                pages.
            not_found_page (str):
                If the requested object path is missing, and any
                ``mainPageSuffix`` object is missing, if applicable, the
                service will return the named object from this bucket as the
                content for a
                [https://tools.ietf.org/html/rfc7231#section-6.5.4][404 Not
                Found] result.
        """

        main_page_suffix = proto.Field(
            proto.STRING,
            number=1,
        )
        not_found_page = proto.Field(
            proto.STRING,
            number=2,
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    bucket_id = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )
    metageneration = proto.Field(
        proto.INT64,
        number=4,
    )
    location = proto.Field(
        proto.STRING,
        number=5,
    )
    location_type = proto.Field(
        proto.STRING,
        number=6,
    )
    storage_class = proto.Field(
        proto.STRING,
        number=7,
    )
    acl = proto.RepeatedField(
        proto.MESSAGE,
        number=8,
        message='BucketAccessControl',
    )
    default_object_acl = proto.RepeatedField(
        proto.MESSAGE,
        number=9,
        message='ObjectAccessControl',
    )
    lifecycle = proto.Field(
        proto.MESSAGE,
        number=10,
        message=Lifecycle,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=11,
        message=timestamp_pb2.Timestamp,
    )
    cors = proto.RepeatedField(
        proto.MESSAGE,
        number=12,
        message=Cors,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=13,
        message=timestamp_pb2.Timestamp,
    )
    default_event_based_hold = proto.Field(
        proto.BOOL,
        number=14,
    )
    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=15,
    )
    website = proto.Field(
        proto.MESSAGE,
        number=16,
        message=Website,
    )
    versioning = proto.Field(
        proto.MESSAGE,
        number=17,
        message=Versioning,
    )
    logging = proto.Field(
        proto.MESSAGE,
        number=18,
        message=Logging,
    )
    owner = proto.Field(
        proto.MESSAGE,
        number=19,
        message='Owner',
    )
    encryption = proto.Field(
        proto.MESSAGE,
        number=20,
        message=Encryption,
    )
    billing = proto.Field(
        proto.MESSAGE,
        number=21,
        message=Billing,
    )
    retention_policy = proto.Field(
        proto.MESSAGE,
        number=22,
        message=RetentionPolicy,
    )
    iam_config = proto.Field(
        proto.MESSAGE,
        number=23,
        message=IamConfig,
    )
    zone_affinity = proto.RepeatedField(
        proto.STRING,
        number=24,
    )
    satisfies_pzs = proto.Field(
        proto.BOOL,
        number=25,
    )


class BucketAccessControl(proto.Message):
    r"""An access-control entry.
    Attributes:
        role (str):
            The access permission for the entity.
        id (str):
            The ID of the access-control entry.
        entity (str):
            The entity holding the permission, in one of the following
            forms:

            -  ``user-{userid}``
            -  ``user-{email}``
            -  ``group-{groupid}``
            -  ``group-{email}``
            -  ``domain-{domain}``
            -  ``project-{team-projectid}``
            -  ``allUsers``
            -  ``allAuthenticatedUsers`` Examples:
            -  The user ``liz@example.com`` would be
               ``user-liz@example.com``.
            -  The group ``example@googlegroups.com`` would be
               ``group-example@googlegroups.com``
            -  All members of the Google Apps for Business domain
               ``example.com`` would be ``domain-example.com``
        entity_id (str):
            The ID for the entity, if any.
        email (str):
            The email address associated with the entity,
            if any.
        domain (str):
            The domain associated with the entity, if
            any.
        project_team (google.storage_v2.types.ProjectTeam):
            The project team associated with the entity,
            if any.
    """

    role = proto.Field(
        proto.STRING,
        number=1,
    )
    id = proto.Field(
        proto.STRING,
        number=2,
    )
    entity = proto.Field(
        proto.STRING,
        number=3,
    )
    entity_id = proto.Field(
        proto.STRING,
        number=4,
    )
    email = proto.Field(
        proto.STRING,
        number=5,
    )
    domain = proto.Field(
        proto.STRING,
        number=6,
    )
    project_team = proto.Field(
        proto.MESSAGE,
        number=7,
        message='ProjectTeam',
    )


class ChecksummedData(proto.Message):
    r"""Message used to convey content being read or written, along
    with an optional checksum.

    Attributes:
        content (bytes):
            The data.
        crc32c (int):
            If set, the CRC32C digest of the content
            field.
    """

    content = proto.Field(
        proto.BYTES,
        number=1,
    )
    crc32c = proto.Field(
        proto.FIXED32,
        number=2,
        optional=True,
    )


class ObjectChecksums(proto.Message):
    r"""Message used for storing full (not subrange) object
    checksums.

    Attributes:
        crc32c (int):
            CRC32C digest of the object data. Computed by
            the Cloud Storage service for all written
            objects. If set in an WriteObjectRequest,
            service will validate that the stored object
            matches this checksum.
        md5_hash (bytes):
            128 bit MD5 hash of the object data. For more information
            about using the MD5 hash, see
            [https://cloud.google.com/storage/docs/hashes-etags#json-api][Hashes
            and ETags: Best Practices]. Not all objects will provide an
            MD5 hash. For example, composite objects provide only crc32c
            hashes. This value is equivalent to running
            ``cat object.txt | openssl md5 -binary``
    """

    crc32c = proto.Field(
        proto.FIXED32,
        number=1,
        optional=True,
    )
    md5_hash = proto.Field(
        proto.BYTES,
        number=2,
    )


class Object(proto.Message):
    r"""An object.
    Attributes:
        name (str):
            Immutable. The name of this object. Nearly any sequence of
            unicode characters is valid. See
            `Guidelines <https://cloud.google.com/storage/docs/naming-objects>`__.
            Example: ``test.txt`` The ``name`` field by itself does not
            uniquely identify a Cloud Storage object. A Cloud Storage
            object is uniquely identified by the tuple of (bucket,
            object, generation).
        bucket (str):
            Immutable. The name of the bucket containing this object.
            Example: ``projects/_/buckets/foo``.
        generation (int):
            Immutable. The content generation of this object. Used for
            object versioning. Attempting to set or update this field
            will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        metageneration (int):
            Output only. The version of the metadata for this generation
            of this object. Used for preconditions and for detecting
            changes in metadata. A metageneration number is only
            meaningful in the context of a particular generation of a
            particular object. Attempting to set or update this field
            will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        storage_class (str):
            Storage class of the object.
        size (int):
            Output only. Content-Length of the object data in bytes,
            matching
            [https://tools.ietf.org/html/rfc7230#section-3.3.2][RFC 7230
            §3.3.2]. Attempting to set or update this field will result
            in a [FieldViolation][google.rpc.BadRequest.FieldViolation].
        content_encoding (str):
            Content-Encoding of the object data, matching
            [https://tools.ietf.org/html/rfc7231#section-3.1.2.2][RFC
            7231 §3.1.2.2]
        content_disposition (str):
            Content-Disposition of the object data, matching
            [https://tools.ietf.org/html/rfc6266][RFC 6266].
        cache_control (str):
            Cache-Control directive for the object data, matching
            [https://tools.ietf.org/html/rfc7234#section-5.2"][RFC 7234
            §5.2]. If omitted, and the object is accessible to all
            anonymous users, the default will be
            ``public, max-age=3600``.
        acl (Sequence[google.storage_v2.types.ObjectAccessControl]):
            Access controls on the object.
            If iamConfig.uniformBucketLevelAccess is enabled
            on the parent bucket, requests to set, read, or
            modify acl is an error.
        content_language (str):
            Content-Language of the object data, matching
            [https://tools.ietf.org/html/rfc7231#section-3.1.3.2][RFC
            7231 §3.1.3.2].
        delete_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The deletion time of the object. Will be
            returned if and only if this version of the object has been
            deleted. Attempting to set or update this field will result
            in a [FieldViolation][google.rpc.BadRequest.FieldViolation].
        content_type (str):
            Content-Type of the object data, matching
            [https://tools.ietf.org/html/rfc7231#section-3.1.1.5][RFC
            7231 §3.1.1.5]. If an object is stored without a
            Content-Type, it is served as ``application/octet-stream``.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The creation time of the object. Attempting to
            set or update this field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        component_count (int):
            Output only. Number of underlying components that make up
            this object. Components are accumulated by compose
            operations. Attempting to set or update this field will
            result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        checksums (google.storage_v2.types.ObjectChecksums):
            Output only. Hashes for the data part of this
            object.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The modification time of the object metadata.
            Attempting to set or update this field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        kms_key (str):
            Cloud KMS Key used to encrypt this object, if
            the object is encrypted by such a key.
        update_storage_class_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time at which the object's storage class
            was last changed. When the object is initially created, it
            will be set to time_created. Attempting to set or update
            this field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        temporary_hold (bool):
            Whether an object is under temporary hold.
            While this flag is set to true, the object is
            protected against deletion and overwrites.  A
            common use case of this flag is regulatory
            investigations where objects need to be retained
            while the investigation is ongoing. Note that
            unlike event-based hold, temporary hold does not
            impact retention expiration time of an object.
        retention_expire_time (google.protobuf.timestamp_pb2.Timestamp):
            A server-determined value that specifies the earliest time
            that the object's retention period expires. This value is in
            [https://tools.ietf.org/html/rfc3339][RFC 3339] format. Note
            1: This field is not provided for objects with an active
            event-based hold, since retention expiration is unknown
            until the hold is removed. Note 2: This value can be
            provided even when temporary hold is set (so that the user
            can reason about policy without having to first unset the
            temporary hold).
        metadata (Sequence[google.storage_v2.types.Object.MetadataEntry]):
            User-provided metadata, in key/value pairs.
        event_based_hold (bool):
            Whether an object is under event-based hold. An event-based
            hold is a way to force the retention of an object until
            after some event occurs. Once the hold is released by
            explicitly setting this field to false, the object will
            become subject to any bucket-level retention policy, except
            that the retention duration will be calculated from the time
            the event based hold was lifted, rather than the time the
            object was created.

            In a WriteObject request, not setting this field implies
            that the value should be taken from the parent bucket's
            "default_event_based_hold" field. In a response, this field
            will always be set to true or false.
        owner (google.storage_v2.types.Owner):
            Output only. The owner of the object. This will always be
            the uploader of the object. Attempting to set or update this
            field will result in a
            [FieldViolation][google.rpc.BadRequest.FieldViolation].
        customer_encryption (google.storage_v2.types.Object.CustomerEncryption):
            Metadata of customer-supplied encryption key,
            if the object is encrypted by such a key.
        custom_time (google.protobuf.timestamp_pb2.Timestamp):
            A user-specified timestamp set on an object.
    """

    class CustomerEncryption(proto.Message):
        r"""Describes the customer-specified mechanism used to store the
        data at rest.

        Attributes:
            encryption_algorithm (str):
                The encryption algorithm.
            key_sha256 (str):
                SHA256 hash value of the encryption key.
        """

        encryption_algorithm = proto.Field(
            proto.STRING,
            number=1,
        )
        key_sha256 = proto.Field(
            proto.STRING,
            number=2,
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    bucket = proto.Field(
        proto.STRING,
        number=2,
    )
    generation = proto.Field(
        proto.INT64,
        number=3,
    )
    metageneration = proto.Field(
        proto.INT64,
        number=4,
    )
    storage_class = proto.Field(
        proto.STRING,
        number=5,
    )
    size = proto.Field(
        proto.INT64,
        number=6,
    )
    content_encoding = proto.Field(
        proto.STRING,
        number=7,
    )
    content_disposition = proto.Field(
        proto.STRING,
        number=8,
    )
    cache_control = proto.Field(
        proto.STRING,
        number=9,
    )
    acl = proto.RepeatedField(
        proto.MESSAGE,
        number=10,
        message='ObjectAccessControl',
    )
    content_language = proto.Field(
        proto.STRING,
        number=11,
    )
    delete_time = proto.Field(
        proto.MESSAGE,
        number=12,
        message=timestamp_pb2.Timestamp,
    )
    content_type = proto.Field(
        proto.STRING,
        number=13,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=14,
        message=timestamp_pb2.Timestamp,
    )
    component_count = proto.Field(
        proto.INT32,
        number=15,
    )
    checksums = proto.Field(
        proto.MESSAGE,
        number=16,
        message='ObjectChecksums',
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=17,
        message=timestamp_pb2.Timestamp,
    )
    kms_key = proto.Field(
        proto.STRING,
        number=18,
    )
    update_storage_class_time = proto.Field(
        proto.MESSAGE,
        number=19,
        message=timestamp_pb2.Timestamp,
    )
    temporary_hold = proto.Field(
        proto.BOOL,
        number=20,
    )
    retention_expire_time = proto.Field(
        proto.MESSAGE,
        number=21,
        message=timestamp_pb2.Timestamp,
    )
    metadata = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=22,
    )
    event_based_hold = proto.Field(
        proto.BOOL,
        number=23,
        optional=True,
    )
    owner = proto.Field(
        proto.MESSAGE,
        number=24,
        message='Owner',
    )
    customer_encryption = proto.Field(
        proto.MESSAGE,
        number=25,
        message=CustomerEncryption,
    )
    custom_time = proto.Field(
        proto.MESSAGE,
        number=26,
        message=timestamp_pb2.Timestamp,
    )


class ObjectAccessControl(proto.Message):
    r"""An access-control entry.
    Attributes:
        role (str):
            The access permission for the entity.
        id (str):
            The ID of the access-control entry.
        entity (str):
            The entity holding the permission, in one of the following
            forms:

            -  ``user-{userid}``
            -  ``user-{email}``
            -  ``group-{groupid}``
            -  ``group-{email}``
            -  ``domain-{domain}``
            -  ``project-{team-projectid}``
            -  ``allUsers``
            -  ``allAuthenticatedUsers`` Examples:
            -  The user ``liz@example.com`` would be
               ``user-liz@example.com``.
            -  The group ``example@googlegroups.com`` would be
               ``group-example@googlegroups.com``.
            -  All members of the Google Apps for Business domain
               ``example.com`` would be ``domain-example.com``.
        entity_id (str):
            The ID for the entity, if any.
        email (str):
            The email address associated with the entity,
            if any.
        domain (str):
            The domain associated with the entity, if
            any.
        project_team (google.storage_v2.types.ProjectTeam):
            The project team associated with the entity,
            if any.
    """

    role = proto.Field(
        proto.STRING,
        number=1,
    )
    id = proto.Field(
        proto.STRING,
        number=2,
    )
    entity = proto.Field(
        proto.STRING,
        number=3,
    )
    entity_id = proto.Field(
        proto.STRING,
        number=4,
    )
    email = proto.Field(
        proto.STRING,
        number=5,
    )
    domain = proto.Field(
        proto.STRING,
        number=6,
    )
    project_team = proto.Field(
        proto.MESSAGE,
        number=7,
        message='ProjectTeam',
    )


class ProjectTeam(proto.Message):
    r"""Represents the Viewers, Editors, or Owners of a given
    project.

    Attributes:
        project_number (str):
            The project number.
        team (str):
            The team.
    """

    project_number = proto.Field(
        proto.STRING,
        number=1,
    )
    team = proto.Field(
        proto.STRING,
        number=2,
    )


class Owner(proto.Message):
    r"""The owner of a specific resource.
    Attributes:
        entity (str):
            The entity, in the form ``user-``\ *userId*.
        entity_id (str):
            The ID for the entity.
    """

    entity = proto.Field(
        proto.STRING,
        number=1,
    )
    entity_id = proto.Field(
        proto.STRING,
        number=2,
    )


class ContentRange(proto.Message):
    r"""Specifies a requested range of bytes to download.
    Attributes:
        start (int):
            The starting offset of the object data.
        end (int):
            The ending offset of the object data.
        complete_length (int):
            The complete length of the object data.
    """

    start = proto.Field(
        proto.INT64,
        number=1,
    )
    end = proto.Field(
        proto.INT64,
        number=2,
    )
    complete_length = proto.Field(
        proto.INT64,
        number=3,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
