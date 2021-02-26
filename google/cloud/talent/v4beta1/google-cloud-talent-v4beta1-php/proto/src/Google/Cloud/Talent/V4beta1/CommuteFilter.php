<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/talent/v4beta1/filters.proto

namespace Google\Cloud\Talent\V4beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Parameters needed for commute search.
 *
 * Generated from protobuf message <code>google.cloud.talent.v4beta1.CommuteFilter</code>
 */
class CommuteFilter extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The method of transportation to calculate the commute time for.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.CommuteMethod commute_method = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $commute_method = 0;
    /**
     * Required. The latitude and longitude of the location to calculate the
     * commute time from.
     *
     * Generated from protobuf field <code>.google.type.LatLng start_coordinates = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $start_coordinates = null;
    /**
     * Required. The maximum travel time in seconds. The maximum allowed value is `3600s`
     * (one hour). Format is `123s`.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration travel_duration = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $travel_duration = null;
    /**
     * If `true`, jobs without street level addresses may also be returned.
     * For city level addresses, the city center is used. For state and coarser
     * level addresses, text matching is used.
     * If this field is set to `false` or isn't specified, only jobs that include
     * street level addresses will be returned by commute search.
     *
     * Generated from protobuf field <code>bool allow_imprecise_addresses = 4;</code>
     */
    protected $allow_imprecise_addresses = false;
    protected $traffic_option;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $commute_method
     *           Required. The method of transportation to calculate the commute time for.
     *     @type \Google\Type\LatLng $start_coordinates
     *           Required. The latitude and longitude of the location to calculate the
     *           commute time from.
     *     @type \Google\Protobuf\Duration $travel_duration
     *           Required. The maximum travel time in seconds. The maximum allowed value is `3600s`
     *           (one hour). Format is `123s`.
     *     @type bool $allow_imprecise_addresses
     *           If `true`, jobs without street level addresses may also be returned.
     *           For city level addresses, the city center is used. For state and coarser
     *           level addresses, text matching is used.
     *           If this field is set to `false` or isn't specified, only jobs that include
     *           street level addresses will be returned by commute search.
     *     @type int $road_traffic
     *           Specifies the traffic density to use when calculating commute time.
     *     @type \Google\Type\TimeOfDay $departure_time
     *           The departure time used to calculate traffic impact, represented as
     *           [google.type.TimeOfDay][google.type.TimeOfDay] in local time zone.
     *           Currently traffic model is restricted to hour level resolution.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Talent\V4Beta1\Filters::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The method of transportation to calculate the commute time for.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.CommuteMethod commute_method = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getCommuteMethod()
    {
        return $this->commute_method;
    }

    /**
     * Required. The method of transportation to calculate the commute time for.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.CommuteMethod commute_method = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setCommuteMethod($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Talent\V4beta1\CommuteMethod::class);
        $this->commute_method = $var;

        return $this;
    }

    /**
     * Required. The latitude and longitude of the location to calculate the
     * commute time from.
     *
     * Generated from protobuf field <code>.google.type.LatLng start_coordinates = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Type\LatLng|null
     */
    public function getStartCoordinates()
    {
        return isset($this->start_coordinates) ? $this->start_coordinates : null;
    }

    public function hasStartCoordinates()
    {
        return isset($this->start_coordinates);
    }

    public function clearStartCoordinates()
    {
        unset($this->start_coordinates);
    }

    /**
     * Required. The latitude and longitude of the location to calculate the
     * commute time from.
     *
     * Generated from protobuf field <code>.google.type.LatLng start_coordinates = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Type\LatLng $var
     * @return $this
     */
    public function setStartCoordinates($var)
    {
        GPBUtil::checkMessage($var, \Google\Type\LatLng::class);
        $this->start_coordinates = $var;

        return $this;
    }

    /**
     * Required. The maximum travel time in seconds. The maximum allowed value is `3600s`
     * (one hour). Format is `123s`.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration travel_duration = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getTravelDuration()
    {
        return isset($this->travel_duration) ? $this->travel_duration : null;
    }

    public function hasTravelDuration()
    {
        return isset($this->travel_duration);
    }

    public function clearTravelDuration()
    {
        unset($this->travel_duration);
    }

    /**
     * Required. The maximum travel time in seconds. The maximum allowed value is `3600s`
     * (one hour). Format is `123s`.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration travel_duration = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setTravelDuration($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->travel_duration = $var;

        return $this;
    }

    /**
     * If `true`, jobs without street level addresses may also be returned.
     * For city level addresses, the city center is used. For state and coarser
     * level addresses, text matching is used.
     * If this field is set to `false` or isn't specified, only jobs that include
     * street level addresses will be returned by commute search.
     *
     * Generated from protobuf field <code>bool allow_imprecise_addresses = 4;</code>
     * @return bool
     */
    public function getAllowImpreciseAddresses()
    {
        return $this->allow_imprecise_addresses;
    }

    /**
     * If `true`, jobs without street level addresses may also be returned.
     * For city level addresses, the city center is used. For state and coarser
     * level addresses, text matching is used.
     * If this field is set to `false` or isn't specified, only jobs that include
     * street level addresses will be returned by commute search.
     *
     * Generated from protobuf field <code>bool allow_imprecise_addresses = 4;</code>
     * @param bool $var
     * @return $this
     */
    public function setAllowImpreciseAddresses($var)
    {
        GPBUtil::checkBool($var);
        $this->allow_imprecise_addresses = $var;

        return $this;
    }

    /**
     * Specifies the traffic density to use when calculating commute time.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.CommuteFilter.RoadTraffic road_traffic = 5;</code>
     * @return int
     */
    public function getRoadTraffic()
    {
        return $this->readOneof(5);
    }

    public function hasRoadTraffic()
    {
        return $this->hasOneof(5);
    }

    /**
     * Specifies the traffic density to use when calculating commute time.
     *
     * Generated from protobuf field <code>.google.cloud.talent.v4beta1.CommuteFilter.RoadTraffic road_traffic = 5;</code>
     * @param int $var
     * @return $this
     */
    public function setRoadTraffic($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Talent\V4beta1\CommuteFilter\RoadTraffic::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * The departure time used to calculate traffic impact, represented as
     * [google.type.TimeOfDay][google.type.TimeOfDay] in local time zone.
     * Currently traffic model is restricted to hour level resolution.
     *
     * Generated from protobuf field <code>.google.type.TimeOfDay departure_time = 6;</code>
     * @return \Google\Type\TimeOfDay|null
     */
    public function getDepartureTime()
    {
        return $this->readOneof(6);
    }

    public function hasDepartureTime()
    {
        return $this->hasOneof(6);
    }

    /**
     * The departure time used to calculate traffic impact, represented as
     * [google.type.TimeOfDay][google.type.TimeOfDay] in local time zone.
     * Currently traffic model is restricted to hour level resolution.
     *
     * Generated from protobuf field <code>.google.type.TimeOfDay departure_time = 6;</code>
     * @param \Google\Type\TimeOfDay $var
     * @return $this
     */
    public function setDepartureTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Type\TimeOfDay::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getTrafficOption()
    {
        return $this->whichOneof("traffic_option");
    }

}

