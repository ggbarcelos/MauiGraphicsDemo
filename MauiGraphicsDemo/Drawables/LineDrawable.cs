
namespace MauiGraphicsDemo.Drawables;

public class LineDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.Blue;
        canvas.StrokeSize = 6;
        canvas.DrawLine(80, 80, 200, 200);
    }
}

