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
    module Bigquery
      module V2
        # The type of a variable, e.g., a function argument.
        # Examples:
        # INT64: \\{type_kind="INT64"}
        # ARRAY<STRING>: \\{type_kind="ARRAY", array_element_type="STRING"}
        # STRUCT<x STRING, y ARRAY<DATE>>:
        #   {type_kind="STRUCT",
        #    struct_type={fields=[
        #      \\{name="x", type=\\{type_kind="STRING"}},
        #      \\{name="y", type=\\{type_kind="ARRAY", array_element_type="DATE"}}
        #    ]}}
        # @!attribute [rw] type_kind
        #   @return [::Google::Cloud::Bigquery::V2::StandardSqlDataType::TypeKind]
        #     Required. The top level type of this field.
        #     Can be any standard SQL data type (e.g., "INT64", "DATE", "ARRAY").
        # @!attribute [rw] array_element_type
        #   @return [::Google::Cloud::Bigquery::V2::StandardSqlDataType]
        #     The type of the array's elements, if type_kind = "ARRAY".
        # @!attribute [rw] struct_type
        #   @return [::Google::Cloud::Bigquery::V2::StandardSqlStructType]
        #     The fields of this struct, in order, if type_kind = "STRUCT".
        class StandardSqlDataType
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          module TypeKind
            # Invalid type.
            TYPE_KIND_UNSPECIFIED = 0

            # Encoded as a string in decimal format.
            INT64 = 2

            # Encoded as a boolean "false" or "true".
            BOOL = 5

            # Encoded as a number, or string "NaN", "Infinity" or "-Infinity".
            FLOAT64 = 7

            # Encoded as a string value.
            STRING = 8

            # Encoded as a base64 string per RFC 4648, section 4.
            BYTES = 9

            # Encoded as an RFC 3339 timestamp with mandatory "Z" time zone string:
            # 1985-04-12T23:20:50.52Z
            TIMESTAMP = 19

            # Encoded as RFC 3339 full-date format string: 1985-04-12
            DATE = 10

            # Encoded as RFC 3339 partial-time format string: 23:20:50.52
            TIME = 20

            # Encoded as RFC 3339 full-date "T" partial-time: 1985-04-12T23:20:50.52
            DATETIME = 21

            # Encoded as fully qualified 3 part: 0-5 15 2:30:45.6
            INTERVAL = 26

            # Encoded as WKT
            GEOGRAPHY = 22

            # Encoded as a decimal string.
            NUMERIC = 23

            # Encoded as a decimal string.
            BIGNUMERIC = 24

            # Encoded as a string.
            JSON = 25

            # Encoded as a list with types matching Type.array_type.
            ARRAY = 16

            # Encoded as a list with fields of type Type.struct_type[i]. List is used
            # because a JSON object cannot have duplicate field names.
            STRUCT = 17
          end
        end

        # A field or a column.
        # @!attribute [rw] name
        #   @return [::String]
        #     Optional. The name of this field. Can be absent for struct fields.
        # @!attribute [rw] type
        #   @return [::Google::Cloud::Bigquery::V2::StandardSqlDataType]
        #     Optional. The type of this parameter. Absent if not explicitly
        #     specified (e.g., CREATE FUNCTION statement can omit the return type;
        #     in this case the output parameter does not have this "type" field).
        class StandardSqlField
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # @!attribute [rw] fields
        #   @return [::Array<::Google::Cloud::Bigquery::V2::StandardSqlField>]
        class StandardSqlStructType
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A table type
        # @!attribute [rw] columns
        #   @return [::Array<::Google::Cloud::Bigquery::V2::StandardSqlField>]
        #     The columns in this table type
        class StandardSqlTableType
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
