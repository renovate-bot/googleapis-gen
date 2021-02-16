<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/intent.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1\Intent\TrainingPhrase;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents a part of a training phrase.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Intent.TrainingPhrase.Part</code>
 */
class Part extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The text for this part.
     *
     * Generated from protobuf field <code>string text = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $text = '';
    /**
     * The [parameter][google.cloud.dialogflow.cx.v3beta1.Intent.Parameter] used to annotate this part of the
     * training phrase. This field is required for annotated parts of the
     * training phrase.
     *
     * Generated from protobuf field <code>string parameter_id = 2;</code>
     */
    protected $parameter_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $text
     *           Required. The text for this part.
     *     @type string $parameter_id
     *           The [parameter][google.cloud.dialogflow.cx.v3beta1.Intent.Parameter] used to annotate this part of the
     *           training phrase. This field is required for annotated parts of the
     *           training phrase.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Intent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The text for this part.
     *
     * Generated from protobuf field <code>string text = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getText()
    {
        return $this->text;
    }

    /**
     * Required. The text for this part.
     *
     * Generated from protobuf field <code>string text = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setText($var)
    {
        GPBUtil::checkString($var, True);
        $this->text = $var;

        return $this;
    }

    /**
     * The [parameter][google.cloud.dialogflow.cx.v3beta1.Intent.Parameter] used to annotate this part of the
     * training phrase. This field is required for annotated parts of the
     * training phrase.
     *
     * Generated from protobuf field <code>string parameter_id = 2;</code>
     * @return string
     */
    public function getParameterId()
    {
        return $this->parameter_id;
    }

    /**
     * The [parameter][google.cloud.dialogflow.cx.v3beta1.Intent.Parameter] used to annotate this part of the
     * training phrase. This field is required for annotated parts of the
     * training phrase.
     *
     * Generated from protobuf field <code>string parameter_id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setParameterId($var)
    {
        GPBUtil::checkString($var, True);
        $this->parameter_id = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Part::class, \Google\Cloud\Dialogflow\Cx\V3beta1\Intent_TrainingPhrase_Part::class);

