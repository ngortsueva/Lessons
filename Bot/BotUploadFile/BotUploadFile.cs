using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Net;

namespace BotUploadFile
{
    public class EmptyBot : ActivityHandler
    {
        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Bot: Upload file "), cancellationToken);
                }
            }
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var message = turnContext.Activity;

            if(message.Attachments != null && message.Attachments.Any())
            {
                var attach = message.Attachments.First();

                var filename = Path.Combine(Directory.GetCurrentDirectory(), attach.Name);

                using(var client = new WebClient())
                {
                    client.DownloadFile(attach.ContentUrl, filename);
                }
            }          

            await turnContext.SendActivityAsync(MessageFactory.Text($"End dialog"), cancellationToken);            
        }
    }
}
