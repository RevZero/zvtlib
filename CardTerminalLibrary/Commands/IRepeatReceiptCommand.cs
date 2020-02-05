using System;
using System.Collections.Generic;
using System.Text;

namespace Wiffzack.Devices.CardTerminals.Commands
{
    /// <summary>
    /// Repeats the last receipt
    /// </summary>
    public interface IRepeatReceiptCommand:ICommand
    {

        RepeatReceiptResult Execute();
    }
}
