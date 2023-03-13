// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: watchtower_record.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from watchtower_record.proto</summary>
public static partial class WatchtowerRecordReflection {

  #region Descriptor
  /// <summary>File descriptor for watchtower_record.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WatchtowerRecordReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chd3YXRjaHRvd2VyX3JlY29yZC5wcm90byKRBAoQV2F0Y2h0b3dlclJlY29y",
          "ZBIVCg1taW51dGVfYnVja2V0GAEgASgDEhYKDnVzZXJfcmVmZXJlbmNlGAIg",
          "ASgJEhEKCXN5c3RlbV9pZBgDIAEoAxIYChBhcHBsaWNhdGlvbl9uYW1lGAQg",
          "ASgJEhkKEXJlcXVlc3RfdHlwZV9uYW1lGAUgASgJEhMKC3N0YXR1c19jb2Rl",
          "GAYgASgDEhAKCHJldmlzaW9uGAcgASgDEhEKCWhvc3RfbmFtZRgIIAEoCRIW",
          "Cg50b3RhbF9kdXJhdGlvbhgJIAEoAxIdChV0b3RhbF9zcXVhcmVfZHVyYXRp",
          "b24YCiABKAMSFQoNcmVxdWVzdF9ieXRlcxgLIAEoAxIWCg5yZXNwb25zZV9i",
          "eXRlcxgMIAEoAxITCgtwZ19zZXNzaW9ucxgNIAEoAxIUCgxzcWxfc2Vzc2lv",
          "bnMYDiABKAMSFQoNcGdfc3RhdGVtZW50cxgPIAEoAxIWCg5zcWxfc3RhdGVt",
          "ZW50cxgQIAEoAxIMCgRoaXRzGBEgASgDEhwKFGNhc3NhbmRyYV9zdGF0ZW1l",
          "bnRzGBIgASgDEiEKGWV4dGVybmFsX2FwcGxpY2F0aW9uX25hbWUYEyABKAkS",
          "EwoLcGdfZW50aXRpZXMYFCABKAMSFAoMc3FsX2VudGl0aWVzGBUgASgDEhIK",
          "CmlwX2FkZHJlc3MYFiABKAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WatchtowerRecord), global::WatchtowerRecord.Parser, new[]{ "MinuteBucket", "UserReference", "SystemId", "ApplicationName", "RequestTypeName", "StatusCode", "Revision", "HostName", "TotalDuration", "TotalSquareDuration", "RequestBytes", "ResponseBytes", "PgSessions", "SqlSessions", "PgStatements", "SqlStatements", "Hits", "CassandraStatements", "ExternalApplicationName", "PgEntities", "SqlEntities", "IpAddress" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class WatchtowerRecord : pb::IMessage<WatchtowerRecord>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WatchtowerRecord> _parser = new pb::MessageParser<WatchtowerRecord>(() => new WatchtowerRecord());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WatchtowerRecord> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WatchtowerRecordReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WatchtowerRecord() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WatchtowerRecord(WatchtowerRecord other) : this() {
    minuteBucket_ = other.minuteBucket_;
    userReference_ = other.userReference_;
    systemId_ = other.systemId_;
    applicationName_ = other.applicationName_;
    requestTypeName_ = other.requestTypeName_;
    statusCode_ = other.statusCode_;
    revision_ = other.revision_;
    hostName_ = other.hostName_;
    totalDuration_ = other.totalDuration_;
    totalSquareDuration_ = other.totalSquareDuration_;
    requestBytes_ = other.requestBytes_;
    responseBytes_ = other.responseBytes_;
    pgSessions_ = other.pgSessions_;
    sqlSessions_ = other.sqlSessions_;
    pgStatements_ = other.pgStatements_;
    sqlStatements_ = other.sqlStatements_;
    hits_ = other.hits_;
    cassandraStatements_ = other.cassandraStatements_;
    externalApplicationName_ = other.externalApplicationName_;
    pgEntities_ = other.pgEntities_;
    sqlEntities_ = other.sqlEntities_;
    ipAddress_ = other.ipAddress_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WatchtowerRecord Clone() {
    return new WatchtowerRecord(this);
  }

