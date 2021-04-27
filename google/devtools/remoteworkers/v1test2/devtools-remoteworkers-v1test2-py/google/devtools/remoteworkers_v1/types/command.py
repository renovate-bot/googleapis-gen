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

from google.protobuf import any_pb2 as gp_any  # type: ignore
from google.protobuf import duration_pb2 as gp_duration  # type: ignore
from google.rpc import status_pb2 as gr_status  # type: ignore


__protobuf__ = proto.module(
    package='google.devtools.remoteworkers.v1test2',
    manifest={
        'CommandTask',
        'CommandOutputs',
        'CommandOverhead',
        'CommandResult',
        'FileMetadata',
        'DirectoryMetadata',
        'Digest',
        'Blob',
        'Directory',
    },
)


class CommandTask(proto.Message):
    r"""Describes a shell-style task to execute, suitable for providing as
    the Bots interface's ``Lease.payload`` field.

    Attributes:
        inputs (google.devtools.remoteworkers_v1.types.CommandTask.Inputs):
            The inputs to the task.
        expected_outputs (google.devtools.remoteworkers_v1.types.CommandTask.Outputs):
            The expected outputs from the task.
        timeouts (google.devtools.remoteworkers_v1.types.CommandTask.Timeouts):
            The timeouts of this task.
    """

    class Inputs(proto.Message):
        r"""Describes the inputs to a shell-style task.
        Attributes:
            arguments (Sequence[str]):
                The command itself to run (e.g., argv).

                This field should be passed directly to the underlying
                operating system, and so it must be sensible to that
                operating system. For example, on Windows, the first
                argument might be "C:\Windows\System32\ping.exe" - that is,
                using drive letters and backslashes. A command for a \*nix
                system, on the other hand, would use forward slashes.

                All other fields in the RWAPI must consistently use forward
                slashes, since those fields may be interpretted by both the
                service and the bot.
            files (Sequence[google.devtools.remoteworkers_v1.types.Digest]):
                The input filesystem to be set up prior to
                the task beginning. The contents should be a
                repeated set of FileMetadata messages though
                other formats are allowed if better for the
                implementation (eg, a LUCI-style .isolated
                file).

                This field is repeated since implementations
                might want to cache the metadata, in which case
                it may be useful to break up portions of the
                filesystem that change frequently (eg, specific
                input files) from those that don't (eg, standard
                header files).
            inline_blobs (Sequence[google.devtools.remoteworkers_v1.types.Blob]):
                Inline contents for blobs expected to be needed by the bot
                to execute the task. For example, contents of entries in
                ``files`` or blobs that are indirectly referenced by an
                entry there.

                The bot should check against this list before downloading
                required task inputs to reduce the number of communications
                between itself and the remote CAS server.
            environment_variables (Sequence[google.devtools.remoteworkers_v1.types.CommandTask.Inputs.EnvironmentVariable]):
                All environment variables required by the
                task.
            working_directory (str):
                Directory from which a command is executed.
                It is a relative directory with respect to the
                bot's working directory (i.e., "./"). If it is
                non-empty, then it must exist under "./".
                Otherwise, "./" will be used.
        """

        class EnvironmentVariable(proto.Message):
            r"""An environment variable required by this task.
            Attributes:
                name (str):
                    The envvar name.
                value (str):
                    The envvar value.
            """

            name = proto.Field(
                proto.STRING,
                number=1,
            )
            value = proto.Field(
                proto.STRING,
                number=2,
            )

        arguments = proto.RepeatedField(
            proto.STRING,
            number=1,
        )
        files = proto.RepeatedField(
            proto.MESSAGE,
            number=2,
            message='Digest',
        )
        inline_blobs = proto.RepeatedField(
            proto.MESSAGE,
            number=4,
            message='Blob',
        )
        environment_variables = proto.RepeatedField(
            proto.MESSAGE,
            number=3,
            message='CommandTask.Inputs.EnvironmentVariable',
        )
        working_directory = proto.Field(
            proto.STRING,
            number=5,
        )

    class Outputs(proto.Message):
        r"""Describes the expected outputs of the command.
        Attributes:
            files (Sequence[str]):
                A list of expected files, relative to the
                execution root. All paths MUST be delimited by
                forward slashes.
            directories (Sequence[str]):
                A list of expected directories, relative to
                the execution root. All paths MUST be delimited
                by forward slashes.
            stdout_destination (str):
                The destination to which any stdout should be sent. The
                method by which the bot should send the stream contents to
                that destination is not defined in this API. As examples,
                the destination could be a file referenced in the ``files``
                field in this message, or it could be a URI that must be
                written via the ByteStream API.
            stderr_destination (str):
                The destination to which any stderr should be sent. The
                method by which the bot should send the stream contents to
                that destination is not defined in this API. As examples,
                the destination could be a file referenced in the ``files``
                field in this message, or it could be a URI that must be
                written via the ByteStream API.
        """

        files = proto.RepeatedField(
            proto.STRING,
            number=1,
        )
        directories = proto.RepeatedField(
            proto.STRING,
            number=2,
        )
        stdout_destination = proto.Field(
            proto.STRING,
            number=3,
        )
        stderr_destination = proto.Field(
            proto.STRING,
            number=4,
        )

    class Timeouts(proto.Message):
        r"""Describes the timeouts associated with this task.
        Attributes:
            execution (google.protobuf.duration_pb2.Duration):
                This specifies the maximum time that the task
                can run, excluding the time required to download
                inputs or upload outputs. That is, the worker
                will terminate the task if it runs longer than
                this.
            idle (google.protobuf.duration_pb2.Duration):
                This specifies the maximum amount of time the
                task can be idle - that is, go without
                generating some output in either stdout or
                stderr. If the process is silent for more than
                the specified time, the worker will terminate
                the task.
            shutdown (google.protobuf.duration_pb2.Duration):
                If the execution or IO timeouts are exceeded, the worker
                will try to gracefully terminate the task and return any
                existing logs. However, tasks may be hard-frozen in which
                case this process will fail. This timeout specifies how long
                to wait for a terminated task to shut down gracefully (e.g.
                via SIGTERM) before we bring down the hammer (e.g. SIGKILL
                on \*nix, CTRL_BREAK_EVENT on Windows).
        """

        execution = proto.Field(
            proto.MESSAGE,
            number=1,
            message=gp_duration.Duration,
        )
        idle = proto.Field(
            proto.MESSAGE,
            number=2,
            message=gp_duration.Duration,
        )
        shutdown = proto.Field(
            proto.MESSAGE,
            number=3,
            message=gp_duration.Duration,
        )

    inputs = proto.Field(
        proto.MESSAGE,
        number=1,
        message=Inputs,
    )
    expected_outputs = proto.Field(
        proto.MESSAGE,
        number=4,
        message=Outputs,
    )
    timeouts = proto.Field(
        proto.MESSAGE,
        number=5,
        message=Timeouts,
    )


