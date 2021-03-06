<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/testing/v1/test_environment_discovery.proto

namespace Google\Devtools\Testing\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A location/region designation for language.
 *
 * Generated from protobuf message <code>google.devtools.testing.v1.Locale</code>
 */
class Locale extends \Google\Protobuf\Internal\Message
{
    /**
     * The id for this locale.
     * Example: "en_US".
     *
     * Generated from protobuf field <code>string id = 1;</code>
     */
    protected $id = '';
    /**
     * A human-friendly name for this language/locale.
     * Example: "English".
     *
     * Generated from protobuf field <code>string name = 2;</code>
     */
    protected $name = '';
    /**
     * A human-friendly string representing the region for this
     * locale. Example: "United States". Not present for every locale.
     *
     * Generated from protobuf field <code>string region = 3;</code>
     */
    protected $region = '';
    /**
     * Tags for this dimension.
     * Example: "default".
     *
     * Generated from protobuf field <code>repeated string tags = 4;</code>
     */
    private $tags;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $id
     *           The id for this locale.
     *           Example: "en_US".
     *     @type string $name
     *           A human-friendly name for this language/locale.
     *           Example: "English".
     *     @type string $region
     *           A human-friendly string representing the region for this
     *           locale. Example: "United States". Not present for every locale.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $tags
     *           Tags for this dimension.
     *           Example: "default".
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Testing\V1\TestEnvironmentDiscovery::initOnce();
        parent::__construct($data);
    }

    /**
     * The id for this locale.
     * Example: "en_US".
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * The id for this locale.
     * Example: "en_US".
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

    /**
     * A human-friendly name for this language/locale.
     * Example: "English".
     *
     * Generated from protobuf field <code>string name = 2;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * A human-friendly name for this language/locale.
     * Example: "English".
     *
     * Generated from protobuf field <code>string name = 2;</code>
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
     * A human-friendly string representing the region for this
     * locale. Example: "United States". Not present for every locale.
     *
     * Generated from protobuf field <code>string region = 3;</code>
     * @return string
     */
    public function getRegion()
    {
        return $this->region;
    }

    /**
     * A human-friendly string representing the region for this
     * locale. Example: "United States". Not present for every locale.
     *
     * Generated from protobuf field <code>string region = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setRegion($var)
    {
        GPBUtil::checkString($var, True);
        $this->region = $var;

        return $this;
    }

    /**
     * Tags for this dimension.
     * Example: "default".
     *
     * Generated from protobuf field <code>repeated string tags = 4;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTags()
    {
        return $this->tags;
    }

    /**
     * Tags for this dimension.
     * Example: "default".
     *
     * Generated from protobuf field <code>repeated string tags = 4;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTags($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->tags = $arr;

        return $this;
    }

}

