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

from google.cloud.osconfig.agentendpoint_v1.types import config_common
from google.cloud.osconfig.agentendpoint_v1.types import os_policy
from google.cloud.osconfig.agentendpoint_v1.types import patch_jobs


__protobuf__ = proto.module(
    package='google.cloud.osconfig.agentendpoint.v1',
    manifest={
        'TaskDirective',
        'TaskType',
        'Task',
        'ApplyPatchesTask',
        'ApplyPatchesTaskProgress',
        'ApplyPatchesTaskOutput',
        'ExecStepTask',
        'ExecStepTaskProgress',
        'ExecStepTaskOutput',
        'ApplyConfigTask',
        'ApplyConfigTaskProgress',
        'ApplyConfigTaskOutput',
    },
)


class TaskDirective(proto.Enum):
    r"""Specifies the current agent behavior."""
    TASK_DIRECTIVE_UNSPECIFIED = 0
    CONTINUE = 1
    STOP = 2


class TaskType(proto.Enum):
    r"""Specifies the type of task to perform."""
    TASK_TYPE_UNSPECIFIED = 0
    APPLY_PATCHES = 1
    EXEC_STEP_TASK = 2
    APPLY_CONFIG_TASK = 3


class Task(proto.Message):
    r"""A unit of work to be performed by the agent.
    Attributes:
        task_id (str):
            Unique task id.
        task_type (google.cloud.osconfig.agentendpoint_v1.types.TaskType):
            The type of task to perform.

            Task details must include the appropriate message based on
            this enum as specified below: APPLY_PATCHES =
            ApplyPatchesTask EXEC_STEP = ExecStepTask APPLY_CONFIG_TASK
            = ApplyConfigTask
        task_directive (google.cloud.osconfig.agentendpoint_v1.types.TaskDirective):
            Current directive to the agent.
        apply_patches_task (google.cloud.osconfig.agentendpoint_v1.types.ApplyPatchesTask):
            Details about the apply patches task to
            perform.
        exec_step_task (google.cloud.osconfig.agentendpoint_v1.types.ExecStepTask):
            Details about the exec step task to perform.
        apply_config_task (google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTask):
            Details about the apply config step task to
            perform.
        service_labels (Sequence[google.cloud.osconfig.agentendpoint_v1.types.Task.ServiceLabelsEntry]):
            Labels describing the task.  Used for logging
            by the agent.
    """

    task_id = proto.Field(
        proto.STRING,
        number=1,
    )
    task_type = proto.Field(
        proto.ENUM,
        number=2,
        enum='TaskType',
    )
    task_directive = proto.Field(
        proto.ENUM,
        number=3,
        enum='TaskDirective',
    )
    apply_patches_task = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='task_details',
        message='ApplyPatchesTask',
    )
    exec_step_task = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='task_details',
        message='ExecStepTask',
    )
    apply_config_task = proto.Field(
        proto.MESSAGE,
        number=7,
        oneof='task_details',
        message='ApplyConfigTask',
    )
    service_labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=6,
    )


class ApplyPatchesTask(proto.Message):
    r"""Message which instructs agent to apply patches.
    Attributes:
        patch_config (google.cloud.osconfig.agentendpoint_v1.types.PatchConfig):
            Specific information about how patches should
            be applied.
        dry_run (bool):
            If true, the agent will report its status as
            it goes through the motions but won't actually
            run any updates or perform any reboots.
    """

    patch_config = proto.Field(
        proto.MESSAGE,
        number=1,
        message=patch_jobs.PatchConfig,
    )
    dry_run = proto.Field(
        proto.BOOL,
        number=3,
    )


class ApplyPatchesTaskProgress(proto.Message):
    r"""Information reported from the agent about applying patches
    execution.

    Attributes:
        state (google.cloud.osconfig.agentendpoint_v1.types.ApplyPatchesTaskProgress.State):
            Required. The current state of this patch
            execution.
    """
    class State(proto.Enum):
        r"""The intermediate states of applying patches."""
        STATE_UNSPECIFIED = 0
        STARTED = 4
        DOWNLOADING_PATCHES = 1
        APPLYING_PATCHES = 2
        REBOOTING = 3

    state = proto.Field(
        proto.ENUM,
        number=1,
        enum=State,
    )


class ApplyPatchesTaskOutput(proto.Message):
    r"""Information reported from the agent about applying patches
    execution.

    Attributes:
        state (google.cloud.osconfig.agentendpoint_v1.types.ApplyPatchesTaskOutput.State):
            Required. The final state of this task.
    """
    class State(proto.Enum):
        r"""The final states of applying patches."""
        STATE_UNSPECIFIED = 0
        SUCCEEDED = 1
        SUCCEEDED_REBOOT_REQUIRED = 2
        FAILED = 3

    state = proto.Field(
        proto.ENUM,
        number=1,
        enum=State,
    )


