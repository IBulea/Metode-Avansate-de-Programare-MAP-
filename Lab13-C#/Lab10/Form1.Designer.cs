namespace Lab10
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
            this.Run = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Button();
            this.serialise = new System.Windows.Forms.Button();
            this.deserialise = new System.Windows.Forms.Button();
            this.toFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exeList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.symList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outList = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.heapList = new System.Windows.Forms.ListBox();
            this.heaplbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(49, 89);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(87, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(49, 118);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(87, 23);
            this.debug.TabIndex = 1;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // serialise
            // 
            this.serialise.Location = new System.Drawing.Point(49, 147);
            this.serialise.Name = "serialise";
            this.serialise.Size = new System.Drawing.Size(87, 23);
            this.serialise.TabIndex = 2;
            this.serialise.Text = "Serialise";
            this.serialise.UseVisualStyleBackColor = true;
            this.serialise.Click += new System.EventHandler(this.serialise_Click);
            // 
            // deserialise
            // 
            this.deserialise.Location = new System.Drawing.Point(49, 176);
            this.deserialise.Name = "deserialise";
            this.deserialise.Size = new System.Drawing.Size(87, 23);
            this.deserialise.TabIndex = 3;
            this.deserialise.Text = "Deserialise";
            this.deserialise.UseVisualStyleBackColor = true;
            this.deserialise.Click += new System.EventHandler(this.deserialise_Click);
            // 
            // toFile
            // 
            this.toFile.Location = new System.Drawing.Point(49, 205);
            this.toFile.Name = "toFile";
            this.toFile.Size = new System.Drawing.Size(87, 23);
            this.toFile.TabIndex = 4;
            this.toFile.Text = "Write To File";
            this.toFile.UseVisualStyleBackColor = true;
            this.toFile.Click += new System.EventHandler(this.toFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exe Stack";
            // 
            // exeList
            // 
            this.exeList.FormattingEnabled = true;
            this.exeList.Location = new System.Drawing.Point(238, 58);
            this.exeList.Name = "exeList";
            this.exeList.Size = new System.Drawing.Size(326, 82);
            this.exeList.TabIndex = 6;
            this.exeList.SelectedIndexChanged += new System.EventHandler(this.exeList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sym Table";
            // 
            // symList
            // 
            this.symList.FormattingEnabled = true;
            this.symList.Location = new System.Drawing.Point(239, 163);
            this.symList.Name = "symList";
            this.symList.Size = new System.Drawing.Size(324, 82);
            this.symList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            // 
            // outList
            // 
            this.outList.FormattingEnabled = true;
            this.outList.Location = new System.Drawing.Point(241, 271);
            this.outList.Name = "outList";
            this.outList.Size = new System.Drawing.Size(321, 82);
            this.outList.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(49, 60);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(87, 23);
            this.add.TabIndex = 11;
            this.add.Text = "Add Program";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(49, 238);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(87, 23);
            this.test.TabIndex = 12;
            this.test.Text = "Test Program";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // heapList
            // 
            this.heapList.FormattingEnabled = true;
            this.heapList.Location = new System.Drawing.Point(241, 375);
            this.heapList.Name = "heapList";
            this.heapList.Size = new System.Drawing.Size(319, 82);
            this.heapList.TabIndex = 13;
            // 
            // heaplbl
            // 
            this.heaplbl.AutoSize = true;
            this.heaplbl.Location = new System.Drawing.Point(241, 359);
            this.heaplbl.Name = "heaplbl";
            this.heaplbl.Size = new System.Drawing.Size(33, 13);
            this.heaplbl.TabIndex = 14;
            this.heaplbl.Text = "Heap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 465);
            this.Controls.Add(this.heaplbl);
            this.Controls.Add(this.heapList);
            this.Controls.Add(this.test);
            this.Controls.Add(this.add);
            this.Controls.Add(this.outList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.symList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toFile);
            this.Controls.Add(this.deserialise);
            this.Controls.Add(this.serialise);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.Run);
            this.Name = "Form1";
            this.Text = "Toy Language";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.Button serialise;
        private System.Windows.Forms.Button deserialise;
        private System.Windows.Forms.Button toFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox exeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox symList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox outList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.ListBox heapList;
        private System.Windows.Forms.Label heaplbl;
    }
}

