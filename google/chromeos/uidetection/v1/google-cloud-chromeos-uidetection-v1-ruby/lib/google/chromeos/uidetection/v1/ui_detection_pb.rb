# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/chromeos/uidetection/v1/ui_detection.proto

require 'google/api/annotations_pb'
require 'google/api/field_behavior_pb'
require 'google/api/client_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/chromeos/uidetection/v1/ui_detection.proto", :syntax => :proto3) do
    add_message "google.chromeos.uidetection.v1.UiDetectionRequest" do
      optional :image_png, :bytes, 1
      optional :request, :message, 2, "google.chromeos.uidetection.v1.DetectionRequest"
    end
    add_message "google.chromeos.uidetection.v1.DetectionRequest" do
      oneof :detection_request_type do
        optional :word_detection_request, :message, 1, "google.chromeos.uidetection.v1.WordDetectionRequest"
        optional :text_block_detection_request, :message, 2, "google.chromeos.uidetection.v1.TextBlockDetectionRequest"
        optional :custom_icon_detection_request, :message, 3, "google.chromeos.uidetection.v1.CustomIconDetectionRequest"
      end
    end
    add_message "google.chromeos.uidetection.v1.WordDetectionRequest" do
      optional :word, :string, 1
    end
    add_message "google.chromeos.uidetection.v1.TextBlockDetectionRequest" do
      repeated :words, :string, 1
    end
    add_message "google.chromeos.uidetection.v1.CustomIconDetectionRequest" do
      optional :icon_png, :bytes, 1
    end
    add_message "google.chromeos.uidetection.v1.UiDetectionResponse" do
      repeated :bounding_boxes, :message, 1, "google.chromeos.uidetection.v1.BoundingBox"
    end
    add_message "google.chromeos.uidetection.v1.BoundingBox" do
      optional :text, :string, 1
      optional :top, :int32, 2
      optional :left, :int32, 3
      optional :bottom, :int32, 4
      optional :right, :int32, 5
    end
  end
end

module Google
  module Chromeos
    module Uidetection
      module V1
        UiDetectionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.UiDetectionRequest").msgclass
        DetectionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.DetectionRequest").msgclass
        WordDetectionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.WordDetectionRequest").msgclass
        TextBlockDetectionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.TextBlockDetectionRequest").msgclass
        CustomIconDetectionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.CustomIconDetectionRequest").msgclass
        UiDetectionResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.UiDetectionResponse").msgclass
        BoundingBox = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.chromeos.uidetection.v1.BoundingBox").msgclass
      end
    end
  end
end
