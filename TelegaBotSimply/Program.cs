using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegaBotSimply
{
    internal class Program
    {
        static void Main()
        {
            var botApiKey = "6952143006:AAGnQWEsAu_hgNyAfIiiK_dPzlPmy6rEn-U";

            TelegramBotClient telegramBotClient = new TelegramBotClient(botApiKey);
            
            telegramBotClient.StartReceiving(UpdateHandler, ErrorHandler);
            Console.WriteLine("Bot started successfully and listnening the specific channel");
            
            Console.ReadKey();
        }

        private static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken token)
        {
            try
            {
                if (update.Message != null)
                {
                    if (update.Message?.Sticker != null)
                    {
                        string responseMessage = "Suck my cock";
                        await bot.SendTextMessageAsync(update.Message.Chat.Id, responseMessage);
                    }
                }
                else
                {
                    Console.WriteLine("Received an update without a message.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateHandler: {ex.Message}");
            }
        }

        private static async Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken token)
        {
            Console.WriteLine("Error....");
        }
    }
}