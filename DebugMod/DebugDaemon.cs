using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pathfinder.Daemon;
using Hacknet;
using Hacknet.Gui;

namespace DebugMod
{
    class DebugDaemon : Daemon, IInterface
    {
        public string InitialServiceName => "DebugMod";
        private DebugModState State;

        public DebugDaemon(Computer computer, OS opSystem, string serviceName = "DebugMod") : base(computer, serviceName, opSystem)
        {

        }

        public void Draw(Instance instance, Rectangle bounds, SpriteBatch sb) // Draws stuff on the screen, will need
        {
            Rectangle bounds1 = new Rectangle(bounds.X + 40, bounds.Y + 40, bounds.Width - 80, bounds.Height - 80);
            switch (State)
            {
                case DebugModState.HomePage:
                    DrawHome(bounds1);
                    break;
                case DebugModState.Page1:
                    break;
                case DebugModState.Page2:
                    break;
                case DebugModState.Page3:
                    break;
                case DebugModState.Page4:
                    break;
                case DebugModState.Page5:
                    break;
            }
        }

        private void DrawHome(Rectangle rect)
        {
            string text = "IT WORKS! IT WORKS!";
            Vector2 pos = new Vector2(20, 20);
            TextItem.doLabel(pos, text, null);
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

        }

        public void OnNavigatedTo(Instance instance) // Won't need this
        {
            State = DebugModState.HomePage;
        }

        public void OnUserAdded(Instance instance, string name, string pass, byte type) // Won't need this
        {
            
        }
        internal void NewCommand()
        {
            
        }
        private enum DebugModState {
            HomePage,
            Page1,
            Page2,
            Page3,
            Page4,
            Page5,
        }
    }
}
