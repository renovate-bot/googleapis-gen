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
from google.protobuf import wrappers_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.storage.v1',
    manifest={
        'Bucket',
        'BucketAccessControl',
        'ListBucketAccessControlsResponse',
        'ListBucketsResponse',
        'Channel',
        'ListChannelsResponse',
        'ChecksummedData',
        'ObjectChecksums',
        'CommonEnums',
        'ContentRange',
        'HmacKeyMetadata',
        'Notification',
        'ListNotificationsResponse',
        'Object',
        'ObjectAccessControl',
        'ListObjectAccessControlsResponse',
        'ListObjectsResponse',
        'ProjectTeam',
        'ServiceAccount',
        'Owner',
    },
)


class Bucket(proto.Message):
    r"""A bucket.
    Attributes:
        acl (Sequence[google.storage_v1.types.BucketAccessControl]):
            Access controls on the bucket.
        default_object_acl (Sequence[google.storage_v1.types.ObjectAccessControl]):
            Default access controls to apply to new
            objects when no ACL is provided.
        lifecycle (google.storage_v1.types.Bucket.Lifecycle):
            The bucket's lifecycle configuration. See
            [https://developers.google.com/storage/docs/lifecycle]Lifecycle
            Management] for more information.
        time_created (google.protobuf.timestamp_pb2.Timestamp):
            The creation time of the bucket in
            [https://tools.ietf.org/html/rfc3339][RFC 3339] format.
            Attempting to set this field will result in an error.
        id (str):
            The ID of the bucket. For buckets, the ``id`` and ``name``
            properties are the same. Attempting to update this field
            after the bucket is created will result in an error.
        name (str):
            The name of the bucket.
            Attempting to update this field after the bucket
            is created will result in an error.
        project_number (int):
            The project number of the project the bucket
            belongs to. Attempting to set this field will
            result in an error.
        metageneration (int):
            The metadata generation of this bucket.
            Attempting to set this field will result in an
            error.
        cors (Sequence[google.storage_v1.types.Bucket.Cors]):
            The bucket's [https://www.w3.org/TR/cors/][Cross-Origin
            Resource Sharing] (CORS) configuration.
        location (str):
            The location of the bucket. Object data for objects in the
            bucket resides in physical storage within this region.
            Defaults to ``US``. See the
            [https://developers.google.com/storage/docs/concepts-techniques#specifyinglocations"][developer's
            guide] for the authoritative list. Attempting to update this
            field after the bucket is created will result in an error.
        storage_class (str):
            The bucket's default storage class, used whenever no
            storageClass is specified for a newly-created object. This
            defines how objects in the bucket are stored and determines
            the SLA and the cost of storage. If this value is not
            specified when the bucket is created, it will default to
            ``STANDARD``. For more information, see
            https://developers.google.com/storage/docs/storage-classes.
        etag (str):
            HTTP 1.1
            [https://tools.ietf.org/html/rfc7232#section-2.3"]Entity
            tag] for the bucket. Attempting to set this field will
            result in an error.
        updated (google.protobuf.timestamp_pb2.Timestamp):
            The modification time of the bucket.
            Attempting to set this field will result in an
            error.
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
        labels (Sequence[google.storage_v1.types.Bucket.LabelsEntry]):
            User-provided labels, in key/value pairs.
        website (google.storage_v1.types.Bucket.Website):
            The bucket's website configuration, controlling how the
            service behaves when accessing bucket contents as a web
            site. See the
            [https://cloud.google.com/storage/docs/static-website][Static
            Website Examples] for more information.
        versioning (google.storage_v1.types.Bucket.Versioning):
            The bucket's versioning configuration.
        logging (google.storage_v1.types.Bucket.Logging):
            The bucket's logging configuration, which
            defines the destination bucket and optional name
            prefix for the current bucket's logs.
        owner (google.storage_v1.types.Owner):
            The owner of the bucket. This is always the
            project team's owner group.
        encryption (google.storage_v1.types.Bucket.Encryption):
            Encryption configuration for a bucket.
        billing (google.storage_v1.types.Bucket.Billing):
            The bucket's billing configuration.
        retention_policy (google.storage_v1.types.Bucket.RetentionPolicy):
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
        location_type (str):
            The location type of the bucket (region,
            dual-region, multi-region, etc).
        iam_configuration (google.storage_v1.types.Bucket.IamConfiguration):
            The bucket's IAM configuration.
        zone_affinity (Sequence[str]):
            The zone or zones from which the bucket is
            intended to use zonal quota. Requests for data
            from outside the specified affinities are still
            allowed but won’t be able to use zonal quota.
            The values are case-insensitive. Attempting to
            update this field after bucket is created will
            result in an error.
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
        For more on GCS and CORS, see
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
            default_kms_key_name (str):
                A Cloud KMS key that will be used to encrypt
                objects inserted into this bucket, if no
                encryption method is specified.
        """

        default_kms_key_name = proto.Field(
            proto.STRING,
            number=1,
        )

    class IamConfiguration(proto.Message):
        r"""Bucket restriction options currently enforced on the bucket.
        Attributes:
            uniform_bucket_level_access (google.storage_v1.types.Bucket.IamConfiguration.UniformBucketLevelAccess):

        """

        class UniformBucketLevelAccess(proto.Message):
            r"""
            Attributes:
                enabled (bool):
                    If set, access checks only use bucket-level
                    IAM policies or above.
                locked_time (google.protobuf.timestamp_pb2.Timestamp):
                    The deadline time for changing
                    iamConfiguration.uniformBucketLevelAccess.enabled from true
                    to false in [https://tools.ietf.org/html/rfc3339][RFC 3339].
                    After the deadline is passed the field is immutable.
            """

            enabled = proto.Field(
                proto.BOOL,
                number=1,
            )
            locked_time = proto.Field(
                proto.MESSAGE,
                number=2,
                message=timestamp_pb2.Timestamp,
            )

        uniform_bucket_level_access = proto.Field(
            proto.MESSAGE,
            number=1,
            message='Bucket.IamConfiguration.UniformBucketLevelAccess',
        )

    class Lifecycle(proto.Message):
        r"""Lifecycle properties of a bucket.
        For more information, see
        https://cloud.google.com/storage/docs/lifecycle.

        Attributes:
            rule (Sequence[google.storage_v1.types.Bucket.Lifecycle.Rule]):
                A lifecycle management rule, which is made of
                an action to take and the condition(s) under
                which the action will be taken.
        """

        class Rule(proto.Message):
            r"""A lifecycle Rule, combining an action to take on an object
            and a condition which will trigger that action.

            Attributes:
                action (google.storage_v1.types.Bucket.Lifecycle.Rule.Action):
                    The action to take.
                condition (google.storage_v1.types.Bucket.Lifecycle.Rule.Condition):
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
                    age (int):
                        Age of an object (in days). This condition is
                        satisfied when an object reaches the specified
                        age.
                    created_before (google.protobuf.timestamp_pb2.Timestamp):
                        A date in [RFC 3339][1] format with only the date part (for
                        instance, "2013-01-15"). This condition is satisfied when an
                        object is created before midnight of the specified date in
                        UTC. [1]: https://tools.ietf.org/html/rfc3339
                    is_live (google.protobuf.wrappers_pb2.BoolValue):
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
                        Access" launch stage and is only available to a
                        whitelisted set of users; that means that this
                        feature may be changed in backward-incompatible
                        ways and that it is not guaranteed to be
                        released.
                """

                age = proto.Field(
                    proto.INT32,
                    number=1,
                )
                created_before = proto.Field(
                    proto.MESSAGE,
                    number=2,
                    message=timestamp_pb2.Timestamp,
                )
                is_live = proto.Field(
                    proto.MESSAGE,
                    number=3,
                    message=wrappers_pb2.BoolValue,
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
        For more on GCS versioning, see
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
        static website. For more on hosting a static website via GCS,
        see https://cloud.google.com/storage/docs/hosting-static-
        website.

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

    acl = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='BucketAccessControl',
    )
    default_object_acl = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='ObjectAccessControl',
    )
    lifecycle = proto.Field(
        proto.MESSAGE,
        number=3,
        message=Lifecycle,
    )
    time_created = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    id = proto.Field(
        proto.STRING,
        number=5,
    )
    name = proto.Field(
        proto.STRING,
        number=6,
    )
    project_number = proto.Field(
        proto.INT64,
        number=7,
    )
    metageneration = proto.Field(
        proto.INT64,
        number=8,
    )
    cors = proto.RepeatedField(
        proto.MESSAGE,
        number=9,
        message=Cors,
    )
    location = proto.Field(
        proto.STRING,
        number=10,
    )
    storage_class = proto.Field(
        proto.STRING,
        number=11,
    )
    etag = proto.Field(
        proto.STRING,
        number=12,
    )
    updated = proto.Field(
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
    location_type = proto.Field(
        proto.STRING,
        number=23,
    )
    iam_configuration = proto.Field(
        proto.MESSAGE,
        number=24,
        message=IamConfiguration,
    )
    zone_affinity = proto.RepeatedField(
        proto.STRING,
        number=25,
    )


class BucketAccessControl(proto.Message):
    r"""An access-control entry.
    Attributes:
        role (str):
            The access permission for the entity.
        etag (str):
            HTTP 1.1
            ["https://tools.ietf.org/html/rfc7232#section-2.3][Entity
            tag] for the access-control entry.
        id (str):
            The ID of the access-control entry.
        bucket (str):
            The name of the bucket.
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
        project_team (google.storage_v1.types.ProjectTeam):
            The project team associated with the entity,
            if any.
    """

    role = proto.Field(
        proto.STRING,
        number=1,
    )
    etag = proto.Field(
        proto.STRING,
        number=2,
    )
    id = proto.Field(
        proto.STRING,
        number=3,
    )
    bucket = proto.Field(
        proto.STRING,
        number=4,
    )
    entity = proto.Field(
        proto.STRING,
        number=6,
    )
    entity_id = proto.Field(
        proto.STRING,
        number=7,
    )
    email = proto.Field(
        proto.STRING,
        number=8,
    )
    domain = proto.Field(
        proto.STRING,
        number=9,
    )
    project_team = proto.Field(
        proto.MESSAGE,
        number=10,
        message='ProjectTeam',
    )


class ListBucketAccessControlsResponse(proto.Message):
    r"""The response to a call to
    BucketAccessControls.ListBucketAccessControls.

    Attributes:
        items (Sequence[google.storage_v1.types.BucketAccessControl]):
            The list of items.
    """

    items = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='BucketAccessControl',
    )


