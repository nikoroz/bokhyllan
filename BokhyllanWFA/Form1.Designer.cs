namespace BokhyllanWFA
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
            this.userInputBoxTitel = new System.Windows.Forms.TextBox();
            this.userInputBoxSkribent = new System.Windows.Forms.TextBox();
            this.userInputBoxUtgivningsår = new System.Windows.Forms.NumericUpDown();
            this.labelUtgivningsår = new System.Windows.Forms.Label();
            this.labelSkribent = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelTyp = new System.Windows.Forms.Label();
            this.buttonAddNewBook = new System.Windows.Forms.Button();
            this.buttonShowBookList = new System.Windows.Forms.Button();
            this.buttonEraseBookList = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.userInputBoxTyp = new System.Windows.Forms.ComboBox();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTitel = new System.Windows.Forms.CheckBox();
            this.checkBoxTyp = new System.Windows.Forms.CheckBox();
            this.checkBoxUtgivningsår = new System.Windows.Forms.CheckBox();
            this.checkBoxSkribent = new System.Windows.Forms.CheckBox();
            this.buttonTipsmaskinen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bibliotekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.userInputBoxUtgivningsår)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInputBoxTitel
            // 
            this.userInputBoxTitel.Location = new System.Drawing.Point(10, 62);
            this.userInputBoxTitel.Name = "userInputBoxTitel";
            this.userInputBoxTitel.Size = new System.Drawing.Size(170, 20);
            this.userInputBoxTitel.TabIndex = 1;
            // 
            // userInputBoxSkribent
            // 
            this.userInputBoxSkribent.Location = new System.Drawing.Point(186, 62);
            this.userInputBoxSkribent.Name = "userInputBoxSkribent";
            this.userInputBoxSkribent.Size = new System.Drawing.Size(170, 20);
            this.userInputBoxSkribent.TabIndex = 2;
            // 
            // userInputBoxUtgivningsår
            // 
            this.userInputBoxUtgivningsår.AllowDrop = true;
            this.userInputBoxUtgivningsår.Location = new System.Drawing.Point(186, 108);
            this.userInputBoxUtgivningsår.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.userInputBoxUtgivningsår.Name = "userInputBoxUtgivningsår";
            this.userInputBoxUtgivningsår.Size = new System.Drawing.Size(170, 20);
            this.userInputBoxUtgivningsår.TabIndex = 3;
            this.userInputBoxUtgivningsår.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userInputBoxUtgivningsår.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // labelUtgivningsår
            // 
            this.labelUtgivningsår.AutoSize = true;
            this.labelUtgivningsår.Location = new System.Drawing.Point(183, 91);
            this.labelUtgivningsår.Name = "labelUtgivningsår";
            this.labelUtgivningsår.Size = new System.Drawing.Size(69, 13);
            this.labelUtgivningsår.TabIndex = 4;
            this.labelUtgivningsår.Text = "Utgivningsår:";
            // 
            // labelSkribent
            // 
            this.labelSkribent.AutoSize = true;
            this.labelSkribent.Location = new System.Drawing.Point(183, 42);
            this.labelSkribent.Name = "labelSkribent";
            this.labelSkribent.Size = new System.Drawing.Size(49, 13);
            this.labelSkribent.TabIndex = 5;
            this.labelSkribent.Text = "Skribent:";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(7, 42);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(30, 13);
            this.labelTitel.TabIndex = 6;
            this.labelTitel.Text = "Titel:";
            // 
            // labelTyp
            // 
            this.labelTyp.AutoSize = true;
            this.labelTyp.Location = new System.Drawing.Point(7, 91);
            this.labelTyp.Name = "labelTyp";
            this.labelTyp.Size = new System.Drawing.Size(28, 13);
            this.labelTyp.TabIndex = 8;
            this.labelTyp.Text = "Typ:";
            // 
            // buttonAddNewBook
            // 
            this.buttonAddNewBook.Location = new System.Drawing.Point(10, 143);
            this.buttonAddNewBook.Name = "buttonAddNewBook";
            this.buttonAddNewBook.Size = new System.Drawing.Size(110, 25);
            this.buttonAddNewBook.TabIndex = 9;
            this.buttonAddNewBook.Text = "Lägg till bok";
            this.buttonAddNewBook.UseVisualStyleBackColor = true;
            this.buttonAddNewBook.Click += new System.EventHandler(this.ButtonAddNewBook_Click);
            // 
            // buttonShowBookList
            // 
            this.buttonShowBookList.Location = new System.Drawing.Point(128, 143);
            this.buttonShowBookList.Name = "buttonShowBookList";
            this.buttonShowBookList.Size = new System.Drawing.Size(110, 25);
            this.buttonShowBookList.TabIndex = 10;
            this.buttonShowBookList.Text = "Visa alla böcker";
            this.buttonShowBookList.UseVisualStyleBackColor = true;
            this.buttonShowBookList.Click += new System.EventHandler(this.ButtonShowBookList_Click);
            // 
            // buttonEraseBookList
            // 
            this.buttonEraseBookList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEraseBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEraseBookList.Location = new System.Drawing.Point(246, 143);
            this.buttonEraseBookList.Name = "buttonEraseBookList";
            this.buttonEraseBookList.Size = new System.Drawing.Size(110, 25);
            this.buttonEraseBookList.TabIndex = 11;
            this.buttonEraseBookList.Text = "Radera alla böcker";
            this.buttonEraseBookList.UseVisualStyleBackColor = false;
            this.buttonEraseBookList.Click += new System.EventHandler(this.ButtonEraseBookList_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputBox.Location = new System.Drawing.Point(11, 269);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputBox.Size = new System.Drawing.Size(345, 287);
            this.outputBox.TabIndex = 10;
            this.outputBox.Text = "";
            // 
            // userInputBoxTyp
            // 
            this.userInputBoxTyp.AllowDrop = true;
            this.userInputBoxTyp.FormattingEnabled = true;
            this.userInputBoxTyp.Items.AddRange(new object[] {
            "Novellsamling",
            "Tidskrift",
            "Roman"});
            this.userInputBoxTyp.Location = new System.Drawing.Point(10, 107);
            this.userInputBoxTyp.Name = "userInputBoxTyp";
            this.userInputBoxTyp.Size = new System.Drawing.Size(170, 21);
            this.userInputBoxTyp.TabIndex = 7;
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(10, 196);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(170, 25);
            this.buttonSearchBook.TabIndex = 13;
            this.buttonSearchBook.Text = "Sök efter bok";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sök efter:";
            // 
            // checkBoxTitel
            // 
            this.checkBoxTitel.AutoSize = true;
            this.checkBoxTitel.Location = new System.Drawing.Point(82, 233);
            this.checkBoxTitel.Name = "checkBoxTitel";
            this.checkBoxTitel.Size = new System.Drawing.Size(46, 17);
            this.checkBoxTitel.TabIndex = 15;
            this.checkBoxTitel.Text = "Titel";
            this.checkBoxTitel.UseVisualStyleBackColor = true;
            this.checkBoxTitel.CheckedChanged += new System.EventHandler(this.checkBoxTitel_CheckedChanged);
            // 
            // checkBoxTyp
            // 
            this.checkBoxTyp.AutoSize = true;
            this.checkBoxTyp.Location = new System.Drawing.Point(205, 233);
            this.checkBoxTyp.Name = "checkBoxTyp";
            this.checkBoxTyp.Size = new System.Drawing.Size(44, 17);
            this.checkBoxTyp.TabIndex = 17;
            this.checkBoxTyp.Text = "Typ";
            this.checkBoxTyp.UseVisualStyleBackColor = true;
            this.checkBoxTyp.CheckedChanged += new System.EventHandler(this.checkBoxTyp_CheckedChanged);
            // 
            // checkBoxUtgivningsår
            // 
            this.checkBoxUtgivningsår.AutoSize = true;
            this.checkBoxUtgivningsår.Location = new System.Drawing.Point(255, 233);
            this.checkBoxUtgivningsår.Name = "checkBoxUtgivningsår";
            this.checkBoxUtgivningsår.Size = new System.Drawing.Size(85, 17);
            this.checkBoxUtgivningsår.TabIndex = 18;
            this.checkBoxUtgivningsår.Text = "Utgivningsår";
            this.checkBoxUtgivningsår.UseVisualStyleBackColor = true;
            this.checkBoxUtgivningsår.CheckedChanged += new System.EventHandler(this.checkBoxUtgivningsår_CheckedChanged);
            // 
            // checkBoxSkribent
            // 
            this.checkBoxSkribent.AutoSize = true;
            this.checkBoxSkribent.Location = new System.Drawing.Point(134, 233);
            this.checkBoxSkribent.Name = "checkBoxSkribent";
            this.checkBoxSkribent.Size = new System.Drawing.Size(65, 17);
            this.checkBoxSkribent.TabIndex = 19;
            this.checkBoxSkribent.Text = "Skribent";
            this.checkBoxSkribent.UseVisualStyleBackColor = true;
            this.checkBoxSkribent.CheckedChanged += new System.EventHandler(this.checkBoxSkribent_CheckedChanged);
            // 
            // buttonTipsmaskinen
            // 
            this.buttonTipsmaskinen.Location = new System.Drawing.Point(186, 196);
            this.buttonTipsmaskinen.Name = "buttonTipsmaskinen";
            this.buttonTipsmaskinen.Size = new System.Drawing.Size(170, 25);
            this.buttonTipsmaskinen.TabIndex = 20;
            this.buttonTipsmaskinen.Text = "Tipsmaskinen";
            this.buttonTipsmaskinen.UseVisualStyleBackColor = true;
            this.buttonTipsmaskinen.Click += new System.EventHandler(this.buttonTipsmaskinen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibliotekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bibliotekToolStripMenuItem
            // 
            this.bibliotekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem});
            this.bibliotekToolStripMenuItem.Name = "bibliotekToolStripMenuItem";
            this.bibliotekToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.bibliotekToolStripMenuItem.Text = "Bibliotek";
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna...";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sparaToolStripMenuItem.Text = "Spara...";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // dlgSparaFil
            // 
            this.dlgSparaFil.AddExtension = false;
            this.dlgSparaFil.CreatePrompt = true;
            this.dlgSparaFil.DefaultExt = "txt";
            this.dlgSparaFil.FileName = "texter";
            this.dlgSparaFil.Filter = "Text files|*.txt";
            // 
            // dlgÖppnaFil
            // 
            this.dlgÖppnaFil.DefaultExt = "txt";
            this.dlgÖppnaFil.FileName = "texter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 566);
            this.Controls.Add(this.buttonTipsmaskinen);
            this.Controls.Add(this.checkBoxSkribent);
            this.Controls.Add(this.checkBoxUtgivningsår);
            this.Controls.Add(this.checkBoxTyp);
            this.Controls.Add(this.checkBoxTitel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.buttonEraseBookList);
            this.Controls.Add(this.buttonShowBookList);
            this.Controls.Add(this.buttonAddNewBook);
            this.Controls.Add(this.labelTyp);
            this.Controls.Add(this.userInputBoxTyp);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.labelSkribent);
            this.Controls.Add(this.labelUtgivningsår);
            this.Controls.Add(this.userInputBoxUtgivningsår);
            this.Controls.Add(this.userInputBoxSkribent);
            this.Controls.Add(this.userInputBoxTitel);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bibliotekarien";
            ((System.ComponentModel.ISupportInitialize)(this.userInputBoxUtgivningsår)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userInputBoxTitel;
        private System.Windows.Forms.TextBox userInputBoxSkribent;
        private System.Windows.Forms.NumericUpDown userInputBoxUtgivningsår;
        private System.Windows.Forms.Label labelUtgivningsår;
        private System.Windows.Forms.Label labelSkribent;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelTyp;
        private System.Windows.Forms.Button buttonAddNewBook;
        private System.Windows.Forms.Button buttonShowBookList;
        private System.Windows.Forms.Button buttonEraseBookList;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.ComboBox userInputBoxTyp;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTitel;
        private System.Windows.Forms.CheckBox checkBoxTyp;
        private System.Windows.Forms.CheckBox checkBoxUtgivningsår;
        private System.Windows.Forms.CheckBox checkBoxSkribent;
        private System.Windows.Forms.Button buttonTipsmaskinen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bibliotekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
    }
}

