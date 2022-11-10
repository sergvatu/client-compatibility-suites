/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Hazelcast.Testing.Remote
{

  public partial class Response : TBase
  {
    private bool _success;
    private string _message;
    private byte[] _result;

    public bool Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }

    public string Message
    {
      get
      {
        return _message;
      }
      set
      {
        __isset.message = true;
        this._message = value;
      }
    }

    public byte[] Result
    {
      get
      {
        return _result;
      }
      set
      {
        __isset.result = true;
        this._result = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool success;
      public bool message;
      public bool result;
    }

    public Response()
    {
    }

    public Response DeepCopy()
    {
      var tmp15 = new Response();
      if(__isset.success)
      {
        tmp15.Success = this.Success;
      }
      tmp15.__isset.success = this.__isset.success;
      if((Message != null) && __isset.message)
      {
        tmp15.Message = this.Message;
      }
      tmp15.__isset.message = this.__isset.message;
      if((Result != null) && __isset.result)
      {
        tmp15.Result = this.Result.ToArray();
      }
      tmp15.__isset.result = this.__isset.result;
      return tmp15;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Bool)
              {
                Success = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Message = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Result = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp16 = new TStruct("Response");
        await oprot.WriteStructBeginAsync(tmp16, cancellationToken);
        var tmp17 = new TField();
        if(__isset.success)
        {
          tmp17.Name = "success";
          tmp17.Type = TType.Bool;
          tmp17.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp17, cancellationToken);
          await oprot.WriteBoolAsync(Success, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Message != null) && __isset.message)
        {
          tmp17.Name = "message";
          tmp17.Type = TType.String;
          tmp17.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp17, cancellationToken);
          await oprot.WriteStringAsync(Message, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Result != null) && __isset.result)
        {
          tmp17.Name = "result";
          tmp17.Type = TType.String;
          tmp17.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp17, cancellationToken);
          await oprot.WriteBinaryAsync(Result, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is Response other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.success == other.__isset.success) && ((!__isset.success) || (System.Object.Equals(Success, other.Success))))
        && ((__isset.message == other.__isset.message) && ((!__isset.message) || (System.Object.Equals(Message, other.Message))))
        && ((__isset.result == other.__isset.result) && ((!__isset.result) || (TCollections.Equals(Result, other.Result))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.success)
        {
          hashcode = (hashcode * 397) + Success.GetHashCode();
        }
        if((Message != null) && __isset.message)
        {
          hashcode = (hashcode * 397) + Message.GetHashCode();
        }
        if((Result != null) && __isset.result)
        {
          hashcode = (hashcode * 397) + Result.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp18 = new StringBuilder("Response(");
      int tmp19 = 0;
      if(__isset.success)
      {
        if(0 < tmp19++) { tmp18.Append(", "); }
        tmp18.Append("Success: ");
        Success.ToString(tmp18);
      }
      if((Message != null) && __isset.message)
      {
        if(0 < tmp19++) { tmp18.Append(", "); }
        tmp18.Append("Message: ");
        Message.ToString(tmp18);
      }
      if((Result != null) && __isset.result)
      {
        if(0 < tmp19++) { tmp18.Append(", "); }
        tmp18.Append("Result: ");
        Result.ToString(tmp18);
      }
      tmp18.Append(')');
      return tmp18.ToString();
    }
  }

}