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
  module Analytics
    module Admin
      module V1alpha
        # Request message for GetAccount RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the account to lookup.
        #     Format: accounts/{account}
        #     Example: "accounts/100"
        class GetAccountRequest; end

        # Request message for ListAccounts RPC.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return. The service may return
        #     fewer than this value, even if there are additional pages.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListAccounts` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListAccounts` must
        #     match the call that provided the page token.
        # @!attribute [rw] show_deleted
        #   @return [true, false]
        #     Whether to include soft-deleted (ie: "trashed") Accounts in the
        #     results. Accounts can be inspected to determine whether they are deleted or
        #     not.
        class ListAccountsRequest; end

        # Request message for ListAccounts RPC.
        # @!attribute [rw] accounts
        #   @return [Array<Google::Analytics::Admin::V1alpha::Account>]
        #     Results that were accessible to the caller.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListAccountsResponse; end

        # Request message for DeleteAccount RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Account to soft-delete.
        #     Format: accounts/{account}
        #     Example: "accounts/100"
        class DeleteAccountRequest; end

        # Request message for UpdateAccount RPC.
        # @!attribute [rw] account
        #   @return [Google::Analytics::Admin::V1alpha::Account]
        #     Required. The account to update.
        #     The account's `name` field is used to identify the account.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateAccountRequest; end

        # Request message for ProvisionAccountTicket RPC.
        # @!attribute [rw] account
        #   @return [Google::Analytics::Admin::V1alpha::Account]
        #     The account to create.
        # @!attribute [rw] redirect_uri
        #   @return [String]
        #     Redirect URI where the user will be sent after accepting Terms of Service.
        #     Must be configured in Developers Console as a Redirect URI
        class ProvisionAccountTicketRequest; end

        # Response message for ProvisionAccountTicket RPC.
        # @!attribute [rw] account_ticket_id
        #   @return [String]
        #     The param to be passed in the ToS link.
        class ProvisionAccountTicketResponse; end

        # Request message for GetProperty RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the property to lookup.
        #     Format: properties/{property_id}
        #     Example: "properties/1000"
        class GetPropertyRequest; end

        # Request message for ListProperties RPC.
        # @!attribute [rw] filter
        #   @return [String]
        #     Required. An expression for filtering the results of the request.
        #     Fields eligible for filtering are:
        #     `parent:`(The resource name of the parent account) or
        #     `firebase_project:`(The id or number of the linked firebase project).
        #     Some examples of filters:
        #
        #     ```
        #     | Filter                      | Description                               |
        #     |-----------------------------|-------------------------------------------|
        #     | parent:accounts/123         | The account with account id: 123.         |
        #     | firebase_project:project-id | The firebase project with id: project-id. |
        #     | firebase_project:123        | The firebase project with number: 123.    |
        #     ```
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return. The service may return
        #     fewer than this value, even if there are additional pages.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListProperties` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListProperties` must
        #     match the call that provided the page token.
        # @!attribute [rw] show_deleted
        #   @return [true, false]
        #     Whether to include soft-deleted (ie: "trashed") Properties in the
        #     results. Properties can be inspected to determine whether they are deleted
        #     or not.
        class ListPropertiesRequest; end

        # Response message for ListProperties RPC.
        # @!attribute [rw] properties
        #   @return [Array<Google::Analytics::Admin::V1alpha::Property>]
        #     Results that matched the filter criteria and were accessible to the caller.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListPropertiesResponse; end

        # Request message for UpdateProperty RPC.
        # @!attribute [rw] property
        #   @return [Google::Analytics::Admin::V1alpha::Property]
        #     Required. The property to update.
        #     The property's `name` field is used to identify the property to be
        #     updated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdatePropertyRequest; end

        # Request message for CreateProperty RPC.
        # @!attribute [rw] property
        #   @return [Google::Analytics::Admin::V1alpha::Property]
        #     Required. The property to create.
        #     Note: the supplied property must specify its parent.
        class CreatePropertyRequest; end

        # Request message for DeleteProperty RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Property to soft-delete.
        #     Format: properties/{property_id}
        #     Example: "properties/1000"
        class DeletePropertyRequest; end

        # Request message for GetUserLink RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Example format: accounts/1234/userLinks/5678
        class GetUserLinkRequest; end

        # Request message for BatchGetUserLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The account or property that all user links in the request are
        #     for. The parent of all provided values for the 'names' field must match
        #     this field.
        #     Example format: accounts/1234
        # @!attribute [rw] names
        #   @return [Array<String>]
        #     Required. The names of the user links to retrieve.
        #     A maximum of 1000 user links can be retrieved in a batch.
        #     Format: accounts/{accountId}/userLinks/{userLinkId}
        class BatchGetUserLinksRequest; end

        # Response message for BatchGetUserLinks RPC.
        # @!attribute [rw] user_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::UserLink>]
        #     The requested user links.
        class BatchGetUserLinksResponse; end

        # Request message for ListUserLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Example format: accounts/1234
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of user links to return.
        #     The service may return fewer than this value.
        #     If unspecified, at most 200 user links will be returned.
        #     The maximum value is 500; values above 500 will be coerced to 500.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListUserLinks` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListUserLinks` must
        #     match the call that provided the page token.
        class ListUserLinksRequest; end

        # Response message for ListUserLinks RPC.
        # @!attribute [rw] user_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::UserLink>]
        #     List of UserLinks. These will be ordered stably, but in an arbitrary order.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListUserLinksResponse; end

        # Request message for AuditUserLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Example format: accounts/1234
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of user links to return.
        #     The service may return fewer than this value.
        #     If unspecified, at most 1000 user links will be returned.
        #     The maximum value is 5000; values above 5000 will be coerced to 5000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `AuditUserLinks` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `AuditUserLinks` must
        #     match the call that provided the page token.
        class AuditUserLinksRequest; end

        # Response message for AuditUserLinks RPC.
        # @!attribute [rw] user_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::AuditUserLink>]
        #     List of AuditUserLinks. These will be ordered stably, but in an arbitrary
        #     order.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class AuditUserLinksResponse; end

        # Request message for CreateUserLink RPC.
        #
        # Users can have multiple email addresses associated with their Google
        # account, and one of these email addresses is the "primary" email address.
        # Any of the email addresses associated with a Google account may be used
        # for a new UserLink, but the returned UserLink will always contain the
        # "primary" email address. As a result, the input and output email address
        # for this request may differ.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Example format: accounts/1234
        # @!attribute [rw] notify_new_user
        #   @return [true, false]
        #     Optional. If set, then email the new user notifying them that they've been granted
        #     permissions to the resource.
        # @!attribute [rw] user_link
        #   @return [Google::Analytics::Admin::V1alpha::UserLink]
        #     Required. The user link to create.
        class CreateUserLinkRequest; end

        # Request message for BatchCreateUserLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The account or property that all user links in the request are for.
        #     This field is required. The parent field in the CreateUserLinkRequest
        #     messages must either be empty or match this field.
        #     Example format: accounts/1234
        # @!attribute [rw] notify_new_users
        #   @return [true, false]
        #     Optional. If set, then email the new users notifying them that they've been granted
        #     permissions to the resource. Regardless of whether this is set or not,
        #     notify_new_user field inside each individual request is ignored.
        # @!attribute [rw] requests
        #   @return [Array<Google::Analytics::Admin::V1alpha::CreateUserLinkRequest>]
        #     Required. The requests specifying the user links to create.
        #     A maximum of 1000 user links can be created in a batch.
        class BatchCreateUserLinksRequest; end

        # Response message for BatchCreateUserLinks RPC.
        # @!attribute [rw] user_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::UserLink>]
        #     The user links created.
        class BatchCreateUserLinksResponse; end

        # Request message for UpdateUserLink RPC.
        # @!attribute [rw] user_link
        #   @return [Google::Analytics::Admin::V1alpha::UserLink]
        #     Required. The user link to update.
        class UpdateUserLinkRequest; end

        # Request message for BatchUpdateUserLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The account or property that all user links in the request are
        #     for. The parent field in the UpdateUserLinkRequest messages must either be
        #     empty or match this field.
        #     Example format: accounts/1234
        # @!attribute [rw] requests
        #   @return [Array<Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest>]
        #     Required. The requests specifying the user links to update.
        #     A maximum of 1000 user links can be updated in a batch.
        class BatchUpdateUserLinksRequest; end

        # Response message for BatchUpdateUserLinks RPC.
        # @!attribute [rw] user_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::UserLink>]
        #     The user links updated.
        class BatchUpdateUserLinksResponse; end

        # Request message for DeleteUserLink RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Example format: accounts/1234/userLinks/5678
        class DeleteUserLinkRequest; end

        # Request message for BatchDeleteUserLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The account or property that all user links in the request are
        #     for. The parent of all values for user link names to delete must match this
        #     field.
        #     Example format: accounts/1234
        # @!attribute [rw] requests
        #   @return [Array<Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest>]
        #     Required. The requests specifying the user links to update.
        #     A maximum of 1000 user links can be updated in a batch.
        class BatchDeleteUserLinksRequest; end

        # Request message for GetWebDataStream RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the web data stream to lookup.
        #     Format: properties/{property_id}/webDataStreams/{stream_id}
        #     Example: "properties/123/webDataStreams/456"
        class GetWebDataStreamRequest; end

        # Request message for DeleteWebDataStream RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the web data stream to delete.
        #     Format: properties/{property_id}/webDataStreams/{stream_id}
        #     Example: "properties/123/webDataStreams/456"
        class DeleteWebDataStreamRequest; end

        # Request message for UpdateWebDataStream RPC.
        # @!attribute [rw] web_data_stream
        #   @return [Google::Analytics::Admin::V1alpha::WebDataStream]
        #     Required. The web stream to update.
        #     The `name` field is used to identify the web stream to be updated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateWebDataStreamRequest; end

        # Request message for CreateWebDataStream RPC.
        # @!attribute [rw] web_data_stream
        #   @return [Google::Analytics::Admin::V1alpha::WebDataStream]
        #     Required. The web stream to create.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource where this web data stream will be created.
        #     Format: properties/123
        class CreateWebDataStreamRequest; end

        # Request message for ListWebDataStreams RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the parent property.
        #     For example, to list results of web streams under the property with Id
        #     123: "properties/123"
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListWebDataStreams` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListWebDataStreams` must
        #     match the call that provided the page token.
        class ListWebDataStreamsRequest; end

        # Request message for ListWebDataStreams RPC.
        # @!attribute [rw] web_data_streams
        #   @return [Array<Google::Analytics::Admin::V1alpha::WebDataStream>]
        #     Results that matched the filter criteria and were accessible to the caller.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListWebDataStreamsResponse; end

        # Request message for GetIosAppDataStream RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the iOS app data stream to lookup.
        #     Format: properties/{property_id}/iosAppDataStreams/{stream_id}
        #     Example: "properties/123/iosAppDataStreams/456"
        class GetIosAppDataStreamRequest; end

        # Request message for DeleteIosAppDataStream RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the iOS app data stream to delete.
        #     Format: properties/{property_id}/iosAppDataStreams/{stream_id}
        #     Example: "properties/123/iosAppDataStreams/456"
        class DeleteIosAppDataStreamRequest; end

        # Request message for UpdateIosAppDataStream RPC.
        # @!attribute [rw] ios_app_data_stream
        #   @return [Google::Analytics::Admin::V1alpha::IosAppDataStream]
        #     Required. The iOS app stream to update.
        #     The `name` field is used to identify the iOS app stream to be updated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateIosAppDataStreamRequest; end

        # Request message for CreateIosAppDataStream RPC.
        # @!attribute [rw] ios_app_data_stream
        #   @return [Google::Analytics::Admin::V1alpha::IosAppDataStream]
        #     Required. The iOS app data stream to create.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource where this ios app data stream will be created.
        #     Format: properties/123
        class CreateIosAppDataStreamRequest; end

        # Request message for ListIosAppDataStreams RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the parent property.
        #     For example, to list results of app streams under the property with Id
        #     123: "properties/123"
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListIosAppDataStreams`
        #     call. Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListIosAppDataStreams`
        #     must match the call that provided the page token.
        class ListIosAppDataStreamsRequest; end

        # Request message for ListIosAppDataStreams RPC.
        # @!attribute [rw] ios_app_data_streams
        #   @return [Array<Google::Analytics::Admin::V1alpha::IosAppDataStream>]
        #     Results that matched the filter criteria and were accessible to the caller.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListIosAppDataStreamsResponse; end

        # Request message for GetAndroidAppDataStream RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the android app data stream to lookup.
        #     Format: properties/{property_id}/androidAppDataStreams/{stream_id}
        #     Example: "properties/123/androidAppDataStreams/456"
        class GetAndroidAppDataStreamRequest; end

        # Request message for DeleteAndroidAppDataStream RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the android app data stream to delete.
        #     Format: properties/{property_id}/androidAppDataStreams/{stream_id}
        #     Example: "properties/123/androidAppDataStreams/456"
        class DeleteAndroidAppDataStreamRequest; end

        # Request message for UpdateAndroidAppDataStream RPC.
        # @!attribute [rw] android_app_data_stream
        #   @return [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
        #     Required. The android app stream to update.
        #     The `name` field is used to identify the android app stream to be updated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateAndroidAppDataStreamRequest; end

        # Request message for CreateAndroidAppDataStream RPC.
        # @!attribute [rw] android_app_data_stream
        #   @return [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
        #     Required. The android app stream to create.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource where this android app data stream will be created.
        #     Format: properties/123
        class CreateAndroidAppDataStreamRequest; end

        # Request message for ListAndroidAppDataStreams RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the parent property.
        #     For example, to limit results to app streams under the property with Id
        #     123: "properties/123"
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return.
        #
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous call. Provide this to
        #     retrieve the subsequent page.
        #     When paginating, all other parameters provided to
        #     `ListAndroidAppDataStreams` must match the call that provided the page
        #     token.
        class ListAndroidAppDataStreamsRequest; end

        # Request message for ListAndroidDataStreams RPC.
        # @!attribute [rw] android_app_data_streams
        #   @return [Array<Google::Analytics::Admin::V1alpha::AndroidAppDataStream>]
        #     Results that matched the filter criteria and were accessible to the caller.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListAndroidAppDataStreamsResponse; end

        # Request message for GetEnhancedMeasurementSettings RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the settings to lookup.
        #     Format:
        #     properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings
        #     Example: "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
        class GetEnhancedMeasurementSettingsRequest; end

        # Request message for UpdateEnhancedMeasurementSettings RPC.
        # @!attribute [rw] enhanced_measurement_settings
        #   @return [Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings]
        #     Required. The settings to update.
        #     The `name` field is used to identify the settings to be updated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateEnhancedMeasurementSettingsRequest; end

        # Request message for CreateFirebaseLink RPC
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Format: properties/{property_id}
        #     Example: properties/1234
        # @!attribute [rw] firebase_link
        #   @return [Google::Analytics::Admin::V1alpha::FirebaseLink]
        #     Required. The Firebase link to create.
        class CreateFirebaseLinkRequest; end

        # Request message for UpdateFirebaseLink RPC
        # @!attribute [rw] firebase_link
        #   @return [Google::Analytics::Admin::V1alpha::FirebaseLink]
        #     Required. The Firebase link to update.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateFirebaseLinkRequest; end

        # Request message for DeleteFirebaseLink RPC
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
        #     Example: properties/1234/firebaseLinks/5678
        class DeleteFirebaseLinkRequest; end

        # Request message for ListFirebaseLinks RPC
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Format: properties/{property_id}
        #     Example: properties/1234
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return. The service may return
        #     fewer than this value, even if there are additional pages.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListFirebaseLinks` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListProperties` must
        #     match the call that provided the page token.
        class ListFirebaseLinksRequest; end

        # Response message for ListFirebaseLinks RPC
        # @!attribute [rw] firebase_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::FirebaseLink>]
        #     List of FirebaseLinks. This will have at most one value.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        #     Currently, Google Analytics supports only one FirebaseLink per property,
        #     so this will never be populated.
        class ListFirebaseLinksResponse; end

        # Request message for GetGlobalSiteTag RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the site tag to lookup.
        #     Note that site tags are singletons and do not have unique IDs.
        #     Format: properties/{property_id}/webDataStreams/{stream_id}/globalSiteTag
        #     Example: "properties/123/webDataStreams/456/globalSiteTag"
        class GetGlobalSiteTagRequest; end

        # Request message for CreateGoogleAdsLink RPC
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Example format: properties/1234
        # @!attribute [rw] google_ads_link
        #   @return [Google::Analytics::Admin::V1alpha::GoogleAdsLink]
        #     Required. The GoogleAdsLink to create.
        class CreateGoogleAdsLinkRequest; end

        # Request message for UpdateGoogleAdsLink RPC
        # @!attribute [rw] google_ads_link
        #   @return [Google::Analytics::Admin::V1alpha::GoogleAdsLink]
        #     The GoogleAdsLink to update
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The list of fields to be updated. Field names must be in snake case
        #     (e.g., "field_to_update"). Omitted fields will not be updated. To replace
        #     the entire entity, use one path with the string "*" to match all fields.
        class UpdateGoogleAdsLinkRequest; end

        # Request message for DeleteGoogleAdsLink RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Example format: properties/1234/googleAdsLinks/5678
        class DeleteGoogleAdsLinkRequest; end

        # Request message for ListGoogleAdsLinks RPC.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Example format: properties/1234
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of resources to return.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200 (higher values will be coerced to the maximum).
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListGoogleAdsLinks` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListGoogleAdsLinks` must
        #     match the call that provided the page token.
        class ListGoogleAdsLinksRequest; end

        # Response message for ListGoogleAdsLinks RPC.
        # @!attribute [rw] google_ads_links
        #   @return [Array<Google::Analytics::Admin::V1alpha::GoogleAdsLink>]
        #     List of GoogleAdsLinks.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListGoogleAdsLinksResponse; end

        # Request message for GetDataSharingSettings RPC.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the settings to lookup.
        #     Format: accounts/{account}/dataSharingSettings
        #     Example: "accounts/1000/dataSharingSettings"
        class GetDataSharingSettingsRequest; end

        # Request message for ListAccountSummaries RPC.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of AccountSummary resources to return. The service may
        #     return fewer than this value, even if there are additional pages.
        #     If unspecified, at most 50 resources will be returned.
        #     The maximum value is 200; (higher values will be coerced to the maximum)
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListAccountSummaries` call.
        #     Provide this to retrieve the subsequent page.
        #     When paginating, all other parameters provided to `ListAccountSummaries`
        #     must match the call that provided the page token.
        class ListAccountSummariesRequest; end

        # Response message for ListAccountSummaries RPC.
        # @!attribute [rw] account_summaries
        #   @return [Array<Google::Analytics::Admin::V1alpha::AccountSummary>]
        #     Account summaries of all accounts the caller has access to.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        class ListAccountSummariesResponse; end
      end
    end
  end
end