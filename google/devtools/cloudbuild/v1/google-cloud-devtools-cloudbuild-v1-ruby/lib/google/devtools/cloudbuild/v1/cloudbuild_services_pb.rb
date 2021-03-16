# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/devtools/cloudbuild/v1/cloudbuild.proto for package 'Google.Cloud.Build.V1'
# Original file comments:
# Copyright 2021 Google LLC
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

require 'grpc'
require 'google/devtools/cloudbuild/v1/cloudbuild_pb'

module Google
  module Cloud
    module Build
      module V1
        module CloudBuild
          # Creates and manages builds on Google Cloud Platform.
          #
          # The main concept used by this API is a `Build`, which describes the location
          # of the source to build, how to build the source, and where to store the
          # built artifacts, if any.
          #
          # A user can list previously-requested builds or get builds by their ID to
          # determine the status of the build.
          class Service

            include GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.devtools.cloudbuild.v1.CloudBuild'

            # Starts a build with the specified configuration.
            #
            # This method returns a long-running `Operation`, which includes the build
            # ID. Pass the build ID to `GetBuild` to determine the build status (such as
            # `SUCCESS` or `FAILURE`).
            rpc :CreateBuild, ::Google::Cloud::Build::V1::CreateBuildRequest, ::Google::Longrunning::Operation
            # Returns information about a previously requested build.
            #
            # The `Build` that is returned includes its status (such as `SUCCESS`,
            # `FAILURE`, or `WORKING`), and timing information.
            rpc :GetBuild, ::Google::Cloud::Build::V1::GetBuildRequest, ::Google::Cloud::Build::V1::Build
            # Lists previously requested builds.
            #
            # Previously requested builds may still be in-progress, or may have finished
            # successfully or unsuccessfully.
            rpc :ListBuilds, ::Google::Cloud::Build::V1::ListBuildsRequest, ::Google::Cloud::Build::V1::ListBuildsResponse
            # Cancels a build in progress.
            rpc :CancelBuild, ::Google::Cloud::Build::V1::CancelBuildRequest, ::Google::Cloud::Build::V1::Build
            # Creates a new build based on the specified build.
            #
            # This method creates a new build using the original build request, which may
            # or may not result in an identical build.
            #
            # For triggered builds:
            #
            # * Triggered builds resolve to a precise revision; therefore a retry of a
            # triggered build will result in a build that uses the same revision.
            #
            # For non-triggered builds that specify `RepoSource`:
            #
            # * If the original build built from the tip of a branch, the retried build
            # will build from the tip of that branch, which may not be the same revision
            # as the original build.
            # * If the original build specified a commit sha or revision ID, the retried
            # build will use the identical source.
            #
            # For builds that specify `StorageSource`:
            #
            # * If the original build pulled source from Google Cloud Storage without
            # specifying the generation of the object, the new build will use the current
            # object, which may be different from the original build source.
            # * If the original build pulled source from Cloud Storage and specified the
            # generation of the object, the new build will attempt to use the same
            # object, which may or may not be available depending on the bucket's
            # lifecycle management settings.
            rpc :RetryBuild, ::Google::Cloud::Build::V1::RetryBuildRequest, ::Google::Longrunning::Operation
            # Creates a new `BuildTrigger`.
            #
            # This API is experimental.
            rpc :CreateBuildTrigger, ::Google::Cloud::Build::V1::CreateBuildTriggerRequest, ::Google::Cloud::Build::V1::BuildTrigger
            # Returns information about a `BuildTrigger`.
            #
            # This API is experimental.
            rpc :GetBuildTrigger, ::Google::Cloud::Build::V1::GetBuildTriggerRequest, ::Google::Cloud::Build::V1::BuildTrigger
            # Lists existing `BuildTrigger`s.
            #
            # This API is experimental.
            rpc :ListBuildTriggers, ::Google::Cloud::Build::V1::ListBuildTriggersRequest, ::Google::Cloud::Build::V1::ListBuildTriggersResponse
            # Deletes a `BuildTrigger` by its project ID and trigger ID.
            #
            # This API is experimental.
            rpc :DeleteBuildTrigger, ::Google::Cloud::Build::V1::DeleteBuildTriggerRequest, ::Google::Protobuf::Empty
            # Updates a `BuildTrigger` by its project ID and trigger ID.
            #
            # This API is experimental.
            rpc :UpdateBuildTrigger, ::Google::Cloud::Build::V1::UpdateBuildTriggerRequest, ::Google::Cloud::Build::V1::BuildTrigger
            # Runs a `BuildTrigger` at a particular source revision.
            rpc :RunBuildTrigger, ::Google::Cloud::Build::V1::RunBuildTriggerRequest, ::Google::Longrunning::Operation
            # ReceiveTriggerWebhook [Experimental] is called when the API receives a
            # webhook request targeted at a specific trigger.
            rpc :ReceiveTriggerWebhook, ::Google::Cloud::Build::V1::ReceiveTriggerWebhookRequest, ::Google::Cloud::Build::V1::ReceiveTriggerWebhookResponse
            # Creates a `WorkerPool` to run the builds, and returns the new worker pool.
            #
            # This API is experimental.
            rpc :CreateWorkerPool, ::Google::Cloud::Build::V1::CreateWorkerPoolRequest, ::Google::Cloud::Build::V1::WorkerPool
            # Returns information about a `WorkerPool`.
            #
            # This API is experimental.
            rpc :GetWorkerPool, ::Google::Cloud::Build::V1::GetWorkerPoolRequest, ::Google::Cloud::Build::V1::WorkerPool
            # Deletes a `WorkerPool` by its project ID and WorkerPool name.
            #
            # This API is experimental.
            rpc :DeleteWorkerPool, ::Google::Cloud::Build::V1::DeleteWorkerPoolRequest, ::Google::Protobuf::Empty
            # Update a `WorkerPool`.
            #
            # This API is experimental.
            rpc :UpdateWorkerPool, ::Google::Cloud::Build::V1::UpdateWorkerPoolRequest, ::Google::Cloud::Build::V1::WorkerPool
            # List project's `WorkerPools`.
            #
            # This API is experimental.
            rpc :ListWorkerPools, ::Google::Cloud::Build::V1::ListWorkerPoolsRequest, ::Google::Cloud::Build::V1::ListWorkerPoolsResponse
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end
