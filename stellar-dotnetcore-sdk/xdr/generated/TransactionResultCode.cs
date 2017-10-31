// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  enum TransactionResultCode
//  {
//      txSUCCESS = 0, // all operations succeeded
//  
//      txFAILED = -1, // one of the operations failed (none were applied)
//  
//      txTOO_EARLY = -2,         // ledger closeTime before minTime
//      txTOO_LATE = -3,          // ledger closeTime after maxTime
//      txMISSING_OPERATION = -4, // no operation was specified
//      txBAD_SEQ = -5,           // sequence number does not match source account
//  
//      txBAD_AUTH = -6,             // too few valid signatures / wrong network
//      txINSUFFICIENT_BALANCE = -7, // fee would bring account below reserve
//      txNO_ACCOUNT = -8,           // source account not found
//      txINSUFFICIENT_FEE = -9,     // fee is too small
//      txBAD_AUTH_EXTRA = -10,      // unused signatures attached to transaction
//      txINTERNAL_ERROR = -11       // an unknown error occured
//  };

//  ===========================================================================
public class TransactionResultCode  {
  public enum TransactionResultCodeEnum {
  txSUCCESS = 0,
  txFAILED = -1,
  txTOO_EARLY = -2,
  txTOO_LATE = -3,
  txMISSING_OPERATION = -4,
  txBAD_SEQ = -5,
  txBAD_AUTH = -6,
  txINSUFFICIENT_BALANCE = -7,
  txNO_ACCOUNT = -8,
  txINSUFFICIENT_FEE = -9,
  txBAD_AUTH_EXTRA = -10,
  txINTERNAL_ERROR = -11,
  }
  public TransactionResultCodeEnum InnerValue {get; set;} = default(TransactionResultCodeEnum);

  public static TransactionResultCode Create(TransactionResultCodeEnum v)
  {
    return new TransactionResultCode {
      InnerValue = v
    };
  }

  public static TransactionResultCode Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 0: return Create(TransactionResultCodeEnum.txSUCCESS);
      case -1: return Create(TransactionResultCodeEnum.txFAILED);
      case -2: return Create(TransactionResultCodeEnum.txTOO_EARLY);
      case -3: return Create(TransactionResultCodeEnum.txTOO_LATE);
      case -4: return Create(TransactionResultCodeEnum.txMISSING_OPERATION);
      case -5: return Create(TransactionResultCodeEnum.txBAD_SEQ);
      case -6: return Create(TransactionResultCodeEnum.txBAD_AUTH);
      case -7: return Create(TransactionResultCodeEnum.txINSUFFICIENT_BALANCE);
      case -8: return Create(TransactionResultCodeEnum.txNO_ACCOUNT);
      case -9: return Create(TransactionResultCodeEnum.txINSUFFICIENT_FEE);
      case -10: return Create(TransactionResultCodeEnum.txBAD_AUTH_EXTRA);
      case -11: return Create(TransactionResultCodeEnum.txINTERNAL_ERROR);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(XdrDataOutputStream stream, TransactionResultCode value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}