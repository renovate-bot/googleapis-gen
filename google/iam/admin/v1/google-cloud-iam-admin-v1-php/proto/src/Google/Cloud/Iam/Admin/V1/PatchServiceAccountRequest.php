<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/iam/admin/v1/iam.proto

namespace Google\Cloud\Iam\Admin\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request for
 * [PatchServiceAccount][google.iam.admin.v1.PatchServiceAccount].
 * You can patch only the `display_name` and `description` fields. You must use
 * the `update_mask` field to specify which of these fields you want to patch.
 * Only the fields specified in the request are guaranteed to be returned in
 * the response. Other fields may be empty in the response.
 *
 * Generated from protobuf message <code>google.iam.admin.v1.PatchServiceAccountRequest</code>
 */
class PatchServiceAccountRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>.google.iam.admin.v1.ServiceAccount service_account = 1;</code>
     */
    protected $service_account = null;
    /**
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Iam\Admin\V1\ServiceAccount $service_account
     *     @type \Google\Protobuf\FieldMask $update_mask
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Iam\Admin\V1\Iam::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>.google.iam.admin.v1.ServiceAccount service_account = 1;</code>
     * @return \Google\Cloud\Iam\Admin\V1\ServiceAccount|null
     */
    public function getServiceAccount()
    {
        return $this->service_account;
    }

    public function hasServiceAccount()
    {
        return isset($this->service_account);
    }

    public function clearServiceAccount()
    {
        unset($this->service_account);
    }

    /**
     * Generated from protobuf field <code>.google.iam.admin.v1.ServiceAccount service_account = 1;</code>
     * @param \Google\Cloud\Iam\Admin\V1\ServiceAccount $var
     * @return $this
     */
    public function setServiceAccount($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Iam\Admin\V1\ServiceAccount::class);
        $this->service_account = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return $this->update_mask;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

