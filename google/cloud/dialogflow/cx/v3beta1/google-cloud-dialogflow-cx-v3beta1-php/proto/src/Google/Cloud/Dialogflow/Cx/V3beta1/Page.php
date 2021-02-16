<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/page.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A Dialogflow CX conversation (session) can be described and visualized as a
 * state machine. The states of a CX session are represented by pages.
 * For each flow, you define many pages, where your combined pages can handle a
 * complete conversation on the topics the flow is designed for. At any given
 * moment, exactly one page is the current page, the current page is considered
 * active, and the flow associated with that page is considered active. Every
 * flow has a special start page. When a flow initially becomes active, the
 * start page page becomes the current page. For each conversational turn, the
 * current page will either stay the same or transition to another page.
 * You configure each page to collect information from the end-user that is
 * relevant for the conversational state represented by the page.
 * For more information, see the
 * [Page guide](https://cloud.google.com/dialogflow/cx/docs/concept/page).
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Page</code>
 */
class Page extends \Google\Protobuf\Internal\Message
{
    /**
     * The unique identifier of the page.
     * Required for the [Pages.UpdatePage][google.cloud.dialogflow.cx.v3beta1.Pages.UpdatePage] method. [Pages.CreatePage][google.cloud.dialogflow.cx.v3beta1.Pages.CreatePage]
     * populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Required. The human-readable name of the page, unique within the agent.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * The fulfillment to call when the session is entering the page.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Fulfillment entry_fulfillment = 7;</code>
     */
    protected $entry_fulfillment = null;
    /**
     * The form associated with the page, used for collecting parameters
     * relevant to the page.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Form form = 4;</code>
     */
    protected $form = null;
    /**
     * Ordered list of [`TransitionRouteGroups`][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] associated
     * with the page. Transition route groups must be unique within a page.
     * *   If multiple transition routes within a page scope refer to the same
     *     intent, then the precedence order is: page's transition route -> page's
     *     transition route group -> flow's transition routes.
     * *   If multiple transition route groups within a page contain the same
     *     intent, then the first group in the ordered list takes precedence.
     * Format:`projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/transitionRouteGroups/<TransitionRouteGroup ID>`.
     *
     * Generated from protobuf field <code>repeated string transition_route_groups = 11 [(.google.api.resource_reference) = {</code>
     */
    private $transition_route_groups;
    /**
     * A list of transitions for the transition rules of this page.
     * They route the conversation to another page in the same flow, or another
     * flow.
     * When we are in a certain page, the TransitionRoutes are evalauted in the
     * following order:
     * *   TransitionRoutes defined in the page with intent specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with intent
     *     specified.
     * *   TransitionRoutes defined in flow with intent specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Flow.transition_route_groups] with intent
     *     specified.
     * *   TransitionRoutes defined in the page with only condition specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with only
     *     condition specified.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.TransitionRoute transition_routes = 9;</code>
     */
    private $transition_routes;
    /**
     * Handlers associated with the page to handle events such as webhook errors,
     * no match or no input.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.EventHandler event_handlers = 10;</code>
     */
    private $event_handlers;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The unique identifier of the page.
     *           Required for the [Pages.UpdatePage][google.cloud.dialogflow.cx.v3beta1.Pages.UpdatePage] method. [Pages.CreatePage][google.cloud.dialogflow.cx.v3beta1.Pages.CreatePage]
     *           populates the name automatically.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>/pages/<Page ID>`.
     *     @type string $display_name
     *           Required. The human-readable name of the page, unique within the agent.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment $entry_fulfillment
     *           The fulfillment to call when the session is entering the page.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Form $form
     *           The form associated with the page, used for collecting parameters
     *           relevant to the page.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $transition_route_groups
     *           Ordered list of [`TransitionRouteGroups`][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] associated
     *           with the page. Transition route groups must be unique within a page.
     *           *   If multiple transition routes within a page scope refer to the same
     *               intent, then the precedence order is: page's transition route -> page's
     *               transition route group -> flow's transition routes.
     *           *   If multiple transition route groups within a page contain the same
     *               intent, then the first group in the ordered list takes precedence.
     *           Format:`projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>/transitionRouteGroups/<TransitionRouteGroup ID>`.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRoute[]|\Google\Protobuf\Internal\RepeatedField $transition_routes
     *           A list of transitions for the transition rules of this page.
     *           They route the conversation to another page in the same flow, or another
     *           flow.
     *           When we are in a certain page, the TransitionRoutes are evalauted in the
     *           following order:
     *           *   TransitionRoutes defined in the page with intent specified.
     *           *   TransitionRoutes defined in the
     *               [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with intent
     *               specified.
     *           *   TransitionRoutes defined in flow with intent specified.
     *           *   TransitionRoutes defined in the
     *               [transition route groups][google.cloud.dialogflow.cx.v3beta1.Flow.transition_route_groups] with intent
     *               specified.
     *           *   TransitionRoutes defined in the page with only condition specified.
     *           *   TransitionRoutes defined in the
     *               [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with only
     *               condition specified.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\EventHandler[]|\Google\Protobuf\Internal\RepeatedField $event_handlers
     *           Handlers associated with the page to handle events such as webhook errors,
     *           no match or no input.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Page::initOnce();
        parent::__construct($data);
    }

    /**
     * The unique identifier of the page.
     * Required for the [Pages.UpdatePage][google.cloud.dialogflow.cx.v3beta1.Pages.UpdatePage] method. [Pages.CreatePage][google.cloud.dialogflow.cx.v3beta1.Pages.CreatePage]
     * populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The unique identifier of the page.
     * Required for the [Pages.UpdatePage][google.cloud.dialogflow.cx.v3beta1.Pages.UpdatePage] method. [Pages.CreatePage][google.cloud.dialogflow.cx.v3beta1.Pages.CreatePage]
     * populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
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
     * Required. The human-readable name of the page, unique within the agent.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the page, unique within the agent.
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
     * The fulfillment to call when the session is entering the page.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Fulfillment entry_fulfillment = 7;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment
     */
    public function getEntryFulfillment()
    {
        return isset($this->entry_fulfillment) ? $this->entry_fulfillment : null;
    }

    public function hasEntryFulfillment()
    {
        return isset($this->entry_fulfillment);
    }

    public function clearEntryFulfillment()
    {
        unset($this->entry_fulfillment);
    }

    /**
     * The fulfillment to call when the session is entering the page.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Fulfillment entry_fulfillment = 7;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment $var
     * @return $this
     */
    public function setEntryFulfillment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment::class);
        $this->entry_fulfillment = $var;

        return $this;
    }

    /**
     * The form associated with the page, used for collecting parameters
     * relevant to the page.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Form form = 4;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Form
     */
    public function getForm()
    {
        return isset($this->form) ? $this->form : null;
    }

    public function hasForm()
    {
        return isset($this->form);
    }

    public function clearForm()
    {
        unset($this->form);
    }

    /**
     * The form associated with the page, used for collecting parameters
     * relevant to the page.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Form form = 4;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Form $var
     * @return $this
     */
    public function setForm($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Form::class);
        $this->form = $var;

        return $this;
    }

    /**
     * Ordered list of [`TransitionRouteGroups`][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] associated
     * with the page. Transition route groups must be unique within a page.
     * *   If multiple transition routes within a page scope refer to the same
     *     intent, then the precedence order is: page's transition route -> page's
     *     transition route group -> flow's transition routes.
     * *   If multiple transition route groups within a page contain the same
     *     intent, then the first group in the ordered list takes precedence.
     * Format:`projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/transitionRouteGroups/<TransitionRouteGroup ID>`.
     *
     * Generated from protobuf field <code>repeated string transition_route_groups = 11 [(.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTransitionRouteGroups()
    {
        return $this->transition_route_groups;
    }

    /**
     * Ordered list of [`TransitionRouteGroups`][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] associated
     * with the page. Transition route groups must be unique within a page.
     * *   If multiple transition routes within a page scope refer to the same
     *     intent, then the precedence order is: page's transition route -> page's
     *     transition route group -> flow's transition routes.
     * *   If multiple transition route groups within a page contain the same
     *     intent, then the first group in the ordered list takes precedence.
     * Format:`projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/transitionRouteGroups/<TransitionRouteGroup ID>`.
     *
     * Generated from protobuf field <code>repeated string transition_route_groups = 11 [(.google.api.resource_reference) = {</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTransitionRouteGroups($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->transition_route_groups = $arr;

        return $this;
    }

    /**
     * A list of transitions for the transition rules of this page.
     * They route the conversation to another page in the same flow, or another
     * flow.
     * When we are in a certain page, the TransitionRoutes are evalauted in the
     * following order:
     * *   TransitionRoutes defined in the page with intent specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with intent
     *     specified.
     * *   TransitionRoutes defined in flow with intent specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Flow.transition_route_groups] with intent
     *     specified.
     * *   TransitionRoutes defined in the page with only condition specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with only
     *     condition specified.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.TransitionRoute transition_routes = 9;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTransitionRoutes()
    {
        return $this->transition_routes;
    }

    /**
     * A list of transitions for the transition rules of this page.
     * They route the conversation to another page in the same flow, or another
     * flow.
     * When we are in a certain page, the TransitionRoutes are evalauted in the
     * following order:
     * *   TransitionRoutes defined in the page with intent specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with intent
     *     specified.
     * *   TransitionRoutes defined in flow with intent specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Flow.transition_route_groups] with intent
     *     specified.
     * *   TransitionRoutes defined in the page with only condition specified.
     * *   TransitionRoutes defined in the
     *     [transition route groups][google.cloud.dialogflow.cx.v3beta1.Page.transition_route_groups] with only
     *     condition specified.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.TransitionRoute transition_routes = 9;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRoute[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTransitionRoutes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRoute::class);
        $this->transition_routes = $arr;

        return $this;
    }

    /**
     * Handlers associated with the page to handle events such as webhook errors,
     * no match or no input.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.EventHandler event_handlers = 10;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getEventHandlers()
    {
        return $this->event_handlers;
    }

    /**
     * Handlers associated with the page to handle events such as webhook errors,
     * no match or no input.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.EventHandler event_handlers = 10;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\EventHandler[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setEventHandlers($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\EventHandler::class);
        $this->event_handlers = $arr;

        return $this;
    }

}

