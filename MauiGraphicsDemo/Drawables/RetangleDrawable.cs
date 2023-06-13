
namespace MauiGraphicsDemo.Drawables;

public class RetangleDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.Blue;
        canvas.StrokeSize = 4;
        canvas.DrawRectangle(80, 80, 200, 150);
    }
}

