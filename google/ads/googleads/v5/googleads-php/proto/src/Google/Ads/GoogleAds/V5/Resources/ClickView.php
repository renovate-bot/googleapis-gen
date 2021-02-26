<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/click_view.proto

namespace Google\Ads\GoogleAds\V5\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A click view with metrics aggregated at each click level, including both
 * valid and invalid clicks. For non-Search campaigns, metrics.clicks
 * represents the number of valid and invalid interactions.
 * Queries including ClickView must have a filter limiting the results to one
 * day and can be requested for dates back to 90 days before the time of the
 * request.
 *
 * Generated from protobuf message <code>google.ads.googleads.v5.resources.ClickView</code>
 */
class ClickView extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The resource name of the click view.
     * Click view resource names have the form:
     * `customers/{customer_id}/clickViews/{date (yyyy-MM-dd)}~{gclid}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * Output only. The Google Click ID.
     *
     * Generated from protobuf field <code>string gclid = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $gclid = null;
    /**
     * Output only. The location criteria matching the area of interest associated with the
     * impression.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ClickLocation area_of_interest = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $area_of_interest = null;
    /**
     * Output only. The location criteria matching the location of presence associated with the
     * impression.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ClickLocation location_of_presence = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $location_of_presence = null;
    /**
     * Output only. Page number in search results where the ad was shown.
     *
     * Generated from protobuf field <code>int64 page_number = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $page_number = null;
    /**
     * Output only. The associated ad.
     *
     * Generated from protobuf field <code>string ad_group_ad = 10 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     */
    protected $ad_group_ad = null;
    /**
     * Output only. The associated campaign location target, if one exists.
     *
     * Generated from protobuf field <code>string campaign_location_target = 11 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     */
    protected $campaign_location_target = null;
    /**
     * Output only. The associated user list, if one exists.
     *
     * Generated from protobuf field <code>string user_list = 12 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     */
    protected $user_list = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Output only. The resource name of the click view.
     *           Click view resource names have the form:
     *           `customers/{customer_id}/clickViews/{date (yyyy-MM-dd)}~{gclid}`
     *     @type string $gclid
     *           Output only. The Google Click ID.
     *     @type \Google\Ads\GoogleAds\V5\Common\ClickLocation $area_of_interest
     *           Output only. The location criteria matching the area of interest associated with the
     *           impression.
     *     @type \Google\Ads\GoogleAds\V5\Common\ClickLocation $location_of_presence
     *           Output only. The location criteria matching the location of presence associated with the
     *           impression.
     *     @type int|string $page_number
     *           Output only. Page number in search results where the ad was shown.
     *     @type string $ad_group_ad
     *           Output only. The associated ad.
     *     @type string $campaign_location_target
     *           Output only. The associated campaign location target, if one exists.
     *     @type string $user_list
     *           Output only. The associated user list, if one exists.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V5\Resources\ClickView::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The resource name of the click view.
     * Click view resource names have the form:
     * `customers/{customer_id}/clickViews/{date (yyyy-MM-dd)}~{gclid}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Output only. The resource name of the click view.
     * Click view resource names have the form:
     * `customers/{customer_id}/clickViews/{date (yyyy-MM-dd)}~{gclid}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
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
     * Output only. The Google Click ID.
     *
     * Generated from protobuf field <code>string gclid = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getGclid()
    {
        return isset($this->gclid) ? $this->gclid : '';
    }

    public function hasGclid()
    {
        return isset($this->gclid);
    }

    public function clearGclid()
    {
        unset($this->gclid);
    }

    /**
     * Output only. The Google Click ID.
     *
     * Generated from protobuf field <code>string gclid = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setGclid($var)
    {
        GPBUtil::checkString($var, True);
        $this->gclid = $var;

        return $this;
    }

    /**
     * Output only. The location criteria matching the area of interest associated with the
     * impression.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ClickLocation area_of_interest = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V5\Common\ClickLocation|null
     */
    public function getAreaOfInterest()
    {
        return isset($this->area_of_interest) ? $this->area_of_interest : null;
    }

    public function hasAreaOfInterest()
    {
        return isset($this->area_of_interest);
    }

    public function clearAreaOfInterest()
    {
        unset($this->area_of_interest);
    }

    /**
     * Output only. The location criteria matching the area of interest associated with the
     * impression.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ClickLocation area_of_interest = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V5\Common\ClickLocation $var
     * @return $this
     */
    public function setAreaOfInterest($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\ClickLocation::class);
        $this->area_of_interest = $var;

        return $this;
    }

    /**
     * Output only. The location criteria matching the location of presence associated with the
     * impression.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ClickLocation location_of_presence = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V5\Common\ClickLocation|null
     */
    public function getLocationOfPresence()
    {
        return isset($this->location_of_presence) ? $this->location_of_presence : null;
    }

    public function hasLocationOfPresence()
    {
        return isset($this->location_of_presence);
    }

    public function clearLocationOfPresence()
    {
        unset($this->location_of_presence);
    }

    /**
     * Output only. The location criteria matching the location of presence associated with the
     * impression.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ClickLocation location_of_presence = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V5\Common\ClickLocation $var
     * @return $this
     */
    public function setLocationOfPresence($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\ClickLocation::class);
        $this->location_of_presence = $var;

        return $this;
    }

    /**
     * Output only. Page number in search results where the ad was shown.
     *
     * Generated from protobuf field <code>int64 page_number = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string
     */
    public function getPageNumber()
    {
        return isset($this->page_number) ? $this->page_number : 0;
    }

    public function hasPageNumber()
    {
        return isset($this->page_number);
    }

    public function clearPageNumber()
    {
        unset($this->page_number);
    }

    /**
     * Output only. Page number in search results where the ad was shown.
     *
     * Generated from protobuf field <code>int64 page_number = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string $var
     * @return $this
     */
    public function setPageNumber($var)
    {
        GPBUtil::checkInt64($var);
        $this->page_number = $var;

        return $this;
    }

    /**
     * Output only. The associated ad.
     *
     * Generated from protobuf field <code>string ad_group_ad = 10 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getAdGroupAd()
    {
        return isset($this->ad_group_ad) ? $this->ad_group_ad : '';
    }

    public function hasAdGroupAd()
    {
        return isset($this->ad_group_ad);
    }

    public function clearAdGroupAd()
    {
        unset($this->ad_group_ad);
    }

    /**
     * Output only. The associated ad.
     *
     * Generated from protobuf field <code>string ad_group_ad = 10 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setAdGroupAd($var)
    {
        GPBUtil::checkString($var, True);
        $this->ad_group_ad = $var;

        return $this;
    }

    /**
     * Output only. The associated campaign location target, if one exists.
     *
     * Generated from protobuf field <code>string campaign_location_target = 11 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getCampaignLocationTarget()
    {
        return isset($this->campaign_location_target) ? $this->campaign_location_target : '';
    }

    public function hasCampaignLocationTarget()
    {
        return isset($this->campaign_location_target);
    }

    public function clearCampaignLocationTarget()
    {
        unset($this->campaign_location_target);
    }

    /**
     * Output only. The associated campaign location target, if one exists.
     *
     * Generated from protobuf field <code>string campaign_location_target = 11 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setCampaignLocationTarget($var)
    {
        GPBUtil::checkString($var, True);
        $this->campaign_location_target = $var;

        return $this;
    }

    /**
     * Output only. The associated user list, if one exists.
     *
     * Generated from protobuf field <code>string user_list = 12 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getUserList()
    {
        return isset($this->user_list) ? $this->user_list : '';
    }

    public function hasUserList()
    {
        return isset($this->user_list);
    }

    public function clearUserList()
    {
        unset($this->user_list);
    }

    /**
     * Output only. The associated user list, if one exists.
     *
     * Generated from protobuf field <code>string user_list = 12 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setUserList($var)
    {
        GPBUtil::checkString($var, True);
        $this->user_list = $var;

        return $this;
    }

}

