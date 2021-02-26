<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/example/library/v1/library.proto

namespace Google\Example\Library\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for LibraryService.CreateShelf.
 *
 * Generated from protobuf message <code>google.example.library.v1.CreateShelfRequest</code>
 */
class CreateShelfRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The shelf to create.
     *
     * Generated from protobuf field <code>.google.example.library.v1.Shelf shelf = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $shelf = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Example\Library\V1\Shelf $shelf
     *           The shelf to create.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Example\Library\V1\Library::initOnce();
        parent::__construct($data);
    }

    /**
     * The shelf to create.
     *
     * Generated from protobuf field <code>.google.example.library.v1.Shelf shelf = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Example\Library\V1\Shelf|null
     */
    public function getShelf()
    {
        return isset($this->shelf) ? $this->shelf : null;
    }

    public function hasShelf()
    {
        return isset($this->shelf);
    }

    public function clearShelf()
    {
        unset($this->shelf);
    }

    /**
     * The shelf to create.
     *
     * Generated from protobuf field <code>.google.example.library.v1.Shelf shelf = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Example\Library\V1\Shelf $var
     * @return $this
     */
    public function setShelf($var)
    {
        GPBUtil::checkMessage($var, \Google\Example\Library\V1\Shelf::class);
        $this->shelf = $var;

        return $this;
    }

}

