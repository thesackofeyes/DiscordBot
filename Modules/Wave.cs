using Discord.Commands;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class Wave : ModuleBase<SocketCommandContext>
    {
        [Command("o/")]
        public async Task PingAsync()
        {
            ArrayList waves = new ArrayList();
            waves.Add("o/");
            waves.Add("\\o");
            waves.Add("o7");
            waves.Add("\\o/");

            Random RandomGen = new Random(DateTime.Now.Millisecond);
            ArrayList ScrambledList = new ArrayList();

            Int32 Index;

            // randomly remove items from the first list and
            // put them in the second list
            while (waves.Count > 0)
            {
                Index = RandomGen.Next(waves.Count);
                ScrambledList.Add(waves[Index]);
                waves.RemoveAt(Index);
            }

            await ReplyAsync(ScrambledList[0].ToString());
        }

    }
}