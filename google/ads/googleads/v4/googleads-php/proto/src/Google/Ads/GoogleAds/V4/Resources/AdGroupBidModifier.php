<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/ad_group_bid_modifier.proto

namespace Google\Ads\GoogleAds\V4\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents an ad group bid modifier.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.AdGroupBidModifier</code>
 */
class AdGroupBidModifier extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the ad group bid modifier.
     * Ad group bid modifier resource names have the form:
     * `customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * Immutable. The ad group to which this criterion belongs.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $ad_group = null;
    /**
     * Output only. The ID of the criterion to bid modify.
     * This field is ignored for mutates.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value criterion_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $criterion_id = null;
    /**
     * The modifier for the bid when the criterion matches. The modifier must be
     * in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
     * Use 0 to opt out of a Device type.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue bid_modifier = 4;</code>
     */
    protected $bid_modifier = null;
    /**
     * Output only. The base ad group from which this draft/trial adgroup bid modifier was
     * created. If ad_group is a base ad group then this field will be equal to
     * ad_group. If the ad group was created in the draft or trial and has no
     * corresponding base ad group, then this field will be null.
     * This field is readonly.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue base_ad_group = 9 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     */
    protected $base_ad_group = null;
    /**
     * Output only. Bid modifier source.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.BidModifierSourceEnum.BidModifierSource bid_modifier_source = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $bid_modifier_source = 0;
    protected $criterion;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The resource name of the ad group bid modifier.
     *           Ad group bid modifier resource names have the form:
     *           `customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}`
     *     @type \Google\Protobuf\StringValue $ad_group
     *           Immutable. The ad group to which this criterion belongs.
     *     @type \Google\Protobuf\Int64Value $criterion_id
     *           Output only. The ID of the criterion to bid modify.
     *           This field is ignored for mutates.
     *     @type \Google\Protobuf\DoubleValue $bid_modifier
     *           The modifier for the bid when the criterion matches. The modifier must be
     *           in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
     *           Use 0 to opt out of a Device type.
     *     @type \Google\Protobuf\StringValue $base_ad_group
     *           Output only. The base ad group from which this draft/trial adgroup bid modifier was
     *           created. If ad_group is a base ad group then this field will be equal to
     *           ad_group. If the ad group was created in the draft or trial and has no
     *           corresponding base ad group, then this field will be null.
     *           This field is readonly.
     *     @type int $bid_modifier_source
     *           Output only. Bid modifier source.
     *     @type \Google\Ads\GoogleAds\V4\Common\HotelDateSelectionTypeInfo $hotel_date_selection_type
     *           Immutable. Criterion for hotel date selection (default dates vs. user selected).
     *     @type \Google\Ads\GoogleAds\V4\Common\HotelAdvanceBookingWindowInfo $hotel_advance_booking_window
     *           Immutable. Criterion for number of days prior to the stay the booking is being made.
     *     @type \Google\Ads\GoogleAds\V4\Common\HotelLengthOfStayInfo $hotel_length_of_stay
     *           Immutable. Criterion for length of hotel stay in nights.
     *     @type \Google\Ads\GoogleAds\V4\Common\HotelCheckInDayInfo $hotel_check_in_day
     *           Immutable. Criterion for day of the week the booking is for.
     *     @type \Google\Ads\GoogleAds\V4\Common\DeviceInfo $device
     *           Immutable. A device criterion.
     *     @type \Google\Ads\GoogleAds\V4\Common\PreferredContentInfo $preferred_content
     *           Immutable. A preferred content criterion.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\AdGroupBidModifier::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the ad group bid modifier.
     * Ad group bid modifier resource names have the form:
     * `customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The resource name of the ad group bid modifier.
     * Ad group bid modifier resource names have the form:
     * `customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}`
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
     * Immutable. The ad group to which this criterion belongs.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getAdGroup()
    {
        return isset($this->ad_group) ? $this->ad_group : null;
    }

    public function hasAdGroup()
    {
        return isset($this->ad_group);
    }

    public function clearAdGroup()
    {
        unset($this->ad_group);
    }

    /**
     * Returns the unboxed value from <code>getAdGroup()</code>

     * Immutable. The ad group to which this criterion belongs.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string|null
     */
    public function getAdGroupUnwrapped()
    {
        return $this->readWrapperValue("ad_group");
    }

    /**
     * Immutable. The ad group to which this criterion belongs.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setAdGroup($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->ad_group = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Immutable. The ad group to which this criterion belongs.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string|null $var
     * @return $this
     */
    public function setAdGroupUnwrapped($var)
    {
        $this->writeWrapperValue("ad_group", $var);
        return $this;}

    /**
     * Output only. The ID of the criterion to bid modify.
     * This field is ignored for mutates.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value criterion_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getCriterionId()
    {
        return isset($this->criterion_id) ? $this->criterion_id : null;
    }

    public function hasCriterionId()
    {
        return isset($this->criterion_id);
    }

    public function clearCriterionId()
    {
        unset($this->criterion_id);
    }

    /**
     * Returns the unboxed value from <code>getCriterionId()</code>

     * Output only. The ID of the criterion to bid modify.
     * This field is ignored for mutates.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value criterion_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getCriterionIdUnwrapped()
    {
        return $this->readWrapperValue("criterion_id");
    }

    /**
     * Output only. The ID of the criterion to bid modify.
     * This field is ignored for mutates.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value criterion_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setCriterionId($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->criterion_id = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Output only. The ID of the criterion to bid modify.
     * This field is ignored for mutates.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value criterion_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setCriterionIdUnwrapped($var)
    {
        $this->writeWrapperValue("criterion_id", $var);
        return $this;}

    /**
     * The modifier for the bid when the criterion matches. The modifier must be
     * in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
     * Use 0 to opt out of a Device type.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue bid_modifier = 4;</code>
     * @return \Google\Protobuf\DoubleValue|null
     */
    public function getBidModifier()
    {
        return isset($this->bid_modifier) ? $this->bid_modifier : null;
    }

    public function hasBidModifier()
    {
        return isset($this->bid_modifier);
    }

    public function clearBidModifier()
    {
        unset($this->bid_modifier);
    }

    /**
     * Returns the unboxed value from <code>getBidModifier()</code>

     * The modifier for the bid when the criterion matches. The modifier must be
     * in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
     * Use 0 to opt out of a Device type.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue bid_modifier = 4;</code>
     * @return float|null
     */
    public function getBidModifierUnwrapped()
    {
        return $this->readWrapperValue("bid_modifier");
    }

    /**
     * The modifier for the bid when the criterion matches. The modifier must be
     * in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
     * Use 0 to opt out of a Device type.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue bid_modifier = 4;</code>
     * @param \Google\Protobuf\DoubleValue $var
     * @return $this
     */
    public function setBidModifier($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\DoubleValue::class);
        $this->bid_modifier = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\DoubleValue object.

     * The modifier for the bid when the criterion matches. The modifier must be
     * in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
     * Use 0 to opt out of a Device type.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue bid_modifier = 4;</code>
     * @param float|null $var
     * @return $this
     */
    public function setBidModifierUnwrapped($var)
    {
        $this->writeWrapperValue("bid_modifier", $var);
        return $this;}

    /**
     * Output only. The base ad group from which this draft/trial adgroup bid modifier was
     * created. If ad_group is a base ad group then this field will be equal to
     * ad_group. If the ad group was created in the draft or trial and has no
     * corresponding base ad group, then this field will be null.
     * This field is readonly.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue base_ad_group = 9 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getBaseAdGroup()
    {
        return isset($this->base_ad_group) ? $this->base_ad_group : null;
    }

    public function hasBaseAdGroup()
    {
        return isset($this->base_ad_group);
    }

    public function clearBaseAdGroup()
    {
        unset($this->base_ad_group);
    }

    /**
     * Returns the unboxed value from <code>getBaseAdGroup()</code>

     * Output only. The base ad group from which this draft/trial adgroup bid modifier was
     * created. If ad_group is a base ad group then this field will be equal to
     * ad_group. If the ad group was created in the draft or trial and has no
     * corresponding base ad group, then this field will be null.
     * This field is readonly.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue base_ad_group = 9 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return string|null
     */
    public function getBaseAdGroupUnwrapped()
    {
        return $this->readWrapperValue("base_ad_group");
    }

    /**
     * Output only. The base ad group from which this draft/trial adgroup bid modifier was
     * created. If ad_group is a base ad group then this field will be equal to
     * ad_group. If the ad group was created in the draft or trial and has no
     * corresponding base ad group, then this field will be null.
     * This field is readonly.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue base_ad_group = 9 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setBaseAdGroup($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->base_ad_group = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Output only. The base ad group from which this draft/trial adgroup bid modifier was
     * created. If ad_group is a base ad group then this field will be equal to
     * ad_group. If the ad group was created in the draft or trial and has no
     * corresponding base ad group, then this field will be null.
     * This field is readonly.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue base_ad_group = 9 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @param string|null $var
     * @return $this
     */
    public function setBaseAdGroupUnwrapped($var)
    {
        $this->writeWrapperValue("base_ad_group", $var);
        return $this;}

    /**
     * Output only. Bid modifier source.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.BidModifierSourceEnum.BidModifierSource bid_modifier_source = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getBidModifierSource()
    {
        return $this->bid_modifier_source;
    }

    /**
     * Output only. Bid modifier source.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.BidModifierSourceEnum.BidModifierSource bid_modifier_source = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setBidModifierSource($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\BidModifierSourceEnum\BidModifierSource::class);
        $this->bid_modifier_source = $var;

        return $this;
    }

    /**
     * Immutable. Criterion for hotel date selection (default dates vs. user selected).
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelDateSelectionTypeInfo hotel_date_selection_type = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Common\HotelDateSelectionTypeInfo|null
     */
    public function getHotelDateSelectionType()
    {
        return $this->readOneof(5);
    }

    public function hasHotelDateSelectionType()
    {
        return $this->hasOneof(5);
    }

    /**
     * Immutable. Criterion for hotel date selection (default dates vs. user selected).
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelDateSelectionTypeInfo hotel_date_selection_type = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Common\HotelDateSelectionTypeInfo $var
     * @return $this
     */
    public function setHotelDateSelectionType($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Common\HotelDateSelectionTypeInfo::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * Immutable. Criterion for number of days prior to the stay the booking is being made.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelAdvanceBookingWindowInfo hotel_advance_booking_window = 6 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Common\HotelAdvanceBookingWindowInfo|null
     */
    public function getHotelAdvanceBookingWindow()
    {
        return $this->readOneof(6);
    }

    public function hasHotelAdvanceBookingWindow()
    {
        return $this->hasOneof(6);
    }

    /**
     * Immutable. Criterion for number of days prior to the stay the booking is being made.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelAdvanceBookingWindowInfo hotel_advance_booking_window = 6 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Common\HotelAdvanceBookingWindowInfo $var
     * @return $this
     */
    public function setHotelAdvanceBookingWindow($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Common\HotelAdvanceBookingWindowInfo::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * Immutable. Criterion for length of hotel stay in nights.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelLengthOfStayInfo hotel_length_of_stay = 7 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Common\HotelLengthOfStayInfo|null
     */
    public function getHotelLengthOfStay()
    {
        return $this->readOneof(7);
    }

    public function hasHotelLengthOfStay()
    {
        return $this->hasOneof(7);
    }

    /**
     * Immutable. Criterion for length of hotel stay in nights.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelLengthOfStayInfo hotel_length_of_stay = 7 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Common\HotelLengthOfStayInfo $var
     * @return $this
     */
    public function setHotelLengthOfStay($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Common\HotelLengthOfStayInfo::class);
        $this->writeOneof(7, $var);

        return $this;
    }

    /**
     * Immutable. Criterion for day of the week the booking is for.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelCheckInDayInfo hotel_check_in_day = 8 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Common\HotelCheckInDayInfo|null
     */
    public function getHotelCheckInDay()
    {
        return $this->readOneof(8);
    }

    public function hasHotelCheckInDay()
    {
        return $this->hasOneof(8);
    }

    /**
     * Immutable. Criterion for day of the week the booking is for.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.HotelCheckInDayInfo hotel_check_in_day = 8 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Common\HotelCheckInDayInfo $var
     * @return $this
     */
    public function setHotelCheckInDay($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Common\HotelCheckInDayInfo::class);
        $this->writeOneof(8, $var);

        return $this;
    }

    /**
     * Immutable. A device criterion.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.DeviceInfo device = 11 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Common\DeviceInfo|null
     */
    public function getDevice()
    {
        return $this->readOneof(11);
    }

    public function hasDevice()
    {
        return $this->hasOneof(11);
    }

    /**
     * Immutable. A device criterion.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.DeviceInfo device = 11 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Common\DeviceInfo $var
     * @return $this
     */
    public function setDevice($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Common\DeviceInfo::class);
        $this->writeOneof(11, $var);

        return $this;
    }

    /**
     * Immutable. A preferred content criterion.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.PreferredContentInfo preferred_content = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V4\Common\PreferredContentInfo|null
     */
    public function getPreferredContent()
    {
        return $this->readOneof(12);
    }

    public function hasPreferredContent()
    {
        return $this->hasOneof(12);
    }

    /**
     * Immutable. A preferred content criterion.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.common.PreferredContentInfo preferred_content = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V4\Common\PreferredContentInfo $var
     * @return $this
     */
    public function setPreferredContent($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V4\Common\PreferredContentInfo::class);
        $this->writeOneof(12, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getCriterion()
    {
        return $this->whichOneof("criterion");
    }

}

