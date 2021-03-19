# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/aiplatform/v1beta1/dataset_service.proto for package 'google.cloud.aiplatform.v1beta1'
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
require 'google/cloud/aiplatform/v1beta1/dataset_service_pb'

module Google
  module Cloud
    module Aiplatform
      module V1beta1
        module DatasetService
          class Service

            include GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.aiplatform.v1beta1.DatasetService'

            # Creates a Dataset.
            rpc :CreateDataset, ::Google::Cloud::Aiplatform::V1beta1::CreateDatasetRequest, ::Google::Longrunning::Operation
            # Gets a Dataset.
            rpc :GetDataset, ::Google::Cloud::Aiplatform::V1beta1::GetDatasetRequest, ::Google::Cloud::Aiplatform::V1beta1::Dataset
            # Updates a Dataset.
            rpc :UpdateDataset, ::Google::Cloud::Aiplatform::V1beta1::UpdateDatasetRequest, ::Google::Cloud::Aiplatform::V1beta1::Dataset
            # Lists Datasets in a Location.
            rpc :ListDatasets, ::Google::Cloud::Aiplatform::V1beta1::ListDatasetsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListDatasetsResponse
            # Deletes a Dataset.
            rpc :DeleteDataset, ::Google::Cloud::Aiplatform::V1beta1::DeleteDatasetRequest, ::Google::Longrunning::Operation
            # Imports data into a Dataset.
            rpc :ImportData, ::Google::Cloud::Aiplatform::V1beta1::ImportDataRequest, ::Google::Longrunning::Operation
            # Exports data from a Dataset.
            rpc :ExportData, ::Google::Cloud::Aiplatform::V1beta1::ExportDataRequest, ::Google::Longrunning::Operation
            # Lists DataItems in a Dataset.
            rpc :ListDataItems, ::Google::Cloud::Aiplatform::V1beta1::ListDataItemsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListDataItemsResponse
            # Gets an AnnotationSpec.
            rpc :GetAnnotationSpec, ::Google::Cloud::Aiplatform::V1beta1::GetAnnotationSpecRequest, ::Google::Cloud::Aiplatform::V1beta1::AnnotationSpec
            # Lists Annotations belongs to a dataitem
            rpc :ListAnnotations, ::Google::Cloud::Aiplatform::V1beta1::ListAnnotationsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListAnnotationsResponse
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end
