<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/firestore/v1/write.proto

namespace Google\Cloud\Firestore\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A [Document][google.firestore.v1.Document] has changed.
 * May be the result of multiple [writes][google.firestore.v1.Write], including deletes, that
 * ultimately resulted in a new value for the [Document][google.firestore.v1.Document].
 * Multiple [DocumentChange][google.firestore.v1.DocumentChange] messages may be returned for the same logical
 * change, if multiple targets are affected.
 *
 * Generated from protobuf message <code>google.firestore.v1.DocumentChange</code>
 */
class DocumentChange extends \Google\Protobuf\Internal\Message
{
    /**
     * The new state of the [Document][google.firestore.v1.Document].
     * If `mask` is set, contains only fields that were updated or added.
     *
     * Generated from protobuf field <code>.google.firestore.v1.Document document = 1;</code>
     */
    protected $document = null;
    /**
     * A set of target IDs of targets that match this document.
     *
     * Generated from protobuf field <code>repeated int32 target_ids = 5;</code>
     */
    private $target_ids;
    /**
     * A set of target IDs for targets that no longer match this document.
     *
     * Generated from protobuf field <code>repeated int32 removed_target_ids = 6;</code>
     */
    private $removed_target_ids;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Firestore\V1\Document $document
     *           The new state of the [Document][google.firestore.v1.Document].
     *           If `mask` is set, contains only fields that were updated or added.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $target_ids
     *           A set of target IDs of targets that match this document.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $removed_target_ids
     *           A set of target IDs for targets that no longer match this document.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Firestore\V1\Write::initOnce();
        parent::__construct($data);
    }

    /**
     * The new state of the [Document][google.firestore.v1.Document].
     * If `mask` is set, contains only fields that were updated or added.
     *
     * Generated from protobuf field <code>.google.firestore.v1.Document document = 1;</code>
     * @return \Google\Cloud\Firestore\V1\Document|null
     */
    public function getDocument()
    {
        return isset($this->document) ? $this->document : null;
    }

    public function hasDocument()
    {
        return isset($this->document);
    }

    public function clearDocument()
    {
        unset($this->document);
    }

    /**
     * The new state of the [Document][google.firestore.v1.Document].
     * If `mask` is set, contains only fields that were updated or added.
     *
     * Generated from protobuf field <code>.google.firestore.v1.Document document = 1;</code>
     * @param \Google\Cloud\Firestore\V1\Document $var
     * @return $this
     */
    public function setDocument($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Firestore\V1\Document::class);
        $this->document = $var;

        return $this;
    }

    /**
     * A set of target IDs of targets that match this document.
     *
     * Generated from protobuf field <code>repeated int32 target_ids = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTargetIds()
    {
        return $this->target_ids;
    }

    /**
     * A set of target IDs of targets that match this document.
     *
     * Generated from protobuf field <code>repeated int32 target_ids = 5;</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTargetIds($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::INT32);
        $this->target_ids = $arr;

        return $this;
    }

    /**
     * A set of target IDs for targets that no longer match this document.
     *
     * Generated from protobuf field <code>repeated int32 removed_target_ids = 6;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRemovedTargetIds()
    {
        return $this->removed_target_ids;
    }

    /**
     * A set of target IDs for targets that no longer match this document.
     *
     * Generated from protobuf field <code>repeated int32 removed_target_ids = 6;</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRemovedTargetIds($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::INT32);
        $this->removed_target_ids = $arr;

        return $this;
    }

}

