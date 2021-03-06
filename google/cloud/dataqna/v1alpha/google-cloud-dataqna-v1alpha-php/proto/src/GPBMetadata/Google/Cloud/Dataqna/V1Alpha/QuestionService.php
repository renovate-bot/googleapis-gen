<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataqna/v1alpha/question_service.proto

namespace GPBMetadata\Google\Cloud\Dataqna\V1Alpha;

class QuestionService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Dataqna\V1Alpha\Question::initOnce();
        \GPBMetadata\Google\Cloud\Dataqna\V1Alpha\UserFeedback::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
3google/cloud/dataqna/v1alpha/question_service.protogoogle.cloud.dataqna.v1alphagoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto+google/cloud/dataqna/v1alpha/question.proto0google/cloud/dataqna/v1alpha/user_feedback.proto google/protobuf/field_mask.proto"z
GetQuestionRequest5
name (	B\'�A�A!
dataqna.googleapis.com/Question-
	read_mask (2.google.protobuf.FieldMask"�
CreateQuestionRequest9
parent (	B)�A�A#
!locations.googleapis.com/Location=
question (2&.google.cloud.dataqna.v1alpha.QuestionB�A"N
ExecuteQuestionRequest
name (	B�A!
interpretation_index (B�A"S
GetUserFeedbackRequest9
name (	B+�A�A%
#dataqna.googleapis.com/UserFeedback"�
UpdateUserFeedbackRequestF
user_feedback (2*.google.cloud.dataqna.v1alpha.UserFeedbackB�A/
update_mask (2.google.protobuf.FieldMask2�
QuestionService�
GetQuestion0.google.cloud.dataqna.v1alpha.GetQuestionRequest&.google.cloud.dataqna.v1alpha.Question"A���42/v1alpha/{name=projects/*/locations/*/questions/*}�Aname�
CreateQuestion3.google.cloud.dataqna.v1alpha.CreateQuestionRequest&.google.cloud.dataqna.v1alpha.Question"V���>"2/v1alpha/{parent=projects/*/locations/*}/questions:question�Aparent,question�
ExecuteQuestion4.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest&.google.cloud.dataqna.v1alpha.Question"a���?":/v1alpha/{name=projects/*/locations/*/questions/*}:execute:*�Aname,interpretation_index�
GetUserFeedback4.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest*.google.cloud.dataqna.v1alpha.UserFeedback"N���A?/v1alpha/{name=projects/*/locations/*/questions/*/userFeedback}�Aname�
UpdateUserFeedback7.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest*.google.cloud.dataqna.v1alpha.UserFeedback"����^2M/v1alpha/{user_feedback.name=projects/*/locations/*/questions/*/userFeedback}:user_feedback�Auser_feedback,update_maskJ�Adataqna.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
 com.google.cloud.dataqna.v1alphaBQuestionServiceProtoPZCgoogle.golang.org/genproto/googleapis/cloud/dataqna/v1alpha;dataqna�Google.Cloud.DataQnA.V1Alpha�Google\\Cloud\\DataQnA\\V1alpha�Google::Cloud::DataQnA::V1alphabproto3'
        , true);

        static::$is_initialized = true;
    }
}

