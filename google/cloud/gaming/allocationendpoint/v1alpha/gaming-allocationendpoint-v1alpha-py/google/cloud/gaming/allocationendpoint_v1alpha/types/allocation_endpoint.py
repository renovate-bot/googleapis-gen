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
    package='google.cloud.gaming.allocationendpoint.v1alpha',
    manifest={
        'AllocationRequest',
        'AllocationResponse',
        'MetaPatch',
        'GameServerSelector',
    },
)


class AllocationRequest(proto.Message):
    r"""

    Attributes:
        realm (str):
            The required realm name in the following form:
            ``{location}/{realm}``.
        default_game_server_deployment (str):
            The default game server deployment name.
            This is used to increase the likelihood of a
            successful allocation.
        game_server_selectors (Sequence[google.cloud.gaming.allocationendpoint_v1alpha.types.GameServerSelector]):
            The ordered list of game server labels to
            match for allocations. If the first game server
            selector is not matched, the selection attempts
            the second game server selector, and so on.
        metadata (google.cloud.gaming.allocationendpoint_v1alpha.types.MetaPatch):
            Metadata is optional custom metadata that is
            added to the game server at allocation. You can
            use this to tell the server necessary session
            data.
    """

    realm = proto.Field(
        proto.STRING,
        number=1,
    )
    default_game_server_deployment = proto.Field(
        proto.STRING,
        number=2,
    )
    game_server_selectors = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='GameServerSelector',
    )
    metadata = proto.Field(
        proto.MESSAGE,
        number=4,
        message='MetaPatch',
    )


class AllocationResponse(proto.Message):
    r"""

    Attributes:
        game_server_name (str):
            The name of the allocated game server.
        ports (Sequence[google.cloud.gaming.allocationendpoint_v1alpha.types.AllocationResponse.GameServerStatusPort]):
            The allocated game server's port information.
        address (str):
            The address of the allocated game server.
        node_name (str):
            The node name of the allocated game server.
        game_server_cluster_name (str):
            The game server cluster from which the game
            server was allocated.
        deployment_name (str):
            The game server deployment from which the
            game server was allocated.
    """

    class GameServerStatusPort(proto.Message):
        r"""The game server port info that is allocated.

        Attributes:
            name (str):

            port (int):

        """

        name = proto.Field(
            proto.STRING,
            number=1,
        )
        port = proto.Field(
            proto.INT32,
            number=2,
        )

    game_server_name = proto.Field(
        proto.STRING,
        number=1,
    )
    ports = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=GameServerStatusPort,
    )
    address = proto.Field(
        proto.STRING,
        number=3,
    )
    node_name = proto.Field(
        proto.STRING,
        number=4,
    )
    game_server_cluster_name = proto.Field(
        proto.STRING,
        number=5,
    )
    deployment_name = proto.Field(
        proto.STRING,
        number=6,
    )


class MetaPatch(proto.Message):
    r"""MetaPatch is the metadata used to patch the Game Server
    metadata on allocation. It behaves exactly as it does in OSS.

    Attributes:
        labels (Sequence[google.cloud.gaming.allocationendpoint_v1alpha.types.MetaPatch.LabelsEntry]):

        annotations (Sequence[google.cloud.gaming.allocationendpoint_v1alpha.types.MetaPatch.AnnotationsEntry]):

    """

    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=1,
    )
    annotations = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=2,
    )


class GameServerSelector(proto.Message):
    r"""GameServerSelector used for finding a GameServer with
    matching labels.

    Attributes:
        match_labels (Sequence[google.cloud.gaming.allocationendpoint_v1alpha.types.GameServerSelector.MatchLabelsEntry]):
            Labels to match.
    """

    match_labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=1,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
