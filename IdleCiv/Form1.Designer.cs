namespace Boblovespi.IdleCiv
{
    partial class IdleCivMainForm
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
            this.outputRichTB = new System.Windows.Forms.RichTextBox();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.landTextBox = new System.Windows.Forms.TextBox();
            this.armyTextBox = new System.Windows.Forms.TextBox();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forfeitNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.controlsGroupBox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputRichTB
            // 
            this.outputRichTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputRichTB.Enabled = false;
            this.outputRichTB.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRichTB.Location = new System.Drawing.Point(12, 27);
            this.outputRichTB.Name = "outputRichTB";
            this.outputRichTB.ReadOnly = true;
            this.outputRichTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputRichTB.Size = new System.Drawing.Size(489, 328);
            this.outputRichTB.TabIndex = 0;
            this.outputRichTB.Text = "";
            this.outputRichTB.TextChanged += new System.EventHandler(this.outputRichTB_TextChanged);
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Location = new System.Drawing.Point(61, 360);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(199, 66);
            this.nextTurnButton.TabIndex = 1;
            this.nextTurnButton.Text = "Next Turn";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Army: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Land: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gold: ";
            // 
            // landTextBox
            // 
            this.landTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.landTextBox.Enabled = false;
            this.landTextBox.Location = new System.Drawing.Point(68, 361);
            this.landTextBox.Name = "landTextBox";
            this.landTextBox.ReadOnly = true;
            this.landTextBox.Size = new System.Drawing.Size(100, 20);
            this.landTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.landTextBox, "The amount of land you have");
            // 
            // armyTextBox
            // 
            this.armyTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.armyTextBox.Enabled = false;
            this.armyTextBox.Location = new System.Drawing.Point(68, 387);
            this.armyTextBox.Name = "armyTextBox";
            this.armyTextBox.ReadOnly = true;
            this.armyTextBox.Size = new System.Drawing.Size(100, 20);
            this.armyTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.armyTextBox, "The size of your army");
            // 
            // foodTextBox
            // 
            this.foodTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.foodTextBox.Enabled = false;
            this.foodTextBox.Location = new System.Drawing.Point(68, 413);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.ReadOnly = true;
            this.foodTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.foodTextBox, "The amount of food you have");
            // 
            // goldTextBox
            // 
            this.goldTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.goldTextBox.Enabled = false;
            this.goldTextBox.Location = new System.Drawing.Point(68, 439);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.ReadOnly = true;
            this.goldTextBox.Size = new System.Drawing.Size(100, 20);
            this.goldTextBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.goldTextBox, "The amount of gold you have");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Help: ";
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.comboBox2);
            this.controlsGroupBox.Controls.Add(this.comboBox1);
            this.controlsGroupBox.Controls.Add(this.radioButton5);
            this.controlsGroupBox.Controls.Add(this.radioButton4);
            this.controlsGroupBox.Controls.Add(this.radioButton3);
            this.controlsGroupBox.Controls.Add(this.radioButton2);
            this.controlsGroupBox.Controls.Add(this.radioButton1);
            this.controlsGroupBox.Controls.Add(this.nextTurnButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(537, 27);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(322, 432);
            this.controlsGroupBox.TabIndex = 12;
            this.controlsGroupBox.TabStop = false;
            this.toolTip1.SetToolTip(this.controlsGroupBox, "Controls for next turn");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.forfeitNewGameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // forfeitNewGameToolStripMenuItem
            // 
            this.forfeitNewGameToolStripMenuItem.Name = "forfeitNewGameToolStripMenuItem";
            this.forfeitNewGameToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.forfeitNewGameToolStripMenuItem.Text = "Forfeit / New game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem2,
            this.saveAsToolStripMenuItem1});
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as...";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "icsave";
            this.saveFileDialog.Filter = "Idle Civ save files|*.icsave|All files|*.*";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(61, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(61, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(61, 121);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(61, 145);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // IdleCivMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 469);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.goldTextBox);
            this.Controls.Add(this.foodTextBox);
            this.Controls.Add(this.armyTextBox);
            this.Controls.Add(this.landTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputRichTB);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IdleCivMainForm";
            this.Text = "Idle Civ";
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRichTB;
        private System.Windows.Forms.Button nextTurnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox landTextBox;
        private System.Windows.Forms.TextBox armyTextBox;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forfeitNewGameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

