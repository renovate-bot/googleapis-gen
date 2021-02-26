<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/change_event.proto

namespace Google\Ads\GoogleAds\V6\Resources\ChangeEvent;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A wrapper proto presenting all supported resources.
 * Only the resource of the change_resource_type will be set.
 *
 * Generated from protobuf message <code>google.ads.googleads.v6.resources.ChangeEvent.ChangedResource</code>
 */
class ChangedResource extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. Set if change_resource_type == AD.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Ad ad = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad = null;
    /**
     * Output only. Set if change_resource_type == AD_GROUP.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroup ad_group = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad_group = null;
    /**
     * Output only. Set if change_resource_type == AD_GROUP_CRITERION.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupCriterion ad_group_criterion = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad_group_criterion = null;
    /**
     * Output only. Set if change_resource_type == CAMPAIGN.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Campaign campaign = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $campaign = null;
    /**
     * Output only. Set if change_resource_type == CAMPAIGN_BUDGET.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignBudget campaign_budget = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $campaign_budget = null;
    /**
     * Output only. Set if change_resource_type == AD_GROUP_BID_MODIFIER.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupBidModifier ad_group_bid_modifier = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad_group_bid_modifier = null;
    /**
     * Output only. Set if change_resource_type == CAMPAIGN_CRITERION.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignCriterion campaign_criterion = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $campaign_criterion = null;
    /**
     * Output only. Set if change_resource_type == FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Feed feed = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $feed = null;
    /**
     * Output only. Set if change_resource_type == FEED_ITEM.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.FeedItem feed_item = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $feed_item = null;
    /**
     * Output only. Set if change_resource_type == CAMPAIGN_FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignFeed campaign_feed = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $campaign_feed = null;
    /**
     * Output only. Set if change_resource_type == AD_GROUP_FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupFeed ad_group_feed = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad_group_feed = null;
    /**
     * Output only. Set if change_resource_type == AD_GROUP_AD.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupAd ad_group_ad = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad_group_ad = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Ads\GoogleAds\V6\Resources\Ad $ad
     *           Output only. Set if change_resource_type == AD.
     *     @type \Google\Ads\GoogleAds\V6\Resources\AdGroup $ad_group
     *           Output only. Set if change_resource_type == AD_GROUP.
     *     @type \Google\Ads\GoogleAds\V6\Resources\AdGroupCriterion $ad_group_criterion
     *           Output only. Set if change_resource_type == AD_GROUP_CRITERION.
     *     @type \Google\Ads\GoogleAds\V6\Resources\Campaign $campaign
     *           Output only. Set if change_resource_type == CAMPAIGN.
     *     @type \Google\Ads\GoogleAds\V6\Resources\CampaignBudget $campaign_budget
     *           Output only. Set if change_resource_type == CAMPAIGN_BUDGET.
     *     @type \Google\Ads\GoogleAds\V6\Resources\AdGroupBidModifier $ad_group_bid_modifier
     *           Output only. Set if change_resource_type == AD_GROUP_BID_MODIFIER.
     *     @type \Google\Ads\GoogleAds\V6\Resources\CampaignCriterion $campaign_criterion
     *           Output only. Set if change_resource_type == CAMPAIGN_CRITERION.
     *     @type \Google\Ads\GoogleAds\V6\Resources\Feed $feed
     *           Output only. Set if change_resource_type == FEED.
     *     @type \Google\Ads\GoogleAds\V6\Resources\FeedItem $feed_item
     *           Output only. Set if change_resource_type == FEED_ITEM.
     *     @type \Google\Ads\GoogleAds\V6\Resources\CampaignFeed $campaign_feed
     *           Output only. Set if change_resource_type == CAMPAIGN_FEED.
     *     @type \Google\Ads\GoogleAds\V6\Resources\AdGroupFeed $ad_group_feed
     *           Output only. Set if change_resource_type == AD_GROUP_FEED.
     *     @type \Google\Ads\GoogleAds\V6\Resources\AdGroupAd $ad_group_ad
     *           Output only. Set if change_resource_type == AD_GROUP_AD.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V6\Resources\ChangeEvent::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. Set if change_resource_type == AD.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Ad ad = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\Ad|null
     */
    public function getAd()
    {
        return isset($this->ad) ? $this->ad : null;
    }

    public function hasAd()
    {
        return isset($this->ad);
    }

    public function clearAd()
    {
        unset($this->ad);
    }

    /**
     * Output only. Set if change_resource_type == AD.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Ad ad = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\Ad $var
     * @return $this
     */
    public function setAd($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\Ad::class);
        $this->ad = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroup ad_group = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\AdGroup|null
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
     * Output only. Set if change_resource_type == AD_GROUP.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroup ad_group = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\AdGroup $var
     * @return $this
     */
    public function setAdGroup($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\AdGroup::class);
        $this->ad_group = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP_CRITERION.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupCriterion ad_group_criterion = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\AdGroupCriterion|null
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
     * Output only. Set if change_resource_type == AD_GROUP_CRITERION.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupCriterion ad_group_criterion = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\AdGroupCriterion $var
     * @return $this
     */
    public function setAdGroupCriterion($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\AdGroupCriterion::class);
        $this->ad_group_criterion = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Campaign campaign = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\Campaign|null
     */
    public function getCampaign()
    {
        return isset($this->campaign) ? $this->campaign : null;
    }

    public function hasCampaign()
    {
        return isset($this->campaign);
    }

    public function clearCampaign()
    {
        unset($this->campaign);
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Campaign campaign = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\Campaign $var
     * @return $this
     */
    public function setCampaign($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\Campaign::class);
        $this->campaign = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN_BUDGET.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignBudget campaign_budget = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\CampaignBudget|null
     */
    public function getCampaignBudget()
    {
        return isset($this->campaign_budget) ? $this->campaign_budget : null;
    }

    public function hasCampaignBudget()
    {
        return isset($this->campaign_budget);
    }

    public function clearCampaignBudget()
    {
        unset($this->campaign_budget);
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN_BUDGET.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignBudget campaign_budget = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\CampaignBudget $var
     * @return $this
     */
    public function setCampaignBudget($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\CampaignBudget::class);
        $this->campaign_budget = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP_BID_MODIFIER.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupBidModifier ad_group_bid_modifier = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\AdGroupBidModifier|null
     */
    public function getAdGroupBidModifier()
    {
        return isset($this->ad_group_bid_modifier) ? $this->ad_group_bid_modifier : null;
    }

    public function hasAdGroupBidModifier()
    {
        return isset($this->ad_group_bid_modifier);
    }

    public function clearAdGroupBidModifier()
    {
        unset($this->ad_group_bid_modifier);
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP_BID_MODIFIER.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupBidModifier ad_group_bid_modifier = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\AdGroupBidModifier $var
     * @return $this
     */
    public function setAdGroupBidModifier($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\AdGroupBidModifier::class);
        $this->ad_group_bid_modifier = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN_CRITERION.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignCriterion campaign_criterion = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\CampaignCriterion|null
     */
    public function getCampaignCriterion()
    {
        return isset($this->campaign_criterion) ? $this->campaign_criterion : null;
    }

    public function hasCampaignCriterion()
    {
        return isset($this->campaign_criterion);
    }

    public function clearCampaignCriterion()
    {
        unset($this->campaign_criterion);
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN_CRITERION.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignCriterion campaign_criterion = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\CampaignCriterion $var
     * @return $this
     */
    public function setCampaignCriterion($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\CampaignCriterion::class);
        $this->campaign_criterion = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Feed feed = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\Feed|null
     */
    public function getFeed()
    {
        return isset($this->feed) ? $this->feed : null;
    }

    public function hasFeed()
    {
        return isset($this->feed);
    }

    public function clearFeed()
    {
        unset($this->feed);
    }

    /**
     * Output only. Set if change_resource_type == FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.Feed feed = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\Feed $var
     * @return $this
     */
    public function setFeed($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\Feed::class);
        $this->feed = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == FEED_ITEM.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.FeedItem feed_item = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\FeedItem|null
     */
    public function getFeedItem()
    {
        return isset($this->feed_item) ? $this->feed_item : null;
    }

    public function hasFeedItem()
    {
        return isset($this->feed_item);
    }

    public function clearFeedItem()
    {
        unset($this->feed_item);
    }

    /**
     * Output only. Set if change_resource_type == FEED_ITEM.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.FeedItem feed_item = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\FeedItem $var
     * @return $this
     */
    public function setFeedItem($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\FeedItem::class);
        $this->feed_item = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN_FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignFeed campaign_feed = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\CampaignFeed|null
     */
    public function getCampaignFeed()
    {
        return isset($this->campaign_feed) ? $this->campaign_feed : null;
    }

    public function hasCampaignFeed()
    {
        return isset($this->campaign_feed);
    }

    public function clearCampaignFeed()
    {
        unset($this->campaign_feed);
    }

    /**
     * Output only. Set if change_resource_type == CAMPAIGN_FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.CampaignFeed campaign_feed = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\CampaignFeed $var
     * @return $this
     */
    public function setCampaignFeed($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\CampaignFeed::class);
        $this->campaign_feed = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP_FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupFeed ad_group_feed = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\AdGroupFeed|null
     */
    public function getAdGroupFeed()
    {
        return isset($this->ad_group_feed) ? $this->ad_group_feed : null;
    }

    public function hasAdGroupFeed()
    {
        return isset($this->ad_group_feed);
    }

    public function clearAdGroupFeed()
    {
        unset($this->ad_group_feed);
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP_FEED.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupFeed ad_group_feed = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\AdGroupFeed $var
     * @return $this
     */
    public function setAdGroupFeed($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\AdGroupFeed::class);
        $this->ad_group_feed = $var;

        return $this;
    }

    /**
     * Output only. Set if change_resource_type == AD_GROUP_AD.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupAd ad_group_ad = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V6\Resources\AdGroupAd|null
     */
    public function getAdGroupAd()
    {
        return isset($this->ad_group_ad) ? $this->ad_group_ad : null;
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
     * Output only. Set if change_resource_type == AD_GROUP_AD.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v6.resources.AdGroupAd ad_group_ad = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V6\Resources\AdGroupAd $var
     * @return $this
     */
    public function setAdGroupAd($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V6\Resources\AdGroupAd::class);
        $this->ad_group_ad = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ChangedResource::class, \Google\Ads\GoogleAds\V6\Resources\ChangeEvent_ChangedResource::class);

