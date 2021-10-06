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

from google.iam.v1 import policy_pb2  # type: ignore
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.rpc import status_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.datafusion.v1beta1',
    manifest={
        'NamespaceView',
        'NetworkConfig',
        'Version',
        'Accelerator',
        'CryptoKeyConfig',
        'Instance',
        'ListInstancesRequest',
        'ListInstancesResponse',
        'ListAvailableVersionsRequest',
        'ListAvailableVersionsResponse',
        'GetInstanceRequest',
        'CreateInstanceRequest',
        'DeleteInstanceRequest',
        'UpdateInstanceRequest',
        'RestartInstanceRequest',
        'UpgradeInstanceRequest',
        'OperationMetadata',
        'RemoveIamPolicyRequest',
        'RemoveIamPolicyResponse',
        'ListNamespacesRequest',
        'IAMPolicy',
        'Namespace',
        'ListNamespacesResponse',
        'DnsPeering',
        'AddDnsPeeringRequest',
        'AddDnsPeeringResponse',
        'RemoveDnsPeeringRequest',
        'RemoveDnsPeeringResponse',
        'ListDnsPeeringsRequest',
        'ListDnsPeeringsResponse',
    },
)


class NamespaceView(proto.Enum):
    r"""A view for Namespace"""
    NAMESPACE_VIEW_UNSPECIFIED = 0
    NAMESPACE_VIEW_BASIC = 1
    NAMESPACE_VIEW_FULL = 2


class NetworkConfig(proto.Message):
    r"""Network configuration for a Data Fusion instance. These
    configurations are used for peering with the customer network.
    Configurations are optional when a public Data Fusion instance
    is to be created. However, providing these configurations allows
    several benefits, such as reduced network latency while
    accessing the customer resources from managed Data Fusion
    instance nodes, as well as access to the customer on-prem
    resources.

    Attributes:
        network (str):
            Name of the network in the customer project
            with which the Tenant Project will be peered for
            executing pipelines. In case of shared VPC where
            the network resides in another host project the
            network should specified in the form of
            projects/{host-project-
            id}/global/networks/{network}
        ip_allocation (str):
            The IP range in CIDR notation to use for the
            managed Data Fusion instance nodes. This range
            must not overlap with any other ranges used in
            the Data Fusion instance network.
    """

    network = proto.Field(
        proto.STRING,
        number=1,
    )
    ip_allocation = proto.Field(
        proto.STRING,
        number=2,
    )


class Version(proto.Message):
    r"""The Data Fusion version.

    Attributes:
        version_number (str):
            The version number of the Data Fusion
            instance, such as '6.0.1.0'.
        default_version (bool):
            Whether this is currently the default version
            for Cloud Data Fusion
        available_features (Sequence[str]):
            Represents a list of available feature names
            for a given version.
    """

    version_number = proto.Field(
        proto.STRING,
        number=1,
    )
    default_version = proto.Field(
        proto.BOOL,
        number=2,
    )
    available_features = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class Accelerator(proto.Message):
    r"""Identifies Data Fusion accelerators for an instance.

    Attributes:
        accelerator_type (google.cloud.datafusion_v1beta1.types.Accelerator.AcceleratorType):
            The type of an accelator for a CDF instance.
    """
    class AcceleratorType(proto.Enum):
        r"""Each type represents an Accelerator (Add-On) supported by
        Cloud Data Fusion service.
        """
        ACCELERATOR_TYPE_UNSPECIFIED = 0
        CDC = 1
        HEALTHCARE = 2

    accelerator_type = proto.Field(
        proto.ENUM,
        number=1,
        enum=AcceleratorType,
    )


class CryptoKeyConfig(proto.Message):
    r"""The crypto key configuration. This field is used by the
    Customer-managed encryption keys (CMEK) feature.

    Attributes:
        key_reference (str):
            The name of the key which is used to encrypt/decrypt
            customer data. For key in Cloud KMS, the key should be in
            the format of
            ``projects/*/locations/*/keyRings/*/cryptoKeys/*``.
    """

    key_reference = proto.Field(
        proto.STRING,
        number=1,
    )


