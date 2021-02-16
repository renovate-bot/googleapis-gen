<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/transition_route_group.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TransitionRouteGroups.ListTransitionRouteGroups][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups.ListTransitionRouteGroups].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.ListTransitionRouteGroupsRequest</code>
 */
class ListTransitionRouteGroupsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The flow to list all transition route groups for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * The maximum number of items to return in a single page. By default 100 and
     * at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     */
    protected $page_token = '';
    /**
     * The language to list transition route groups for. The field
     * [`messages`][TransitionRoute.trigger_fulfillment.messages] in
     * [TransitionRoute][google.cloud.dialogflow.cx.v3beta1.TransitionRoute] is language dependent.
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 4;</code>
     */
    protected $language_code = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The flow to list all transition route groups for.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>`.
     *     @type int $page_size
     *           The maximum number of items to return in a single page. By default 100 and
     *           at most 1000.
     *     @type string $page_token
     *           The next_page_token value returned from a previous list request.
     *     @type string $language_code
     *           The language to list transition route groups for. The field
     *           [`messages`][TransitionRoute.trigger_fulfillment.messages] in
     *           [TransitionRoute][google.cloud.dialogflow.cx.v3beta1.TransitionRoute] is language dependent.
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\TransitionRouteGroup::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The flow to list all transition route groups for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The flow to list all transition route groups for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
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
     * The maximum number of items to return in a single page. By default 100 and
     * at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * The maximum number of items to return in a single page. By default 100 and
     * at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setPageSize($var)
    {
        GPBUtil::checkInt32($var);
        $this->page_size = $var;

        return $this;
    }

    /**
     * The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->page_token = $var;

        return $this;
    }

    /**
     * The language to list transition route groups for. The field
     * [`messages`][TransitionRoute.trigger_fulfillment.messages] in
     * [TransitionRoute][google.cloud.dialogflow.cx.v3beta1.TransitionRoute] is language dependent.
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 4;</code>
     * @return string
     */
    public function getLanguageCode()
    {
        return $this->language_code;
    }

    /**
     * The language to list transition route groups for. The field
     * [`messages`][TransitionRoute.trigger_fulfillment.messages] in
     * [TransitionRoute][google.cloud.dialogflow.cx.v3beta1.TransitionRoute] is language dependent.
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 4;</code>
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

