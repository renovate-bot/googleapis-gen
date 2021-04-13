<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/migration/v2alpha/migration_service.proto

namespace Google\Cloud\Bigquery\Migration\V2alpha;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A request to get a previously created migration workflow.
 *
 * Generated from protobuf message <code>google.cloud.bigquery.migration.v2alpha.GetMigrationWorkflowRequest</code>
 */
class GetMigrationWorkflowRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The unique identifier for the migration workflow.
     * Example: `projects/123/locations/us/workflows/1234`
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * The list of fields to be retrieved.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask read_mask = 2;</code>
     */
    protected $read_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The unique identifier for the migration workflow.
     *           Example: `projects/123/locations/us/workflows/1234`
     *     @type \Google\Protobuf\FieldMask $read_mask
     *           The list of fields to be retrieved.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Bigquery\Migration\V2Alpha\MigrationService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The unique identifier for the migration workflow.
     * Example: `projects/123/locations/us/workflows/1234`
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The unique identifier for the migration workflow.
     * Example: `projects/123/locations/us/workflows/1234`
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * The list of fields to be retrieved.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask read_mask = 2;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getReadMask()
    {
        return isset($this->read_mask) ? $this->read_mask : null;
    }

    public function hasReadMask()
    {
        return isset($this->read_mask);
    }

    public function clearReadMask()
    {
        unset($this->read_mask);
    }

    /**
     * The list of fields to be retrieved.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask read_mask = 2;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setReadMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->read_mask = $var;

        return $this;
    }

}

