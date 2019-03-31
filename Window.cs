using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;

namespace Heartbeat {
    public class Window : GameWindow {
        KeyboardState keyState, lastKeyState;
        Color4 BackColor;
        public string Name;
        public Window (int width, int height, string title, bool vs) : base (width, height, GraphicsMode.Default, title, GameWindowFlags.FixedWindow) {
            Name = title;
            if (vs) {
                VSync = VSyncMode.On;
            } else {
                VSync = VSyncMode.Off;
            }

            BackColor.A = 1.0f;
            BackColor.R = 0.0f;
            BackColor.G = 0.0f;
            BackColor.B = 0.0f;
        }

        protected override void OnUpdateFrame (FrameEventArgs e) {

            keyState = Keyboard.GetState ();

            if (CKeyPress (Key.Escape)) {
                Exit ();
            }

            lastKeyState = keyState;

            base.OnUpdateFrame (e);
        }

        protected override void OnRenderFrame (FrameEventArgs e) {
            Title = $"{Name} (VSync: {VSync}) FPS: {1f / e.Time:0}";

            GL.ClearColor (BackColor);
            GL.Clear (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SwapBuffers ();
        }

        public bool CKeyPress (Key key) {
            return (keyState[key] && (keyState[key] != lastKeyState[key]));
        }
    }
}