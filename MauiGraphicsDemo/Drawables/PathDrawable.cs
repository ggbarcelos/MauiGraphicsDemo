
namespace MauiGraphicsDemo.Drawables;

public class PathDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        PathF path = new PathF();
        path.MoveTo(40, 40);
        path.LineTo(170, 180);
        path.LineTo(110, 180);
        path.Close();
        canvas.StrokeColor = Colors.Blue;
        canvas.StrokeSize = 6;
        canvas.DrawPath(path);
    }
}

