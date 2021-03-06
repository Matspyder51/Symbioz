


















// Generated on 06/04/2015 18:44:50
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class ExchangeBidHouseBuyResultMessage : Message
{

public const ushort Id = 6272;
public override ushort MessageId
{
    get { return Id; }
}

public uint uid;
        public bool bought;
        

public ExchangeBidHouseBuyResultMessage()
{
}

public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
        {
            this.uid = uid;
            this.bought = bought;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(uid);
            writer.WriteBoolean(bought);
            

}

public override void Deserialize(ICustomDataInput reader)
{

uid = reader.ReadVarUhInt();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            bought = reader.ReadBoolean();
            

}


}


}