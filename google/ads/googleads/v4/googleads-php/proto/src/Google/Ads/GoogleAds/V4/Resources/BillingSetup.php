<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/billing_setup.proto

namespace Google\Ads\GoogleAds\V4\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A billing setup, which associates a payments account and an advertiser. A
 * billing setup is specific to one advertiser.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.BillingSetup</code>
 */
class BillingSetup extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the billing setup.
     * BillingSetup resource names have the form:
     * `customers/{customer_id}/billingSetups/{billing_setup_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * Output only. The ID of the billing setup.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $id = null;
    /**
     * Output only. The status of the billing setup.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.BillingSetupStatusEnum.BillingSetupStatus status = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $status = 0;
    /**
     * Immutable. The resource name of the payments account associated with this billing
     * setup. Payments resource names have the form:
     * `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
     * When setting up billing, this is used to signup with an existing payments
     * account (and then payments_account_info should not be set).
     * When getting a billing setup, this and payments_account_info will be
     * populated.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue payments_account = 11 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $payments_account = null;
    /**
     * Immutable. The payments account information associated with this billing setup.
     * When setting up billing, this is used to signup with a new payments account
     * (and then payments_account should not be set).
     * When getting a billing setup, this and payments_account will be
     * populated.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.BillingSetup.PaymentsAccountInfo payments_account_info = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $payments_account_info = null;
    protected $start_time;
    protected $end_time;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The resource name of the billing setup.
     *           BillingSetup resource names have the form:
     *           `customers/{customer_id}/billingSetups/{billing_setup_id}`
     *     @type \Google\Protobuf\Int64Value $id
     *           Output only. The ID of the billing setup.
     *     @type int $status
     *           Output only. The status of the billing setup.
     *     @type \Google\Protobuf\StringValue $payments_account
     *           Immutable. The resource name of the payments account associated with this billing
     *           setup. Payments resource names have the form:
     *           `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
     *           When setting up billing, this is used to signup with an existing payments
     *           account (and then payments_account_info should not be set).
     *           When getting a billing setup, this and payments_account_info will be
     *           populated.
     *     @type \Google\Ads\GoogleAds\V4\Resources\BillingSetup\PaymentsAccountInfo $payments_account_info
     *           Immutable. The payments account information associated with this billing setup.
     *           When setting up billing, this is used to signup with a new payments account
     *           (and then payments_account should not be set).
     *           When getting a billing setup, this and payments_account will be
     *           populated.
     *     @type \Google\Protobuf\StringValue $start_date_time
     *           Immutable. The start date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format. Only a
     *           future time is allowed.
     *     @type int $start_time_type
     *           Immutable. The start time as a type. Only NOW is allowed.
     *     @type \Google\Protobuf\StringValue $end_date_time
     *           Output only. The end date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.
     *     @type int $end_time_type
     *           Output only. The end time as a type.  The only possible value is FOREVER.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\BillingSetup::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the billing setup.
     * BillingSetup resource names have the form:
     * `customers/{customer_id}/billingSetups/{billing_setup_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The resource name of the billing setup.
     * BillingSetup resource names have the form:
     * `customers/{customer_id}/billingSetups/{billing_setup_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setResourceName($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_name = $var;

        return $this;
    }

    /**
     * Output only. The ID of the billing setup.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getId()
    {
        return isset($this->id) ? $this->id : null;
    }

    public function hasId()
    {
        return isset($this->id);
    }

    public function clearId()
    {
        unset($this->id);
    }

    /**
     * Returns the unboxed value from <code>getId()</code>

     * Output only. The ID of the billing setup.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getIdUnwrapped()
    {
        return $this->readWrapperValue("id");
    }

    /**
     * Output only. The ID of the billing setup.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->id = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Output only. The ID of the billing setup.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setIdUnwrapped($var)
    {
        $this->writeWrapperValue("id", $var);
        return $this;}

    /**
     * Output only. The status of the billing setup.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.BillingSetupStatusEnum.BillingSetupStatus status = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getStatus()
    {
        return $this->status;
    }

    /**
     * Output only. The status of the billing setup.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.BillingSetupStatusEnum.BillingSetupStatus status = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\BillingSetupStatusEnum\BillingSetupStatus::class);
        $this->status = $var;

        return $this;
    }

    /**
     * Immutable. The resource name of the payments account associated with this billing
     * setup. Payments resource names have the form:
     * `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
     * When setting up billing, this is used to signup with an existing payments
     * account (and then payments_account_info should not be set).
     * When getting a billing setup, this and payments_account_info will be
     * populated.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue payments_account = 11 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getPaymentsAccount()
    {
        return isset($this->payments_account) ? $this->payments_account : null;
    }

    public function hasPaymentsAccount()
    {
        return isset($this->payments_account);
    }

    public function clearPaymentsAccount()
    {
        unset($this->payments_account);
    }

    /**
     * Returns the unboxed value from <code>getPaymentsAccount()</code>

     * Immutable. The resource name of the payments account associated with this billing
     * setup. Payments resource names have the form:
     * `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
     * When setting up billing, this is used to signup with an existing payments
     * account (and then payments_account_info should not be set).
     * When getting a billing setup, this and payments_account_info will be
     * populated.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue payments_account = 11 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string|null
     */
    public function getPaymentsAccountUnwrapped()
    {
        return $this->readWrapperValue("payments_account");
    }

    /**
     * Immutable. The resource name of the payments account associated with this billing
     * setup. Payments resource names have the form:
     * `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
     * When setting up billing, this is used to signup with an existing payments
     * account (and then payments_account_info should not be set).
     * When getting a billing setup, this and payments_account_info will be
     * populated.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue payments_account = 11 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setPaymentsAccount($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->payments_account = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Immutable. The resource name of the payments account associated with this billing
     * setup. Payments resource names have the form:
     * `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
     * When setting up billing, this is used to signup with an existing payments
     * account (and then payments_account_info should not be set).
     * When getting a billing setup, this and payments_account_info will be
     * populated.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue payments_account = 11 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string|null $var
     * @return $this
     */
    public function setPaymentsAccountUnwrapped($var)
    {
        $this->writeWrapperValue("payments_account", $var);
        return $this;}

    /**
     * Immutable. The payments account information associated with this billing setup.
     * When setting up billing, this is used to signup with a new payments account
     * (and then payments_account should not be set).
     * When getting a billing setup, this and payments_account will be
     * populated.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.BillingSetup.PaymentsAccountInfo payments_account_info = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Resources\BillingSetup\PaymentsAccountInfo|null
     */
    public function getPaymentsAccountInfo()
    {
        return isset($this->payments_account_info) ? $this->payments_account_info : null;
    }

    public function hasPaymentsAccountInfo()
    {
        return isset($this->payments_account_info);
    }

    public function clearPaymentsAccountInfo()
    {
        unset($this->payments_account_info);
    }

    /**
     * Immutable. The payments account information associated with this billing setup.
     * When setting up billing, this is used to signup with a new payments account
     * (and then payments_account should not be set).
     * When getting a billing setup, this and payments_account will be
     * populated.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.resources.BillingSetup.PaymentsAccountInfo payments_account_info = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Resources\BillingSetup\PaymentsAccountInfo $var
     * @return $this
     */
    public function setPaymentsAccountInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Resources\BillingSetup\PaymentsAccountInfo::class);
        $this->payments_account_info = $var;

        return $this;
    }

    /**
     * Immutable. The start date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format. Only a
     * future time is allowed.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue start_date_time = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getStartDateTime()
    {
        return $this->readOneof(9);
    }

    public function hasStartDateTime()
    {
        return $this->hasOneof(9);
    }

    /**
     * Returns the unboxed value from <code>getStartDateTime()</code>

     * Immutable. The start date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format. Only a
     * future time is allowed.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue start_date_time = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string|null
     */
    public function getStartDateTimeUnwrapped()
    {
        return $this->readWrapperValue("start_date_time");
    }

    /**
     * Immutable. The start date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format. Only a
     * future time is allowed.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue start_date_time = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setStartDateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->writeOneof(9, $var);

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Immutable. The start date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format. Only a
     * future time is allowed.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue start_date_time = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string|null $var
     * @return $this
     */
    public function setStartDateTimeUnwrapped($var)
    {
        $this->writeWrapperValue("start_date_time", $var);
        return $this;}

    /**
     * Immutable. The start time as a type. Only NOW is allowed.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType start_time_type = 10 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return int
     */
    public function getStartTimeType()
    {
        return $this->readOneof(10);
    }

    public function hasStartTimeType()
    {
        return $this->hasOneof(10);
    }

    /**
     * Immutable. The start time as a type. Only NOW is allowed.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType start_time_type = 10 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param int $var
     * @return $this
     */
    public function setStartTimeType($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\TimeTypeEnum\TimeType::class);
        $this->writeOneof(10, $var);

        return $this;
    }

    /**
     * Output only. The end date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue end_date_time = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getEndDateTime()
    {
        return $this->readOneof(13);
    }

    public function hasEndDateTime()
    {
        return $this->hasOneof(13);
    }

    /**
     * Returns the unboxed value from <code>getEndDateTime()</code>

     * Output only. The end date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue end_date_time = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string|null
     */
    public function getEndDateTimeUnwrapped()
    {
        return $this->readWrapperValue("end_date_time");
    }

    /**
     * Output only. The end date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue end_date_time = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setEndDateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->writeOneof(13, $var);

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Output only. The end date time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue end_date_time = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string|null $var
     * @return $this
     */
    public function setEndDateTimeUnwrapped($var)
    {
        $this->writeWrapperValue("end_date_time", $var);
        return $this;}

    /**
     * Output only. The end time as a type.  The only possible value is FOREVER.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType end_time_type = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getEndTimeType()
    {
        return $this->readOneof(14);
    }

    public function hasEndTimeType()
    {
        return $this->hasOneof(14);
    }

    /**
     * Output only. The end time as a type.  The only possible value is FOREVER.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType end_time_type = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setEndTimeType($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\TimeTypeEnum\TimeType::class);
        $this->writeOneof(14, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getStartTime()
    {
        return $this->whichOneof("start_time");
    }

    /**
     * @return string
     */
    public function getEndTime()
    {
        return $this->whichOneof("end_time");
    }

}

