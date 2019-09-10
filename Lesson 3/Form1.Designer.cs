namespace Lesson_3
{
    partial class txtInput2
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
            this.btnGo = new System.Windows.Forms.Button();
            this.IbxOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Green;
            this.btnGo.Location = new System.Drawing.Point(133, 89);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(205, 41);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Click This";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // IbxOutput
            // 
            this.IbxOutput.BackColor = System.Drawing.Color.Blue;
            this.IbxOutput.FormattingEnabled = true;
            this.IbxOutput.Location = new System.Drawing.Point(133, 149);
            this.IbxOutput.Name = "IbxOutput";
            this.IbxOutput.Size = new System.Drawing.Size(498, 160);
            this.IbxOutput.TabIndex = 1;
            this.IbxOutput.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // IblOutput
            // 
            this.IblOutput.BackColor = System.Drawing.Color.Pink;
            this.IblOutput.Location = new System.Drawing.Point(367, 117);
            this.IblOutput.Name = "IblOutput";
            this.IblOutput.Size = new System.Drawing.Size(264, 29);
            this.IblOutput.TabIndex = 4;
            this.IblOutput.Click += new System.EventHandler(this.IblOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(367, 80);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(264, 34);
            this.txtInput.TabIndex = 5;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtInput2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.IblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IbxOutput);
            this.Controls.Add(this.btnGo);
            this.Name = "txtInput2";
            this.Load += new System.EventHandler(this.TxtInput2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox IbxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

