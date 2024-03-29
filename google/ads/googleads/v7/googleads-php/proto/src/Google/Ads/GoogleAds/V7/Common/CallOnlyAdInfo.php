<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v7/common/ad_type_infos.proto

namespace Google\Ads\GoogleAds\V7\Common;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A call-only ad.
 *
 * Generated from protobuf message <code>google.ads.googleads.v7.common.CallOnlyAdInfo</code>
 */
class CallOnlyAdInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * The country code in the ad.
     *
     * Generated from protobuf field <code>optional string country_code = 13;</code>
     */
    protected $country_code = null;
    /**
     * The phone number in the ad.
     *
     * Generated from protobuf field <code>optional string phone_number = 14;</code>
     */
    protected $phone_number = null;
    /**
     * The business name in the ad.
     *
     * Generated from protobuf field <code>optional string business_name = 15;</code>
     */
    protected $business_name = null;
    /**
     * First headline in the ad.
     *
     * Generated from protobuf field <code>optional string headline1 = 16;</code>
     */
    protected $headline1 = null;
    /**
     * Second headline in the ad.
     *
     * Generated from protobuf field <code>optional string headline2 = 17;</code>
     */
    protected $headline2 = null;
    /**
     * The first line of the ad's description.
     *
     * Generated from protobuf field <code>optional string description1 = 18;</code>
     */
    protected $description1 = null;
    /**
     * The second line of the ad's description.
     *
     * Generated from protobuf field <code>optional string description2 = 19;</code>
     */
    protected $description2 = null;
    /**
     * Whether to enable call tracking for the creative. Enabling call
     * tracking also enables call conversions.
     *
     * Generated from protobuf field <code>optional bool call_tracked = 20;</code>
     */
    protected $call_tracked = null;
    /**
     * Whether to disable call conversion for the creative.
     * If set to `true`, disables call conversions even when `call_tracked` is
     * `true`.
     * If `call_tracked` is `false`, this field is ignored.
     *
     * Generated from protobuf field <code>optional bool disable_call_conversion = 21;</code>
     */
    protected $disable_call_conversion = null;
    /**
     * The URL to be used for phone number verification.
     *
     * Generated from protobuf field <code>optional string phone_number_verification_url = 22;</code>
     */
    protected $phone_number_verification_url = null;
    /**
     * The conversion action to attribute a call conversion to. If not set a
     * default conversion action is used. This field only has effect if
     * `call_tracked` is set to `true`. Otherwise this field is ignored.
     *
     * Generated from protobuf field <code>optional string conversion_action = 23;</code>
     */
    protected $conversion_action = null;
    /**
     * The call conversion behavior of this call only ad. It can use its own call
     * conversion setting, inherit the account level setting, or be disabled.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v7.enums.CallConversionReportingStateEnum.CallConversionReportingState conversion_reporting_state = 10;</code>
     */
    protected $conversion_reporting_state = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $country_code
     *           The country code in the ad.
     *     @type string $phone_number
     *           The phone number in the ad.
     *     @type string $business_name
     *           The business name in the ad.
     *     @type string $headline1
     *           First headline in the ad.
     *     @type string $headline2
     *           Second headline in the ad.
     *     @type string $description1
     *           The first line of the ad's description.
     *     @type string $description2
     *           The second line of the ad's description.
     *     @type bool $call_tracked
     *           Whether to enable call tracking for the creative. Enabling call
     *           tracking also enables call conversions.
     *     @type bool $disable_call_conversion
     *           Whether to disable call conversion for the creative.
     *           If set to `true`, disables call conversions even when `call_tracked` is
     *           `true`.
     *           If `call_tracked` is `false`, this field is ignored.
     *     @type string $phone_number_verification_url
     *           The URL to be used for phone number verification.
     *     @type string $conversion_action
     *           The conversion action to attribute a call conversion to. If not set a
     *           default conversion action is used. This field only has effect if
     *           `call_tracked` is set to `true`. Otherwise this field is ignored.
     *     @type int $conversion_reporting_state
     *           The call conversion behavior of this call only ad. It can use its own call
     *           conversion setting, inherit the account level setting, or be disabled.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V7\Common\AdTypeInfos::initOnce();
        parent::__construct($data);
    }

    /**
     * The country code in the ad.
     *
     * Generated from protobuf field <code>optional string country_code = 13;</code>
     * @return string
     */
    public function getCountryCode()
    {
        return isset($this->country_code) ? $this->country_code : '';
    }

    public function hasCountryCode()
    {
        return isset($this->country_code);
    }

    public function clearCountryCode()
    {
        unset($this->country_code);
    }

    /**
     * The country code in the ad.
     *
     * Generated from protobuf field <code>optional string country_code = 13;</code>
     * @param string $var
     * @return $this
     */
    public function setCountryCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->country_code = $var;

        return $this;
    }

    /**
     * The phone number in the ad.
     *
     * Generated from protobuf field <code>optional string phone_number = 14;</code>
     * @return string
     */
    public function getPhoneNumber()
    {
        return isset($this->phone_number) ? $this->phone_number : '';
    }

    public function hasPhoneNumber()
    {
        return isset($this->phone_number);
    }

    public function clearPhoneNumber()
    {
        unset($this->phone_number);
    }

    /**
     * The phone number in the ad.
     *
     * Generated from protobuf field <code>optional string phone_number = 14;</code>
     * @param string $var
     * @return $this
     */
    public function setPhoneNumber($var)
    {
        GPBUtil::checkString($var, True);
        $this->phone_number = $var;

        return $this;
    }

    /**
     * The business name in the ad.
     *
     * Generated from protobuf field <code>optional string business_name = 15;</code>
     * @return string
     */
    public function getBusinessName()
    {
        return isset($this->business_name) ? $this->business_name : '';
    }

    public function hasBusinessName()
    {
        return isset($this->business_name);
    }

    public function clearBusinessName()
    {
        unset($this->business_name);
    }

    /**
     * The business name in the ad.
     *
     * Generated from protobuf field <code>optional string business_name = 15;</code>
     * @param string $var
     * @return $this
     */
    public function setBusinessName($var)
    {
        GPBUtil::checkString($var, True);
        $this->business_name = $var;

        return $this;
    }

    /**
     * First headline in the ad.
     *
     * Generated from protobuf field <code>optional string headline1 = 16;</code>
     * @return string
     */
    public function getHeadline1()
    {
        return isset($this->headline1) ? $this->headline1 : '';
    }

    public function hasHeadline1()
    {
        return isset($this->headline1);
    }

    public function clearHeadline1()
    {
        unset($this->headline1);
    }

    /**
     * First headline in the ad.
     *
     * Generated from protobuf field <code>optional string headline1 = 16;</code>
     * @param string $var
     * @return $this
     */
    public function setHeadline1($var)
    {
        GPBUtil::checkString($var, True);
        $this->headline1 = $var;

        return $this;
    }

    /**
     * Second headline in the ad.
     *
     * Generated from protobuf field <code>optional string headline2 = 17;</code>
     * @return string
     */
    public function getHeadline2()
    {
        return isset($this->headline2) ? $this->headline2 : '';
    }

    public function hasHeadline2()
    {
        return isset($this->headline2);
    }

    public function clearHeadline2()
    {
        unset($this->headline2);
    }

    /**
     * Second headline in the ad.
     *
     * Generated from protobuf field <code>optional string headline2 = 17;</code>
     * @param string $var
     * @return $this
     */
    public function setHeadline2($var)
    {
        GPBUtil::checkString($var, True);
        $this->headline2 = $var;

        return $this;
    }

    /**
     * The first line of the ad's description.
     *
     * Generated from protobuf field <code>optional string description1 = 18;</code>
     * @return string
     */
    public function getDescription1()
    {
        return isset($this->description1) ? $this->description1 : '';
    }

    public function hasDescription1()
    {
        return isset($this->description1);
    }

    public function clearDescription1()
    {
        unset($this->description1);
    }

    /**
     * The first line of the ad's description.
     *
     * Generated from protobuf field <code>optional string description1 = 18;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription1($var)
    {
        GPBUtil::checkString($var, True);
        $this->description1 = $var;

        return $this;
    }

    /**
     * The second line of the ad's description.
     *
     * Generated from protobuf field <code>optional string description2 = 19;</code>
     * @return string
     */
    public function getDescription2()
    {
        return isset($this->description2) ? $this->description2 : '';
    }

    public function hasDescription2()
    {
        return isset($this->description2);
    }

    public function clearDescription2()
    {
        unset($this->description2);
    }

    /**
     * The second line of the ad's description.
     *
     * Generated from protobuf field <code>optional string description2 = 19;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription2($var)
    {
        GPBUtil::checkString($var, True);
        $this->description2 = $var;

        return $this;
    }

    /**
     * Whether to enable call tracking for the creative. Enabling call
     * tracking also enables call conversions.
     *
     * Generated from protobuf field <code>optional bool call_tracked = 20;</code>
     * @return bool
     */
    public function getCallTracked()
    {
        return isset($this->call_tracked) ? $this->call_tracked : false;
    }

    public function hasCallTracked()
    {
        return isset($this->call_tracked);
    }

    public function clearCallTracked()
    {
        unset($this->call_tracked);
    }

    /**
     * Whether to enable call tracking for the creative. Enabling call
     * tracking also enables call conversions.
     *
     * Generated from protobuf field <code>optional bool call_tracked = 20;</code>
     * @param bool $var
     * @return $this
     */
    public function setCallTracked($var)
    {
        GPBUtil::checkBool($var);
        $this->call_tracked = $var;

        return $this;
    }

    /**
     * Whether to disable call conversion for the creative.
     * If set to `true`, disables call conversions even when `call_tracked` is
     * `true`.
     * If `call_tracked` is `false`, this field is ignored.
     *
     * Generated from protobuf field <code>optional bool disable_call_conversion = 21;</code>
     * @return bool
     */
    public function getDisableCallConversion()
    {
        return isset($this->disable_call_conversion) ? $this->disable_call_conversion : false;
    }

    public function hasDisableCallConversion()
    {
        return isset($this->disable_call_conversion);
    }

    public function clearDisableCallConversion()
    {
        unset($this->disable_call_conversion);
    }

    /**
     * Whether to disable call conversion for the creative.
     * If set to `true`, disables call conversions even when `call_tracked` is
     * `true`.
     * If `call_tracked` is `false`, this field is ignored.
     *
     * Generated from protobuf field <code>optional bool disable_call_conversion = 21;</code>
     * @param bool $var
     * @return $this
     */
    public function setDisableCallConversion($var)
    {
        GPBUtil::checkBool($var);
        $this->disable_call_conversion = $var;

        return $this;
    }

    /**
     * The URL to be used for phone number verification.
     *
     * Generated from protobuf field <code>optional string phone_number_verification_url = 22;</code>
     * @return string
     */
    public function getPhoneNumberVerificationUrl()
    {
        return isset($this->phone_number_verification_url) ? $this->phone_number_verification_url : '';
    }

    public function hasPhoneNumberVerificationUrl()
    {
        return isset($this->phone_number_verification_url);
    }

    public function clearPhoneNumberVerificationUrl()
    {
        unset($this->phone_number_verification_url);
    }

    /**
     * The URL to be used for phone number verification.
     *
     * Generated from protobuf field <code>optional string phone_number_verification_url = 22;</code>
     * @param string $var
     * @return $this
     */
    public function setPhoneNumberVerificationUrl($var)
    {
        GPBUtil::checkString($var, True);
        $this->phone_number_verification_url = $var;

        return $this;
    }

    /**
     * The conversion action to attribute a call conversion to. If not set a
     * default conversion action is used. This field only has effect if
     * `call_tracked` is set to `true`. Otherwise this field is ignored.
     *
     * Generated from protobuf field <code>optional string conversion_action = 23;</code>
     * @return string
     */
    public function getConversionAction()
    {
        return isset($this->conversion_action) ? $this->conversion_action : '';
    }

    public function hasConversionAction()
    {
        return isset($this->conversion_action);
    }

    public function clearConversionAction()
    {
        unset($this->conversion_action);
    }

    /**
     * The conversion action to attribute a call conversion to. If not set a
     * default conversion action is used. This field only has effect if
     * `call_tracked` is set to `true`. Otherwise this field is ignored.
     *
     * Generated from protobuf field <code>optional string conversion_action = 23;</code>
     * @param string $var
     * @return $this
     */
    public function setConversionAction($var)
    {
        GPBUtil::checkString($var, True);
        $this->conversion_action = $var;

        return $this;
    }

    /**
     * The call conversion behavior of this call only ad. It can use its own call
     * conversion setting, inherit the account level setting, or be disabled.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v7.enums.CallConversionReportingStateEnum.CallConversionReportingState conversion_reporting_state = 10;</code>
     * @return int
     */
    public function getConversionReportingState()
    {
        return $this->conversion_reporting_state;
    }

    /**
     * The call conversion behavior of this call only ad. It can use its own call
     * conversion setting, inherit the account level setting, or be disabled.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v7.enums.CallConversionReportingStateEnum.CallConversionReportingState conversion_reporting_state = 10;</code>
     * @param int $var
     * @return $this
     */
    public function setConversionReportingState($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V7\Enums\CallConversionReportingStateEnum\CallConversionReportingState::class);
        $this->conversion_reporting_state = $var;

        return $this;
    }

}

