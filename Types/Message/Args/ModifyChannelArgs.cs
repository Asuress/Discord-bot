using System.Collections.Generic;

namespace Discord_bot.Types
{
    public class ModifyChannelArgs
    {
        public ModifyChannelArgs(){}
        public ModifyChannelArgs(Channel channel)
        {
            Name = channel.Name;
            Position = channel.Position;
            PermissionOverwrites = channel.PermissionOverwrites;
        }
        string name;
        int? position;
        LinkedList<Overwrite> permission_overwrites;

        public string Name { get => name; set => name = value; }
        public int? Position { get => position; set => position = value; }
        public LinkedList<Overwrite> PermissionOverwrites { get => permission_overwrites; set => permission_overwrites = value; }
    }
}