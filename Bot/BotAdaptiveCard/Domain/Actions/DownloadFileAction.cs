using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using BotAdaptiveCard.Cards;

namespace BotAdaptiveCard.Domain.Actions
{
    public class DownloadFileAction : IAction
    {
        public async Task Execute(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            var message = turnContext.Activity;

            if (message.Attachments == null)
            {
                await turnContext.SendActivityAsync(MessageFactory.Text($"Please, select file:"), cancellationToken);
            }
            else
            {
                if (message.Attachments != null && message.Attachments.Any())
                {
                    var attachFile = message.Attachments.First();

                    var filename = Path.Combine(Directory.GetCurrentDirectory(), attachFile.Name);

                    using (var client = new WebClient())
                    {
                        client.DownloadFile(attachFile.ContentUrl, filename);
                    }
                }

                await turnContext.SendActivityAsync(MessageFactory.Text($"Download file"));
            }
        }
    }
}