class ListBucketsResponse(proto.Message):
    r"""The result of a call to Buckets.ListBuckets
    Attributes:
        items (Sequence[google.storage_v1.types.Bucket]):
            The list of items.
        next_page_token (str):
            The continuation token, used to page through
            large result sets. Provide this value in a
            subsequent request to return the next page of
            results.
    """

    @property
    def raw_page(self):
        return self

    items = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Bucket',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class Channel(proto.Message):
    r"""An notification channel used to watch for resource changes.
    Attributes:
        id (str):
            A UUID or similar unique string that
            identifies this channel.
        resource_id (str):
            An opaque ID that identifies the resource
            being watched on this channel. Stable across
            different API versions.
        resource_uri (str):
            A version-specific identifier for the watched
            resource.
        token (str):
            An arbitrary string delivered to the target
            address with each notification delivered over
            this channel. Optional.
        expiration (google.protobuf.timestamp_pb2.Timestamp):
            Date and time of notification channel
            expiration. Optional.
        type_ (str):
            The type of delivery mechanism used for this
            channel.
        address (str):
            The address where notifications are delivered
            for this channel.
        params (Sequence[google.storage_v1.types.Channel.ParamsEntry]):
            Additional parameters controlling delivery
            channel behavior. Optional.
        payload (bool):
            A Boolean value to indicate whether payload
            is wanted. Optional.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    resource_id = proto.Field(
        proto.STRING,
        number=2,
    )
    resource_uri = proto.Field(
        proto.STRING,
        number=3,
    )
    token = proto.Field(
        proto.STRING,
        number=4,
    )
    expiration = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )
    type_ = proto.Field(
        proto.STRING,
        number=6,
    )
    address = proto.Field(
        proto.STRING,
        number=7,
    )
    params = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=8,
    )
    payload = proto.Field(
        proto.BOOL,
        number=9,
    )


class ListChannelsResponse(proto.Message):
    r"""The result of a call to Channels.ListChannels
    Attributes:
        items (Sequence[google.storage_v1.types.ListChannelsResponse.Items]):
            The list of notification channels for a
            bucket.
    """

    class Items(proto.Message):
        r"""
        Attributes:
            channel_id (str):
                User-specified name for a channel. Needed to
                unsubscribe.
            resource_id (str):
                Opaque value generated by GCS representing a
                bucket. Needed to unsubscribe.
            push_url (str):
                Url used to identify where notifications are
                sent to.
            subscriber_email (str):
                Email address of the subscriber.
            creation_time (google.protobuf.timestamp_pb2.Timestamp):
                Time when the channel was created.
        """

        channel_id = proto.Field(
            proto.STRING,
            number=1,
        )
        resource_id = proto.Field(
            proto.STRING,
            number=2,
        )
        push_url = proto.Field(
            proto.STRING,
            number=3,
        )
        subscriber_email = proto.Field(
            proto.STRING,
            number=4,
        )
        creation_time = proto.Field(
            proto.MESSAGE,
            number=5,
            message=timestamp_pb2.Timestamp,
        )

    items = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=Items,
    )


class ChecksummedData(proto.Message):
    r"""Message used to convey content being read or written, along
    with its checksum.

    Attributes:
        content (bytes):
            The data.
        crc32c (google.protobuf.wrappers_pb2.UInt32Value):
            CRC32C digest of the contents.
    """

    content = proto.Field(
        proto.BYTES,
        number=1,
    )
    crc32c = proto.Field(
        proto.MESSAGE,
        number=2,
        message=wrappers_pb2.UInt32Value,
    )


class ObjectChecksums(proto.Message):
    r"""Message used for storing full (not subrange) object
    checksums.

    Attributes:
        crc32c (google.protobuf.wrappers_pb2.UInt32Value):
            CRC32C digest of the object data. Computed by
            the GCS service for all written objects, and
            validated by the GCS service against client-
            supplied values if present in an
            InsertObjectRequest.
        md5_hash (str):
            Hex-encoded MD5 hash of the object data
            (hexdigest). Whether/how this checksum is
            provided and validated is service-dependent.
    """

    crc32c = proto.Field(
        proto.MESSAGE,
        number=1,
        message=wrappers_pb2.UInt32Value,
    )
    md5_hash = proto.Field(
        proto.STRING,
        number=2,
    )


class CommonEnums(proto.Message):
    r"""A collection of enums used in multiple places throughout the
    API.
        """
    class Projection(proto.Enum):
        r"""A set of properties to return in a response."""
        PROJECTION_UNSPECIFIED = 0
        NO_ACL = 1
        FULL = 2

    class PredefinedBucketAcl(proto.Enum):
        r"""Predefined or "canned" aliases for sets of specific bucket
        ACL entries.
        """
        PREDEFINED_BUCKET_ACL_UNSPECIFIED = 0
        BUCKET_ACL_AUTHENTICATED_READ = 1
        BUCKET_ACL_PRIVATE = 2
        BUCKET_ACL_PROJECT_PRIVATE = 3
        BUCKET_ACL_PUBLIC_READ = 4
        BUCKET_ACL_PUBLIC_READ_WRITE = 5

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


class HmacKeyMetadata(proto.Message):
    r"""Hmac Key Metadata, which includes all information other than
    the secret.

    Attributes:
        id (str):
            Resource name ID of the key in the format
            <projectId>/<accessId>.
        access_id (str):
            Globally unique id for keys.
        project_id (str):
            The project ID that the hmac key is contained
            in.
        service_account_email (str):
            Email of the service account the key
            authenticates as.
        state (str):
            State of the key. One of ACTIVE, INACTIVE, or
            DELETED.
        time_created (google.protobuf.timestamp_pb2.Timestamp):
            The creation time of the HMAC key in RFC 3339
            format.
        updated (google.protobuf.timestamp_pb2.Timestamp):
            The last modification time of the HMAC key
            metadata in RFC 3339 format.
        etag (str):
            Tag updated with each key update.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    access_id = proto.Field(
        proto.STRING,
        number=2,
    )
    project_id = proto.Field(
        proto.STRING,
        number=3,
    )
    service_account_email = proto.Field(
        proto.STRING,
        number=4,
    )
    state = proto.Field(
        proto.STRING,
        number=5,
    )
    time_created = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    updated = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )
    etag = proto.Field(
        proto.STRING,
        number=8,
    )


