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
    module Monitoring
      module Dashboard
        module V1
          # A basic layout divides the available space into vertical columns of equal
          # width and arranges a list of widgets using a row-first strategy.
          # @!attribute [rw] columns
          #   @return [::Integer]
          #     The number of columns into which the view's width is divided. If omitted
          #     or set to zero, a system default will be used while rendering.
          # @!attribute [rw] widgets
          #   @return [::Array<::Google::Cloud::Monitoring::Dashboard::V1::Widget>]
          #     The informational elements that are arranged into the columns row-first.
          class GridLayout
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A mosaic layout divides the available space into a grid of blocks, and
          # overlays the grid with tiles. Unlike `GridLayout`, tiles may span multiple
          # grid blocks and can be placed at arbitrary locations in the grid.
          # @!attribute [rw] columns
          #   @return [::Integer]
          #     The number of columns in the mosaic grid. The number of columns must be
          #     between 1 and 12, inclusive.
          # @!attribute [rw] tiles
          #   @return [::Array<::Google::Cloud::Monitoring::Dashboard::V1::MosaicLayout::Tile>]
          #     The tiles to display.
          class MosaicLayout
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # A single tile in the mosaic. The placement and size of the tile are
            # configurable.
            # @!attribute [rw] x_pos
            #   @return [::Integer]
            #     The zero-indexed position of the tile in grid blocks relative to the
            #     left edge of the grid. Tiles must be contained within the specified
            #     number of columns. `x_pos` cannot be negative.
            # @!attribute [rw] y_pos
            #   @return [::Integer]
            #     The zero-indexed position of the tile in grid blocks relative to the
            #     top edge of the grid. `y_pos` cannot be negative.
            # @!attribute [rw] width
            #   @return [::Integer]
            #     The width of the tile, measured in grid blocks. Tiles must have a
            #     minimum width of 1.
            # @!attribute [rw] height
            #   @return [::Integer]
            #     The height of the tile, measured in grid blocks. Tiles must have a
            #     minimum height of 1.
            # @!attribute [rw] widget
            #   @return [::Google::Cloud::Monitoring::Dashboard::V1::Widget]
            #     The informational widget contained in the tile. For example an `XyChart`.
            class Tile
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end
          end

          # A simplified layout that divides the available space into rows
          # and arranges a set of widgets horizontally in each row.
          # @!attribute [rw] rows
          #   @return [::Array<::Google::Cloud::Monitoring::Dashboard::V1::RowLayout::Row>]
          #     The rows of content to display.
          class RowLayout
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Defines the layout properties and content for a row.
            # @!attribute [rw] weight
            #   @return [::Integer]
            #     The relative weight of this row. The row weight is used to adjust the
            #     height of rows on the screen (relative to peers). Greater the weight,
            #     greater the height of the row on the screen. If omitted, a value
            #     of 1 is used while rendering.
            # @!attribute [rw] widgets
            #   @return [::Array<::Google::Cloud::Monitoring::Dashboard::V1::Widget>]
            #     The display widgets arranged horizontally in this row.
            class Row
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end
          end

          # A simplified layout that divides the available space into vertical columns
          # and arranges a set of widgets vertically in each column.
          # @!attribute [rw] columns
          #   @return [::Array<::Google::Cloud::Monitoring::Dashboard::V1::ColumnLayout::Column>]
          #     The columns of content to display.
          class ColumnLayout
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Defines the layout properties and content for a column.
            # @!attribute [rw] weight
            #   @return [::Integer]
            #     The relative weight of this column. The column weight is used to adjust
            #     the width of columns on the screen (relative to peers).
            #     Greater the weight, greater the width of the column on the screen.
            #     If omitted, a value of 1 is used while rendering.
            # @!attribute [rw] widgets
            #   @return [::Array<::Google::Cloud::Monitoring::Dashboard::V1::Widget>]
            #     The display widgets arranged vertically in this column.
            class Column
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end
          end
        end
      end
    end
  end
end
