<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/binaryauthorization/v1/resources.proto

namespace Google\Cloud\BinaryAuthorization\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An [attestor][google.cloud.binaryauthorization.v1.Attestor] that attests to container image
 * artifacts. An existing attestor cannot be modified except where
 * indicated.
 *
 * Generated from protobuf message <code>google.cloud.binaryauthorization.v1.Attestor</code>
 */
class Attestor extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name, in the format:
     * `projects/&#42;&#47;attestors/&#42;`. This field may not be updated.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $name = '';
    /**
     * Optional. A descriptive comment.  This field may be updated.
     * The field may be displayed in chooser dialogs.
     *
     * Generated from protobuf field <code>string description = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $description = '';
    /**
     * Output only. Time when the attestor was last updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $update_time = null;
    protected $attestor_type;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The resource name, in the format:
     *           `projects/&#42;&#47;attestors/&#42;`. This field may not be updated.
     *     @type string $description
     *           Optional. A descriptive comment.  This field may be updated.
     *           The field may be displayed in chooser dialogs.
     *     @type \Google\Cloud\BinaryAuthorization\V1\UserOwnedGrafeasNote $user_owned_grafeas_note
     *           This specifies how an attestation will be read, and how it will be used
     *           during policy enforcement.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           Output only. Time when the attestor was last updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Binaryauthorization\V1\Resources::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The resource name, in the format:
     * `projects/&#42;&#47;attestors/&#42;`. This field may not be updated.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The resource name, in the format:
     * `projects/&#42;&#47;attestors/&#42;`. This field may not be updated.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Optional. A descriptive comment.  This field may be updated.
     * The field may be displayed in chooser dialogs.
     *
     * Generated from protobuf field <code>string description = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Optional. A descriptive comment.  This field may be updated.
     * The field may be displayed in chooser dialogs.
     *
     * Generated from protobuf field <code>string description = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * This specifies how an attestation will be read, and how it will be used
     * during policy enforcement.
     *
     * Generated from protobuf field <code>.google.cloud.binaryauthorization.v1.UserOwnedGrafeasNote user_owned_grafeas_note = 3;</code>
     * @return \Google\Cloud\BinaryAuthorization\V1\UserOwnedGrafeasNote|null
     */
    public function getUserOwnedGrafeasNote()
    {
        return $this->readOneof(3);
    }

    public function hasUserOwnedGrafeasNote()
    {
        return $this->hasOneof(3);
    }

    /**
     * This specifies how an attestation will be read, and how it will be used
     * during policy enforcement.
     *
     * Generated from protobuf field <code>.google.cloud.binaryauthorization.v1.UserOwnedGrafeasNote user_owned_grafeas_note = 3;</code>
     * @param \Google\Cloud\BinaryAuthorization\V1\UserOwnedGrafeasNote $var
     * @return $this
     */
    public function setUserOwnedGrafeasNote($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\BinaryAuthorization\V1\UserOwnedGrafeasNote::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * Output only. Time when the attestor was last updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getUpdateTime()
    {
        return $this->update_time;
    }

    public function hasUpdateTime()
    {
        return isset($this->update_time);
    }

    public function clearUpdateTime()
    {
        unset($this->update_time);
    }

    /**
     * Output only. Time when the attestor was last updated.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->update_time = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getAttestorType()
    {
        return $this->whichOneof("attestor_type");
    }

}