  /// <summary>Field number for the "minute_bucket" field.</summary>
  public const int MinuteBucketFieldNumber = 1;
  private long minuteBucket_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long MinuteBucket {
    get { return minuteBucket_; }
    set {
      minuteBucket_ = value;
    }
  }

  /// <summary>Field number for the "user_reference" field.</summary>
  public const int UserReferenceFieldNumber = 2;
  private string userReference_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string UserReference {
    get { return userReference_; }
    set {
      userReference_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "system_id" field.</summary>
  public const int SystemIdFieldNumber = 3;
  private long systemId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long SystemId {
    get { return systemId_; }
    set {
      systemId_ = value;
    }
  }

  /// <summary>Field number for the "application_name" field.</summary>
  public const int ApplicationNameFieldNumber = 4;
  private string applicationName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ApplicationName {
    get { return applicationName_; }
    set {
      applicationName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "request_type_name" field.</summary>
  public const int RequestTypeNameFieldNumber = 5;
  private string requestTypeName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string RequestTypeName {
    get { return requestTypeName_; }
    set {
      requestTypeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "status_code" field.</summary>
  public const int StatusCodeFieldNumber = 6;
  private long statusCode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long StatusCode {
    get { return statusCode_; }
    set {
      statusCode_ = value;
    }
  }

  /// <summary>Field number for the "revision" field.</summary>
  public const int RevisionFieldNumber = 7;
  private long revision_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Revision {
    get { return revision_; }
    set {
      revision_ = value;
    }
  }

  /// <summary>Field number for the "host_name" field.</summary>
  public const int HostNameFieldNumber = 8;
  private string hostName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string HostName {
    get { return hostName_; }
    set {
      hostName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "total_duration" field.</summary>
  public const int TotalDurationFieldNumber = 9;
  private long totalDuration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long TotalDuration {
    get { return totalDuration_; }
    set {
      totalDuration_ = value;
    }
  }

  /// <summary>Field number for the "total_square_duration" field.</summary>
  public const int TotalSquareDurationFieldNumber = 10;
  private long totalSquareDuration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long TotalSquareDuration {
    get { return totalSquareDuration_; }
    set {
      totalSquareDuration_ = value;
    }
  }

  /// <summary>Field number for the "request_bytes" field.</summary>
  public const int RequestBytesFieldNumber = 11;
  private long requestBytes_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long RequestBytes {
    get { return requestBytes_; }
    set {
      requestBytes_ = value;
    }
  }

  /// <summary>Field number for the "response_bytes" field.</summary>
  public const int ResponseBytesFieldNumber = 12;
  private long responseBytes_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long ResponseBytes {
    get { return responseBytes_; }
    set {
      responseBytes_ = value;
    }
  }

  /// <summary>Field number for the "pg_sessions" field.</summary>
  public const int PgSessionsFieldNumber = 13;
  private long pgSessions_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long PgSessions {
    get { return pgSessions_; }
    set {
      pgSessions_ = value;
    }
  }

  /// <summary>Field number for the "sql_sessions" field.</summary>
  public const int SqlSessionsFieldNumber = 14;
  private long sqlSessions_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long SqlSessions {
    get { return sqlSessions_; }
    set {
      sqlSessions_ = value;
    }
  }

  /// <summary>Field number for the "pg_statements" field.</summary>
  public const int PgStatementsFieldNumber = 15;
  private long pgStatements_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long PgStatements {
    get { return pgStatements_; }
    set {
      pgStatements_ = value;
    }
  }

  /// <summary>Field number for the "sql_statements" field.</summary>
  public const int SqlStatementsFieldNumber = 16;
  private long sqlStatements_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long SqlStatements {
    get { return sqlStatements_; }
    set {
      sqlStatements_ = value;
    }
  }

  /// <summary>Field number for the "hits" field.</summary>
  public const int HitsFieldNumber = 17;
  private long hits_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Hits {
    get { return hits_; }
    set {
      hits_ = value;
    }
  }

  /// <summary>Field number for the "cassandra_statements" field.</summary>
  public const int CassandraStatementsFieldNumber = 18;
  private long cassandraStatements_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long CassandraStatements {
    get { return cassandraStatements_; }
    set {
      cassandraStatements_ = value;
    }
  }

  /// <summary>Field number for the "external_application_name" field.</summary>
  public const int ExternalApplicationNameFieldNumber = 19;
  private string externalApplicationName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ExternalApplicationName {
    get { return externalApplicationName_; }
    set {
      externalApplicationName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "pg_entities" field.</summary>
  public const int PgEntitiesFieldNumber = 20;
  private long pgEntities_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long PgEntities {
    get { return pgEntities_; }
    set {
      pgEntities_ = value;
    }
  }

  /// <summary>Field number for the "sql_entities" field.</summary>
  public const int SqlEntitiesFieldNumber = 21;
  private long sqlEntities_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long SqlEntities {
    get { return sqlEntities_; }
    set {
      sqlEntities_ = value;
    }
  }

  /// <summary>Field number for the "ip_address" field.</summary>
  public const int IpAddressFieldNumber = 22;
  private string ipAddress_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string IpAddress {
    get { return ipAddress_; }
    set {
      ipAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WatchtowerRecord);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WatchtowerRecord other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MinuteBucket != other.MinuteBucket) return false;
    if (UserReference != other.UserReference) return false;
    if (SystemId != other.SystemId) return false;
    if (ApplicationName != other.ApplicationName) return false;
    if (RequestTypeName != other.RequestTypeName) return false;
    if (StatusCode != other.StatusCode) return false;
    if (Revision != other.Revision) return false;
    if (HostName != other.HostName) return false;
    if (TotalDuration != other.TotalDuration) return false;
    if (TotalSquareDuration != other.TotalSquareDuration) return false;
    if (RequestBytes != other.RequestBytes) return false;
    if (ResponseBytes != other.ResponseBytes) return false;
    if (PgSessions != other.PgSessions) return false;
    if (SqlSessions != other.SqlSessions) return false;
    if (PgStatements != other.PgStatements) return false;
    if (SqlStatements != other.SqlStatements) return false;
    if (Hits != other.Hits) return false;
    if (CassandraStatements != other.CassandraStatements) return false;
    if (ExternalApplicationName != other.ExternalApplicationName) return false;
    if (PgEntities != other.PgEntities) return false;
    if (SqlEntities != other.SqlEntities) return false;
    if (IpAddress != other.IpAddress) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (MinuteBucket != 0L) hash ^= MinuteBucket.GetHashCode();
    if (UserReference.Length != 0) hash ^= UserReference.GetHashCode();
    if (SystemId != 0L) hash ^= SystemId.GetHashCode();
    if (ApplicationName.Length != 0) hash ^= ApplicationName.GetHashCode();
    if (RequestTypeName.Length != 0) hash ^= RequestTypeName.GetHashCode();
    if (StatusCode != 0L) hash ^= StatusCode.GetHashCode();
    if (Revision != 0L) hash ^= Revision.GetHashCode();
    if (HostName.Length != 0) hash ^= HostName.GetHashCode();
    if (TotalDuration != 0L) hash ^= TotalDuration.GetHashCode();
    if (TotalSquareDuration != 0L) hash ^= TotalSquareDuration.GetHashCode();
    if (RequestBytes != 0L) hash ^= RequestBytes.GetHashCode();
    if (ResponseBytes != 0L) hash ^= ResponseBytes.GetHashCode();
    if (PgSessions != 0L) hash ^= PgSessions.GetHashCode();
    if (SqlSessions != 0L) hash ^= SqlSessions.GetHashCode();
    if (PgStatements != 0L) hash ^= PgStatements.GetHashCode();
    if (SqlStatements != 0L) hash ^= SqlStatements.GetHashCode();
    if (Hits != 0L) hash ^= Hits.GetHashCode();
    if (CassandraStatements != 0L) hash ^= CassandraStatements.GetHashCode();
    if (ExternalApplicationName.Length != 0) hash ^= ExternalApplicationName.GetHashCode();
    if (PgEntities != 0L) hash ^= PgEntities.GetHashCode();
    if (SqlEntities != 0L) hash ^= SqlEntities.GetHashCode();
    if (IpAddress.Length != 0) hash ^= IpAddress.GetHashCode();
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
    if (MinuteBucket != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(MinuteBucket);
    }
    if (UserReference.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(UserReference);
    }
    if (SystemId != 0L) {
      output.WriteRawTag(24);
      output.WriteInt64(SystemId);
    }
    if (ApplicationName.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(ApplicationName);
    }
    if (RequestTypeName.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(RequestTypeName);
    }
    if (StatusCode != 0L) {
      output.WriteRawTag(48);
      output.WriteInt64(StatusCode);
    }
    if (Revision != 0L) {
      output.WriteRawTag(56);
      output.WriteInt64(Revision);
    }
    if (HostName.Length != 0) {
      output.WriteRawTag(66);
      output.WriteString(HostName);
    }
    if (TotalDuration != 0L) {
      output.WriteRawTag(72);
      output.WriteInt64(TotalDuration);
    }
    if (TotalSquareDuration != 0L) {
      output.WriteRawTag(80);
      output.WriteInt64(TotalSquareDuration);
    }
    if (RequestBytes != 0L) {
      output.WriteRawTag(88);
      output.WriteInt64(RequestBytes);
    }
    if (ResponseBytes != 0L) {
      output.WriteRawTag(96);
      output.WriteInt64(ResponseBytes);
    }
    if (PgSessions != 0L) {
      output.WriteRawTag(104);
      output.WriteInt64(PgSessions);
    }
    if (SqlSessions != 0L) {
      output.WriteRawTag(112);
      output.WriteInt64(SqlSessions);
    }
    if (PgStatements != 0L) {
      output.WriteRawTag(120);
      output.WriteInt64(PgStatements);
    }
    if (SqlStatements != 0L) {
      output.WriteRawTag(128, 1);
      output.WriteInt64(SqlStatements);
    }
    if (Hits != 0L) {
      output.WriteRawTag(136, 1);
      output.WriteInt64(Hits);
    }
    if (CassandraStatements != 0L) {
      output.WriteRawTag(144, 1);
      output.WriteInt64(CassandraStatements);
    }
    if (ExternalApplicationName.Length != 0) {
      output.WriteRawTag(154, 1);
      output.WriteString(ExternalApplicationName);
    }
    if (PgEntities != 0L) {
      output.WriteRawTag(160, 1);
      output.WriteInt64(PgEntities);
    }
    if (SqlEntities != 0L) {
      output.WriteRawTag(168, 1);
      output.WriteInt64(SqlEntities);
    }
    if (IpAddress.Length != 0) {
      output.WriteRawTag(178, 1);
      output.WriteString(IpAddress);
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
    if (MinuteBucket != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(MinuteBucket);
    }
    if (UserReference.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(UserReference);
    }
    if (SystemId != 0L) {
      output.WriteRawTag(24);
      output.WriteInt64(SystemId);
    }
    if (ApplicationName.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(ApplicationName);
    }
    if (RequestTypeName.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(RequestTypeName);
    }
    if (StatusCode != 0L) {
      output.WriteRawTag(48);
      output.WriteInt64(StatusCode);
    }
    if (Revision != 0L) {
      output.WriteRawTag(56);
      output.WriteInt64(Revision);
    }
    if (HostName.Length != 0) {
      output.WriteRawTag(66);
      output.WriteString(HostName);
    }
    if (TotalDuration != 0L) {
      output.WriteRawTag(72);
      output.WriteInt64(TotalDuration);
    }
    if (TotalSquareDuration != 0L) {
      output.WriteRawTag(80);
      output.WriteInt64(TotalSquareDuration);
    }
    if (RequestBytes != 0L) {
      output.WriteRawTag(88);
      output.WriteInt64(RequestBytes);
    }
    if (ResponseBytes != 0L) {
      output.WriteRawTag(96);
      output.WriteInt64(ResponseBytes);
    }
    if (PgSessions != 0L) {
      output.WriteRawTag(104);
      output.WriteInt64(PgSessions);
    }
    if (SqlSessions != 0L) {
      output.WriteRawTag(112);
      output.WriteInt64(SqlSessions);
    }
    if (PgStatements != 0L) {
      output.WriteRawTag(120);
      output.WriteInt64(PgStatements);
    }
    if (SqlStatements != 0L) {
      output.WriteRawTag(128, 1);
      output.WriteInt64(SqlStatements);
    }
    if (Hits != 0L) {
      output.WriteRawTag(136, 1);
      output.WriteInt64(Hits);
    }
    if (CassandraStatements != 0L) {
      output.WriteRawTag(144, 1);
      output.WriteInt64(CassandraStatements);
    }
    if (ExternalApplicationName.Length != 0) {
      output.WriteRawTag(154, 1);
      output.WriteString(ExternalApplicationName);
    }
    if (PgEntities != 0L) {
      output.WriteRawTag(160, 1);
      output.WriteInt64(PgEntities);
    }
    if (SqlEntities != 0L) {
      output.WriteRawTag(168, 1);
      output.WriteInt64(SqlEntities);
    }
    if (IpAddress.Length != 0) {
      output.WriteRawTag(178, 1);
      output.WriteString(IpAddress);
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
    if (MinuteBucket != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(MinuteBucket);
    }
    if (UserReference.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(UserReference);
    }
    if (SystemId != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(SystemId);
    }
    if (ApplicationName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ApplicationName);
    }
    if (RequestTypeName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestTypeName);
    }
    if (StatusCode != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(StatusCode);
    }
    if (Revision != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Revision);
    }
    if (HostName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(HostName);
    }
    if (TotalDuration != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(TotalDuration);
    }
    if (TotalSquareDuration != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(TotalSquareDuration);
    }
    if (RequestBytes != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(RequestBytes);
    }
    if (ResponseBytes != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(ResponseBytes);
    }
    if (PgSessions != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(PgSessions);
    }
    if (SqlSessions != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(SqlSessions);
    }
    if (PgStatements != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(PgStatements);
    }
    if (SqlStatements != 0L) {
      size += 2 + pb::CodedOutputStream.ComputeInt64Size(SqlStatements);
    }
    if (Hits != 0L) {
      size += 2 + pb::CodedOutputStream.ComputeInt64Size(Hits);
    }
    if (CassandraStatements != 0L) {
      size += 2 + pb::CodedOutputStream.ComputeInt64Size(CassandraStatements);
    }
    if (ExternalApplicationName.Length != 0) {
      size += 2 + pb::CodedOutputStream.ComputeStringSize(ExternalApplicationName);
    }
    if (PgEntities != 0L) {
      size += 2 + pb::CodedOutputStream.ComputeInt64Size(PgEntities);
    }
    if (SqlEntities != 0L) {
      size += 2 + pb::CodedOutputStream.ComputeInt64Size(SqlEntities);
    }
    if (IpAddress.Length != 0) {
      size += 2 + pb::CodedOutputStream.ComputeStringSize(IpAddress);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WatchtowerRecord other) {
    if (other == null) {
      return;
    }
    if (other.MinuteBucket != 0L) {
      MinuteBucket = other.MinuteBucket;
    }
    if (other.UserReference.Length != 0) {
      UserReference = other.UserReference;
    }
    if (other.SystemId != 0L) {
      SystemId = other.SystemId;
    }
    if (other.ApplicationName.Length != 0) {
      ApplicationName = other.ApplicationName;
    }
    if (other.RequestTypeName.Length != 0) {
      RequestTypeName = other.RequestTypeName;
    }
    if (other.StatusCode != 0L) {
      StatusCode = other.StatusCode;
    }
    if (other.Revision != 0L) {
      Revision = other.Revision;
    }
    if (other.HostName.Length != 0) {
      HostName = other.HostName;
    }
    if (other.TotalDuration != 0L) {
      TotalDuration = other.TotalDuration;
    }
    if (other.TotalSquareDuration != 0L) {
      TotalSquareDuration = other.TotalSquareDuration;
    }
    if (other.RequestBytes != 0L) {
      RequestBytes = other.RequestBytes;
    }
    if (other.ResponseBytes != 0L) {
      ResponseBytes = other.ResponseBytes;
    }
    if (other.PgSessions != 0L) {
      PgSessions = other.PgSessions;
    }
    if (other.SqlSessions != 0L) {
      SqlSessions = other.SqlSessions;
    }
    if (other.PgStatements != 0L) {
      PgStatements = other.PgStatements;
    }
    if (other.SqlStatements != 0L) {
      SqlStatements = other.SqlStatements;
    }
    if (other.Hits != 0L) {
      Hits = other.Hits;
    }
    if (other.CassandraStatements != 0L) {
      CassandraStatements = other.CassandraStatements;
    }
    if (other.ExternalApplicationName.Length != 0) {
      ExternalApplicationName = other.ExternalApplicationName;
    }
    if (other.PgEntities != 0L) {
      PgEntities = other.PgEntities;
    }
    if (other.SqlEntities != 0L) {
      SqlEntities = other.SqlEntities;
    }
    if (other.IpAddress.Length != 0) {
      IpAddress = other.IpAddress;
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
          MinuteBucket = input.ReadInt64();
          break;
        }
        case 18: {
          UserReference = input.ReadString();
          break;
        }
        case 24: {
          SystemId = input.ReadInt64();
          break;
        }
        case 34: {
          ApplicationName = input.ReadString();
          break;
        }
        case 42: {
          RequestTypeName = input.ReadString();
          break;
        }
        case 48: {
          StatusCode = input.ReadInt64();
          break;
        }
        case 56: {
          Revision = input.ReadInt64();
          break;
        }
        case 66: {
          HostName = input.ReadString();
          break;
        }
        case 72: {
          TotalDuration = input.ReadInt64();
          break;
        }
        case 80: {
          TotalSquareDuration = input.ReadInt64();
          break;
        }
        case 88: {
          RequestBytes = input.ReadInt64();
          break;
        }
        case 96: {
          ResponseBytes = input.ReadInt64();
          break;
        }
        case 104: {
          PgSessions = input.ReadInt64();
          break;
        }
        case 112: {
          SqlSessions = input.ReadInt64();
          break;
        }
        case 120: {
          PgStatements = input.ReadInt64();
          break;
        }
        case 128: {
          SqlStatements = input.ReadInt64();
          break;
        }
        case 136: {
          Hits = input.ReadInt64();
          break;
        }
        case 144: {
          CassandraStatements = input.ReadInt64();
          break;
        }
        case 154: {
          ExternalApplicationName = input.ReadString();
          break;
        }
        case 160: {
          PgEntities = input.ReadInt64();
          break;
        }
        case 168: {
          SqlEntities = input.ReadInt64();
          break;
        }
        case 178: {
          IpAddress = input.ReadString();
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
          MinuteBucket = input.ReadInt64();
          break;
        }
        case 18: {
          UserReference = input.ReadString();
          break;
        }
        case 24: {
          SystemId = input.ReadInt64();
          break;
        }
        case 34: {
          ApplicationName = input.ReadString();
          break;
        }
        case 42: {
          RequestTypeName = input.ReadString();
          break;
        }
        case 48: {
          StatusCode = input.ReadInt64();
          break;
        }
        case 56: {
          Revision = input.ReadInt64();
          break;
        }
        case 66: {
          HostName = input.ReadString();
          break;
        }
        case 72: {
          TotalDuration = input.ReadInt64();
          break;
        }
        case 80: {
          TotalSquareDuration = input.ReadInt64();
          break;
        }
        case 88: {
          RequestBytes = input.ReadInt64();
          break;
        }
        case 96: {
          ResponseBytes = input.ReadInt64();
          break;
        }
        case 104: {
          PgSessions = input.ReadInt64();
          break;
        }
        case 112: {
          SqlSessions = input.ReadInt64();
          break;
        }
        case 120: {
          PgStatements = input.ReadInt64();
          break;
        }
        case 128: {
          SqlStatements = input.ReadInt64();
          break;
        }
        case 136: {
          Hits = input.ReadInt64();
          break;
        }
        case 144: {
          CassandraStatements = input.ReadInt64();
          break;
        }
        case 154: {
          ExternalApplicationName = input.ReadString();
          break;
        }
        case 160: {
          PgEntities = input.ReadInt64();
          break;
        }
        case 168: {
          SqlEntities = input.ReadInt64();
          break;
        }
        case 178: {
          IpAddress = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
