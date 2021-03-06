<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/area120/tables/v1alpha1/tables.proto

namespace Google\Area120\Tables\V1alpha1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A single item in a labeled column.
 *
 * Generated from protobuf message <code>google.area120.tables.v1alpha1.LabeledItem</code>
 */
class LabeledItem extends \Google\Protobuf\Internal\Message
{
    /**
     * Display string as entered by user.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Internal id associated with the item.
     *
     * Generated from protobuf field <code>string id = 2;</code>
     */
    protected $id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Display string as entered by user.
     *     @type string $id
     *           Internal id associated with the item.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Area120\Tables\V1Alpha1\Tables::initOnce();
        parent::__construct($data);
    }

    /**
     * Display string as entered by user.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Display string as entered by user.
     *
     * Generated from protobuf field <code>string name = 1;</code>
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
     * Internal id associated with the item.
     *
     * Generated from protobuf field <code>string id = 2;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Internal id associated with the item.
     *
     * Generated from protobuf field <code>string id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

}

