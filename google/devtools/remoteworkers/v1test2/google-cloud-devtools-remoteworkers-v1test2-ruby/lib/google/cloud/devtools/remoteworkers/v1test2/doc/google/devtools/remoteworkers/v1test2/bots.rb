# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Devtools
    module Remoteworkers
      module V1test2
        # A bot session represents the state of a bot while in continuous contact with
        # the server for a period of time. The session includes information about the
        # worker - that is, the *worker* (the physical or virtual hardware) is
        # considered to be a property of the bot (the software agent running on that
        # hardware), which is the reverse of real life, but more natural from the point
        # of the view of this API, which communicates solely with the bot and not
        # directly with the underlying worker.
        # @!attribute [rw] name
        #   @return [String]
        #     The bot session name, as selected by the server. Output only during a call
        #     to CreateBotSession.
        # @!attribute [rw] bot_id
        #   @return [String]
        #     A unique bot ID within the farm used to persistently identify this bot over
        #     time (i.e., over multiple sessions). This ID must be unique within a
        #     farm. Typically, the bot ID will be the same as the name of the primary
        #     device in the worker (e.g., what you'd get from typing `uname -n` on *nix),
        #     but this is not required since a single device may allow multiple bots to
        #     run on it, each with access to different resources. What is important is
        #     that this ID is meaningful to humans, who might need to hunt a physical
        #     machine down to fix it.
        #
        #     When CreateBotSession is successfully called with a bot_id, all prior
        #     sessions with the same ID are invalidated. If a bot attempts to update an
        #     invalid session, the server must reject that request, and may also
        #     quarantine the other bot with the same bot IDs (ie, stop sending it new
        #     leases and alert an admin).
        # @!attribute [rw] status
        #   @return [Google::Devtools::Remoteworkers::V1test2::BotStatus]
        #     The status of the bot. This must be populated in every call to
        #     UpdateBotSession.
        # @!attribute [rw] worker
        #   @return [Google::Devtools::Remoteworkers::V1test2::Worker]
        #     A description of the worker hosting this bot. The Worker message is used
        #     here in the Status context (see Worker for more information).  If multiple
        #     bots are running on the worker, this field should only describe the
        #     resources accessible from this bot.
        #
        #     During the call to CreateBotSession, the server may make arbitrary changes
        #     to the worker's `server_properties` field (see that field for more
        #     information). Otherwise, this field is input-only.
        # @!attribute [rw] leases
        #   @return [Array<Google::Devtools::Remoteworkers::V1test2::Lease>]
        #     A list of all leases that are a part of this session. See the Lease message
        #     for details.
        # @!attribute [rw] expire_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time at which this bot session will expire, unless the bot calls
        #     UpdateBotSession again. Output only.
        # @!attribute [rw] version
        #   @return [String]
        #     The version of the bot code currently running. The server may use this
        #     information to issue an admin action to tell the bot to update itself.
        class BotSession; end

        # A Lease is a lease that the scheduler has assigned to this bot. If the bot
        # notices (by UpdateBotSession) that it has any leases in the PENDING state, it
        # should call UpdateBotSession to put the leases into the ACTIVE state and
        # start executing their assignments.
        #
        # All fields in this message are output-only, *except* the `state` and `status`
        # fields. Note that repeated fields can only be updated as a unit, so on every
        # update the bot must provide an update for *all* the leases the server expects
        # it to report on.
        #
        # The scheduler *should* ensure that all leases scheduled to a bot can actually
        # be accepted, but race conditions may occur. In such cases, the bot should
        # attempt to accept the leases in the order they are listed by the server, to
        # allow the server to control priorities.
        #
        # The server will remove COMPLETED leases from time to time, after which the
        # bot shouldn't report on them any more (the server will ignore superfluous
        # COMPLETED records).
        # @!attribute [rw] id
        #   @return [String]
        #     A short string uniquely identifing the lease within this bot session.
        # @!attribute [rw] payload
        #   @return [Google::Protobuf::Any]
        #     The actual work to be performed, if any. May be omitted by the server if
        #     the lease is not in the `PENDING` state. The message must be meaningful to
        #     the bot. Output only (must only be set by the server).
        # @!attribute [rw] result
        #   @return [Google::Protobuf::Any]
        #     Any result the bot wishes to provide about the lease. Must not be changed
        #     after the first call with the lease in the `COMPLETED` or `CANCELLED`
        #     state. Input only (must only be set by the bot, will not be echoed by the
        #     server).
        # @!attribute [rw] state
        #   @return [Google::Devtools::Remoteworkers::V1test2::LeaseState]
        #     The state of the lease. See LeaseState for more information.
        # @!attribute [rw] status
        #   @return [Google::Rpc::Status]
        #     The final status of the lease (should be populated by the bot if the state
        #     is completed). This is the status of the lease, not of any task represented
        #     by the lease. For example, if the bot could not accept the lease because it
        #     asked for some resource the bot didn't have, this status will be
        #     FAILED_PRECONDITION. But if the assignment in the lease didn't execute
        #     correctly, this field will be `OK` while the failure of the assignment must
        #     communicated via the `result` field.
        # @!attribute [rw] requirements
        #   @return [Google::Devtools::Remoteworkers::V1test2::Worker]
        #     The requirements that are being claimed by this lease. This field may be
        #     omitted by the server if the lease is not pending.
        # @!attribute [rw] expire_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time at which this lease expires. The server *may* extend this over
        #     time, but due to race conditions, the bot is not *required* to respect any
        #     expiry date except the first one.
        # @!attribute [rw] assignment
        #   @return [String]
        #     DEPRECATED. The assignment should be provided to the bot via the `payload`
        #     field. Clients that wish to use a simple name (such as a queue of work
        #     provided elsewhere) should define a custom message type and encode it into
        #     `payload`.
        # @!attribute [rw] inline_assignment
        #   @return [Google::Protobuf::Any]
        #     DEPRECATED. Use `payload` instead.
        class Lease; end

        # AdminTemp is a prelimiary set of administration tasks. It's called "Temp"
        # because we do not yet know the best way to represent admin tasks; it's
        # possible that this will be entirely replaced in later versions of this API.
        # If this message proves to be sufficient, it will be renamed in the alpha or
        # beta release of this API.
        #
        # This message (suitably marshalled into a protobuf.Any) can be used as the
        # inline_assignment field in a lease; the lease assignment field should simply
        # be `"admin"` in these cases.
        #
        # This message is heavily based on Swarming administration tasks from the LUCI
        # project (http://github.com/luci/luci-py/appengine/swarming).
        # @!attribute [rw] command
        #   @return [Google::Devtools::Remoteworkers::V1test2::AdminTemp::Command]
        #     The admin action; see `Command` for legal values.
        # @!attribute [rw] arg
        #   @return [String]
        #     The argument to the admin action; see `Command` for semantics.
        class AdminTemp
          # Possible administration actions.
          module Command
            # Illegal value.
            UNSPECIFIED = 0

            # Download and run a new version of the bot. `arg` will be a resource
            # accessible via `ByteStream.Read` to obtain the new bot code.
            BOT_UPDATE = 1

            # Restart the bot without downloading a new version. `arg` will be a
            # message to log.
            BOT_RESTART = 2

            # Shut down the bot. `arg` will be a task resource name (similar to those
            # in tasks.proto) that the bot can use to tell the server that it is
            # terminating.
            BOT_TERMINATE = 3

            # Restart the host computer. `arg` will be a message to log.
            HOST_RESTART = 4
          end
        end

        # Request message for CreateBotSession.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The farm resource.
        # @!attribute [rw] bot_session
        #   @return [Google::Devtools::Remoteworkers::V1test2::BotSession]
        #     Required. The bot session to create. Server-assigned fields like name must be unset.
        class CreateBotSessionRequest; end

        # Request message for UpdateBotSession.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The bot session name. Must match bot_session.name.
        # @!attribute [rw] bot_session
        #   @return [Google::Devtools::Remoteworkers::V1test2::BotSession]
        #     Required. The bot session resource to update.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The fields on the bot that should be updated. See the BotSession resource
        #     for which fields are updatable by which caller.
        class UpdateBotSessionRequest; end

        # A coarse description of the status of the bot that the server uses to
        # determine whether to assign the bot new leases.
        module BotStatus
          # Default value; do not use.
          BOT_STATUS_UNSPECIFIED = 0

          # The bot is healthy, and will accept leases as normal.
          OK = 1

          # The bot is unhealthy and will not accept new leases. For example, the bot
          # may have detected that available disk space is too low. This situation may
          # resolve itself, but will typically require human intervention.
          UNHEALTHY = 2

          # The bot has been asked to reboot the host. The bot will not accept new
          # leases; once all leases are complete, this session will no longer be
          # updated but the bot will be expected to establish a new session after the
          # reboot completes.
          HOST_REBOOTING = 3

          # The bot has been asked to shut down. As with HOST_REBOOTING, once all
          # leases are completed, the session will no longer be updated and the bot
          # will not be expected to establish a new session.
          #
          # Bots are typically only asked to shut down if its host computer will be
          # modified in some way, such as deleting a VM.
          BOT_TERMINATING = 4

          # The bot is initializing and is not ready to accept leases.
          INITIALIZING = 5
        end

        # The state of the lease. All leases start in the PENDING state. A bot can
        # change PENDING to ACTIVE or (in the case of an error) COMPLETED, or from
        # ACTIVE to COMPLETED. The server can change PENDING or ACTIVE to CANCELLED if
        # it wants the bot to release its resources - for example, if the bot needs to
        # be quarantined (it's producing bad output) or a cell needs to be drained.
        module LeaseState
          # Default value; do not use.
          LEASE_STATE_UNSPECIFIED = 0

          # Pending: the server expects the bot to accept this lease. This may only be
          # set by the server.
          PENDING = 1

          # Active: the bot has accepted this lease. This may only be set by the bot.
          ACTIVE = 2

          # Completed: the bot is no longer leased. This may only be set by the bot,
          # and the status field must be populated iff the state is COMPLETED.
          COMPLETED = 4

          # Cancelled: The bot should immediately release all resources associated with
          # the lease. This may only be set by the server.
          CANCELLED = 5
        end
      end
    end
  end
end