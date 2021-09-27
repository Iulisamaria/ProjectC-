namespace ProiectBD
{
    partial class Retete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retete));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numeretetatxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new ProiectBD.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxdesc = new System.Windows.Forms.CheckBox();
            this.checkBoxasc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(143, 227);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 61);
            this.button3.TabIndex = 34;
            this.button3.Text = "Editare";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(143, 315);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 63);
            this.button2.TabIndex = 33;
            this.button2.Text = "Sterege";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.SystemColors.GrayText;
            this.t.Location = new System.Drawing.Point(45, 315);
            this.t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(89, 63);
            this.t.TabIndex = 32;
            this.t.Text = "Afisare";
            this.t.UseVisualStyleBackColor = false;
            this.t.Click += new System.EventHandler(this.t_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(45, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 61);
            this.button1.TabIndex = 31;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nume_Reteta";
            // 
            // numeretetatxt
            // 
            this.numeretetatxt.Location = new System.Drawing.Point(45, 153);
            this.numeretetatxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numeretetatxt.Name = "numeretetatxt";
            this.numeretetatxt.Size = new System.Drawing.Size(193, 27);
            this.numeretetatxt.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(251, 568);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 42;
            // 
            // checkBoxdesc
            // 
            this.checkBoxdesc.AutoSize = true;
            this.checkBoxdesc.Location = new System.Drawing.Point(47, 498);
            this.checkBoxdesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxdesc.Name = "checkBoxdesc";
            this.checkBoxdesc.Size = new System.Drawing.Size(110, 23);
            this.checkBoxdesc.TabIndex = 46;
            this.checkBoxdesc.Text = "Sort Z to A";
            this.checkBoxdesc.UseVisualStyleBackColor = true;
            this.checkBoxdesc.CheckedChanged += new System.EventHandler(this.checkBoxdesc_CheckedChanged);
            // 
            // checkBoxasc
            // 
            this.checkBoxasc.AutoSize = true;
            this.checkBoxasc.Location = new System.Drawing.Point(47, 426);
            this.checkBoxasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxasc.Name = "checkBoxasc";
            this.checkBoxasc.Size = new System.Drawing.Size(110, 23);
            this.checkBoxasc.TabIndex = 45;
            this.checkBoxasc.Text = "Sort A to Z";
            this.checkBoxasc.UseVisualStyleBackColor = true;
            this.checkBoxasc.CheckedChanged += new System.EventHandler(this.checkBoxasc_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Retete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(180, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 43;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Retete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 732);
            this.Controls.Add(this.checkBoxdesc);
            this.Controls.Add(this.checkBoxasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numeretetatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Retete";
            this.Text = "Retete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeretetatxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxdesc;
        private System.Windows.Forms.CheckBox checkBoxasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}