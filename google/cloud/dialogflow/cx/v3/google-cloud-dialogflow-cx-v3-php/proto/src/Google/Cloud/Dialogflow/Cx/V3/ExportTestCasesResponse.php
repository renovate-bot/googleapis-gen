<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The response message for [TestCases.ExportTestCases][google.cloud.dialogflow.cx.v3.TestCases.ExportTestCases].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.ExportTestCasesResponse</code>
 */
class ExportTestCasesResponse extends \Google\Protobuf\Internal\Message
{
    protected $destination;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $gcs_uri
     *           The URI to a file containing the exported test cases. This field is
     *           populated only if `gcs_uri` is specified in
     *           [ExportTestCasesRequest][google.cloud.dialogflow.cx.v3.ExportTestCasesRequest].
     *     @type string $content
     *           Uncompressed raw byte content for test cases.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * The URI to a file containing the exported test cases. This field is
     * populated only if `gcs_uri` is specified in
     * [ExportTestCasesRequest][google.cloud.dialogflow.cx.v3.ExportTestCasesRequest].
     *
     * Generated from protobuf field <code>string gcs_uri = 1;</code>
     * @return string
     */
    public function getGcsUri()
    {
        return $this->readOneof(1);
    }

    public function hasGcsUri()
    {
        return $this->hasOneof(1);
    }

    /**
     * The URI to a file containing the exported test cases. This field is
     * populated only if `gcs_uri` is specified in
     * [ExportTestCasesRequest][google.cloud.dialogflow.cx.v3.ExportTestCasesRequest].
     *
     * Generated from protobuf field <code>string gcs_uri = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setGcsUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * Uncompressed raw byte content for test cases.
     *
     * Generated from protobuf field <code>bytes content = 2;</code>
     * @return string
     */
    public function getContent()
    {
        return $this->readOneof(2);
    }

    public function hasContent()
    {
        return $this->hasOneof(2);
    }

    /**
     * Uncompressed raw byte content for test cases.
     *
     * Generated from protobuf field <code>bytes content = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setContent($var)
    {
        GPBUtil::checkString($var, False);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getDestination()
    {
        return $this->whichOneof("destination");
    }

}

