// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/errors/offline_user_data_job_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/errors/offline_user_data_job_error.proto</summary>
  public static partial class OfflineUserDataJobErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/errors/offline_user_data_job_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lcnJvcnMvb2ZmbGluZV91c2Vy",
            "X2RhdGFfam9iX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "OC5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i+AgKG09m",
            "ZmxpbmVVc2VyRGF0YUpvYkVycm9yRW51bSLYCAoXT2ZmbGluZVVzZXJEYXRh",
            "Sm9iRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESGAoUSU5W",
            "QUxJRF9VU0VSX0xJU1RfSUQQAxIaChZJTlZBTElEX1VTRVJfTElTVF9UWVBF",
            "EAQSIAocTk9UX09OX0FMTE9XTElTVF9GT1JfVVNFUl9JRBAhEiAKHElOQ09N",
            "UEFUSUJMRV9VUExPQURfS0VZX1RZUEUQBhIbChdNSVNTSU5HX1VTRVJfSURF",
            "TlRJRklFUhAHEhwKGElOVkFMSURfTU9CSUxFX0lEX0ZPUk1BVBAIEh0KGVRP",
            "T19NQU5ZX1VTRVJfSURFTlRJRklFUlMQCRIrCidOT1RfT05fQUxMT1dMSVNU",
            "X0ZPUl9TVE9SRV9TQUxFU19ESVJFQ1QQHxIsCihOT1RfT05fQUxMT1dMSVNU",
            "X0ZPUl9VTklGSUVEX1NUT1JFX1NBTEVTECASFgoSSU5WQUxJRF9QQVJUTkVS",
            "X0lEEAsSFAoQSU5WQUxJRF9FTkNPRElORxAMEhgKFElOVkFMSURfQ09VTlRS",
            "WV9DT0RFEA0SIAocSU5DT01QQVRJQkxFX1VTRVJfSURFTlRJRklFUhAOEhsK",
            "F0ZVVFVSRV9UUkFOU0FDVElPTl9USU1FEA8SHQoZSU5WQUxJRF9DT05WRVJT",
            "SU9OX0FDVElPThAQEhsKF01PQklMRV9JRF9OT1RfU1VQUE9SVEVEEBESGwoX",
            "SU5WQUxJRF9PUEVSQVRJT05fT1JERVIQEhIZChVDT05GTElDVElOR19PUEVS",
            "QVRJT04QExIlCiFFWFRFUk5BTF9VUERBVEVfSURfQUxSRUFEWV9FWElTVFMQ",
            "FRIXChNKT0JfQUxSRUFEWV9TVEFSVEVEEBYSGAoUUkVNT1ZFX05PVF9TVVBQ",
            "T1JURUQQFxIcChhSRU1PVkVfQUxMX05PVF9TVVBQT1JURUQQGBIZChVJTlZB",
            "TElEX1NIQTI1Nl9GT1JNQVQQGRIXChNDVVNUT01fS0VZX0RJU0FCTEVEEBoS",
            "HQoZQ1VTVE9NX0tFWV9OT1RfUFJFREVGSU5FRBAbEhYKEkNVU1RPTV9LRVlf",
            "Tk9UX1NFVBAdEi0KKUNVU1RPTUVSX05PVF9BQ0NFUFRFRF9DVVNUT01FUl9E",
            "QVRBX1RFUk1TEB4SOgo2QVRUUklCVVRFU19OT1RfQVBQTElDQUJMRV9GT1Jf",
            "Q1VTVE9NRVJfTUFUQ0hfVVNFUl9MSVNUECISJgoiTElGRVRJTUVfVkFMVUVf",
            "QlVDS0VUX05PVF9JTl9SQU5HRRAjEi8KK0lOQ09NUEFUSUJMRV9VU0VSX0lE",
            "RU5USUZJRVJfRk9SX0FUVFJJQlVURVMQJBIbChdGVVRVUkVfVElNRV9OT1Rf",
            "QUxMT1dFRBAlEjEKLUxBU1RfUFVSQ0hBU0VfVElNRV9MRVNTX1RIQU5fQUNR",
            "VUlTSVRJT05fVElNRRAmQvcBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djguZXJyb3JzQhxPZmZsaW5lVXNlckRhdGFKb2JFcnJvclByb3RvUAFaRGdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92OC9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjguRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjhcRXJy",
            "b3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OkVycm9yc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Errors.OfflineUserDataJobErrorEnum), global::Google.Ads.GoogleAds.V8.Errors.OfflineUserDataJobErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Errors.OfflineUserDataJobErrorEnum.Types.OfflineUserDataJobError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible offline user data job errors.
  /// </summary>
  public sealed partial class OfflineUserDataJobErrorEnum : pb::IMessage<OfflineUserDataJobErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJobErrorEnum> _parser = new pb::MessageParser<OfflineUserDataJobErrorEnum>(() => new OfflineUserDataJobErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineUserDataJobErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Errors.OfflineUserDataJobErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobErrorEnum(OfflineUserDataJobErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobErrorEnum Clone() {
      return new OfflineUserDataJobErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJobErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineUserDataJobErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OfflineUserDataJobErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OfflineUserDataJobErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible request errors.
      /// </summary>
      public enum OfflineUserDataJobError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The user list ID provided for the job is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_ID")] InvalidUserListId = 3,
        /// <summary>
        /// Type of the user list is not applicable for the job.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_TYPE")] InvalidUserListType = 4,
        /// <summary>
        /// Customer is not allowisted for using user ID in upload data.
        /// </summary>
        [pbr::OriginalName("NOT_ON_ALLOWLIST_FOR_USER_ID")] NotOnAllowlistForUserId = 33,
        /// <summary>
        /// Upload data is not compatible with the upload key type of the associated
        /// user list.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_UPLOAD_KEY_TYPE")] IncompatibleUploadKeyType = 6,
        /// <summary>
        /// The user identifier is missing valid data.
        /// </summary>
        [pbr::OriginalName("MISSING_USER_IDENTIFIER")] MissingUserIdentifier = 7,
        /// <summary>
        /// The mobile ID is malformed.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_ID_FORMAT")] InvalidMobileIdFormat = 8,
        /// <summary>
        /// Maximum number of user identifiers allowed per request is 100,000.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_USER_IDENTIFIERS")] TooManyUserIdentifiers = 9,
        /// <summary>
        /// Customer is not on the allow-list for store sales direct data.
        /// </summary>
        [pbr::OriginalName("NOT_ON_ALLOWLIST_FOR_STORE_SALES_DIRECT")] NotOnAllowlistForStoreSalesDirect = 31,
        /// <summary>
        /// Customer is not on the allow-list for unified store sales data.
        /// </summary>
        [pbr::OriginalName("NOT_ON_ALLOWLIST_FOR_UNIFIED_STORE_SALES")] NotOnAllowlistForUnifiedStoreSales = 32,
        /// <summary>
        /// The partner ID in store sales direct metadata is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PARTNER_ID")] InvalidPartnerId = 11,
        /// <summary>
        /// The data in user identifier should not be encoded.
        /// </summary>
        [pbr::OriginalName("INVALID_ENCODING")] InvalidEncoding = 12,
        /// <summary>
        /// The country code is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 13,
        /// <summary>
        /// Incompatible user identifier when using third_party_user_id for store
        /// sales direct first party data or not using third_party_user_id for store
        /// sales third party data.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_USER_IDENTIFIER")] IncompatibleUserIdentifier = 14,
        /// <summary>
        /// A transaction time in the future is not allowed.
        /// </summary>
        [pbr::OriginalName("FUTURE_TRANSACTION_TIME")] FutureTransactionTime = 15,
        /// <summary>
        /// The conversion_action specified in transaction_attributes is used to
        /// report conversions to a conversion action configured in Google Ads. This
        /// error indicates there is no such conversion action in the account.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_ACTION")] InvalidConversionAction = 16,
        /// <summary>
        /// Mobile ID is not supported for store sales direct data.
        /// </summary>
        [pbr::OriginalName("MOBILE_ID_NOT_SUPPORTED")] MobileIdNotSupported = 17,
        /// <summary>
        /// When a remove-all operation is provided, it has to be the first operation
        /// of the operation list.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATION_ORDER")] InvalidOperationOrder = 18,
        /// <summary>
        /// Mixing creation and removal of offline data in the same job is not
        /// allowed.
        /// </summary>
        [pbr::OriginalName("CONFLICTING_OPERATION")] ConflictingOperation = 19,
        /// <summary>
        /// The external update ID already exists.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_UPDATE_ID_ALREADY_EXISTS")] ExternalUpdateIdAlreadyExists = 21,
        /// <summary>
        /// Once the upload job is started, new operations cannot be added.
        /// </summary>
        [pbr::OriginalName("JOB_ALREADY_STARTED")] JobAlreadyStarted = 22,
        /// <summary>
        /// Remove operation is not allowed for store sales direct updates.
        /// </summary>
        [pbr::OriginalName("REMOVE_NOT_SUPPORTED")] RemoveNotSupported = 23,
        /// <summary>
        /// Remove-all is not supported for certain offline user data job types.
        /// </summary>
        [pbr::OriginalName("REMOVE_ALL_NOT_SUPPORTED")] RemoveAllNotSupported = 24,
        /// <summary>
        /// The SHA256 encoded value is malformed.
        /// </summary>
        [pbr::OriginalName("INVALID_SHA256_FORMAT")] InvalidSha256Format = 25,
        /// <summary>
        /// The custom key specified is not enabled for the unified store sales
        /// upload.
        /// </summary>
        [pbr::OriginalName("CUSTOM_KEY_DISABLED")] CustomKeyDisabled = 26,
        /// <summary>
        /// The custom key specified is not predefined through the Google Ads UI.
        /// </summary>
        [pbr::OriginalName("CUSTOM_KEY_NOT_PREDEFINED")] CustomKeyNotPredefined = 27,
        /// <summary>
        /// The custom key specified is not set in the upload.
        /// </summary>
        [pbr::OriginalName("CUSTOM_KEY_NOT_SET")] CustomKeyNotSet = 29,
        /// <summary>
        /// The customer has not accepted the customer data terms in the conversion
        /// settings page.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ACCEPTED_CUSTOMER_DATA_TERMS")] CustomerNotAcceptedCustomerDataTerms = 30,
        /// <summary>
        /// User attributes cannot be uploaded into a user list.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTES_NOT_APPLICABLE_FOR_CUSTOMER_MATCH_USER_LIST")] AttributesNotApplicableForCustomerMatchUserList = 34,
        /// <summary>
        /// Lifetime value bucket must be a number from 1-10, except for remove
        /// operation where 0 will be accepted.
        /// </summary>
        [pbr::OriginalName("LIFETIME_VALUE_BUCKET_NOT_IN_RANGE")] LifetimeValueBucketNotInRange = 35,
        /// <summary>
        /// Identifiers not supported for Customer Match attributes. User attributes
        /// can only be provided with contact info (email, phone, address) user
        /// identifiers.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_USER_IDENTIFIER_FOR_ATTRIBUTES")] IncompatibleUserIdentifierForAttributes = 36,
        /// <summary>
        /// A time in the future is not allowed.
        /// </summary>
        [pbr::OriginalName("FUTURE_TIME_NOT_ALLOWED")] FutureTimeNotAllowed = 37,
        /// <summary>
        /// Last purchase date time cannot be less than acquisition date time.
        /// </summary>
        [pbr::OriginalName("LAST_PURCHASE_TIME_LESS_THAN_ACQUISITION_TIME")] LastPurchaseTimeLessThanAcquisitionTime = 38,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
