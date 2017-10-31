// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  struct ChangeTrustOp
//  {
//      Asset line;
//  
//      // if limit is set to 0, deletes the trust line
//      int64 limit;
//  };

//  ===========================================================================
public class ChangeTrustOp  {
  public ChangeTrustOp () {}
  public Asset Line {get; set;}
  public Int64 Limit {get; set;}

  public static void Encode(XdrDataOutputStream stream, ChangeTrustOp encodedChangeTrustOp) {
    Asset.Encode(stream, encodedChangeTrustOp.Line);
    Int64.Encode(stream, encodedChangeTrustOp.Limit);
  }
  public static ChangeTrustOp Decode(XdrDataInputStream stream) {
    ChangeTrustOp decodedChangeTrustOp = new ChangeTrustOp();
    decodedChangeTrustOp.Line = Asset.Decode(stream);
    decodedChangeTrustOp.Limit = Int64.Decode(stream);
    return decodedChangeTrustOp;
  }
}
}