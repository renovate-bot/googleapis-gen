<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/vision/v1p2beta1/image_annotator.proto

namespace Google\Cloud\Vision\V1p2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The Google Cloud Storage location where the output will be written to.
 *
 * Generated from protobuf message <code>google.cloud.vision.v1p2beta1.GcsDestination</code>
 */
class GcsDestination extends \Google\Protobuf\Internal\Message
{
    /**
     * Google Cloud Storage URI where the results will be stored. Results will
     * be in JSON format and preceded by its corresponding input URI. This field
     * can either represent a single file, or a prefix for multiple outputs.
     * Prefixes must end in a `/`.
     * Examples:
     * *    File: gs://bucket-name/filename.json
     * *    Prefix: gs://bucket-name/prefix/here/
     * *    File: gs://bucket-name/prefix/here
     * If multiple outputs, each response is still AnnotateFileResponse, each of
     * which contains some subset of the full list of AnnotateImageResponse.
     * Multiple outputs can happen if, for example, the output JSON is too large
     * and overflows into multiple sharded files.
     *
     * Generated from protobuf field <code>string uri = 1;</code>
     */
    protected $uri = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $uri
     *           Google Cloud Storage URI where the results will be stored. Results will
     *           be in JSON format and preceded by its corresponding input URI. This field
     *           can either represent a single file, or a prefix for multiple outputs.
     *           Prefixes must end in a `/`.
     *           Examples:
     *           *    File: gs://bucket-name/filename.json
     *           *    Prefix: gs://bucket-name/prefix/here/
     *           *    File: gs://bucket-name/prefix/here
     *           If multiple outputs, each response is still AnnotateFileResponse, each of
     *           which contains some subset of the full list of AnnotateImageResponse.
     *           Multiple outputs can happen if, for example, the output JSON is too large
     *           and overflows into multiple sharded files.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Vision\V1P2Beta1\ImageAnnotator::initOnce();
        parent::__construct($data);
    }

    /**
     * Google Cloud Storage URI where the results will be stored. Results will
     * be in JSON format and preceded by its corresponding input URI. This field
     * can either represent a single file, or a prefix for multiple outputs.
     * Prefixes must end in a `/`.
     * Examples:
     * *    File: gs://bucket-name/filename.json
     * *    Prefix: gs://bucket-name/prefix/here/
     * *    File: gs://bucket-name/prefix/here
     * If multiple outputs, each response is still AnnotateFileResponse, each of
     * which contains some subset of the full list of AnnotateImageResponse.
     * Multiple outputs can happen if, for example, the output JSON is too large
     * and overflows into multiple sharded files.
     *
     * Generated from protobuf field <code>string uri = 1;</code>
     * @return string
     */
    public function getUri()
    {
        return $this->uri;
    }

    /**
     * Google Cloud Storage URI where the results will be stored. Results will
     * be in JSON format and preceded by its corresponding input URI. This field
     * can either represent a single file, or a prefix for multiple outputs.
     * Prefixes must end in a `/`.
     * Examples:
     * *    File: gs://bucket-name/filename.json
     * *    Prefix: gs://bucket-name/prefix/here/
     * *    File: gs://bucket-name/prefix/here
     * If multiple outputs, each response is still AnnotateFileResponse, each of
     * which contains some subset of the full list of AnnotateImageResponse.
     * Multiple outputs can happen if, for example, the output JSON is too large
     * and overflows into multiple sharded files.
     *
     * Generated from protobuf field <code>string uri = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->uri = $var;

        return $this;
    }

}

