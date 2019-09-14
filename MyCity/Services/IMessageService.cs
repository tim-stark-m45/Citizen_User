﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCity.Services
{
    interface IMessageService
    {
        void ShowInfo(string text, string title = "Info");
        void ShowError(string text, string title = "Error");
        bool ShowYesNo(string text, string title = "Your answer:");
    }
}
