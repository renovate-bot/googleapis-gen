<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/sql/v1/cloud_sql_instances.proto

namespace Google\Cloud\Sql\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Database instance clone request.
 *
 * Generated from protobuf message <code>google.cloud.sql.v1.InstancesCloneRequest</code>
 */
class InstancesCloneRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Contains details about the clone operation.
     *
     * Generated from protobuf field <code>.google.cloud.sql.v1.CloneContext clone_context = 1;</code>
     */
    protected $clone_context = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Sql\V1\CloneContext $clone_context
     *           Contains details about the clone operation.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Sql\V1\CloudSqlInstances::initOnce();
        parent::__construct($data);
    }

    /**
     * Contains details about the clone operation.
     *
     * Generated from protobuf field <code>.google.cloud.sql.v1.CloneContext clone_context = 1;</code>
     * @return \Google\Cloud\Sql\V1\CloneContext|null
     */
    public function getCloneContext()
    {
        return $this->clone_context;
    }

    public function hasCloneContext()
    {
        return isset($this->clone_context);
    }

    public function clearCloneContext()
    {
        unset($this->clone_context);
    }

    /**
     * Contains details about the clone operation.
     *
     * Generated from protobuf field <code>.google.cloud.sql.v1.CloneContext clone_context = 1;</code>
     * @param \Google\Cloud\Sql\V1\CloneContext $var
     * @return $this
     */
    public function setCloneContext($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Sql\V1\CloneContext::class);
        $this->clone_context = $var;

        return $this;
    }

}

