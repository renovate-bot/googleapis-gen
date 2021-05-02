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


from google.cloud.osconfig.agentendpoint_v1.types import inventory as gcoa_inventory
from google.cloud.osconfig.agentendpoint_v1.types import tasks


__protobuf__ = proto.module(
    package='google.cloud.osconfig.agentendpoint.v1',
    manifest={
        'ReceiveTaskNotificationRequest',
        'ReceiveTaskNotificationResponse',
        'StartNextTaskRequest',
        'StartNextTaskResponse',
        'ReportTaskProgressRequest',
        'ReportTaskProgressResponse',
        'ReportTaskCompleteRequest',
        'ReportTaskCompleteResponse',
        'RegisterAgentRequest',
        'RegisterAgentResponse',
        'ReportInventoryRequest',
        'ReportInventoryResponse',
    },
)


class ReceiveTaskNotificationRequest(proto.Message):
    r"""A request message to receive task notifications.

    Attributes:
        instance_id_token (str):
            Required. This is the Compute Engine instance
            identity token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
        agent_version (str):
            Required. The version of the agent making the
            request.
    """

    instance_id_token = proto.Field(proto.STRING, number=1)

    agent_version = proto.Field(proto.STRING, number=2)


class ReceiveTaskNotificationResponse(proto.Message):
    r"""The streaming rpc message that will notify the agent when it
    has a task it needs to perform on the instance.
    """


class StartNextTaskRequest(proto.Message):
    r"""A request message for signaling the start of a task
    execution.

    Attributes:
        instance_id_token (str):
            Required. This is the Compute Engine instance
            identity token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
    """

    instance_id_token = proto.Field(proto.STRING, number=1)


class StartNextTaskResponse(proto.Message):
    r"""A response message that contains the details of the task to
    work on.

    Attributes:
        task (google.cloud.osconfig.agentendpoint_v1.types.Task):
            The details of the task that should be worked
            on.  Can be empty if there is no new task to
            work on.
    """

    task = proto.Field(proto.MESSAGE, number=1,
        message=tasks.Task,
    )


class ReportTaskProgressRequest(proto.Message):
    r"""A request message for reporting the progress of current task.

    Attributes:
        instance_id_token (str):
            Required. This is the Compute Engine instance
            identity token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
        task_id (str):
            Required. Unique identifier of the task this
            applies to.
        task_type (google.cloud.osconfig.agentendpoint_v1.types.TaskType):
            Required. The type of task to report progress on.

            Progress must include the appropriate message based on this
            enum as specified below: APPLY_PATCHES =
            ApplyPatchesTaskProgress EXEC_STEP = Progress not supported
            for this type.
        apply_patches_task_progress (google.cloud.osconfig.agentendpoint_v1.types.ApplyPatchesTaskProgress):
            Details about the progress of the apply
            patches task.
        exec_step_task_progress (google.cloud.osconfig.agentendpoint_v1.types.ExecStepTaskProgress):
            Details about the progress of the exec step
            task.
        apply_config_task_progress (google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTaskProgress):
            Details about the progress of the apply
            config task.
    """

    instance_id_token = proto.Field(proto.STRING, number=1)

    task_id = proto.Field(proto.STRING, number=2)

    task_type = proto.Field(proto.ENUM, number=3,
        enum=tasks.TaskType,
    )

    apply_patches_task_progress = proto.Field(proto.MESSAGE, number=4, oneof='progress',
        message=tasks.ApplyPatchesTaskProgress,
    )

    exec_step_task_progress = proto.Field(proto.MESSAGE, number=5, oneof='progress',
        message=tasks.ExecStepTaskProgress,
    )

    apply_config_task_progress = proto.Field(proto.MESSAGE, number=6, oneof='progress',
        message=tasks.ApplyConfigTaskProgress,
    )


class ReportTaskProgressResponse(proto.Message):
    r"""The response message after the agent reported the current
    task progress.

    Attributes:
        task_directive (google.cloud.osconfig.agentendpoint_v1.types.TaskDirective):
            Instructs agent to continue or not.
    """

    task_directive = proto.Field(proto.ENUM, number=1,
        enum=tasks.TaskDirective,
    )


