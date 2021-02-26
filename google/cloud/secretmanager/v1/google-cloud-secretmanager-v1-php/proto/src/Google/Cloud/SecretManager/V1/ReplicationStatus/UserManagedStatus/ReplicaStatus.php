<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/secretmanager/v1/resources.proto

namespace Google\Cloud\SecretManager\V1\ReplicationStatus\UserManagedStatus;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes the status of a user-managed replica for the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
 *
 * Generated from protobuf message <code>google.cloud.secretmanager.v1.ReplicationStatus.UserManagedStatus.ReplicaStatus</code>
 */
class ReplicaStatus extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The canonical ID of the replica location.
     * For example: `"us-east1"`.
     *
     * Generated from protobuf field <code>string location = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $location = '';
    /**
     * Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only
     * populated if customer-managed encryption is used.
     *
     * Generated from protobuf field <code>.google.cloud.secretmanager.v1.CustomerManagedEncryptionStatus customer_managed_encryption = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $customer_managed_encryption = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $location
     *           Output only. The canonical ID of the replica location.
     *           For example: `"us-east1"`.
     *     @type \Google\Cloud\SecretManager\V1\CustomerManagedEncryptionStatus $customer_managed_encryption
     *           Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only
     *           populated if customer-managed encryption is used.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Secretmanager\V1\Resources::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The canonical ID of the replica location.
     * For example: `"us-east1"`.
     *
     * Generated from protobuf field <code>string location = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getLocation()
    {
        return $this->location;
    }

    /**
     * Output only. The canonical ID of the replica location.
     * For example: `"us-east1"`.
     *
     * Generated from protobuf field <code>string location = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setLocation($var)
    {
        GPBUtil::checkString($var, True);
        $this->location = $var;

        return $this;
    }

    /**
     * Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only
     * populated if customer-managed encryption is used.
     *
     * Generated from protobuf field <code>.google.cloud.secretmanager.v1.CustomerManagedEncryptionStatus customer_managed_encryption = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Cloud\SecretManager\V1\CustomerManagedEncryptionStatus|null
     */
    public function getCustomerManagedEncryption()
    {
        return isset($this->customer_managed_encryption) ? $this->customer_managed_encryption : null;
    }

    public function hasCustomerManagedEncryption()
    {
        return isset($this->customer_managed_encryption);
    }

    public function clearCustomerManagedEncryption()
    {
        unset($this->customer_managed_encryption);
    }

    /**
     * Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only
     * populated if customer-managed encryption is used.
     *
     * Generated from protobuf field <code>.google.cloud.secretmanager.v1.CustomerManagedEncryptionStatus customer_managed_encryption = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Cloud\SecretManager\V1\CustomerManagedEncryptionStatus $var
     * @return $this
     */
    public function setCustomerManagedEncryption($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\SecretManager\V1\CustomerManagedEncryptionStatus::class);
        $this->customer_managed_encryption = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ReplicaStatus::class, \Google\Cloud\SecretManager\V1\ReplicationStatus_UserManagedStatus_ReplicaStatus::class);

