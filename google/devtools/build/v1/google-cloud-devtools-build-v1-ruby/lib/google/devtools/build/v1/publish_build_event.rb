# frozen_string_literal: true

# Copyright 2022 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!

require "gapic/common"
require "gapic/config"
require "gapic/config/method"

require "google/cloud/build/v1/version"

require "google/devtools/build/v1/publish_build_event/credentials"
require "google/devtools/build/v1/publish_build_event/client"

module Google
  module Devtools
    module Build
      module V1
        ##
        # A service for publishing BuildEvents. BuildEvents are generated by Build
        # Systems to record actions taken during a Build. Events occur in streams,
        # are identified by a StreamId, and ordered by sequence number in a stream.
        #
        # A Build may contain several streams of BuildEvents, depending on the systems
        # that are involved in the Build. Some BuildEvents are used to declare the
        # beginning and end of major portions of a Build; these are called
        # LifecycleEvents, and are used (for example) to indicate the beginning or end
        # of a Build, and the beginning or end of an Invocation attempt (there can be
        # more than 1 Invocation in a Build if, for example, a failure occurs somewhere
        # and it needs to be retried).
        #
        # Other, build-tool events represent actions taken by the Build tool, such as
        # target objects produced via compilation, tests run, et cetera. There could be
        # more than one build tool stream for an invocation attempt of a build.
        #
        # To load this service and instantiate a client:
        #
        #     require "google/devtools/build/v1/publish_build_event"
        #     client = ::Google::Devtools::Build::V1::PublishBuildEvent::Client.new
        #
        module PublishBuildEvent
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "publish_build_event", "helpers.rb"
require "google/devtools/build/v1/publish_build_event/helpers" if ::File.file? helper_path
