<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/services/keyword_plan_service.proto

namespace Google\Ads\GoogleAds\V9\Services;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The forecast of the campaign for the week starting start_date.
 *
 * Generated from protobuf message <code>google.ads.googleads.v9.services.KeywordPlanWeeklyForecast</code>
 */
class KeywordPlanWeeklyForecast extends \Google\Protobuf\Internal\Message
{
    /**
     * The start date, in yyyy-mm-dd format. This date is inclusive.
     *
     * Generated from protobuf field <code>optional string start_date = 1;</code>
     */
    protected $start_date = null;
    /**
     * The forecast for the Keyword Plan campaign for the week.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.services.ForecastMetrics forecast = 2;</code>
     */
    protected $forecast = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $start_date
     *           The start date, in yyyy-mm-dd format. This date is inclusive.
     *     @type \Google\Ads\GoogleAds\V9\Services\ForecastMetrics $forecast
     *           The forecast for the Keyword Plan campaign for the week.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V9\Services\KeywordPlanService::initOnce();
        parent::__construct($data);
    }

    /**
     * The start date, in yyyy-mm-dd format. This date is inclusive.
     *
     * Generated from protobuf field <code>optional string start_date = 1;</code>
     * @return string
     */
    public function getStartDate()
    {
        return isset($this->start_date) ? $this->start_date : '';
    }

    public function hasStartDate()
    {
        return isset($this->start_date);
    }

    public function clearStartDate()
    {
        unset($this->start_date);
    }

    /**
     * The start date, in yyyy-mm-dd format. This date is inclusive.
     *
     * Generated from protobuf field <code>optional string start_date = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setStartDate($var)
    {
        GPBUtil::checkString($var, True);
        $this->start_date = $var;

        return $this;
    }

    /**
     * The forecast for the Keyword Plan campaign for the week.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.services.ForecastMetrics forecast = 2;</code>
     * @return \Google\Ads\GoogleAds\V9\Services\ForecastMetrics|null
     */
    public function getForecast()
    {
        return $this->forecast;
    }

    public function hasForecast()
    {
        return isset($this->forecast);
    }

    public function clearForecast()
    {
        unset($this->forecast);
    }

    /**
     * The forecast for the Keyword Plan campaign for the week.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.services.ForecastMetrics forecast = 2;</code>
     * @param \Google\Ads\GoogleAds\V9\Services\ForecastMetrics $var
     * @return $this
     */
    public function setForecast($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Services\ForecastMetrics::class);
        $this->forecast = $var;

        return $this;
    }

}

