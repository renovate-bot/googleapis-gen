<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1beta1/tags.proto

namespace GPBMetadata\Google\Cloud\Datacatalog\V1Beta1;

class Tags
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
+google/cloud/datacatalog/v1beta1/tags.proto google.cloud.datacatalog.v1beta1google/api/resource.protogoogle/protobuf/timestamp.proto"�
Tag
name (	
template (	B�A"
template_display_name (	B�A
column (	H F
fields (21.google.cloud.datacatalog.v1beta1.Tag.FieldsEntryB�AY
FieldsEntry
key (	9
value (2*.google.cloud.datacatalog.v1beta1.TagField:8:��A~
datacatalog.googleapis.com/Tag\\projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}B
scope"�
TagField
display_name (	B�A
double_value (H 
string_value (	H 

bool_value (H 5
timestamp_value (2.google.protobuf.TimestampH J

enum_value (24.google.cloud.datacatalog.v1beta1.TagField.EnumValueH 
order (B�A!
	EnumValue
display_name (	B
kind"�
TagTemplate
name (	
display_name (	N
fields (29.google.cloud.datacatalog.v1beta1.TagTemplate.FieldsEntryB�Aa
FieldsEntry
key (	A
value (22.google.cloud.datacatalog.v1beta1.TagTemplateField:8:p�Am
&datacatalog.googleapis.com/TagTemplateCprojects/{project}/locations/{location}/tagTemplates/{tag_template}"�
TagTemplateField
name (	B�A
display_name (	>
type (2+.google.cloud.datacatalog.v1beta1.FieldTypeB�A
is_required (
order (:��A�
+datacatalog.googleapis.com/TagTemplateFieldRprojects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}"�
	FieldTypeS
primitive_type (29.google.cloud.datacatalog.v1beta1.FieldType.PrimitiveTypeH I
	enum_type (24.google.cloud.datacatalog.v1beta1.FieldType.EnumTypeH �
EnumTypeV
allowed_values (2>.google.cloud.datacatalog.v1beta1.FieldType.EnumType.EnumValue&
	EnumValue
display_name (	B�A"`
PrimitiveType
PRIMITIVE_TYPE_UNSPECIFIED 

DOUBLE

STRING
BOOL
	TIMESTAMPB
	type_declB�
$com.google.cloud.datacatalog.v1beta1PZKgoogle.golang.org/genproto/googleapis/cloud/datacatalog/v1beta1;datacatalog�� Google.Cloud.DataCatalog.V1Beta1� Google\\Cloud\\DataCatalog\\V1beta1�#Google::Cloud::DataCatalog::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

