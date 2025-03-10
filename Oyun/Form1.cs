using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Transactions;
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
			sam.Health_Potion = true;
		}
		private async void  Attackcycle(int Super = 1)
		{
			sam.attack(goblin,Super);
			mainlabel.Text = "-" + Convert.ToString(sam.attack_damage);
			Superbutton.Text = Convert.ToString(sam.Super) + " Super Power";
			if (goblin.Health <= 0)
			{
				mainlabel.Text = "You Win";
				DisableControls(false);
				label2.Text = Convert.ToString(goblin.Health) + " HP ";

			}
			else
			{
				label2.Text = Convert.ToString(goblin.Health) + " HP ";
				DisableControls(false);
				await Task.Delay(1000);
				goblin.attack(sam);
				mainlabel.Text = "-" + Convert.ToString(goblin.attack_damage);
				if (sam.Health <= 0)
				{
					mainlabel.Text = "You Lost";
					label1.Text = Convert.ToString(sam.Health) + " HP ";
					DisableControls(false);
				}
				else
				{
					label1.Text = Convert.ToString(sam.Health) + " HP ";
					DisableControls(true);
				}
			}
		}
		private void DisableControls(bool x)
		{
			foreach (Control control in Controls)
			{
				control.Enabled= x;
			}
		}
		private void attackbutton_Click(object sender, EventArgs e)
		{
			Attackcycle();
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

		private void Superbutton_Click(object sender, EventArgs e)
		{
			if (sam.Super == 3)
			{
				Attackcycle(3);
				sam.Super = 1;
				Superbutton.Text = Convert.ToString(sam.Super) + " Super Power";
			}
			else
			{
				Superbutton.Text = "Super power can be perform after 3 defenses";
			}
		}

		private async void defensebutton_Click(object sender, EventArgs e)
		{
			sam.defense = true;
			DisableControls(false);
			await Task.Delay(1000);
			goblin.attack(sam);
			mainlabel.Text = "-" + Convert.ToString(goblin.attack_damage);
			if (sam.Health <= 0)
			{
				mainlabel.Text = "KAYBETT�N";
				DisableControls(false);
			}
			else
			{
				label1.Text = Convert.ToString(sam.Health) + " HP ";
				DisableControls(true);
			}
			sam.defense = false;
			Superbutton.Text = Convert.ToString(sam.Super)+" Super Power";

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
		public int Power = 10;
		public int Health = 100;
		public int Super = 1;
		public bool Health_Potion;
		public bool defense;
		public int attack_damage;
		public void attack(Creature enemy, int Super = 1)
		{
			Random rast = new Random();
			if (enemy.defense)
			{
				int damage = rast.Next(1 * (Power * Super)/ 10, (5 * (Power * Super / 10)));
				enemy.Health -= damage;
				attack_damage = damage;
				if (enemy.Super < 3) { enemy.Super += 1; }
				else { }
			}
			else
			{
				int damage = rast.Next(2 * (Power * Super / 10), (10 * (Power * Super / 10)));
				enemy.Health -= damage;
				attack_damage = damage;
			}
		}
	}
}