class Instance(proto.Message):
    r"""Represents a Data Fusion instance.

    Attributes:
        name (str):
            Output only. The name of this instance is in
            the form of
            projects/{project}/locations/{location}/instances/{instance}.
        description (str):
            A description of this instance.
        type_ (google.cloud.datafusion_v1beta1.types.Instance.Type):
            Required. Instance type.
        enable_stackdriver_logging (bool):
            Option to enable Stackdriver Logging.
        enable_stackdriver_monitoring (bool):
            Option to enable Stackdriver Monitoring.
        private_instance (bool):
            Specifies whether the Data Fusion instance
            should be private. If set to true, all Data
            Fusion nodes will have private IP addresses and
            will not be able to access the public internet.
        network_config (google.cloud.datafusion_v1beta1.types.NetworkConfig):
            Network configuration options. These are
            required when a private Data Fusion instance is
            to be created.
        labels (Sequence[google.cloud.datafusion_v1beta1.types.Instance.LabelsEntry]):
            The resource labels for instance to use to
            annotate any related underlying resources such
            as Compute Engine VMs. The character '=' is not
            allowed to be used within the labels.
        options (Sequence[google.cloud.datafusion_v1beta1.types.Instance.OptionsEntry]):
            Map of additional options used to configure
            the behavior of Data Fusion instance.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time the instance was
            created.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time the instance was last
            updated.
        state (google.cloud.datafusion_v1beta1.types.Instance.State):
            Output only. The current state of this Data
            Fusion instance.
        state_message (str):
            Output only. Additional information about the
            current state of this Data Fusion instance if
            available.
        service_endpoint (str):
            Output only. Endpoint on which the Data
            Fusion UI is accessible.
        zone (str):
            Name of the zone in which the Data Fusion
            instance will be created. Only DEVELOPER
            instances use this field.
        version (str):
            Current version of Data Fusion.
        service_account (str):
            Output only. Deprecated. Use tenant_project_id instead to
            extract the tenant project ID.
        display_name (str):
            Display name for an instance.
        available_version (Sequence[google.cloud.datafusion_v1beta1.types.Version]):
            Available versions that the instance can be
            upgraded to using UpdateInstanceRequest.
        api_endpoint (str):
            Output only. Endpoint on which the REST APIs
            is accessible.
        gcs_bucket (str):
            Output only. Cloud Storage bucket generated
            by Data Fusion in the customer project.
        accelerators (Sequence[google.cloud.datafusion_v1beta1.types.Accelerator]):
            List of accelerators enabled for this CDF
            instance.
        p4_service_account (str):
            Output only. P4 service account for the
            customer project.
        tenant_project_id (str):
            Output only. The name of the tenant project.
        dataproc_service_account (str):
            User-managed service account to set on
            Dataproc when Cloud Data Fusion creates Dataproc
            to run data processing pipelines.
            This allows users to have fine-grained access
            control on Dataproc's accesses to cloud
            resources.
        enable_rbac (bool):
            Option to enable granular role-based access
            control.
        crypto_key_config (google.cloud.datafusion_v1beta1.types.CryptoKeyConfig):
            The crypto key configuration. This field is
            used by the Customer-Managed Encryption Keys
            (CMEK) feature.
    """
    class Type(proto.Enum):
        r"""Represents the type of Data Fusion instance. Each type is
        configured with the default settings for processing and memory.
        """
        TYPE_UNSPECIFIED = 0
        BASIC = 1
        ENTERPRISE = 2
        DEVELOPER = 3

    class State(proto.Enum):
        r"""Represents the state of a Data Fusion instance"""
        STATE_UNSPECIFIED = 0
        CREATING = 1
        RUNNING = 2
        FAILED = 3
        DELETING = 4
        UPGRADING = 5
        RESTARTING = 6
        UPDATING = 7
        AUTO_UPDATING = 8
        AUTO_UPGRADING = 9

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    description = proto.Field(
        proto.STRING,
        number=2,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=3,
        enum=Type,
    )
    enable_stackdriver_logging = proto.Field(
        proto.BOOL,
        number=4,
    )
    enable_stackdriver_monitoring = proto.Field(
        proto.BOOL,
        number=5,
    )
    private_instance = proto.Field(
        proto.BOOL,
        number=6,
    )
    network_config = proto.Field(
        proto.MESSAGE,
        number=7,
        message='NetworkConfig',
    )
    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=8,
    )
    options = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=9,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=10,
        message=timestamp_pb2.Timestamp,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=11,
        message=timestamp_pb2.Timestamp,
    )
    state = proto.Field(
        proto.ENUM,
        number=12,
        enum=State,
    )
    state_message = proto.Field(
        proto.STRING,
        number=13,
    )
    service_endpoint = proto.Field(
        proto.STRING,
        number=14,
    )
    zone = proto.Field(
        proto.STRING,
        number=15,
    )
    version = proto.Field(
        proto.STRING,
        number=16,
    )
    service_account = proto.Field(
        proto.STRING,
        number=17,
    )
    display_name = proto.Field(
        proto.STRING,
        number=18,
    )
    available_version = proto.RepeatedField(
        proto.MESSAGE,
        number=19,
        message='Version',
    )
    api_endpoint = proto.Field(
        proto.STRING,
        number=20,
    )
    gcs_bucket = proto.Field(
        proto.STRING,
        number=21,
    )
    accelerators = proto.RepeatedField(
        proto.MESSAGE,
        number=22,
        message='Accelerator',
    )
    p4_service_account = proto.Field(
        proto.STRING,
        number=23,
    )
    tenant_project_id = proto.Field(
        proto.STRING,
        number=24,
    )
    dataproc_service_account = proto.Field(
        proto.STRING,
        number=25,
    )
    enable_rbac = proto.Field(
        proto.BOOL,
        number=26,
    )
    crypto_key_config = proto.Field(
        proto.MESSAGE,
        number=27,
        message='CryptoKeyConfig',
    )


