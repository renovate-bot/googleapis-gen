<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/target.proto

namespace Google\Apps\Drive\Activity\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A lightweight reference to the target of activity.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.TargetReference</code>
 */
class TargetReference extends \Google\Protobuf\Internal\Message
{
    /**
     * This field is deprecated; please use the `drive` field instead.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.TeamDriveReference team_drive = 2 [deprecated = true];</code>
     * @deprecated
     */
    protected $team_drive = null;
    protected $object;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Apps\Drive\Activity\V2\DriveItemReference $drive_item
     *           The target is a Drive item.
     *     @type \Google\Apps\Drive\Activity\V2\DriveReference $drive
     *           The target is a shared drive.
     *     @type \Google\Apps\Drive\Activity\V2\TeamDriveReference $team_drive
     *           This field is deprecated; please use the `drive` field instead.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Target::initOnce();
        parent::__construct($data);
    }

    /**
     * The target is a Drive item.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItemReference drive_item = 1;</code>
     * @return \Google\Apps\Drive\Activity\V2\DriveItemReference|null
     */
    public function getDriveItem()
    {
        return $this->readOneof(1);
    }

    public function hasDriveItem()
    {
        return $this->hasOneof(1);
    }

    /**
     * The target is a Drive item.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItemReference drive_item = 1;</code>
     * @param \Google\Apps\Drive\Activity\V2\DriveItemReference $var
     * @return $this
     */
    public function setDriveItem($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\DriveItemReference::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * The target is a shared drive.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveReference drive = 3;</code>
     * @return \Google\Apps\Drive\Activity\V2\DriveReference|null
     */
    public function getDrive()
    {
        return $this->readOneof(3);
    }

    public function hasDrive()
    {
        return $this->hasOneof(3);
    }

    /**
     * The target is a shared drive.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveReference drive = 3;</code>
     * @param \Google\Apps\Drive\Activity\V2\DriveReference $var
     * @return $this
     */
    public function setDrive($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\DriveReference::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * This field is deprecated; please use the `drive` field instead.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.TeamDriveReference team_drive = 2 [deprecated = true];</code>
     * @return \Google\Apps\Drive\Activity\V2\TeamDriveReference|null
     * @deprecated
     */
    public function getTeamDrive()
    {
        @trigger_error('team_drive is deprecated.', E_USER_DEPRECATED);
        return $this->team_drive;
    }

    public function hasTeamDrive()
    {
        @trigger_error('team_drive is deprecated.', E_USER_DEPRECATED);
        return isset($this->team_drive);
    }

    public function clearTeamDrive()
    {
        @trigger_error('team_drive is deprecated.', E_USER_DEPRECATED);
        unset($this->team_drive);
    }

    /**
     * This field is deprecated; please use the `drive` field instead.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.TeamDriveReference team_drive = 2 [deprecated = true];</code>
     * @param \Google\Apps\Drive\Activity\V2\TeamDriveReference $var
     * @return $this
     * @deprecated
     */
    public function setTeamDrive($var)
    {
        @trigger_error('team_drive is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\TeamDriveReference::class);
        $this->team_drive = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getObject()
    {
        return $this->whichOneof("object");
    }

}

