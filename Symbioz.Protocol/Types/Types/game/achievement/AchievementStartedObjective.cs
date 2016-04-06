


















// Generated on 06/04/2015 18:45:19
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class AchievementStartedObjective : AchievementObjective
{

public const short Id = 402;
public override short TypeId
{
    get { return Id; }
}

public ushort value;
        

public AchievementStartedObjective()
{
}

public AchievementStartedObjective(uint id, ushort maxValue, ushort value)
         : base(id, maxValue)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(value);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            value = reader.ReadVarUhShort();
            if (value < 0)
                throw new Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < 0");
            

}


}


}