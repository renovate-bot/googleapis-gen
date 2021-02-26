<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/mediatranslation/v1beta1/media_translation.proto

namespace Google\Cloud\MediaTranslation\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A streaming speech translation result corresponding to a portion of the audio
 * that is currently being processed.
 *
 * Generated from protobuf message <code>google.cloud.mediatranslation.v1beta1.StreamingTranslateSpeechResult</code>
 */
class StreamingTranslateSpeechResult extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The debug only recognition result in original language. This field is debug
     * only and will be set to empty string if not available.
     * This is implementation detail and will not be backward compatible.
     * Still need to decide whether to expose this field by default.
     *
     * Generated from protobuf field <code>string recognition_result = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $recognition_result = '';
    protected $result;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\MediaTranslation\V1beta1\StreamingTranslateSpeechResult\TextTranslationResult $text_translation_result
     *           Text translation result.
     *     @type string $recognition_result
     *           Output only. The debug only recognition result in original language. This field is debug
     *           only and will be set to empty string if not available.
     *           This is implementation detail and will not be backward compatible.
     *           Still need to decide whether to expose this field by default.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Mediatranslation\V1Beta1\MediaTranslation::initOnce();
        parent::__construct($data);
    }

    /**
     * Text translation result.
     *
     * Generated from protobuf field <code>.google.cloud.mediatranslation.v1beta1.StreamingTranslateSpeechResult.TextTranslationResult text_translation_result = 1;</code>
     * @return \Google\Cloud\MediaTranslation\V1beta1\StreamingTranslateSpeechResult\TextTranslationResult|null
     */
    public function getTextTranslationResult()
    {
        return $this->readOneof(1);
    }

    public function hasTextTranslationResult()
    {
        return $this->hasOneof(1);
    }

    /**
     * Text translation result.
     *
     * Generated from protobuf field <code>.google.cloud.mediatranslation.v1beta1.StreamingTranslateSpeechResult.TextTranslationResult text_translation_result = 1;</code>
     * @param \Google\Cloud\MediaTranslation\V1beta1\StreamingTranslateSpeechResult\TextTranslationResult $var
     * @return $this
     */
    public function setTextTranslationResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\MediaTranslation\V1beta1\StreamingTranslateSpeechResult\TextTranslationResult::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * Output only. The debug only recognition result in original language. This field is debug
     * only and will be set to empty string if not available.
     * This is implementation detail and will not be backward compatible.
     * Still need to decide whether to expose this field by default.
     *
     * Generated from protobuf field <code>string recognition_result = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getRecognitionResult()
    {
        return $this->recognition_result;
    }

    /**
     * Output only. The debug only recognition result in original language. This field is debug
     * only and will be set to empty string if not available.
     * This is implementation detail and will not be backward compatible.
     * Still need to decide whether to expose this field by default.
     *
     * Generated from protobuf field <code>string recognition_result = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setRecognitionResult($var)
    {
        GPBUtil::checkString($var, True);
        $this->recognition_result = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getResult()
    {
        return $this->whichOneof("result");
    }

}

