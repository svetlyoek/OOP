﻿namespace CommandPattern.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
