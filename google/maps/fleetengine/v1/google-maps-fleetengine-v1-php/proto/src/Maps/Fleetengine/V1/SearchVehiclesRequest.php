<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/maps/fleetengine/v1/vehicle_api.proto

namespace Maps\Fleetengine\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * SearchVehicles request message.
 *
 * Generated from protobuf message <code>maps.fleetengine.v1.SearchVehiclesRequest</code>
 */
class SearchVehiclesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The standard Fleet Engine request header.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.RequestHeader header = 1;</code>
     */
    protected $header = null;
    /**
     * Required. Must be in the format "providers/{provider}".
     * The provider must be the Project ID (for example, sample-cloud-project)
     * of the Google Cloud Project of which the service account making
     * this call is a member.
     *
     * Generated from protobuf field <code>string parent = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $parent = '';
    /**
     * Required. The pickup point to search near.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.TerminalLocation pickup_point = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $pickup_point = null;
    /**
     * The customer's intended dropoff location. The field is required if
     * trip_types contains TripType.SHARED.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.TerminalLocation dropoff_point = 5;</code>
     */
    protected $dropoff_point = null;
    /**
     * Required. Defines the vehicle search radius around the pickup point. Only
     * vehicles within the search radius will be returned. Value must be between
     * 400 and 10000 meters.
     *
     * Generated from protobuf field <code>int32 pickup_radius_meters = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $pickup_radius_meters = 0;
    /**
     * Required. Specifies the maximum number of available vehicles to return. By
     * default, the Fleet Engine limits the number to  50.
     *
     * Generated from protobuf field <code>int32 count = 7 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $count = 0;
    /**
     * Required. Specifies the minimum number of passengers allowed in the
     * vehicle. Must number must be greater than or equal to one. The driver is
     * not considered in the capacity search. This number indicates the number of
     * passengers being considered for a trip.
     *
     * Generated from protobuf field <code>int32 minimum_capacity = 8 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $minimum_capacity = 0;
    /**
     * Required. Restricts the search to only those vehicles that support at least
     * one of the specified trip types.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.TripType trip_types = 9 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private $trip_types;
    /**
     * Restricts the search to only those vehicles that have updated their
     * locations within the specified duration back from now. If this field is not
     * set, the server uses five minutes as the default value.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration maximum_staleness = 10;</code>
     */
    protected $maximum_staleness = null;
    /**
     * Required. Restricts the search to those vehicles with the specified types.
     * At least one vehicle type must be specified.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.Vehicle.VehicleType vehicle_types = 14 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private $vehicle_types;
    /**
     * Callers can form complex logical operations using the
     * requiredAttributes and requiredOneOfAttributes fields.
     * requiredAttributes is a list; requiredOneOfAttributes uses a message which
     * allows a list of lists. In combination, the two fields allow the
     * composition of this expression:
     * ```
     * (required_attribute[0] AND required_attribute[1] AND ...)
     * AND
     * (required_one_of_attribute[0][0] OR required_one_of_attribute[0][1] OR ...)
     * AND
     * (required_one_of_attribute[1][0] OR required_one_of_attribute[1][1] OR ...)
     * ```
     * Restricts the search to only those vehicles with the specified attributes.
     * This field is a conjunction/AND operation. Your app can specify up to 100
     * attributes; however, the combined key:value string length cannot exceed
     * 1024 characters.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttribute required_attributes = 12;</code>
     */
    private $required_attributes;
    /**
     * Restricts the search to only those vehicles with at least one of
     * the specified attributes applied to each VehicleAttributeList. Within each
     * list, a vehicle must match at least one of the attributes. This field is an
     * inclusive disjunction/OR operation in each VehicleAttributeList and a
     * conjunction/AND operation across the collection of VehicleAttributeList.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttributeList required_one_of_attributes = 15;</code>
     */
    private $required_one_of_attributes;
    /**
     * Restricts the search to only those vehicles with at least one set of the
     * specified attributes in the VehicleAttributeList. Within each list, a
     * vehicle must match all of the attributes. This field is a conjunction/AND
     * operation in each VehicleAttributeList and inclusive disjunction/OR
     * operation across the collection of VehicleAttributeList.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttributeList required_one_of_attribute_sets = 20;</code>
     */
    private $required_one_of_attribute_sets;
    /**
     * Required. Specifies ordering criterion for results.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.SearchVehiclesRequest.VehicleMatchOrder order_by = 13 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $order_by = 0;
    /**
     * Indicates if a vehicle with an active trip is eligible for
     * another match. If `false`, a vehicle is excluded from search results.
     * If `true`, search results include vehicles with `TripStatus` of
     * `ENROUTE_TO_DROPOFF`. The services only use this field if
     * the `SearchVehicles` request has `TripType` set to EXCLUSIVE.
     * Default value is `false`.
     *
     * Generated from protobuf field <code>bool include_back_to_back = 18;</code>
     */
    protected $include_back_to_back = false;
    /**
     * Indicates the ID of the trip the searchVehicleRequest is
     * associated with.
     *
     * Generated from protobuf field <code>string trip_id = 19;</code>
     */
    protected $trip_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Maps\Fleetengine\V1\RequestHeader $header
     *           The standard Fleet Engine request header.
     *     @type string $parent
     *           Required. Must be in the format "providers/{provider}".
     *           The provider must be the Project ID (for example, sample-cloud-project)
     *           of the Google Cloud Project of which the service account making
     *           this call is a member.
     *     @type \Maps\Fleetengine\V1\TerminalLocation $pickup_point
     *           Required. The pickup point to search near.
     *     @type \Maps\Fleetengine\V1\TerminalLocation $dropoff_point
     *           The customer's intended dropoff location. The field is required if
     *           trip_types contains TripType.SHARED.
     *     @type int $pickup_radius_meters
     *           Required. Defines the vehicle search radius around the pickup point. Only
     *           vehicles within the search radius will be returned. Value must be between
     *           400 and 10000 meters.
     *     @type int $count
     *           Required. Specifies the maximum number of available vehicles to return. By
     *           default, the Fleet Engine limits the number to  50.
     *     @type int $minimum_capacity
     *           Required. Specifies the minimum number of passengers allowed in the
     *           vehicle. Must number must be greater than or equal to one. The driver is
     *           not considered in the capacity search. This number indicates the number of
     *           passengers being considered for a trip.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $trip_types
     *           Required. Restricts the search to only those vehicles that support at least
     *           one of the specified trip types.
     *     @type \Google\Protobuf\Duration $maximum_staleness
     *           Restricts the search to only those vehicles that have updated their
     *           locations within the specified duration back from now. If this field is not
     *           set, the server uses five minutes as the default value.
     *     @type \Maps\Fleetengine\V1\Vehicle\VehicleType[]|\Google\Protobuf\Internal\RepeatedField $vehicle_types
     *           Required. Restricts the search to those vehicles with the specified types.
     *           At least one vehicle type must be specified.
     *     @type \Maps\Fleetengine\V1\VehicleAttribute[]|\Google\Protobuf\Internal\RepeatedField $required_attributes
     *           Callers can form complex logical operations using the
     *           requiredAttributes and requiredOneOfAttributes fields.
     *           requiredAttributes is a list; requiredOneOfAttributes uses a message which
     *           allows a list of lists. In combination, the two fields allow the
     *           composition of this expression:
     *           ```
     *           (required_attribute[0] AND required_attribute[1] AND ...)
     *           AND
     *           (required_one_of_attribute[0][0] OR required_one_of_attribute[0][1] OR ...)
     *           AND
     *           (required_one_of_attribute[1][0] OR required_one_of_attribute[1][1] OR ...)
     *           ```
     *           Restricts the search to only those vehicles with the specified attributes.
     *           This field is a conjunction/AND operation. Your app can specify up to 100
     *           attributes; however, the combined key:value string length cannot exceed
     *           1024 characters.
     *     @type \Maps\Fleetengine\V1\VehicleAttributeList[]|\Google\Protobuf\Internal\RepeatedField $required_one_of_attributes
     *           Restricts the search to only those vehicles with at least one of
     *           the specified attributes applied to each VehicleAttributeList. Within each
     *           list, a vehicle must match at least one of the attributes. This field is an
     *           inclusive disjunction/OR operation in each VehicleAttributeList and a
     *           conjunction/AND operation across the collection of VehicleAttributeList.
     *     @type \Maps\Fleetengine\V1\VehicleAttributeList[]|\Google\Protobuf\Internal\RepeatedField $required_one_of_attribute_sets
     *           Restricts the search to only those vehicles with at least one set of the
     *           specified attributes in the VehicleAttributeList. Within each list, a
     *           vehicle must match all of the attributes. This field is a conjunction/AND
     *           operation in each VehicleAttributeList and inclusive disjunction/OR
     *           operation across the collection of VehicleAttributeList.
     *     @type int $order_by
     *           Required. Specifies ordering criterion for results.
     *     @type bool $include_back_to_back
     *           Indicates if a vehicle with an active trip is eligible for
     *           another match. If `false`, a vehicle is excluded from search results.
     *           If `true`, search results include vehicles with `TripStatus` of
     *           `ENROUTE_TO_DROPOFF`. The services only use this field if
     *           the `SearchVehicles` request has `TripType` set to EXCLUSIVE.
     *           Default value is `false`.
     *     @type string $trip_id
     *           Indicates the ID of the trip the searchVehicleRequest is
     *           associated with.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Maps\Fleetengine\V1\VehicleApi::initOnce();
        parent::__construct($data);
    }

    /**
     * The standard Fleet Engine request header.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.RequestHeader header = 1;</code>
     * @return \Maps\Fleetengine\V1\RequestHeader|null
     */
    public function getHeader()
    {
        return isset($this->header) ? $this->header : null;
    }

    public function hasHeader()
    {
        return isset($this->header);
    }

    public function clearHeader()
    {
        unset($this->header);
    }

    /**
     * The standard Fleet Engine request header.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.RequestHeader header = 1;</code>
     * @param \Maps\Fleetengine\V1\RequestHeader $var
     * @return $this
     */
    public function setHeader($var)
    {
        GPBUtil::checkMessage($var, \Maps\Fleetengine\V1\RequestHeader::class);
        $this->header = $var;

        return $this;
    }

    /**
     * Required. Must be in the format "providers/{provider}".
     * The provider must be the Project ID (for example, sample-cloud-project)
     * of the Google Cloud Project of which the service account making
     * this call is a member.
     *
     * Generated from protobuf field <code>string parent = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. Must be in the format "providers/{provider}".
     * The provider must be the Project ID (for example, sample-cloud-project)
     * of the Google Cloud Project of which the service account making
     * this call is a member.
     *
     * Generated from protobuf field <code>string parent = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Required. The pickup point to search near.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.TerminalLocation pickup_point = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Maps\Fleetengine\V1\TerminalLocation|null
     */
    public function getPickupPoint()
    {
        return isset($this->pickup_point) ? $this->pickup_point : null;
    }

    public function hasPickupPoint()
    {
        return isset($this->pickup_point);
    }

    public function clearPickupPoint()
    {
        unset($this->pickup_point);
    }

    /**
     * Required. The pickup point to search near.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.TerminalLocation pickup_point = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Maps\Fleetengine\V1\TerminalLocation $var
     * @return $this
     */
    public function setPickupPoint($var)
    {
        GPBUtil::checkMessage($var, \Maps\Fleetengine\V1\TerminalLocation::class);
        $this->pickup_point = $var;

        return $this;
    }

    /**
     * The customer's intended dropoff location. The field is required if
     * trip_types contains TripType.SHARED.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.TerminalLocation dropoff_point = 5;</code>
     * @return \Maps\Fleetengine\V1\TerminalLocation|null
     */
    public function getDropoffPoint()
    {
        return isset($this->dropoff_point) ? $this->dropoff_point : null;
    }

    public function hasDropoffPoint()
    {
        return isset($this->dropoff_point);
    }

    public function clearDropoffPoint()
    {
        unset($this->dropoff_point);
    }

    /**
     * The customer's intended dropoff location. The field is required if
     * trip_types contains TripType.SHARED.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.TerminalLocation dropoff_point = 5;</code>
     * @param \Maps\Fleetengine\V1\TerminalLocation $var
     * @return $this
     */
    public function setDropoffPoint($var)
    {
        GPBUtil::checkMessage($var, \Maps\Fleetengine\V1\TerminalLocation::class);
        $this->dropoff_point = $var;

        return $this;
    }

    /**
     * Required. Defines the vehicle search radius around the pickup point. Only
     * vehicles within the search radius will be returned. Value must be between
     * 400 and 10000 meters.
     *
     * Generated from protobuf field <code>int32 pickup_radius_meters = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getPickupRadiusMeters()
    {
        return $this->pickup_radius_meters;
    }

    /**
     * Required. Defines the vehicle search radius around the pickup point. Only
     * vehicles within the search radius will be returned. Value must be between
     * 400 and 10000 meters.
     *
     * Generated from protobuf field <code>int32 pickup_radius_meters = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setPickupRadiusMeters($var)
    {
        GPBUtil::checkInt32($var);
        $this->pickup_radius_meters = $var;

        return $this;
    }

    /**
     * Required. Specifies the maximum number of available vehicles to return. By
     * default, the Fleet Engine limits the number to  50.
     *
     * Generated from protobuf field <code>int32 count = 7 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getCount()
    {
        return $this->count;
    }

    /**
     * Required. Specifies the maximum number of available vehicles to return. By
     * default, the Fleet Engine limits the number to  50.
     *
     * Generated from protobuf field <code>int32 count = 7 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setCount($var)
    {
        GPBUtil::checkInt32($var);
        $this->count = $var;

        return $this;
    }

    /**
     * Required. Specifies the minimum number of passengers allowed in the
     * vehicle. Must number must be greater than or equal to one. The driver is
     * not considered in the capacity search. This number indicates the number of
     * passengers being considered for a trip.
     *
     * Generated from protobuf field <code>int32 minimum_capacity = 8 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getMinimumCapacity()
    {
        return $this->minimum_capacity;
    }

    /**
     * Required. Specifies the minimum number of passengers allowed in the
     * vehicle. Must number must be greater than or equal to one. The driver is
     * not considered in the capacity search. This number indicates the number of
     * passengers being considered for a trip.
     *
     * Generated from protobuf field <code>int32 minimum_capacity = 8 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setMinimumCapacity($var)
    {
        GPBUtil::checkInt32($var);
        $this->minimum_capacity = $var;

        return $this;
    }

    /**
     * Required. Restricts the search to only those vehicles that support at least
     * one of the specified trip types.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.TripType trip_types = 9 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTripTypes()
    {
        return $this->trip_types;
    }

    /**
     * Required. Restricts the search to only those vehicles that support at least
     * one of the specified trip types.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.TripType trip_types = 9 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTripTypes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::ENUM, \Maps\Fleetengine\V1\TripType::class);
        $this->trip_types = $arr;

        return $this;
    }

    /**
     * Restricts the search to only those vehicles that have updated their
     * locations within the specified duration back from now. If this field is not
     * set, the server uses five minutes as the default value.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration maximum_staleness = 10;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getMaximumStaleness()
    {
        return isset($this->maximum_staleness) ? $this->maximum_staleness : null;
    }

    public function hasMaximumStaleness()
    {
        return isset($this->maximum_staleness);
    }

    public function clearMaximumStaleness()
    {
        unset($this->maximum_staleness);
    }

    /**
     * Restricts the search to only those vehicles that have updated their
     * locations within the specified duration back from now. If this field is not
     * set, the server uses five minutes as the default value.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration maximum_staleness = 10;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setMaximumStaleness($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->maximum_staleness = $var;

        return $this;
    }

    /**
     * Required. Restricts the search to those vehicles with the specified types.
     * At least one vehicle type must be specified.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.Vehicle.VehicleType vehicle_types = 14 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getVehicleTypes()
    {
        return $this->vehicle_types;
    }

    /**
     * Required. Restricts the search to those vehicles with the specified types.
     * At least one vehicle type must be specified.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.Vehicle.VehicleType vehicle_types = 14 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Maps\Fleetengine\V1\Vehicle\VehicleType[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setVehicleTypes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Maps\Fleetengine\V1\Vehicle\VehicleType::class);
        $this->vehicle_types = $arr;

        return $this;
    }

    /**
     * Callers can form complex logical operations using the
     * requiredAttributes and requiredOneOfAttributes fields.
     * requiredAttributes is a list; requiredOneOfAttributes uses a message which
     * allows a list of lists. In combination, the two fields allow the
     * composition of this expression:
     * ```
     * (required_attribute[0] AND required_attribute[1] AND ...)
     * AND
     * (required_one_of_attribute[0][0] OR required_one_of_attribute[0][1] OR ...)
     * AND
     * (required_one_of_attribute[1][0] OR required_one_of_attribute[1][1] OR ...)
     * ```
     * Restricts the search to only those vehicles with the specified attributes.
     * This field is a conjunction/AND operation. Your app can specify up to 100
     * attributes; however, the combined key:value string length cannot exceed
     * 1024 characters.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttribute required_attributes = 12;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRequiredAttributes()
    {
        return $this->required_attributes;
    }

    /**
     * Callers can form complex logical operations using the
     * requiredAttributes and requiredOneOfAttributes fields.
     * requiredAttributes is a list; requiredOneOfAttributes uses a message which
     * allows a list of lists. In combination, the two fields allow the
     * composition of this expression:
     * ```
     * (required_attribute[0] AND required_attribute[1] AND ...)
     * AND
     * (required_one_of_attribute[0][0] OR required_one_of_attribute[0][1] OR ...)
     * AND
     * (required_one_of_attribute[1][0] OR required_one_of_attribute[1][1] OR ...)
     * ```
     * Restricts the search to only those vehicles with the specified attributes.
     * This field is a conjunction/AND operation. Your app can specify up to 100
     * attributes; however, the combined key:value string length cannot exceed
     * 1024 characters.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttribute required_attributes = 12;</code>
     * @param \Maps\Fleetengine\V1\VehicleAttribute[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRequiredAttributes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Maps\Fleetengine\V1\VehicleAttribute::class);
        $this->required_attributes = $arr;

        return $this;
    }

    /**
     * Restricts the search to only those vehicles with at least one of
     * the specified attributes applied to each VehicleAttributeList. Within each
     * list, a vehicle must match at least one of the attributes. This field is an
     * inclusive disjunction/OR operation in each VehicleAttributeList and a
     * conjunction/AND operation across the collection of VehicleAttributeList.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttributeList required_one_of_attributes = 15;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRequiredOneOfAttributes()
    {
        return $this->required_one_of_attributes;
    }

    /**
     * Restricts the search to only those vehicles with at least one of
     * the specified attributes applied to each VehicleAttributeList. Within each
     * list, a vehicle must match at least one of the attributes. This field is an
     * inclusive disjunction/OR operation in each VehicleAttributeList and a
     * conjunction/AND operation across the collection of VehicleAttributeList.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttributeList required_one_of_attributes = 15;</code>
     * @param \Maps\Fleetengine\V1\VehicleAttributeList[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRequiredOneOfAttributes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Maps\Fleetengine\V1\VehicleAttributeList::class);
        $this->required_one_of_attributes = $arr;

        return $this;
    }

    /**
     * Restricts the search to only those vehicles with at least one set of the
     * specified attributes in the VehicleAttributeList. Within each list, a
     * vehicle must match all of the attributes. This field is a conjunction/AND
     * operation in each VehicleAttributeList and inclusive disjunction/OR
     * operation across the collection of VehicleAttributeList.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttributeList required_one_of_attribute_sets = 20;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRequiredOneOfAttributeSets()
    {
        return $this->required_one_of_attribute_sets;
    }

    /**
     * Restricts the search to only those vehicles with at least one set of the
     * specified attributes in the VehicleAttributeList. Within each list, a
     * vehicle must match all of the attributes. This field is a conjunction/AND
     * operation in each VehicleAttributeList and inclusive disjunction/OR
     * operation across the collection of VehicleAttributeList.
     *
     * Generated from protobuf field <code>repeated .maps.fleetengine.v1.VehicleAttributeList required_one_of_attribute_sets = 20;</code>
     * @param \Maps\Fleetengine\V1\VehicleAttributeList[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRequiredOneOfAttributeSets($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Maps\Fleetengine\V1\VehicleAttributeList::class);
        $this->required_one_of_attribute_sets = $arr;

        return $this;
    }

    /**
     * Required. Specifies ordering criterion for results.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.SearchVehiclesRequest.VehicleMatchOrder order_by = 13 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getOrderBy()
    {
        return $this->order_by;
    }

    /**
     * Required. Specifies ordering criterion for results.
     *
     * Generated from protobuf field <code>.maps.fleetengine.v1.SearchVehiclesRequest.VehicleMatchOrder order_by = 13 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setOrderBy($var)
    {
        GPBUtil::checkEnum($var, \Maps\Fleetengine\V1\SearchVehiclesRequest\VehicleMatchOrder::class);
        $this->order_by = $var;

        return $this;
    }

    /**
     * Indicates if a vehicle with an active trip is eligible for
     * another match. If `false`, a vehicle is excluded from search results.
     * If `true`, search results include vehicles with `TripStatus` of
     * `ENROUTE_TO_DROPOFF`. The services only use this field if
     * the `SearchVehicles` request has `TripType` set to EXCLUSIVE.
     * Default value is `false`.
     *
     * Generated from protobuf field <code>bool include_back_to_back = 18;</code>
     * @return bool
     */
    public function getIncludeBackToBack()
    {
        return $this->include_back_to_back;
    }

    /**
     * Indicates if a vehicle with an active trip is eligible for
     * another match. If `false`, a vehicle is excluded from search results.
     * If `true`, search results include vehicles with `TripStatus` of
     * `ENROUTE_TO_DROPOFF`. The services only use this field if
     * the `SearchVehicles` request has `TripType` set to EXCLUSIVE.
     * Default value is `false`.
     *
     * Generated from protobuf field <code>bool include_back_to_back = 18;</code>
     * @param bool $var
     * @return $this
     */
    public function setIncludeBackToBack($var)
    {
        GPBUtil::checkBool($var);
        $this->include_back_to_back = $var;

        return $this;
    }

    /**
     * Indicates the ID of the trip the searchVehicleRequest is
     * associated with.
     *
     * Generated from protobuf field <code>string trip_id = 19;</code>
     * @return string
     */
    public function getTripId()
    {
        return $this->trip_id;
    }

    /**
     * Indicates the ID of the trip the searchVehicleRequest is
     * associated with.
     *
     * Generated from protobuf field <code>string trip_id = 19;</code>
     * @param string $var
     * @return $this
     */
    public function setTripId($var)
    {
        GPBUtil::checkString($var, True);
        $this->trip_id = $var;

        return $this;
    }

}

