namespace ProiectBD
{
    partial class Materie_Prima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materie_Prima));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumire = new System.Windows.Forms.Label();
            this.um = new System.Windows.Forms.Label();
            this.cantitate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.denumiretxt = new System.Windows.Forms.TextBox();
            this.cantitatetxt = new System.Windows.Forms.TextBox();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.furnizor = new System.Windows.Forms.ComboBox();
            this.id_furnizor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oracleCommand2 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.t = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.filterfurnizor = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stoc = new System.Windows.Forms.CheckBox();
            this.umtxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 612);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // denumire
            // 
            this.denumire.AutoSize = true;
            this.denumire.Location = new System.Drawing.Point(46, 70);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(90, 19);
            this.denumire.TabIndex = 1;
            this.denumire.Text = "DENUMIRE";
            // 
            // um
            // 
            this.um.AutoSize = true;
            this.um.Location = new System.Drawing.Point(46, 260);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(35, 19);
            this.um.TabIndex = 2;
            this.um.Text = "UM";
            // 
            // cantitate
            // 
            this.cantitate.AutoSize = true;
            this.cantitate.Location = new System.Drawing.Point(46, 173);
            this.cantitate.Name = "cantitate";
            this.cantitate.Size = new System.Drawing.Size(93, 19);
            this.cantitate.TabIndex = 3;
            this.cantitate.Text = "CANTITATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nume Furnizor";
            // 
            // denumiretxt
            // 
            this.denumiretxt.Location = new System.Drawing.Point(47, 118);
            this.denumiretxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.denumiretxt.Name = "denumiretxt";
            this.denumiretxt.Size = new System.Drawing.Size(204, 27);
            this.denumiretxt.TabIndex = 5;
            this.denumiretxt.Enter += new System.EventHandler(this.comboBox1_Click);
            // 
            // cantitatetxt
            // 
            this.cantitatetxt.Location = new System.Drawing.Point(47, 215);
            this.cantitatetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cantitatetxt.Name = "cantitatetxt";
            this.cantitatetxt.Size = new System.Drawing.Size(204, 27);
            this.cantitatetxt.TabIndex = 6;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // furnizor
            // 
            this.furnizor.FormattingEnabled = true;
            this.furnizor.Location = new System.Drawing.Point(47, 387);
            this.furnizor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnizor.Name = "furnizor";
            this.furnizor.Size = new System.Drawing.Size(136, 27);
            this.furnizor.TabIndex = 8;
            this.furnizor.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // id_furnizor
            // 
            this.id_furnizor.FormattingEnabled = true;
            this.id_furnizor.Location = new System.Drawing.Point(204, 387);
            this.id_furnizor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_furnizor.Name = "id_furnizor";
            this.id_furnizor.Size = new System.Drawing.Size(136, 27);
            this.id_furnizor.TabIndex = 9;
            this.id_furnizor.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(47, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Transaction = null;
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.SystemColors.GrayText;
            this.t.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t.Location = new System.Drawing.Point(160, 444);
            this.t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(92, 61);
            this.t.TabIndex = 11;
            this.t.Text = "Afisare";
            this.t.UseVisualStyleBackColor = false;
            this.t.Click += new System.EventHandler(this.t_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(160, 532);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 59);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sterege";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 13;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(47, 532);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 59);
            this.button3.TabIndex = 14;
            this.button3.Text = "Editare";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Materii Prime";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(974, 143);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 23);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Sort Z to A";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(974, 65);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 23);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Sort A to Z";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // filterfurnizor
            // 
            this.filterfurnizor.FormattingEnabled = true;
            this.filterfurnizor.Location = new System.Drawing.Point(794, 24);
            this.filterfurnizor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterfurnizor.Name = "filterfurnizor";
            this.filterfurnizor.Size = new System.Drawing.Size(136, 27);
            this.filterfurnizor.TabIndex = 20;
            this.filterfurnizor.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(974, 275);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 27);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(970, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Furnizor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // stoc
            // 
            this.stoc.AutoSize = true;
            this.stoc.Location = new System.Drawing.Point(974, 349);
            this.stoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stoc.Name = "stoc";
            this.stoc.Size = new System.Drawing.Size(84, 23);
            this.stoc.TabIndex = 21;
            this.stoc.Text = "STOC 0";
            this.stoc.UseVisualStyleBackColor = true;
            this.stoc.CheckedChanged += new System.EventHandler(this.stoc_CheckedChanged);
            // 
            // umtxt
            // 
            this.umtxt.FormattingEnabled = true;
            this.umtxt.Items.AddRange(new object[] {
            "KG",
            "L",
            "BUC"});
            this.umtxt.Location = new System.Drawing.Point(47, 297);
            this.umtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.umtxt.Name = "umtxt";
            this.umtxt.Size = new System.Drawing.Size(136, 27);
            this.umtxt.TabIndex = 22;
            // 
            // Materie_Prima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 786);
            this.Controls.Add(this.umtxt);
            this.Controls.Add(this.stoc);
            this.Controls.Add(this.filterfurnizor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_furnizor);
            this.Controls.Add(this.furnizor);
            this.Controls.Add(this.cantitatetxt);
            this.Controls.Add(this.denumiretxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantitate);
            this.Controls.Add(this.um);
            this.Controls.Add(this.denumire);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Materie_Prima";
            this.Text = "Materie_Prima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label denumire;
        private System.Windows.Forms.Label um;
        private System.Windows.Forms.Label cantitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox denumiretxt;
        private System.Windows.Forms.TextBox cantitatetxt;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.ComboBox furnizor;
        private System.Windows.Forms.ComboBox id_furnizor;
        private System.Windows.Forms.Button button1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox filterfurnizor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox stoc;
        private System.Windows.Forms.ComboBox umtxt;
    }
}