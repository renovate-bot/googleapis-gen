<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2/entity_type.proto

namespace Google\Cloud\Dialogflow\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [EntityTypes.BatchUpdateEntityTypes][google.cloud.dialogflow.v2.EntityTypes.BatchUpdateEntityTypes].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2.BatchUpdateEntityTypesRequest</code>
 */
class BatchUpdateEntityTypesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the agent to update or create entity types in.
     * Format: `projects/<Project ID>/agent`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Optional. The language used to access language-specific data.
     * If not specified, the agent's default language is used.
     * For more information, see
     * [Multilingual intent and entity
     * data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
     *
     * Generated from protobuf field <code>string language_code = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $language_code = '';
    /**
     * Optional. The mask to control which fields get updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $update_mask = null;
    protected $entity_type_batch;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the agent to update or create entity types in.
     *           Format: `projects/<Project ID>/agent`.
     *     @type string $entity_type_batch_uri
     *           The URI to a Google Cloud Storage file containing entity types to update
     *           or create. The file format can either be a serialized proto (of
     *           EntityBatch type) or a JSON object. Note: The URI must start with
     *           "gs://".
     *     @type \Google\Cloud\Dialogflow\V2\EntityTypeBatch $entity_type_batch_inline
     *           The collection of entity types to update or create.
     *     @type string $language_code
     *           Optional. The language used to access language-specific data.
     *           If not specified, the agent's default language is used.
     *           For more information, see
     *           [Multilingual intent and entity
     *           data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Optional. The mask to control which fields get updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2\EntityType::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the agent to update or create entity types in.
     * Format: `projects/<Project ID>/agent`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the agent to update or create entity types in.
     * Format: `projects/<Project ID>/agent`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * The URI to a Google Cloud Storage file containing entity types to update
     * or create. The file format can either be a serialized proto (of
     * EntityBatch type) or a JSON object. Note: The URI must start with
     * "gs://".
     *
     * Generated from protobuf field <code>string entity_type_batch_uri = 2;</code>
     * @return string
     */
    public function getEntityTypeBatchUri()
    {
        return $this->readOneof(2);
    }

    public function hasEntityTypeBatchUri()
    {
        return $this->hasOneof(2);
    }

    /**
     * The URI to a Google Cloud Storage file containing entity types to update
     * or create. The file format can either be a serialized proto (of
     * EntityBatch type) or a JSON object. Note: The URI must start with
     * "gs://".
     *
     * Generated from protobuf field <code>string entity_type_batch_uri = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setEntityTypeBatchUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * The collection of entity types to update or create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.EntityTypeBatch entity_type_batch_inline = 3;</code>
     * @return \Google\Cloud\Dialogflow\V2\EntityTypeBatch|null
     */
    public function getEntityTypeBatchInline()
    {
        return $this->readOneof(3);
    }

    public function hasEntityTypeBatchInline()
    {
        return $this->hasOneof(3);
    }

    /**
     * The collection of entity types to update or create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.EntityTypeBatch entity_type_batch_inline = 3;</code>
     * @param \Google\Cloud\Dialogflow\V2\EntityTypeBatch $var
     * @return $this
     */
    public function setEntityTypeBatchInline($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\EntityTypeBatch::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * Optional. The language used to access language-specific data.
     * If not specified, the agent's default language is used.
     * For more information, see
     * [Multilingual intent and entity
     * data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
     *
     * Generated from protobuf field <code>string language_code = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getLanguageCode()
    {
        return $this->language_code;
    }

    /**
     * Optional. The language used to access language-specific data.
     * If not specified, the agent's default language is used.
     * For more information, see
     * [Multilingual intent and entity
     * data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
     *
     * Generated from protobuf field <code>string language_code = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setLanguageCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->language_code = $var;

        return $this;
    }

    /**
     * Optional. The mask to control which fields get updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * Optional. The mask to control which fields get updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getEntityTypeBatch()
    {
        return $this->whichOneof("entity_type_batch");
    }

}

