using System.Runtime.CompilerServices;

namespace Oyun
{
	public partial class Form1 : Form
	{
		Creature sam = new Creature();
		Creature goblin = new Creature();
		int stor = 0;

		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			sam.Power = 10;
			sam.Health = 100;
			goblin.Power = 10;
			goblin.Health = 100;
			sam.Health_Potion = true;
		}
		private void DisableControls()
		{
			foreach (Control control in Controls)
			{
				control.Enabled = false;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			goblin.Health -= sam.attack();
			if (goblin.Health <= 0)
			{
				label3.Text = "KAZANDIN";
				DisableControls();
			}
			else
			{
				label2.Text = Convert.ToString(goblin.Health);
			}
			sam.Health -= goblin.attack();
			if (sam.Health <= 0)
			{
				label3.Text = "KAYBETT�N";
				DisableControls();
			}
			else
			{
				label1.Text = Convert.ToString(sam.Health);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			if (sam.Health_Potion == true)
			{
				sam.Health += 50;
				sam.Health_Potion = false;
				label1.Text = Convert.ToString(sam.Health);
			}
			else
			{
				if (stor < 10)
				{
					Story.Texts(label1);
					stor += 1;
				}
				else if (stor == 10)
				{
					Story.Texts2(label1);
				}
			}
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
	public class Creature
	{
		public int Power;
		public int Health;
		public bool Health_Potion;
		public int attack(int damage_coefficent = 1)
		{
			Random rast = new Random();
			int hasar = rast.Next(1*damage_coefficent, 10*damage_coefficent);
			return hasar;
		}
	}
	public class Story
	{
		public static string Texts(Label label)
		{
			label.Text = "�KS�R�N KALMADI";
			return label.Text;
		}
		public static string Texts2(Label label)
		{
			label.Text = "�KS�R�N KALMADI!!!";
			return label.Text;
		}
	}
}