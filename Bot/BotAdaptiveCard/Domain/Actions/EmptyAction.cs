using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace BotAdaptiveCard.Domain.Actions
{
    public class EmptyAction : IAction
    {
        public async Task Execute(ITurnContext turnContext, CancellationToken cancellationToken) { }
    }
}
