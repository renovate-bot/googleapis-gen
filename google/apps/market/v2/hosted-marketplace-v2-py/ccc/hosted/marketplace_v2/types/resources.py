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
    package='ccc.hosted.marketplace.v2',
    manifest={
        'CustomerLicense',
        'LicenseNotification',
        'LicenseNotificationList',
        'UserLicense',
    },
)


class CustomerLicense(proto.Message):
    r"""

    Attributes:
        kind (str):
            The type of API resource. This is always
            appsmarket#customerLicense.
        state (str):
            The customer's license status. One of:

            -  ``ACTIVE``: The customer has a valid license.
            -  ``UNLICENSED``: There is no license: either this customer
               has never installed your application, or else has deleted
               it.
        application_id (str):
            The ID of the application corresponding to
            this license query.
        editions (Sequence[ccc.hosted.marketplace_v2.types.CustomerLicense.Editions]):
            (Deprecated)
        id (str):
            The ID of the customer license.
        customer_id (str):
            The domain name of the customer.
    """
    class Editions(proto.Message):
        r"""

        Attributes:
            edition_id (str):
                (Deprecated)
            seat_count (int):
                (Deprecated)
            assigned_seats (int):
                (Deprecated)
        """

        edition_id = proto.Field(proto.STRING, number=405)

        seat_count = proto.Field(proto.INT32, number=406)

        assigned_seats = proto.Field(proto.INT32, number=409)

    kind = proto.Field(proto.STRING, number=1)

    state = proto.Field(proto.STRING, number=2)

    application_id = proto.Field(proto.STRING, number=3)

    editions = proto.RepeatedField(proto.MESSAGE, number=4,
        message=Editions,
    )

    id = proto.Field(proto.STRING, number=101)

    customer_id = proto.Field(proto.STRING, number=102)


class LicenseNotification(proto.Message):
    r"""

    Attributes:
        id (str):
            The ID of the license notification.
        application_id (str):
            The ID of the application according to this
            notification.
        timestamp (int):
            The time the event occurred, measuring in
            milliseconds since the UNIX epoch.
        customer_id (str):
            The domain name of the customer corresponding
            to this notification.
        kind (str):
            The type of API resource. This is always
            appsmarket#licenseNotification.
        provisions (Sequence[ccc.hosted.marketplace_v2.types.LicenseNotification.Provisions]):
            The list of provisioning notifications.
        expiries (Sequence[ccc.hosted.marketplace_v2.types.LicenseNotification.Expiries]):
            The list of expiry notifications.
        reassignments (Sequence[ccc.hosted.marketplace_v2.types.LicenseNotification.Reassignments]):
            The list of reassignment notifications.
        deletes (Sequence[ccc.hosted.marketplace_v2.types.LicenseNotification.Deletes]):
            The list of deletion notifications.
    """
    class Deletes(proto.Message):
        r"""

        Attributes:
            kind (str):

            edition_id (str):
                (Deprecated)
        """

        kind = proto.Field(proto.STRING, number=1)

        edition_id = proto.Field(proto.STRING, number=901)

    class Expiries(proto.Message):
        r"""

        Attributes:
            kind (str):

            edition_id (str):
                (Deprecated)
        """

        kind = proto.Field(proto.STRING, number=1)

        edition_id = proto.Field(proto.STRING, number=701)

    class Provisions(proto.Message):
        r"""

        Attributes:
            kind (str):

            edition_id (str):
                (Deprecated)
            seat_count (int):
                The number of seats that were provisioned.
        """

        kind = proto.Field(proto.STRING, number=1)

        edition_id = proto.Field(proto.STRING, number=601)

        seat_count = proto.Field(proto.INT64, number=602)

    class Reassignments(proto.Message):
        r"""

        Attributes:
            kind (str):

            user_id (str):
                The email address of the reassigned user.
            type_ (str):

            edition_id (str):
                (Deprecated)
        """

        kind = proto.Field(proto.STRING, number=1)

        user_id = proto.Field(proto.STRING, number=801)

        type_ = proto.Field(proto.STRING, number=802)

        edition_id = proto.Field(proto.STRING, number=803)

    id = proto.Field(proto.STRING, number=1)

    application_id = proto.Field(proto.STRING, number=2)

    timestamp = proto.Field(proto.INT64, number=3)

    customer_id = proto.Field(proto.STRING, number=4)

    kind = proto.Field(proto.STRING, number=5)

    provisions = proto.RepeatedField(proto.MESSAGE, number=6,
        message=Provisions,
    )

    expiries = proto.RepeatedField(proto.MESSAGE, number=7,
        message=Expiries,
    )

    reassignments = proto.RepeatedField(proto.MESSAGE, number=8,
        message=Reassignments,
    )

    deletes = proto.RepeatedField(proto.MESSAGE, number=9,
        message=Deletes,
    )


class LicenseNotificationList(proto.Message):
    r"""

    Attributes:
        kind (str):

        notifications (Sequence[ccc.hosted.marketplace_v2.types.LicenseNotification]):
            The list of notifications. One or more of:

            -  ``provisions``: A new license of the application has been
               provisioned.
            -  ``expiries``: A license of the application has expired.
            -  ``deletions``: An application has been deleted from a
               domain.
            -  ``reassignments``: An administrator has assigned or
               revoked a seat license for the application on the
               provided domain.
        next_page_token (str):
            The token used to continue querying for
            notifications after the final notification in
            the current result set.
    """

    @property
    def raw_page(self):
        return self

    kind = proto.Field(proto.STRING, number=1)

    notifications = proto.RepeatedField(proto.MESSAGE, number=1007,
        message='LicenseNotification',
    )

    next_page_token = proto.Field(proto.STRING, number=100602)


class UserLicense(proto.Message):
    r"""

    Attributes:
        kind (str):
            The type of API resource. This is always
            appsmarket#userLicense.
        enabled (bool):
            The domain administrator has activated the
            application for this domain.
        state (str):
            The user's licensing status. One of:

            -  ``ACTIVE``: The user has a valid license and should be
               permitted to use the application.
            -  ``UNLICENSED``: The administrator of this user's domain
               never assigned a seat for the application to this user.
            -  ``EXPIRED``: The administrator assigned a seat to this
               user, but the license is expired.
        edition_id (str):
            (Deprecated)
        customer_id (str):
            The domain name of the user.
        application_id (str):
            The ID of the application corresponding to
            the license query.
        id (str):
            The ID of user license.
        user_id (str):
            The email address of the user.
    """

    kind = proto.Field(proto.STRING, number=1)

    enabled = proto.Field(proto.BOOL, number=2)

    state = proto.Field(proto.STRING, number=3)

    edition_id = proto.Field(proto.STRING, number=4)

    customer_id = proto.Field(proto.STRING, number=5)

    application_id = proto.Field(proto.STRING, number=6)

    id = proto.Field(proto.STRING, number=101)

    user_id = proto.Field(proto.STRING, number=102)


__all__ = tuple(sorted(__protobuf__.manifest))
