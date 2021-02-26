<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/intent.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Intents.UpdateIntent][google.cloud.dialogflow.cx.v3.Intents.UpdateIntent].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.UpdateIntentRequest</code>
 */
class UpdateIntentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The intent to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Intent intent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $intent = null;
    /**
     * The language of the following fields in `intent`:
     * *   `Intent.training_phrases.parts.text`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 2;</code>
     */
    protected $language_code = '';
    /**
     * The mask to control which fields get updated. If the mask is not present,
     * all fields will be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3;</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\Intent $intent
     *           Required. The intent to update.
     *     @type string $language_code
     *           The language of the following fields in `intent`:
     *           *   `Intent.training_phrases.parts.text`
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           The mask to control which fields get updated. If the mask is not present,
     *           all fields will be updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Intent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The intent to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Intent intent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\Intent|null
     */
    public function getIntent()
    {
        return isset($this->intent) ? $this->intent : null;
    }

    public function hasIntent()
    {
        return isset($this->intent);
    }

    public function clearIntent()
    {
        unset($this->intent);
    }

    /**
     * Required. The intent to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Intent intent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\Intent $var
     * @return $this
     */
    public function setIntent($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\Intent::class);
        $this->intent = $var;

        return $this;
    }

    /**
     * The language of the following fields in `intent`:
     * *   `Intent.training_phrases.parts.text`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 2;</code>
     * @return string
     */
    public function getLanguageCode()
    {
        return $this->language_code;
    }

    /**
     * The language of the following fields in `intent`:
     * *   `Intent.training_phrases.parts.text`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 2;</code>
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
     * The mask to control which fields get updated. If the mask is not present,
     * all fields will be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3;</code>
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
     * The mask to control which fields get updated. If the mask is not present,
     * all fields will be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

