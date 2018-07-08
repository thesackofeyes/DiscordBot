using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class RemindMe : ModuleBase<SocketCommandContext>
    {
        [Command("remindme")]
        public async Task PingAsync(String time) // <- this is how you parse more args on a command
        {
            EmbedBuilder builder = new EmbedBuilder();
            int minutes = Int32.Parse(time);
            

            //Builds Chat Message
            builder.WithTitle("Reminder set for "+ time + " Minutes.")
            .WithDescription(Context.User.Mention + " Will be notified via Direct Message.")
            .WithColor(Color.Blue);

            //Sends DM
            await Context.User.SendMessageAsync("Ngl bud, this shit don't work yet.");

            //Sends Chat Message
            await ReplyAsync("",false,builder.Build());
        }
    }
}
