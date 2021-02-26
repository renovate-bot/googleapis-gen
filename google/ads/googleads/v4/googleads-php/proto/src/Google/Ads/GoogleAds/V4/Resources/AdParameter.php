<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/ad_parameter.proto

namespace Google\Ads\GoogleAds\V4\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An ad parameter that is used to update numeric values (such as prices or
 * inventory levels) in any text line of an ad (including URLs). There can
 * be a maximum of two AdParameters per ad group criterion. (One with
 * parameter_index = 1 and one with parameter_index = 2.)
 * In the ad the parameters are referenced by a placeholder of the form
 * "{param#:value}". E.g. "{param1:$17}"
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.AdParameter</code>
 */
class AdParameter extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the ad parameter.
     * Ad parameter resource names have the form:
     * `customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * Immutable. The ad group criterion that this ad parameter belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group_criterion = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $ad_group_criterion = null;
    /**
     * Immutable. The unique index of this ad parameter. Must be either 1 or 2.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value parameter_index = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $parameter_index = null;
    /**
     * Numeric value to insert into the ad text. The following restrictions
     *  apply:
     *  - Can use comma or period as a separator, with an optional period or
     *    comma (respectively) for fractional values. For example, 1,000,000.00
     *    and 2.000.000,10 are valid.
     *  - Can be prepended or appended with a currency symbol. For example,
     *    $99.99 is valid.
     *  - Can be prepended or appended with a currency code. For example, 99.99USD
     *    and EUR200 are valid.
     *  - Can use '%'. For example, 1.0% and 1,0% are valid.
     *  - Can use plus or minus. For example, -10.99 and 25+ are valid.
     *  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
     *    valid.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue insertion_text = 4;</code>
     */
    protected $insertion_text = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The resource name of the ad parameter.
     *           Ad parameter resource names have the form:
     *           `customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}`
     *     @type \Google\Protobuf\StringValue $ad_group_criterion
     *           Immutable. The ad group criterion that this ad parameter belongs to.
     *     @type \Google\Protobuf\Int64Value $parameter_index
     *           Immutable. The unique index of this ad parameter. Must be either 1 or 2.
     *     @type \Google\Protobuf\StringValue $insertion_text
     *           Numeric value to insert into the ad text. The following restrictions
     *            apply:
     *            - Can use comma or period as a separator, with an optional period or
     *              comma (respectively) for fractional values. For example, 1,000,000.00
     *              and 2.000.000,10 are valid.
     *            - Can be prepended or appended with a currency symbol. For example,
     *              $99.99 is valid.
     *            - Can be prepended or appended with a currency code. For example, 99.99USD
     *              and EUR200 are valid.
     *            - Can use '%'. For example, 1.0% and 1,0% are valid.
     *            - Can use plus or minus. For example, -10.99 and 25+ are valid.
     *            - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
     *              valid.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\AdParameter::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the ad parameter.
     * Ad parameter resource names have the form:
     * `customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The resource name of the ad parameter.
     * Ad parameter resource names have the form:
     * `customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}`
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
     * Immutable. The ad group criterion that this ad parameter belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group_criterion = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getAdGroupCriterion()
    {
        return isset($this->ad_group_criterion) ? $this->ad_group_criterion : null;
    }

    public function hasAdGroupCriterion()
    {
        return isset($this->ad_group_criterion);
    }

    public function clearAdGroupCriterion()
    {
        unset($this->ad_group_criterion);
    }

    /**
     * Returns the unboxed value from <code>getAdGroupCriterion()</code>

     * Immutable. The ad group criterion that this ad parameter belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group_criterion = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string|null
     */
    public function getAdGroupCriterionUnwrapped()
    {
        return $this->readWrapperValue("ad_group_criterion");
    }

    /**
     * Immutable. The ad group criterion that this ad parameter belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group_criterion = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setAdGroupCriterion($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->ad_group_criterion = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Immutable. The ad group criterion that this ad parameter belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue ad_group_criterion = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string|null $var
     * @return $this
     */
    public function setAdGroupCriterionUnwrapped($var)
    {
        $this->writeWrapperValue("ad_group_criterion", $var);
        return $this;}

    /**
     * Immutable. The unique index of this ad parameter. Must be either 1 or 2.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value parameter_index = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getParameterIndex()
    {
        return isset($this->parameter_index) ? $this->parameter_index : null;
    }

    public function hasParameterIndex()
    {
        return isset($this->parameter_index);
    }

    public function clearParameterIndex()
    {
        unset($this->parameter_index);
    }

    /**
     * Returns the unboxed value from <code>getParameterIndex()</code>

     * Immutable. The unique index of this ad parameter. Must be either 1 or 2.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value parameter_index = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return int|string|null
     */
    public function getParameterIndexUnwrapped()
    {
        return $this->readWrapperValue("parameter_index");
    }

    /**
     * Immutable. The unique index of this ad parameter. Must be either 1 or 2.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value parameter_index = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setParameterIndex($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->parameter_index = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Immutable. The unique index of this ad parameter. Must be either 1 or 2.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value parameter_index = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setParameterIndexUnwrapped($var)
    {
        $this->writeWrapperValue("parameter_index", $var);
        return $this;}

    /**
     * Numeric value to insert into the ad text. The following restrictions
     *  apply:
     *  - Can use comma or period as a separator, with an optional period or
     *    comma (respectively) for fractional values. For example, 1,000,000.00
     *    and 2.000.000,10 are valid.
     *  - Can be prepended or appended with a currency symbol. For example,
     *    $99.99 is valid.
     *  - Can be prepended or appended with a currency code. For example, 99.99USD
     *    and EUR200 are valid.
     *  - Can use '%'. For example, 1.0% and 1,0% are valid.
     *  - Can use plus or minus. For example, -10.99 and 25+ are valid.
     *  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
     *    valid.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue insertion_text = 4;</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getInsertionText()
    {
        return isset($this->insertion_text) ? $this->insertion_text : null;
    }

    public function hasInsertionText()
    {
        return isset($this->insertion_text);
    }

    public function clearInsertionText()
    {
        unset($this->insertion_text);
    }

    /**
     * Returns the unboxed value from <code>getInsertionText()</code>

     * Numeric value to insert into the ad text. The following restrictions
     *  apply:
     *  - Can use comma or period as a separator, with an optional period or
     *    comma (respectively) for fractional values. For example, 1,000,000.00
     *    and 2.000.000,10 are valid.
     *  - Can be prepended or appended with a currency symbol. For example,
     *    $99.99 is valid.
     *  - Can be prepended or appended with a currency code. For example, 99.99USD
     *    and EUR200 are valid.
     *  - Can use '%'. For example, 1.0% and 1,0% are valid.
     *  - Can use plus or minus. For example, -10.99 and 25+ are valid.
     *  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
     *    valid.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue insertion_text = 4;</code>
     * @return string|null
     */
    public function getInsertionTextUnwrapped()
    {
        return $this->readWrapperValue("insertion_text");
    }

    /**
     * Numeric value to insert into the ad text. The following restrictions
     *  apply:
     *  - Can use comma or period as a separator, with an optional period or
     *    comma (respectively) for fractional values. For example, 1,000,000.00
     *    and 2.000.000,10 are valid.
     *  - Can be prepended or appended with a currency symbol. For example,
     *    $99.99 is valid.
     *  - Can be prepended or appended with a currency code. For example, 99.99USD
     *    and EUR200 are valid.
     *  - Can use '%'. For example, 1.0% and 1,0% are valid.
     *  - Can use plus or minus. For example, -10.99 and 25+ are valid.
     *  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
     *    valid.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue insertion_text = 4;</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setInsertionText($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->insertion_text = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Numeric value to insert into the ad text. The following restrictions
     *  apply:
     *  - Can use comma or period as a separator, with an optional period or
     *    comma (respectively) for fractional values. For example, 1,000,000.00
     *    and 2.000.000,10 are valid.
     *  - Can be prepended or appended with a currency symbol. For example,
     *    $99.99 is valid.
     *  - Can be prepended or appended with a currency code. For example, 99.99USD
     *    and EUR200 are valid.
     *  - Can use '%'. For example, 1.0% and 1,0% are valid.
     *  - Can use plus or minus. For example, -10.99 and 25+ are valid.
     *  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
     *    valid.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue insertion_text = 4;</code>
     * @param string|null $var
     * @return $this
     */
    public function setInsertionTextUnwrapped($var)
    {
        $this->writeWrapperValue("insertion_text", $var);
        return $this;}

}

