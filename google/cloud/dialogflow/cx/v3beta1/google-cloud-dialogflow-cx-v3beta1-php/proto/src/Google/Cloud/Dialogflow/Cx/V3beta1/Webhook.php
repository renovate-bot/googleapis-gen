<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/webhook.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Webhooks host the developer's business logic. During a session, webhooks
 * allow the developer to use the data extracted by Dialogflow's natural
 * language processing to generate dynamic responses, validate collected data,
 * or trigger actions on the backend.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Webhook</code>
 */
class Webhook extends \Google\Protobuf\Internal\Message
{
    /**
     * The unique identifier of the webhook.
     * Required for the [Webhooks.UpdateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.UpdateWebhook] method.
     * [Webhooks.CreateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.CreateWebhook] populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/webhooks/<Webhook ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Required. The human-readable name of the webhook, unique within the agent.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * Webhook execution timeout. Execution is considered failed if Dialogflow
     * doesn't receive a response from webhook at the end of the timeout period.
     * Defaults to 5 seconds, maximum allowed timeout is 30 seconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration timeout = 6;</code>
     */
    protected $timeout = null;
    /**
     * Indicates whether the webhook is disabled.
     *
     * Generated from protobuf field <code>bool disabled = 5;</code>
     */
    protected $disabled = false;
    protected $webhook;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The unique identifier of the webhook.
     *           Required for the [Webhooks.UpdateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.UpdateWebhook] method.
     *           [Webhooks.CreateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.CreateWebhook] populates the name automatically.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/webhooks/<Webhook ID>`.
     *     @type string $display_name
     *           Required. The human-readable name of the webhook, unique within the agent.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Webhook\GenericWebService $generic_web_service
     *           Configuration for a generic web service.
     *     @type \Google\Protobuf\Duration $timeout
     *           Webhook execution timeout. Execution is considered failed if Dialogflow
     *           doesn't receive a response from webhook at the end of the timeout period.
     *           Defaults to 5 seconds, maximum allowed timeout is 30 seconds.
     *     @type bool $disabled
     *           Indicates whether the webhook is disabled.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Webhook::initOnce();
        parent::__construct($data);
    }

    /**
     * The unique identifier of the webhook.
     * Required for the [Webhooks.UpdateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.UpdateWebhook] method.
     * [Webhooks.CreateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.CreateWebhook] populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/webhooks/<Webhook ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The unique identifier of the webhook.
     * Required for the [Webhooks.UpdateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.UpdateWebhook] method.
     * [Webhooks.CreateWebhook][google.cloud.dialogflow.cx.v3beta1.Webhooks.CreateWebhook] populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/webhooks/<Webhook ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Required. The human-readable name of the webhook, unique within the agent.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the webhook, unique within the agent.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkString($var, True);
        $this->display_name = $var;

        return $this;
    }

    /**
     * Configuration for a generic web service.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Webhook.GenericWebService generic_web_service = 4;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Webhook\GenericWebService|null
     */
    public function getGenericWebService()
    {
        return $this->readOneof(4);
    }

    public function hasGenericWebService()
    {
        return $this->hasOneof(4);
    }

    /**
     * Configuration for a generic web service.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Webhook.GenericWebService generic_web_service = 4;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Webhook\GenericWebService $var
     * @return $this
     */
    public function setGenericWebService($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Webhook\GenericWebService::class);
        $this->writeOneof(4, $var);

        return $this;
    }

    /**
     * Webhook execution timeout. Execution is considered failed if Dialogflow
     * doesn't receive a response from webhook at the end of the timeout period.
     * Defaults to 5 seconds, maximum allowed timeout is 30 seconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration timeout = 6;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getTimeout()
    {
        return isset($this->timeout) ? $this->timeout : null;
    }

    public function hasTimeout()
    {
        return isset($this->timeout);
    }

    public function clearTimeout()
    {
        unset($this->timeout);
    }

    /**
     * Webhook execution timeout. Execution is considered failed if Dialogflow
     * doesn't receive a response from webhook at the end of the timeout period.
     * Defaults to 5 seconds, maximum allowed timeout is 30 seconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration timeout = 6;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setTimeout($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->timeout = $var;

        return $this;
    }

    /**
     * Indicates whether the webhook is disabled.
     *
     * Generated from protobuf field <code>bool disabled = 5;</code>
     * @return bool
     */
    public function getDisabled()
    {
        return $this->disabled;
    }

    /**
     * Indicates whether the webhook is disabled.
     *
     * Generated from protobuf field <code>bool disabled = 5;</code>
     * @param bool $var
     * @return $this
     */
    public function setDisabled($var)
    {
        GPBUtil::checkBool($var);
        $this->disabled = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getWebhook()
    {
        return $this->whichOneof("webhook");
    }

}

