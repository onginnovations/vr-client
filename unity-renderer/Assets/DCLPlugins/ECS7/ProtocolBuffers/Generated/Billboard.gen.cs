// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: decentraland/sdk/components/billboard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DCL.ECSComponents {

  /// <summary>Holder for reflection information generated from decentraland/sdk/components/billboard.proto</summary>
  public static partial class BillboardReflection {

    #region Descriptor
    /// <summary>File descriptor for decentraland/sdk/components/billboard.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BillboardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitkZWNlbnRyYWxhbmQvc2RrL2NvbXBvbmVudHMvYmlsbGJvYXJkLnByb3Rv",
            "EhtkZWNlbnRyYWxhbmQuc2RrLmNvbXBvbmVudHMioQEKC1BCQmlsbGJvYXJk",
            "EkcKDmJpbGxib2FyZF9tb2RlGAEgASgOMiouZGVjZW50cmFsYW5kLnNkay5j",
            "b21wb25lbnRzLkJpbGxib2FyZE1vZGVIAIgBARIfChJvcHBvc2l0ZV9kaXJl",
            "Y3Rpb24YAiABKAhIAYgBAUIRCg9fYmlsbGJvYXJkX21vZGVCFQoTX29wcG9z",
            "aXRlX2RpcmVjdGlvbiouCg1CaWxsYm9hcmRNb2RlEg8KC0JNX0FMTF9BWEVT",
            "EAASDAoIQk1fWV9BWEUQAUIUqgIRRENMLkVDU0NvbXBvbmVudHNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::DCL.ECSComponents.BillboardMode), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DCL.ECSComponents.PBBillboard), global::DCL.ECSComponents.PBBillboard.Parser, new[]{ "BillboardMode", "OppositeDirection" }, new[]{ "BillboardMode", "OppositeDirection" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum BillboardMode {
    [pbr::OriginalName("BM_ALL_AXES")] BmAllAxes = 0,
    [pbr::OriginalName("BM_Y_AXE")] BmYAxe = 1,
  }

  #endregion

  #region Messages
  public sealed partial class PBBillboard : pb::IMessage<PBBillboard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PBBillboard> _parser = new pb::MessageParser<PBBillboard>(() => new PBBillboard());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PBBillboard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DCL.ECSComponents.BillboardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PBBillboard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PBBillboard(PBBillboard other) : this() {
      _hasBits0 = other._hasBits0;
      billboardMode_ = other.billboardMode_;
      oppositeDirection_ = other.oppositeDirection_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PBBillboard Clone() {
      return new PBBillboard(this);
    }

    /// <summary>Field number for the "billboard_mode" field.</summary>
    public const int BillboardModeFieldNumber = 1;
    private global::DCL.ECSComponents.BillboardMode billboardMode_;
    /// <summary>
    /// default=BM_ALL_AXES
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::DCL.ECSComponents.BillboardMode BillboardMode {
      get { if ((_hasBits0 & 1) != 0) { return billboardMode_; } else { return global::DCL.ECSComponents.BillboardMode.BmAllAxes; } }
      set {
        _hasBits0 |= 1;
        billboardMode_ = value;
      }
    }
    /// <summary>Gets whether the "billboard_mode" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBillboardMode {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "billboard_mode" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBillboardMode() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "opposite_direction" field.</summary>
    public const int OppositeDirectionFieldNumber = 2;
    private bool oppositeDirection_;
    /// <summary>
    /// default=false
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OppositeDirection {
      get { if ((_hasBits0 & 2) != 0) { return oppositeDirection_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        oppositeDirection_ = value;
      }
    }
    /// <summary>Gets whether the "opposite_direction" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOppositeDirection {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "opposite_direction" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOppositeDirection() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PBBillboard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PBBillboard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BillboardMode != other.BillboardMode) return false;
      if (OppositeDirection != other.OppositeDirection) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasBillboardMode) hash ^= BillboardMode.GetHashCode();
      if (HasOppositeDirection) hash ^= OppositeDirection.GetHashCode();
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
      if (HasBillboardMode) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BillboardMode);
      }
      if (HasOppositeDirection) {
        output.WriteRawTag(16);
        output.WriteBool(OppositeDirection);
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
      if (HasBillboardMode) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BillboardMode);
      }
      if (HasOppositeDirection) {
        output.WriteRawTag(16);
        output.WriteBool(OppositeDirection);
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
      if (HasBillboardMode) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BillboardMode);
      }
      if (HasOppositeDirection) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PBBillboard other) {
      if (other == null) {
        return;
      }
      if (other.HasBillboardMode) {
        BillboardMode = other.BillboardMode;
      }
      if (other.HasOppositeDirection) {
        OppositeDirection = other.OppositeDirection;
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
          case 8: {
            BillboardMode = (global::DCL.ECSComponents.BillboardMode) input.ReadEnum();
            break;
          }
          case 16: {
            OppositeDirection = input.ReadBool();
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
          case 8: {
            BillboardMode = (global::DCL.ECSComponents.BillboardMode) input.ReadEnum();
            break;
          }
          case 16: {
            OppositeDirection = input.ReadBool();
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