class CommandOutputs(proto.Message):
    r"""DEPRECATED - use CommandResult instead.
    Describes the actual outputs from the task.

    Attributes:
        exit_code (int):
            exit_code is only fully reliable if the status' code is OK.
            If the task exceeded its deadline or was cancelled, the
            process may still produce an exit code as it is cancelled,
            and this will be populated, but a successful (zero) is
            unlikely to be correct unless the status code is OK.
        outputs (google.devtools.remoteworkers_v1.types.Digest):
            The output files. The blob referenced by the digest should
            contain one of the following (implementation-dependent): \*
            A marshalled DirectoryMetadata of the returned filesystem \*
            A LUCI-style .isolated file
    """

    exit_code = proto.Field(
        proto.INT32,
        number=1,
    )
    outputs = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Digest',
    )


class CommandOverhead(proto.Message):
    r"""DEPRECATED - use CommandResult instead.
    Can be used as part of CompleteRequest.metadata, or are part of
    a more sophisticated message.

    Attributes:
        duration (google.protobuf.duration_pb2.Duration):
            The elapsed time between calling Accept and
            Complete. The server will also have its own idea
            of what this should be, but this excludes the
            overhead of the RPCs and the bot response time.
        overhead (google.protobuf.duration_pb2.Duration):
            The amount of time *not* spent executing the command (ie
            uploading/downloading files).
    """

    duration = proto.Field(
        proto.MESSAGE,
        number=1,
        message=gp_duration.Duration,
    )
    overhead = proto.Field(
        proto.MESSAGE,
        number=2,
        message=gp_duration.Duration,
    )


