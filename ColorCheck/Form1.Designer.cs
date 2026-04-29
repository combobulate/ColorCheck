namespace ColorCheck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            SelectImage = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewColors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewColors).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files(*.gif;*.jpg;*.png)|*.gif;*.jpg;*.png";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Choose image to analyze";
            // 
            // SelectImage
            // 
            SelectImage.Location = new Point(43, 41);
            SelectImage.Name = "SelectImage";
            SelectImage.Size = new Size(142, 49);
            SelectImage.TabIndex = 0;
            SelectImage.Text = "Select Image";
            SelectImage.UseVisualStyleBackColor = true;
            SelectImage.Click += SelectImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 303);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewColors
            // 
            dataGridViewColors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColors.Location = new Point(404, 109);
            dataGridViewColors.Name = "dataGridViewColors";
            dataGridViewColors.Size = new Size(394, 303);
            dataGridViewColors.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 453);
            Controls.Add(dataGridViewColors);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(SelectImage);
            Name = "Form1";
            Text = "Color Checker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewColors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button SelectImage;
        private Label label1;
        private PictureBox pictureBox1;
        //private Label imageColorSummary;
        private DataGridView dataGridViewColors;
    }
}
