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
  module Area120
    module Tables
      module V1alpha1
        # Request message for TablesService.GetTable.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the table to retrieve.
        #     Format: tables/{table}
        class GetTableRequest; end

        # Request message for TablesService.ListTables.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of tables to return. The service may return fewer than
        #     this value.
        #
        #     If unspecified, at most 20 tables are returned. The maximum value is 100;
        #     values above 100 are coerced to 100.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListTables` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListTables` must match
        #     the call that provided the page token.
        class ListTablesRequest; end

        # Response message for TablesService.ListTables.
        # @!attribute [rw] tables
        #   @return [Array<Google::Area120::Tables::V1alpha1::Table>]
        #     The list of tables.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is empty, there are no subsequent pages.
        class ListTablesResponse; end

        # Request message for TablesService.GetWorkspace.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the workspace to retrieve.
        #     Format: workspaces/{workspace}
        class GetWorkspaceRequest; end

        # Request message for TablesService.ListWorkspaces.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of workspaces to return. The service may return fewer
        #     than this value.
        #
        #     If unspecified, at most 10 workspaces are returned. The maximum value is
        #     25; values above 25 are coerced to 25.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListWorkspaces` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListWorkspaces` must
        #     match the call that provided the page token.
        class ListWorkspacesRequest; end

        # Response message for TablesService.ListWorkspaces.
        # @!attribute [rw] workspaces
        #   @return [Array<Google::Area120::Tables::V1alpha1::Workspace>]
        #     The list of workspaces.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is empty, there are no subsequent pages.
        class ListWorkspacesResponse; end

        # Request message for TablesService.GetRow.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the row to retrieve.
        #     Format: tables/{table}/rows/{row}
        # @!attribute [rw] view
        #   @return [Google::Area120::Tables::V1alpha1::View]
        #     Optional. Column key to use for values in the row.
        #     Defaults to user entered name.
        class GetRowRequest; end

        # Request message for TablesService.ListRows.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent table.
        #     Format: tables/{table}
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of rows to return. The service may return fewer than
        #     this value.
        #
        #     If unspecified, at most 50 rows are returned. The maximum value is 1,000;
        #     values above 1,000 are coerced to 1,000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListRows` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListRows` must match
        #     the call that provided the page token.
        # @!attribute [rw] view
        #   @return [Google::Area120::Tables::V1alpha1::View]
        #     Optional. Column key to use for values in the row.
        #     Defaults to user entered name.
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. Raw text query to search for in rows of the table.
        #     Special characters must be escaped. Logical operators and field specific
        #     filtering not supported.
        class ListRowsRequest; end

        # Response message for TablesService.ListRows.
        # @!attribute [rw] rows
        #   @return [Array<Google::Area120::Tables::V1alpha1::Row>]
        #     The rows from the specified table.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is empty, there are no subsequent pages.
        class ListRowsResponse; end

        # Request message for TablesService.CreateRow.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent table where this row will be created.
        #     Format: tables/{table}
        # @!attribute [rw] row
        #   @return [Google::Area120::Tables::V1alpha1::Row]
        #     Required. The row to create.
        # @!attribute [rw] view
        #   @return [Google::Area120::Tables::V1alpha1::View]
        #     Optional. Column key to use for values in the row.
        #     Defaults to user entered name.
        class CreateRowRequest; end

        # Request message for TablesService.BatchCreateRows.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent table where the rows will be created.
        #     Format: tables/{table}
        # @!attribute [rw] requests
        #   @return [Array<Google::Area120::Tables::V1alpha1::CreateRowRequest>]
        #     Required. The request message specifying the rows to create.
        #
        #     A maximum of 500 rows can be created in a single batch.
        class BatchCreateRowsRequest; end

        # Response message for TablesService.BatchCreateRows.
        # @!attribute [rw] rows
        #   @return [Array<Google::Area120::Tables::V1alpha1::Row>]
        #     The created rows.
        class BatchCreateRowsResponse; end

        # Request message for TablesService.UpdateRow.
        # @!attribute [rw] row
        #   @return [Google::Area120::Tables::V1alpha1::Row]
        #     Required. The row to update.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     The list of fields to update.
        # @!attribute [rw] view
        #   @return [Google::Area120::Tables::V1alpha1::View]
        #     Optional. Column key to use for values in the row.
        #     Defaults to user entered name.
        class UpdateRowRequest; end

        # Request message for TablesService.BatchUpdateRows.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent table shared by all rows being updated.
        #     Format: tables/{table}
        # @!attribute [rw] requests
        #   @return [Array<Google::Area120::Tables::V1alpha1::UpdateRowRequest>]
        #     Required. The request messages specifying the rows to update.
        #
        #     A maximum of 500 rows can be modified in a single batch.
        class BatchUpdateRowsRequest; end

        # Response message for TablesService.BatchUpdateRows.
        # @!attribute [rw] rows
        #   @return [Array<Google::Area120::Tables::V1alpha1::Row>]
        #     The updated rows.
        class BatchUpdateRowsResponse; end

        # Request message for TablesService.DeleteRow
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the row to delete.
        #     Format: tables/{table}/rows/{row}
        class DeleteRowRequest; end

        # Request message for TablesService.BatchDeleteRows
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent table shared by all rows being deleted.
        #     Format: tables/{table}
        # @!attribute [rw] names
        #   @return [Array<String>]
        #     Required. The names of the rows to delete. All rows must belong to the parent table
        #     or else the entire batch will fail. A maximum of 500 rows can be deleted
        #     in a batch.
        #     Format: tables/{table}/rows/{row}
        class BatchDeleteRowsRequest; end

        # A single table.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the table.
        #     Table names have the form `tables/{table}`.
        # @!attribute [rw] display_name
        #   @return [String]
        #     The human readable title of the table.
        # @!attribute [rw] columns
        #   @return [Array<Google::Area120::Tables::V1alpha1::ColumnDescription>]
        #     List of columns in this table.
        #     Order of columns matches the display order.
        class Table; end

        # Details on a column in the table.
        # @!attribute [rw] name
        #   @return [String]
        #     column name
        # @!attribute [rw] data_type
        #   @return [String]
        #     Data type of the column
        #     Supported types are auto_id, boolean, boolean_list, creator,
        #     create_timestamp, date, dropdown, location, integer,
        #     integer_list, number, number_list, person, person_list, tags, check_list,
        #     text, text_list, update_timestamp, updater, relationship,
        #     file_attachment_list.
        #     These types directly map to the column types supported on Tables website.
        # @!attribute [rw] id
        #   @return [String]
        #     Internal id for a column.
        # @!attribute [rw] labels
        #   @return [Array<Google::Area120::Tables::V1alpha1::LabeledItem>]
        #     Optional. Range of labeled values for the column.
        #     Some columns like tags and drop-downs limit the values to a set of
        #     possible values. We return the range of values in such cases to help
        #     clients implement better user data validation.
        # @!attribute [rw] relationship_details
        #   @return [Google::Area120::Tables::V1alpha1::RelationshipDetails]
        #     Optional. Additional details about a relationship column. Specified when data_type
        #     is relationship.
        # @!attribute [rw] lookup_details
        #   @return [Google::Area120::Tables::V1alpha1::LookupDetails]
        #     Optional. Indicates that this is a lookup column whose value is derived from the
        #     relationship column specified in the details. Lookup columns can not be
        #     updated directly. To change the value you must update the associated
        #     relationship column.
        class ColumnDescription; end

        # A single item in a labeled column.
        # @!attribute [rw] name
        #   @return [String]
        #     Display string as entered by user.
        # @!attribute [rw] id
        #   @return [String]
        #     Internal id associated with the item.
        class LabeledItem; end

        # Details about a relationship column.
        # @!attribute [rw] linked_table
        #   @return [String]
        #     The name of the table this relationship is linked to.
        class RelationshipDetails; end

        # Details about a lookup column whose value comes from the associated
        # relationship.
        # @!attribute [rw] relationship_column
        #   @return [String]
        #     The name of the relationship column associated with the lookup.
        # @!attribute [rw] relationship_column_id
        #   @return [String]
        #     The id of the relationship column.
        class LookupDetails; end

        # A single row in a table.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the row.
        #     Row names have the form `tables/{table}/rows/{row}`.
        #     The name is ignored when creating a row.
        # @!attribute [rw] values
        #   @return [Hash{String => Google::Protobuf::Value}]
        #     The values of the row. This is a map of column key to value.
        #     Key is user entered name(default) or the internal column id based on
        #     the view in the request.
        class Row; end

        # A single workspace.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the workspace.
        #     Workspace names have the form `workspaces/{workspace}`.
        # @!attribute [rw] display_name
        #   @return [String]
        #     The human readable title of the workspace.
        # @!attribute [rw] tables
        #   @return [Array<Google::Area120::Tables::V1alpha1::Table>]
        #     The list of tables in the workspace.
        class Workspace; end

        # Column identifier used for the values in the row.
        module View
          # Defaults to user entered text.
          VIEW_UNSPECIFIED = 0

          # Uses internally generated column id to identify values.
          COLUMN_ID_VIEW = 1
        end
      end
    end
  end
end