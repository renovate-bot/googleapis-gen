# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/dialogflow/cx/v3beta1/experiment.proto for package 'google.cloud.dialogflow.cx.v3beta1'
# Original file comments:
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

require 'grpc'
require 'google/cloud/dialogflow/cx/v3beta1/experiment_pb'

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3beta1
          module Experiments
            # Service for managing [Experiments][google.cloud.dialogflow.cx.v3beta1.Experiment].
            class Service

              include GRPC::GenericService

              self.marshal_class_method = :encode
              self.unmarshal_class_method = :decode
              self.service_name = 'google.cloud.dialogflow.cx.v3beta1.Experiments'

              # Returns the list of all experiments in the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              rpc :ListExperiments, ::Google::Cloud::Dialogflow::Cx::V3beta1::ListExperimentsRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::ListExperimentsResponse
              # Retrieves the specified [Experiment][google.cloud.dialogflow.cx.v3beta1.Experiment].
              rpc :GetExperiment, ::Google::Cloud::Dialogflow::Cx::V3beta1::GetExperimentRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Experiment
              # Creates an [Experiment][google.cloud.dialogflow.cx.v3beta1.Experiment] in the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              rpc :CreateExperiment, ::Google::Cloud::Dialogflow::Cx::V3beta1::CreateExperimentRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Experiment
              # Updates the specified [Experiment][google.cloud.dialogflow.cx.v3beta1.Experiment].
              rpc :UpdateExperiment, ::Google::Cloud::Dialogflow::Cx::V3beta1::UpdateExperimentRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Experiment
              # Deletes the specified [Experiment][google.cloud.dialogflow.cx.v3beta1.Experiment].
              rpc :DeleteExperiment, ::Google::Cloud::Dialogflow::Cx::V3beta1::DeleteExperimentRequest, ::Google::Protobuf::Empty
              # Starts the specified [Experiment][google.cloud.dialogflow.cx.v3beta1.Experiment]. This rpc only changes the state of
              # experiment from PENDING to RUNNING.
              rpc :StartExperiment, ::Google::Cloud::Dialogflow::Cx::V3beta1::StartExperimentRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Experiment
              # Stops the specified [Experiment][google.cloud.dialogflow.cx.v3beta1.Experiment]. This rpc only changes the state of
              # experiment from RUNNING to DONE.
              rpc :StopExperiment, ::Google::Cloud::Dialogflow::Cx::V3beta1::StopExperimentRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Experiment
            end

            Stub = Service.rpc_stub_class
          end
        end
      end
    end
  end
end
