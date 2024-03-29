// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/notebooks/v1/event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Notebooks.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/notebooks/v1/event.proto</summary>
  public static partial class EventReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/notebooks/v1/event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvY2xvdWQvbm90ZWJvb2tzL3YxL2V2ZW50LnByb3RvEhlnb29n",
            "bGUuY2xvdWQubm90ZWJvb2tzLnYxGh9nb29nbGUvcHJvdG9idWYvdGltZXN0",
            "YW1wLnByb3RvIqUBCgVFdmVudBIvCgtyZXBvcnRfdGltZRgBIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASOAoEdHlwZRgCIAEoDjIqLmdvb2ds",
            "ZS5jbG91ZC5ub3RlYm9va3MudjEuRXZlbnQuRXZlbnRUeXBlIjEKCUV2ZW50",
            "VHlwZRIaChZFVkVOVF9UWVBFX1VOU1BFQ0lGSUVEEAASCAoESURMRRABQnEK",
            "HWNvbS5nb29nbGUuY2xvdWQubm90ZWJvb2tzLnYxQgpFdmVudFByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQv",
            "bm90ZWJvb2tzL3YxO25vdGVib29rc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Notebooks.V1.Event), global::Google.Cloud.Notebooks.V1.Event.Parser, new[]{ "ReportTime", "Type" }, null, new[]{ typeof(global::Google.Cloud.Notebooks.V1.Event.Types.EventType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The definition of an Event for a managed / semi-managed notebook instance.
  /// </summary>
  public sealed partial class Event : pb::IMessage<Event>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Event> _parser = new pb::MessageParser<Event>(() => new Event());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Event> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Notebooks.V1.EventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Event() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Event(Event other) : this() {
      reportTime_ = other.reportTime_ != null ? other.reportTime_.Clone() : null;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Event Clone() {
      return new Event(this);
    }

    /// <summary>Field number for the "report_time" field.</summary>
    public const int ReportTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp reportTime_;
    /// <summary>
    /// Event report time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ReportTime {
      get { return reportTime_; }
      set {
        reportTime_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Google.Cloud.Notebooks.V1.Event.Types.EventType type_ = global::Google.Cloud.Notebooks.V1.Event.Types.EventType.Unspecified;
    /// <summary>
    /// Event type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Notebooks.V1.Event.Types.EventType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Event);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Event other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReportTime, other.ReportTime)) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (reportTime_ != null) hash ^= ReportTime.GetHashCode();
      if (Type != global::Google.Cloud.Notebooks.V1.Event.Types.EventType.Unspecified) hash ^= Type.GetHashCode();
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
      if (reportTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ReportTime);
      }
      if (Type != global::Google.Cloud.Notebooks.V1.Event.Types.EventType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
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
      if (reportTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ReportTime);
      }
      if (Type != global::Google.Cloud.Notebooks.V1.Event.Types.EventType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
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
      if (reportTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReportTime);
      }
      if (Type != global::Google.Cloud.Notebooks.V1.Event.Types.EventType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Event other) {
      if (other == null) {
        return;
      }
      if (other.reportTime_ != null) {
        if (reportTime_ == null) {
          ReportTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ReportTime.MergeFrom(other.ReportTime);
      }
      if (other.Type != global::Google.Cloud.Notebooks.V1.Event.Types.EventType.Unspecified) {
        Type = other.Type;
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
            if (reportTime_ == null) {
              ReportTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ReportTime);
            break;
          }
          case 16: {
            Type = (global::Google.Cloud.Notebooks.V1.Event.Types.EventType) input.ReadEnum();
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
            if (reportTime_ == null) {
              ReportTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ReportTime);
            break;
          }
          case 16: {
            Type = (global::Google.Cloud.Notebooks.V1.Event.Types.EventType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Event message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The definition of the even types.
      /// </summary>
      public enum EventType {
        /// <summary>
        /// Event is not specified.
        /// </summary>
        [pbr::OriginalName("EVENT_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The instance / runtime is idle
        /// </summary>
        [pbr::OriginalName("IDLE")] Idle = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
