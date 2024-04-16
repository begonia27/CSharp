using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Search;
using Windows.UI.Xaml.Automation.Peers;
using DataTypes;

namespace CheckoutService
{
    public class CheckoutController
    {
        public delegate void CheckoutDelegate(Order order);

        public CheckoutDelegate CheckoutProcessing = null;
        
        private bool RequestPayment()
        {
            // Payment processing goes here

            // Payment logic is not implemented in this example
            // - simply return true to indicate payment has been received
            return true;
        }

        public void StartCheckoutProcessing(Order order)
        {
            if (RequestPayment())
            {
                if (CheckoutProcessing is not null)
                {
                    CheckoutProcessing(order);
                }
            }
        }
    }
}

// 发布者类
// class TemperatureMonitor
// {
//     // 定义委托事件
//     public delegate void StopMachineryDelegate();
//
//     // 定义触发事件的方法
//     public event StopMachineryDelegate MachineOverHeating;
//     public event StopMachineryDelegate MachineDefault;
// }

// 订阅事件
// TemperatureMonitor tempMonitor = new TemperatureMonitor();
// tempMonitor.MachineOverHeating += (() => Folder.StopFolding(0));
// tempMonitor.MachineOverHeating += welder.FinishWelding;
// tempMonitor.MachineOverHeating += PatternInterface.PaintOff;

// 取消订阅事件
// TemperatureMonitor tempMonitor = new TemperatureMonitor();
// tempMonitor.MachineDefault -= welder.FinishWelding;

// 引发事件
// private void Notify()
// {
//     if (MachineOverHeating is not null)
//     {
//         MachineOverHeating();
//     }
// }
