namespace Compilador__clase
{
    partial class Form1
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
            this.lblmaintitle = new System.Windows.Forms.Label();
            this.rtbconsole = new System.Windows.Forms.RichTextBox();
            this.lblconsole = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.rtbout = new System.Windows.Forms.RichTextBox();
            this.cboxloadfile = new System.Windows.Forms.ComboBox();
            this.lblout = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnloadfile = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tboxpath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmaintitle
            // 
            this.lblmaintitle.AutoSize = true;
            this.lblmaintitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaintitle.Location = new System.Drawing.Point(49, 88);
            this.lblmaintitle.Name = "lblmaintitle";
            this.lblmaintitle.Size = new System.Drawing.Size(378, 31);
            this.lblmaintitle.TabIndex = 1;
            this.lblmaintitle.Text = "Origen del programa fuente:";
            // 
            // rtbconsole
            // 
            this.rtbconsole.Enabled = false;
            this.rtbconsole.Location = new System.Drawing.Point(78, 234);
            this.rtbconsole.Name = "rtbconsole";
            this.rtbconsole.Size = new System.Drawing.Size(349, 205);
            this.rtbconsole.TabIndex = 3;
            this.rtbconsole.Text = "";
            this.rtbconsole.Visible = false;
            // 
            // lblconsole
            // 
            this.lblconsole.AutoSize = true;
            this.lblconsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsole.Location = new System.Drawing.Point(72, 200);
            this.lblconsole.Name = "lblconsole";
            this.lblconsole.Size = new System.Drawing.Size(79, 24);
            this.lblconsole.TabIndex = 4;
            this.lblconsole.Text = "Consola";
            this.lblconsole.Visible = false;
            // 
            // btnload
            // 
            this.btnload.Enabled = false;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(456, 270);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(118, 52);
            this.btnload.TabIndex = 5;
            this.btnload.Text = "Cargar >>>";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Visible = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // rtbout
            // 
            this.rtbout.Location = new System.Drawing.Point(607, 234);
            this.rtbout.Name = "rtbout";
            this.rtbout.ReadOnly = true;
            this.rtbout.Size = new System.Drawing.Size(349, 205);
            this.rtbout.TabIndex = 6;
            this.rtbout.Text = "";
            // 
            // cboxloadfile
            // 
            this.cboxloadfile.FormattingEnabled = true;
            this.cboxloadfile.Items.AddRange(new object[] {
            " ",
            "Ingreso manual",
            "Carga desde archivo"});
            this.cboxloadfile.Location = new System.Drawing.Point(503, 98);
            this.cboxloadfile.Name = "cboxloadfile";
            this.cboxloadfile.Size = new System.Drawing.Size(359, 21);
            this.cboxloadfile.TabIndex = 7;
            this.cboxloadfile.SelectedIndexChanged += new System.EventHandler(this.cboxloadfile_SelectedIndexChanged);
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.Location = new System.Drawing.Point(614, 207);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(61, 24);
            this.lblout.TabIndex = 8;
            this.lblout.Text = "Salida";
            this.lblout.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnloadfile
            // 
            this.btnloadfile.Enabled = false;
            this.btnloadfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadfile.Location = new System.Drawing.Point(445, 350);
            this.btnloadfile.Name = "btnloadfile";
            this.btnloadfile.Size = new System.Drawing.Size(129, 64);
            this.btnloadfile.TabIndex = 9;
            this.btnloadfile.Text = "Cargar archivo";
            this.btnloadfile.UseVisualStyleBackColor = true;
            this.btnloadfile.Visible = false;
            this.btnloadfile.Click += new System.EventHandler(this.btnloadfile_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tboxpath
            // 
            this.tboxpath.Enabled = false;
            this.tboxpath.Location = new System.Drawing.Point(78, 234);
            this.tboxpath.Name = "tboxpath";
            this.tboxpath.Size = new System.Drawing.Size(349, 20);
            this.tboxpath.TabIndex = 10;
            this.tboxpath.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 560);
            this.Controls.Add(this.tboxpath);
            this.Controls.Add(this.btnloadfile);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.cboxloadfile);
            this.Controls.Add(this.rtbout);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.lblconsole);
            this.Controls.Add(this.rtbconsole);
            this.Controls.Add(this.lblmaintitle);
            this.Name = "Form1";
            this.Text = "Compilador de clase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmaintitle;
        private System.Windows.Forms.RichTextBox rtbconsole;
        private System.Windows.Forms.Label lblconsole;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.RichTextBox rtbout;
        private System.Windows.Forms.ComboBox cboxloadfile;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnloadfile;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox tboxpath;
    }
}

