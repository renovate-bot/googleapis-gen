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


module Google
  module Cloud
    module AutoML
      module V1
        # Annotation details for image object detection.
        # @!attribute [rw] bounding_box
        #   @return [::Google::Cloud::AutoML::V1::BoundingPoly]
        #     Output only. The rectangle representing the object location.
        # @!attribute [rw] score
        #   @return [::Float]
        #     Output only. The confidence that this annotation is positive for the parent example,
        #     value in [0, 1], higher means higher positivity confidence.
        class ImageObjectDetectionAnnotation
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Bounding box matching model metrics for a single intersection-over-union
        # threshold and multiple label match confidence thresholds.
        # @!attribute [rw] iou_threshold
        #   @return [::Float]
        #     Output only. The intersection-over-union threshold value used to compute
        #     this metrics entry.
        # @!attribute [rw] mean_average_precision
        #   @return [::Float]
        #     Output only. The mean average precision, most often close to au_prc.
        # @!attribute [rw] confidence_metrics_entries
        #   @return [::Array<::Google::Cloud::AutoML::V1::BoundingBoxMetricsEntry::ConfidenceMetricsEntry>]
        #     Output only. Metrics for each label-match confidence_threshold from
        #     0.05,0.10,...,0.95,0.96,0.97,0.98,0.99. Precision-recall curve is
        #     derived from them.
        class BoundingBoxMetricsEntry
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # Metrics for a single confidence threshold.
          # @!attribute [rw] confidence_threshold
          #   @return [::Float]
          #     Output only. The confidence threshold value used to compute the metrics.
          # @!attribute [rw] recall
          #   @return [::Float]
          #     Output only. Recall under the given confidence threshold.
          # @!attribute [rw] precision
          #   @return [::Float]
          #     Output only. Precision under the given confidence threshold.
          # @!attribute [rw] f1_score
          #   @return [::Float]
          #     Output only. The harmonic mean of recall and precision.
          class ConfidenceMetricsEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end

        # Model evaluation metrics for image object detection problems.
        # Evaluates prediction quality of labeled bounding boxes.
        # @!attribute [rw] evaluated_bounding_box_count
        #   @return [::Integer]
        #     Output only. The total number of bounding boxes (i.e. summed over all
        #     images) the ground truth used to create this evaluation had.
        # @!attribute [rw] bounding_box_metrics_entries
        #   @return [::Array<::Google::Cloud::AutoML::V1::BoundingBoxMetricsEntry>]
        #     Output only. The bounding boxes match metrics for each
        #     Intersection-over-union threshold 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99
        #     and each label confidence threshold 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99
        #     pair.
        # @!attribute [rw] bounding_box_mean_average_precision
        #   @return [::Float]
        #     Output only. The single metric for bounding boxes evaluation:
        #     the mean_average_precision averaged over all bounding_box_metrics_entries.
        class ImageObjectDetectionEvaluationMetrics
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
