<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/storage/v2/storage.proto

namespace Google\Storage\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The owner of a specific resource.
 *
 * Generated from protobuf message <code>google.storage.v2.Owner</code>
 */
class Owner extends \Google\Protobuf\Internal\Message
{
    /**
     * The entity, in the form `user-`*userId*.
     *
     * Generated from protobuf field <code>string entity = 1;</code>
     */
    protected $entity = '';
    /**
     * The ID for the entity.
     *
     * Generated from protobuf field <code>string entity_id = 2;</code>
     */
    protected $entity_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $entity
     *           The entity, in the form `user-`*userId*.
     *     @type string $entity_id
     *           The ID for the entity.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Storage\V2\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * The entity, in the form `user-`*userId*.
     *
     * Generated from protobuf field <code>string entity = 1;</code>
     * @return string
     */
    public function getEntity()
    {
        return $this->entity;
    }

    /**
     * The entity, in the form `user-`*userId*.
     *
     * Generated from protobuf field <code>string entity = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setEntity($var)
    {
        GPBUtil::checkString($var, True);
        $this->entity = $var;

        return $this;
    }

    /**
     * The ID for the entity.
     *
     * Generated from protobuf field <code>string entity_id = 2;</code>
     * @return string
     */
    public function getEntityId()
    {
        return $this->entity_id;
    }

    /**
     * The ID for the entity.
     *
     * Generated from protobuf field <code>string entity_id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setEntityId($var)
    {
        GPBUtil::checkString($var, True);
        $this->entity_id = $var;

        return $this;
    }

}

