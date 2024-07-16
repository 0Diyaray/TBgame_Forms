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
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			label3 = new Label();
			bindingSource1 = new BindingSource(components);
			Levelbutton = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(281, 362);
			button1.Name = "button1";
			button1.Size = new Size(147, 76);
			button1.TabIndex = 0;
			button1.Text = "Attack";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
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
			pictureBox2.Location = new Point(12, 78);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(253, 246);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 20F);
			label3.Location = new Point(271, 177);
			label3.Name = "label3";
			label3.Size = new Size(178, 55);
			label3.TabIndex = 5;
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.Click += label3_Click;
			// 
			// Levelbutton
			// 
			Levelbutton.Location = new Point(281, 69);
			Levelbutton.Name = "button2";
			Levelbutton.Size = new Size(147, 60);
			Levelbutton.TabIndex = 6;
			Levelbutton.Text = "Level Up";
			Levelbutton.UseVisualStyleBackColor = true;
			Levelbutton.Click += Levelbutton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(800, 450);
			Controls.Add(Levelbutton);
			Controls.Add(label3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
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

		private Button button1;
		private Label label1;
		private Label label2;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label3;
		private BindingSource bindingSource1;
		private Button Levelbutton;
	}
}
