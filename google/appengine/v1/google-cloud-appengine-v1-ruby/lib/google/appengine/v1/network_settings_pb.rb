# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/appengine/v1/network_settings.proto

require 'google/api/annotations_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/appengine/v1/network_settings.proto", :syntax => :proto3) do
    add_message "google.appengine.v1.NetworkSettings" do
      optional :ingress_traffic_allowed, :enum, 1, "google.appengine.v1.NetworkSettings.IngressTrafficAllowed"
    end
    add_enum "google.appengine.v1.NetworkSettings.IngressTrafficAllowed" do
      value :INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED, 0
      value :INGRESS_TRAFFIC_ALLOWED_ALL, 1
      value :INGRESS_TRAFFIC_ALLOWED_INTERNAL_ONLY, 2
      value :INGRESS_TRAFFIC_ALLOWED_INTERNAL_AND_LB, 3
    end
  end
end

module Google
  module Cloud
    module AppEngine
      module V1
        NetworkSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.NetworkSettings").msgclass
        NetworkSettings::IngressTrafficAllowed = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.NetworkSettings.IngressTrafficAllowed").enummodule
      end
    end
  end
end
