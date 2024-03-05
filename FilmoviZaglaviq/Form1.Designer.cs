namespace FilmoviZaglaviq
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
            txtRejisior = new TextBox();
            lblRejisior = new Label();
            cmbCountry = new ComboBox();
            grbGenre = new GroupBox();
            rdbRomance = new RadioButton();
            rdbAction = new RadioButton();
            rdbTriller = new RadioButton();
            rdbHorror = new RadioButton();
            rdbDrama = new RadioButton();
            chbISokMinors = new CheckBox();
            cmbCompany = new ComboBox();
            txtZaglavie = new TextBox();
            lblZaglavie = new Label();
            lblCountry = new Label();
            lblCompany = new Label();
            btnEnter = new Button();
            btnOutput = new Button();
            grbGenre.SuspendLayout();
            SuspendLayout();
            // 
            // txtRejisior
            // 
            txtRejisior.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            txtRejisior.Location = new Point(12, 51);
            txtRejisior.Name = "txtRejisior";
            txtRejisior.Size = new Size(169, 35);
            txtRejisior.TabIndex = 0;
            // 
            // lblRejisior
            // 
            lblRejisior.AutoSize = true;
            lblRejisior.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblRejisior.Location = new Point(12, 22);
            lblRejisior.Name = "lblRejisior";
            lblRejisior.Size = new Size(124, 26);
            lblRejisior.TabIndex = 1;
            lblRejisior.Text = "Режисьор:";
            // 
            // cmbCountry
            // 
            cmbCountry.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "България", "Америка", "Италия", "Франция", "Африка", "Кореа", "Китай", "Гана", "Германия" });
            cmbCountry.Location = new Point(218, 145);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(216, 34);
            cmbCountry.TabIndex = 2;
            // 
            // grbGenre
            // 
            grbGenre.Controls.Add(rdbRomance);
            grbGenre.Controls.Add(rdbAction);
            grbGenre.Controls.Add(rdbTriller);
            grbGenre.Controls.Add(rdbHorror);
            grbGenre.Controls.Add(rdbDrama);
            grbGenre.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            grbGenre.Location = new Point(12, 236);
            grbGenre.Name = "grbGenre";
            grbGenre.Size = new Size(154, 157);
            grbGenre.TabIndex = 3;
            grbGenre.TabStop = false;
            grbGenre.Text = "Жанр:";
            // 
            // rdbRomance
            // 
            rdbRomance.AutoSize = true;
            rdbRomance.Location = new Point(7, 122);
            rdbRomance.Name = "rdbRomance";
            rdbRomance.Size = new Size(149, 30);
            rdbRomance.TabIndex = 4;
            rdbRomance.TabStop = true;
            rdbRomance.Text = "Романтика";
            rdbRomance.UseVisualStyleBackColor = true;
            // 
            // rdbAction
            // 
            rdbAction.AutoSize = true;
            rdbAction.Location = new Point(7, 97);
            rdbAction.Name = "rdbAction";
            rdbAction.Size = new Size(102, 30);
            rdbAction.TabIndex = 3;
            rdbAction.TabStop = true;
            rdbAction.Text = "Екшън";
            rdbAction.UseVisualStyleBackColor = true;
            // 
            // rdbTriller
            // 
            rdbTriller.AutoSize = true;
            rdbTriller.Location = new Point(6, 72);
            rdbTriller.Name = "rdbTriller";
            rdbTriller.Size = new Size(110, 30);
            rdbTriller.TabIndex = 2;
            rdbTriller.TabStop = true;
            rdbTriller.Text = "Трилър";
            rdbTriller.UseVisualStyleBackColor = true;
            // 
            // rdbHorror
            // 
            rdbHorror.AutoSize = true;
            rdbHorror.Location = new Point(6, 47);
            rdbHorror.Name = "rdbHorror";
            rdbHorror.Size = new Size(98, 30);
            rdbHorror.TabIndex = 1;
            rdbHorror.TabStop = true;
            rdbHorror.Text = "Хорър";
            rdbHorror.UseVisualStyleBackColor = true;
            // 
            // rdbDrama
            // 
            rdbDrama.AutoSize = true;
            rdbDrama.Location = new Point(5, 22);
            rdbDrama.Name = "rdbDrama";
            rdbDrama.Size = new Size(102, 30);
            rdbDrama.TabIndex = 0;
            rdbDrama.TabStop = true;
            rdbDrama.Text = "Драма";
            rdbDrama.UseVisualStyleBackColor = true;
            // 
            // chbISokMinors
            // 
            chbISokMinors.AutoSize = true;
            chbISokMinors.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            chbISokMinors.Location = new Point(12, 200);
            chbISokMinors.Name = "chbISokMinors";
            chbISokMinors.Size = new Size(395, 30);
            chbISokMinors.TabIndex = 4;
            chbISokMinors.Text = "Подходящо за деца над 16 години";
            chbISokMinors.UseVisualStyleBackColor = true;
            // 
            // cmbCompany
            // 
            cmbCompany.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Items.AddRange(new object[] { "Pro films", "BG Films", "Filmi uk", "USA Film Production", "German Movies", "Movies For U", "JK FILM", "Production Centre UK" });
            cmbCompany.Location = new Point(218, 51);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(216, 34);
            cmbCompany.TabIndex = 5;
            // 
            // txtZaglavie
            // 
            txtZaglavie.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            txtZaglavie.Location = new Point(12, 144);
            txtZaglavie.Name = "txtZaglavie";
            txtZaglavie.Size = new Size(169, 35);
            txtZaglavie.TabIndex = 6;
            // 
            // lblZaglavie
            // 
            lblZaglavie.AutoSize = true;
            lblZaglavie.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblZaglavie.Location = new Point(9, 115);
            lblZaglavie.Name = "lblZaglavie";
            lblZaglavie.Size = new Size(117, 26);
            lblZaglavie.TabIndex = 7;
            lblZaglavie.Text = "Заглавие:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblCountry.Location = new Point(218, 115);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(115, 26);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Държава:";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold);
            lblCompany.Location = new Point(218, 22);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(226, 26);
            lblCompany.TabIndex = 9;
            lblCompany.Text = "Филмова компания:";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(258, 231);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(149, 81);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "Въведи";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnOutput
            // 
            btnOutput.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOutput.Location = new Point(236, 325);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(189, 79);
            btnOutput.TabIndex = 11;
            btnOutput.Text = "Отпечатване";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 416);
            Controls.Add(btnOutput);
            Controls.Add(btnEnter);
            Controls.Add(lblCompany);
            Controls.Add(lblCountry);
            Controls.Add(lblZaglavie);
            Controls.Add(txtZaglavie);
            Controls.Add(cmbCompany);
            Controls.Add(chbISokMinors);
            Controls.Add(grbGenre);
            Controls.Add(cmbCountry);
            Controls.Add(lblRejisior);
            Controls.Add(txtRejisior);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Филмотека";
            grbGenre.ResumeLayout(false);
            grbGenre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRejisior;
        private Label lblRejisior;
        private ComboBox cmbCountry;
        private GroupBox grbGenre;
        private RadioButton rdbRomance;
        private RadioButton rdbAction;
        private RadioButton rdbTriller;
        private RadioButton rdbHorror;
        private RadioButton rdbDrama;
        private CheckBox chbISokMinors;
        private ComboBox cmbCompany;
        private TextBox txtZaglavie;
        private Label lblZaglavie;
        private Label lblCountry;
        private Label lblCompany;
        private Button btnEnter;
        private Button btnOutput;
    }
}
