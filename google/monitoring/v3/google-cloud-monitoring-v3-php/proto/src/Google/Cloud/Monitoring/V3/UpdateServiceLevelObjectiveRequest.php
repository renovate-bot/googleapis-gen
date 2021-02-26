<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/service_service.proto

namespace Google\Cloud\Monitoring\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The `UpdateServiceLevelObjective` request.
 *
 * Generated from protobuf message <code>google.monitoring.v3.UpdateServiceLevelObjectiveRequest</code>
 */
class UpdateServiceLevelObjectiveRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The `ServiceLevelObjective` to draw updates from.
     * The given `name` specifies the resource to update.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.ServiceLevelObjective service_level_objective = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $service_level_objective = null;
    /**
     * A set of field paths defining which fields to use for the update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Monitoring\V3\ServiceLevelObjective $service_level_objective
     *           Required. The `ServiceLevelObjective` to draw updates from.
     *           The given `name` specifies the resource to update.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           A set of field paths defining which fields to use for the update.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\ServiceService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The `ServiceLevelObjective` to draw updates from.
     * The given `name` specifies the resource to update.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.ServiceLevelObjective service_level_objective = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Monitoring\V3\ServiceLevelObjective|null
     */
    public function getServiceLevelObjective()
    {
        return isset($this->service_level_objective) ? $this->service_level_objective : null;
    }

    public function hasServiceLevelObjective()
    {
        return isset($this->service_level_objective);
    }

    public function clearServiceLevelObjective()
    {
        unset($this->service_level_objective);
    }

    /**
     * Required. The `ServiceLevelObjective` to draw updates from.
     * The given `name` specifies the resource to update.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.ServiceLevelObjective service_level_objective = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Monitoring\V3\ServiceLevelObjective $var
     * @return $this
     */
    public function setServiceLevelObjective($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\ServiceLevelObjective::class);
        $this->service_level_objective = $var;

        return $this;
    }

    /**
     * A set of field paths defining which fields to use for the update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * A set of field paths defining which fields to use for the update.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

