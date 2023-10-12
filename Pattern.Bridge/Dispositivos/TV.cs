using Pattern.Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge.Dispositivos
{
    public class TV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("TV encendida");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV apagada");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Cambiando canal a " + channel);
        }
    }
}
