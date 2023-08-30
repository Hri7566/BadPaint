using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace BadPaint
{
    public partial class frmBadPaint : Form
    {
        public Graphics graphics;

        public Pen pen1;
        public Pen pen2;
        public Pen currentPen;
        
        public int cursorX, cursorY = -1;
        public bool mouseHeld = false;
        public int lineWidth = 7;

        public List<List<Color>> palettes;
        public List<PictureBox> paletteBoxes;

        public Bitmap imageBuffer;

        public frmBadPaint()
        {
            InitializeComponent();

            // Setup image buffer
            imageBuffer = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);

            // Setup graphics
            // graphics = pnlCanvas.CreateGraphics();
            graphics = Graphics.FromImage(imageBuffer);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Setup pens
            pen1 = new Pen(Color.Black, lineWidth);
            pen1.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen1.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pen2 = new Pen(Color.White, lineWidth);
            pen2.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen2.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Setup palette controls
            paletteBoxes = new List<PictureBox>
            {
                boxPalette1,
                boxPalette2,
                boxPalette3,
                boxPalette4,
                boxPalette5,
                boxPalette6,
                boxPalette7,
                boxPalette8,
                boxPalette9,
                boxPalette10,
                boxPalette11,
                boxPalette12,
                boxPalette13,
                boxPalette14,
                boxPalette15,
                boxPalette16
            };

            // Setup palettes
            palettes = new List<List<Color>>();
            addPalettes();
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHeld = true;

            if (e.Button == MouseButtons.Right)
            {
                // Use secondary pen
                currentPen = pen2;
            }
            else
            {
                // Use primary pen
                currentPen = pen1;
            }

            cursorX = e.X;
            cursorY = e.Y;
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHeld = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && mouseHeld)
            {
                // Draw line
                graphics.DrawLine(currentPen, new Point(cursorX, cursorY), e.Location);

                cursorX = e.X;
                cursorY = e.Y;

                // Redraw
                Graphics pnlgfx = pnlCanvas.CreateGraphics();
                pnlgfx.DrawImage(imageBuffer, 0, 0);
                pnlgfx.Dispose();
            }
        }

        private void nudLineWidth_ValueChanged(object sender, EventArgs e)
        {
            // Change line width to new value
            lineWidth = (int)nudLineWidth.Value;
            pen1.Width = lineWidth;
            pen2.Width = lineWidth;
        }

        private void boxFill_MouseDown(object sender, MouseEventArgs e)
        {
            // Fill canvas with pen
            if (e.Button == MouseButtons.Right)
            {
                // Fill with secondary color
                graphics.FillRectangle(pen2.Brush, Rectangle.FromLTRB(0, 0, pnlCanvas.Width, pnlCanvas.Height));
            }
            else
            {
                // Fill with primary color
                graphics.FillRectangle(pen1.Brush, Rectangle.FromLTRB(0, 0, pnlCanvas.Width, pnlCanvas.Height));
            }

            // Redraw
            Graphics pnlgfx = pnlCanvas.CreateGraphics();
            pnlgfx.DrawImage(imageBuffer, 0, 0);
            pnlgfx.Dispose();
        }

        private void frmBadPaint_Load(object sender, EventArgs e)
        {
            // Draw selected colors
            updateSelectedColors();

            // Draw palette
            loadPalette(0);
        }

        public void updateSelectedColors()
        {
            // Update selected color boxes
            boxPaletteSelected1.BackColor = pen1.Color;
            boxPaletteSelected2.BackColor = pen2.Color;
        }

        private void nudPaletteNum_ValueChanged(object sender, EventArgs e)
        {
            // Change palette to value
            NumericUpDown nud = (NumericUpDown)sender;
            loadPalette((int)nud.Value);
        }

        private void box_palette_MouseDown(object sender, MouseEventArgs e)
        {
            // Change pen color
            PictureBox paletteBox = (PictureBox)sender;

            if (e.Button == MouseButtons.Right)
            {
                // Change secondary pen
                pen2.Color = paletteBox.BackColor;
            }
            else
            {
                // Change primary pen
                pen1.Color = paletteBox.BackColor;
            }

            updateSelectedColors();
        }

        public void loadPalette(int paletteNum)
        {
            // Load color palette

            if (paletteNum < 0)
            {
                paletteNum = palettes.Count - 1;
            }

            if (paletteNum >= palettes.Count)
            {
                paletteNum = 0;
            }

            for (int i = 0; i < 16; i++)
            {
                if (i < palettes[paletteNum].Count)
                {
                    if (palettes[paletteNum][i] != null)
                    {
                        paletteBoxes[i].Enabled = true;
                        paletteBoxes[i].Visible = true;
                        paletteBoxes[i].BackColor = palettes[paletteNum][i];
                    }
                    else
                    {
                        paletteBoxes[i].Enabled = false;
                        paletteBoxes[i].Visible = false;
                        paletteBoxes[i].BackColor = Color.Black;
                    }
                }
                else
                {
                    paletteBoxes[i].Enabled = false;
                    paletteBoxes[i].Visible = false;
                    paletteBoxes[i].BackColor = Color.Black;
                }
            }

            nudPaletteNum.Value = paletteNum;
        }

        private void boxSave_Click(object sender, EventArgs e)
        {
            dlgSave = new SaveFileDialog();
            dlgSave.Filter = "PNG Image|*.png";
            dlgSave.Title = "Save an Image File";
            dlgSave.ShowDialog();

            if (dlgSave.FileName != "")
            {
                pnlCanvas.DrawToBitmap(imageBuffer, new Rectangle(0, 0, pnlCanvas.Width, pnlCanvas.Height));
                imageBuffer.Save(dlgSave.FileName, ImageFormat.Png);
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageBuffer, 0, 0);
        }

        private void btnChangeCustomColor_Click(object sender, EventArgs e)
        {
            dlgCustomPalette.ShowDialog();

            if (dlgCustomPalette.Color != null)
            {
                boxPaletteCustom.BackColor = dlgCustomPalette.Color;
            }
        }

        private void boxOpen_Click(object sender, EventArgs e)
        {
            // Open file and read data to bitmap
            dlgOpen.ShowDialog();

            if (dlgOpen.FileName != "")
            {
                // Load image buffer
                imageBuffer = new Bitmap(dlgOpen.FileName);

                // Setup graphics again
                graphics = Graphics.FromImage(imageBuffer);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Redraw
                Graphics pnlgfx = pnlCanvas.CreateGraphics();
                pnlgfx.DrawImage(imageBuffer, 0, 0);
                pnlgfx.Dispose();
            }
        }

        public void addPalettes()
        {
            // HTML
            palettes.Add(new List<Color> { Color.White, Color.Silver, Color.Gray, Color.Black, Color.Red, Color.Maroon, Color.Yellow, Color.Olive, Color.Lime, Color.Green, Color.Aqua, Color.Teal, Color.Blue, Color.Navy, Color.Fuchsia, Color.Purple });

            // Pinks and Reds
            palettes.Add(new List<Color> {
                Color.MediumVioletRed, Color.DeepPink, Color.PaleVioletRed, Color.HotPink, Color.LightPink, Color.Pink,
                Color.DarkRed, Color.Firebrick, Color.Crimson, Color.IndianRed, Color.LightCoral, Color.Salmon, Color.DarkSalmon, Color.LightSalmon
            });

            // Oranges and Yellows
            palettes.Add(new List<Color>
            {
                Color.OrangeRed, Color.Tomato, Color.DarkOrange, Color.Coral, Color.Orange,

                Color.DarkKhaki, Color.Gold, Color.Khaki,
                Color.PeachPuff, Color.PaleGoldenrod,
                Color.Moccasin, Color.PapayaWhip,
                Color.LightGoldenrodYellow, Color.LemonChiffon,
                Color.LightYellow
            });

            // Browns #1
            palettes.Add(new List<Color>
            {
                Color.Maroon, Color.Brown, Color.SaddleBrown, Color.Sienna, Color.Chocolate, Color.DarkGoldenrod,
                Color.Peru, Color.RosyBrown, Color.Goldenrod
            });

            // Browns #2
            palettes.Add(new List<Color>
            {
                Color.SandyBrown, Color.Tan, Color.BurlyWood, Color.Wheat, Color.NavajoWhite, Color.Bisque,
                Color.BlanchedAlmond, Color.Cornsilk
            });

            // Purples
            palettes.Add(new List<Color>
            {
                Color.Indigo, Color.DarkMagenta, Color.DarkViolet, Color.DarkSlateBlue, Color.BlueViolet, Color.DarkOrchid,
                Color.SlateBlue, Color.MediumSlateBlue, Color.MediumOrchid, Color.MediumPurple, Color.Orchid,
                Color.Violet, Color.Plum, Color.Thistle, Color.Lavender
            });

            // Blues
            palettes.Add(new List<Color>
            {
                Color.MidnightBlue, Color.Navy, Color.DarkBlue, Color.MediumBlue, Color.RoyalBlue, Color.SteelBlue,
                Color.DodgerBlue, Color.DeepSkyBlue, Color.CornflowerBlue, Color.SkyBlue, Color.LightSkyBlue,
                Color.LightSteelBlue, Color.LightBlue, Color.PowderBlue
            });

            // Cyans
            palettes.Add(new List<Color>
            {
                Color.DarkCyan, Color.LightSeaGreen, Color.CadetBlue, Color.DarkTurquoise, Color.MediumTurquoise,
                Color.Turquoise, Color.Aqua, Color.Cyan, Color.Aquamarine, Color.PaleTurquoise, Color.LightCyan
            });

            // Greens #1
            palettes.Add(new List<Color>
            {
                Color.DarkGreen, Color.DarkOliveGreen, Color.ForestGreen, Color.SeaGreen, Color.OliveDrab, Color.MediumSeaGreen,
                Color.LimeGreen, Color.SpringGreen, Color.MediumSpringGreen
            });

            // Greens #2
            palettes.Add(new List<Color>
            {
                Color.DarkSeaGreen, Color.MediumAquamarine,
                Color.YellowGreen, Color.LawnGreen, Color.Chartreuse, Color.LightGreen, Color.GreenYellow, Color.PaleGreen
            });

            // Whites
            palettes.Add(new List<Color>
            {
                Color.MistyRose, Color.AntiqueWhite, Color.Linen, Color.Beige, Color.WhiteSmoke, Color.LavenderBlush,
                Color.OldLace, Color.AliceBlue, Color.SeaShell, Color.GhostWhite, Color.Honeydew, Color.FloralWhite,
                Color.Azure, Color.MintCream, Color.Snow, Color.Ivory
            });

            // Grays and blacks
            palettes.Add(new List<Color>
            {
                Color.DarkSlateGray, Color.DimGray, Color.SlateGray, Color.LightSlateGray, Color.DarkGray, Color.LightGray, Color.Gainsboro
            });
        }
    }
}
