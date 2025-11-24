using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class LineControl : Control
{
    private Color lineColor = Color.Black;

    [Category("Appearance")]
    public Color LineColor
    {
        get => lineColor;
        set { lineColor = value; Invalidate(); }
    }

    public LineControl()
    {
        this.Height = 2;
        this.Width = 100;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Pen pen = new Pen(lineColor, 2))
        {
            e.Graphics.DrawLine(pen,
                0, this.Height / 2,
                this.Width, this.Height / 2);
        }
    }
}
