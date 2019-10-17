using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using AdaptiveCards;
using Newtonsoft.Json.Linq;

namespace BotAdaptiveCard.Cards
{
    public class CardProvider
    {
        public static Attachment CreateWelcomeCard()
        {
            var card = new AdaptiveCard(new AdaptiveSchemaVersion(1,0))
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveTextBlock(){ Text = "Welcome" }
                },
                Actions = new List<AdaptiveAction>()
                {
                    new AdaptiveSubmitAction
                    {
                          Title = "View Request",
                          Data = new { Action = "ViewRequest", Value = "ViewRequest"}                         
                    },
                    new AdaptiveSubmitAction
                    {
                          Title = "Create Request",
                          Data = new { Action = "CreateRequest", Value = "CreateRequest"}
                    },
                    new AdaptiveSubmitAction
                    {
                          Title = "Download file",
                          Data = new { Action = "DownloadFile", Value = "DownloadFile"}
                    }
                }   
            };

            var attach = new Attachment
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };

            return attach;
        }

        public static Attachment CreateViewActionCard()
        {
            var card = new AdaptiveCard(new AdaptiveSchemaVersion(1, 0))
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveTextBlock(){ Text = "Welcome" }
                },
                Actions = new List<AdaptiveAction>()
                {
                    new AdaptiveSubmitAction
                    {
                          Title = "Input Request Number",
                          Data = new { Action="InputRequestNumber", Value = "InputRequestNumber"}
                    },
                    new AdaptiveSubmitAction
                    {
                          Title = "Open Request List",
                          Data = new { Action = "OpenRequestList", Value = "OpenRequestList"}
                    },
                    new AdaptiveSubmitAction
                    {
                          Title = "Recent Request List",
                          Data = new { Action = "RecentRequestList", Value = "RecentRequestList"}
                    }
                }
            };

            var attach = new Attachment
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };

            return attach;
        }

        public static Attachment CreateRequestListCard()
        {
            var card = new AdaptiveCard(new AdaptiveSchemaVersion(1, 0))
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveTextBlock(){ Text = "Requests:" }
                },
                Actions = new List<AdaptiveAction>()
                {
                    new AdaptiveSubmitAction
                    {
                          Title = "Request 01",
                          Data = new { Action = "OpenRequest", Value = "Request01"}
                    },
                    new AdaptiveSubmitAction
                    {
                          Title = "Request 02",
                          Data = new { Action = "OpenRequest", Value = "Request02"}
                    },
                    new AdaptiveSubmitAction
                    {
                          Title = "Request 03",
                          Data = new { Action = "OpenRequest", Value = "Request03"}
                    }
                }
            };

            var attach = new Attachment
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };

            return attach;
        }
    }
}
