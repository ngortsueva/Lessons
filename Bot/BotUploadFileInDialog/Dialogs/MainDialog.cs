using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Choices;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Logging;

namespace BotUploadFileInDialog.Dialogs
{
    public class MainDialog : ComponentDialog
    {
        protected readonly ILogger _logger;

        public MainDialog(ILogger<MainDialog> logger)
            : base(nameof(MainDialog))
        {
            _logger = logger;
                       
            AddDialog(new AttachmentPrompt(nameof(AttachmentPrompt)));
            AddDialog(new TextPrompt(nameof(TextPrompt)));
            AddDialog(new WaterfallDialog(nameof(WaterfallDialog), new WaterfallStep[]
            {
                PromptUploadFileAsync,
                UploadFileAsync,
            }));

            // The initial child Dialog to run.
            InitialDialogId = nameof(WaterfallDialog);
        }

        private async Task<DialogTurnResult> PromptUploadFileAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var options = new PromptOptions()
            {
                Prompt = MessageFactory.Text("Select file:"),
            };
            
            return await stepContext.PromptAsync(nameof(AttachmentPrompt), options, cancellationToken);            
        }

        private async Task<DialogTurnResult> UploadFileAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {            
            string name = DownloadFile(stepContext.Context, cancellationToken);

            await stepContext.Context.SendActivityAsync(MessageFactory.Text($"File {name} received"), cancellationToken);

            await stepContext.Context.SendActivityAsync(MessageFactory.Text($"End dialog"), cancellationToken);

            return await stepContext.EndDialogAsync();
        }

        protected string DownloadFile(ITurnContext turnContext, CancellationToken cancellationToken)
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
                return attach.Name;
            }
            return "";

            //await turnContext.SendActivityAsync(MessageFactory.Text($"End dialog"), cancellationToken);
        }
    }
}
