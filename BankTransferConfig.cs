using System;
using Newtonsoft.Json;

namespace modul8_1302220031
{
	public class BankTransferConfig
	{
        public BankTransferConfig loadData()
		{
            string data = File.ReadAllText("/Users/hasannp/SEMESTER (4)/5. Konstruksi PL/modul8_1302220031/bank_transfer_config.json");
            BankTransferConfig json = JsonConvert.DeserializeObject<BankTransferConfig>(data);
            return json;
        }

        public void UbahBahasa()
        {
            if (lang == "en")
            {
                lang = "id";
            }
            else if (lang == "id")
            {
                lang = "en";
            }
        }

        public string lang { get; set; }
        public int transfer { get; set; }

        public string methods { get; set; }
        public string confirmation { get; set; }
    }
}