// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/services/mobile_device_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/services/mobile_device_constant_service.proto</summary>
  public static partial class MobileDeviceConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/services/mobile_device_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MobileDeviceConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9zZXJ2aWNlcy9tb2JpbGVfZGV2",
            "aWNlX2NvbnN0YW50X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY3LnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNv",
            "dXJjZXMvbW9iaWxlX2RldmljZV9jb25zdGFudC5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8ibgoeR2V0TW9iaWxlRGV2aWNlQ29uc3RhbnRSZXF1",
            "ZXN0EkwKDXJlc291cmNlX25hbWUYASABKAlCNeBBAvpBLwotZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL01vYmlsZURldmljZUNvbnN0YW50MsACChtNb2Jp",
            "bGVEZXZpY2VDb25zdGFudFNlcnZpY2US2QEKF0dldE1vYmlsZURldmljZUNv",
            "bnN0YW50EkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuc2VydmljZXMuR2V0",
            "TW9iaWxlRGV2aWNlQ29uc3RhbnRSZXF1ZXN0GjcuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjcucmVzb3VyY2VzLk1vYmlsZURldmljZUNvbnN0YW50IkOC0+ST",
            "Ai0SKy92Ny97cmVzb3VyY2VfbmFtZT1tb2JpbGVEZXZpY2VDb25zdGFudHMv",
            "Kn3aQQ1yZXNvdXJjZV9uYW1lGkXKQRhnb29nbGVhZHMuZ29vZ2xlYXBpcy5j",
            "b23SQSdodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Fkd29yZHNC",
            "hwIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5zZXJ2aWNlc0IgTW9i",
            "aWxlRGV2aWNlQ29uc3RhbnRTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y3L3Nl",
            "cnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjcuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWN1xTZXJ2aWNl",
            "c+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY3OjpTZXJ2aWNlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Resources.MobileDeviceConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Services.GetMobileDeviceConstantRequest), global::Google.Ads.GoogleAds.V7.Services.GetMobileDeviceConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [MobileDeviceConstantService.GetMobileDeviceConstant][google.ads.googleads.v7.services.MobileDeviceConstantService.GetMobileDeviceConstant].
  /// </summary>
  public sealed partial class GetMobileDeviceConstantRequest : pb::IMessage<GetMobileDeviceConstantRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMobileDeviceConstantRequest> _parser = new pb::MessageParser<GetMobileDeviceConstantRequest>(() => new GetMobileDeviceConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMobileDeviceConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Services.MobileDeviceConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMobileDeviceConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMobileDeviceConstantRequest(GetMobileDeviceConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMobileDeviceConstantRequest Clone() {
      return new GetMobileDeviceConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the mobile device to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMobileDeviceConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMobileDeviceConstantRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMobileDeviceConstantRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
