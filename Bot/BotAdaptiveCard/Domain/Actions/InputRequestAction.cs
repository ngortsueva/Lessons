using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using BotAdaptiveCard.Cards;

namespace BotAdaptiveCard.Domain.Actions
{
    public class InputRequestAction : IAction
    {
        public async Task Execute(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            var text = turnContext.Activity.Text;

            if (text == null)
            {
                await turnContext.SendActivityAsync(MessageFactory.Text($"Please, input request id:"), cancellationToken);
            }
            else
            {
                await turnContext.SendActivityAsync(MessageFactory.Text($"Your request id: {text}"), cancellationToken);
            }
        }
    }
}
