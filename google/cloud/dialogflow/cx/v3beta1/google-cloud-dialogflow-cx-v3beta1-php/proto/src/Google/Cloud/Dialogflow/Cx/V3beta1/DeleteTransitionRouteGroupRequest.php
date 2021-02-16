<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/transition_route_group.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TransitionRouteGroups.DeleteTransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups.DeleteTransitionRouteGroup].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.DeleteTransitionRouteGroupRequest</code>
 */
class DeleteTransitionRouteGroupRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] to delete.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * This field has no effect for transition route group that no page is using.
     * If the transition route group is referenced by any page:
     * *  If `force` is set to false, an error will be returned with message
     *    indicating pages that reference the transition route group.
     * *  If `force` is set to true, Dialogflow will remove the transition route
     *    group, as well as any reference to it.
     *
     * Generated from protobuf field <code>bool force = 2;</code>
     */
    protected $force = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] to delete.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
     *     @type bool $force
     *           This field has no effect for transition route group that no page is using.
     *           If the transition route group is referenced by any page:
     *           *  If `force` is set to false, an error will be returned with message
     *              indicating pages that reference the transition route group.
     *           *  If `force` is set to true, Dialogflow will remove the transition route
     *              group, as well as any reference to it.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\TransitionRouteGroup::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] to delete.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] to delete.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * This field has no effect for transition route group that no page is using.
     * If the transition route group is referenced by any page:
     * *  If `force` is set to false, an error will be returned with message
     *    indicating pages that reference the transition route group.
     * *  If `force` is set to true, Dialogflow will remove the transition route
     *    group, as well as any reference to it.
     *
     * Generated from protobuf field <code>bool force = 2;</code>
     * @return bool
     */
    public function getForce()
    {
        return $this->force;
    }

    /**
     * This field has no effect for transition route group that no page is using.
     * If the transition route group is referenced by any page:
     * *  If `force` is set to false, an error will be returned with message
     *    indicating pages that reference the transition route group.
     * *  If `force` is set to true, Dialogflow will remove the transition route
     *    group, as well as any reference to it.
     *
     * Generated from protobuf field <code>bool force = 2;</code>
     * @param bool $var
     * @return $this
     */
    public function setForce($var)
    {
        GPBUtil::checkBool($var);
        $this->force = $var;

        return $this;
    }

}

