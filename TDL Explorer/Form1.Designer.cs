namespace TDL_Explorer {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.textBox_TDL = new System.Windows.Forms.TextBox();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox_StartRange = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox_EndRange = new System.Windows.Forms.TextBox();
         this.dataGridView_TimedEvents = new System.Windows.Forms.DataGridView();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripButton_Parse = new System.Windows.Forms.ToolStripButton();
         this.insertExamplesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.flowLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TimedEvents)).BeginInit();
         this.toolStrip1.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer1.Location = new System.Drawing.Point(0, 25);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.textBox_TDL);
         this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.dataGridView_TimedEvents);
         this.splitContainer1.Size = new System.Drawing.Size(499, 320);
         this.splitContainer1.SplitterDistance = 115;
         this.splitContainer1.TabIndex = 1;
         // 
         // textBox_TDL
         // 
         this.textBox_TDL.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox_TDL.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBox_TDL.Location = new System.Drawing.Point(0, 25);
         this.textBox_TDL.Multiline = true;
         this.textBox_TDL.Name = "textBox_TDL";
         this.textBox_TDL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox_TDL.Size = new System.Drawing.Size(499, 90);
         this.textBox_TDL.TabIndex = 1;
         this.textBox_TDL.WordWrap = false;
         this.textBox_TDL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TDL_KeyDown);
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Controls.Add(this.label1);
         this.flowLayoutPanel1.Controls.Add(this.textBox_StartRange);
         this.flowLayoutPanel1.Controls.Add(this.label2);
         this.flowLayoutPanel1.Controls.Add(this.textBox_EndRange);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 25);
         this.flowLayoutPanel1.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(67, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Start Range:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // textBox_StartRange
         // 
         this.textBox_StartRange.Location = new System.Drawing.Point(76, 3);
         this.textBox_StartRange.Name = "textBox_StartRange";
         this.textBox_StartRange.Size = new System.Drawing.Size(130, 20);
         this.textBox_StartRange.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(212, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(64, 20);
         this.label2.TabIndex = 2;
         this.label2.Text = "End Range:";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // textBox_EndRange
         // 
         this.textBox_EndRange.Location = new System.Drawing.Point(282, 3);
         this.textBox_EndRange.Name = "textBox_EndRange";
         this.textBox_EndRange.Size = new System.Drawing.Size(130, 20);
         this.textBox_EndRange.TabIndex = 2;
         // 
         // dataGridView_TimedEvents
         // 
         this.dataGridView_TimedEvents.AllowUserToAddRows = false;
         this.dataGridView_TimedEvents.AllowUserToDeleteRows = false;
         this.dataGridView_TimedEvents.AllowUserToOrderColumns = true;
         this.dataGridView_TimedEvents.AllowUserToResizeRows = false;
         this.dataGridView_TimedEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView_TimedEvents.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView_TimedEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
         this.dataGridView_TimedEvents.Location = new System.Drawing.Point(0, 0);
         this.dataGridView_TimedEvents.Name = "dataGridView_TimedEvents";
         this.dataGridView_TimedEvents.ReadOnly = true;
         this.dataGridView_TimedEvents.RowHeadersVisible = false;
         this.dataGridView_TimedEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.dataGridView_TimedEvents.Size = new System.Drawing.Size(499, 201);
         this.dataGridView_TimedEvents.TabIndex = 0;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Parse,
            this.insertExamplesToolStripDropDownButton});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(499, 25);
         this.toolStrip1.TabIndex = 2;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolStripButton_Parse
         // 
         this.toolStripButton_Parse.Image = global::TDL_Explorer.Properties.Resources.cog_go;
         this.toolStripButton_Parse.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton_Parse.Name = "toolStripButton_Parse";
         this.toolStripButton_Parse.Size = new System.Drawing.Size(79, 22);
         this.toolStripButton_Parse.Text = "&Parse TDL";
         this.toolStripButton_Parse.ToolTipText = "Parse TDL F5";
         this.toolStripButton_Parse.Click += new System.EventHandler(this.toolStripButton_Parse_Click);
         // 
         // insertExamplesToolStripDropDownButton
         // 
         this.insertExamplesToolStripDropDownButton.Image = global::TDL_Explorer.Properties.Resources.pencil_add;
         this.insertExamplesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.insertExamplesToolStripDropDownButton.Name = "insertExamplesToolStripDropDownButton";
         this.insertExamplesToolStripDropDownButton.Size = new System.Drawing.Size(117, 22);
         this.insertExamplesToolStripDropDownButton.Text = "&Insert Examples";
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 345);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(499, 22);
         this.statusStrip1.TabIndex = 3;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(484, 17);
         this.toolStripStatusLabel1.Spring = true;
         this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(499, 367);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.toolStrip1);
         this.Name = "Form1";
         this.Text = "TDL Explorer";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TimedEvents)).EndInit();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.TextBox textBox_TDL;
      private System.Windows.Forms.DataGridView dataGridView_TimedEvents;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton toolStripButton_Parse;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox_StartRange;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox_EndRange;
      private System.Windows.Forms.ToolStripDropDownButton insertExamplesToolStripDropDownButton;

   }
}

