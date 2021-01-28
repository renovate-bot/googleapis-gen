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
        # Request message for {Google::Cloud::Aiplatform::V1::PredictionService::Predict PredictionService::Predict}.
        # @!attribute [rw] endpoint
        #   @return [String]
        #     Required. The name of the Endpoint requested to serve the prediction.
        #     Format:
        #     `projects/{project}/locations/{location}/endpoints/{endpoint}`
        # @!attribute [rw] instances
        #   @return [Array<Google::Protobuf::Value>]
        #     Required. The instances that are the input to the prediction call.
        #     A DeployedModel may have an upper limit on the number of instances it
        #     supports per request, and when it is exceeded the prediction call errors
        #     in case of AutoML Models, or, in case of customer created Models, the
        #     behaviour is as documented by that Model.
        #     The schema of any single instance may be specified via Endpoint's
        #     DeployedModels' {Google::Cloud::Aiplatform::V1::DeployedModel#model Model's}
        #     {Google::Cloud::Aiplatform::V1::Model#predict_schemata PredictSchemata's}
        #     {Google::Cloud::Aiplatform::V1::PredictSchemata#instance_schema_uri instance_schema_uri}.
        # @!attribute [rw] parameters
        #   @return [Google::Protobuf::Value]
        #     The parameters that govern the prediction. The schema of the parameters may
        #     be specified via Endpoint's DeployedModels' {Google::Cloud::Aiplatform::V1::DeployedModel#model Model's }
        #     {Google::Cloud::Aiplatform::V1::Model#predict_schemata PredictSchemata's}
        #     {Google::Cloud::Aiplatform::V1::PredictSchemata#parameters_schema_uri parameters_schema_uri}.
        class PredictRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::PredictionService::Predict PredictionService::Predict}.
        # @!attribute [rw] predictions
        #   @return [Array<Google::Protobuf::Value>]
        #     The predictions that are the output of the predictions call.
        #     The schema of any single prediction may be specified via Endpoint's
        #     DeployedModels' {Google::Cloud::Aiplatform::V1::DeployedModel#model Model's }
        #     {Google::Cloud::Aiplatform::V1::Model#predict_schemata PredictSchemata's}
        #     {Google::Cloud::Aiplatform::V1::PredictSchemata#prediction_schema_uri prediction_schema_uri}.
        # @!attribute [rw] deployed_model_id
        #   @return [String]
        #     ID of the Endpoint's DeployedModel that served this prediction.
        class PredictResponse; end
      end
    end
  end
end