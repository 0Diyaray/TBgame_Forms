using System.Diagnostics.Eventing.Reader;
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
		private async void attackbutton_Click(object sender, EventArgs e)
		{
			int damagedone = sam.damagepower();
			goblin.Health -= damagedone;
			mainlabel.Text = "-" + Convert.ToString(damagedone);
			if (goblin.Health <= 0)
			{
				mainlabel.Text = "KAZANDIN";
				DisableControls();
			}
			else
			{
				label2.Text = Convert.ToString(goblin.Health) + " HP " + "Level:" + goblin.Level;
			}
			await Task.Delay(4000);
			int damagetaken = goblin.damagepower();
			sam.Health -= damagetaken;
			mainlabel.Text = "-" + Convert.ToString(damagetaken);
			if (sam.Health <= 0)
			{
				mainlabel.Text = "KAYBETTÝN";
				DisableControls();
			}
			else
			{
				label1.Text = Convert.ToString(sam.Health) + " HP " + "Level:" + sam.Level;
			}

		}

		private void label1_Click(object sender, EventArgs e)
		{
			
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
			sam.Level += 1;
			label1.Text = Convert.ToString(sam.Health) + " HP " + "Level:" + sam.Level;
		}

		private void defensebutton_Click(object sender, EventArgs e)
		{

		}

		private void damagetaken_Click(object sender, EventArgs e)
		{

		}

		private void health_potion_button_Click(object sender, EventArgs e)
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
					health_potion_button.Text = "Out of potions";
					stor += 1;
				}
				else if (stor == 10)
				{
					health_potion_button.Text = "Out of potions!!!";
				}
			}
		}
	}
	public class Creature
	{
		public int Power;
		public int Health;
		public int Level;
		public bool Health_Potion;
		public bool defense;
		public int damagepower()
		{
			Random rast = new Random();
			if (defense)
			{
				int damage = rast.Next(1 * (Power * Level / 1), (5 * (Power * Level / 10)));
				return damage;
			}
			else
			{
				int damage = rast.Next(1 * (Power * Level / 10), (10 * (Power * Level / 10)));
				return damage;
			}
		}
	}
}