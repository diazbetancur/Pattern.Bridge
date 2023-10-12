using Pattern.Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge.Control
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void Mute()
        {
            Console.WriteLine("Silenciando el dispositivo");
        }

        public override void TurnOn()
        {
            // Implementación para encender
            Console.WriteLine("Encendiendo el dispositivo...");
        }

        public override void TurnOff()
        {
            // Implementación para apagar
            Console.WriteLine("Apagando el dispositivo...");
        }

        public override void SetChannel(int channel)
        {
            // Implementación para cambiar de canal
            Console.WriteLine($"Cambiando al canal {channel}");
        }
    }
}
