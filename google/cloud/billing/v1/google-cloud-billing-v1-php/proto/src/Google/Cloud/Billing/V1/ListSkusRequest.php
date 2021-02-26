<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/billing/v1/cloud_catalog.proto

namespace Google\Cloud\Billing\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for `ListSkus`.
 *
 * Generated from protobuf message <code>google.cloud.billing.v1.ListSkusRequest</code>
 */
class ListSkusRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the service.
     * Example: "services/DA34-426B-A397"
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Optional inclusive start time of the time range for which the pricing
     * versions will be returned. Timestamps in the future are not allowed.
     * The time range has to be within a single calendar month in
     * America/Los_Angeles timezone. Time range as a whole is optional. If not
     * specified, the latest pricing will be returned (up to 12 hours old at
     * most).
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2;</code>
     */
    protected $start_time = null;
    /**
     * Optional exclusive end time of the time range for which the pricing
     * versions will be returned. Timestamps in the future are not allowed.
     * The time range has to be within a single calendar month in
     * America/Los_Angeles timezone. Time range as a whole is optional. If not
     * specified, the latest pricing will be returned (up to 12 hours old at
     * most).
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 3;</code>
     */
    protected $end_time = null;
    /**
     * The ISO 4217 currency code for the pricing info in the response proto.
     * Will use the conversion rate as of start_time.
     * Optional. If not specified USD will be used.
     *
     * Generated from protobuf field <code>string currency_code = 4;</code>
     */
    protected $currency_code = '';
    /**
     * Requested page size. Defaults to 5000.
     *
     * Generated from protobuf field <code>int32 page_size = 5;</code>
     */
    protected $page_size = 0;
    /**
     * A token identifying a page of results to return. This should be a
     * `next_page_token` value returned from a previous `ListSkus`
     * call. If unspecified, the first page of results is returned.
     *
     * Generated from protobuf field <code>string page_token = 6;</code>
     */
    protected $page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the service.
     *           Example: "services/DA34-426B-A397"
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Optional inclusive start time of the time range for which the pricing
     *           versions will be returned. Timestamps in the future are not allowed.
     *           The time range has to be within a single calendar month in
     *           America/Los_Angeles timezone. Time range as a whole is optional. If not
     *           specified, the latest pricing will be returned (up to 12 hours old at
     *           most).
     *     @type \Google\Protobuf\Timestamp $end_time
     *           Optional exclusive end time of the time range for which the pricing
     *           versions will be returned. Timestamps in the future are not allowed.
     *           The time range has to be within a single calendar month in
     *           America/Los_Angeles timezone. Time range as a whole is optional. If not
     *           specified, the latest pricing will be returned (up to 12 hours old at
     *           most).
     *     @type string $currency_code
     *           The ISO 4217 currency code for the pricing info in the response proto.
     *           Will use the conversion rate as of start_time.
     *           Optional. If not specified USD will be used.
     *     @type int $page_size
     *           Requested page size. Defaults to 5000.
     *     @type string $page_token
     *           A token identifying a page of results to return. This should be a
     *           `next_page_token` value returned from a previous `ListSkus`
     *           call. If unspecified, the first page of results is returned.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Billing\V1\CloudCatalog::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the service.
     * Example: "services/DA34-426B-A397"
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the service.
     * Example: "services/DA34-426B-A397"
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
     * Optional inclusive start time of the time range for which the pricing
     * versions will be returned. Timestamps in the future are not allowed.
     * The time range has to be within a single calendar month in
     * America/Los_Angeles timezone. Time range as a whole is optional. If not
     * specified, the latest pricing will be returned (up to 12 hours old at
     * most).
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getStartTime()
    {
        return isset($this->start_time) ? $this->start_time : null;
    }

    public function hasStartTime()
    {
        return isset($this->start_time);
    }

    public function clearStartTime()
    {
        unset($this->start_time);
    }

    /**
     * Optional inclusive start time of the time range for which the pricing
     * versions will be returned. Timestamps in the future are not allowed.
     * The time range has to be within a single calendar month in
     * America/Los_Angeles timezone. Time range as a whole is optional. If not
     * specified, the latest pricing will be returned (up to 12 hours old at
     * most).
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setStartTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->start_time = $var;

        return $this;
    }

    /**
     * Optional exclusive end time of the time range for which the pricing
     * versions will be returned. Timestamps in the future are not allowed.
     * The time range has to be within a single calendar month in
     * America/Los_Angeles timezone. Time range as a whole is optional. If not
     * specified, the latest pricing will be returned (up to 12 hours old at
     * most).
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 3;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getEndTime()
    {
        return isset($this->end_time) ? $this->end_time : null;
    }

    public function hasEndTime()
    {
        return isset($this->end_time);
    }

    public function clearEndTime()
    {
        unset($this->end_time);
    }

    /**
     * Optional exclusive end time of the time range for which the pricing
     * versions will be returned. Timestamps in the future are not allowed.
     * The time range has to be within a single calendar month in
     * America/Los_Angeles timezone. Time range as a whole is optional. If not
     * specified, the latest pricing will be returned (up to 12 hours old at
     * most).
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEndTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->end_time = $var;

        return $this;
    }

    /**
     * The ISO 4217 currency code for the pricing info in the response proto.
     * Will use the conversion rate as of start_time.
     * Optional. If not specified USD will be used.
     *
     * Generated from protobuf field <code>string currency_code = 4;</code>
     * @return string
     */
    public function getCurrencyCode()
    {
        return $this->currency_code;
    }

    /**
     * The ISO 4217 currency code for the pricing info in the response proto.
     * Will use the conversion rate as of start_time.
     * Optional. If not specified USD will be used.
     *
     * Generated from protobuf field <code>string currency_code = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setCurrencyCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->currency_code = $var;

        return $this;
    }

    /**
     * Requested page size. Defaults to 5000.
     *
     * Generated from protobuf field <code>int32 page_size = 5;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Requested page size. Defaults to 5000.
     *
     * Generated from protobuf field <code>int32 page_size = 5;</code>
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
     * A token identifying a page of results to return. This should be a
     * `next_page_token` value returned from a previous `ListSkus`
     * call. If unspecified, the first page of results is returned.
     *
     * Generated from protobuf field <code>string page_token = 6;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * A token identifying a page of results to return. This should be a
     * `next_page_token` value returned from a previous `ListSkus`
     * call. If unspecified, the first page of results is returned.
     *
     * Generated from protobuf field <code>string page_token = 6;</code>
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

