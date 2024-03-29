# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/appengine/v1/appengine.proto

require 'google/appengine/v1/application_pb'
require 'google/appengine/v1/certificate_pb'
require 'google/appengine/v1/domain_pb'
require 'google/appengine/v1/domain_mapping_pb'
require 'google/appengine/v1/firewall_pb'
require 'google/appengine/v1/instance_pb'
require 'google/appengine/v1/version_pb'
require 'google/appengine/v1/service_pb'
require 'google/api/annotations_pb'
require 'google/longrunning/operations_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/api/client_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/appengine/v1/appengine.proto", :syntax => :proto3) do
    add_message "google.appengine.v1.GetApplicationRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.CreateApplicationRequest" do
      optional :application, :message, 2, "google.appengine.v1.Application"
    end
    add_message "google.appengine.v1.UpdateApplicationRequest" do
      optional :name, :string, 1
      optional :application, :message, 2, "google.appengine.v1.Application"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
    end
    add_message "google.appengine.v1.RepairApplicationRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.ListServicesRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.appengine.v1.ListServicesResponse" do
      repeated :services, :message, 1, "google.appengine.v1.Service"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.GetServiceRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.UpdateServiceRequest" do
      optional :name, :string, 1
      optional :service, :message, 2, "google.appengine.v1.Service"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
      optional :migrate_traffic, :bool, 4
    end
    add_message "google.appengine.v1.DeleteServiceRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.ListVersionsRequest" do
      optional :parent, :string, 1
      optional :view, :enum, 2, "google.appengine.v1.VersionView"
      optional :page_size, :int32, 3
      optional :page_token, :string, 4
    end
    add_message "google.appengine.v1.ListVersionsResponse" do
      repeated :versions, :message, 1, "google.appengine.v1.Version"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.GetVersionRequest" do
      optional :name, :string, 1
      optional :view, :enum, 2, "google.appengine.v1.VersionView"
    end
    add_message "google.appengine.v1.CreateVersionRequest" do
      optional :parent, :string, 1
      optional :version, :message, 2, "google.appengine.v1.Version"
    end
    add_message "google.appengine.v1.UpdateVersionRequest" do
      optional :name, :string, 1
      optional :version, :message, 2, "google.appengine.v1.Version"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
    end
    add_message "google.appengine.v1.DeleteVersionRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.ListInstancesRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.appengine.v1.ListInstancesResponse" do
      repeated :instances, :message, 1, "google.appengine.v1.Instance"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.GetInstanceRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.DeleteInstanceRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.DebugInstanceRequest" do
      optional :name, :string, 1
      optional :ssh_key, :string, 2
    end
    add_message "google.appengine.v1.ListIngressRulesRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :matching_address, :string, 4
    end
    add_message "google.appengine.v1.ListIngressRulesResponse" do
      repeated :ingress_rules, :message, 1, "google.appengine.v1.FirewallRule"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.BatchUpdateIngressRulesRequest" do
      optional :name, :string, 1
      repeated :ingress_rules, :message, 2, "google.appengine.v1.FirewallRule"
    end
    add_message "google.appengine.v1.BatchUpdateIngressRulesResponse" do
      repeated :ingress_rules, :message, 1, "google.appengine.v1.FirewallRule"
    end
    add_message "google.appengine.v1.CreateIngressRuleRequest" do
      optional :parent, :string, 1
      optional :rule, :message, 2, "google.appengine.v1.FirewallRule"
    end
    add_message "google.appengine.v1.GetIngressRuleRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.UpdateIngressRuleRequest" do
      optional :name, :string, 1
      optional :rule, :message, 2, "google.appengine.v1.FirewallRule"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
    end
    add_message "google.appengine.v1.DeleteIngressRuleRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.ListAuthorizedDomainsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.appengine.v1.ListAuthorizedDomainsResponse" do
      repeated :domains, :message, 1, "google.appengine.v1.AuthorizedDomain"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.ListAuthorizedCertificatesRequest" do
      optional :parent, :string, 1
      optional :view, :enum, 4, "google.appengine.v1.AuthorizedCertificateView"
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.appengine.v1.ListAuthorizedCertificatesResponse" do
      repeated :certificates, :message, 1, "google.appengine.v1.AuthorizedCertificate"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.GetAuthorizedCertificateRequest" do
      optional :name, :string, 1
      optional :view, :enum, 2, "google.appengine.v1.AuthorizedCertificateView"
    end
    add_message "google.appengine.v1.CreateAuthorizedCertificateRequest" do
      optional :parent, :string, 1
      optional :certificate, :message, 2, "google.appengine.v1.AuthorizedCertificate"
    end
    add_message "google.appengine.v1.UpdateAuthorizedCertificateRequest" do
      optional :name, :string, 1
      optional :certificate, :message, 2, "google.appengine.v1.AuthorizedCertificate"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
    end
    add_message "google.appengine.v1.DeleteAuthorizedCertificateRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.ListDomainMappingsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.appengine.v1.ListDomainMappingsResponse" do
      repeated :domain_mappings, :message, 1, "google.appengine.v1.DomainMapping"
      optional :next_page_token, :string, 2
    end
    add_message "google.appengine.v1.GetDomainMappingRequest" do
      optional :name, :string, 1
    end
    add_message "google.appengine.v1.CreateDomainMappingRequest" do
      optional :parent, :string, 1
      optional :domain_mapping, :message, 2, "google.appengine.v1.DomainMapping"
      optional :override_strategy, :enum, 4, "google.appengine.v1.DomainOverrideStrategy"
    end
    add_message "google.appengine.v1.UpdateDomainMappingRequest" do
      optional :name, :string, 1
      optional :domain_mapping, :message, 2, "google.appengine.v1.DomainMapping"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
    end
    add_message "google.appengine.v1.DeleteDomainMappingRequest" do
      optional :name, :string, 1
    end
    add_enum "google.appengine.v1.VersionView" do
      value :BASIC, 0
      value :FULL, 1
    end
    add_enum "google.appengine.v1.AuthorizedCertificateView" do
      value :BASIC_CERTIFICATE, 0
      value :FULL_CERTIFICATE, 1
    end
    add_enum "google.appengine.v1.DomainOverrideStrategy" do
      value :UNSPECIFIED_DOMAIN_OVERRIDE_STRATEGY, 0
      value :STRICT, 1
      value :OVERRIDE, 2
    end
  end
