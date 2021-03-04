<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/conversation.proto

namespace Google\Cloud\Dialogflow\V2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Conversations.ListMessages][google.cloud.dialogflow.v2beta1.Conversations.ListMessages].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2beta1.ListMessagesRequest</code>
 */
class ListMessagesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the conversation to list messages for.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/conversations/<Conversation ID>`
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Optional. Filter on message fields. Currently predicates on `create_time`
     * and `create_time_epoch_microseconds` are supported. `create_time` only
     * support milliseconds accuracy. E.g.,
     * `create_time_epoch_microseconds > 1551790877964485` or
     * `create_time > 2017-01-15T01:30:15.01Z`.
     * For more information about filtering, see
     * [API Filtering](https://aip.dev/160).
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     */
    protected $filter = '';
    /**
     * Optional. The maximum number of items to return in a single page. By
     * default 100 and at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * Optional. The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     */
    protected $page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the conversation to list messages for.
     *           Format: `projects/<Project ID>/locations/<Location
     *           ID>/conversations/<Conversation ID>`
     *     @type string $filter
     *           Optional. Filter on message fields. Currently predicates on `create_time`
     *           and `create_time_epoch_microseconds` are supported. `create_time` only
     *           support milliseconds accuracy. E.g.,
     *           `create_time_epoch_microseconds > 1551790877964485` or
     *           `create_time > 2017-01-15T01:30:15.01Z`.
     *           For more information about filtering, see
     *           [API Filtering](https://aip.dev/160).
     *     @type int $page_size
     *           Optional. The maximum number of items to return in a single page. By
     *           default 100 and at most 1000.
     *     @type string $page_token
     *           Optional. The next_page_token value returned from a previous list request.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Conversation::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the conversation to list messages for.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/conversations/<Conversation ID>`
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the conversation to list messages for.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/conversations/<Conversation ID>`
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
     * Optional. Filter on message fields. Currently predicates on `create_time`
     * and `create_time_epoch_microseconds` are supported. `create_time` only
     * support milliseconds accuracy. E.g.,
     * `create_time_epoch_microseconds > 1551790877964485` or
     * `create_time > 2017-01-15T01:30:15.01Z`.
     * For more information about filtering, see
     * [API Filtering](https://aip.dev/160).
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * Optional. Filter on message fields. Currently predicates on `create_time`
     * and `create_time_epoch_microseconds` are supported. `create_time` only
     * support milliseconds accuracy. E.g.,
     * `create_time_epoch_microseconds > 1551790877964485` or
     * `create_time > 2017-01-15T01:30:15.01Z`.
     * For more information about filtering, see
     * [API Filtering](https://aip.dev/160).
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

    /**
     * Optional. The maximum number of items to return in a single page. By
     * default 100 and at most 1000.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Optional. The maximum number of items to return in a single page. By
     * default 100 and at most 1000.
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
     * Optional. The next_page_token value returned from a previous list request.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * Optional. The next_page_token value returned from a previous list request.
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

}

