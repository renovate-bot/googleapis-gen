<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/osconfig/v1beta/guest_policies.proto

namespace Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A guest policy package repository including its source.
 *
 * Generated from protobuf message <code>google.cloud.osconfig.v1beta.EffectiveGuestPolicy.SourcedPackageRepository</code>
 */
class SourcedPackageRepository extends \Google\Protobuf\Internal\Message
{
    /**
     * Name of the guest policy providing this config.
     *
     * Generated from protobuf field <code>string source = 1;</code>
     */
    protected $source = '';
    /**
     * A software package repository to configure on the VM instance.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1beta.PackageRepository package_repository = 2;</code>
     */
    protected $package_repository = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $source
     *           Name of the guest policy providing this config.
     *     @type \Google\Cloud\Osconfig\V1beta\PackageRepository $package_repository
     *           A software package repository to configure on the VM instance.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Osconfig\V1Beta\GuestPolicies::initOnce();
        parent::__construct($data);
    }

    /**
     * Name of the guest policy providing this config.
     *
     * Generated from protobuf field <code>string source = 1;</code>
     * @return string
     */
    public function getSource()
    {
        return $this->source;
    }

    /**
     * Name of the guest policy providing this config.
     *
     * Generated from protobuf field <code>string source = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setSource($var)
    {
        GPBUtil::checkString($var, True);
        $this->source = $var;

        return $this;
    }

    /**
     * A software package repository to configure on the VM instance.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1beta.PackageRepository package_repository = 2;</code>
     * @return \Google\Cloud\Osconfig\V1beta\PackageRepository|null
     */
    public function getPackageRepository()
    {
        return isset($this->package_repository) ? $this->package_repository : null;
    }

    public function hasPackageRepository()
    {
        return isset($this->package_repository);
    }

    public function clearPackageRepository()
    {
        unset($this->package_repository);
    }

    /**
     * A software package repository to configure on the VM instance.
     *
     * Generated from protobuf field <code>.google.cloud.osconfig.v1beta.PackageRepository package_repository = 2;</code>
     * @param \Google\Cloud\Osconfig\V1beta\PackageRepository $var
     * @return $this
     */
    public function setPackageRepository($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Osconfig\V1beta\PackageRepository::class);
        $this->package_repository = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(SourcedPackageRepository::class, \Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy_SourcedPackageRepository::class);

