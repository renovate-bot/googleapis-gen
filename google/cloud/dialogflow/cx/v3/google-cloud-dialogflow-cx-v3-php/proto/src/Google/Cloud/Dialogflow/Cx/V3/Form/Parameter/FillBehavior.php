<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/page.proto

namespace Google\Cloud\Dialogflow\Cx\V3\Form\Parameter;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Configuration for how the filling of a parameter should be handled.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.Form.Parameter.FillBehavior</code>
 */
class FillBehavior extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The fulfillment to provide the initial prompt that the agent
     * can present to the user in order to fill the parameter.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Fulfillment initial_prompt_fulfillment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $initial_prompt_fulfillment = null;
    /**
     * The handlers for parameter-level events, used to provide reprompt for
     * the parameter or transition to a different page/flow. The supported
     * events are:
     * *   `sys.no-match-<N>`, where N can be from 1 to 6
     * *   `sys.no-match-default`
     * *   `sys.no-input-<N>`, where N can be from 1 to 6
     * *   `sys.no-input-default`
     * *   `sys.invalid-parameter`
     * `initial_prompt_fulfillment` provides the first prompt for the
     * parameter.
     * If the user's response does not fill the parameter, a
     * no-match/no-input event will be triggered, and the fulfillment
     * associated with the `sys.no-match-1`/`sys.no-input-1` handler (if
     * defined) will be called to provide a prompt. The
     * `sys.no-match-2`/`sys.no-input-2` handler (if defined) will respond to
     * the next no-match/no-input event, and so on.
     * A `sys.no-match-default` or `sys.no-input-default` handler will be used
     * to handle all following no-match/no-input events after all numbered
     * no-match/no-input handlers for the parameter are consumed.
     * A `sys.invalid-parameter` handler can be defined to handle the case
     * where the parameter values have been `invalidated` by webhook. For
     * example, if the user's response fill the parameter, however the
     * parameter was invalidated by webhook, the fulfillment associated with
     * the `sys.invalid-parameter` handler (if defined) will be called to
     * provide a prompt.
     * If the event handler for the corresponding event can't be found on the
     * parameter, `initial_prompt_fulfillment` will be re-prompted.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.EventHandler reprompt_event_handlers = 5;</code>
     */
    private $reprompt_event_handlers;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\Fulfillment $initial_prompt_fulfillment
     *           Required. The fulfillment to provide the initial prompt that the agent
     *           can present to the user in order to fill the parameter.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\EventHandler[]|\Google\Protobuf\Internal\RepeatedField $reprompt_event_handlers
     *           The handlers for parameter-level events, used to provide reprompt for
     *           the parameter or transition to a different page/flow. The supported
     *           events are:
     *           *   `sys.no-match-<N>`, where N can be from 1 to 6
     *           *   `sys.no-match-default`
     *           *   `sys.no-input-<N>`, where N can be from 1 to 6
     *           *   `sys.no-input-default`
     *           *   `sys.invalid-parameter`
     *           `initial_prompt_fulfillment` provides the first prompt for the
     *           parameter.
     *           If the user's response does not fill the parameter, a
     *           no-match/no-input event will be triggered, and the fulfillment
     *           associated with the `sys.no-match-1`/`sys.no-input-1` handler (if
     *           defined) will be called to provide a prompt. The
     *           `sys.no-match-2`/`sys.no-input-2` handler (if defined) will respond to
     *           the next no-match/no-input event, and so on.
     *           A `sys.no-match-default` or `sys.no-input-default` handler will be used
     *           to handle all following no-match/no-input events after all numbered
     *           no-match/no-input handlers for the parameter are consumed.
     *           A `sys.invalid-parameter` handler can be defined to handle the case
     *           where the parameter values have been `invalidated` by webhook. For
     *           example, if the user's response fill the parameter, however the
     *           parameter was invalidated by webhook, the fulfillment associated with
     *           the `sys.invalid-parameter` handler (if defined) will be called to
     *           provide a prompt.
     *           If the event handler for the corresponding event can't be found on the
     *           parameter, `initial_prompt_fulfillment` will be re-prompted.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Page::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The fulfillment to provide the initial prompt that the agent
     * can present to the user in order to fill the parameter.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Fulfillment initial_prompt_fulfillment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\Fulfillment|null
     */
    public function getInitialPromptFulfillment()
    {
        return isset($this->initial_prompt_fulfillment) ? $this->initial_prompt_fulfillment : null;
    }

    public function hasInitialPromptFulfillment()
    {
        return isset($this->initial_prompt_fulfillment);
    }

    public function clearInitialPromptFulfillment()
    {
        unset($this->initial_prompt_fulfillment);
    }

    /**
     * Required. The fulfillment to provide the initial prompt that the agent
     * can present to the user in order to fill the parameter.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Fulfillment initial_prompt_fulfillment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\Fulfillment $var
     * @return $this
     */
    public function setInitialPromptFulfillment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\Fulfillment::class);
        $this->initial_prompt_fulfillment = $var;

        return $this;
    }

    /**
     * The handlers for parameter-level events, used to provide reprompt for
     * the parameter or transition to a different page/flow. The supported
     * events are:
     * *   `sys.no-match-<N>`, where N can be from 1 to 6
     * *   `sys.no-match-default`
     * *   `sys.no-input-<N>`, where N can be from 1 to 6
     * *   `sys.no-input-default`
     * *   `sys.invalid-parameter`
     * `initial_prompt_fulfillment` provides the first prompt for the
     * parameter.
     * If the user's response does not fill the parameter, a
     * no-match/no-input event will be triggered, and the fulfillment
     * associated with the `sys.no-match-1`/`sys.no-input-1` handler (if
     * defined) will be called to provide a prompt. The
     * `sys.no-match-2`/`sys.no-input-2` handler (if defined) will respond to
     * the next no-match/no-input event, and so on.
     * A `sys.no-match-default` or `sys.no-input-default` handler will be used
     * to handle all following no-match/no-input events after all numbered
     * no-match/no-input handlers for the parameter are consumed.
     * A `sys.invalid-parameter` handler can be defined to handle the case
     * where the parameter values have been `invalidated` by webhook. For
     * example, if the user's response fill the parameter, however the
     * parameter was invalidated by webhook, the fulfillment associated with
     * the `sys.invalid-parameter` handler (if defined) will be called to
     * provide a prompt.
     * If the event handler for the corresponding event can't be found on the
     * parameter, `initial_prompt_fulfillment` will be re-prompted.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.EventHandler reprompt_event_handlers = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRepromptEventHandlers()
    {
        return $this->reprompt_event_handlers;
    }

    /**
     * The handlers for parameter-level events, used to provide reprompt for
     * the parameter or transition to a different page/flow. The supported
     * events are:
     * *   `sys.no-match-<N>`, where N can be from 1 to 6
     * *   `sys.no-match-default`
     * *   `sys.no-input-<N>`, where N can be from 1 to 6
     * *   `sys.no-input-default`
     * *   `sys.invalid-parameter`
     * `initial_prompt_fulfillment` provides the first prompt for the
     * parameter.
     * If the user's response does not fill the parameter, a
     * no-match/no-input event will be triggered, and the fulfillment
     * associated with the `sys.no-match-1`/`sys.no-input-1` handler (if
     * defined) will be called to provide a prompt. The
     * `sys.no-match-2`/`sys.no-input-2` handler (if defined) will respond to
     * the next no-match/no-input event, and so on.
     * A `sys.no-match-default` or `sys.no-input-default` handler will be used
     * to handle all following no-match/no-input events after all numbered
     * no-match/no-input handlers for the parameter are consumed.
     * A `sys.invalid-parameter` handler can be defined to handle the case
     * where the parameter values have been `invalidated` by webhook. For
     * example, if the user's response fill the parameter, however the
     * parameter was invalidated by webhook, the fulfillment associated with
     * the `sys.invalid-parameter` handler (if defined) will be called to
     * provide a prompt.
     * If the event handler for the corresponding event can't be found on the
     * parameter, `initial_prompt_fulfillment` will be re-prompted.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.EventHandler reprompt_event_handlers = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\EventHandler[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRepromptEventHandlers($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3\EventHandler::class);
        $this->reprompt_event_handlers = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(FillBehavior::class, \Google\Cloud\Dialogflow\Cx\V3\Form_Parameter_FillBehavior::class);

