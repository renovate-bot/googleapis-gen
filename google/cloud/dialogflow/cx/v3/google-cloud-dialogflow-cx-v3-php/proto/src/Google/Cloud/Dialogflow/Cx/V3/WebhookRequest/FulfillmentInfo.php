<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/webhook.proto

namespace Google\Cloud\Dialogflow\Cx\V3\WebhookRequest;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents fulfillment information communicated to the webhook.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo</code>
 */
class FulfillmentInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Always present. The tag used to identify which fulfillment is being
     * called.
     *
     * Generated from protobuf field <code>string tag = 1;</code>
     */
    protected $tag = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $tag
     *           Always present. The tag used to identify which fulfillment is being
     *           called.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Webhook::initOnce();
        parent::__construct($data);
    }

    /**
     * Always present. The tag used to identify which fulfillment is being
     * called.
     *
     * Generated from protobuf field <code>string tag = 1;</code>
     * @return string
     */
    public function getTag()
    {
        return $this->tag;
    }

    /**
     * Always present. The tag used to identify which fulfillment is being
     * called.
     *
     * Generated from protobuf field <code>string tag = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setTag($var)
    {
        GPBUtil::checkString($var, True);
        $this->tag = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(FulfillmentInfo::class, \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest_FulfillmentInfo::class);

