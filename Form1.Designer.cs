namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIGURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDACTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGECOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicPanel = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIGURAToolStripMenuItem,
            this.fILEToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1485, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIGURAToolStripMenuItem
            // 
            this.fIGURAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOINTToolStripMenuItem,
            this.lINEToolStripMenuItem,
            this.pLEXToolStripMenuItem});
            this.fIGURAToolStripMenuItem.Name = "fIGURAToolStripMenuItem";
            this.fIGURAToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.fIGURAToolStripMenuItem.Text = "FIGURA";
            // 
            // pOINTToolStripMenuItem
            // 
            this.pOINTToolStripMenuItem.Name = "pOINTToolStripMenuItem";
            this.pOINTToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.pOINTToolStripMenuItem.Text = "POINT";
            this.pOINTToolStripMenuItem.Click += new System.EventHandler(this.pOINTToolStripMenuItem_Click);
            // 
            // lINEToolStripMenuItem
            // 
            this.lINEToolStripMenuItem.Name = "lINEToolStripMenuItem";
            this.lINEToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.lINEToolStripMenuItem.Text = "LINE";
            this.lINEToolStripMenuItem.Click += new System.EventHandler(this.lINEToolStripMenuItem_Click);
            // 
            // pLEXToolStripMenuItem
            // 
            this.pLEXToolStripMenuItem.Name = "pLEXToolStripMenuItem";
            this.pLEXToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.pLEXToolStripMenuItem.Text = "PLEX";
            this.pLEXToolStripMenuItem.Click += new System.EventHandler(this.pLEXToolStripMenuItem_Click);
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVEToolStripMenuItem,
            this.lOADToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // lOADToolStripMenuItem
            // 
            this.lOADToolStripMenuItem.Name = "lOADToolStripMenuItem";
            this.lOADToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.lOADToolStripMenuItem.Text = "LOAD";
            this.lOADToolStripMenuItem.Click += new System.EventHandler(this.lOADToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEDACTToolStripMenuItem,
            this.cLEARToolStripMenuItem,
            this.cHANGECOLORToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem1.Text = "FUNCTIONS";
            // 
            // rEDACTToolStripMenuItem
            // 
            this.rEDACTToolStripMenuItem.Name = "rEDACTToolStripMenuItem";
            this.rEDACTToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.rEDACTToolStripMenuItem.Text = "REDACT";
            this.rEDACTToolStripMenuItem.Click += new System.EventHandler(this.rEDACTToolStripMenuItem_Click);
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // cHANGECOLORToolStripMenuItem
            // 
            this.cHANGECOLORToolStripMenuItem.Name = "cHANGECOLORToolStripMenuItem";
            this.cHANGECOLORToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.cHANGECOLORToolStripMenuItem.Text = "CHANGE COLOR";
            this.cHANGECOLORToolStripMenuItem.Click += new System.EventHandler(this.cHANGECOLORToolStripMenuItem_Click);
            // 
            // GraphicPanel
            // 
            this.GraphicPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GraphicPanel.Location = new System.Drawing.Point(0, 33);
            this.GraphicPanel.Margin = new System.Windows.Forms.Padding(4);
            this.GraphicPanel.Name = "GraphicPanel";
            this.GraphicPanel.Size = new System.Drawing.Size(1005, 616);
            this.GraphicPanel.TabIndex = 1;
            this.GraphicPanel.TabStop = false;
            this.GraphicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphicPanel_MouseDown);
            this.GraphicPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphicPanel_MouseMove);
            this.GraphicPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphicPanel_MouseUp);
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorButton.Location = new System.Drawing.Point(1012, 33);
            this.colorButton.Margin = new System.Windows.Forms.Padding(4);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(259, 94);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Change color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(1013, 155);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(93, 39);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "plex";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Plex";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(656, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1020, 209);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(453, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1276, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1013, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1012, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 75);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1012, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "Redact";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 725);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.GraphicPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox GraphicPanel;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fIGURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lINEToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem pLEXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOADToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEDACTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHANGECOLORToolStripMenuItem;
    }
}

