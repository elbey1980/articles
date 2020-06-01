namespace ClientConsultationArticleWCF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.likes = new System.Windows.Forms.Button();
            this.dislikes = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayall = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.searchMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(564, 90);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(28, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(564, 161);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            // 
            // likes
            // 
            this.likes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.likes.Location = new System.Drawing.Point(671, 111);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(75, 23);
            this.likes.TabIndex = 4;
            this.likes.Text = "Like";
            this.likes.UseVisualStyleBackColor = true;
            this.likes.Click += new System.EventHandler(this.likes_Click);
            // 
            // dislikes
            // 
            this.dislikes.ForeColor = System.Drawing.Color.Red;
            this.dislikes.Location = new System.Drawing.Point(671, 165);
            this.dislikes.Name = "dislikes";
            this.dislikes.Size = new System.Drawing.Size(75, 23);
            this.dislikes.TabIndex = 5;
            this.dislikes.Text = "Dislike";
            this.dislikes.UseVisualStyleBackColor = true;
            this.dislikes.Click += new System.EventHandler(this.dislikes_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(671, 240);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(671, 366);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 8;
            this.Quit.Text = "Close";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "list of articles";
            // 
            // displayall
            // 
            this.displayall.Location = new System.Drawing.Point(671, 46);
            this.displayall.Name = "displayall";
            this.displayall.Size = new System.Drawing.Size(75, 23);
            this.displayall.TabIndex = 10;
            this.displayall.Text = "All Articles";
            this.displayall.UseVisualStyleBackColor = true;
            this.displayall.Click += new System.EventHandler(this.displayall_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(222, 345);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 11;
            this.search.Text = "local Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(671, 299);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // searchMode
            // 
            this.searchMode.AutoSize = true;
            this.searchMode.Location = new System.Drawing.Point(28, 378);
            this.searchMode.Name = "searchMode";
            this.searchMode.Size = new System.Drawing.Size(105, 17);
            this.searchMode.TabIndex = 14;
            this.searchMode.Text = "dataBaseSearch";
            this.searchMode.UseVisualStyleBackColor = true;
            this.searchMode.CheckStateChanged += new System.EventHandler(this.searchMode_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(799, 407);
            this.Controls.Add(this.searchMode);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.displayall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dislikes);
            this.Controls.Add(this.likes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation Articles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button likes;
        private System.Windows.Forms.Button dislikes;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayall;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.CheckBox searchMode;
    }
}