class Notification(proto.Message):
    r"""A subscription to receive Google PubSub notifications.
    Attributes:
        topic (str):
            The Cloud PubSub topic to which this
            subscription publishes. Formatted as:
            '//pubsub.googleapis.com/projects/{project-
            identifier}/topics/{my-topic}'
        event_types (Sequence[str]):
            If present, only send notifications about
            listed event types. If empty, sent notifications
            for all event types.
        custom_attributes (Sequence[google.storage_v1.types.Notification.CustomAttributesEntry]):
            An optional list of additional attributes to
            attach to each Cloud PubSub message published
            for this notification subscription.
        etag (str):
            HTTP 1.1
            [https://tools.ietf.org/html/rfc7232#section-2.3][Entity
            tag] for this subscription notification.
        object_name_prefix (str):
            If present, only apply this notification
            configuration to object names that begin with
            this prefix.
        payload_format (str):
            The desired content of the Payload.
        id (str):
            The ID of the notification.
    """

    topic = proto.Field(
        proto.STRING,
        number=1,
    )
    event_types = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    custom_attributes = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=3,
    )
    etag = proto.Field(
        proto.STRING,
        number=4,
    )
    object_name_prefix = proto.Field(
        proto.STRING,
        number=5,
    )
    payload_format = proto.Field(
        proto.STRING,
        number=6,
    )
    id = proto.Field(
        proto.STRING,
        number=7,
    )


