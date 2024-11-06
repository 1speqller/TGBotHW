using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TestTGBot.Extensions;

namespace TestTGBot.Controllers
{
    /// <summary>
    /// Контроллер для работы с входящими текстовыми сообщениями
    /// </summary>

    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public TextMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            int result;
            if (message.Text == "/start")
            {
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Наш бот считает количество символов в тексте. {Environment.NewLine}" +
                $"{Environment.NewLine}Или сумму двух введенных вами чисел.{Environment.NewLine}", cancellationToken: ct,
                parseMode: ParseMode.Html);
            }

            else if (int.TryParse(message.Text.Replace(" ", ""), out result))
            {
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Сумма чисел : {StringExtensions.SummaryNumberInString(message.Text)}. {Environment.NewLine}");
            }

            else if (message.Text != null)
            {
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, $" Количество символов в веденном вами сообщении равна: {message.Text.Length} {Environment.NewLine}");
            }

            else
                await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Введите текст или пару чисел.", cancellationToken: ct);
        }
    }
}