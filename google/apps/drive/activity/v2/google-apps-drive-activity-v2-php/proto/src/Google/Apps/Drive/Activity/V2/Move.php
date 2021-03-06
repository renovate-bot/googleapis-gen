<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/action.proto

namespace Google\Apps\Drive\Activity\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An object was moved.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.Move</code>
 */
class Move extends \Google\Protobuf\Internal\Message
{
    /**
     * The added parent object(s).
     *
     * Generated from protobuf field <code>repeated .google.apps.drive.activity.v2.TargetReference added_parents = 1;</code>
     */
    private $added_parents;
    /**
     * The removed parent object(s).
     *
     * Generated from protobuf field <code>repeated .google.apps.drive.activity.v2.TargetReference removed_parents = 2;</code>
     */
    private $removed_parents;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Apps\Drive\Activity\V2\TargetReference[]|\Google\Protobuf\Internal\RepeatedField $added_parents
     *           The added parent object(s).
     *     @type \Google\Apps\Drive\Activity\V2\TargetReference[]|\Google\Protobuf\Internal\RepeatedField $removed_parents
     *           The removed parent object(s).
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Action::initOnce();
        parent::__construct($data);
    }

    /**
     * The added parent object(s).
     *
     * Generated from protobuf field <code>repeated .google.apps.drive.activity.v2.TargetReference added_parents = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAddedParents()
    {
        return $this->added_parents;
    }

    /**
     * The added parent object(s).
     *
     * Generated from protobuf field <code>repeated .google.apps.drive.activity.v2.TargetReference added_parents = 1;</code>
     * @param \Google\Apps\Drive\Activity\V2\TargetReference[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAddedParents($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Apps\Drive\Activity\V2\TargetReference::class);
        $this->added_parents = $arr;

        return $this;
    }

    /**
     * The removed parent object(s).
     *
     * Generated from protobuf field <code>repeated .google.apps.drive.activity.v2.TargetReference removed_parents = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getRemovedParents()
    {
        return $this->removed_parents;
    }

    /**
     * The removed parent object(s).
     *
     * Generated from protobuf field <code>repeated .google.apps.drive.activity.v2.TargetReference removed_parents = 2;</code>
     * @param \Google\Apps\Drive\Activity\V2\TargetReference[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setRemovedParents($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Apps\Drive\Activity\V2\TargetReference::class);
        $this->removed_parents = $arr;

        return $this;
    }

}

