<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/language/v1beta2/language_service.proto

namespace Google\Cloud\Language\V1beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents a phrase in the text that is a known entity, such as
 * a person, an organization, or location. The API associates information, such
 * as salience and mentions, with entities.
 *
 * Generated from protobuf message <code>google.cloud.language.v1beta2.Entity</code>
 */
class Entity extends \Google\Protobuf\Internal\Message
{
    /**
     * The representative name for the entity.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * The entity type.
     *
     * Generated from protobuf field <code>.google.cloud.language.v1beta2.Entity.Type type = 2;</code>
     */
    protected $type = 0;
    /**
     * Metadata associated with the entity.
     * For most entity types, the metadata is a Wikipedia URL (`wikipedia_url`)
     * and Knowledge Graph MID (`mid`), if they are available. For the metadata
     * associated with other entity types, see the Type table below.
     *
     * Generated from protobuf field <code>map<string, string> metadata = 3;</code>
     */
    private $metadata;
    /**
     * The salience score associated with the entity in the [0, 1.0] range.
     * The salience score for an entity provides information about the
     * importance or centrality of that entity to the entire document text.
     * Scores closer to 0 are less salient, while scores closer to 1.0 are highly
     * salient.
     *
     * Generated from protobuf field <code>float salience = 4;</code>
     */
    protected $salience = 0.0;
    /**
     * The mentions of this entity in the input document. The API currently
     * supports proper noun mentions.
     *
     * Generated from protobuf field <code>repeated .google.cloud.language.v1beta2.EntityMention mentions = 5;</code>
     */
    private $mentions;
    /**
     * For calls to [AnalyzeEntitySentiment][] or if
     * [AnnotateTextRequest.Features.extract_entity_sentiment][google.cloud.language.v1beta2.AnnotateTextRequest.Features.extract_entity_sentiment] is set to
     * true, this field will contain the aggregate sentiment expressed for this
     * entity in the provided document.
     *
     * Generated from protobuf field <code>.google.cloud.language.v1beta2.Sentiment sentiment = 6;</code>
     */
    protected $sentiment = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The representative name for the entity.
     *     @type int $type
     *           The entity type.
     *     @type array|\Google\Protobuf\Internal\MapField $metadata
     *           Metadata associated with the entity.
     *           For most entity types, the metadata is a Wikipedia URL (`wikipedia_url`)
     *           and Knowledge Graph MID (`mid`), if they are available. For the metadata
     *           associated with other entity types, see the Type table below.
     *     @type float $salience
     *           The salience score associated with the entity in the [0, 1.0] range.
     *           The salience score for an entity provides information about the
     *           importance or centrality of that entity to the entire document text.
     *           Scores closer to 0 are less salient, while scores closer to 1.0 are highly
     *           salient.
     *     @type \Google\Cloud\Language\V1beta2\EntityMention[]|\Google\Protobuf\Internal\RepeatedField $mentions
     *           The mentions of this entity in the input document. The API currently
     *           supports proper noun mentions.
     *     @type \Google\Cloud\Language\V1beta2\Sentiment $sentiment
     *           For calls to [AnalyzeEntitySentiment][] or if
     *           [AnnotateTextRequest.Features.extract_entity_sentiment][google.cloud.language.v1beta2.AnnotateTextRequest.Features.extract_entity_sentiment] is set to
     *           true, this field will contain the aggregate sentiment expressed for this
     *           entity in the provided document.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Language\V1Beta2\LanguageService::initOnce();
        parent::__construct($data);
    }

    /**
     * The representative name for the entity.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The representative name for the entity.
     *
     * Generated from protobuf field <code>string name = 1;</code>
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
     * The entity type.
     *
     * Generated from protobuf field <code>.google.cloud.language.v1beta2.Entity.Type type = 2;</code>
     * @return int
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * The entity type.
     *
     * Generated from protobuf field <code>.google.cloud.language.v1beta2.Entity.Type type = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Language\V1beta2\Entity\Type::class);
        $this->type = $var;

        return $this;
    }

    /**
     * Metadata associated with the entity.
     * For most entity types, the metadata is a Wikipedia URL (`wikipedia_url`)
     * and Knowledge Graph MID (`mid`), if they are available. For the metadata
     * associated with other entity types, see the Type table below.
     *
     * Generated from protobuf field <code>map<string, string> metadata = 3;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getMetadata()
    {
        return $this->metadata;
    }

    /**
     * Metadata associated with the entity.
     * For most entity types, the metadata is a Wikipedia URL (`wikipedia_url`)
     * and Knowledge Graph MID (`mid`), if they are available. For the metadata
     * associated with other entity types, see the Type table below.
     *
     * Generated from protobuf field <code>map<string, string> metadata = 3;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setMetadata($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->metadata = $arr;

        return $this;
    }

    /**
     * The salience score associated with the entity in the [0, 1.0] range.
     * The salience score for an entity provides information about the
     * importance or centrality of that entity to the entire document text.
     * Scores closer to 0 are less salient, while scores closer to 1.0 are highly
     * salient.
     *
     * Generated from protobuf field <code>float salience = 4;</code>
     * @return float
     */
    public function getSalience()
    {
        return $this->salience;
    }

    /**
     * The salience score associated with the entity in the [0, 1.0] range.
     * The salience score for an entity provides information about the
     * importance or centrality of that entity to the entire document text.
     * Scores closer to 0 are less salient, while scores closer to 1.0 are highly
     * salient.
     *
     * Generated from protobuf field <code>float salience = 4;</code>
     * @param float $var
     * @return $this
     */
    public function setSalience($var)
    {
        GPBUtil::checkFloat($var);
        $this->salience = $var;

        return $this;
    }

    /**
     * The mentions of this entity in the input document. The API currently
     * supports proper noun mentions.
     *
     * Generated from protobuf field <code>repeated .google.cloud.language.v1beta2.EntityMention mentions = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getMentions()
    {
        return $this->mentions;
    }

    /**
     * The mentions of this entity in the input document. The API currently
     * supports proper noun mentions.
     *
     * Generated from protobuf field <code>repeated .google.cloud.language.v1beta2.EntityMention mentions = 5;</code>
     * @param \Google\Cloud\Language\V1beta2\EntityMention[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setMentions($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Language\V1beta2\EntityMention::class);
        $this->mentions = $arr;

        return $this;
    }

    /**
     * For calls to [AnalyzeEntitySentiment][] or if
     * [AnnotateTextRequest.Features.extract_entity_sentiment][google.cloud.language.v1beta2.AnnotateTextRequest.Features.extract_entity_sentiment] is set to
     * true, this field will contain the aggregate sentiment expressed for this
     * entity in the provided document.
     *
     * Generated from protobuf field <code>.google.cloud.language.v1beta2.Sentiment sentiment = 6;</code>
     * @return \Google\Cloud\Language\V1beta2\Sentiment|null
     */
    public function getSentiment()
    {
        return isset($this->sentiment) ? $this->sentiment : null;
    }

    public function hasSentiment()
    {
        return isset($this->sentiment);
    }

    public function clearSentiment()
    {
        unset($this->sentiment);
    }

    /**
     * For calls to [AnalyzeEntitySentiment][] or if
     * [AnnotateTextRequest.Features.extract_entity_sentiment][google.cloud.language.v1beta2.AnnotateTextRequest.Features.extract_entity_sentiment] is set to
     * true, this field will contain the aggregate sentiment expressed for this
     * entity in the provided document.
     *
     * Generated from protobuf field <code>.google.cloud.language.v1beta2.Sentiment sentiment = 6;</code>
     * @param \Google\Cloud\Language\V1beta2\Sentiment $var
     * @return $this
     */
    public function setSentiment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Language\V1beta2\Sentiment::class);
        $this->sentiment = $var;

        return $this;
    }

}

