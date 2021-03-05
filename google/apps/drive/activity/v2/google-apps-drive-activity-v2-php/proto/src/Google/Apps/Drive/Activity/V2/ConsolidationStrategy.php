<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/query_drive_activity_request.proto

namespace Google\Apps\Drive\Activity\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * How the individual activities are consolidated. A set of activities may be
 * consolidated into one combined activity if they are related in some way, such
 * as one actor performing the same action on multiple targets, or multiple
 * actors performing the same action on a single target. The strategy defines
 * the rules for which activities are related.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.ConsolidationStrategy</code>
 */
class ConsolidationStrategy extends \Google\Protobuf\Internal\Message
{
    protected $strategy;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\NoConsolidation $none
     *           The individual activities are not consolidated.
     *     @type \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\Legacy $legacy
     *           The individual activities are consolidated using the legacy strategy.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\QueryDriveActivityRequest::initOnce();
        parent::__construct($data);
    }

    /**
     * The individual activities are not consolidated.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ConsolidationStrategy.NoConsolidation none = 1;</code>
     * @return \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\NoConsolidation|null
     */
    public function getNone()
    {
        return $this->readOneof(1);
    }

    public function hasNone()
    {
        return $this->hasOneof(1);
    }

    /**
     * The individual activities are not consolidated.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ConsolidationStrategy.NoConsolidation none = 1;</code>
     * @param \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\NoConsolidation $var
     * @return $this
     */
    public function setNone($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\NoConsolidation::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * The individual activities are consolidated using the legacy strategy.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ConsolidationStrategy.Legacy legacy = 2;</code>
     * @return \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\Legacy|null
     */
    public function getLegacy()
    {
        return $this->readOneof(2);
    }

    public function hasLegacy()
    {
        return $this->hasOneof(2);
    }

    /**
     * The individual activities are consolidated using the legacy strategy.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.ConsolidationStrategy.Legacy legacy = 2;</code>
     * @param \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\Legacy $var
     * @return $this
     */
    public function setLegacy($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\ConsolidationStrategy\Legacy::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getStrategy()
    {
        return $this->whichOneof("strategy");
    }

}

