<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1/realms.proto

namespace Google\Cloud\Gaming\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for RealmsService.UpdateRealm.
 *
 * Generated from protobuf message <code>google.cloud.gaming.v1.UpdateRealmRequest</code>
 */
class UpdateRealmRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The realm to be updated.
     * Only fields specified in update_mask are updated.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1.Realm realm = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $realm = null;
    /**
     * Required. The update mask applies to the resource. For the `FieldMask`
     * definition, see
     * https:
     * //developers.google.com/protocol-buffers
     * // /docs/reference/google.protobuf#fieldmask
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Gaming\V1\Realm $realm
     *           Required. The realm to be updated.
     *           Only fields specified in update_mask are updated.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. The update mask applies to the resource. For the `FieldMask`
     *           definition, see
     *           https:
     *           //developers.google.com/protocol-buffers
     *           // /docs/reference/google.protobuf#fieldmask
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Gaming\V1\Realms::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The realm to be updated.
     * Only fields specified in update_mask are updated.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1.Realm realm = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Gaming\V1\Realm|null
     */
    public function getRealm()
    {
        return isset($this->realm) ? $this->realm : null;
    }

    public function hasRealm()
    {
        return isset($this->realm);
    }

    public function clearRealm()
    {
        unset($this->realm);
    }

    /**
     * Required. The realm to be updated.
     * Only fields specified in update_mask are updated.
     *
     * Generated from protobuf field <code>.google.cloud.gaming.v1.Realm realm = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Gaming\V1\Realm $var
     * @return $this
     */
    public function setRealm($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Gaming\V1\Realm::class);
        $this->realm = $var;

        return $this;
    }

    /**
     * Required. The update mask applies to the resource. For the `FieldMask`
     * definition, see
     * https:
     * //developers.google.com/protocol-buffers
     * // /docs/reference/google.protobuf#fieldmask
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
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
     * Required. The update mask applies to the resource. For the `FieldMask`
     * definition, see
     * https:
     * //developers.google.com/protocol-buffers
     * // /docs/reference/google.protobuf#fieldmask
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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

