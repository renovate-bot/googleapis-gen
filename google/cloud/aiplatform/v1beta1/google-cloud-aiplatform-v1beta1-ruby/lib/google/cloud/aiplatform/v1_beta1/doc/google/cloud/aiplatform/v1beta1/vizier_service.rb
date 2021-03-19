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
      module V1beta1
        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::GetStudy VizierService::GetStudy}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Study resource.
        #     Format: `projects/{project}/locations/{location}/studies/{study}`
        class GetStudyRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::CreateStudy VizierService::CreateStudy}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to create the CustomJob in.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] study
        #   @return [Google::Cloud::Aiplatform::V1beta1::Study]
        #     Required. The Study configuration used to create the Study.
        class CreateStudyRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::ListStudies VizierService::ListStudies}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to list the Study from.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A page token to request the next page of results.
        #     If unspecified, there are no subsequent pages.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of studies to return per "page" of results.
        #     If unspecified, service will pick an appropriate default.
        class ListStudiesRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::VizierService::ListStudies VizierService::ListStudies}.
        # @!attribute [rw] studies
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::Study>]
        #     The studies associated with the project.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Passes this token as the `page_token` field of the request for a
        #     subsequent call.
        #     If this field is omitted, there are no subsequent pages.
        class ListStudiesResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::DeleteStudy VizierService::DeleteStudy}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Study resource to be deleted.
        #     Format: `projects/{project}/locations/{location}/studies/{study}`
        class DeleteStudyRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::LookupStudy VizierService::LookupStudy}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to get the Study from.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The user-defined display name of the Study
        class LookupStudyRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::SuggestTrials VizierService::SuggestTrials}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The project and location that the Study belongs to.
        #     Format: `projects/{project}/locations/{location}/studies/{study}`
        # @!attribute [rw] suggestion_count
        #   @return [Integer]
        #     Required. The number of suggestions requested.
        # @!attribute [rw] client_id
        #   @return [String]
        #     Required. The identifier of the client that is requesting the suggestion.
        #
        #     If multiple SuggestTrialsRequests have the same `client_id`,
        #     the service will return the identical suggested Trial if the Trial is
        #     pending, and provide a new Trial if the last suggested Trial was completed.
        class SuggestTrialsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::VizierService::SuggestTrials VizierService::SuggestTrials}.
        # @!attribute [rw] trials
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::Trial>]
        #     A list of Trials.
        # @!attribute [rw] study_state
        #   @return [Google::Cloud::Aiplatform::V1beta1::Study::State]
        #     The state of the Study.
        # @!attribute [rw] start_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time at which the operation was started.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time at which operation processing completed.
        class SuggestTrialsResponse; end

        # Details of operations that perform Trials suggestion.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     Operation metadata for suggesting Trials.
        # @!attribute [rw] client_id
        #   @return [String]
        #     The identifier of the client that is requesting the suggestion.
        #
        #     If multiple SuggestTrialsRequests have the same `client_id`,
        #     the service will return the identical suggested Trial if the Trial is
        #     pending, and provide a new Trial if the last suggested Trial was completed.
        class SuggestTrialsMetadata; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::CreateTrial VizierService::CreateTrial}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Study to create the Trial in.
        #     Format: `projects/{project}/locations/{location}/studies/{study}`
        # @!attribute [rw] trial
        #   @return [Google::Cloud::Aiplatform::V1beta1::Trial]
        #     Required. The Trial to create.
        class CreateTrialRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::GetTrial VizierService::GetTrial}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Trial resource.
        #     Format:
        #     `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        class GetTrialRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::ListTrials VizierService::ListTrials}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Study to list the Trial from.
        #     Format: `projects/{project}/locations/{location}/studies/{study}`
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A page token to request the next page of results.
        #     If unspecified, there are no subsequent pages.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The number of Trials to retrieve per "page" of results.
        #     If unspecified, the service will pick an appropriate default.
        class ListTrialsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::VizierService::ListTrials VizierService::ListTrials}.
        # @!attribute [rw] trials
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::Trial>]
        #     The Trials associated with the Study.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Pass this token as the `page_token` field of the request for a
        #     subsequent call.
        #     If this field is omitted, there are no subsequent pages.
        class ListTrialsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::AddTrialMeasurement VizierService::AddTrialMeasurement}.
        # @!attribute [rw] trial_name
        #   @return [String]
        #     Required. The name of the trial to add measurement.
        #     Format:
        #     `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        # @!attribute [rw] measurement
        #   @return [Google::Cloud::Aiplatform::V1beta1::Measurement]
        #     Required. The measurement to be added to a Trial.
        class AddTrialMeasurementRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::CompleteTrial VizierService::CompleteTrial}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The Trial's name.
        #     Format:
        #     `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        # @!attribute [rw] final_measurement
        #   @return [Google::Cloud::Aiplatform::V1beta1::Measurement]
        #     Optional. If provided, it will be used as the completed Trial's
        #     final_measurement; Otherwise, the service will auto-select a
        #     previously reported measurement as the final-measurement
        # @!attribute [rw] trial_infeasible
        #   @return [true, false]
        #     Optional. True if the Trial cannot be run with the given Parameter, and
        #     final_measurement will be ignored.
        # @!attribute [rw] infeasible_reason
        #   @return [String]
        #     Optional. A human readable reason why the trial was infeasible. This should
        #     only be provided if `trial_infeasible` is true.
        class CompleteTrialRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::DeleteTrial VizierService::DeleteTrial}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The Trial's name.
        #     Format:
        #     `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        class DeleteTrialRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::CheckTrialEarlyStoppingState VizierService::CheckTrialEarlyStoppingState}.
        # @!attribute [rw] trial_name
        #   @return [String]
        #     Required. The Trial's name.
        #     Format:
        #     `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        class CheckTrialEarlyStoppingStateRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::VizierService::CheckTrialEarlyStoppingState VizierService::CheckTrialEarlyStoppingState}.
        # @!attribute [rw] should_stop
        #   @return [true, false]
        #     True if the Trial should stop.
        class CheckTrialEarlyStoppingStateResponse; end

        # This message will be placed in the metadata field of a
        # google.longrunning.Operation associated with a CheckTrialEarlyStoppingState
        # request.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     Operation metadata for suggesting Trials.
        # @!attribute [rw] study
        #   @return [String]
        #     The name of the Study that the Trial belongs to.
        # @!attribute [rw] trial
        #   @return [String]
        #     The Trial name.
        class CheckTrialEarlyStoppingStateMetatdata; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::StopTrial VizierService::StopTrial}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The Trial's name.
        #     Format:
        #     `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        class StopTrialRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::VizierService::ListOptimalTrials VizierService::ListOptimalTrials}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the Study that the optimal Trial belongs to.
        class ListOptimalTrialsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::VizierService::ListOptimalTrials VizierService::ListOptimalTrials}.
        # @!attribute [rw] optimal_trials
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::Trial>]
        #     The pareto-optimal Trials for multiple objective Study or the
        #     optimal trial for single objective Study. The definition of
        #     pareto-optimal can be checked in wiki page.
        #     https://en.wikipedia.org/wiki/Pareto_efficiency
        class ListOptimalTrialsResponse; end
      end
    end
  end
end