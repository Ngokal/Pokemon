namespace Soru1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnParseDisplay = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kriterFiltre = new System.Windows.Forms.ComboBox();
            this.txtFiltreMax = new System.Windows.Forms.TextBox();
            this.txtFiltreMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.kriterAra = new System.Windows.Forms.ComboBox();
            this.txtAramaGirdi = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFight = new System.Windows.Forms.Button();
            this.txtPokeName1 = new System.Windows.Forms.TextBox();
            this.txtPokeName2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFightResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnParseDisplay
            // 
            this.btnParseDisplay.Location = new System.Drawing.Point(584, 12);
            this.btnParseDisplay.Name = "btnParseDisplay";
            this.btnParseDisplay.Size = new System.Drawing.Size(172, 23);
            this.btnParseDisplay.TabIndex = 1;
            this.btnParseDisplay.Text = "Parse and Display";
            this.btnParseDisplay.UseVisualStyleBackColor = true;
            this.btnParseDisplay.Click += new System.EventHandler(this.btnParseDisplay_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(566, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kriterFiltre
            // 
            this.kriterFiltre.FormattingEnabled = true;
            this.kriterFiltre.Items.AddRange(new object[] {
            "#",
            "Name",
            "Type 1",
            "Type 2",
            "Total",
            "Hp",
            "Attack",
            "Deffence",
            "Sp. Atk",
            "Sp. Def",
            "Speed",
            "Generation",
            "Legendary"});
            this.kriterFiltre.Location = new System.Drawing.Point(765, 58);
            this.kriterFiltre.Name = "kriterFiltre";
            this.kriterFiltre.Size = new System.Drawing.Size(135, 21);
            this.kriterFiltre.TabIndex = 4;
            this.kriterFiltre.Text = "Criteria";
            // 
            // txtFiltreMax
            // 
            this.txtFiltreMax.Location = new System.Drawing.Point(800, 119);
            this.txtFiltreMax.Name = "txtFiltreMax";
            this.txtFiltreMax.Size = new System.Drawing.Size(100, 20);
            this.txtFiltreMax.TabIndex = 5;
            // 
            // txtFiltreMin
            // 
            this.txtFiltreMin.Location = new System.Drawing.Point(800, 85);
            this.txtFiltreMin.Name = "txtFiltreMin";
            this.txtFiltreMin.Size = new System.Drawing.Size(100, 20);
            this.txtFiltreMin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max";
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(808, 145);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltre.TabIndex = 9;
            this.btnFiltre.Text = "Filter";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // kriterAra
            // 
            this.kriterAra.FormattingEnabled = true;
            this.kriterAra.Items.AddRange(new object[] {
            "#",
            "Name",
            "Type 1",
            "Type 2",
            "Total",
            "Hp",
            "Attack",
            "Deffence",
            "Sp. Atk",
            "Sp. Def",
            "Speed",
            "Generation",
            "Legendary"});
            this.kriterAra.Location = new System.Drawing.Point(926, 58);
            this.kriterAra.Name = "kriterAra";
            this.kriterAra.Size = new System.Drawing.Size(135, 21);
            this.kriterAra.TabIndex = 10;
            this.kriterAra.Text = "Criteria";
            // 
            // txtAramaGirdi
            // 
            this.txtAramaGirdi.Location = new System.Drawing.Point(926, 98);
            this.txtAramaGirdi.Name = "txtAramaGirdi";
            this.txtAramaGirdi.Size = new System.Drawing.Size(135, 20);
            this.txtAramaGirdi.TabIndex = 11;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(953, 124);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Search";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search Word";
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(899, 270);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(75, 23);
            this.btnFight.TabIndex = 14;
            this.btnFight.Text = "Fight!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // txtPokeName1
            // 
            this.txtPokeName1.Location = new System.Drawing.Point(899, 218);
            this.txtPokeName1.Name = "txtPokeName1";
            this.txtPokeName1.Size = new System.Drawing.Size(100, 20);
            this.txtPokeName1.TabIndex = 15;
            // 
            // txtPokeName2
            // 
            this.txtPokeName2.Location = new System.Drawing.Point(899, 244);
            this.txtPokeName2.Name = "txtPokeName2";
            this.txtPokeName2.Size = new System.Drawing.Size(100, 20);
            this.txtPokeName2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "1. Pokémon\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "2. Pokémon\'s Name";
            // 
            // txtFightResult
            // 
            this.txtFightResult.Location = new System.Drawing.Point(899, 299);
            this.txtFightResult.Name = "txtFightResult";
            this.txtFightResult.Size = new System.Drawing.Size(162, 20);
            this.txtFightResult.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "AAAND THE RESULT IS:";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(817, 365);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(244, 20);
            this.txtError.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ERROR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pokémon Fight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(950, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(791, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Filter";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(899, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 438);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFightResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPokeName2);
            this.Controls.Add(this.txtPokeName1);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAramaGirdi);
            this.Controls.Add(this.kriterAra);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltreMin);
            this.Controls.Add(this.txtFiltreMax);
            this.Controls.Add(this.kriterFiltre);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnParseDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnParseDisplay;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox kriterFiltre;
        private System.Windows.Forms.TextBox txtFiltreMax;
        private System.Windows.Forms.TextBox txtFiltreMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.ComboBox kriterAra;
        private System.Windows.Forms.TextBox txtAramaGirdi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.TextBox txtPokeName1;
        private System.Windows.Forms.TextBox txtPokeName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFightResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
    }
}

