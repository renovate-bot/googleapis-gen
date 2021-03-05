<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/target.proto

namespace Google\Apps\Drive\Activity\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A comment on a file.
 *
 * Generated from protobuf message <code>google.apps.drive.activity.v2.FileComment</code>
 */
class FileComment extends \Google\Protobuf\Internal\Message
{
    /**
     * The comment in the discussion thread. This identifier is an opaque string
     * compatible with the Drive API; see
     * https://developers.google.com/drive/v3/reference/comments/get
     *
     * Generated from protobuf field <code>string legacy_comment_id = 1;</code>
     */
    protected $legacy_comment_id = '';
    /**
     * The discussion thread to which the comment was added. This identifier is an
     * opaque string compatible with the Drive API and references the first
     * comment in a discussion; see
     * https://developers.google.com/drive/v3/reference/comments/get
     *
     * Generated from protobuf field <code>string legacy_discussion_id = 2;</code>
     */
    protected $legacy_discussion_id = '';
    /**
     * The link to the discussion thread containing this comment, for example,
     * `https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID`.
     *
     * Generated from protobuf field <code>string link_to_discussion = 3;</code>
     */
    protected $link_to_discussion = '';
    /**
     * The Drive item containing this comment.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItem parent = 4;</code>
     */
    protected $parent = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $legacy_comment_id
     *           The comment in the discussion thread. This identifier is an opaque string
     *           compatible with the Drive API; see
     *           https://developers.google.com/drive/v3/reference/comments/get
     *     @type string $legacy_discussion_id
     *           The discussion thread to which the comment was added. This identifier is an
     *           opaque string compatible with the Drive API and references the first
     *           comment in a discussion; see
     *           https://developers.google.com/drive/v3/reference/comments/get
     *     @type string $link_to_discussion
     *           The link to the discussion thread containing this comment, for example,
     *           `https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID`.
     *     @type \Google\Apps\Drive\Activity\V2\DriveItem $parent
     *           The Drive item containing this comment.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Target::initOnce();
        parent::__construct($data);
    }

    /**
     * The comment in the discussion thread. This identifier is an opaque string
     * compatible with the Drive API; see
     * https://developers.google.com/drive/v3/reference/comments/get
     *
     * Generated from protobuf field <code>string legacy_comment_id = 1;</code>
     * @return string
     */
    public function getLegacyCommentId()
    {
        return $this->legacy_comment_id;
    }

    /**
     * The comment in the discussion thread. This identifier is an opaque string
     * compatible with the Drive API; see
     * https://developers.google.com/drive/v3/reference/comments/get
     *
     * Generated from protobuf field <code>string legacy_comment_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setLegacyCommentId($var)
    {
        GPBUtil::checkString($var, True);
        $this->legacy_comment_id = $var;

        return $this;
    }

    /**
     * The discussion thread to which the comment was added. This identifier is an
     * opaque string compatible with the Drive API and references the first
     * comment in a discussion; see
     * https://developers.google.com/drive/v3/reference/comments/get
     *
     * Generated from protobuf field <code>string legacy_discussion_id = 2;</code>
     * @return string
     */
    public function getLegacyDiscussionId()
    {
        return $this->legacy_discussion_id;
    }

    /**
     * The discussion thread to which the comment was added. This identifier is an
     * opaque string compatible with the Drive API and references the first
     * comment in a discussion; see
     * https://developers.google.com/drive/v3/reference/comments/get
     *
     * Generated from protobuf field <code>string legacy_discussion_id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setLegacyDiscussionId($var)
    {
        GPBUtil::checkString($var, True);
        $this->legacy_discussion_id = $var;

        return $this;
    }

    /**
     * The link to the discussion thread containing this comment, for example,
     * `https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID`.
     *
     * Generated from protobuf field <code>string link_to_discussion = 3;</code>
     * @return string
     */
    public function getLinkToDiscussion()
    {
        return $this->link_to_discussion;
    }

    /**
     * The link to the discussion thread containing this comment, for example,
     * `https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID`.
     *
     * Generated from protobuf field <code>string link_to_discussion = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setLinkToDiscussion($var)
    {
        GPBUtil::checkString($var, True);
        $this->link_to_discussion = $var;

        return $this;
    }

    /**
     * The Drive item containing this comment.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItem parent = 4;</code>
     * @return \Google\Apps\Drive\Activity\V2\DriveItem|null
     */
    public function getParent()
    {
        return isset($this->parent) ? $this->parent : null;
    }

    public function hasParent()
    {
        return isset($this->parent);
    }

    public function clearParent()
    {
        unset($this->parent);
    }

    /**
     * The Drive item containing this comment.
     *
     * Generated from protobuf field <code>.google.apps.drive.activity.v2.DriveItem parent = 4;</code>
     * @param \Google\Apps\Drive\Activity\V2\DriveItem $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkMessage($var, \Google\Apps\Drive\Activity\V2\DriveItem::class);
        $this->parent = $var;

        return $this;
    }

}

