<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/keyword_plan_campaign.proto

namespace Google\Ads\GoogleAds\V4\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A Keyword Plan campaign.
 * Max number of keyword plan campaigns per plan allowed: 1.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.KeywordPlanCampaign</code>
 */
class KeywordPlanCampaign extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the Keyword Plan campaign.
     * KeywordPlanCampaign resource names have the form:
     * `customers/{customer_id}/keywordPlanCampaigns/{kp_campaign_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * The keyword plan this campaign belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue keyword_plan = 2 [(.google.api.resource_reference) = {</code>
     */
    protected $keyword_plan = null;
    /**
     * Output only. The ID of the Keyword Plan campaign.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $id = null;
    /**
     * The name of the Keyword Plan campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     */
    protected $name = null;
    /**
     * The languages targeted for the Keyword Plan campaign.
     * Max allowed: 1.
     *
     * Generated from protobuf field <code>repeated .google.protobuf.StringValue language_constants = 5 [(.google.api.resource_reference) = {</code>
     */
    private $language_constants;
    /**
     * Targeting network.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.KeywordPlanNetworkEnum.KeywordPlanNetwork keyword_plan_network = 6;</code>
     */
    protected $keyword_plan_network = 0;
    /**
     * A default max cpc bid in micros, and in the account currency, for all ad
     * groups under the campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 7;</code>
     */
    protected $cpc_bid_micros = null;
    /**
     * The geo targets.
     * Max number allowed: 20.
     *
     * Generated from protobuf field <code>repeated .google.ads.googleads.v4.resources.KeywordPlanGeoTarget geo_targets = 8;</code>
     */
    private $geo_targets;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The resource name of the Keyword Plan campaign.
     *           KeywordPlanCampaign resource names have the form:
     *           `customers/{customer_id}/keywordPlanCampaigns/{kp_campaign_id}`
     *     @type \Google\Protobuf\StringValue $keyword_plan
     *           The keyword plan this campaign belongs to.
     *     @type \Google\Protobuf\Int64Value $id
     *           Output only. The ID of the Keyword Plan campaign.
     *     @type \Google\Protobuf\StringValue $name
     *           The name of the Keyword Plan campaign.
     *           This field is required and should not be empty when creating Keyword Plan
     *           campaigns.
     *     @type \Google\Protobuf\StringValue[]|\Google\Protobuf\Internal\RepeatedField $language_constants
     *           The languages targeted for the Keyword Plan campaign.
     *           Max allowed: 1.
     *     @type int $keyword_plan_network
     *           Targeting network.
     *           This field is required and should not be empty when creating Keyword Plan
     *           campaigns.
     *     @type \Google\Protobuf\Int64Value $cpc_bid_micros
     *           A default max cpc bid in micros, and in the account currency, for all ad
     *           groups under the campaign.
     *           This field is required and should not be empty when creating Keyword Plan
     *           campaigns.
     *     @type \Google\Ads\GoogleAds\V4\Resources\KeywordPlanGeoTarget[]|\Google\Protobuf\Internal\RepeatedField $geo_targets
     *           The geo targets.
     *           Max number allowed: 20.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\KeywordPlanCampaign::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the Keyword Plan campaign.
     * KeywordPlanCampaign resource names have the form:
     * `customers/{customer_id}/keywordPlanCampaigns/{kp_campaign_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The resource name of the Keyword Plan campaign.
     * KeywordPlanCampaign resource names have the form:
     * `customers/{customer_id}/keywordPlanCampaigns/{kp_campaign_id}`
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
     * The keyword plan this campaign belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue keyword_plan = 2 [(.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getKeywordPlan()
    {
        return isset($this->keyword_plan) ? $this->keyword_plan : null;
    }

    public function hasKeywordPlan()
    {
        return isset($this->keyword_plan);
    }

    public function clearKeywordPlan()
    {
        unset($this->keyword_plan);
    }

    /**
     * Returns the unboxed value from <code>getKeywordPlan()</code>

     * The keyword plan this campaign belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue keyword_plan = 2 [(.google.api.resource_reference) = {</code>
     * @return string|null
     */
    public function getKeywordPlanUnwrapped()
    {
        return $this->readWrapperValue("keyword_plan");
    }

    /**
     * The keyword plan this campaign belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue keyword_plan = 2 [(.google.api.resource_reference) = {</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setKeywordPlan($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->keyword_plan = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * The keyword plan this campaign belongs to.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue keyword_plan = 2 [(.google.api.resource_reference) = {</code>
     * @param string|null $var
     * @return $this
     */
    public function setKeywordPlanUnwrapped($var)
    {
        $this->writeWrapperValue("keyword_plan", $var);
        return $this;}

    /**
     * Output only. The ID of the Keyword Plan campaign.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
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

     * Output only. The ID of the Keyword Plan campaign.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getIdUnwrapped()
    {
        return $this->readWrapperValue("id");
    }

    /**
     * Output only. The ID of the Keyword Plan campaign.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
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

     * Output only. The ID of the Keyword Plan campaign.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setIdUnwrapped($var)
    {
        $this->writeWrapperValue("id", $var);
        return $this;}

    /**
     * The name of the Keyword Plan campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getName()
    {
        return isset($this->name) ? $this->name : null;
    }

    public function hasName()
    {
        return isset($this->name);
    }

    public function clearName()
    {
        unset($this->name);
    }

    /**
     * Returns the unboxed value from <code>getName()</code>

     * The name of the Keyword Plan campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @return string|null
     */
    public function getNameUnwrapped()
    {
        return $this->readWrapperValue("name");
    }

    /**
     * The name of the Keyword Plan campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->name = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * The name of the Keyword Plan campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue name = 4;</code>
     * @param string|null $var
     * @return $this
     */
    public function setNameUnwrapped($var)
    {
        $this->writeWrapperValue("name", $var);
        return $this;}

    /**
     * The languages targeted for the Keyword Plan campaign.
     * Max allowed: 1.
     *
     * Generated from protobuf field <code>repeated .google.protobuf.StringValue language_constants = 5 [(.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getLanguageConstants()
    {
        return $this->language_constants;
    }

    /**
     * The languages targeted for the Keyword Plan campaign.
     * Max allowed: 1.
     *
     * Generated from protobuf field <code>repeated .google.protobuf.StringValue language_constants = 5 [(.google.api.resource_reference) = {</code>
     * @param \Google\Protobuf\StringValue[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setLanguageConstants($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Protobuf\StringValue::class);
        $this->language_constants = $arr;

        return $this;
    }

    /**
     * Targeting network.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.KeywordPlanNetworkEnum.KeywordPlanNetwork keyword_plan_network = 6;</code>
     * @return int
     */
    public function getKeywordPlanNetwork()
    {
        return $this->keyword_plan_network;
    }

    /**
     * Targeting network.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v4.enums.KeywordPlanNetworkEnum.KeywordPlanNetwork keyword_plan_network = 6;</code>
     * @param int $var
     * @return $this
     */
    public function setKeywordPlanNetwork($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V4\Enums\KeywordPlanNetworkEnum\KeywordPlanNetwork::class);
        $this->keyword_plan_network = $var;

        return $this;
    }

    /**
     * A default max cpc bid in micros, and in the account currency, for all ad
     * groups under the campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 7;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getCpcBidMicros()
    {
        return isset($this->cpc_bid_micros) ? $this->cpc_bid_micros : null;
    }

    public function hasCpcBidMicros()
    {
        return isset($this->cpc_bid_micros);
    }

    public function clearCpcBidMicros()
    {
        unset($this->cpc_bid_micros);
    }

    /**
     * Returns the unboxed value from <code>getCpcBidMicros()</code>

     * A default max cpc bid in micros, and in the account currency, for all ad
     * groups under the campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 7;</code>
     * @return int|string|null
     */
    public function getCpcBidMicrosUnwrapped()
    {
        return $this->readWrapperValue("cpc_bid_micros");
    }

    /**
     * A default max cpc bid in micros, and in the account currency, for all ad
     * groups under the campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 7;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setCpcBidMicros($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->cpc_bid_micros = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * A default max cpc bid in micros, and in the account currency, for all ad
     * groups under the campaign.
     * This field is required and should not be empty when creating Keyword Plan
     * campaigns.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 7;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setCpcBidMicrosUnwrapped($var)
    {
        $this->writeWrapperValue("cpc_bid_micros", $var);
        return $this;}

    /**
     * The geo targets.
     * Max number allowed: 20.
     *
     * Generated from protobuf field <code>repeated .google.ads.googleads.v4.resources.KeywordPlanGeoTarget geo_targets = 8;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getGeoTargets()
    {
        return $this->geo_targets;
    }

    /**
     * The geo targets.
     * Max number allowed: 20.
     *
     * Generated from protobuf field <code>repeated .google.ads.googleads.v4.resources.KeywordPlanGeoTarget geo_targets = 8;</code>
     * @param \Google\Ads\GoogleAds\V4\Resources\KeywordPlanGeoTarget[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setGeoTargets($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Ads\GoogleAds\V4\Resources\KeywordPlanGeoTarget::class);
        $this->geo_targets = $arr;

        return $this;
    }

}

