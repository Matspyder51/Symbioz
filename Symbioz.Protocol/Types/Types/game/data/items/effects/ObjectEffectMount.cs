


















// Generated on 06/04/2015 18:45:33
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class ObjectEffectMount : ObjectEffect
{

public const short Id = 179;
public override short TypeId
{
    get { return Id; }
}

public int mountId { get; set; }
public double date { get; set; }
public ushort modelId { get; set; }
        

public ObjectEffectMount()
{
}

public ObjectEffectMount(ushort actionId, int mountId, double date, ushort modelId)
         : base(actionId)
        {
            this.mountId = mountId;
            this.date = date;
            this.modelId = modelId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(mountId);
            writer.WriteDouble(date);
            writer.WriteVarUhShort(modelId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            mountId = reader.ReadInt();
            if (mountId < 0)
                throw new Exception("Forbidden value on mountId = " + mountId + ", it doesn't respect the following condition : mountId < 0");
            date = reader.ReadDouble();
            if ((date < -9.007199254740992E15) || (date > 9.007199254740992E15))
                throw new Exception("Forbidden value on date = " + date + ", it doesn't respect the following condition : (date < -9.007199254740992E15) || (date > 9.007199254740992E15)");
            modelId = reader.ReadVarUhShort();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            

}


}


}