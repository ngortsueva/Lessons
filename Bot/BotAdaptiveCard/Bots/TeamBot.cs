using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Logging;
using BotAdaptiveCard.Cards;
using BotAdaptiveCard.Model;
using BotAdaptiveCard.Domain;
using System.IO;
using System.Net;

namespace BotAdaptiveCard.Bots
{
    public class TeamBot : ActivityHandler
    {        
        protected readonly BotState ConversationState;
        protected readonly BotState UserState;
        protected readonly ILogger Logger;
        private string action;
        private string value;

        public TeamBot(ConversationState conversationState, UserState userState, ILogger<TeamBot> logger)
        {
            ConversationState = conversationState;
            UserState = userState;            
            Logger = logger;
        }
        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    var attach = CardProvider.CreateWelcomeCard();
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Hello world!"), cancellationToken);
                    await turnContext.SendActivityAsync(MessageFactory.Attachment(attach), cancellationToken);
                }
            }
        }

        public override async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default(CancellationToken))
        {
            await base.OnTurnAsync(turnContext, cancellationToken);
            
            await ConversationState.SaveChangesAsync(turnContext, false, cancellationToken);
            await UserState.SaveChangesAsync(turnContext, false, cancellationToken);
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var userActionAccessor = UserState.CreateProperty<UserAction>(nameof(UserAction));
            var userAction = await userActionAccessor.GetAsync(turnContext, () => new UserAction());

            var message = turnContext.Activity;

            var text = message.Text;

            dynamic data = message.Value;

            if (data != null)
            {
                userAction.ActionName = data["Action"];
                //value = data["Value"];
            }

            //var action = BotActionFactory.CreateAction(userAction.ActionName);

            //await action.Execute(turnContext, cancellationToken);
            
            switch (userAction.ActionName)
            {
                case "ViewRequest":                    
                    var attach = CardProvider.CreateViewActionCard();
                    await turnContext.SendActivityAsync(MessageFactory.Attachment(attach), cancellationToken);
                    break;

                case "InputRequestNumber":
                    if(text == null)
                        await turnContext.SendActivityAsync(MessageFactory.Text($"Please, input request id:"), cancellationToken);
                    else
                    {
                        await turnContext.SendActivityAsync(MessageFactory.Text($"Your request id: {text}"), cancellationToken);
                    }
                    break;

                case "OpenRequestList":
                    attach = CardProvider.CreateRequestListCard();
                    await turnContext.SendActivityAsync(MessageFactory.Attachment(attach), cancellationToken);
                    break;

                case "RecentRequestList":
                    attach = CardProvider.CreateRequestListCard();
                    await turnContext.SendActivityAsync(MessageFactory.Attachment(attach), cancellationToken);
                    break;

                case "DownloadFile":
                    
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
                    break;


            }
            
            await UserState.SaveChangesAsync(turnContext);
        }

        private async Task DownloadFile(ITurnContext<IMessageActivity> turnContext)
        {
            var message = turnContext.Activity;

            if (message.Attachments != null && message.Attachments.Any())
            {
                var attach = message.Attachments.First();

                var filename = Path.Combine(Directory.GetCurrentDirectory(), attach.Name);

                using (var client = new WebClient())
                {
                    client.DownloadFile(attach.ContentUrl, filename);
                }
            }

            await turnContext.SendActivityAsync(MessageFactory.Text($"Download file"));
        }
    }
}
