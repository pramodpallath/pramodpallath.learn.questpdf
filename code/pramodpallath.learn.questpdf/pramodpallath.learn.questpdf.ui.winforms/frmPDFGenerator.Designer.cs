namespace pramodpallath.learn.questpdf.ui.winforms
{
    partial class frmPDFGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDFGenerator));
            splitContainer1 = new SplitContainer();
            lstBxActions = new ListBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            lblSelectedGeneratorName = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstBxActions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Panel2.Controls.Add(lblSelectedGeneratorName);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 225;
            splitContainer1.TabIndex = 0;
            // 
            // lstBxActions
            // 
            lstBxActions.DisplayMember = "GeneratorName";
            lstBxActions.Dock = DockStyle.Fill;
            lstBxActions.FormattingEnabled = true;
            lstBxActions.ItemHeight = 15;
            lstBxActions.Location = new Point(0, 0);
            lstBxActions.Name = "lstBxActions";
            lstBxActions.Size = new Size(225, 450);
            lstBxActions.TabIndex = 0;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 50);
            webView21.Name = "webView21";
            webView21.Size = new Size(571, 400);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // lblSelectedGeneratorName
            // 
            lblSelectedGeneratorName.Dock = DockStyle.Top;
            lblSelectedGeneratorName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSelectedGeneratorName.Location = new Point(0, 0);
            lblSelectedGeneratorName.Name = "lblSelectedGeneratorName";
            lblSelectedGeneratorName.Size = new Size(571, 50);
            lblSelectedGeneratorName.TabIndex = 0;
            lblSelectedGeneratorName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPDFGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPDFGenerator";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lstBxActions;
        private Label lblSelectedGeneratorName;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
