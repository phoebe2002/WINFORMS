namespace WinFormsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            drawArea = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea;
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.LightBlue);
            }
            //an alternative
            //Graphics graphics = Graphics.FromImage(drawArea);
            //graphics.Clear(Color.LightBlue);
            //graphics.Dispose(); 
            pen = new Pen(Brushes.Black, 3);
            dashedPen = new Pen(Brushes.Black, 3);
            dashedPen.DashPattern = new float[] { 2, 1 };
        }

        private Bitmap drawArea;
        private const int RADIUS = 10;
        private Pen pen;
        private Pen dashedPen;

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //using(Graphics g = Graphics.FromImage(drawArea))
            //{
            //    g.FillEllipse(Brushes.White, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            //}
            //Canvas.Refresh();

            //new part
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.FillEllipse(Brushes.White, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                    g.DrawEllipse(pen, e.X - RADIUS, e.Y - RADIUS, RADIUS*2, RADIUS * 2);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.FillEllipse(Brushes.White, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                    g.DrawEllipse(dashedPen, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                }
            }
            Canvas.Refresh();

        }
        }
}