class ListInstancesRequest(proto.Message):
    r"""Request message for listing Data Fusion instances.

    Attributes:
        parent (str):
            The project and location for which to
            retrieve instance information in the format
            projects/{project}/locations/{location}. If the
            location is specified as '-' (wildcard), then
            all regions available to the project are
            queried, and the results are aggregated.
        page_size (int):
            The maximum number of items to return.
        page_token (str):
            The next_page_token value to use if there are additional
            results to retrieve for this list request.
        filter (str):
            List filter.
        order_by (str):
            Sort results. Supported values are "name",
            "name desc",  or "" (unsorted).
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


class ListInstancesResponse(proto.Message):
    r"""Response message for the list instance request.

    Attributes:
        instances (Sequence[google.cloud.datafusion_v1beta1.types.Instance]):
            Represents a list of Data Fusion instances.
        next_page_token (str):
            Token to retrieve the next page of results or
            empty if there are no more results in the list.
        unreachable (Sequence[str]):
            Locations that could not be reached.
    """

    @property
    def raw_page(self):
        return self

    instances = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Instance',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )
    unreachable = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class ListAvailableVersionsRequest(proto.Message):
    r"""Request message for the list available versions request.

    Attributes:
        parent (str):
            Required. The project and location for which
            to retrieve instance information in the format
            projects/{project}/locations/{location}.
        page_size (int):
            The maximum number of items to return.
        page_token (str):
            The next_page_token value to use if there are additional
            results to retrieve for this list request.
        latest_patch_only (bool):
            Whether or not to return the latest patch of every available
            minor version. If true, only the latest patch will be
            returned. Ex. if allowed versions is [6.1.1, 6.1.2, 6.2.0]
            then response will be [6.1.2, 6.2.0]
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
    latest_patch_only = proto.Field(
        proto.BOOL,
        number=4,
    )


