# -*- coding: utf-8 -*-

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

from google.appengine_v1.services.applications.async_client import ApplicationsAsyncClient
from google.appengine_v1.services.applications.client import ApplicationsClient
from google.appengine_v1.services.authorized_certificates.async_client import AuthorizedCertificatesAsyncClient
from google.appengine_v1.services.authorized_certificates.client import AuthorizedCertificatesClient
from google.appengine_v1.services.authorized_domains.async_client import AuthorizedDomainsAsyncClient
from google.appengine_v1.services.authorized_domains.client import AuthorizedDomainsClient
from google.appengine_v1.services.domain_mappings.async_client import DomainMappingsAsyncClient
from google.appengine_v1.services.domain_mappings.client import DomainMappingsClient
from google.appengine_v1.services.firewall.async_client import FirewallAsyncClient
from google.appengine_v1.services.firewall.client import FirewallClient
from google.appengine_v1.services.instances.async_client import InstancesAsyncClient
from google.appengine_v1.services.instances.client import InstancesClient
from google.appengine_v1.services.services.async_client import ServicesAsyncClient
from google.appengine_v1.services.services.client import ServicesClient
from google.appengine_v1.services.versions.async_client import VersionsAsyncClient
from google.appengine_v1.services.versions.client import VersionsClient
from google.appengine_v1.types.app_yaml import ApiConfigHandler
from google.appengine_v1.types.app_yaml import ApiEndpointHandler
from google.appengine_v1.types.app_yaml import AuthFailAction
from google.appengine_v1.types.app_yaml import ErrorHandler
from google.appengine_v1.types.app_yaml import HealthCheck
from google.appengine_v1.types.app_yaml import Library
from google.appengine_v1.types.app_yaml import LivenessCheck
from google.appengine_v1.types.app_yaml import LoginRequirement
from google.appengine_v1.types.app_yaml import ReadinessCheck
from google.appengine_v1.types.app_yaml import ScriptHandler
from google.appengine_v1.types.app_yaml import SecurityLevel
from google.appengine_v1.types.app_yaml import StaticFilesHandler
from google.appengine_v1.types.app_yaml import UrlMap
from google.appengine_v1.types.appengine import AuthorizedCertificateView
from google.appengine_v1.types.appengine import BatchUpdateIngressRulesRequest
from google.appengine_v1.types.appengine import BatchUpdateIngressRulesResponse
from google.appengine_v1.types.appengine import CreateApplicationRequest
from google.appengine_v1.types.appengine import CreateAuthorizedCertificateRequest
from google.appengine_v1.types.appengine import CreateDomainMappingRequest
from google.appengine_v1.types.appengine import CreateIngressRuleRequest
from google.appengine_v1.types.appengine import CreateVersionRequest
from google.appengine_v1.types.appengine import DebugInstanceRequest
from google.appengine_v1.types.appengine import DeleteAuthorizedCertificateRequest
from google.appengine_v1.types.appengine import DeleteDomainMappingRequest
from google.appengine_v1.types.appengine import DeleteIngressRuleRequest
from google.appengine_v1.types.appengine import DeleteInstanceRequest
from google.appengine_v1.types.appengine import DeleteServiceRequest
from google.appengine_v1.types.appengine import DeleteVersionRequest
from google.appengine_v1.types.appengine import DomainOverrideStrategy
from google.appengine_v1.types.appengine import GetApplicationRequest
from google.appengine_v1.types.appengine import GetAuthorizedCertificateRequest
from google.appengine_v1.types.appengine import GetDomainMappingRequest
from google.appengine_v1.types.appengine import GetIngressRuleRequest
from google.appengine_v1.types.appengine import GetInstanceRequest
from google.appengine_v1.types.appengine import GetServiceRequest
from google.appengine_v1.types.appengine import GetVersionRequest
from google.appengine_v1.types.appengine import ListAuthorizedCertificatesRequest
from google.appengine_v1.types.appengine import ListAuthorizedCertificatesResponse
from google.appengine_v1.types.appengine import ListAuthorizedDomainsRequest
from google.appengine_v1.types.appengine import ListAuthorizedDomainsResponse
from google.appengine_v1.types.appengine import ListDomainMappingsRequest
from google.appengine_v1.types.appengine import ListDomainMappingsResponse
from google.appengine_v1.types.appengine import ListIngressRulesRequest
from google.appengine_v1.types.appengine import ListIngressRulesResponse
from google.appengine_v1.types.appengine import ListInstancesRequest
from google.appengine_v1.types.appengine import ListInstancesResponse
from google.appengine_v1.types.appengine import ListServicesRequest
from google.appengine_v1.types.appengine import ListServicesResponse
from google.appengine_v1.types.appengine import ListVersionsRequest
from google.appengine_v1.types.appengine import ListVersionsResponse
from google.appengine_v1.types.appengine import RepairApplicationRequest
from google.appengine_v1.types.appengine import UpdateApplicationRequest
from google.appengine_v1.types.appengine import UpdateAuthorizedCertificateRequest
from google.appengine_v1.types.appengine import UpdateDomainMappingRequest
from google.appengine_v1.types.appengine import UpdateIngressRuleRequest
from google.appengine_v1.types.appengine import UpdateServiceRequest
from google.appengine_v1.types.appengine import UpdateVersionRequest
from google.appengine_v1.types.appengine import VersionView
from google.appengine_v1.types.application import Application
from google.appengine_v1.types.application import UrlDispatchRule
from google.appengine_v1.types.audit_data import AuditData
from google.appengine_v1.types.audit_data import CreateVersionMethod
from google.appengine_v1.types.audit_data import UpdateServiceMethod
from google.appengine_v1.types.certificate import AuthorizedCertificate
from google.appengine_v1.types.certificate import CertificateRawData
from google.appengine_v1.types.certificate import ManagedCertificate
from google.appengine_v1.types.certificate import ManagementStatus
from google.appengine_v1.types.deploy import CloudBuildOptions
from google.appengine_v1.types.deploy import ContainerInfo
from google.appengine_v1.types.deploy import Deployment
from google.appengine_v1.types.deploy import FileInfo
from google.appengine_v1.types.deploy import ZipInfo
from google.appengine_v1.types.domain import AuthorizedDomain
from google.appengine_v1.types.domain_mapping import DomainMapping
from google.appengine_v1.types.domain_mapping import ResourceRecord
from google.appengine_v1.types.domain_mapping import SslSettings
from google.appengine_v1.types.firewall import FirewallRule
from google.appengine_v1.types.instance import Instance
from google.appengine_v1.types.location import LocationMetadata
from google.appengine_v1.types.network_settings import NetworkSettings
from google.appengine_v1.types.operation import CreateVersionMetadataV1
from google.appengine_v1.types.operation import OperationMetadataV1
from google.appengine_v1.types.service import Service
from google.appengine_v1.types.service import TrafficSplit
from google.appengine_v1.types.version import AutomaticScaling
from google.appengine_v1.types.version import BasicScaling
from google.appengine_v1.types.version import CpuUtilization
from google.appengine_v1.types.version import DiskUtilization
from google.appengine_v1.types.version import EndpointsApiService
from google.appengine_v1.types.version import Entrypoint
from google.appengine_v1.types.version import InboundServiceType
from google.appengine_v1.types.version import ManualScaling
from google.appengine_v1.types.version import Network
from google.appengine_v1.types.version import NetworkUtilization
from google.appengine_v1.types.version import RequestUtilization
from google.appengine_v1.types.version import Resources
from google.appengine_v1.types.version import ServingStatus
from google.appengine_v1.types.version import StandardSchedulerSettings
from google.appengine_v1.types.version import Version
from google.appengine_v1.types.version import Volume
from google.appengine_v1.types.version import VpcAccessConnector

