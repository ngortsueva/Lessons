using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotAdaptiveCard.Domain.Actions;

namespace BotAdaptiveCard.Domain
{
    public class BotActionFactory
    {
        public static IAction CreateAction(string actionName)
        {
            switch (actionName)
            {
                case BotActions.ViewRequest: return new ViewRequestAction();
                case BotActions.InputRequestNumber: return new InputRequestAction();
                case BotActions.OpenRequestList: return new ViewRequestListAction();
                case BotActions.RecentRequestList: return new ViewRequestListAction();
                case BotActions.DownloadFile: return new DownloadFileAction();

                default: return new EmptyAction();


            }
        }
    }
}
