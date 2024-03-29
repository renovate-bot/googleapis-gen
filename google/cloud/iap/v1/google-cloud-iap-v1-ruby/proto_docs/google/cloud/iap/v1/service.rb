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
    module Iap
      module V1
        # The request sent to GetIapSettings.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The resource name for which to retrieve the settings.
        #     Authorization: Requires the `getSettings` permission for the associated
        #     resource.
        class GetIapSettingsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to UpdateIapSettings.
        # @!attribute [rw] iap_settings
        #   @return [::Google::Cloud::Iap::V1::IapSettings]
        #     Required. The new values for the IAP settings to be updated.
        #     Authorization: Requires the `updateSettings` permission for the associated
        #     resource.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     The field mask specifying which IAP settings should be updated.
        #     If omitted, the all of the settings are updated. See
        #     https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        class UpdateIapSettingsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The IAP configurable settings.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The resource name of the IAP protected resource.
        # @!attribute [rw] access_settings
        #   @return [::Google::Cloud::Iap::V1::AccessSettings]
        #     Top level wrapper for all access related setting in IAP
        # @!attribute [rw] application_settings
        #   @return [::Google::Cloud::Iap::V1::ApplicationSettings]
        #     Top level wrapper for all application related settings in IAP
        class IapSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Access related settings for IAP protected apps.
        # @!attribute [rw] gcip_settings
        #   @return [::Google::Cloud::Iap::V1::GcipSettings]
        #     GCIP claims and endpoint configurations for 3p identity providers.
        # @!attribute [rw] cors_settings
        #   @return [::Google::Cloud::Iap::V1::CorsSettings]
        #     Configuration to allow cross-origin requests via IAP.
        # @!attribute [rw] oauth_settings
        #   @return [::Google::Cloud::Iap::V1::OAuthSettings]
        #     Settings to configure IAP's OAuth behavior.
        class AccessSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Allows customers to configure tenant_id for GCIP instance per-app.
        # @!attribute [rw] tenant_ids
        #   @return [::Array<::String>]
        #     GCIP tenant ids that are linked to the IAP resource.
        #     tenant_ids could be a string beginning with a number character to indicate
        #     authenticating with GCIP tenant flow, or in the format of _<ProjectNumber>
        #     to indicate authenticating with GCIP agent flow.
        #     If agent flow is used, tenant_ids should only contain one single element,
        #     while for tenant flow, tenant_ids can contain multiple elements.
        # @!attribute [rw] login_page_uri
        #   @return [::Google::Protobuf::StringValue]
        #     Login page URI associated with the GCIP tenants.
        #     Typically, all resources within the same project share the same login page,
        #     though it could be overridden at the sub resource level.
        class GcipSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Allows customers to configure HTTP request paths that'll allow HTTP OPTIONS
        # call to bypass authentication and authorization.
        # @!attribute [rw] allow_http_options
        #   @return [::Google::Protobuf::BoolValue]
        #     Configuration to allow HTTP OPTIONS calls to skip authorization. If
        #     undefined, IAP will not apply any special logic to OPTIONS requests.
        class CorsSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Configuration for OAuth login&consent flow behavior as well as for OAuth
        # Credentials.
        # @!attribute [rw] login_hint
        #   @return [::Google::Protobuf::StringValue]
        #     Domain hint to send as hd=? parameter in OAuth request flow. Enables
        #     redirect to primary IDP by skipping Google's login screen.
        #     https://developers.google.com/identity/protocols/OpenIDConnect#hd-param
        #     Note: IAP does not verify that the id token's hd claim matches this value
        #     since access behavior is managed by IAM policies.
        class OAuthSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Wrapper over application specific settings for IAP.
        # @!attribute [rw] csm_settings
        #   @return [::Google::Cloud::Iap::V1::CsmSettings]
        #     Settings to configure IAP's behavior for a CSM mesh.
        # @!attribute [rw] access_denied_page_settings
        #   @return [::Google::Cloud::Iap::V1::AccessDeniedPageSettings]
        #     Customization for Access Denied page.
        # @!attribute [rw] cookie_domain
        #   @return [::Google::Protobuf::StringValue]
        #     The Domain value to set for cookies generated by IAP. This value is not
        #     validated by the API, but will be ignored at runtime if invalid.
        class ApplicationSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Configuration for RCTokens generated for CSM workloads protected by IAP.
        # RCTokens are IAP generated JWTs that can be verified at the application. The
        # RCToken is primarily used for ISTIO deployments, and can be scoped to a
        # single mesh by configuring the audience field accordingly
        # @!attribute [rw] rctoken_aud
        #   @return [::Google::Protobuf::StringValue]
        #     Audience claim set in the generated RCToken. This value is not validated by
        #     IAP.
        class CsmSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Custom content configuration for access denied page.
        # IAP allows customers to define a custom URI to use as the error page when
        # access is denied to users. If IAP prevents access to this page, the default
        # IAP error page will be displayed instead.
        # @!attribute [rw] access_denied_page_uri
        #   @return [::Google::Protobuf::StringValue]
        #     The URI to be redirected to when access is denied.
        # @!attribute [rw] generate_troubleshooting_uri
        #   @return [::Google::Protobuf::BoolValue]
        #     Whether to generate a troubleshooting URL on access denied events to this
        #     application.
        class AccessDeniedPageSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to ListBrands.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. GCP Project number/id.
        #     In the following format: projects/\\{project_number/id}.
        class ListBrandsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response message for ListBrands.
        # @!attribute [rw] brands
        #   @return [::Array<::Google::Cloud::Iap::V1::Brand>]
        #     Brands existing in the project.
        class ListBrandsResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to CreateBrand.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. GCP Project number/id under which the brand is to be created.
        #     In the following format: projects/\\{project_number/id}.
        # @!attribute [rw] brand
        #   @return [::Google::Cloud::Iap::V1::Brand]
        #     Required. The brand to be created.
        class CreateBrandRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to GetBrand.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the brand to be fetched.
        #     In the following format: projects/\\{project_number/id}/brands/\\{brand}.
        class GetBrandRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to ListIdentityAwareProxyClients.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. Full brand path.
        #     In the following format: projects/\\{project_number/id}/brands/\\{brand}.
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     The maximum number of clients to return. The service may return fewer than
        #     this value.
        #     If unspecified, at most 100 clients will be returned.
        #     The maximum value is 1000; values above 1000 will be coerced to 1000.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     A page token, received from a previous `ListIdentityAwareProxyClients`
        #     call. Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to
        #     `ListIdentityAwareProxyClients` must match the call that provided the page
        #     token.
        class ListIdentityAwareProxyClientsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response message for ListIdentityAwareProxyClients.
        # @!attribute [rw] identity_aware_proxy_clients
        #   @return [::Array<::Google::Cloud::Iap::V1::IdentityAwareProxyClient>]
        #     Clients existing in the brand.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     A token, which can be send as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListIdentityAwareProxyClientsResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to CreateIdentityAwareProxyClient.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. Path to create the client in.
        #     In the following format:
        #     projects/\\{project_number/id}/brands/\\{brand}.
        #     The project must belong to a G Suite account.
        # @!attribute [rw] identity_aware_proxy_client
        #   @return [::Google::Cloud::Iap::V1::IdentityAwareProxyClient]
        #     Required. Identity Aware Proxy Client to be created.
        class CreateIdentityAwareProxyClientRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to GetIdentityAwareProxyClient.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the Identity Aware Proxy client to be fetched.
        #     In the following format:
        #     projects/\\{project_number/id}/brands/\\{brand}/identityAwareProxyClients/\\{client_id}.
        class GetIdentityAwareProxyClientRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to ResetIdentityAwareProxyClientSecret.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the Identity Aware Proxy client to that will have its
        #     secret reset. In the following format:
        #     projects/\\{project_number/id}/brands/\\{brand}/identityAwareProxyClients/\\{client_id}.
        class ResetIdentityAwareProxyClientSecretRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The request sent to DeleteIdentityAwareProxyClient.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the Identity Aware Proxy client to be deleted.
        #     In the following format:
        #     projects/\\{project_number/id}/brands/\\{brand}/identityAwareProxyClients/\\{client_id}.
        class DeleteIdentityAwareProxyClientRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # OAuth brand data.
        # NOTE: Only contains a portion of the data that describes a brand.
        # @!attribute [r] name
        #   @return [::String]
        #     Output only. Identifier of the brand.
        #     NOTE: GCP project number achieves the same brand identification purpose as
        #     only one brand per project can be created.
        # @!attribute [rw] support_email
        #   @return [::String]
        #     Support email displayed on the OAuth consent screen.
        # @!attribute [rw] application_title
        #   @return [::String]
        #     Application name displayed on OAuth consent screen.
        # @!attribute [r] org_internal_only
        #   @return [::Boolean]
        #     Output only. Whether the brand is only intended for usage inside the
        #     G Suite organization only.
        class Brand
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Contains the data that describes an Identity Aware Proxy owned client.
        # @!attribute [r] name
        #   @return [::String]
        #     Output only. Unique identifier of the OAuth client.
        # @!attribute [r] secret
        #   @return [::String]
        #     Output only. Client secret of the OAuth client.
        # @!attribute [rw] display_name
        #   @return [::String]
        #     Human-friendly name given to the OAuth client.
        class IdentityAwareProxyClient
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
