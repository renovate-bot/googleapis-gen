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

from google.protobuf import any_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.rpc import status_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.apps.alertcenter.v1beta1',
    manifest={
        'AlertFeedbackType',
        'Alert',
        'AlertFeedback',
        'AlertMetadata',
        'Settings',
        'BatchDeleteAlertsRequest',
        'BatchDeleteAlertsResponse',
        'BatchUndeleteAlertsRequest',
        'BatchUndeleteAlertsResponse',
        'ListAlertsRequest',
        'ListAlertsResponse',
        'GetAlertRequest',
        'DeleteAlertRequest',
        'UndeleteAlertRequest',
        'CreateAlertFeedbackRequest',
        'ListAlertFeedbackRequest',
        'ListAlertFeedbackResponse',
        'GetAlertMetadataRequest',
        'GetSettingsRequest',
        'UpdateSettingsRequest',
    },
)


class AlertFeedbackType(proto.Enum):
    r"""The type of alert feedback."""
    ALERT_FEEDBACK_TYPE_UNSPECIFIED = 0
    NOT_USEFUL = 1
    SOMEWHAT_USEFUL = 2
    VERY_USEFUL = 3


class Alert(proto.Message):
    r"""An alert affecting a customer.

    Attributes:
        customer_id (str):
            Output only. The unique identifier of the
            Google account of the customer.
        alert_id (str):
            Output only. The unique identifier for the
            alert.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this alert was created.
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            Required. The time the event that caused this
            alert was started or detected.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            Optional. The time the event that caused this
            alert ceased being active. If provided, the end
            time must not be earlier than the start time. If
            not provided, it indicates an ongoing alert.
        type_ (str):
            Required. The type of the alert. This is output only after
            alert is created. For a list of available alert types see
            `Google Workspace Alert
            types <https://developers.google.com/admin-sdk/alertcenter/reference/alert-types>`__.
        source (str):
            Required. A unique identifier for the system that reported
            the alert. This is output only after alert is created.

            Supported sources are any of the following:

            -  Google Operations
            -  Mobile device management
            -  Gmail phishing
            -  Domain wide takeout
            -  State sponsored attack
            -  Google identity
        data (google.protobuf.any_pb2.Any):
            Optional. The data associated with this alert, for example
            [google.apps.alertcenter.type.DeviceCompromised]
            [google.apps.alertcenter.type.DeviceCompromised].
        security_investigation_tool_link (str):
            Output only. An optional `Security Investigation
            Tool <https://support.google.com/a/answer/7575955>`__ query
            for this alert.
        deleted (bool):
            Output only. ``True`` if this alert is marked for deletion.
        metadata (google.apps.alertcenter_v1beta1.types.AlertMetadata):
            Output only. The metadata associated with
            this alert.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this alert was last
            updated.
        etag (str):
            Optional. ``etag`` is used for optimistic concurrency
            control as a way to help prevent simultaneous updates of an
            alert from overwriting each other. It is strongly suggested
            that systems make use of the ``etag`` in the
            read-modify-write cycle to perform alert updates in order to
            avoid race conditions: An ``etag`` is returned in the
            response which contains alerts, and systems are expected to
            put that etag in the request to update alert to ensure that
            their change will be applied to the same version of the
            alert.

            If no ``etag`` is provided in the call to update alert, then
            the existing alert is overwritten blindly.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp_pb2.Timestamp,
    )
    start_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )
    type_ = proto.Field(
        proto.STRING,
        number=6,
    )
    source = proto.Field(
        proto.STRING,
        number=7,
    )
    data = proto.Field(
        proto.MESSAGE,
        number=8,
        message=any_pb2.Any,
    )
    security_investigation_tool_link = proto.Field(
        proto.STRING,
        number=9,
    )
    deleted = proto.Field(
        proto.BOOL,
        number=11,
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=12,
        message='AlertMetadata',
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=13,
        message=timestamp_pb2.Timestamp,
    )
    etag = proto.Field(
        proto.STRING,
        number=14,
    )


class AlertFeedback(proto.Message):
    r"""A customer feedback about an alert.

    Attributes:
        customer_id (str):
            Output only. The unique identifier of the
            Google account of the customer.
        alert_id (str):
            Output only. The alert identifier.
        feedback_id (str):
            Output only. The unique identifier for the
            feedback.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this feedback was
            created.
        type_ (google.apps.alertcenter_v1beta1.types.AlertFeedbackType):
            Required. The type of the feedback.
        email (str):
            Output only. The email of the user that
            provided the feedback.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )
    feedback_id = proto.Field(
        proto.STRING,
        number=3,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=5,
        enum='AlertFeedbackType',
    )
    email = proto.Field(
        proto.STRING,
        number=6,
    )


