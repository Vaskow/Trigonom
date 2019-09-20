namespace Trigonom
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
            this.rbDegree = new System.Windows.Forms.RadioButton();
            this.rbRads = new System.Windows.Forms.RadioButton();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPSin = new System.Windows.Forms.TabPage();
            this.pbSin = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPCos = new System.Windows.Forms.TabPage();
            this.pbCos = new System.Windows.Forms.PictureBox();
            this.tabPTan = new System.Windows.Forms.TabPage();
            this.pbTan = new System.Windows.Forms.PictureBox();
            this.tabPCot = new System.Windows.Forms.TabPage();
            this.pbCot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lSin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lCos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lTan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lCot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPSin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSin)).BeginInit();
            this.tabPCos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCos)).BeginInit();
            this.tabPTan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTan)).BeginInit();
            this.tabPCot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCot)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDegree
            // 
            this.rbDegree.AutoSize = true;
            this.rbDegree.Location = new System.Drawing.Point(349, 12);
            this.rbDegree.Name = "rbDegree";
            this.rbDegree.Size = new System.Drawing.Size(58, 17);
            this.rbDegree.TabIndex = 0;
            this.rbDegree.TabStop = true;
            this.rbDegree.Text = "degree";
            this.rbDegree.UseVisualStyleBackColor = true;
            this.rbDegree.CheckedChanged += new System.EventHandler(this.rbDegree_CheckedChanged);
            // 
            // rbRads
            // 
            this.rbRads.AutoSize = true;
            this.rbRads.Location = new System.Drawing.Point(427, 12);
            this.rbRads.Name = "rbRads";
            this.rbRads.Size = new System.Drawing.Size(45, 17);
            this.rbRads.TabIndex = 1;
            this.rbRads.TabStop = true;
            this.rbRads.Text = "rads";
            this.rbRads.UseVisualStyleBackColor = true;
            // 
            // pbCircle
            // 
            this.pbCircle.Location = new System.Drawing.Point(12, 12);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(300, 300);
            this.pbCircle.TabIndex = 2;
            this.pbCircle.TabStop = false;
            this.pbCircle.Click += new System.EventHandler(this.pbCircle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(349, 91);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(123, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPSin);
            this.tabControl.Controls.Add(this.tabPCos);
            this.tabControl.Controls.Add(this.tabPTan);
            this.tabControl.Controls.Add(this.tabPCot);
            this.tabControl.Location = new System.Drawing.Point(12, 318);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(510, 232);
            this.tabControl.TabIndex = 5;
            this.tabControl.Tag = "";
            // 
            // tabPSin
            // 
            this.tabPSin.Controls.Add(this.pbSin);
            this.tabPSin.Controls.Add(this.splitter1);
            this.tabPSin.Location = new System.Drawing.Point(4, 22);
            this.tabPSin.Name = "tabPSin";
            this.tabPSin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSin.Size = new System.Drawing.Size(502, 206);
            this.tabPSin.TabIndex = 0;
            this.tabPSin.Text = "Sin";
            this.tabPSin.UseVisualStyleBackColor = true;
            // 
            // pbSin
            // 
            this.pbSin.Location = new System.Drawing.Point(0, 0);
            this.pbSin.Name = "pbSin";
            this.pbSin.Size = new System.Drawing.Size(502, 206);
            this.pbSin.TabIndex = 7;
            this.pbSin.TabStop = false;
            this.pbSin.Click += new System.EventHandler(this.pbSin_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 200);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabPCos
            // 
            this.tabPCos.Controls.Add(this.pbCos);
            this.tabPCos.Location = new System.Drawing.Point(4, 22);
            this.tabPCos.Name = "tabPCos";
            this.tabPCos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCos.Size = new System.Drawing.Size(502, 206);
            this.tabPCos.TabIndex = 1;
            this.tabPCos.Text = "Cos";
            this.tabPCos.UseVisualStyleBackColor = true;
            // 
            // pbCos
            // 
            this.pbCos.Location = new System.Drawing.Point(0, 0);
            this.pbCos.Name = "pbCos";
            this.pbCos.Size = new System.Drawing.Size(502, 206);
            this.pbCos.TabIndex = 7;
            this.pbCos.TabStop = false;
            // 
            // tabPTan
            // 
            this.tabPTan.Controls.Add(this.pbTan);
            this.tabPTan.Location = new System.Drawing.Point(4, 22);
            this.tabPTan.Name = "tabPTan";
            this.tabPTan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTan.Size = new System.Drawing.Size(502, 206);
            this.tabPTan.TabIndex = 2;
            this.tabPTan.Text = "Tan";
            this.tabPTan.UseVisualStyleBackColor = true;
            // 
            // pbTan
            // 
            this.pbTan.Location = new System.Drawing.Point(0, 0);
            this.pbTan.Name = "pbTan";
            this.pbTan.Size = new System.Drawing.Size(502, 206);
            this.pbTan.TabIndex = 6;
            this.pbTan.TabStop = false;
            // 
            // tabPCot
            // 
            this.tabPCot.Controls.Add(this.pbCot);
            this.tabPCot.Location = new System.Drawing.Point(4, 22);
            this.tabPCot.Name = "tabPCot";
            this.tabPCot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCot.Size = new System.Drawing.Size(502, 206);
            this.tabPCot.TabIndex = 3;
            this.tabPCot.Text = "Cot";
            this.tabPCot.UseVisualStyleBackColor = true;
            // 
            // pbCot
            // 
            this.pbCot.Location = new System.Drawing.Point(0, 0);
            this.pbCot.Name = "pbCot";
            this.pbCot.Size = new System.Drawing.Size(502, 206);
            this.pbCot.TabIndex = 0;
            this.pbCot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sin";
            // 
            // lSin
            // 
            this.lSin.AutoSize = true;
            this.lSin.Location = new System.Drawing.Point(401, 137);
            this.lSin.Name = "lSin";
            this.lSin.Size = new System.Drawing.Size(35, 13);
            this.lSin.TabIndex = 6;
            this.lSin.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cos";
            // 
            // lCos
            // 
            this.lCos.AutoSize = true;
            this.lCos.Location = new System.Drawing.Point(401, 162);
            this.lCos.Name = "lCos";
            this.lCos.Size = new System.Drawing.Size(35, 13);
            this.lCos.TabIndex = 6;
            this.lCos.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tan";
            // 
            // lTan
            // 
            this.lTan.AutoSize = true;
            this.lTan.Location = new System.Drawing.Point(401, 184);
            this.lTan.Name = "lTan";
            this.lTan.Size = new System.Drawing.Size(35, 13);
            this.lTan.TabIndex = 6;
            this.lTan.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cot";
            // 
            // lCot
            // 
            this.lCot.AutoSize = true;
            this.lCot.Location = new System.Drawing.Point(401, 206);
            this.lCot.Name = "lCot";
            this.lCot.Size = new System.Drawing.Size(35, 13);
            this.lCot.TabIndex = 6;
            this.lCot.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 562);
            this.Controls.Add(this.lCot);
            this.Controls.Add(this.lTan);
            this.Controls.Add(this.lCos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lSin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbCircle);
            this.Controls.Add(this.rbRads);
            this.Controls.Add(this.rbDegree);
            this.Name = "Form1";
            this.Text = "la";
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPSin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSin)).EndInit();
            this.tabPCos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCos)).EndInit();
            this.tabPTan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTan)).EndInit();
            this.tabPCot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDegree;
        private System.Windows.Forms.RadioButton rbRads;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPSin;
        private System.Windows.Forms.PictureBox pbSin;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPCos;
        private System.Windows.Forms.PictureBox pbCos;
        private System.Windows.Forms.TabPage tabPTan;
        private System.Windows.Forms.PictureBox pbTan;
        private System.Windows.Forms.TabPage tabPCot;
        private System.Windows.Forms.PictureBox pbCot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lTan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lCot;
    }
}

