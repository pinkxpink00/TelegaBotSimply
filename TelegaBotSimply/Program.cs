using Telegram.Bot;
using Telegram.Bot.Types;

class Program
{
    static void Main()
    {
        var BotApiKey = "6952143006:AAGnQWEsAu_hgNyAfIiiK_dPzlPmy6rEn-U";

        TelegramBotClient? _telegramBotClient = new TelegramBotClient(BotApiKey);
        
        _telegramBotClient.StartReceiving(UpdateHandler,ErrorHandler);
        Console.WriteLine("Bot started successfully and listnening the specific channel");
        Console.ReadKey();
    }

    public static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken token)
    {
        string responseMessage;

        if (update.Message.Sticker is not null)
        {
            responseMessage = "Close your ass";
        }
        else
        {
            responseMessage = "I coudn't understand you";
        }
        
        await bot.SendTextMessageAsync(update.Message.Chat.Id, responseMessage);
    }

    private static async Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken token)
    {
          Console.WriteLine("Error Happened");
    }
}