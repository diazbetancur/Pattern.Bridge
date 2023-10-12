using Pattern.Bridge.Control;
using Pattern.Bridge.Dispositivos;
using Pattern.Bridge.Interface;

IDevice tv = new TV();
RemoteControl remote = new BasicRemoteControl(tv);

remote.TurnOn();
remote.SetChannel(5);
remote.TurnOff();

IDevice radio = new Radio();
AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);

advancedRemote.TurnOn();
advancedRemote.SetChannel(102);
advancedRemote.Mute();
advancedRemote.TurnOff();

Console.WriteLine("Hello, World!");
