using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Input
    {
        public string Data { get; private set; }
        public string Time { get; private set; }
        public Input(string input)
        {
            string[] temp = input.Split(':');
            Data = temp[0];
            Time = temp[1];
        }
    }
}
