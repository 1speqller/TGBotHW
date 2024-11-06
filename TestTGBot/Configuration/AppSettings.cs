using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTGBot.Configuration
{
    /// <summary>
    /// Класс с данными конфигурации бота
    /// </summary>

    public class AppSettings
    {
        // Tокен Telegram API
        public string BotToken { get; set; }

        public AppSettings ()
        {
            BotToken = "7813534619:AAHhD9RASRumRNH7sd8ON5mAsdLVx2MKZfo";
        }
    }
}
