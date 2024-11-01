namespace MusicLab.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // tbSearch
            this.tbSearch.Location = new System.Drawing.Point(90, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(300, 23);
            this.tbSearch.TabIndex = 0;

            // cbSearchType
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Location = new System.Drawing.Point(90, 60);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(300, 23);
            this.cbSearchType.TabIndex = 1;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(400, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnAddArtist
            this.btnAddArtist.Location = new System.Drawing.Point(20, 100);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(120, 30);
            this.btnAddArtist.TabIndex = 3;
            this.btnAddArtist.Text = "Добавить Артиста";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);

            // btnAddAlbum
            this.btnAddAlbum.Location = new System.Drawing.Point(150, 100);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(120, 30);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Добавить Альбом";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);

            // btnAddTrack
            this.btnAddTrack.Location = new System.Drawing.Point(280, 100);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(120, 30);
            this.btnAddTrack.TabIndex = 5;
            this.btnAddTrack.Text = "Добавить Трек";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(410, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // lbResults
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 15;
            this.lbResults.Location = new System.Drawing.Point(20, 150);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(510, 214);
            this.lbResults.TabIndex = 7;

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Поиск:";

            // lblSearchType
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(20, 63);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(70, 15);
            this.lblSearchType.TabIndex = 9;
            this.lblSearchType.Text = "Тип поиска:";

            // MainForm
            this.ClientSize = new System.Drawing.Size(554, 391);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.btnAddTrack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblSearchType);
            this.Name = "MainForm";
            this.Text = "Музыкальный каталог";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