class ListNotificationsResponse(proto.Message):
    r"""The result of a call to Notifications.ListNotifications
    Attributes:
        items (Sequence[google.storage_v1.types.Notification]):
            The list of items.
    """

    items = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Notification',
    )


class Object(proto.Message):
    r"""An object.
    Attributes:
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
        acl (Sequence[google.storage_v1.types.ObjectAccessControl]):
            Access controls on the object.
        content_language (str):
            Content-Language of the object data, matching
            [https://tools.ietf.org/html/rfc7231#section-3.1.3.2][RFC
            7231 §3.1.3.2].
        metageneration (int):
            The version of the metadata for this object
            at this generation. Used for preconditions and
            for detecting changes in metadata. A
            metageneration number is only meaningful in the
            context of a particular generation of a
            particular object.
            Attempting to set this field will result in an
            error.
        time_deleted (google.protobuf.timestamp_pb2.Timestamp):
            The deletion time of the object. Will be
            returned if and only if this version of the
            object has been deleted. Attempting to set this
            field will result in an error.
        content_type (str):
            Content-Type of the object data, matching
            [https://tools.ietf.org/html/rfc7231#section-3.1.1.5][RFC
            7231 §3.1.1.5]. If an object is stored without a
            Content-Type, it is served as ``application/octet-stream``.
        size (int):
            Content-Length of the object data in bytes, matching
            [https://tools.ietf.org/html/rfc7230#section-3.3.2][RFC 7230
            §3.3.2]. Attempting to set this field will result in an
            error.
        time_created (google.protobuf.timestamp_pb2.Timestamp):
            The creation time of the object.
            Attempting to set this field will result in an
            error.
        crc32c (google.protobuf.wrappers_pb2.UInt32Value):
            CRC32c checksum. For more information about using the CRC32c
            checksum, see
            [https://cloud.google.com/storage/docs/hashes-etags#_JSONAPI][Hashes
            and ETags: Best Practices]. This is a server determined
            value and should not be supplied by the user when sending an
            Object. The server will ignore any value provided. Users
            should instead use the object_checksums field on the
            InsertObjectRequest when uploading an object.
        component_count (int):
            Number of underlying components that make up
            this object. Components are accumulated by
            compose operations. Attempting to set this field
            will result in an error.
        md5_hash (str):
            MD5 hash of the data; encoded using base64 as per
            [https://tools.ietf.org/html/rfc4648#section-4][RFC 4648
            §4]. For more information about using the MD5 hash, see
            [https://cloud.google.com/storage/docs/hashes-etags#_JSONAPI][Hashes
            and ETags: Best Practices]. This is a server determined
            value and should not be supplied by the user when sending an
            Object. The server will ignore any value provided. Users
            should instead use the object_checksums field on the
            InsertObjectRequest when uploading an object.
        etag (str):
            HTTP 1.1 Entity tag for the object. See
            [https://tools.ietf.org/html/rfc7232#section-2.3][RFC 7232
            §2.3]. Attempting to set this field will result in an error.
        updated (google.protobuf.timestamp_pb2.Timestamp):
            The modification time of the object metadata.
            Attempting to set this field will result in an
            error.
        storage_class (str):
            Storage class of the object.
        kms_key_name (str):
            Cloud KMS Key used to encrypt this object, if
            the object is encrypted by such a key.
        time_storage_class_updated (google.protobuf.timestamp_pb2.Timestamp):
            The time at which the object's storage class was last
            changed. When the object is initially created, it will be
            set to time_created. Attempting to set this field will
            result in an error.
        temporary_hold (bool):
            Whether an object is under temporary hold.
            While this flag is set to true, the object is
            protected against deletion and overwrites.  A
            common use case of this flag is regulatory
            investigations where objects need to be retained
            while the investigation is ongoing. Note that
            unlike event-based hold, temporary hold does not
            impact retention expiration time of an object.
        retention_expiration_time (google.protobuf.timestamp_pb2.Timestamp):
            A server-determined value that specifies the earliest time
            that the object's retention period expires. This value is in
            [https://tools.ietf.org/html/rfc3339][RFC 3339] format. Note
            1: This field is not provided for objects with an active
            event-based hold, since retention expiration is unknown
            until the hold is removed. Note 2: This value can be
            provided even when temporary hold is set (so that the user
            can reason about policy without having to first unset the
            temporary hold).
        metadata (Sequence[google.storage_v1.types.Object.MetadataEntry]):
            User-provided metadata, in key/value pairs.
        event_based_hold (google.protobuf.wrappers_pb2.BoolValue):
            Whether an object is under event-based hold.
            Event-based hold is a way to retain objects
            until an event occurs, which is signified by the
            hold's release (i.e. this value is set to
            false). After being released (set to false),
            such objects will be subject to bucket-level
            retention (if any). One sample use case of this
            flag is for banks to hold loan documents for at
            least 3 years after loan is paid in full. Here,
            bucket-level retention is 3 years and the event
            is the loan being paid in full. In this example,
            these objects will be held intact for any number
            of years until the event has occurred (event-
            based hold on the object is released) and then 3
            more years after that. That means retention
            duration of the objects begins from the moment
            event-based hold transitioned from true to
            false.
        name (str):
            The name of the object.
            Attempting to update this field after the object
            is created will result in an error.
        id (str):
            The ID of the object, including the bucket
            name, object name, and generation number.
            Attempting to update this field after the object
            is created will result in an error.
        bucket (str):
            The name of the bucket containing this
            object. Attempting to update this field after
            the object is created will result in an error.
        generation (int):
            The content generation of this object. Used
            for object versioning. Attempting to set this
            field will result in an error.
        owner (google.storage_v1.types.Owner):
            The owner of the object. This will always be
            the uploader of the object. Attempting to set
            this field will result in an error.
        customer_encryption (google.storage_v1.types.Object.CustomerEncryption):
            Metadata of customer-supplied encryption key,
            if the object is encrypted by such a key.
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

    content_encoding = proto.Field(
        proto.STRING,
        number=1,
    )
    content_disposition = proto.Field(
        proto.STRING,
        number=2,
    )
    cache_control = proto.Field(
        proto.STRING,
        number=3,
    )
    acl = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message='ObjectAccessControl',
    )
    content_language = proto.Field(
        proto.STRING,
        number=5,
    )
    metageneration = proto.Field(
        proto.INT64,
        number=6,
    )
    time_deleted = proto.Field(
        proto.MESSAGE,
        number=7,
        message=timestamp_pb2.Timestamp,
    )
    content_type = proto.Field(
        proto.STRING,
        number=8,
    )
    size = proto.Field(
        proto.INT64,
        number=9,
    )
    time_created = proto.Field(
        proto.MESSAGE,
        number=10,
        message=timestamp_pb2.Timestamp,
    )
    crc32c = proto.Field(
        proto.MESSAGE,
        number=11,
        message=wrappers_pb2.UInt32Value,
    )
    component_count = proto.Field(
        proto.INT32,
        number=12,
    )
    md5_hash = proto.Field(
        proto.STRING,
        number=13,
    )
    etag = proto.Field(
        proto.STRING,
        number=14,
    )
    updated = proto.Field(
        proto.MESSAGE,
        number=15,
        message=timestamp_pb2.Timestamp,
    )
    storage_class = proto.Field(
        proto.STRING,
        number=16,
    )
    kms_key_name = proto.Field(
        proto.STRING,
        number=17,
    )
    time_storage_class_updated = proto.Field(
        proto.MESSAGE,
        number=18,
        message=timestamp_pb2.Timestamp,
    )
    temporary_hold = proto.Field(
        proto.BOOL,
        number=19,
    )
    retention_expiration_time = proto.Field(
        proto.MESSAGE,
        number=20,
        message=timestamp_pb2.Timestamp,
    )
    metadata = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=21,
    )
    event_based_hold = proto.Field(
        proto.MESSAGE,
        number=29,
        message=wrappers_pb2.BoolValue,
    )
    name = proto.Field(
        proto.STRING,
        number=23,
    )
    id = proto.Field(
        proto.STRING,
        number=24,
    )
    bucket = proto.Field(
        proto.STRING,
        number=25,
    )
    generation = proto.Field(
        proto.INT64,
        number=26,
    )
    owner = proto.Field(
        proto.MESSAGE,
        number=27,
        message='Owner',
    )
    customer_encryption = proto.Field(
        proto.MESSAGE,
        number=28,
        message=CustomerEncryption,
    )


class ObjectAccessControl(proto.Message):
    r"""An access-control entry.
    Attributes:
        role (str):
            The access permission for the entity.
        etag (str):
            HTTP 1.1 Entity tag for the access-control entry. See
            [https://tools.ietf.org/html/rfc7232#section-2.3][RFC 7232
            §2.3].
        id (str):
            The ID of the access-control entry.
        bucket (str):
            The name of the bucket.
        object_ (str):
            The name of the object, if applied to an
            object.
        generation (int):
            The content generation of the object, if
            applied to an object.
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
        project_team (google.storage_v1.types.ProjectTeam):
            The project team associated with the entity,
            if any.
    """

    role = proto.Field(
        proto.STRING,
        number=1,
    )
    etag = proto.Field(
        proto.STRING,
        number=2,
    )
    id = proto.Field(
        proto.STRING,
        number=3,
    )
    bucket = proto.Field(
        proto.STRING,
        number=4,
    )
    object_ = proto.Field(
        proto.STRING,
        number=5,
    )
    generation = proto.Field(
        proto.INT64,
        number=6,
    )
    entity = proto.Field(
        proto.STRING,
        number=7,
    )
    entity_id = proto.Field(
        proto.STRING,
        number=8,
    )
    email = proto.Field(
        proto.STRING,
        number=9,
    )
    domain = proto.Field(
        proto.STRING,
        number=10,
    )
    project_team = proto.Field(
        proto.MESSAGE,
        number=11,
        message='ProjectTeam',
    )


class ListObjectAccessControlsResponse(proto.Message):
    r"""The result of a call to
    ObjectAccessControls.ListObjectAccessControls.

    Attributes:
        items (Sequence[google.storage_v1.types.ObjectAccessControl]):
            The list of items.
    """

    items = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='ObjectAccessControl',
    )


class ListObjectsResponse(proto.Message):
    r"""The result of a call to Objects.ListObjects
    Attributes:
        prefixes (Sequence[str]):
            The list of prefixes of objects matching-but-
            ot-listed up to and including the requested
            delimiter.
        items (Sequence[google.storage_v1.types.Object]):
            The list of items.
        next_page_token (str):
            The continuation token, used to page through
            large result sets. Provide this value in a
            subsequent request to return the next page of
            results.
    """

    @property
    def raw_page(self):
        return self

    prefixes = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Object',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=3,
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


class ServiceAccount(proto.Message):
    r"""A subscription to receive Google PubSub notifications.
    Attributes:
        email_address (str):
            The ID of the notification.
    """

    email_address = proto.Field(
        proto.STRING,
        number=1,
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


__all__ = tuple(sorted(__protobuf__.manifest))
