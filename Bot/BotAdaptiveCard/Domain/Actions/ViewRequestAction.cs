﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using BotAdaptiveCard.Cards;

namespace BotAdaptiveCard.Domain.Actions
{
    public class ViewRequestAction : IAction
    {
        public async Task Execute(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            var attach = CardProvider.CreateViewActionCard();

            await turnContext.SendActivityAsync(MessageFactory.Attachment(attach), cancellationToken);
        }
    }
}