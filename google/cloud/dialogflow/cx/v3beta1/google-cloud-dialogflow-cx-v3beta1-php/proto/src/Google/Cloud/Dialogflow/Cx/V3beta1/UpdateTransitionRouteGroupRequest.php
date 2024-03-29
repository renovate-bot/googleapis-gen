<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/transition_route_group.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TransitionRouteGroups.UpdateTransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups.UpdateTransitionRouteGroup].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.UpdateTransitionRouteGroupRequest</code>
 */
class UpdateTransitionRouteGroupRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The transition route group to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup transition_route_group = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $transition_route_group = null;
    /**
     * The mask to control which fields get updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    protected $update_mask = null;
    /**
     * The language of the following fields in `TransitionRouteGroup`:
     * *  `TransitionRouteGroup.transition_routes.trigger_fulfillment.messages`
     * *
     * `TransitionRouteGroup.transition_routes.trigger_fulfillment.conditional_cases`
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
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup $transition_route_group
     *           Required. The transition route group to update.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           The mask to control which fields get updated.
     *     @type string $language_code
     *           The language of the following fields in `TransitionRouteGroup`:
     *           *  `TransitionRouteGroup.transition_routes.trigger_fulfillment.messages`
     *           *
     *           `TransitionRouteGroup.transition_routes.trigger_fulfillment.conditional_cases`
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\TransitionRouteGroup::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The transition route group to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup transition_route_group = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup|null
     */
    public function getTransitionRouteGroup()
    {
        return $this->transition_route_group;
    }

    public function hasTransitionRouteGroup()
    {
        return isset($this->transition_route_group);
    }

    public function clearTransitionRouteGroup()
    {
        unset($this->transition_route_group);
    }

    /**
     * Required. The transition route group to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup transition_route_group = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup $var
     * @return $this
     */
    public function setTransitionRouteGroup($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup::class);
        $this->transition_route_group = $var;

        return $this;
    }

    /**
     * The mask to control which fields get updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return $this->update_mask;
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
     * The mask to control which fields get updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
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
     * The language of the following fields in `TransitionRouteGroup`:
     * *  `TransitionRouteGroup.transition_routes.trigger_fulfillment.messages`
     * *
     * `TransitionRouteGroup.transition_routes.trigger_fulfillment.conditional_cases`
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
     * The language of the following fields in `TransitionRouteGroup`:
     * *  `TransitionRouteGroup.transition_routes.trigger_fulfillment.messages`
     * *
     * `TransitionRouteGroup.transition_routes.trigger_fulfillment.conditional_cases`
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

