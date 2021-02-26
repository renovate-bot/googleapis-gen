<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: grafeas/v1/image.proto

namespace Grafeas\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Basis describes the base image portion (Note) of the DockerImage
 * relationship. Linked occurrences are derived from this or an equivalent image
 * via:
 *   FROM <Basis.resource_url>
 * Or an equivalent reference, e.g., a tag of the resource_url.
 *
 * Generated from protobuf message <code>grafeas.v1.ImageNote</code>
 */
class ImageNote extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Immutable. The resource_url for the resource representing the
     * basis of associated occurrence images.
     *
     * Generated from protobuf field <code>string resource_url = 1;</code>
     */
    protected $resource_url = '';
    /**
     * Required. Immutable. The fingerprint of the base image.
     *
     * Generated from protobuf field <code>.grafeas.v1.Fingerprint fingerprint = 2;</code>
     */
    protected $fingerprint = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_url
     *           Required. Immutable. The resource_url for the resource representing the
     *           basis of associated occurrence images.
     *     @type \Grafeas\V1\Fingerprint $fingerprint
     *           Required. Immutable. The fingerprint of the base image.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Grafeas\V1\Image::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Immutable. The resource_url for the resource representing the
     * basis of associated occurrence images.
     *
     * Generated from protobuf field <code>string resource_url = 1;</code>
     * @return string
     */
    public function getResourceUrl()
    {
        return $this->resource_url;
    }

    /**
     * Required. Immutable. The resource_url for the resource representing the
     * basis of associated occurrence images.
     *
     * Generated from protobuf field <code>string resource_url = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setResourceUrl($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_url = $var;

        return $this;
    }

    /**
     * Required. Immutable. The fingerprint of the base image.
     *
     * Generated from protobuf field <code>.grafeas.v1.Fingerprint fingerprint = 2;</code>
     * @return \Grafeas\V1\Fingerprint|null
     */
    public function getFingerprint()
    {
        return isset($this->fingerprint) ? $this->fingerprint : null;
    }

    public function hasFingerprint()
    {
        return isset($this->fingerprint);
    }

    public function clearFingerprint()
    {
        unset($this->fingerprint);
    }

    /**
     * Required. Immutable. The fingerprint of the base image.
     *
     * Generated from protobuf field <code>.grafeas.v1.Fingerprint fingerprint = 2;</code>
     * @param \Grafeas\V1\Fingerprint $var
     * @return $this
     */
    public function setFingerprint($var)
    {
        GPBUtil::checkMessage($var, \Grafeas\V1\Fingerprint::class);
        $this->fingerprint = $var;

        return $this;
    }

}

