# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/maps/roads/v1op/roads.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/protobuf/wrappers_pb'
require 'google/type/latlng_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/maps/roads/v1op/roads.proto", :syntax => :proto3) do
    add_message "google.maps.roads.v1op.SnapToRoadsRequest" do
      optional :path, :string, 1
      optional :interpolate, :bool, 2
      optional :asset_id, :string, 3
      optional :travel_mode, :enum, 4, "google.maps.roads.v1op.TravelMode"
    end
    add_message "google.maps.roads.v1op.SnappedPoint" do
      optional :location, :message, 1, "google.type.LatLng"
      optional :original_index, :message, 2, "google.protobuf.UInt32Value"
      optional :place_id, :string, 3
    end
    add_message "google.maps.roads.v1op.SnapToRoadsResponse" do
      repeated :snapped_points, :message, 1, "google.maps.roads.v1op.SnappedPoint"
      optional :warning_message, :string, 2
    end
    add_message "google.maps.roads.v1op.ListNearestRoadsRequest" do
      optional :points, :string, 1
      optional :travel_mode, :enum, 2, "google.maps.roads.v1op.TravelMode"
    end
    add_message "google.maps.roads.v1op.ListNearestRoadsResponse" do
      repeated :snapped_points, :message, 1, "google.maps.roads.v1op.SnappedPoint"
    end
    add_enum "google.maps.roads.v1op.TravelMode" do
      value :TRAVEL_MODE_UNSPECIFIED, 0
      value :DRIVING, 1
      value :CYCLING, 2
      value :WALKING, 3
    end
  end
end

module Google
  module Maps
    module Roads
      module V1op
        SnapToRoadsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.maps.roads.v1op.SnapToRoadsRequest").msgclass
        SnappedPoint = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.maps.roads.v1op.SnappedPoint").msgclass
        SnapToRoadsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.maps.roads.v1op.SnapToRoadsResponse").msgclass
        ListNearestRoadsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.maps.roads.v1op.ListNearestRoadsRequest").msgclass
        ListNearestRoadsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.maps.roads.v1op.ListNearestRoadsResponse").msgclass
        TravelMode = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.maps.roads.v1op.TravelMode").enummodule
      end
    end
  end
end