class ListAvailableVersionsResponse(proto.Message):
    r"""Response message for the list available versions request.

    Attributes:
        available_versions (Sequence[google.cloud.datafusion_v1beta1.types.Version]):
            Represents a list of versions that are
            supported.
        next_page_token (str):
            Token to retrieve the next page of results or
            empty if there are no more results in the list.
    """

    @property
    def raw_page(self):
        return self

    available_versions = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Version',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetInstanceRequest(proto.Message):
    r"""Request message for getting details about a Data Fusion
    instance.

    Attributes:
        name (str):
            The instance resource name in the format
            projects/{project}/locations/{location}/instances/{instance}.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class CreateInstanceRequest(proto.Message):
    r"""Request message for creating a Data Fusion instance.

    Attributes:
        parent (str):
            The instance's project and location in the
            format projects/{project}/locations/{location}.
        instance_id (str):
            The name of the instance to create.
        instance (google.cloud.datafusion_v1beta1.types.Instance):
            An instance resource.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    instance_id = proto.Field(
        proto.STRING,
        number=2,
    )
    instance = proto.Field(
        proto.MESSAGE,
        number=3,
        message='Instance',
    )


class DeleteInstanceRequest(proto.Message):
    r"""Request message for deleting a Data Fusion instance.

    Attributes:
        name (str):
            The instance resource name in the format
            projects/{project}/locations/{location}/instances/{instance}
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class UpdateInstanceRequest(proto.Message):
    r"""Request message for updating a Data Fusion instance.
    Data Fusion only allows updating the labels, options, and stack
    driver settings.

    Attributes:
        instance (google.cloud.datafusion_v1beta1.types.Instance):
            The instance resource that replaces the
            resource on the server. Currently, Data Fusion
            only allows replacing labels, options, and stack
            driver settings. All other fields will be
            ignored.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Field mask is used to specify the fields that the update
            will overwrite in an instance resource. The fields specified
            in the update_mask are relative to the resource, not the
            full request. A field will be overwritten if it is in the
            mask. If the user does not provide a mask, all the supported
            fields (labels and options currently) will be overwritten.
    """

    instance = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Instance',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class RestartInstanceRequest(proto.Message):
    r"""Request message for restarting a Data Fusion instance.

    Attributes:
        name (str):
            Name of the Data Fusion instance which need
            to be restarted in the form of
            projects/{project}/locations/{location}/instances/{instance}
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class UpgradeInstanceRequest(proto.Message):
    r"""Request message for upgrading a Data Fusion instance.
    To change the instance properties, instance update should be
    used.

    Attributes:
        name (str):
            Name of the Data Fusion instance which need
            to be upgraded in the form of
            projects/{project}/locations/{location}/instances/{instance}
            Instance will be upgraded with the latest stable
            version of the Data Fusion.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class OperationMetadata(proto.Message):
    r"""Represents the metadata of a long-running operation.

    Attributes:
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            The time the operation was created.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            The time the operation finished running.
        target (str):
            Server-defined resource path for the target
            of the operation.
        verb (str):
            Name of the verb executed by the operation.
        status_detail (str):
            Human-readable status of the operation if
            any.
        requested_cancellation (bool):
            Identifies whether the user has requested cancellation of
            the operation. Operations that have successfully been
            cancelled have [Operation.error][] value with a
            [google.rpc.Status.code][google.rpc.Status.code] of 1,
            corresponding to ``Code.CANCELLED``.
        api_version (str):
            API version used to start the operation.
    """

    create_time = proto.Field(
        proto.MESSAGE,
        number=1,
        message=timestamp_pb2.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )
    target = proto.Field(
        proto.STRING,
        number=3,
    )
    verb = proto.Field(
        proto.STRING,
        number=4,
    )
    status_detail = proto.Field(
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


class RemoveIamPolicyRequest(proto.Message):
    r"""Request message for RemoveIamPolicy method.

    Attributes:
        resource (str):
            The resource on which IAM policy to be
            removed is attached to.
    """

    resource = proto.Field(
        proto.STRING,
        number=1,
    )


class RemoveIamPolicyResponse(proto.Message):
    r"""Response message for RemoveIamPolicy method.
    """


class ListNamespacesRequest(proto.Message):
    r"""List namespaces request.

    Attributes:
        parent (str):
            Required. The instance to list its
            namespaces.
        page_size (int):
            The maximum number of items to return.
        page_token (str):
            The next_page_token value to use if there are additional
            results to retrieve for this list request.
        view (google.cloud.datafusion_v1beta1.types.NamespaceView):
            By default, only basic information about a namespace is
            returned (e.g. name). When ``NAMESPACE_VIEW_FULL`` is
            specified, additional information associated with a
            namespace gets returned (e.g. IAM policy set on the
            namespace)
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
    view = proto.Field(
        proto.ENUM,
        number=4,
        enum='NamespaceView',
    )


