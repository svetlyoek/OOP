namespace Graphic_Editor.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IDrawing
    {
        string Draw(IShape shape);
    }
}
