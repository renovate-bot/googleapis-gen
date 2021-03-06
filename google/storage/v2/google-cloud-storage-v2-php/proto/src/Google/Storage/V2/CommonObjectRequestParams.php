<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/storage/v2/storage.proto

namespace Google\Storage\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Parameters that can be passed to any object request.
 *
 * Generated from protobuf message <code>google.storage.v2.CommonObjectRequestParams</code>
 */
class CommonObjectRequestParams extends \Google\Protobuf\Internal\Message
{
    /**
     * Encryption algorithm used with Customer-Supplied Encryption Keys feature.
     *
     * Generated from protobuf field <code>string encryption_algorithm = 1;</code>
     */
    protected $encryption_algorithm = '';
    /**
     * Encryption key used with Customer-Supplied Encryption Keys feature.
     *
     * Generated from protobuf field <code>string encryption_key = 2;</code>
     */
    protected $encryption_key = '';
    /**
     * SHA256 hash of encryption key used with Customer-Supplied Encryption Keys
     * feature.
     *
     * Generated from protobuf field <code>string encryption_key_sha256 = 3;</code>
     */
    protected $encryption_key_sha256 = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $encryption_algorithm
     *           Encryption algorithm used with Customer-Supplied Encryption Keys feature.
     *     @type string $encryption_key
     *           Encryption key used with Customer-Supplied Encryption Keys feature.
     *     @type string $encryption_key_sha256
     *           SHA256 hash of encryption key used with Customer-Supplied Encryption Keys
     *           feature.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Storage\V2\Storage::initOnce();
        parent::__construct($data);
    }

    /**
     * Encryption algorithm used with Customer-Supplied Encryption Keys feature.
     *
     * Generated from protobuf field <code>string encryption_algorithm = 1;</code>
     * @return string
     */
    public function getEncryptionAlgorithm()
    {
        return $this->encryption_algorithm;
    }

    /**
     * Encryption algorithm used with Customer-Supplied Encryption Keys feature.
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
     * Encryption key used with Customer-Supplied Encryption Keys feature.
     *
     * Generated from protobuf field <code>string encryption_key = 2;</code>
     * @return string
     */
    public function getEncryptionKey()
    {
        return $this->encryption_key;
    }

    /**
     * Encryption key used with Customer-Supplied Encryption Keys feature.
     *
     * Generated from protobuf field <code>string encryption_key = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setEncryptionKey($var)
    {
        GPBUtil::checkString($var, True);
        $this->encryption_key = $var;

        return $this;
    }

    /**
     * SHA256 hash of encryption key used with Customer-Supplied Encryption Keys
     * feature.
     *
     * Generated from protobuf field <code>string encryption_key_sha256 = 3;</code>
     * @return string
     */
    public function getEncryptionKeySha256()
    {
        return $this->encryption_key_sha256;
    }

    /**
     * SHA256 hash of encryption key used with Customer-Supplied Encryption Keys
     * feature.
     *
     * Generated from protobuf field <code>string encryption_key_sha256 = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setEncryptionKeySha256($var)
    {
        GPBUtil::checkString($var, True);
        $this->encryption_key_sha256 = $var;

        return $this;
    }

}