class CommandResult(proto.Message):
    r"""All information about the execution of a command, suitable for
    providing as the Bots interface's ``Lease.result`` field.

    Attributes:
        status (google.rpc.status_pb2.Status):
            An overall status for the command. For example, if the
            command timed out, this might have a code of
            DEADLINE_EXCEEDED; if it was killed by the OS for memory
            exhaustion, it might have a code of RESOURCE_EXHAUSTED.
        exit_code (int):
            The exit code of the process. An exit code of "0" should
            only be trusted if ``status`` has a code of OK (otherwise it
            may simply be unset).
        outputs (google.devtools.remoteworkers_v1.types.Digest):
            The output files. The blob referenced by the digest should
            contain one of the following (implementation-dependent): \*
            A marshalled DirectoryMetadata of the returned filesystem \*
            A LUCI-style .isolated file
        duration (google.protobuf.duration_pb2.Duration):
            The elapsed time between calling Accept and
            Complete. The server will also have its own idea
            of what this should be, but this excludes the
            overhead of the RPCs and the bot response time.
        overhead (google.protobuf.duration_pb2.Duration):
            The amount of time *not* spent executing the command (ie
            uploading/downloading files).
        metadata (Sequence[google.protobuf.any_pb2.Any]):
            Implementation-dependent metadata about the task. Both
            servers and bots may define messages which can be encoded
            here; bots are free to provide metadata in multiple formats,
            and servers are free to choose one or more of the values to
            process and ignore others. In particular, it is *not*
            considered an error for the bot to provide the server with a
            field that it doesn't know about.
    """

    status = proto.Field(
        proto.MESSAGE,
        number=1,
        message=gr_status.Status,
    )
    exit_code = proto.Field(
        proto.INT32,
        number=2,
    )
    outputs = proto.Field(
        proto.MESSAGE,
        number=3,
        message='Digest',
    )
    duration = proto.Field(
        proto.MESSAGE,
        number=4,
        message=gp_duration.Duration,
    )
    overhead = proto.Field(
        proto.MESSAGE,
        number=5,
        message=gp_duration.Duration,
    )
    metadata = proto.RepeatedField(
        proto.MESSAGE,
        number=6,
        message=gp_any.Any,
    )


class FileMetadata(proto.Message):
    r"""The metadata for a file. Similar to the equivalent message in
    the Remote Execution API.

    Attributes:
        path (str):
            The path of this file. If this message is
            part of the CommandOutputs.outputs fields, the
            path is relative to the execution root and must
            correspond to an entry in
            CommandTask.outputs.files. If this message is
            part of a Directory message, then the path is
            relative to the root of that directory. All
            paths MUST be delimited by forward slashes.
        digest (google.devtools.remoteworkers_v1.types.Digest):
            A pointer to the contents of the file. The
            method by which a client retrieves the contents
            from a CAS system is not defined here.
        contents (bytes):
            If the file is small enough, its contents may
            also or alternatively be listed here.
        is_executable (bool):
            Properties of the file
    """

    path = proto.Field(
        proto.STRING,
        number=1,
    )
    digest = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Digest',
    )
    contents = proto.Field(
        proto.BYTES,
        number=3,
    )
    is_executable = proto.Field(
        proto.BOOL,
        number=4,
    )


class DirectoryMetadata(proto.Message):
    r"""The metadata for a directory. Similar to the equivalent
    message in the Remote Execution API.

    Attributes:
        path (str):
            The path of the directory, as in
            [FileMetadata.path][google.devtools.remoteworkers.v1test2.FileMetadata.path].
        digest (google.devtools.remoteworkers_v1.types.Digest):
            A pointer to the contents of the directory,
            in the form of a marshalled Directory message.
    """

    path = proto.Field(
        proto.STRING,
        number=1,
    )
    digest = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Digest',
    )


class Digest(proto.Message):
    r"""The CommandTask and CommandResult messages assume the
    existence of a service that can serve blobs of content,
    identified by a hash and size known as a "digest." The method by
    which these blobs may be retrieved is not specified here, but a
    model implementation is in the Remote Execution API's
    "ContentAddressibleStorage" interface.

    In the context of the RWAPI, a Digest will virtually always
    refer to the contents of a file or a directory. The latter is
    represented by the byte-encoded Directory message.

    Attributes:
        hash_ (str):
            A string-encoded hash (eg "1a2b3c", not the byte array
            [0x1a, 0x2b, 0x3c]) using an implementation-defined hash
            algorithm (eg SHA-256).
        size_bytes (int):
            The size of the contents. While this is not
            strictly required as part of an identifier
            (after all, any given hash will have exactly one
            canonical size), it's useful in almost all cases
            when one might want to send or retrieve blobs of
            content and is included here for this reason.
    """

    hash_ = proto.Field(
        proto.STRING,
        number=1,
    )
    size_bytes = proto.Field(
        proto.INT64,
        number=2,
    )


class Blob(proto.Message):
    r"""Describes a blob of binary content with its digest.
    Attributes:
        digest (google.devtools.remoteworkers_v1.types.Digest):
            The digest of the blob. This should be
            verified by the receiver.
        contents (bytes):
            The contents of the blob.
    """

    digest = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Digest',
    )
    contents = proto.Field(
        proto.BYTES,
        number=2,
    )


class Directory(proto.Message):
    r"""The contents of a directory. Similar to the equivalent
    message in the Remote Execution API.

    Attributes:
        files (Sequence[google.devtools.remoteworkers_v1.types.FileMetadata]):
            The files in this directory
        directories (Sequence[google.devtools.remoteworkers_v1.types.DirectoryMetadata]):
            Any subdirectories
    """

    files = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='FileMetadata',
    )
    directories = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='DirectoryMetadata',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
