<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/target.proto

namespace Google\Apps\Drive\Activity\V2\DriveItem;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * This item is deprecated; please see `DriveFolder` instead.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.DriveItem.Folder</code>
 */
class Folder extends \Google\Protobuf\Internal\Message
{
    /**
     * This field is deprecated; please see `DriveFolder.type` instead.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItem.Folder.Type type = 6;</code>
     */
    protected $type = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $type
     *           This field is deprecated; please see `DriveFolder.type` instead.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Target::initOnce();
        parent::__construct($data);
    }

    /**
     * This field is deprecated; please see `DriveFolder.type` instead.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItem.Folder.Type type = 6;</code>
     * @return int
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * This field is deprecated; please see `DriveFolder.type` instead.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItem.Folder.Type type = 6;</code>
     * @param int $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkEnum($var, \Google\Apps\Drive\Activity\V2\DriveItem\Folder\Type::class);
        $this->type = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Folder::class, \Google\Apps\Drive\Activity\V2\DriveItem_Folder::class);

