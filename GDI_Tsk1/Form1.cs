using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GDI_Tsk1
{
    public partial class Form1 : Form
    {
        private Rectangle[,] _chessBoardPanels;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            _chessBoardPanels= new Rectangle[8,8];
            g = this.CreateGraphics();
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
            string FullPath = Path.GetFullPath("assets");
            Bitmap[] myBitmap = new Bitmap[]{new Bitmap(@FullPath+"/RookYellow.bmp"),
                    new Bitmap(@FullPath+"/KnightYellow.bmp"), new Bitmap(@FullPath + "/BishopYellow.bmp"),
                    new Bitmap(@FullPath + "/QueenYellow.bmp"),  new Bitmap(@FullPath + "/KingYellow.bmp"),
                    new Bitmap(@FullPath + "/BishopYellow.bmp"),  new Bitmap(@FullPath + "/KnightYellow.bmp"),
                    new Bitmap(@FullPath + "/RookYellow.bmp"), new Bitmap(@FullPath + "/PawnYellow.bmp")
                    };
            const int tileSize = 60;
            float gridSize = 1F;
            var clr1 = Color.SaddleBrown;
            var clr2 = Color.Chocolate;
            Pen pen1 = new Pen(clr1, gridSize);
            g.DrawRectangle(pen1, new Rectangle(2, 2, 600, 600));
            Brush brush1 = new SolidBrush(Color.SaddleBrown);
            Region region = new Region(new Rectangle(1, 1, 600, 600));
            Font drawFont = new Font("Arial", 16);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            StringFormat drawFormat2 = new StringFormat();
            drawFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.FillRegion(brush1, region);
            this.Text = "Chess";
            for (var n = 1; n < 9; n++)
            {
                for (var m = 1; m < 9; m++)
                {
                    Rectangle newPanel = new Rectangle
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m)

                    };
                    if ((n + m) % 2 == 0)
                    {
                        using (Brush brush = new SolidBrush(clr2))
                        {
                            Pen pen = new Pen(clr2);
                            g.DrawRectangle(pen, newPanel);
                            g.FillRectangle(brush, newPanel);
                        }
                    }
                    else
                    {
                        using (Brush brush = new SolidBrush(clr1))
                        {
                            Pen pen = new Pen(clr1);
                            g.DrawRectangle(pen, newPanel);
                            g.FillRectangle(brush, newPanel);
                        }
                    }
                    g.DrawRectangle(new Pen(Color.White), new Rectangle(50, 50, 500, 500));
                }
                g.DrawString($"{n.ToString()}", drawFont, new SolidBrush(Color.White), 10, 65 * n, drawFormat);
                g.DrawString($"{n.ToString()}", drawFont, new SolidBrush(Color.White), 550, 65 * n, drawFormat);
                g.DrawString(Convert.ToString((char)('a' + n-1)), drawFont, new SolidBrush(Color.White),70*n, 10, drawFormat2);
                g.DrawString(Convert.ToString((char)('a' + n - 1)), drawFont, new SolidBrush(Color.White), 70 * n, 550, drawFormat2);
            }
            g.DrawImage(myBitmap[0], 60, 50, 70, 70);
            g.DrawImage(myBitmap[0], 60, 470, 70, 70);
            g.DrawImage(myBitmap[8], 60, 110, 60, 60);
            g.DrawImage(myBitmap[8], 60, 400, 60, 60);
            for (int i = 1; i <8; i++)
            {
                g.DrawImage(myBitmap[i], 60 *( i+1), 50, 70, 70);
                g.DrawImage(myBitmap[8], 60 * (i + 1), 110, 60, 60);
                g.DrawImage(myBitmap[i], 60 * (i + 1), 470, 70, 70);
                g.DrawImage(myBitmap[8], 60 * (i + 1), 400, 60, 60);
            }
            g.Dispose();
        }
    }
} 