using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
			sam.Level = 1;
			goblin.Power = 10;
			goblin.Health = 100;
			goblin.Level = 1;
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
				label2.Text = Convert.ToString(goblin.Health)+" HP "+"Level:"+goblin.Level;
			}
			sam.Health -= goblin.attack();
			if (sam.Health <= 0)
			{
				label3.Text = "KAYBETTÝN";
				DisableControls();
			}
			else
			{
				label1.Text = Convert.ToString(sam.Health)+" HP " + "Level:" + sam.Level;
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
					label3.Text = "Out of potions";
					stor += 1;
				}
				else if (stor == 10)
				{
					label3.Text = "Out of potions!!!";
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

		private void Levelbutton_Click(object sender, EventArgs e)
		{
			sam.Levelup();
			label1.Text = Convert.ToString(sam.Health) + " HP " + "Level:" + sam.Level;
		}
	}
	public class Creature
	{
		public int Power;
		public int Health;
		public int Level;
		public bool Health_Potion;
		public int attack()
		{
			Random rast = new Random();
			int hasar = rast.Next(1 * (Power*Level / 10), (10 * (Power*Level / 10)));
			return hasar;
		}
		public void Levelup()
		{
			Level += 1;
		}

	}
}