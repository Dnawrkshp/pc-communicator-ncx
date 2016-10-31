using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCheatX.Core;
using NetCheatX.Core.Interfaces;

namespace PCCommunicator
{
    public class Plugin : IPluginMain
    {
        private Communicator _communicator;
        private ObjectVersion _version = null;


        public string Author { get; } = "Daniel Gerendasy";
        public string Description { get; } = "PC Communicator plugin for NetCheat X.";
        public string Name { get; } = "BasicSearch";
        public ObjectVersion Version { get { return _version; } }
        public string[] SupportedPlatforms { get; } = null;

        // Register our PC Communicator
        public void Initialize(IPluginHost host)
        {
            _version = new ObjectVersion(1, 0);
            host.Communicators.Add(this, _communicator = new Communicator());
        }

        // Clean up
        public void Dispose(IPluginHost host)
        {
            _communicator = null;
            _version = null;
        }
    }
}
