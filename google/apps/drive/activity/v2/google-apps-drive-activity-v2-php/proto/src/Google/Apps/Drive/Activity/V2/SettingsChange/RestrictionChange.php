<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/action.proto

namespace Google\Apps\Drive\Activity\V2\SettingsChange;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about restriction policy changes to a feature.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.SettingsChange.RestrictionChange</code>
 */
class RestrictionChange extends \Google\Protobuf\Internal\Message
{
    /**
     * The feature which had a change in restriction policy.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Feature feature = 1;</code>
     */
    protected $feature = 0;
    /**
     * The restriction in place after the change.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Restriction new_restriction = 2;</code>
     */
    protected $new_restriction = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $feature
     *           The feature which had a change in restriction policy.
     *     @type int $new_restriction
     *           The restriction in place after the change.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Action::initOnce();
        parent::__construct($data);
    }

    /**
     * The feature which had a change in restriction policy.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Feature feature = 1;</code>
     * @return int
     */
    public function getFeature()
    {
        return $this->feature;
    }

    /**
     * The feature which had a change in restriction policy.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Feature feature = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setFeature($var)
    {
        GPBUtil::checkEnum($var, \Google\Apps\Drive\Activity\V2\SettingsChange\RestrictionChange\Feature::class);
        $this->feature = $var;

        return $this;
    }

    /**
     * The restriction in place after the change.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Restriction new_restriction = 2;</code>
     * @return int
     */
    public function getNewRestriction()
    {
        return $this->new_restriction;
    }

    /**
     * The restriction in place after the change.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Restriction new_restriction = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setNewRestriction($var)
    {
        GPBUtil::checkEnum($var, \Google\Apps\Drive\Activity\V2\SettingsChange\RestrictionChange\Restriction::class);
        $this->new_restriction = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(RestrictionChange::class, \Google\Apps\Drive\Activity\V2\SettingsChange_RestrictionChange::class);

