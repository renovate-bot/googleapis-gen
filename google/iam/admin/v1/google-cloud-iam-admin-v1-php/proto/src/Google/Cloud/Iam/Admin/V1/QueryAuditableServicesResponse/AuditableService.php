<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/iam/admin/v1/iam.proto

namespace Google\Cloud\Iam\Admin\V1\QueryAuditableServicesResponse;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Contains information about an auditable service.
 *
 * Generated from protobuf message <code>google.iam.admin.v1.QueryAuditableServicesResponse.AuditableService</code>
 */
class AuditableService extends \Google\Protobuf\Internal\Message
{
    /**
     * Public name of the service.
     * For example, the service name for Cloud IAM is 'iam.googleapis.com'.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Public name of the service.
     *           For example, the service name for Cloud IAM is 'iam.googleapis.com'.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Iam\Admin\V1\Iam::initOnce();
        parent::__construct($data);
    }

    /**
     * Public name of the service.
     * For example, the service name for Cloud IAM is 'iam.googleapis.com'.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Public name of the service.
     * For example, the service name for Cloud IAM is 'iam.googleapis.com'.
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

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(AuditableService::class, \Google\Cloud\Iam\Admin\V1\QueryAuditableServicesResponse_AuditableService::class);