class AlertMetadata(proto.Message):
    r"""An alert metadata.

    Attributes:
        customer_id (str):
            Output only. The unique identifier of the
            Google account of the customer.
        alert_id (str):
            Output only. The alert identifier.
        status (str):
            The current status of the alert. The supported values are
            the following:

            -  NOT_STARTED
            -  IN_PROGRESS
            -  CLOSED
        assignee (str):
            The email address of the user assigned to the
            alert.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time this metadata was last
            updated.
        severity (str):
            The severity value of the alert. Alert Center will set this
            field at alert creation time, default's to an empty string
            when it could not be determined. The supported values for
            update actions on this field are the following:

            -  HIGH
            -  MEDIUM
            -  LOW
        etag (str):
            Optional. ``etag`` is used for optimistic concurrency
            control as a way to help prevent simultaneous updates of an
            alert metadata from overwriting each other. It is strongly
            suggested that systems make use of the ``etag`` in the
            read-modify-write cycle to perform metatdata updates in
            order to avoid race conditions: An ``etag`` is returned in
            the response which contains alert metadata, and systems are
            expected to put that etag in the request to update alert
            metadata to ensure that their change will be applied to the
            same version of the alert metadata.

            If no ``etag`` is provided in the call to update alert
            metadata, then the existing alert metadata is overwritten
            blindly.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )
    status = proto.Field(
        proto.STRING,
        number=4,
    )
    assignee = proto.Field(
        proto.STRING,
        number=5,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    severity = proto.Field(
        proto.STRING,
        number=7,
    )
    etag = proto.Field(
        proto.STRING,
        number=8,
    )


class Settings(proto.Message):
    r"""Customer-level settings.

    Attributes:
        notifications (Sequence[google.apps.alertcenter_v1beta1.types.Settings.Notification]):
            The list of notifications.
    """

    class Notification(proto.Message):
        r"""Settings for callback notifications. For more details see `Google
        Workspace Alert
        Notification <https://developers.google.com/admin-sdk/alertcenter/guides/notifications>`__.


        .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

        Attributes:
            cloud_pubsub_topic (google.apps.alertcenter_v1beta1.types.Settings.Notification.CloudPubsubTopic):
                A Google Cloud Pub/sub topic destination.

                This field is a member of `oneof`_ ``destination``.
        """
        class PayloadFormat(proto.Enum):
            r"""The format of the payload."""
            PAYLOAD_FORMAT_UNSPECIFIED = 0
            JSON = 1

        class CloudPubsubTopic(proto.Message):
            r"""A reference to a Cloud Pubsub topic.

            To register for notifications, the owner of the topic must grant
            ``alerts-api-push-notifications@system.gserviceaccount.com`` the
            ``projects.topics.publish`` permission.

            Attributes:
                topic_name (str):
                    The ``name`` field of a Cloud Pubsub [Topic]
                    (https://cloud.google.com/pubsub/docs/reference/rest/v1/projects.topics#Topic).
                payload_format (google.apps.alertcenter_v1beta1.types.Settings.Notification.PayloadFormat):
                    Optional. The format of the payload that
                    would be sent. If not specified the format will
                    be JSON.
            """

            topic_name = proto.Field(
                proto.STRING,
                number=1,
            )
            payload_format = proto.Field(
                proto.ENUM,
                number=2,
                enum='Settings.Notification.PayloadFormat',
            )

        cloud_pubsub_topic = proto.Field(
            proto.MESSAGE,
            number=1,
            oneof='destination',
            message='Settings.Notification.CloudPubsubTopic',
        )

    notifications = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=Notification,
    )


class BatchDeleteAlertsRequest(proto.Message):
    r"""A request to perform batch delete on alerts.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alerts are associated with.
        alert_id (Sequence[str]):
            Required. list of alert IDs.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class BatchDeleteAlertsResponse(proto.Message):
    r"""Response to batch delete operation on alerts.

    Attributes:
        success_alert_ids (Sequence[str]):
            The successful list of alert IDs.
        failed_alert_status (Sequence[google.apps.alertcenter_v1beta1.types.BatchDeleteAlertsResponse.FailedAlertStatusEntry]):
            The status details for each failed alert_id.
    """

    success_alert_ids = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    failed_alert_status = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=2,
        message=status_pb2.Status,
    )


