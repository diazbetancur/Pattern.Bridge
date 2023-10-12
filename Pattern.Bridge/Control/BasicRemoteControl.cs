using Pattern.Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge.Control
{
    public class BasicRemoteControl : RemoteControl
    {
        public BasicRemoteControl(IDevice device) : base(device) { }

        public override void TurnOn()
        {
            Console.WriteLine("Control remoto encendido");
            device.TurnOn();
        }

        public override void TurnOff()
        {
            Console.WriteLine("Control remoto apagado");
            device.TurnOff();
        }

        public override void SetChannel(int channel)
        {
            Console.WriteLine("Cambiando canal a " + channel);
            device.SetChannel(channel);
        }
    }
}
