<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/services/campaign_experiment_service.proto

namespace Google\Ads\GoogleAds\V9\Services;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Message used as metadata returned in Long Running Operations for
 * CreateCampaignExperimentRequest
 *
 * Generated from protobuf message <code>google.ads.googleads.v9.services.CreateCampaignExperimentMetadata</code>
 */
class CreateCampaignExperimentMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Resource name of campaign experiment created.
     *
     * Generated from protobuf field <code>string campaign_experiment = 1;</code>
     */
    protected $campaign_experiment = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $campaign_experiment
     *           Resource name of campaign experiment created.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V9\Services\CampaignExperimentService::initOnce();
        parent::__construct($data);
    }

    /**
     * Resource name of campaign experiment created.
     *
     * Generated from protobuf field <code>string campaign_experiment = 1;</code>
     * @return string
     */
    public function getCampaignExperiment()
    {
        return $this->campaign_experiment;
    }

    /**
     * Resource name of campaign experiment created.
     *
     * Generated from protobuf field <code>string campaign_experiment = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setCampaignExperiment($var)
    {
        GPBUtil::checkString($var, True);
        $this->campaign_experiment = $var;

        return $this;
    }

}

