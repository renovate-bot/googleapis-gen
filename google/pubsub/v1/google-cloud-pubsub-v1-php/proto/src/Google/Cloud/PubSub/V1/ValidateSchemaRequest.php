<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/pubsub/v1/schema.proto

namespace Google\Cloud\PubSub\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request for the `ValidateSchema` method.
 *
 * Generated from protobuf message <code>google.pubsub.v1.ValidateSchemaRequest</code>
 */
class ValidateSchemaRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the project in which to validate schemas.
     * Format is `projects/{project-id}`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The schema object to validate.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.Schema schema = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $schema = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the project in which to validate schemas.
     *           Format is `projects/{project-id}`.
     *     @type \Google\Cloud\PubSub\V1\Schema $schema
     *           Required. The schema object to validate.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Pubsub\V1\Schema::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the project in which to validate schemas.
     * Format is `projects/{project-id}`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the project in which to validate schemas.
     * Format is `projects/{project-id}`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Required. The schema object to validate.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.Schema schema = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\PubSub\V1\Schema|null
     */
    public function getSchema()
    {
        return isset($this->schema) ? $this->schema : null;
    }

    public function hasSchema()
    {
        return isset($this->schema);
    }

    public function clearSchema()
    {
        unset($this->schema);
    }

    /**
     * Required. The schema object to validate.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.Schema schema = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\PubSub\V1\Schema $var
     * @return $this
     */
    public function setSchema($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\PubSub\V1\Schema::class);
        $this->schema = $var;

        return $this;
    }

}