end

module Google
  module Cloud
    module AppEngine
      module V1
        GetApplicationRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetApplicationRequest").msgclass
        CreateApplicationRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.CreateApplicationRequest").msgclass
        UpdateApplicationRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.UpdateApplicationRequest").msgclass
        RepairApplicationRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.RepairApplicationRequest").msgclass
        ListServicesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListServicesRequest").msgclass
        ListServicesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListServicesResponse").msgclass
        GetServiceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetServiceRequest").msgclass
        UpdateServiceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.UpdateServiceRequest").msgclass
        DeleteServiceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DeleteServiceRequest").msgclass
        ListVersionsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListVersionsRequest").msgclass
        ListVersionsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListVersionsResponse").msgclass
        GetVersionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetVersionRequest").msgclass
        CreateVersionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.CreateVersionRequest").msgclass
        UpdateVersionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.UpdateVersionRequest").msgclass
        DeleteVersionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DeleteVersionRequest").msgclass
        ListInstancesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListInstancesRequest").msgclass
        ListInstancesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListInstancesResponse").msgclass
        GetInstanceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetInstanceRequest").msgclass
        DeleteInstanceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DeleteInstanceRequest").msgclass
        DebugInstanceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DebugInstanceRequest").msgclass
        ListIngressRulesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListIngressRulesRequest").msgclass
        ListIngressRulesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListIngressRulesResponse").msgclass
        BatchUpdateIngressRulesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.BatchUpdateIngressRulesRequest").msgclass
        BatchUpdateIngressRulesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.BatchUpdateIngressRulesResponse").msgclass
        CreateIngressRuleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.CreateIngressRuleRequest").msgclass
        GetIngressRuleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetIngressRuleRequest").msgclass
        UpdateIngressRuleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.UpdateIngressRuleRequest").msgclass
        DeleteIngressRuleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DeleteIngressRuleRequest").msgclass
        ListAuthorizedDomainsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListAuthorizedDomainsRequest").msgclass
        ListAuthorizedDomainsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListAuthorizedDomainsResponse").msgclass
        ListAuthorizedCertificatesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListAuthorizedCertificatesRequest").msgclass
        ListAuthorizedCertificatesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListAuthorizedCertificatesResponse").msgclass
        GetAuthorizedCertificateRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetAuthorizedCertificateRequest").msgclass
        CreateAuthorizedCertificateRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.CreateAuthorizedCertificateRequest").msgclass
        UpdateAuthorizedCertificateRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.UpdateAuthorizedCertificateRequest").msgclass
        DeleteAuthorizedCertificateRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DeleteAuthorizedCertificateRequest").msgclass
        ListDomainMappingsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListDomainMappingsRequest").msgclass
        ListDomainMappingsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.ListDomainMappingsResponse").msgclass
        GetDomainMappingRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.GetDomainMappingRequest").msgclass
        CreateDomainMappingRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.CreateDomainMappingRequest").msgclass
        UpdateDomainMappingRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.UpdateDomainMappingRequest").msgclass
        DeleteDomainMappingRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DeleteDomainMappingRequest").msgclass
        VersionView = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.VersionView").enummodule
        AuthorizedCertificateView = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.AuthorizedCertificateView").enummodule
        DomainOverrideStrategy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.appengine.v1.DomainOverrideStrategy").enummodule
      end
    end
  end
end
