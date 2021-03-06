<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/storage/v2/storage.proto

namespace Google\Storage\V2\Object;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes the customer-specified mechanism used to store the data at rest.
 *
 * Generated from protobuf message <code>google.storage.v2.Object.CustomerEncryption</code>
 */
class CustomerEncryption extends \Google\Protobuf\Internal\Message
{
    /**
     * The encryption algorithm.
     *
     * Generated from protobuf field <code>string encryption_algorithm = 1;</code>
     */
    protected $encryption_algorithm = '';
    /**
     * SHA256 hash value of the encryption key.
     *
     * Generated from protobuf field <code>string key_sha256 = 2;</code>
     */
    protected $key_sha256 = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $encryption_algorithm
     *           The encryption algorithm.
     *     @type string $key_sha256
     *           SHA256 hash value of the encryption key.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Storage\V2\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * The encryption algorithm.
     *
     * Generated from protobuf field <code>string encryption_algorithm = 1;</code>
     * @return string
     */
    public function getEncryptionAlgorithm()
    {
        return $this->encryption_algorithm;
    }

    /**
     * The encryption algorithm.
     *
     * Generated from protobuf field <code>string encryption_algorithm = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setEncryptionAlgorithm($var)
    {
        GPBUtil::checkString($var, True);
        $this->encryption_algorithm = $var;

        return $this;
    }

    /**
     * SHA256 hash value of the encryption key.
     *
     * Generated from protobuf field <code>string key_sha256 = 2;</code>
     * @return string
     */
    public function getKeySha256()
    {
        return $this->key_sha256;
    }

    /**
     * SHA256 hash value of the encryption key.
     *
     * Generated from protobuf field <code>string key_sha256 = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setKeySha256($var)
    {
        GPBUtil::checkString($var, True);
        $this->key_sha256 = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(CustomerEncryption::class, \Google\Storage\V2\Object_CustomerEncryption::class);

