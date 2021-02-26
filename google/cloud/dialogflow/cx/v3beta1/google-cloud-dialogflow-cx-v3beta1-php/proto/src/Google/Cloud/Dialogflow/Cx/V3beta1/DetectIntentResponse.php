<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/session.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The message returned from the DetectIntent method.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.DetectIntentResponse</code>
 */
class DetectIntentResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The unique identifier of the response. It can be used to
     * locate a response in the training example set or for reporting issues.
     *
     * Generated from protobuf field <code>string response_id = 1;</code>
     */
    protected $response_id = '';
    /**
     * The result of the conversational query.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.QueryResult query_result = 2;</code>
     */
    protected $query_result = null;
    /**
     * The audio data bytes encoded as specified in the request.
     * Note: The output audio is generated based on the values of default platform
     * text responses found in the
     * [`query_result.response_messages`][google.cloud.dialogflow.cx.v3beta1.QueryResult.response_messages] field. If
     * multiple default text responses exist, they will be concatenated when
     * generating audio. If no default platform text responses exist, the
     * generated audio content will be empty.
     * In some scenarios, multiple output audio fields may be present in the
     * response structure. In these cases, only the top-most-level audio output
     * has content.
     *
     * Generated from protobuf field <code>bytes output_audio = 4;</code>
     */
    protected $output_audio = '';
    /**
     * The config used by the speech synthesizer to generate the output audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.OutputAudioConfig output_audio_config = 5;</code>
     */
    protected $output_audio_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $response_id
     *           Output only. The unique identifier of the response. It can be used to
     *           locate a response in the training example set or for reporting issues.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\QueryResult $query_result
     *           The result of the conversational query.
     *     @type string $output_audio
     *           The audio data bytes encoded as specified in the request.
     *           Note: The output audio is generated based on the values of default platform
     *           text responses found in the
     *           [`query_result.response_messages`][google.cloud.dialogflow.cx.v3beta1.QueryResult.response_messages] field. If
     *           multiple default text responses exist, they will be concatenated when
     *           generating audio. If no default platform text responses exist, the
     *           generated audio content will be empty.
     *           In some scenarios, multiple output audio fields may be present in the
     *           response structure. In these cases, only the top-most-level audio output
     *           has content.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\OutputAudioConfig $output_audio_config
     *           The config used by the speech synthesizer to generate the output audio.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Session::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The unique identifier of the response. It can be used to
     * locate a response in the training example set or for reporting issues.
     *
     * Generated from protobuf field <code>string response_id = 1;</code>
     * @return string
     */
    public function getResponseId()
    {
        return $this->response_id;
    }

    /**
     * Output only. The unique identifier of the response. It can be used to
     * locate a response in the training example set or for reporting issues.
     *
     * Generated from protobuf field <code>string response_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setResponseId($var)
    {
        GPBUtil::checkString($var, True);
        $this->response_id = $var;

        return $this;
    }

    /**
     * The result of the conversational query.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.QueryResult query_result = 2;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\QueryResult|null
     */
    public function getQueryResult()
    {
        return isset($this->query_result) ? $this->query_result : null;
    }

    public function hasQueryResult()
    {
        return isset($this->query_result);
    }

    public function clearQueryResult()
    {
        unset($this->query_result);
    }

    /**
     * The result of the conversational query.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.QueryResult query_result = 2;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\QueryResult $var
     * @return $this
     */
    public function setQueryResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\QueryResult::class);
        $this->query_result = $var;

        return $this;
    }

    /**
     * The audio data bytes encoded as specified in the request.
     * Note: The output audio is generated based on the values of default platform
     * text responses found in the
     * [`query_result.response_messages`][google.cloud.dialogflow.cx.v3beta1.QueryResult.response_messages] field. If
     * multiple default text responses exist, they will be concatenated when
     * generating audio. If no default platform text responses exist, the
     * generated audio content will be empty.
     * In some scenarios, multiple output audio fields may be present in the
     * response structure. In these cases, only the top-most-level audio output
     * has content.
     *
     * Generated from protobuf field <code>bytes output_audio = 4;</code>
     * @return string
     */
    public function getOutputAudio()
    {
        return $this->output_audio;
    }

    /**
     * The audio data bytes encoded as specified in the request.
     * Note: The output audio is generated based on the values of default platform
     * text responses found in the
     * [`query_result.response_messages`][google.cloud.dialogflow.cx.v3beta1.QueryResult.response_messages] field. If
     * multiple default text responses exist, they will be concatenated when
     * generating audio. If no default platform text responses exist, the
     * generated audio content will be empty.
     * In some scenarios, multiple output audio fields may be present in the
     * response structure. In these cases, only the top-most-level audio output
     * has content.
     *
     * Generated from protobuf field <code>bytes output_audio = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setOutputAudio($var)
    {
        GPBUtil::checkString($var, False);
        $this->output_audio = $var;

        return $this;
    }

    /**
     * The config used by the speech synthesizer to generate the output audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.OutputAudioConfig output_audio_config = 5;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\OutputAudioConfig|null
     */
    public function getOutputAudioConfig()
    {
        return isset($this->output_audio_config) ? $this->output_audio_config : null;
    }

    public function hasOutputAudioConfig()
    {
        return isset($this->output_audio_config);
    }

    public function clearOutputAudioConfig()
    {
        unset($this->output_audio_config);
    }

    /**
     * The config used by the speech synthesizer to generate the output audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.OutputAudioConfig output_audio_config = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\OutputAudioConfig $var
     * @return $this
     */
    public function setOutputAudioConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\OutputAudioConfig::class);
        $this->output_audio_config = $var;

        return $this;
    }

}