__all__ = (
    'ApiConfigHandler',
    'ApiEndpointHandler',
    'Application',
    'ApplicationsAsyncClient',
    'ApplicationsClient',
    'AuditData',
    'AuthFailAction',
    'AuthorizedCertificate',
    'AuthorizedCertificateView',
    'AuthorizedCertificatesAsyncClient',
    'AuthorizedCertificatesClient',
    'AuthorizedDomain',
    'AuthorizedDomainsAsyncClient',
    'AuthorizedDomainsClient',
    'AutomaticScaling',
    'BasicScaling',
    'BatchUpdateIngressRulesRequest',
    'BatchUpdateIngressRulesResponse',
    'CertificateRawData',
    'CloudBuildOptions',
    'ContainerInfo',
    'CpuUtilization',
    'CreateApplicationRequest',
    'CreateAuthorizedCertificateRequest',
    'CreateDomainMappingRequest',
    'CreateIngressRuleRequest',
    'CreateVersionMetadataV1',
    'CreateVersionMethod',
    'CreateVersionRequest',
    'DebugInstanceRequest',
    'DeleteAuthorizedCertificateRequest',
    'DeleteDomainMappingRequest',
    'DeleteIngressRuleRequest',
    'DeleteInstanceRequest',
    'DeleteServiceRequest',
    'DeleteVersionRequest',
    'Deployment',
    'DiskUtilization',
    'DomainMapping',
    'DomainMappingsAsyncClient',
    'DomainMappingsClient',
    'DomainOverrideStrategy',
    'EndpointsApiService',
    'Entrypoint',
    'ErrorHandler',
    'FileInfo',
    'FirewallAsyncClient',
    'FirewallClient',
    'FirewallRule',
    'GetApplicationRequest',
    'GetAuthorizedCertificateRequest',
    'GetDomainMappingRequest',
    'GetIngressRuleRequest',
    'GetInstanceRequest',
    'GetServiceRequest',
    'GetVersionRequest',
    'HealthCheck',
    'InboundServiceType',
    'Instance',
    'InstancesAsyncClient',
    'InstancesClient',
    'Library',
    'ListAuthorizedCertificatesRequest',
    'ListAuthorizedCertificatesResponse',
    'ListAuthorizedDomainsRequest',
    'ListAuthorizedDomainsResponse',
    'ListDomainMappingsRequest',
    'ListDomainMappingsResponse',
    'ListIngressRulesRequest',
    'ListIngressRulesResponse',
    'ListInstancesRequest',
    'ListInstancesResponse',
    'ListServicesRequest',
    'ListServicesResponse',
    'ListVersionsRequest',
    'ListVersionsResponse',
    'LivenessCheck',
    'LocationMetadata',
    'LoginRequirement',
    'ManagedCertificate',
    'ManagementStatus',
    'ManualScaling',
    'Network',
    'NetworkSettings',
    'NetworkUtilization',
    'OperationMetadataV1',
    'ReadinessCheck',
    'RepairApplicationRequest',
    'RequestUtilization',
    'ResourceRecord',
    'Resources',
    'ScriptHandler',
    'SecurityLevel',
    'Service',
    'ServicesAsyncClient',
    'ServicesClient',
    'ServingStatus',
    'SslSettings',
    'StandardSchedulerSettings',
    'StaticFilesHandler',
    'TrafficSplit',
    'UpdateApplicationRequest',
    'UpdateAuthorizedCertificateRequest',
    'UpdateDomainMappingRequest',
    'UpdateIngressRuleRequest',
    'UpdateServiceMethod',
    'UpdateServiceRequest',
    'UpdateVersionRequest',
    'UrlDispatchRule',
    'UrlMap',
    'Version',
    'VersionView',
    'VersionsAsyncClient',
    'VersionsClient',
    'Volume',
    'VpcAccessConnector',
    'ZipInfo',
)
