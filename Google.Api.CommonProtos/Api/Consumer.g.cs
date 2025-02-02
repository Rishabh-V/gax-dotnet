/*
 * Copyright 2021 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/consumer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/consumer.proto</summary>
  public static partial class ConsumerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/consumer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConsumerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlnb29nbGUvYXBpL2NvbnN1bWVyLnByb3RvEgpnb29nbGUuYXBpIj0KEVBy",
            "b2plY3RQcm9wZXJ0aWVzEigKCnByb3BlcnRpZXMYASADKAsyFC5nb29nbGUu",
            "YXBpLlByb3BlcnR5IqwBCghQcm9wZXJ0eRIMCgRuYW1lGAEgASgJEi8KBHR5",
            "cGUYAiABKA4yIS5nb29nbGUuYXBpLlByb3BlcnR5LlByb3BlcnR5VHlwZRIT",
            "CgtkZXNjcmlwdGlvbhgDIAEoCSJMCgxQcm9wZXJ0eVR5cGUSDwoLVU5TUEVD",
            "SUZJRUQQABIJCgVJTlQ2NBABEggKBEJPT0wQAhIKCgZTVFJJTkcQAxIKCgZE",
            "T1VCTEUQBEJoCg5jb20uZ29vZ2xlLmFwaUINQ29uc3VtZXJQcm90b1ABWkVn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2FwaS9zZXJ2",
            "aWNlY29uZmlnO3NlcnZpY2Vjb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.ProjectProperties), global::Google.Api.ProjectProperties.Parser, new[]{ "Properties" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Property), global::Google.Api.Property.Parser, new[]{ "Name", "Type", "Description" }, null, new[]{ typeof(global::Google.Api.Property.Types.PropertyType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A descriptor for defining project properties for a service. One service may
  /// have many consumer projects, and the service may want to behave differently
  /// depending on some properties on the project. For example, a project may be
  /// associated with a school, or a business, or a government agency, a business
  /// type property on the project may affect how a service responds to the client.
  /// This descriptor defines which properties are allowed to be set on a project.
  ///
  /// Example:
  ///
  ///    project_properties:
  ///      properties:
  ///      - name: NO_WATERMARK
  ///        type: BOOL
  ///        description: Allows usage of the API without watermarks.
  ///      - name: EXTENDED_TILE_CACHE_PERIOD
  ///        type: INT64
  /// </summary>
  public sealed partial class ProjectProperties : pb::IMessage<ProjectProperties>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProjectProperties> _parser = new pb::MessageParser<ProjectProperties>(() => new ProjectProperties());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProjectProperties> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ConsumerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectProperties() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectProperties(ProjectProperties other) : this() {
      properties_ = other.properties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectProperties Clone() {
      return new ProjectProperties(this);
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Api.Property> _repeated_properties_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Api.Property.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.Property> properties_ = new pbc::RepeatedField<global::Google.Api.Property>();
    /// <summary>
    /// List of per consumer project-specific properties.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Api.Property> Properties {
      get { return properties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProjectProperties);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProjectProperties other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!properties_.Equals(other.properties_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= properties_.GetHashCode();
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
      properties_.WriteTo(output, _repeated_properties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      properties_.WriteTo(ref output, _repeated_properties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += properties_.CalculateSize(_repeated_properties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProjectProperties other) {
      if (other == null) {
        return;
      }
      properties_.Add(other.properties_);
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
            properties_.AddEntriesFrom(input, _repeated_properties_codec);
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
            properties_.AddEntriesFrom(ref input, _repeated_properties_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Defines project properties.
  ///
  /// API services can define properties that can be assigned to consumer projects
  /// so that backends can perform response customization without having to make
  /// additional calls or maintain additional storage. For example, Maps API
  /// defines properties that controls map tile cache period, or whether to embed a
  /// watermark in a result.
  ///
  /// These values can be set via API producer console. Only API providers can
  /// define and set these properties.
  /// </summary>
  public sealed partial class Property : pb::IMessage<Property>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Property> _parser = new pb::MessageParser<Property>(() => new Property());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Property> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ConsumerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Property() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Property(Property other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Property Clone() {
      return new Property(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the property (a.k.a key).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Google.Api.Property.Types.PropertyType type_ = global::Google.Api.Property.Types.PropertyType.Unspecified;
    /// <summary>
    /// The type of this property.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Api.Property.Types.PropertyType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// The description of the property
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Property);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Property other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != global::Google.Api.Property.Types.PropertyType.Unspecified) hash ^= Type.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != global::Google.Api.Property.Types.PropertyType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != global::Google.Api.Property.Types.PropertyType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != global::Google.Api.Property.Types.PropertyType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Property other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != global::Google.Api.Property.Types.PropertyType.Unspecified) {
        Type = other.Type;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Google.Api.Property.Types.PropertyType) input.ReadEnum();
            break;
          }
          case 26: {
            Description = input.ReadString();
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Google.Api.Property.Types.PropertyType) input.ReadEnum();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Property message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Supported data type of the property values
      /// </summary>
      public enum PropertyType {
        /// <summary>
        /// The type is unspecified, and will result in an error.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The type is `int64`.
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 1,
        /// <summary>
        /// The type is `bool`.
        /// </summary>
        [pbr::OriginalName("BOOL")] Bool = 2,
        /// <summary>
        /// The type is `string`.
        /// </summary>
        [pbr::OriginalName("STRING")] String = 3,
        /// <summary>
        /// The type is 'double'.
        /// </summary>
        [pbr::OriginalName("DOUBLE")] Double = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
