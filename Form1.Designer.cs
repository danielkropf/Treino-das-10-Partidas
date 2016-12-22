namespace Treino_das_10_Partidas
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NewGameTab_Radio_Derrota = new System.Windows.Forms.RadioButton();
			this.NewGameTab_Radio_Vitoria = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NewGameTab_Numeric_Assist = new System.Windows.Forms.NumericUpDown();
			this.NewGameTab_Numeric_Death = new System.Windows.Forms.NumericUpDown();
			this.NewGameTab_Numeric_Kill = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NewGameTab_ComboBox_Champion = new System.Windows.Forms.ComboBox();
			this.NewGameTab_ComboBox_Lane = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.NewGameTab_TextBox_PositivePoints = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.NewGameTab_TextBox_NegativePoints = new System.Windows.Forms.TextBox();
			this.NewGameTab_Button_PositivePoints = new System.Windows.Forms.Button();
			this.NewGameTab_Button_NegativePoints = new System.Windows.Forms.Button();
			this.NewGameTab_ListBox_PositivePoints = new System.Windows.Forms.ListBox();
			this.NewGameTab_ListBox_NegativePoints = new System.Windows.Forms.ListBox();
			this.NewGameTab_Button_AddGame = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NewGameTab_Numeric_Assist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGameTab_Numeric_Death)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGameTab_Numeric_Kill)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.ItemSize = new System.Drawing.Size(66, 21);
			this.tabControl1.Location = new System.Drawing.Point(4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(649, 373);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.DimGray;
			this.tabPage1.Controls.Add(this.NewGameTab_Button_AddGame);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.NewGameTab_Radio_Derrota);
			this.tabPage1.Controls.Add(this.NewGameTab_Radio_Vitoria);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.NewGameTab_Numeric_Assist);
			this.tabPage1.Controls.Add(this.NewGameTab_Numeric_Death);
			this.tabPage1.Controls.Add(this.NewGameTab_Numeric_Kill);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.NewGameTab_ComboBox_Champion);
			this.tabPage1.Controls.Add(this.NewGameTab_ComboBox_Lane);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(641, 344);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "New Game";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.NewGameTab_ListBox_NegativePoints);
			this.groupBox2.Controls.Add(this.NewGameTab_Button_NegativePoints);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.NewGameTab_TextBox_NegativePoints);
			this.groupBox2.Location = new System.Drawing.Point(435, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(201, 332);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Negative Points";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NewGameTab_ListBox_PositivePoints);
			this.groupBox1.Controls.Add(this.NewGameTab_Button_PositivePoints);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.NewGameTab_TextBox_PositivePoints);
			this.groupBox1.Location = new System.Drawing.Point(219, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(201, 332);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Positive Points";
			// 
			// NewGameTab_Radio_Derrota
			// 
			this.NewGameTab_Radio_Derrota.AutoSize = true;
			this.NewGameTab_Radio_Derrota.Location = new System.Drawing.Point(18, 227);
			this.NewGameTab_Radio_Derrota.Name = "NewGameTab_Radio_Derrota";
			this.NewGameTab_Radio_Derrota.Size = new System.Drawing.Size(60, 17);
			this.NewGameTab_Radio_Derrota.TabIndex = 16;
			this.NewGameTab_Radio_Derrota.Text = "Derrota";
			this.NewGameTab_Radio_Derrota.UseVisualStyleBackColor = true;
			// 
			// NewGameTab_Radio_Vitoria
			// 
			this.NewGameTab_Radio_Vitoria.AutoSize = true;
			this.NewGameTab_Radio_Vitoria.BackColor = System.Drawing.Color.DimGray;
			this.NewGameTab_Radio_Vitoria.Checked = true;
			this.NewGameTab_Radio_Vitoria.Location = new System.Drawing.Point(18, 204);
			this.NewGameTab_Radio_Vitoria.Name = "NewGameTab_Radio_Vitoria";
			this.NewGameTab_Radio_Vitoria.Size = new System.Drawing.Size(54, 17);
			this.NewGameTab_Radio_Vitoria.TabIndex = 15;
			this.NewGameTab_Radio_Vitoria.TabStop = true;
			this.NewGameTab_Radio_Vitoria.Text = "Vitória";
			this.NewGameTab_Radio_Vitoria.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Vitória/Derrota:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(163, 117);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Assists";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(96, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Death";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Kill";
			// 
			// NewGameTab_Numeric_Assist
			// 
			this.NewGameTab_Numeric_Assist.Location = new System.Drawing.Point(146, 133);
			this.NewGameTab_Numeric_Assist.Name = "NewGameTab_Numeric_Assist";
			this.NewGameTab_Numeric_Assist.Size = new System.Drawing.Size(56, 20);
			this.NewGameTab_Numeric_Assist.TabIndex = 10;
			// 
			// NewGameTab_Numeric_Death
			// 
			this.NewGameTab_Numeric_Death.Location = new System.Drawing.Point(76, 133);
			this.NewGameTab_Numeric_Death.Name = "NewGameTab_Numeric_Death";
			this.NewGameTab_Numeric_Death.Size = new System.Drawing.Size(56, 20);
			this.NewGameTab_Numeric_Death.TabIndex = 9;
			// 
			// NewGameTab_Numeric_Kill
			// 
			this.NewGameTab_Numeric_Kill.Location = new System.Drawing.Point(6, 133);
			this.NewGameTab_Numeric_Kill.Name = "NewGameTab_Numeric_Kill";
			this.NewGameTab_Numeric_Kill.Size = new System.Drawing.Size(56, 20);
			this.NewGameTab_Numeric_Kill.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Frag:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Champion:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lane:";
			// 
			// NewGameTab_ComboBox_Champion
			// 
			this.NewGameTab_ComboBox_Champion.FormattingEnabled = true;
			this.NewGameTab_ComboBox_Champion.Location = new System.Drawing.Point(6, 71);
			this.NewGameTab_ComboBox_Champion.Name = "NewGameTab_ComboBox_Champion";
			this.NewGameTab_ComboBox_Champion.Size = new System.Drawing.Size(196, 21);
			this.NewGameTab_ComboBox_Champion.TabIndex = 1;
			// 
			// NewGameTab_ComboBox_Lane
			// 
			this.NewGameTab_ComboBox_Lane.FormattingEnabled = true;
			this.NewGameTab_ComboBox_Lane.Location = new System.Drawing.Point(6, 27);
			this.NewGameTab_ComboBox_Lane.Name = "NewGameTab_ComboBox_Lane";
			this.NewGameTab_ComboBox_Lane.Size = new System.Drawing.Size(196, 21);
			this.NewGameTab_ComboBox_Lane.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.DimGray;
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(641, 344);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Last Games";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.DimGray;
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(641, 344);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Oldest Games";
			// 
			// NewGameTab_TextBox_PositivePoints
			// 
			this.NewGameTab_TextBox_PositivePoints.Location = new System.Drawing.Point(6, 49);
			this.NewGameTab_TextBox_PositivePoints.Multiline = true;
			this.NewGameTab_TextBox_PositivePoints.Name = "NewGameTab_TextBox_PositivePoints";
			this.NewGameTab_TextBox_PositivePoints.Size = new System.Drawing.Size(189, 98);
			this.NewGameTab_TextBox_PositivePoints.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Point";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(21, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Point";
			// 
			// NewGameTab_TextBox_NegativePoints
			// 
			this.NewGameTab_TextBox_NegativePoints.Location = new System.Drawing.Point(6, 49);
			this.NewGameTab_TextBox_NegativePoints.Multiline = true;
			this.NewGameTab_TextBox_NegativePoints.Name = "NewGameTab_TextBox_NegativePoints";
			this.NewGameTab_TextBox_NegativePoints.Size = new System.Drawing.Size(189, 98);
			this.NewGameTab_TextBox_NegativePoints.TabIndex = 21;
			// 
			// NewGameTab_Button_PositivePoints
			// 
			this.NewGameTab_Button_PositivePoints.Location = new System.Drawing.Point(6, 162);
			this.NewGameTab_Button_PositivePoints.Name = "NewGameTab_Button_PositivePoints";
			this.NewGameTab_Button_PositivePoints.Size = new System.Drawing.Size(189, 23);
			this.NewGameTab_Button_PositivePoints.TabIndex = 22;
			this.NewGameTab_Button_PositivePoints.Text = "Adicionar";
			this.NewGameTab_Button_PositivePoints.UseVisualStyleBackColor = true;
			this.NewGameTab_Button_PositivePoints.Click += new System.EventHandler(this.NewGameTab_Button_PositivePoints_Click);
			// 
			// NewGameTab_Button_NegativePoints
			// 
			this.NewGameTab_Button_NegativePoints.Location = new System.Drawing.Point(6, 162);
			this.NewGameTab_Button_NegativePoints.Name = "NewGameTab_Button_NegativePoints";
			this.NewGameTab_Button_NegativePoints.Size = new System.Drawing.Size(189, 23);
			this.NewGameTab_Button_NegativePoints.TabIndex = 23;
			this.NewGameTab_Button_NegativePoints.Text = "Adicionar";
			this.NewGameTab_Button_NegativePoints.UseVisualStyleBackColor = true;
			this.NewGameTab_Button_NegativePoints.Click += new System.EventHandler(this.NewGameTab_Button_NegativePoints_Click);
			// 
			// NewGameTab_ListBox_PositivePoints
			// 
			this.NewGameTab_ListBox_PositivePoints.FormattingEnabled = true;
			this.NewGameTab_ListBox_PositivePoints.Location = new System.Drawing.Point(6, 198);
			this.NewGameTab_ListBox_PositivePoints.Name = "NewGameTab_ListBox_PositivePoints";
			this.NewGameTab_ListBox_PositivePoints.Size = new System.Drawing.Size(189, 121);
			this.NewGameTab_ListBox_PositivePoints.TabIndex = 24;
			// 
			// NewGameTab_ListBox_NegativePoints
			// 
			this.NewGameTab_ListBox_NegativePoints.FormattingEnabled = true;
			this.NewGameTab_ListBox_NegativePoints.Location = new System.Drawing.Point(6, 198);
			this.NewGameTab_ListBox_NegativePoints.Name = "NewGameTab_ListBox_NegativePoints";
			this.NewGameTab_ListBox_NegativePoints.Size = new System.Drawing.Size(189, 121);
			this.NewGameTab_ListBox_NegativePoints.TabIndex = 25;
			// 
			// NewGameTab_Button_AddGame
			// 
			this.NewGameTab_Button_AddGame.Location = new System.Drawing.Point(6, 302);
			this.NewGameTab_Button_AddGame.Name = "NewGameTab_Button_AddGame";
			this.NewGameTab_Button_AddGame.Size = new System.Drawing.Size(196, 23);
			this.NewGameTab_Button_AddGame.TabIndex = 25;
			this.NewGameTab_Button_AddGame.Text = "Adicionar";
			this.NewGameTab_Button_AddGame.UseVisualStyleBackColor = true;
			this.NewGameTab_Button_AddGame.Click += new System.EventHandler(this.NewGameTab_Button_AddGame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(657, 377);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NewGameTab_Numeric_Assist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGameTab_Numeric_Death)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGameTab_Numeric_Kill)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox NewGameTab_ComboBox_Champion;
		private System.Windows.Forms.ComboBox NewGameTab_ComboBox_Lane;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown NewGameTab_Numeric_Assist;
		private System.Windows.Forms.NumericUpDown NewGameTab_Numeric_Death;
		private System.Windows.Forms.NumericUpDown NewGameTab_Numeric_Kill;
		private System.Windows.Forms.RadioButton NewGameTab_Radio_Derrota;
		private System.Windows.Forms.RadioButton NewGameTab_Radio_Vitoria;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button NewGameTab_Button_AddGame;
		private System.Windows.Forms.ListBox NewGameTab_ListBox_NegativePoints;
		private System.Windows.Forms.Button NewGameTab_Button_NegativePoints;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox NewGameTab_TextBox_NegativePoints;
		private System.Windows.Forms.ListBox NewGameTab_ListBox_PositivePoints;
		private System.Windows.Forms.Button NewGameTab_Button_PositivePoints;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox NewGameTab_TextBox_PositivePoints;
	}
}

