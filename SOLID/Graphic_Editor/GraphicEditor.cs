namespace Graphic_Editor
{
    using Graphic_Editor.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class GraphicEditor : IDrawing
    {
        public string Draw(IShape shape)
        {
            return $"I'm {shape.GetType().Name}";
        }
    }
}
