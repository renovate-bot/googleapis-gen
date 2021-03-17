# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1/document.proto

require 'google/protobuf'

require 'google/api/field_behavior_pb'
require 'google/cloud/documentai/v1/geometry_pb'
require 'google/protobuf/timestamp_pb'
require 'google/rpc/status_pb'
require 'google/type/color_pb'
require 'google/type/date_pb'
require 'google/type/datetime_pb'
require 'google/type/money_pb'
require 'google/type/postal_address_pb'
require 'google/api/annotations_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/documentai/v1/document.proto", :syntax => :proto3) do
    add_message "google.cloud.documentai.v1.Document" do
      optional :mime_type, :string, 3
      optional :text, :string, 4
      repeated :text_styles, :message, 5, "google.cloud.documentai.v1.Document.Style"
      repeated :pages, :message, 6, "google.cloud.documentai.v1.Document.Page"
      repeated :entities, :message, 7, "google.cloud.documentai.v1.Document.Entity"
      repeated :entity_relations, :message, 8, "google.cloud.documentai.v1.Document.EntityRelation"
      repeated :text_changes, :message, 14, "google.cloud.documentai.v1.Document.TextChange"
      optional :shard_info, :message, 9, "google.cloud.documentai.v1.Document.ShardInfo"
      optional :error, :message, 10, "google.rpc.Status"
      repeated :revisions, :message, 13, "google.cloud.documentai.v1.Document.Revision"
      oneof :source do
        optional :uri, :string, 1
        optional :content, :bytes, 2
      end
    end
    add_message "google.cloud.documentai.v1.Document.ShardInfo" do
      optional :shard_index, :int64, 1
      optional :shard_count, :int64, 2
      optional :text_offset, :int64, 3
    end
    add_message "google.cloud.documentai.v1.Document.Style" do
      optional :text_anchor, :message, 1, "google.cloud.documentai.v1.Document.TextAnchor"
      optional :color, :message, 2, "google.type.Color"
      optional :background_color, :message, 3, "google.type.Color"
      optional :font_weight, :string, 4
      optional :text_style, :string, 5
      optional :text_decoration, :string, 6
      optional :font_size, :message, 7, "google.cloud.documentai.v1.Document.Style.FontSize"
    end
    add_message "google.cloud.documentai.v1.Document.Style.FontSize" do
      optional :size, :float, 1
      optional :unit, :string, 2
    end
    add_message "google.cloud.documentai.v1.Document.Page" do
      optional :page_number, :int32, 1
      optional :image, :message, 13, "google.cloud.documentai.v1.Document.Page.Image"
      repeated :transforms, :message, 14, "google.cloud.documentai.v1.Document.Page.Matrix"
      optional :dimension, :message, 2, "google.cloud.documentai.v1.Document.Page.Dimension"
      optional :layout, :message, 3, "google.cloud.documentai.v1.Document.Page.Layout"
      repeated :detected_languages, :message, 4, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      repeated :blocks, :message, 5, "google.cloud.documentai.v1.Document.Page.Block"
      repeated :paragraphs, :message, 6, "google.cloud.documentai.v1.Document.Page.Paragraph"
      repeated :lines, :message, 7, "google.cloud.documentai.v1.Document.Page.Line"
      repeated :tokens, :message, 8, "google.cloud.documentai.v1.Document.Page.Token"
      repeated :visual_elements, :message, 9, "google.cloud.documentai.v1.Document.Page.VisualElement"
      repeated :tables, :message, 10, "google.cloud.documentai.v1.Document.Page.Table"
      repeated :form_fields, :message, 11, "google.cloud.documentai.v1.Document.Page.FormField"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Dimension" do
      optional :width, :float, 1
      optional :height, :float, 2
      optional :unit, :string, 3
    end
    add_message "google.cloud.documentai.v1.Document.Page.Image" do
      optional :content, :bytes, 1
      optional :mime_type, :string, 2
      optional :width, :int32, 3
      optional :height, :int32, 4
    end
    add_message "google.cloud.documentai.v1.Document.Page.Matrix" do
      optional :rows, :int32, 1
      optional :cols, :int32, 2
      optional :type, :int32, 3
      optional :data, :bytes, 4
    end
    add_message "google.cloud.documentai.v1.Document.Page.Layout" do
      optional :text_anchor, :message, 1, "google.cloud.documentai.v1.Document.TextAnchor"
      optional :confidence, :float, 2
      optional :bounding_poly, :message, 3, "google.cloud.documentai.v1.BoundingPoly"
      optional :orientation, :enum, 4, "google.cloud.documentai.v1.Document.Page.Layout.Orientation"
    end
    add_enum "google.cloud.documentai.v1.Document.Page.Layout.Orientation" do
      value :ORIENTATION_UNSPECIFIED, 0
      value :PAGE_UP, 1
      value :PAGE_RIGHT, 2
      value :PAGE_DOWN, 3
      value :PAGE_LEFT, 4
    end
    add_message "google.cloud.documentai.v1.Document.Page.Block" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      repeated :detected_languages, :message, 2, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      optional :provenance, :message, 3, "google.cloud.documentai.v1.Document.Provenance"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Paragraph" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      repeated :detected_languages, :message, 2, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      optional :provenance, :message, 3, "google.cloud.documentai.v1.Document.Provenance"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Line" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      repeated :detected_languages, :message, 2, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      optional :provenance, :message, 3, "google.cloud.documentai.v1.Document.Provenance"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Token" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      optional :detected_break, :message, 2, "google.cloud.documentai.v1.Document.Page.Token.DetectedBreak"
      repeated :detected_languages, :message, 3, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      optional :provenance, :message, 4, "google.cloud.documentai.v1.Document.Provenance"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Token.DetectedBreak" do
      optional :type, :enum, 1, "google.cloud.documentai.v1.Document.Page.Token.DetectedBreak.Type"
    end
    add_enum "google.cloud.documentai.v1.Document.Page.Token.DetectedBreak.Type" do
      value :TYPE_UNSPECIFIED, 0
      value :SPACE, 1
      value :WIDE_SPACE, 2
      value :HYPHEN, 3
    end
    add_message "google.cloud.documentai.v1.Document.Page.VisualElement" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      optional :type, :string, 2
      repeated :detected_languages, :message, 3, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Table" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      repeated :header_rows, :message, 2, "google.cloud.documentai.v1.Document.Page.Table.TableRow"
      repeated :body_rows, :message, 3, "google.cloud.documentai.v1.Document.Page.Table.TableRow"
      repeated :detected_languages, :message, 4, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Table.TableRow" do
      repeated :cells, :message, 1, "google.cloud.documentai.v1.Document.Page.Table.TableCell"
    end
    add_message "google.cloud.documentai.v1.Document.Page.Table.TableCell" do
      optional :layout, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      optional :row_span, :int32, 2
      optional :col_span, :int32, 3
      repeated :detected_languages, :message, 4, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
    end
    add_message "google.cloud.documentai.v1.Document.Page.FormField" do
      optional :field_name, :message, 1, "google.cloud.documentai.v1.Document.Page.Layout"
      optional :field_value, :message, 2, "google.cloud.documentai.v1.Document.Page.Layout"
      repeated :name_detected_languages, :message, 3, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      repeated :value_detected_languages, :message, 4, "google.cloud.documentai.v1.Document.Page.DetectedLanguage"
      optional :value_type, :string, 5
    end
    add_message "google.cloud.documentai.v1.Document.Page.DetectedLanguage" do
      optional :language_code, :string, 1
      optional :confidence, :float, 2
    end
    add_message "google.cloud.documentai.v1.Document.Entity" do
      optional :text_anchor, :message, 1, "google.cloud.documentai.v1.Document.TextAnchor"
      optional :type, :string, 2
      optional :mention_text, :string, 3
      optional :mention_id, :string, 4
      optional :confidence, :float, 5
      optional :page_anchor, :message, 6, "google.cloud.documentai.v1.Document.PageAnchor"
      optional :id, :string, 7
      optional :normalized_value, :message, 9, "google.cloud.documentai.v1.Document.Entity.NormalizedValue"
      repeated :properties, :message, 10, "google.cloud.documentai.v1.Document.Entity"
      optional :provenance, :message, 11, "google.cloud.documentai.v1.Document.Provenance"
      optional :redacted, :bool, 12
    end
    add_message "google.cloud.documentai.v1.Document.Entity.NormalizedValue" do
      optional :text, :string, 1
      oneof :structured_value do
        optional :money_value, :message, 2, "google.type.Money"
        optional :date_value, :message, 3, "google.type.Date"
        optional :datetime_value, :message, 4, "google.type.DateTime"
        optional :address_value, :message, 5, "google.type.PostalAddress"
        optional :boolean_value, :bool, 6
      end
    end
    add_message "google.cloud.documentai.v1.Document.EntityRelation" do
      optional :subject_id, :string, 1
      optional :object_id, :string, 2
      optional :relation, :string, 3
    end
    add_message "google.cloud.documentai.v1.Document.TextAnchor" do
      repeated :text_segments, :message, 1, "google.cloud.documentai.v1.Document.TextAnchor.TextSegment"
      optional :content, :string, 2
    end
    add_message "google.cloud.documentai.v1.Document.TextAnchor.TextSegment" do
      optional :start_index, :int64, 1
      optional :end_index, :int64, 2
    end
    add_message "google.cloud.documentai.v1.Document.PageAnchor" do
      repeated :page_refs, :message, 1, "google.cloud.documentai.v1.Document.PageAnchor.PageRef"
    end
    add_message "google.cloud.documentai.v1.Document.PageAnchor.PageRef" do
      optional :page, :int64, 1
      optional :layout_type, :enum, 2, "google.cloud.documentai.v1.Document.PageAnchor.PageRef.LayoutType"
      optional :layout_id, :string, 3
      optional :bounding_poly, :message, 4, "google.cloud.documentai.v1.BoundingPoly"
    end
    add_enum "google.cloud.documentai.v1.Document.PageAnchor.PageRef.LayoutType" do
      value :LAYOUT_TYPE_UNSPECIFIED, 0
      value :BLOCK, 1
      value :PARAGRAPH, 2
      value :LINE, 3
      value :TOKEN, 4
      value :VISUAL_ELEMENT, 5
      value :TABLE, 6
      value :FORM_FIELD, 7
    end
    add_message "google.cloud.documentai.v1.Document.Provenance" do
      optional :revision, :int32, 1
      optional :id, :int32, 2
      repeated :parents, :message, 3, "google.cloud.documentai.v1.Document.Provenance.Parent"
      optional :type, :enum, 4, "google.cloud.documentai.v1.Document.Provenance.OperationType"
    end
    add_message "google.cloud.documentai.v1.Document.Provenance.Parent" do
      optional :revision, :int32, 1
      optional :id, :int32, 2
    end
    add_enum "google.cloud.documentai.v1.Document.Provenance.OperationType" do
      value :OPERATION_TYPE_UNSPECIFIED, 0
      value :ADD, 1
      value :REMOVE, 2
      value :REPLACE, 3
      value :EVAL_REQUESTED, 4
      value :EVAL_APPROVED, 5
      value :EVAL_SKIPPED, 6
    end
    add_message "google.cloud.documentai.v1.Document.Revision" do
      optional :id, :string, 1
      repeated :parent, :int32, 2
      optional :create_time, :message, 3, "google.protobuf.Timestamp"
      optional :human_review, :message, 6, "google.cloud.documentai.v1.Document.Revision.HumanReview"
      oneof :source do
        optional :agent, :string, 4
        optional :processor, :string, 5
      end
    end
    add_message "google.cloud.documentai.v1.Document.Revision.HumanReview" do
      optional :state, :string, 1
      optional :state_message, :string, 2
    end
    add_message "google.cloud.documentai.v1.Document.TextChange" do
      optional :text_anchor, :message, 1, "google.cloud.documentai.v1.Document.TextAnchor"
      optional :changed_text, :string, 2
      repeated :provenance, :message, 3, "google.cloud.documentai.v1.Document.Provenance"
    end
  end
