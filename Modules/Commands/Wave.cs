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
            await ReplyAsync(getWave());
        }
        public String getWave(){
            ArrayList<String> waves = new ArrayList<String>();
            waves.add("o/");
            waves.add("o7");
            waves.add("o7");
            waves.add("o/");
            Collections.shuffle(waves);
            return waves.get(0);
        }
    }
}
