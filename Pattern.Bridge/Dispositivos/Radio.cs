using Pattern.Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge.Dispositivos
{
    public class Radio : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Radio encendida");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio apagada");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Sintonizando emisora " + channel);
        }
    }
}
