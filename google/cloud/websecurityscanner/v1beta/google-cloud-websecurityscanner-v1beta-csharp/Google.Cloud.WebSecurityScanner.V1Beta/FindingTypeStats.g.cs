// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/websecurityscanner/v1beta/finding_type_stats.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.WebSecurityScanner.V1Beta {

  /// <summary>Holder for reflection information generated from google/cloud/websecurityscanner/v1beta/finding_type_stats.proto</summary>
  public static partial class FindingTypeStatsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/websecurityscanner/v1beta/finding_type_stats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FindingTypeStatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3YxYmV0YS9maW5k",
            "aW5nX3R5cGVfc3RhdHMucHJvdG8SJmdvb2dsZS5jbG91ZC53ZWJzZWN1cml0",
            "eXNjYW5uZXIudjFiZXRhIj8KEEZpbmRpbmdUeXBlU3RhdHMSFAoMZmluZGlu",
            "Z190eXBlGAEgASgJEhUKDWZpbmRpbmdfY291bnQYAiABKAVCnQIKKmNvbS5n",
            "b29nbGUuY2xvdWQud2Vic2VjdXJpdHlzY2FubmVyLnYxYmV0YUIVRmluZGlu",
            "Z1R5cGVTdGF0c1Byb3RvUAFaWGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3YxYmV0YTt3",
            "ZWJzZWN1cml0eXNjYW5uZXKqAiZHb29nbGUuQ2xvdWQuV2ViU2VjdXJpdHlT",
            "Y2FubmVyLlYxQmV0YcoCJkdvb2dsZVxDbG91ZFxXZWJTZWN1cml0eVNjYW5u",
            "ZXJcVjFiZXRh6gIpR29vZ2xlOjpDbG91ZDo6V2ViU2VjdXJpdHlTY2FubmVy",
            "OjpWMWJldGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.WebSecurityScanner.V1Beta.FindingTypeStats), global::Google.Cloud.WebSecurityScanner.V1Beta.FindingTypeStats.Parser, new[]{ "FindingType", "FindingCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A FindingTypeStats resource represents stats regarding a specific FindingType
  /// of Findings under a given ScanRun.
  /// </summary>
  public sealed partial class FindingTypeStats : pb::IMessage<FindingTypeStats>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FindingTypeStats> _parser = new pb::MessageParser<FindingTypeStats>(() => new FindingTypeStats());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FindingTypeStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.WebSecurityScanner.V1Beta.FindingTypeStatsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FindingTypeStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FindingTypeStats(FindingTypeStats other) : this() {
      findingType_ = other.findingType_;
      findingCount_ = other.findingCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FindingTypeStats Clone() {
      return new FindingTypeStats(this);
    }

    /// <summary>Field number for the "finding_type" field.</summary>
    public const int FindingTypeFieldNumber = 1;
    private string findingType_ = "";
    /// <summary>
    /// The finding type associated with the stats.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FindingType {
      get { return findingType_; }
      set {
        findingType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "finding_count" field.</summary>
    public const int FindingCountFieldNumber = 2;
    private int findingCount_;
    /// <summary>
    /// The count of findings belonging to this finding type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FindingCount {
      get { return findingCount_; }
      set {
        findingCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FindingTypeStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FindingTypeStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FindingType != other.FindingType) return false;
      if (FindingCount != other.FindingCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FindingType.Length != 0) hash ^= FindingType.GetHashCode();
      if (FindingCount != 0) hash ^= FindingCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (FindingType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FindingType);
      }
      if (FindingCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(FindingCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FindingType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FindingType);
      }
      if (FindingCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(FindingCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FindingType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FindingType);
      }
      if (FindingCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FindingCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FindingTypeStats other) {
      if (other == null) {
        return;
      }
      if (other.FindingType.Length != 0) {
        FindingType = other.FindingType;
      }
      if (other.FindingCount != 0) {
        FindingCount = other.FindingCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            FindingType = input.ReadString();
            break;
          }
          case 16: {
            FindingCount = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            FindingType = input.ReadString();
            break;
          }
          case 16: {
            FindingCount = input.ReadInt32();
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
