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
    class DebugDaemon : IInterface
    {
        public string InitialServiceName => "DebugMod";
        private DebugModState State;
        private float t = 0f;
        private static Color themeColour = new Color(45, 180, 231);

        public void Draw(Instance instance, Rectangle bounds, SpriteBatch sb) // Draws stuff on the screen, will need
        {
            Rectangle bounds1 = new Rectangle(bounds.X + 40, bounds.Y + 40, bounds.Width - 80, bounds.Height - 80);
            t += 1.0f;
            if (t > 50.1f)
            switch (State)
            {
                case DebugModState.HomePage:
                    DrawHome(bounds1, instance, t, sb);
                    break;
                case DebugModState.DebugPage:
                        DrawDebug(bounds1, instance, t, sb);
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

        private void DrawDebug(Rectangle rect, Instance instance, float ticks, SpriteBatch sb)
        {
            OS os = instance.os;
            Color colour = new Color(45, 180, 231);
            const string doLabel = "doLabel";
            const string doMeasuredSmallLabel = "doMeasuredSmallLabel";
            const string doMeasuredTinyLabel = "doMeasuredTinyLabel";
            TextItem.doLabel(new Vector2(500f, 400f), doLabel, null);
            TextItem.doMeasuredSmallLabel(new Vector2(500f, 500f), doMeasuredSmallLabel, null);
            TextItem.doMeasuredTinyLabel(new Vector2(500f, 600f), doMeasuredTinyLabel, null);
            if (Button.doButton(1, 800, 100, 200, 75, "Button", null))
                State = DebugModState.HomePage;
            Button.doButton(2, 685, 843, 25, 25, "<-", null);
            Button.doButton(2, 733, 843, 25, 25, "->", null);
        }

        private void DrawHome(Rectangle rect, Instance instance, float ticks, SpriteBatch sb)
        {
            const string title = "Debug Mod";
            const string newVersion = "New version of Debug Mod is available";
            string newVersionLine2 = "You are currently running: " + DebugMod.version + " New version: " + DebugMod.newVersion;
            TextItem.doLabel(new Vector2(280f, 55f), title, null);
            TextItem.doMeasuredSmallLabel(new Vector2(500f, 55f), newVersion, themeColour);
            TextItem.doMeasuredSmallLabel(new Vector2(500f, 70f), newVersionLine2, themeColour);
            Button.doButton(2, 673, 843, 25, 25, "<-", null);
            Button.doButton(2, 720, 843, 25, 25, "->", null);
        }

        public void InitFiles(Instance instance) // IDK what this does, maybe creates the files, in that case no
        {
            throw new NotImplementedException();
        }

        public void LoadInit(Instance instance) // IDK what this does
        {
            instance.registerAsDefaultBootDaemon();
        }

        public void LoadInstance(Instance instance, Dictionary<string, string> objects) // IDK what this does
        {
            
        }

        public void OnCreate(Instance instance) // May or may not need this
        {

        }

        public void OnNavigatedTo(Instance instance) // Won't need this
        {
            State = DebugModState.DebugPage;
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
            DebugPage,
        }
    }
}
