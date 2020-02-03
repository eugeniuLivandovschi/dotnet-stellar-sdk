// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  struct SurveyResponseMessage
    //  {
    //      NodeID surveyorPeerID;
    //      NodeID surveyedPeerID;
    //      uint32 ledgerNum;
    //      SurveyMessageCommandType commandType;
    //      EncryptedBody encryptedBody;
    //  };
    //  ===========================================================================
    public class SurveyResponseMessage
    {
        public SurveyResponseMessage() { }
        public NodeID SurveyorPeerID { get; set; }
        public NodeID SurveyedPeerID { get; set; }
        public Uint32 LedgerNum { get; set; }
        public SurveyMessageCommandType CommandType { get; set; }
        public EncryptedBody EncryptedBody { get; set; }

        public static void Encode(XdrDataOutputStream stream, SurveyResponseMessage encodedSurveyResponseMessage)
        {
            NodeID.Encode(stream, encodedSurveyResponseMessage.SurveyorPeerID);
            NodeID.Encode(stream, encodedSurveyResponseMessage.SurveyedPeerID);
            Uint32.Encode(stream, encodedSurveyResponseMessage.LedgerNum);
            SurveyMessageCommandType.Encode(stream, encodedSurveyResponseMessage.CommandType);
            EncryptedBody.Encode(stream, encodedSurveyResponseMessage.EncryptedBody);
        }
        public static SurveyResponseMessage Decode(XdrDataInputStream stream)
        {
            SurveyResponseMessage decodedSurveyResponseMessage = new SurveyResponseMessage();
            decodedSurveyResponseMessage.SurveyorPeerID = NodeID.Decode(stream);
            decodedSurveyResponseMessage.SurveyedPeerID = NodeID.Decode(stream);
            decodedSurveyResponseMessage.LedgerNum = Uint32.Decode(stream);
            decodedSurveyResponseMessage.CommandType = SurveyMessageCommandType.Decode(stream);
            decodedSurveyResponseMessage.EncryptedBody = EncryptedBody.Decode(stream);
            return decodedSurveyResponseMessage;
        }
    }
}