end

module Google
  module Cloud
    module DocumentAI
      module V1
        Document = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document").msgclass
        Document::ShardInfo = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.ShardInfo").msgclass
        Document::Style = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Style").msgclass
        Document::Style::FontSize = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Style.FontSize").msgclass
        Document::Page = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page").msgclass
        Document::Page::Dimension = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Dimension").msgclass
        Document::Page::Image = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Image").msgclass
        Document::Page::Matrix = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Matrix").msgclass
        Document::Page::Layout = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Layout").msgclass
        Document::Page::Layout::Orientation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Layout.Orientation").enummodule
        Document::Page::Block = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Block").msgclass
        Document::Page::Paragraph = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Paragraph").msgclass
        Document::Page::Line = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Line").msgclass
        Document::Page::Token = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Token").msgclass
        Document::Page::Token::DetectedBreak = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Token.DetectedBreak").msgclass
        Document::Page::Token::DetectedBreak::Type = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Token.DetectedBreak.Type").enummodule
        Document::Page::VisualElement = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.VisualElement").msgclass
        Document::Page::Table = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Table").msgclass
        Document::Page::Table::TableRow = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Table.TableRow").msgclass
        Document::Page::Table::TableCell = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.Table.TableCell").msgclass
        Document::Page::FormField = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.FormField").msgclass
        Document::Page::DetectedLanguage = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Page.DetectedLanguage").msgclass
        Document::Entity = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Entity").msgclass
        Document::Entity::NormalizedValue = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Entity.NormalizedValue").msgclass
        Document::EntityRelation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.EntityRelation").msgclass
        Document::TextAnchor = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.TextAnchor").msgclass
        Document::TextAnchor::TextSegment = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.TextAnchor.TextSegment").msgclass
        Document::PageAnchor = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.PageAnchor").msgclass
        Document::PageAnchor::PageRef = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.PageAnchor.PageRef").msgclass
        Document::PageAnchor::PageRef::LayoutType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.PageAnchor.PageRef.LayoutType").enummodule
        Document::Provenance = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Provenance").msgclass
        Document::Provenance::Parent = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Provenance.Parent").msgclass
        Document::Provenance::OperationType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Provenance.OperationType").enummodule
        Document::Revision = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Revision").msgclass
        Document::Revision::HumanReview = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.Revision.HumanReview").msgclass
        Document::TextChange = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.documentai.v1.Document.TextChange").msgclass
      end
    end
  end
end
