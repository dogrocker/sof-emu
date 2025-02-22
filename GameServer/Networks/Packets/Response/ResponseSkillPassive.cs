﻿using System.IO;

namespace GameServer.Networks.Packets.Response
{
    public class ResponseSkillPassive : ASendPacket
    {
        //protected List<PasssiveSkill> PasssiveSkills;
        public ResponseSkillPassive(/*List<PasssiveSkill> passsiveSkills*/)
        {
            //PasssiveSkills = passsiveSkills;
        }

        public override void Write(BinaryWriter writer)
        {
            WriteH(writer, 43940);
            WriteH(writer, 10);
            WriteD(writer, 0);
            WriteD(writer, 0);
            WriteH(writer, 0);
            for (int slot = 0; slot < 15; slot++)
            {
                if (slot < 12)
                {
                    //KeyValuePair<int, int> ability;
                    //if (Player.Abilities.TryGetValue(slot, out ability))
                    //{
                    //    WriteH(writer, ability.Key); // ability id
                    //    WriteH(writer, ability.Value); // ability level
                    //}
                    //else
                    //{
                        WriteD(writer, 0);
                    //}
                }
                else
                {
                    WriteD(writer, 0);
                }
            }
            WriteH(writer, 0);
            WriteH(writer, 65520);
            WriteH(writer, 7);
            WriteD(writer, 0);
        }
    }
}
