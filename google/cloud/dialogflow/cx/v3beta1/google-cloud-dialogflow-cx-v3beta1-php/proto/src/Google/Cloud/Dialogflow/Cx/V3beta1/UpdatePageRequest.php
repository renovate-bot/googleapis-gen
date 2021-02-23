<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/page.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Pages.UpdatePage][google.cloud.dialogflow.cx.v3beta1.Pages.UpdatePage].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.UpdatePageRequest</code>
 */
class UpdatePageRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The page to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Page page = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $page = null;
    /**
     * The language of the following fields in `page`:
     * *  `Page.entry_fulfillment.messages`
     * *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     * *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     * *  `Page.transition_routes.trigger_fulfillment.messages`
     * *
     * `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Page $page
     *           Required. The page to update.
     *     @type string $language_code
     *           The language of the following fields in `page`:
     *           *  `Page.entry_fulfillment.messages`
     *           *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     *           *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     *           *  `Page.transition_routes.trigger_fulfillment.messages`
     *           *
     *           `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Page::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The page to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Page page = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Page
     */
    public function getPage()
    {
        return isset($this->page) ? $this->page : null;
    }

    public function hasPage()
    {
        return isset($this->page);
    }

    public function clearPage()
    {
        unset($this->page);
    }

    /**
     * Required. The page to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Page page = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Page $var
     * @return $this
     */
    public function setPage($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Page::class);
        $this->page = $var;

        return $this;
    }

    /**
     * The language of the following fields in `page`:
     * *  `Page.entry_fulfillment.messages`
     * *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     * *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     * *  `Page.transition_routes.trigger_fulfillment.messages`
     * *
     * `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
     * The language of the following fields in `page`:
     * *  `Page.entry_fulfillment.messages`
     * *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     * *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     * *  `Page.transition_routes.trigger_fulfillment.messages`
     * *
     * `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
     * @return \Google\Protobuf\FieldMask
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

