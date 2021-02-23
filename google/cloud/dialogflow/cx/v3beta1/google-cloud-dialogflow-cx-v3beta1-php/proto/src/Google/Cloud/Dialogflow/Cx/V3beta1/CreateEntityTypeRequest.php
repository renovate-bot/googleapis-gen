<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/entity_type.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [EntityTypes.CreateEntityType][google.cloud.dialogflow.cx.v3beta1.EntityTypes.CreateEntityType].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.CreateEntityTypeRequest</code>
 */
class CreateEntityTypeRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The agent to create a entity type for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The entity type to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.EntityType entity_type = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $entity_type = null;
    /**
     * The language of the following fields in `entity_type`:
     * *   `EntityType.entities.value`
     * *   `EntityType.entities.synonyms`
     * *   `EntityType.excluded_phrases.value`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 3;</code>
     */
    protected $language_code = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The agent to create a entity type for.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\EntityType $entity_type
     *           Required. The entity type to create.
     *     @type string $language_code
     *           The language of the following fields in `entity_type`:
     *           *   `EntityType.entities.value`
     *           *   `EntityType.entities.synonyms`
     *           *   `EntityType.excluded_phrases.value`
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\EntityType::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The agent to create a entity type for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The agent to create a entity type for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
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
     * Required. The entity type to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.EntityType entity_type = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\EntityType
     */
    public function getEntityType()
    {
        return isset($this->entity_type) ? $this->entity_type : null;
    }

    public function hasEntityType()
    {
        return isset($this->entity_type);
    }

    public function clearEntityType()
    {
        unset($this->entity_type);
    }

    /**
     * Required. The entity type to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.EntityType entity_type = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\EntityType $var
     * @return $this
     */
    public function setEntityType($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\EntityType::class);
        $this->entity_type = $var;

        return $this;
    }

    /**
     * The language of the following fields in `entity_type`:
     * *   `EntityType.entities.value`
     * *   `EntityType.entities.synonyms`
     * *   `EntityType.excluded_phrases.value`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 3;</code>
     * @return string
     */
    public function getLanguageCode()
    {
        return $this->language_code;
    }

    /**
     * The language of the following fields in `entity_type`:
     * *   `EntityType.entities.value`
     * *   `EntityType.entities.synonyms`
     * *   `EntityType.excluded_phrases.value`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setLanguageCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->language_code = $var;

        return $this;
    }

}

