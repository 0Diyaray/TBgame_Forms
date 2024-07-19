namespace Oyun
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			attackbutton = new Button();
			label1 = new Label();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			mainlabel = new Label();
			bindingSource1 = new BindingSource(components);
			Superbutton = new Button();
			defensebutton = new Button();
			health_potion_button = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			SuspendLayout();
			// 
			// attackbutton
			// 
			attackbutton.Location = new Point(281, 362);
			attackbutton.Name = "attackbutton";
			attackbutton.Size = new Size(147, 76);
			attackbutton.TabIndex = 0;
			attackbutton.Text = "Attack";
			attackbutton.UseVisualStyleBackColor = true;
			attackbutton.Click += attackbutton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(90, 32);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 1;
			label1.Text = "Health";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(569, 32);
			label2.Name = "label2";
			label2.Size = new Size(45, 15);
			label2.TabIndex = 2;
			label2.Text = "Goblin ";
			label2.Click += label2_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(455, 78);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(267, 246);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 82);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(253, 246);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// mainlabel
			// 
			mainlabel.Font = new Font("Segoe UI", 20F);
			mainlabel.Location = new Point(271, 181);
			mainlabel.Name = "mainlabel";
			mainlabel.Size = new Size(178, 55);
			mainlabel.TabIndex = 5;
			mainlabel.TextAlign = ContentAlignment.MiddleCenter;
			mainlabel.Click += label3_Click;
			// 
			// Superbutton
			// 
			Superbutton.Location = new Point(281, 69);
			Superbutton.Name = "Superbutton";
			Superbutton.Size = new Size(147, 60);
			Superbutton.TabIndex = 6;
			Superbutton.Text = "Super";
			Superbutton.UseVisualStyleBackColor = true;
			Superbutton.Click += Superbutton_Click;
			// 
			// defensebutton
			// 
			defensebutton.Location = new Point(281, 247);
			defensebutton.Name = "defensebutton";
			defensebutton.Size = new Size(147, 66);
			defensebutton.TabIndex = 7;
			defensebutton.Text = "Defense";
			defensebutton.UseVisualStyleBackColor = true;
			defensebutton.Click += defensebutton_Click;
			// 
			// health_potion_button
			// 
			health_potion_button.Location = new Point(12, 362);
			health_potion_button.Name = "health_potion_button";
			health_potion_button.Size = new Size(73, 48);
			health_potion_button.TabIndex = 8;
			health_potion_button.Text = "Health Potion";
			health_potion_button.UseVisualStyleBackColor = true;
			health_potion_button.Click += health_potion_button_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(800, 450);
			Controls.Add(health_potion_button);
			Controls.Add(defensebutton);
			Controls.Add(Superbutton);
			Controls.Add(mainlabel);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(attackbutton);
			Name = "Form1";
			Text = "OYON";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button attackbutton;
		private Label label1;
		private Label label2;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label mainlabel;
		private BindingSource bindingSource1;
		private Button Superbutton;
		private Button defensebutton;
		private Button health_potion_button;
	}
}
