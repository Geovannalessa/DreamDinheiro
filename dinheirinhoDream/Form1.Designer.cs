namespace dinheirinhoDream
{
	partial class home
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
			label_metas = new Label();
			txt_meta = new TextBox();
			btn_salvar_metas = new Button();
			groupBox1 = new GroupBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label_metas
			// 
			label_metas.AutoSize = true;
			label_metas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label_metas.ForeColor = SystemColors.ButtonHighlight;
			label_metas.Location = new Point(25, 168);
			label_metas.Name = "label_metas";
			label_metas.Size = new Size(181, 30);
			label_metas.TabIndex = 0;
			label_metas.Text = "Digite suas metas";
			label_metas.Click += label1_Click;
			// 
			// txt_meta
			// 
			txt_meta.Location = new Point(25, 201);
			txt_meta.Name = "txt_meta";
			txt_meta.PlaceholderText = "tirar a carteira?";
			txt_meta.Size = new Size(457, 31);
			txt_meta.TabIndex = 1;
			txt_meta.TextChanged += textBox1_TextChanged;
			// 
			// btn_salvar_metas
			// 
			btn_salvar_metas.BackColor = Color.FromArgb(192, 255, 255);
			btn_salvar_metas.Location = new Point(187, 437);
			btn_salvar_metas.Name = "btn_salvar_metas";
			btn_salvar_metas.Size = new Size(120, 51);
			btn_salvar_metas.TabIndex = 2;
			btn_salvar_metas.Text = "Salvar";
			btn_salvar_metas.UseVisualStyleBackColor = false;
			btn_salvar_metas.Click += button1_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txt_meta);
			groupBox1.Controls.Add(label_metas);
			groupBox1.Controls.Add(btn_salvar_metas);
			groupBox1.Location = new Point(301, 54);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(511, 503);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(90, 62);
			label1.Name = "label1";
			label1.Size = new Size(323, 62);
			label1.TabIndex = 3;
			label1.Text = "DreamDinheiro";
			label1.Click += label1_Click_1;
			// 
			// home
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 192, 192);
			ClientSize = new Size(1173, 663);
			Controls.Add(groupBox1);
			Name = "home";
			Text = "Home";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label_metas;
		private TextBox txt_meta;
		private Button btn_salvar_metas;
		private GroupBox groupBox1;
		private Label label1;
	}
}
