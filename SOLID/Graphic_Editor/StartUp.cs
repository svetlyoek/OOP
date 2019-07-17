namespace Graphic_Editor
{
    using global::Graphic_Editor;
    using System;
    public class StartUp
    {
        static void Main()
        {
            IShape square = new Square();
            IShape rectangle = new Rectangle();
            var editor = new GraphicEditor();

            Console.WriteLine(editor.Draw(square));
            Console.WriteLine(editor.Draw(rectangle));
        }
    }
}
