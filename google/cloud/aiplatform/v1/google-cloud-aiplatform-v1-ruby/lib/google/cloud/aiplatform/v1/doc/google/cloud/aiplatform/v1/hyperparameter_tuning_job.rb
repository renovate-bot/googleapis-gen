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
  module Cloud
    module Aiplatform
      module V1
        # Represents a HyperparameterTuningJob. A HyperparameterTuningJob
        # has a Study specification and multiple CustomJobs with identical
        # CustomJob specification.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. Resource name of the HyperparameterTuningJob.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The display name of the HyperparameterTuningJob.
        #     The name can be up to 128 characters long and can be consist of any UTF-8
        #     characters.
        # @!attribute [rw] study_spec
        #   @return [Google::Cloud::Aiplatform::V1::StudySpec]
        #     Required. Study configuration of the HyperparameterTuningJob.
        # @!attribute [rw] max_trial_count
        #   @return [Integer]
        #     Required. The desired total number of Trials.
        # @!attribute [rw] parallel_trial_count
        #   @return [Integer]
        #     Required. The desired number of Trials to run in parallel.
        # @!attribute [rw] max_failed_trial_count
        #   @return [Integer]
        #     The number of failed Trials that need to be seen before failing
        #     the HyperparameterTuningJob.
        #
        #     If set to 0, AI Platform decides how many Trials must fail
        #     before the whole job fails.
        # @!attribute [rw] trial_job_spec
        #   @return [Google::Cloud::Aiplatform::V1::CustomJobSpec]
        #     Required. The spec of a trial job. The same spec applies to the CustomJobs created
        #     in all the trials.
        # @!attribute [rw] trials
        #   @return [Array<Google::Cloud::Aiplatform::V1::Trial>]
        #     Output only. Trials of the HyperparameterTuningJob.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Aiplatform::V1::JobState]
        #     Output only. The detailed state of the job.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the HyperparameterTuningJob was created.
        # @!attribute [rw] start_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the HyperparameterTuningJob for the first time entered the
        #     `JOB_STATE_RUNNING` state.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the HyperparameterTuningJob entered any of the following states:
        #     `JOB_STATE_SUCCEEDED`, `JOB_STATE_FAILED`, `JOB_STATE_CANCELLED`.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the HyperparameterTuningJob was most recently updated.
        # @!attribute [rw] error
        #   @return [Google::Rpc::Status]
        #     Output only. Only populated when job's state is JOB_STATE_FAILED or
        #     JOB_STATE_CANCELLED.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     The labels with user-defined metadata to organize HyperparameterTuningJobs.
        #
        #     Label keys and values can be no longer than 64 characters
        #     (Unicode codepoints), can only contain lowercase letters, numeric
        #     characters, underscores and dashes. International characters are allowed.
        #
        #     See https://goo.gl/xmQnxf for more information and examples of labels.
        # @!attribute [rw] encryption_spec
        #   @return [Google::Cloud::Aiplatform::V1::EncryptionSpec]
        #     Customer-managed encryption key options for a HyperparameterTuningJob.
        #     If this is set, then all resources created by the HyperparameterTuningJob
        #     will be encrypted with the provided encryption key.
        class HyperparameterTuningJob; end
      end
    end
  end
end