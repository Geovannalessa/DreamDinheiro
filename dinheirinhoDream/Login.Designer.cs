namespace dinheirinhoDream
{
	partial class Login
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
			btn_Entrar = new Button();
			btn_Cancelar = new Button();
			label1 = new Label();
			label2 = new Label();
			txt_usuario = new TextBox();
			groupBox1 = new GroupBox();
			linkLabel1 = new LinkLabel();
			txt_senha = new TextBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btn_Entrar
			// 
			btn_Entrar.Location = new Point(266, 313);
			btn_Entrar.Name = "btn_Entrar";
			btn_Entrar.Size = new Size(108, 43);
			btn_Entrar.TabIndex = 0;
			btn_Entrar.Text = "Entrar";
			btn_Entrar.UseVisualStyleBackColor = true;
			btn_Entrar.Click += btn_Entrar_Click;
			// 
			// btn_Cancelar
			// 
			btn_Cancelar.Location = new Point(69, 313);
			btn_Cancelar.Name = "btn_Cancelar";
			btn_Cancelar.Size = new Size(106, 43);
			btn_Cancelar.TabIndex = 1;
			btn_Cancelar.Text = "Cancelar";
			btn_Cancelar.UseVisualStyleBackColor = true;
			btn_Cancelar.Click += btn_Cancelar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(59, 57);
			label1.Name = "label1";
			label1.Size = new Size(76, 25);
			label1.TabIndex = 2;
			label1.Text = "Usuário:";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(59, 136);
			label2.Name = "label2";
			label2.Size = new Size(64, 25);
			label2.TabIndex = 3;
			label2.Text = "Senha:";
			// 
			// txt_usuario
			// 
			txt_usuario.Location = new Point(59, 85);
			txt_usuario.Name = "txt_usuario";
			txt_usuario.PlaceholderText = "Digite seu usuario";
			txt_usuario.Size = new Size(315, 31);
			txt_usuario.TabIndex = 4;
			txt_usuario.TextChanged += txt_usuario_TextChanged;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.ButtonHighlight;
			groupBox1.Controls.Add(linkLabel1);
			groupBox1.Controls.Add(btn_Cancelar);
			groupBox1.Controls.Add(txt_senha);
			groupBox1.Controls.Add(btn_Entrar);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txt_usuario);
			groupBox1.Location = new Point(172, 36);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(443, 384);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "EconomyDream";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(138, 220);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(159, 25);
			linkLabel1.TabIndex = 6;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Esqueceu a senha?";
			// 
			// txt_senha
			// 
			txt_senha.Location = new Point(59, 164);
			txt_senha.Name = "txt_senha";
			txt_senha.PlaceholderText = "Digite sua senha";
			txt_senha.Size = new Size(315, 31);
			txt_senha.TabIndex = 5;
			txt_senha.UseSystemPasswordChar = true;
			txt_senha.TextChanged += txt_senha_TextChanged;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox1);
			Name = "Login";
			Text = "EconomyDream";
			Load += Login_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button btn_Entrar;
		private Button btn_Cancelar;
		private Label label1;
		private Label label2;
		private TextBox txt_usuario;
		private GroupBox groupBox1;
		private TextBox txt_senha;
		private LinkLabel linkLabel1;
	}
}