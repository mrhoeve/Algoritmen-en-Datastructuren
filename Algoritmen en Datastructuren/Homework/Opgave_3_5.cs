using System.Drawing;
using System.Windows.Forms;

namespace Algoritmen_en_Datastructuren.Homework
{
    public partial class Opgave_3_5 : Form
    {
        private PaintEventArgs paintEventArgs;
        private PictureBox pictureBox;

        public Opgave_3_5()
        {
            InitializeComponent();
            this.Height = this.Width;
            
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(0);
            pictureBox.BackColor = Color.LightGray;
            pictureBox.Paint += new PaintEventHandler(this.startPainting);
            Controls.Add(pictureBox);
        }

        private void startPainting(object sender, PaintEventArgs e)
        {
            paintEventArgs = e;
            draw(5, 400, 400, 350);
        }

        private void drawH(int x, int y, int size)
        {
            int x0 = x - size / 2;
            int x1 = x + size / 2;
            int y0 = y - size / 2;
            int y1 = y + size / 2;

            Pen pen = new Pen(Color.Blue, 3);
            paintEventArgs.Graphics.DrawLine(pen, x0, y0, x0, y1);      // Left vertical segment
            paintEventArgs.Graphics.DrawLine(pen, x1, y0, x1, y1);      // Right vertical segment
            paintEventArgs.Graphics.DrawLine(pen, x0, y, x1, y);        // connect the vertical segments

        }

        private void draw(int n, int x, int y, int size)
        {
            if (n == 0) return;
            drawH(x, y, size);

            int x0 = x - size / 2;
            int x1 = x + size / 2;
            int y0 = y - size / 2;
            int y1 = y + size / 2;

            // recursively draw 4 half-size H-trees of order n-1
            draw(n - 1, x0, y0, size / 2);    // lower left  H-tree
            draw(n - 1, x0, y1, size / 2);    // upper left  H-tree
            draw(n - 1, x1, y0, size / 2);    // lower right H-tree
            draw(n - 1, x1, y1, size / 2);    // upper right H-tree
        }
    }
}
