using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class COMMAND_NAME : ModuleBase<SocketCommandContext>
    {
        [Command("COMMAND_NAME")]
        public async Task PingAsync()
        {
            await ReplyAsync("COMMAND_DOES");
        }
    }
}