class BatchUndeleteAlertsRequest(proto.Message):
    r"""A request to perform batch undelete on alerts.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alerts are associated with.
        alert_id (Sequence[str]):
            Required. list of alert IDs.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class BatchUndeleteAlertsResponse(proto.Message):
    r"""Response to batch undelete operation on alerts.

    Attributes:
        success_alert_ids (Sequence[str]):
            The successful list of alert IDs.
        failed_alert_status (Sequence[google.apps.alertcenter_v1beta1.types.BatchUndeleteAlertsResponse.FailedAlertStatusEntry]):
            The status details for each failed alert_id.
    """

    success_alert_ids = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    failed_alert_status = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=2,
        message=status_pb2.Status,
    )


class ListAlertsRequest(proto.Message):
    r"""An alert listing request.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alerts are associated with. Inferred from
            the caller identity if not provided.
        page_size (int):
            Optional. The requested page size. Server may
            return fewer items than requested. If
            unspecified, server picks an appropriate
            default.
        page_token (str):
            Optional. A token identifying a page of results the server
            should return. If empty, a new iteration is started. To
            continue an iteration, pass in the value from the previous
            ListAlertsResponse's
            [next_page_token][google.apps.alertcenter.v1beta1.ListAlertsResponse.next_page_token]
            field.
        filter (str):
            Optional. A query string for filtering alert results. For
            more details, see `Query
            filters <https://developers.google.com/admin-sdk/alertcenter/guides/query-filters>`__
            and `Supported query filter
            fields <https://developers.google.com/admin-sdk/alertcenter/reference/filter-fields#alerts.list>`__.
        order_by (str):
            Optional. The sort order of the list results. If not
            specified results may be returned in arbitrary order. You
            can sort the results in descending order based on the
            creation timestamp using ``order_by="create_time desc"``.
            Currently, supported sorting are ``create_time asc``,
            ``create_time desc``, ``update_time desc``
    """

    customer_id = proto.Field(
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


class ListAlertsResponse(proto.Message):
    r"""Response message for an alert listing request.

    Attributes:
        alerts (Sequence[google.apps.alertcenter_v1beta1.types.Alert]):
            The list of alerts.
        next_page_token (str):
            The token for the next page. If not empty, indicates that
            there may be more alerts that match the listing request;
            this value can be used in a subsequent
            [ListAlertsRequest][google.apps.alertcenter.v1beta1.ListAlertsRequest]
            to get alerts continuing from last result of the current
            list call.
    """

    @property
    def raw_page(self):
        return self

    alerts = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Alert',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetAlertRequest(proto.Message):
    r"""Request for a specific alert.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert is associated with. Inferred from the
            caller identity if not provided.
        alert_id (str):
            Required. The identifier of the alert to
            retrieve.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )


class DeleteAlertRequest(proto.Message):
    r"""A request to mark a specific alert for deletion.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert is associated with. Inferred from the
            caller identity if not provided.
        alert_id (str):
            Required. The identifier of the alert to
            delete.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )


class UndeleteAlertRequest(proto.Message):
    r"""A request to undelete a specific alert that was marked for
    deletion.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert is associated with. Inferred from the
            caller identity if not provided.
        alert_id (str):
            Required. The identifier of the alert to
            undelete.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )


class CreateAlertFeedbackRequest(proto.Message):
    r"""A request to create a new alert feedback.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert is associated with. Inferred from the
            caller identity if not provided.
        alert_id (str):
            Required. The identifier of the alert this
            feedback belongs to.
        feedback (google.apps.alertcenter_v1beta1.types.AlertFeedback):
            Required. The new alert feedback to create.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )
    feedback = proto.Field(
        proto.MESSAGE,
        number=3,
        message='AlertFeedback',
    )


class ListAlertFeedbackRequest(proto.Message):
    r"""An alert feedback listing request.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert feedback are associated with. Inferred
            from the caller identity if not provided.
        alert_id (str):
            Required. The alert identifier.
            The "-" wildcard could be used to represent all
            alerts.
        filter (str):
            Optional. A query string for filtering alert feedback
            results. For more details, see `Query
            filters <https://developers.google.com/admin-sdk/alertcenter/guides/query-filters>`__
            and `Supported query filter
            fields <https://developers.google.com/admin-sdk/alertcenter/reference/filter-fields#alerts.feedback.list>`__.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )
    filter = proto.Field(
        proto.STRING,
        number=3,
    )


class ListAlertFeedbackResponse(proto.Message):
    r"""Response message for an alert feedback listing request.

    Attributes:
        feedback (Sequence[google.apps.alertcenter_v1beta1.types.AlertFeedback]):
            The list of alert feedback.
            Feedback entries for each alert are ordered by
            creation time descending.
    """

    feedback = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='AlertFeedback',
    )


class GetAlertMetadataRequest(proto.Message):
    r"""Get the alert metadata.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert metadata is associated with. Inferred
            from the caller identity if not provided.
        alert_id (str):
            Required. The identifier of the alert this
            metadata belongs to.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    alert_id = proto.Field(
        proto.STRING,
        number=2,
    )


class GetSettingsRequest(proto.Message):
    r"""Get the customer level settings.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert settings are associated with. Inferred
            from the caller identity if not provided.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )


class UpdateSettingsRequest(proto.Message):
    r"""Update the customer level settings.

    Attributes:
        customer_id (str):
            Optional. The unique identifier of the Google
            Workspace organization account of the customer
            the alert settings are associated with. Inferred
            from the caller identity if not provided.
        settings (google.apps.alertcenter_v1beta1.types.Settings):
            The customer settings to update.
    """

    customer_id = proto.Field(
        proto.STRING,
        number=1,
    )
    settings = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Settings',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
