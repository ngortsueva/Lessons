using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Bot06UsingCard.Cards
{
    public static class CardProvider
    {
        public static Attachment CreateAdaptiveCardAttachment()
        {
            string[] path = { ".", "Cards", "adaptiveCard.json" };

            var adaptiveCardJson = File.ReadAllText(Path.Combine(path));

            var attach = new Attachment()
            {
                ContentType = "application/vnd.microsoft.card.adaptive",
                Content = JsonConvert.DeserializeObject(adaptiveCardJson)
            };

            return attach;
        }

        public static HeroCard GetHeroCard()
        {
            var heroCard = new HeroCard()
            {
                Title = "BotFramework HeroCard",
                Subtitle = "Microsoft Bot Framework",
                Text = "Build and connect bots",
                Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                Buttons = new List<CardAction>() { new CardAction(ActionTypes.ImBack, "Back", value: "Back") }
            };

            return heroCard;
        }

        public static ThumbnailCard GetThumbnailCard()
        {
            var heroCard = new ThumbnailCard()
            {
                Title = "ThumbnailCard",
                Subtitle = "Microsoft Bot Framework",
                Text = "Build and connect intelligent bots to interact with your users",
                Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Get Started", value: "https://docs.microsoft.com/bot-framework") }
            };

            return heroCard;
        }
    }
}
