using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class wave : ModuleBase<SocketCommandContext>
    {
        [Command("o/")]
        public async Task PingAsync()
        {
            String[] waves = ["\o","o7","\o/"];
            ArrayList<String> waves = new ArrayList<String>();
            waves.add("o/");
            waves.add("\o");
            waves.add("o7");
            waves.add("\o/");
            Collections.shuffle(waves);
            String reply = waves.get(0);
            await ReplyAsync(reply);
        }
    }
}
