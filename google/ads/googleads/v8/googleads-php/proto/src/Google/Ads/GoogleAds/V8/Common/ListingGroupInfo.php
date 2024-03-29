<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v8/common/criteria.proto

namespace Google\Ads\GoogleAds\V8\Common;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A listing group criterion.
 *
 * Generated from protobuf message <code>google.ads.googleads.v8.common.ListingGroupInfo</code>
 */
class ListingGroupInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Type of the listing group.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v8.enums.ListingGroupTypeEnum.ListingGroupType type = 1;</code>
     */
    protected $type = 0;
    /**
     * Dimension value with which this listing group is refining its parent.
     * Undefined for the root group.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v8.common.ListingDimensionInfo case_value = 2;</code>
     */
    protected $case_value = null;
    /**
     * Resource name of ad group criterion which is the parent listing group
     * subdivision. Null for the root group.
     *
     * Generated from protobuf field <code>optional string parent_ad_group_criterion = 4;</code>
     */
    protected $parent_ad_group_criterion = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $type
     *           Type of the listing group.
     *     @type \Google\Ads\GoogleAds\V8\Common\ListingDimensionInfo $case_value
     *           Dimension value with which this listing group is refining its parent.
     *           Undefined for the root group.
     *     @type string $parent_ad_group_criterion
     *           Resource name of ad group criterion which is the parent listing group
     *           subdivision. Null for the root group.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V8\Common\Criteria::initOnce();
        parent::__construct($data);
    }

    /**
     * Type of the listing group.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v8.enums.ListingGroupTypeEnum.ListingGroupType type = 1;</code>
     * @return int
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * Type of the listing group.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v8.enums.ListingGroupTypeEnum.ListingGroupType type = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V8\Enums\ListingGroupTypeEnum\ListingGroupType::class);
        $this->type = $var;

        return $this;
    }

    /**
     * Dimension value with which this listing group is refining its parent.
     * Undefined for the root group.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v8.common.ListingDimensionInfo case_value = 2;</code>
     * @return \Google\Ads\GoogleAds\V8\Common\ListingDimensionInfo|null
     */
    public function getCaseValue()
    {
        return $this->case_value;
    }

    public function hasCaseValue()
    {
        return isset($this->case_value);
    }

    public function clearCaseValue()
    {
        unset($this->case_value);
    }

    /**
     * Dimension value with which this listing group is refining its parent.
     * Undefined for the root group.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v8.common.ListingDimensionInfo case_value = 2;</code>
     * @param \Google\Ads\GoogleAds\V8\Common\ListingDimensionInfo $var
     * @return $this
     */
    public function setCaseValue($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V8\Common\ListingDimensionInfo::class);
        $this->case_value = $var;

        return $this;
    }

    /**
     * Resource name of ad group criterion which is the parent listing group
     * subdivision. Null for the root group.
     *
     * Generated from protobuf field <code>optional string parent_ad_group_criterion = 4;</code>
     * @return string
     */
    public function getParentAdGroupCriterion()
    {
        return isset($this->parent_ad_group_criterion) ? $this->parent_ad_group_criterion : '';
    }

    public function hasParentAdGroupCriterion()
    {
        return isset($this->parent_ad_group_criterion);
    }

    public function clearParentAdGroupCriterion()
    {
        unset($this->parent_ad_group_criterion);
    }

    /**
     * Resource name of ad group criterion which is the parent listing group
     * subdivision. Null for the root group.
     *
     * Generated from protobuf field <code>optional string parent_ad_group_criterion = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setParentAdGroupCriterion($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent_ad_group_criterion = $var;

        return $this;
    }

}

