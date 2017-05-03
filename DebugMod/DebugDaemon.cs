using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pathfinder.Daemon;
using Hacknet;

namespace DebugMod
{
    class DebugDaemon : IInterface
    {
        public string InitialServiceName => "DebugMod";

        public void Draw(Instance instance, Rectangle bounds, SpriteBatch sb)
        {
            throw new NotImplementedException();
        }

        public void InitFiles(Instance instance) // IDK what this does, maybe creates the files, in that case no
        {
            throw new NotImplementedException();
        }

        public void LoadInit(Instance instance) // IDK what this does
        {
            throw new NotImplementedException();
        }

        public void LoadInstance(Instance instance, Dictionary<string, string> objects) // IDK what this does
        {
            throw new NotImplementedException();
        }

        public void OnCreate(Instance instance) // May or may not need this
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(Instance instance) // Won't need this
        {
        }

        public void OnUserAdded(Instance instance, string name, string pass, byte type) // Won't need this
        {
            
        }
        private enum State {
            HomePage,
            Page1,
            Page2,
            Page3,
            Page4,
            Page5,
        }
    }
}
