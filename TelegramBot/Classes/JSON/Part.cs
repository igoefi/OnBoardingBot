using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Classes.JSON
{
    public class Part
    {
        public string Name { get; private set; }
        public string Theory { get; private set; }

        public VictorineData Victorine { get; private set; }
    }
}