class IAMPolicy(proto.Message):
    r"""IAMPolicy encapsulates the IAM policy name, definition and
    status of policy fetching.

    Attributes:
        policy (google.iam.v1.policy_pb2.Policy):
            Policy definition if IAM policy fetching is
            successful, otherwise empty.
        status (google.rpc.status_pb2.Status):
            Status of iam policy fetching.
    """

    policy = proto.Field(
        proto.MESSAGE,
        number=1,
        message=policy_pb2.Policy,
    )
    status = proto.Field(
        proto.MESSAGE,
        number=2,
        message=status_pb2.Status,
    )


class Namespace(proto.Message):
    r"""Represents the information of a namespace

    Attributes:
        name (str):
            Name of the given namespace.
        iam_policy (google.cloud.datafusion_v1beta1.types.IAMPolicy):
            IAM policy associated with this namespace.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    iam_policy = proto.Field(
        proto.MESSAGE,
        number=2,
        message='IAMPolicy',
    )


class ListNamespacesResponse(proto.Message):
    r"""List namespaces response.

    Attributes:
        namespaces (Sequence[google.cloud.datafusion_v1beta1.types.Namespace]):
            List of namespaces
        next_page_token (str):
            Token to retrieve the next page of results or
            empty if there are no more results in the list.
    """

    @property
    def raw_page(self):
        return self

    namespaces = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Namespace',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class DnsPeering(proto.Message):
    r"""DNS peering configuration. These configurations are used to
    create DNS peering with the customer Cloud DNS.

    Attributes:
        zone (str):
            Required. Name of the zone.
        domain (str):
            Required. Name of the dns.
        description (str):
            Optional. Optional description of the dns
            zone.
        target_project (str):
            Optional. Optional target project to which
            dns peering should happen.
        target_network (str):
            Optional. Optional target network to which
            dns peering should happen.
    """

    zone = proto.Field(
        proto.STRING,
        number=1,
    )
    domain = proto.Field(
        proto.STRING,
        number=2,
    )
    description = proto.Field(
        proto.STRING,
        number=3,
    )
    target_project = proto.Field(
        proto.STRING,
        number=4,
    )
    target_network = proto.Field(
        proto.STRING,
        number=5,
    )


class AddDnsPeeringRequest(proto.Message):
    r"""Request message to create dns peering.

    Attributes:
        parent (str):
            The resource on which DNS peering will be
            created.
        dns_peering (google.cloud.datafusion_v1beta1.types.DnsPeering):
            Dns peering config.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    dns_peering = proto.Field(
        proto.MESSAGE,
        number=2,
        message='DnsPeering',
    )


class AddDnsPeeringResponse(proto.Message):
    r"""Response message for set dns peering method.
    """


class RemoveDnsPeeringRequest(proto.Message):
    r"""Request message to remove dns peering.

    Attributes:
        parent (str):
            The resource on which DNS peering will be
            removed.
        zone (str):
            Required. The zone to be removed.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    zone = proto.Field(
        proto.STRING,
        number=2,
    )


class RemoveDnsPeeringResponse(proto.Message):
    r"""Response message for set dns peering method.
    """


class ListDnsPeeringsRequest(proto.Message):
    r"""List dns peering request.

    Attributes:
        parent (str):
            Required. The resource on which dns peering
            will be listed.
        page_size (int):
            The maximum number of items to return.
        page_token (str):
            The next_page_token value to use if there are additional
            results to retrieve for this list request.
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


class ListDnsPeeringsResponse(proto.Message):
    r"""List dns peering response.

    Attributes:
        dns_peerings (Sequence[google.cloud.datafusion_v1beta1.types.DnsPeering]):
            List of dns peering configs.
        next_page_token (str):
            Token to retrieve the next page of results or
            empty if there are no more results in the list.
    """

    @property
    def raw_page(self):
        return self

    dns_peerings = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='DnsPeering',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
