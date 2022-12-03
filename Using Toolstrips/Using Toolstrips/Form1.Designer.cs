namespace Using_Toolstrips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbl = new System.Windows.Forms.ToolStripLabel();
            this.tstxb = new System.Windows.Forms.ToolStripTextBox();
            this.lbltexthere = new System.Windows.Forms.Label();
            this.tsbig = new System.Windows.Forms.ToolStripButton();
            this.tssmall = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl,
            this.tstxb,
            this.tsbig,
            this.tssmall});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbl
            // 
            this.tslbl.Name = "tslbl";
            this.tslbl.Size = new System.Drawing.Size(111, 22);
            this.tslbl.Text = "Write your text here";
            // 
            // tstxb
            // 
            this.tstxb.BackColor = System.Drawing.SystemColors.Info;
            this.tstxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tstxb.Name = "tstxb";
            this.tstxb.Size = new System.Drawing.Size(100, 25);
            this.tstxb.Click += new System.EventHandler(this.E);
            this.tstxb.TextChanged += new System.EventHandler(this.tstxb_TextChanged);
            // 
            // lbltexthere
            // 
            this.lbltexthere.AutoSize = true;
            this.lbltexthere.Location = new System.Drawing.Point(12, 53);
            this.lbltexthere.Name = "lbltexthere";
            this.lbltexthere.Size = new System.Drawing.Size(38, 15);
            this.lbltexthere.TabIndex = 1;
            this.lbltexthere.Text = "label1";
            this.lbltexthere.Click += new System.EventHandler(this.lbltexthere_Click);
            // 
            // tsbig
            // 
            this.tsbig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbig.Image = ((System.Drawing.Image)(resources.GetObject("tsbig.Image")));
            this.tsbig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbig.Name = "tsbig";
            this.tsbig.Size = new System.Drawing.Size(23, 22);
            this.tsbig.Text = "toolStripButton1";
            this.tsbig.Click += new System.EventHandler(this.tsbig_Click);
            // 
            // tssmall
            // 
            this.tssmall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssmall.Image = ((System.Drawing.Image)(resources.GetObject("tssmall.Image")));
            this.tssmall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssmall.Name = "tssmall";
            this.tssmall.Size = new System.Drawing.Size(23, 22);
            this.tssmall.Text = "toolStripButton2";
            this.tssmall.Click += new System.EventHandler(this.tssmall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 341);
            this.Controls.Add(this.lbltexthere);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel tslbl;
        private ToolStripTextBox tstxb;
        private Label lbltexthere;
        private ToolStripButton tsbig;
        private ToolStripButton tssmall;
    }
}