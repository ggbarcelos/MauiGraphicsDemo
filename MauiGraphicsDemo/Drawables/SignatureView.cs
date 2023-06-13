﻿
namespace MauiGraphicsDemo.Drawables;

public class SignatureView : GraphicsView
{
    GraphicsDrawable graphicsDrawable = null;
    public SignatureView()
    {
        graphicsDrawable = new GraphicsDrawable();
        this.Drawable = graphicsDrawable;
        this.StartInteraction += SignatureView_StartInteraction;
        this.DragInteraction += SignatureView_DragInteraction;
        this.EndInteraction += SignatureView_EndInteraction;
    }
    private void SignatureView_EndInteraction(object sender, TouchEventArgs e)
    {
        // Clear signature touch points. 
        //graphicsDrawable.DragPoints.Clear();
        this.Invalidate();
    }

    private void SignatureView_DragInteraction(object sender, TouchEventArgs e)
    {
        graphicsDrawable.DragPoints.Add(e.Touches[0]);
        this.Invalidate();
    }

    private void SignatureView_StartInteraction(object sender, TouchEventArgs e)
    {
        graphicsDrawable.StartPoint = e.Touches[0];
        this.Invalidate();
    }
}

public class GraphicsDrawable : IDrawable
{
    public PointF StartPoint { get; set; }
    public List<PointF> DragPoints { get; set; } = new List<PointF>();
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        // Draw background 
        canvas.FillColor = Colors.CornflowerBlue;
        canvas.FillRectangle(dirtyRect);

        // Draw signature
        PathF path = new PathF();
        if (DragPoints?.Count > 0)
        {
            path.MoveTo(StartPoint.X, StartPoint.Y);
            foreach (var point in DragPoints)
            {
                path.LineTo(point);
            }
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 2;

            canvas.DrawPath(path);
        }
    }
}

