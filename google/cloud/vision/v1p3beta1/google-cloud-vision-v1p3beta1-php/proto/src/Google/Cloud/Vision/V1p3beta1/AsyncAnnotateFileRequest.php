<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/vision/v1p3beta1/image_annotator.proto

namespace Google\Cloud\Vision\V1p3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An offline file annotation request.
 *
 * Generated from protobuf message <code>google.cloud.vision.v1p3beta1.AsyncAnnotateFileRequest</code>
 */
class AsyncAnnotateFileRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Information about the input file.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.InputConfig input_config = 1;</code>
     */
    protected $input_config = null;
    /**
     * Required. Requested features.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p3beta1.Feature features = 2;</code>
     */
    private $features;
    /**
     * Additional context that may accompany the image(s) in the file.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.ImageContext image_context = 3;</code>
     */
    protected $image_context = null;
    /**
     * Required. The desired output location and metadata (e.g. format).
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.OutputConfig output_config = 4;</code>
     */
    protected $output_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Vision\V1p3beta1\InputConfig $input_config
     *           Required. Information about the input file.
     *     @type \Google\Cloud\Vision\V1p3beta1\Feature[]|\Google\Protobuf\Internal\RepeatedField $features
     *           Required. Requested features.
     *     @type \Google\Cloud\Vision\V1p3beta1\ImageContext $image_context
     *           Additional context that may accompany the image(s) in the file.
     *     @type \Google\Cloud\Vision\V1p3beta1\OutputConfig $output_config
     *           Required. The desired output location and metadata (e.g. format).
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Vision\V1P3Beta1\ImageAnnotator::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Information about the input file.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.InputConfig input_config = 1;</code>
     * @return \Google\Cloud\Vision\V1p3beta1\InputConfig|null
     */
    public function getInputConfig()
    {
        return isset($this->input_config) ? $this->input_config : null;
    }

    public function hasInputConfig()
    {
        return isset($this->input_config);
    }

    public function clearInputConfig()
    {
        unset($this->input_config);
    }

    /**
     * Required. Information about the input file.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.InputConfig input_config = 1;</code>
     * @param \Google\Cloud\Vision\V1p3beta1\InputConfig $var
     * @return $this
     */
    public function setInputConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Vision\V1p3beta1\InputConfig::class);
        $this->input_config = $var;

        return $this;
    }

    /**
     * Required. Requested features.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p3beta1.Feature features = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getFeatures()
    {
        return $this->features;
    }

    /**
     * Required. Requested features.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p3beta1.Feature features = 2;</code>
     * @param \Google\Cloud\Vision\V1p3beta1\Feature[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setFeatures($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Vision\V1p3beta1\Feature::class);
        $this->features = $arr;

        return $this;
    }

    /**
     * Additional context that may accompany the image(s) in the file.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.ImageContext image_context = 3;</code>
     * @return \Google\Cloud\Vision\V1p3beta1\ImageContext|null
     */
    public function getImageContext()
    {
        return isset($this->image_context) ? $this->image_context : null;
    }

    public function hasImageContext()
    {
        return isset($this->image_context);
    }

    public function clearImageContext()
    {
        unset($this->image_context);
    }

    /**
     * Additional context that may accompany the image(s) in the file.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.ImageContext image_context = 3;</code>
     * @param \Google\Cloud\Vision\V1p3beta1\ImageContext $var
     * @return $this
     */
    public function setImageContext($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Vision\V1p3beta1\ImageContext::class);
        $this->image_context = $var;

        return $this;
    }

    /**
     * Required. The desired output location and metadata (e.g. format).
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.OutputConfig output_config = 4;</code>
     * @return \Google\Cloud\Vision\V1p3beta1\OutputConfig|null
     */
    public function getOutputConfig()
    {
        return isset($this->output_config) ? $this->output_config : null;
    }

    public function hasOutputConfig()
    {
        return isset($this->output_config);
    }

    public function clearOutputConfig()
    {
        unset($this->output_config);
    }

    /**
     * Required. The desired output location and metadata (e.g. format).
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p3beta1.OutputConfig output_config = 4;</code>
     * @param \Google\Cloud\Vision\V1p3beta1\OutputConfig $var
     * @return $this
     */
    public function setOutputConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Vision\V1p3beta1\OutputConfig::class);
        $this->output_config = $var;

        return $this;
    }

}

