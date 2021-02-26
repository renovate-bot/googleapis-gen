<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/account_link.proto

namespace Google\Ads\GoogleAds\V5\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The identifiers of a Third Party App Analytics Link.
 *
 * Generated from protobuf message <code>google.ads.googleads.v5.resources.ThirdPartyAppAnalyticsLinkIdentifier</code>
 */
class ThirdPartyAppAnalyticsLinkIdentifier extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The ID of the app analytics provider.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value app_analytics_provider_id = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $app_analytics_provider_id = null;
    /**
     * Immutable. A string that uniquely identifies a mobile application from which the data
     * was collected to the Google Ads API. For iOS, the ID string is the 9 digit
     * string that appears at the end of an App Store URL (e.g., "422689480" for
     * "Gmail" whose App Store link is
     * https://apps.apple.com/us/app/gmail-email-by-google/id422689480). For
     * Android, the ID string is the application's package name (e.g.,
     * "com.google.android.gm" for "Gmail" given Google Play link
     * https://play.google.com/store/apps/details?id=com.google.android.gm)
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue app_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $app_id = null;
    /**
     * Immutable. The vendor of the app.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.enums.MobileAppVendorEnum.MobileAppVendor app_vendor = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $app_vendor = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Int64Value $app_analytics_provider_id
     *           Immutable. The ID of the app analytics provider.
     *           This field should not be empty when creating a new third
     *           party app analytics link. It is unable to be modified after the creation of
     *           the link.
     *     @type \Google\Protobuf\StringValue $app_id
     *           Immutable. A string that uniquely identifies a mobile application from which the data
     *           was collected to the Google Ads API. For iOS, the ID string is the 9 digit
     *           string that appears at the end of an App Store URL (e.g., "422689480" for
     *           "Gmail" whose App Store link is
     *           https://apps.apple.com/us/app/gmail-email-by-google/id422689480). For
     *           Android, the ID string is the application's package name (e.g.,
     *           "com.google.android.gm" for "Gmail" given Google Play link
     *           https://play.google.com/store/apps/details?id=com.google.android.gm)
     *           This field should not be empty when creating a new third
     *           party app analytics link. It is unable to be modified after the creation of
     *           the link.
     *     @type int $app_vendor
     *           Immutable. The vendor of the app.
     *           This field should not be empty when creating a new third
     *           party app analytics link. It is unable to be modified after the creation of
     *           the link.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V5\Resources\AccountLink::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The ID of the app analytics provider.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value app_analytics_provider_id = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getAppAnalyticsProviderId()
    {
        return isset($this->app_analytics_provider_id) ? $this->app_analytics_provider_id : null;
    }

    public function hasAppAnalyticsProviderId()
    {
        return isset($this->app_analytics_provider_id);
    }

    public function clearAppAnalyticsProviderId()
    {
        unset($this->app_analytics_provider_id);
    }

    /**
     * Returns the unboxed value from <code>getAppAnalyticsProviderId()</code>

     * Immutable. The ID of the app analytics provider.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value app_analytics_provider_id = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return int|string|null
     */
    public function getAppAnalyticsProviderIdUnwrapped()
    {
        return $this->readWrapperValue("app_analytics_provider_id");
    }

    /**
     * Immutable. The ID of the app analytics provider.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value app_analytics_provider_id = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setAppAnalyticsProviderId($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->app_analytics_provider_id = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Immutable. The ID of the app analytics provider.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value app_analytics_provider_id = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setAppAnalyticsProviderIdUnwrapped($var)
    {
        $this->writeWrapperValue("app_analytics_provider_id", $var);
        return $this;}

    /**
     * Immutable. A string that uniquely identifies a mobile application from which the data
     * was collected to the Google Ads API. For iOS, the ID string is the 9 digit
     * string that appears at the end of an App Store URL (e.g., "422689480" for
     * "Gmail" whose App Store link is
     * https://apps.apple.com/us/app/gmail-email-by-google/id422689480). For
     * Android, the ID string is the application's package name (e.g.,
     * "com.google.android.gm" for "Gmail" given Google Play link
     * https://play.google.com/store/apps/details?id=com.google.android.gm)
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue app_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getAppId()
    {
        return isset($this->app_id) ? $this->app_id : null;
    }

    public function hasAppId()
    {
        return isset($this->app_id);
    }

    public function clearAppId()
    {
        unset($this->app_id);
    }

    /**
     * Returns the unboxed value from <code>getAppId()</code>

     * Immutable. A string that uniquely identifies a mobile application from which the data
     * was collected to the Google Ads API. For iOS, the ID string is the 9 digit
     * string that appears at the end of an App Store URL (e.g., "422689480" for
     * "Gmail" whose App Store link is
     * https://apps.apple.com/us/app/gmail-email-by-google/id422689480). For
     * Android, the ID string is the application's package name (e.g.,
     * "com.google.android.gm" for "Gmail" given Google Play link
     * https://play.google.com/store/apps/details?id=com.google.android.gm)
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue app_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string|null
     */
    public function getAppIdUnwrapped()
    {
        return $this->readWrapperValue("app_id");
    }

    /**
     * Immutable. A string that uniquely identifies a mobile application from which the data
     * was collected to the Google Ads API. For iOS, the ID string is the 9 digit
     * string that appears at the end of an App Store URL (e.g., "422689480" for
     * "Gmail" whose App Store link is
     * https://apps.apple.com/us/app/gmail-email-by-google/id422689480). For
     * Android, the ID string is the application's package name (e.g.,
     * "com.google.android.gm" for "Gmail" given Google Play link
     * https://play.google.com/store/apps/details?id=com.google.android.gm)
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue app_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setAppId($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->app_id = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Immutable. A string that uniquely identifies a mobile application from which the data
     * was collected to the Google Ads API. For iOS, the ID string is the 9 digit
     * string that appears at the end of an App Store URL (e.g., "422689480" for
     * "Gmail" whose App Store link is
     * https://apps.apple.com/us/app/gmail-email-by-google/id422689480). For
     * Android, the ID string is the application's package name (e.g.,
     * "com.google.android.gm" for "Gmail" given Google Play link
     * https://play.google.com/store/apps/details?id=com.google.android.gm)
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue app_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string|null $var
     * @return $this
     */
    public function setAppIdUnwrapped($var)
    {
        $this->writeWrapperValue("app_id", $var);
        return $this;}

    /**
     * Immutable. The vendor of the app.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.enums.MobileAppVendorEnum.MobileAppVendor app_vendor = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return int
     */
    public function getAppVendor()
    {
        return $this->app_vendor;
    }

    /**
     * Immutable. The vendor of the app.
     * This field should not be empty when creating a new third
     * party app analytics link. It is unable to be modified after the creation of
     * the link.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.enums.MobileAppVendorEnum.MobileAppVendor app_vendor = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param int $var
     * @return $this
     */
    public function setAppVendor($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V5\Enums\MobileAppVendorEnum\MobileAppVendor::class);
        $this->app_vendor = $var;

        return $this;
    }

}

