﻿namespace Pyramid
{
    partial class OptionsScreen
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
            this.components = new System.ComponentModel.Container();
            this.txtCodeXL = new System.Windows.Forms.TextBox();
            this.txtD3DCompiler = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnCodeXL = new System.Windows.Forms.Button();
            this.btnD3DCompiler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPowerVR = new System.Windows.Forms.TextBox();
            this.btnPowerVR = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDXX = new System.Windows.Forms.TextBox();
            this.btnDXX = new System.Windows.Forms.Button();
            this.lstBackends = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMali = new System.Windows.Forms.Button();
            this.txtMali = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodeXL
            // 
            this.txtCodeXL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeXL.Enabled = false;
            this.txtCodeXL.Location = new System.Drawing.Point(86, 183);
            this.txtCodeXL.Name = "txtCodeXL";
            this.txtCodeXL.Size = new System.Drawing.Size(459, 20);
            this.txtCodeXL.TabIndex = 1;
            // 
            // txtD3DCompiler
            // 
            this.txtD3DCompiler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtD3DCompiler.Enabled = false;
            this.txtD3DCompiler.Location = new System.Drawing.Point(86, 209);
            this.txtD3DCompiler.Name = "txtD3DCompiler";
            this.txtD3DCompiler.Size = new System.Drawing.Size(459, 20);
            this.txtD3DCompiler.TabIndex = 2;
            // 
            // txtTemp
            // 
            this.txtTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(86, 154);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(459, 20);
            this.txtTemp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CodeXL";
            this.toolTip1.SetToolTip(this.label2, "Path to AMD CodeXL Analyzer");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "D3DCompiler";
            this.toolTip1.SetToolTip(this.label3, "Path to the D3DCompiler DLL to use");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temp Dir";
            this.toolTip1.SetToolTip(this.label4, "Path to a directory that will be polluted with temporary nonsense when the compil" +
        "e button is pressed.");
            // 
            // btnTemp
            // 
            this.btnTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemp.Location = new System.Drawing.Point(546, 154);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(32, 20);
            this.btnTemp.TabIndex = 8;
            this.btnTemp.Text = "...";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnCodeXL
            // 
            this.btnCodeXL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCodeXL.Location = new System.Drawing.Point(545, 182);
            this.btnCodeXL.Name = "btnCodeXL";
            this.btnCodeXL.Size = new System.Drawing.Size(32, 20);
            this.btnCodeXL.TabIndex = 10;
            this.btnCodeXL.Text = "...";
            this.btnCodeXL.UseVisualStyleBackColor = true;
            this.btnCodeXL.Click += new System.EventHandler(this.btnCodeXL_Click);
            // 
            // btnD3DCompiler
            // 
            this.btnD3DCompiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD3DCompiler.Location = new System.Drawing.Point(545, 208);
            this.btnD3DCompiler.Name = "btnD3DCompiler";
            this.btnD3DCompiler.Size = new System.Drawing.Size(32, 20);
            this.btnD3DCompiler.TabIndex = 11;
            this.btnD3DCompiler.Text = "...";
            this.btnD3DCompiler.UseVisualStyleBackColor = true;
            this.btnD3DCompiler.Click += new System.EventHandler(this.btnD3DCompiler_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(439, 343);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 25);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(515, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "PowerVR Dir";
            this.toolTip1.SetToolTip(this.label1, "Directory where the PowerVR compilers can be found.  Default will be relative to " +
        "working directory.");
            // 
            // txtPowerVR
            // 
            this.txtPowerVR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPowerVR.Enabled = false;
            this.txtPowerVR.Location = new System.Drawing.Point(86, 234);
            this.txtPowerVR.Name = "txtPowerVR";
            this.txtPowerVR.Size = new System.Drawing.Size(459, 20);
            this.txtPowerVR.TabIndex = 15;
            // 
            // btnPowerVR
            // 
            this.btnPowerVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerVR.Location = new System.Drawing.Point(545, 233);
            this.btnPowerVR.Name = "btnPowerVR";
            this.btnPowerVR.Size = new System.Drawing.Size(32, 19);
            this.btnPowerVR.TabIndex = 16;
            this.btnPowerVR.Text = "...";
            this.btnPowerVR.UseVisualStyleBackColor = true;
            this.btnPowerVR.Click += new System.EventHandler(this.btnPowerVR_Click);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(33, 344);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(65, 24);
            this.btnDefaults.TabIndex = 17;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "AMD DXX";
            this.toolTip1.SetToolTip(this.label5, "Directory where atidxx32.dll can be found.  Default will be relative to working d" +
        "irectory.");
            // 
            // txtDXX
            // 
            this.txtDXX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDXX.Enabled = false;
            this.txtDXX.Location = new System.Drawing.Point(86, 260);
            this.txtDXX.Name = "txtDXX";
            this.txtDXX.Size = new System.Drawing.Size(459, 20);
            this.txtDXX.TabIndex = 18;
            // 
            // btnDXX
            // 
            this.btnDXX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDXX.Location = new System.Drawing.Point(545, 261);
            this.btnDXX.Name = "btnDXX";
            this.btnDXX.Size = new System.Drawing.Size(32, 19);
            this.btnDXX.TabIndex = 19;
            this.btnDXX.Text = "...";
            this.btnDXX.UseVisualStyleBackColor = true;
            this.btnDXX.Click += new System.EventHandler(this.btnDXX_Click);
            // 
            // lstBackends
            // 
            this.lstBackends.FormattingEnabled = true;
            this.lstBackends.Location = new System.Drawing.Point(86, 27);
            this.lstBackends.Name = "lstBackends";
            this.lstBackends.ScrollAlwaysVisible = true;
            this.lstBackends.Size = new System.Drawing.Size(153, 109);
            this.lstBackends.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Backends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mali Dir";
            this.toolTip1.SetToolTip(this.label7, "Directory where the mali shader compiler can be found.  Default will be relative " +
        "to working directory.");
            // 
            // btnMali
            // 
            this.btnMali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMali.Location = new System.Drawing.Point(545, 287);
            this.btnMali.Name = "btnMali";
            this.btnMali.Size = new System.Drawing.Size(32, 19);
            this.btnMali.TabIndex = 25;
            this.btnMali.Text = "...";
            this.btnMali.UseVisualStyleBackColor = true;
            this.btnMali.Click += new System.EventHandler(this.btnMali_Click);
            // 
            // txtMali
            // 
            this.txtMali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMali.Enabled = false;
            this.txtMali.Location = new System.Drawing.Point(86, 286);
            this.txtMali.Name = "txtMali";
            this.txtMali.Size = new System.Drawing.Size(459, 20);
            this.txtMali.TabIndex = 24;
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 399);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMali);
            this.Controls.Add(this.txtMali);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBackends);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDXX);
            this.Controls.Add(this.txtDXX);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.btnPowerVR);
            this.Controls.Add(this.txtPowerVR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnD3DCompiler);
            this.Controls.Add(this.btnCodeXL);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtD3DCompiler);
            this.Controls.Add(this.txtCodeXL);
            this.Name = "OptionsScreen";
            this.Text = "OptionsScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeXL;
        private System.Windows.Forms.TextBox txtD3DCompiler;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnCodeXL;
        private System.Windows.Forms.Button btnD3DCompiler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPowerVR;
        private System.Windows.Forms.Button btnPowerVR;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDXX;
        private System.Windows.Forms.Button btnDXX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox lstBackends;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMali;
        private System.Windows.Forms.TextBox txtMali;
    }
}