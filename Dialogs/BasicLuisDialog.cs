using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(ConfigurationManager.AppSettings["LuisAppId"], ConfigurationManager.AppSettings["LuisAPIKey"])))
        {
        }

        [LuisIntent("")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the blank intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        // Go to https://luis.ai and create a new intent, then train/publish your luis app.
        // Finally replace "MyIntent" with the name of your newly created intent in the following handler
        [LuisIntent("None")]
        public async Task NoneIntent2(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }




        [LuisIntent("shop.deliverypolicy")]
        public async Task shopdeliverypolicy(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.deliverypolicy intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("shop.giftcard")]
        public async Task shopgiftcard(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.giftcard intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("shop.opening")]
        public async Task MyIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.opening intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("shop.orders.delivery")]
        public async Task shopordersdelivery(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.orders.delivery intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("shop.orders.find")]
        public async Task shopordersfind(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.orders.find intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("shop.orders.refund")]
        public async Task shopordersrefund(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.orders.refund intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("shop.product.recommend")]
        public async Task shopproductrecommend(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the shop.product.recommend intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }


    }
}