class ExecStepTask(proto.Message):
    r"""Message which instructs agent to execute the following
    command.

    Attributes:
        exec_step (google.cloud.osconfig.agentendpoint_v1.types.ExecStep):
            Details of the exec step to run.
    """

    exec_step = proto.Field(
        proto.MESSAGE,
        number=1,
        message=patch_jobs.ExecStep,
    )


class ExecStepTaskProgress(proto.Message):
    r"""Information reported from the agent about the exec step
    execution.

    Attributes:
        state (google.cloud.osconfig.agentendpoint_v1.types.ExecStepTaskProgress.State):
            Required. The current state of this exec
            step.
    """
    class State(proto.Enum):
        r"""The intermediate states of exec steps."""
        STATE_UNSPECIFIED = 0
        STARTED = 1

    state = proto.Field(
        proto.ENUM,
        number=1,
        enum=State,
    )


class ExecStepTaskOutput(proto.Message):
    r"""Information reported from the agent about the exec step
    execution.

    Attributes:
        state (google.cloud.osconfig.agentendpoint_v1.types.ExecStepTaskOutput.State):
            Required. The final state of the exec step.
        exit_code (int):
            Required. The exit code received from the
            script which ran as part of the exec step.
    """
    class State(proto.Enum):
        r"""The final states of exec steps."""
        STATE_UNSPECIFIED = 0
        COMPLETED = 1
        TIMED_OUT = 2
        CANCELLED = 3

    state = proto.Field(
        proto.ENUM,
        number=1,
        enum=State,
    )
    exit_code = proto.Field(
        proto.INT32,
        number=2,
    )


class ApplyConfigTask(proto.Message):
    r"""Message which instructs OS Config agent to apply the desired
    state configuration.

    Attributes:
        os_policies (Sequence[google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTask.OSPolicy]):
            List of os policies to be applied for the
            instance.
    """

    class OSPolicy(proto.Message):
        r"""Message representing an OS policy.
        Attributes:
            id (str):
                User provided policy id.
                Used for reporting and logging by the agent.
            mode (google.cloud.osconfig.agentendpoint_v1.types.OSPolicy.Mode):
                The policy mode
            os_policy_assignment (str):
                Reference to the ``OSPolicyAssignment`` API resource that
                this ``OSPolicy`` belongs to. Format:
                projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}
                Used for reporting and logging by the agent.
            resources (Sequence[google.cloud.osconfig.agentendpoint_v1.types.OSPolicy.Resource]):
                List of resources associated with the policy
                to be set to their desired state.
        """

        id = proto.Field(
            proto.STRING,
            number=1,
        )
        mode = proto.Field(
            proto.ENUM,
            number=2,
            enum=os_policy.OSPolicy.Mode,
        )
        os_policy_assignment = proto.Field(
            proto.STRING,
            number=3,
        )
        resources = proto.RepeatedField(
            proto.MESSAGE,
            number=4,
            message=os_policy.OSPolicy.Resource,
        )

    os_policies = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=OSPolicy,
    )


class ApplyConfigTaskProgress(proto.Message):
    r"""Information reported from the agent regarding the progress of
    the task of applying desired state configuration.

    Attributes:
        state (google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTaskProgress.State):
            The current state of this task.
    """
    class State(proto.Enum):
        r"""The intermediate states of apply config task."""
        STATE_UNSPECIFIED = 0
        STARTED = 1
        APPLYING_CONFIG = 2

    state = proto.Field(
        proto.ENUM,
        number=1,
        enum=State,
    )


class ApplyConfigTaskOutput(proto.Message):
    r"""Information reported from the agent regarding the output of
    the task of applying desired state configuration.

    Attributes:
        state (google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTaskOutput.State):
            Required. The final state of this task.
        os_policy_results (Sequence[google.cloud.osconfig.agentendpoint_v1.types.ApplyConfigTaskOutput.OSPolicyResult]):
            Results of applying desired state config for
            the OS policies.
    """
    class State(proto.Enum):
        r"""The final state of this task."""
        STATE_UNSPECIFIED = 0
        SUCCEEDED = 1
        FAILED = 2
        CANCELLED = 3

    class OSPolicyResult(proto.Message):
        r"""Result of applying desired state config for an OS policy.
        Attributes:
            os_policy_id (str):
                The OS policy id
            os_policy_assignment (str):
                Reference to the ``OSPolicyAssignment`` API resource that
                this ``OSPolicy`` belongs to. Format:
                projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}
                Used for reporting and logging by the agent.
            os_policy_resource_compliances (Sequence[google.cloud.osconfig.agentendpoint_v1.types.OSPolicyResourceCompliance]):
                Results of applying desired state config for
                the OS policy resources.
        """

        os_policy_id = proto.Field(
            proto.STRING,
            number=1,
        )
        os_policy_assignment = proto.Field(
            proto.STRING,
            number=2,
        )
        os_policy_resource_compliances = proto.RepeatedField(
            proto.MESSAGE,
            number=3,
            message=config_common.OSPolicyResourceCompliance,
        )

    state = proto.Field(
        proto.ENUM,
        number=1,
        enum=State,
    )
    os_policy_results = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=OSPolicyResult,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
