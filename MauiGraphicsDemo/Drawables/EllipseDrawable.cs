
namespace MauiGraphicsDemo.Drawables;

public class EllipseDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.Blue;
        canvas.StrokeSize = 4;
        canvas.DrawEllipse(80, 80, 200, 150);
    }
}

