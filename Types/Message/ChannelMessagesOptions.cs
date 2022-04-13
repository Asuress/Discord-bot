using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord_bot.Types
{
    public static class ChannelMessagesOptions //работает наверное
    
    {
        private static string around = "around=";
        private static string before ="before=" ;
        private static string after = "after=";
        private static string limit = "limit=";

        private static Dictionary<MessagesOptions, string> dict = new Dictionary<MessagesOptions, string>()
        {
            {
                MessagesOptions.AROUND ,around
            },
            {
                MessagesOptions.AFTER , after
            },
            {
                MessagesOptions.BEFORE, before
            }
        };


        public enum MessagesOptions
        {
            NONE,
            AROUND,
            BEFORE,
            AFTER
        }
        public static string[] GetOptions(MessagesOptions type, string messageId, int limit = 50)
        {  
            if (type == MessagesOptions.NONE) return new string[] {ChannelMessagesOptions.limit + limit}; //надо продумать

            return  new []{dict[type] + messageId, ChannelMessagesOptions.limit + limit};


        }

    }
}