<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/api/serviceusage/v1beta1/serviceusage.proto

namespace Google\Api\ServiceUsage\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for ImportAdminOverrides
 *
 * Generated from protobuf message <code>google.api.serviceusage.v1beta1.ImportAdminOverridesRequest</code>
 */
class ImportAdminOverridesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * The resource name of the consumer.
     * An example name would be:
     * `projects/123/services/compute.googleapis.com`
     *
     * Generated from protobuf field <code>string parent = 1;</code>
     */
    protected $parent = '';
    /**
     * Whether to force the creation of the quota overrides.
     * Setting the force parameter to 'true' ignores all quota safety checks that
     * would fail the request. QuotaSafetyCheck lists all such validations.
     *
     * Generated from protobuf field <code>bool force = 3;</code>
     */
    protected $force = false;
    /**
     * The list of quota safety checks to ignore before the override mutation.
     * Unlike 'force' field that ignores all the quota safety checks, the
     * 'force_only' field ignores only the specified checks; other checks are
     * still enforced. The 'force' and 'force_only' fields cannot both be set.
     *
     * Generated from protobuf field <code>repeated .google.api.serviceusage.v1beta1.QuotaSafetyCheck force_only = 4;</code>
     */
    private $force_only;
    protected $source;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           The resource name of the consumer.
     *           An example name would be:
     *           `projects/123/services/compute.googleapis.com`
     *     @type \Google\Api\ServiceUsage\V1beta1\OverrideInlineSource $inline_source
     *           The import data is specified in the request message itself
     *     @type bool $force
     *           Whether to force the creation of the quota overrides.
     *           Setting the force parameter to 'true' ignores all quota safety checks that
     *           would fail the request. QuotaSafetyCheck lists all such validations.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $force_only
     *           The list of quota safety checks to ignore before the override mutation.
     *           Unlike 'force' field that ignores all the quota safety checks, the
     *           'force_only' field ignores only the specified checks; other checks are
     *           still enforced. The 'force' and 'force_only' fields cannot both be set.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Api\Serviceusage\V1Beta1\Serviceusage::initOnce();
        parent::__construct($data);
    }

    /**
     * The resource name of the consumer.
     * An example name would be:
     * `projects/123/services/compute.googleapis.com`
     *
     * Generated from protobuf field <code>string parent = 1;</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * The resource name of the consumer.
     * An example name would be:
     * `projects/123/services/compute.googleapis.com`
     *
     * Generated from protobuf field <code>string parent = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * The import data is specified in the request message itself
     *
     * Generated from protobuf field <code>.google.api.serviceusage.v1beta1.OverrideInlineSource inline_source = 2;</code>
     * @return \Google\Api\ServiceUsage\V1beta1\OverrideInlineSource|null
     */
    public function getInlineSource()
    {
        return $this->readOneof(2);
    }

    public function hasInlineSource()
    {
        return $this->hasOneof(2);
    }

    /**
     * The import data is specified in the request message itself
     *
     * Generated from protobuf field <code>.google.api.serviceusage.v1beta1.OverrideInlineSource inline_source = 2;</code>
     * @param \Google\Api\ServiceUsage\V1beta1\OverrideInlineSource $var
     * @return $this
     */
    public function setInlineSource($var)
    {
        GPBUtil::checkMessage($var, \Google\Api\ServiceUsage\V1beta1\OverrideInlineSource::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * Whether to force the creation of the quota overrides.
     * Setting the force parameter to 'true' ignores all quota safety checks that
     * would fail the request. QuotaSafetyCheck lists all such validations.
     *
     * Generated from protobuf field <code>bool force = 3;</code>
     * @return bool
     */
    public function getForce()
    {
        return $this->force;
    }

    /**
     * Whether to force the creation of the quota overrides.
     * Setting the force parameter to 'true' ignores all quota safety checks that
     * would fail the request. QuotaSafetyCheck lists all such validations.
     *
     * Generated from protobuf field <code>bool force = 3;</code>
     * @param bool $var
     * @return $this
     */
    public function setForce($var)
    {
        GPBUtil::checkBool($var);
        $this->force = $var;

        return $this;
    }

    /**
     * The list of quota safety checks to ignore before the override mutation.
     * Unlike 'force' field that ignores all the quota safety checks, the
     * 'force_only' field ignores only the specified checks; other checks are
     * still enforced. The 'force' and 'force_only' fields cannot both be set.
     *
     * Generated from protobuf field <code>repeated .google.api.serviceusage.v1beta1.QuotaSafetyCheck force_only = 4;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getForceOnly()
    {
        return $this->force_only;
    }

    /**
     * The list of quota safety checks to ignore before the override mutation.
     * Unlike 'force' field that ignores all the quota safety checks, the
     * 'force_only' field ignores only the specified checks; other checks are
     * still enforced. The 'force' and 'force_only' fields cannot both be set.
     *
     * Generated from protobuf field <code>repeated .google.api.serviceusage.v1beta1.QuotaSafetyCheck force_only = 4;</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setForceOnly($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::ENUM, \Google\Api\ServiceUsage\V1beta1\QuotaSafetyCheck::class);
        $this->force_only = $arr;

        return $this;
    }

    /**
     * @return string
     */
    public function getSource()
    {
        return $this->whichOneof("source");
    }

}

