<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/market/v2/resources.proto

namespace Ccc\Hosted\Marketplace\V2\CustomerLicense;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>ccc.hosted.marketplace.v2.CustomerLicense.Editions</code>
 */
class Editions extends \Google\Protobuf\Internal\Message
{
    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>string edition_id = 405 [deprecated = true];</code>
     */
    protected $edition_id = '';
    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>int32 seat_count = 406 [deprecated = true];</code>
     */
    protected $seat_count = 0;
    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>int32 assigned_seats = 409 [deprecated = true];</code>
     */
    protected $assigned_seats = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $edition_id
     *           (Deprecated)
     *     @type int $seat_count
     *           (Deprecated)
     *     @type int $assigned_seats
     *           (Deprecated)
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Market\V2\Resources::initOnce();
        parent::__construct($data);
    }

    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>string edition_id = 405 [deprecated = true];</code>
     * @return string
     */
    public function getEditionId()
    {
        return $this->edition_id;
    }

    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>string edition_id = 405 [deprecated = true];</code>
     * @param string $var
     * @return $this
     */
    public function setEditionId($var)
    {
        GPBUtil::checkString($var, True);
        $this->edition_id = $var;

        return $this;
    }

    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>int32 seat_count = 406 [deprecated = true];</code>
     * @return int
     */
    public function getSeatCount()
    {
        return $this->seat_count;
    }

    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>int32 seat_count = 406 [deprecated = true];</code>
     * @param int $var
     * @return $this
     */
    public function setSeatCount($var)
    {
        GPBUtil::checkInt32($var);
        $this->seat_count = $var;

        return $this;
    }

    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>int32 assigned_seats = 409 [deprecated = true];</code>
     * @return int
     */
    public function getAssignedSeats()
    {
        return $this->assigned_seats;
    }

    /**
     * (Deprecated)
     *
     * Generated from protobuf field <code>int32 assigned_seats = 409 [deprecated = true];</code>
     * @param int $var
     * @return $this
     */
    public function setAssignedSeats($var)
    {
        GPBUtil::checkInt32($var);
        $this->assigned_seats = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Editions::class, \Ccc\Hosted\Marketplace\V2\CustomerLicense_Editions::class);

