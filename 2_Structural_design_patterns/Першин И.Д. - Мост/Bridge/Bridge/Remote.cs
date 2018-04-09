using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Device;

namespace Bridge.Remote
{
    public interface IRemote
    {
        void Power();
        void VolumeDown();
        void VolumeUp();
        void ChannelDown();
        void ChannelUp();
    }

    public class BasicRemote : IRemote
    {
        protected IDevice device;

        public BasicRemote() { }

        public BasicRemote(IDevice device)
        {
            this.device = device;
        }
        
        public void Power()
        {
            Console.WriteLine("Remote: power toggle");
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }
        
        public void VolumeDown()
        {
            Console.WriteLine("Remote: volume down");
            device.SetVolume(device.GetVolume() - 10);
        }
        
        public void VolumeUp()
        {
            Console.WriteLine("Remote: volume up");
            device.SetVolume(device.GetVolume() + 10);
        }
        
        public void ChannelDown()
        {
            Console.WriteLine("Remote: channel down");
            device.SetChannel(device.GetChannel() - 1);
        }
        
        public void ChannelUp()
        {
            Console.WriteLine("Remote: channel up");
            device.SetChannel(device.GetChannel() + 1);
        }
    }

    public class AdvancedRemote : BasicRemote
    {
        public AdvancedRemote(IDevice device)
            :base(device)
        { }

        public void Mute()
        {
            Console.WriteLine("Remote: mute");
            device.SetVolume(0);
        }
    }
}
