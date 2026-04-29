using System;
namespace ColorCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                try
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    List<ColorCount> ColorList = new List<ColorCount>();

                    Bitmap bitmapImage = new Bitmap(openFileDialog1.FileName);
                    for (int i = 0; i < bitmapImage.Width; i++) {
                        for (int j = 0; j < bitmapImage.Height; j++) {
                            Color pixelColor = bitmapImage.GetPixel(i, j);
                            int colorFound = ColorList.FindIndex(x => x.imageColor == pixelColor);
                            if (colorFound == -1)
                            {
                                ColorCount newColor = new ColorCount();
                                newColor.imageColor = pixelColor;
                                newColor.colorCount = 1;
                                ColorList.Add(newColor);
                            }
                            else
                            {
                                ColorCount incColor = ColorList[colorFound];
                                incColor.colorCount++;
                                ColorList[colorFound] = incColor;
                            }
                        }
                    }

                    int imageSize = image.Height * image.Width;

                    for (int i = 0; i < ColorList.Count; i++) {
                        ColorCount colorUpdatePercent = ColorList[i];
                        colorUpdatePercent.colorPercent = (float)Math.Round(100 * (float)colorUpdatePercent.colorCount / imageSize, 2, MidpointRounding.AwayFromZero);
                        ColorList[i] = colorUpdatePercent;
                    }

                    dataGridViewColors.DataSource = ColorList;

                    DataGridViewColumn column = dataGridViewColors.Columns[1];
                    column.Width = 23;

                    dataGridViewColors.Columns[0].HeaderText = "RGB Value";
                    dataGridViewColors.Columns[1].HeaderText = "";
                    dataGridViewColors.Columns[2].HeaderText = "# Pixels";
                    dataGridViewColors.Columns[3].HeaderText = "% of Image";

                    foreach (DataGridViewRow row in dataGridViewColors.Rows) {
                        //set second column to show the color being reviewed
                        row.Cells[1].Style.BackColor = (Color)row.Cells[0].Value;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        struct ColorCount
        {
            public Color imageColor { get; set; }
            public String emptyCell { get; } // for display of color in dataGridView
            public int colorCount { get; set; }
            public float colorPercent { get; set; }
        }

        void SetPercent(ColorCount color)
        {

        }
    }

    
}