class ReportTaskCompleteRequest(proto.Message):
    r"""A request message for signaling the completion of a task
    execution.

    Attributes:
        instance_id_token (str):
            Required. This is the Compute Engine instance
            identity token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
        task_id (str):
            Required. Unique identifier of the task this
            applies to.
        task_type (google.cloud.osconfig.agentendpoint_v1.types.TaskType):
            Required. The type of task to report completed.

            Output must include the appropriate message based on this
            enum as specified below: APPLY_PATCHES =
            ApplyPatchesTaskOutput EXEC_STEP = ExecStepTaskOutput
        error_message (str):
            Descriptive error message if the task
            execution ended in error.
        apply_patches_task_output (google.cloud.osconfig.agentendpoint_v1.types.ApplyPatchesTaskOutput):
            Final output details of the apply patches
            task;
        exec_step_task_output (google.cloud.osconfig.agentendpoint_v1.types.ExecStepTaskOutput):
            Final output details of the exec step task;
        apply_config_task_output (google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTaskOutput):
            Final output details of the apply config
            task;
    """

    instance_id_token = proto.Field(proto.STRING, number=1)

    task_id = proto.Field(proto.STRING, number=2)

    task_type = proto.Field(proto.ENUM, number=3,
        enum=tasks.TaskType,
    )

    error_message = proto.Field(proto.STRING, number=4)

    apply_patches_task_output = proto.Field(proto.MESSAGE, number=5, oneof='output',
        message=tasks.ApplyPatchesTaskOutput,
    )

    exec_step_task_output = proto.Field(proto.MESSAGE, number=6, oneof='output',
        message=tasks.ExecStepTaskOutput,
    )

    apply_config_task_output = proto.Field(proto.MESSAGE, number=7, oneof='output',
        message=tasks.ApplyConfigTaskOutput,
    )


class ReportTaskCompleteResponse(proto.Message):
    r"""The response message after the agent signaled the current
    task complete.
    """


class RegisterAgentRequest(proto.Message):
    r"""The request message for registering the agent.

    Attributes:
        instance_id_token (str):
            Required. This is the Compute Engine instance
            identity token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
        agent_version (str):
            Required. The version of the agent.
        supported_capabilities (Sequence[str]):
            Required. The capabilities supported by the agent. Supported
            values are: PATCH_GA GUEST_POLICY_BETA
    """

    instance_id_token = proto.Field(proto.STRING, number=1)

    agent_version = proto.Field(proto.STRING, number=2)

    supported_capabilities = proto.RepeatedField(proto.STRING, number=3)


class RegisterAgentResponse(proto.Message):
    r"""The response message after the agent registered."""


class ReportInventoryRequest(proto.Message):
    r"""The request message for having the agent report inventory.

    Attributes:
        instance_id_token (str):
            Required. This is the Compute Engine instance
            identity token described in
            https://cloud.google.com/compute/docs/instances/verifying-
            instance-identity where the audience is
            'osconfig.googleapis.com' and the format is
            'full'.
        inventory_checksum (str):
            Required. This is a client created checksum
            that should be generated based on the contents
            of the reported inventory.  This will be used by
            the service to determine if it has the latest
            version of inventory.
        inventory (google.cloud.osconfig.agentendpoint_v1.types.Inventory):
            Optional. This is the details of the
            inventory.  Should only be provided if the
            inventory has changed since the last report, or
            if instructed by the service to provide full
            inventory.
    """

    instance_id_token = proto.Field(proto.STRING, number=1)

    inventory_checksum = proto.Field(proto.STRING, number=2)

    inventory = proto.Field(proto.MESSAGE, number=3,
        message=gcoa_inventory.Inventory,
    )


class ReportInventoryResponse(proto.Message):
    r"""The response message after the agent has reported inventory.

    Attributes:
        report_full_inventory (bool):
            If true, the full inventory should be
            reported back to the server.
    """

    report_full_inventory = proto.Field(proto.BOOL, number=1)


__all__ = tuple(sorted(__protobuf__.manifest))
