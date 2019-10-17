using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Bot.Builder;

namespace BotAdaptiveCard.Domain
{
    public interface IAction
    {
        Task Execute(ITurnContext turnContext, CancellationToken cancellationToken);
    }
}
