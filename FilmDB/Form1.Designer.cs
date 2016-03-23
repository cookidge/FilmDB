namespace FilmDB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilmTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddFilm = new System.Windows.Forms.Button();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.txt_FilmName = new System.Windows.Forms.TextBox();
            this.lab_Year = new System.Windows.Forms.Label();
            this.lab_Title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_SearchType = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_ViewAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ViewImdb = new System.Windows.Forms.Button();
            this.info_Plot = new System.Windows.Forms.RichTextBox();
            this.info_Director = new System.Windows.Forms.Label();
            this.info_TitleAndYear = new System.Windows.Forms.Label();
            this.posterBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.FilmTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmTable
            // 
            this.FilmTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.FilmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FilmTable.GridColor = System.Drawing.Color.DimGray;
            this.FilmTable.Location = new System.Drawing.Point(654, 11);
            this.FilmTable.Name = "FilmTable";
            this.FilmTable.RowTemplate.Height = 24;
            this.FilmTable.Size = new System.Drawing.Size(560, 533);
            this.FilmTable.TabIndex = 0;
            this.FilmTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmTable_RowEnter);
            this.FilmTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FilmTable_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.btn_AddFilm);
            this.groupBox1.Controls.Add(this.cmb_Year);
            this.groupBox1.Controls.Add(this.txt_FilmName);
            this.groupBox1.Controls.Add(this.lab_Year);
            this.groupBox1.Controls.Add(this.lab_Title);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Film";
            // 
            // btn_AddFilm
            // 
            this.btn_AddFilm.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddFilm.ForeColor = System.Drawing.Color.White;
            this.btn_AddFilm.Location = new System.Drawing.Point(522, 56);
            this.btn_AddFilm.Name = "btn_AddFilm";
            this.btn_AddFilm.Size = new System.Drawing.Size(96, 31);
            this.btn_AddFilm.TabIndex = 9;
            this.btn_AddFilm.Text = "Add Film";
            this.btn_AddFilm.UseVisualStyleBackColor = false;
            this.btn_AddFilm.Click += new System.EventHandler(this.btn_AddFilm_Click);
            this.btn_AddFilm.MouseEnter += new System.EventHandler(this.btn_AddFilm_MouseEnter);
            this.btn_AddFilm.MouseLeave += new System.EventHandler(this.btn_AddFilm_MouseLeave);
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.ItemHeight = 16;
            this.cmb_Year.Location = new System.Drawing.Point(126, 60);
            this.cmb_Year.MaxDropDownItems = 5;
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(78, 24);
            this.cmb_Year.TabIndex = 8;
            // 
            // txt_FilmName
            // 
            this.txt_FilmName.Location = new System.Drawing.Point(126, 29);
            this.txt_FilmName.Name = "txt_FilmName";
            this.txt_FilmName.Size = new System.Drawing.Size(368, 22);
            this.txt_FilmName.TabIndex = 4;
            // 
            // lab_Year
            // 
            this.lab_Year.AutoSize = true;
            this.lab_Year.Location = new System.Drawing.Point(22, 60);
            this.lab_Year.Name = "lab_Year";
            this.lab_Year.Size = new System.Drawing.Size(98, 17);
            this.lab_Year.TabIndex = 1;
            this.lab_Year.Text = "Release Year:";
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Location = new System.Drawing.Point(42, 29);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(78, 17);
            this.lab_Title.TabIndex = 0;
            this.lab_Title.Text = "Film Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.cmb_SearchType);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Film";
            // 
            // cmb_SearchType
            // 
            this.cmb_SearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchType.FormattingEnabled = true;
            this.cmb_SearchType.Items.AddRange(new object[] {
            "TITLE",
            "YEAR",
            "DIRECTOR",
            "WRITER",
            "GENRE"});
            this.cmb_SearchType.Location = new System.Drawing.Point(244, 27);
            this.cmb_SearchType.Name = "cmb_SearchType";
            this.cmb_SearchType.Size = new System.Drawing.Size(138, 24);
            this.cmb_SearchType.TabIndex = 12;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DimGray;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(388, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 31);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseEnter += new System.EventHandler(this.btn_Search_MouseEnter);
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_Search_MouseLeave);
            // 
            // txt_Search
            // 
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.Location = new System.Drawing.Point(22, 27);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(216, 22);
            this.txt_Search.TabIndex = 5;
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.BackColor = System.Drawing.Color.DimGray;
            this.btn_ViewAll.ForeColor = System.Drawing.Color.White;
            this.btn_ViewAll.Location = new System.Drawing.Point(534, 135);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(96, 31);
            this.btn_ViewAll.TabIndex = 13;
            this.btn_ViewAll.Text = "View All";
            this.btn_ViewAll.UseVisualStyleBackColor = false;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_ViewAll_Click);
            this.btn_ViewAll.MouseEnter += new System.EventHandler(this.btn_ViewAll_MouseEnter);
            this.btn_ViewAll.MouseLeave += new System.EventHandler(this.btn_ViewAll_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.btn_ViewImdb);
            this.groupBox3.Controls.Add(this.info_Plot);
            this.groupBox3.Controls.Add(this.info_Director);
            this.groupBox3.Controls.Add(this.info_TitleAndYear);
            this.groupBox3.Controls.Add(this.posterBox);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 357);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Info";
            // 
            // btn_ViewImdb
            // 
            this.btn_ViewImdb.BackColor = System.Drawing.Color.DimGray;
            this.btn_ViewImdb.ForeColor = System.Drawing.Color.White;
            this.btn_ViewImdb.Location = new System.Drawing.Point(22, 300);
            this.btn_ViewImdb.Name = "btn_ViewImdb";
            this.btn_ViewImdb.Size = new System.Drawing.Size(316, 40);
            this.btn_ViewImdb.TabIndex = 4;
            this.btn_ViewImdb.Text = "IMDB: ";
            this.btn_ViewImdb.UseVisualStyleBackColor = false;
            this.btn_ViewImdb.Click += new System.EventHandler(this.btn_ViewImdb_Click);
            this.btn_ViewImdb.MouseEnter += new System.EventHandler(this.btn_ViewImdb_MouseEnter);
            this.btn_ViewImdb.MouseLeave += new System.EventHandler(this.btn_ViewImdb_MouseLeave);
            // 
            // info_Plot
            // 
            this.info_Plot.BackColor = System.Drawing.Color.DimGray;
            this.info_Plot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_Plot.ForeColor = System.Drawing.Color.White;
            this.info_Plot.Location = new System.Drawing.Point(22, 104);
            this.info_Plot.Name = "info_Plot";
            this.info_Plot.Size = new System.Drawing.Size(316, 161);
            this.info_Plot.TabIndex = 3;
            this.info_Plot.Text = "";
            // 
            // info_Director
            // 
            this.info_Director.AutoSize = true;
            this.info_Director.ForeColor = System.Drawing.Color.White;
            this.info_Director.Location = new System.Drawing.Point(19, 68);
            this.info_Director.Name = "info_Director";
            this.info_Director.Size = new System.Drawing.Size(58, 17);
            this.info_Director.TabIndex = 2;
            this.info_Director.Text = "Director";
            // 
            // info_TitleAndYear
            // 
            this.info_TitleAndYear.AutoSize = true;
            this.info_TitleAndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_TitleAndYear.ForeColor = System.Drawing.Color.White;
            this.info_TitleAndYear.Location = new System.Drawing.Point(17, 28);
            this.info_TitleAndYear.Name = "info_TitleAndYear";
            this.info_TitleAndYear.Size = new System.Drawing.Size(133, 29);
            this.info_TitleAndYear.TabIndex = 1;
            this.info_TitleAndYear.Text = "Film (Year)";
            // 
            // posterBox
            // 
            this.posterBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.posterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posterBox.Location = new System.Drawing.Point(356, 16);
            this.posterBox.Name = "posterBox";
            this.posterBox.Size = new System.Drawing.Size(262, 324);
            this.posterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterBox.TabIndex = 0;
            this.posterBox.TabStop = false;
            this.posterBox.WaitOnLoad = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1224, 558);
            this.Controls.Add(this.btn_ViewAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilmTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "FilmDB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FilmTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_Year;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.TextBox txt_FilmName;
        private System.Windows.Forms.Button btn_AddFilm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox posterBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label info_Director;
        private System.Windows.Forms.Label info_TitleAndYear;
        private System.Windows.Forms.RichTextBox info_Plot;
        private System.Windows.Forms.Button btn_ViewImdb;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_SearchType;
        private System.Windows.Forms.Button btn_ViewAll;
    }
}

