<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/firestore/admin/v1/operation.proto

namespace Google\Cloud\Firestore\Admin\V1\FieldOperationMetadata;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about an index configuration change.
 *
 * Generated from protobuf message <code>google.firestore.admin.v1.FieldOperationMetadata.IndexConfigDelta</code>
 */
class IndexConfigDelta extends \Google\Protobuf\Internal\Message
{
    /**
     * Specifies how the index is changing.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.FieldOperationMetadata.IndexConfigDelta.ChangeType change_type = 1;</code>
     */
    protected $change_type = 0;
    /**
     * The index being changed.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Index index = 2;</code>
     */
    protected $index = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $change_type
     *           Specifies how the index is changing.
     *     @type \Google\Cloud\Firestore\Admin\V1\Index $index
     *           The index being changed.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Firestore\Admin\V1\Operation::initOnce();
        parent::__construct($data);
    }

    /**
     * Specifies how the index is changing.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.FieldOperationMetadata.IndexConfigDelta.ChangeType change_type = 1;</code>
     * @return int
     */
    public function getChangeType()
    {
        return $this->change_type;
    }

    /**
     * Specifies how the index is changing.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.FieldOperationMetadata.IndexConfigDelta.ChangeType change_type = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setChangeType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Firestore\Admin\V1\FieldOperationMetadata\IndexConfigDelta\ChangeType::class);
        $this->change_type = $var;

        return $this;
    }

    /**
     * The index being changed.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Index index = 2;</code>
     * @return \Google\Cloud\Firestore\Admin\V1\Index|null
     */
    public function getIndex()
    {
        return isset($this->index) ? $this->index : null;
    }

    public function hasIndex()
    {
        return isset($this->index);
    }

    public function clearIndex()
    {
        unset($this->index);
    }

    /**
     * The index being changed.
     *
     * Generated from protobuf field <code>.google.firestore.admin.v1.Index index = 2;</code>
     * @param \Google\Cloud\Firestore\Admin\V1\Index $var
     * @return $this
     */
    public function setIndex($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Firestore\Admin\V1\Index::class);
        $this->index = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(IndexConfigDelta::class, \Google\Cloud\Firestore\Admin\V1\FieldOperationMetadata_IndexConfigDelta::class);

