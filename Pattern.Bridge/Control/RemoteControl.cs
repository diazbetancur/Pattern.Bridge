﻿using Pattern.Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge.Control
{
    public abstract class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void SetChannel(int channel);
    }
}
