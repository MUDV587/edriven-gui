#region License

/*
 
Copyright (c) 2010-2014 Danko Kozar

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 
*/

#endregion License

using eDriven.Gui.Components;
using eDriven.Gui.Graphics.Base;
using UnityEngine;
using Rect=eDriven.Gui.Graphics.Rect;

namespace eDriven.Gui.Designer.Styles
{
    public class PlayModeOverlaySelectionBorderStyle
    {
        #region Quasi-Singleton

        private static GUIStyle _instance;
        public static GUIStyle Instance
        {
            get
            {
                //Debug.Log("Getting PlayModeOverlayHoverBorderStyle instance");

                if (_instance == null)
                {
                    _instance = new GUIStyle();
                    Initialize();
                }
                return _instance;
            }
        }

        private PlayModeOverlaySelectionBorderStyle()
        {
            // constructor is protected
        }

        #endregion

        public static int BorderWidth = 4;
        public static Color BorderColor = Color.white; // RgbColor.FromHex(0x335fd8).ToColor();

        private static ProgramaticStyle _style;

        public static void Draw()
        {
            Initialize();
        }

        private static void Initialize()
        {
            _style = new ProgramaticStyle {Style = _instance};

            int w = (BorderWidth + 1) * 2;

            _style.Border = new RectOffset(BorderWidth + 1, BorderWidth + 1, BorderWidth + 1, BorderWidth + 1);

            _style.NormalGraphics = new Rect(w, w,
                                             new Fill(new Color(0.9f, 0.9f, 0.9f, 0)), // transparent fill!
                                             new Stroke(BorderWidth) { Color = BorderColor }
                );

            _style.Commit();
        }
    }
}