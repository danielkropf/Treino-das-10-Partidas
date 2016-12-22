using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino_das_10_Partidas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private List<GamePlayed> gamesPlayed = new List<GamePlayed>();
		private List<String> positivePoints = new List<string>();
		private List<String> negativePoints = new List<string>();

		private void NewGameTab_Button_AddGame_Click(object sender, EventArgs e)
		{

			#region Transformando em Array
			int[] frag = new int[3];
				frag[0] = Convert.ToInt32(NewGameTab_Numeric_Kill.Value);
				frag[1] = Convert.ToInt32(NewGameTab_Numeric_Death.Value);
				frag[2] = Convert.ToInt32(NewGameTab_Numeric_Assist.Value);

			string[] pp = new string[positivePoints.Count];
			string[] np = new string[negativePoints.Count];

			for (int i = 0; i < positivePoints.Count; i++)
			{
				pp[i] = positivePoints[i];
			}
			for (int i = 0; i < negativePoints.Count; i++)
			{
				np[i] = negativePoints[i];
			}
			#endregion

			#region NewGame
			GamePlayed thisGame = new GamePlayed();
			thisGame.champion = NewGameTab_ComboBox_Champion.Text;
			thisGame.lane = Lane();
			thisGame.frag = frag;
			thisGame.status = Status();
			thisGame.postivePoints = pp;
			thisGame.negativePoints = np;
			#endregion

			#region Limpando Campos
			NewGameTab_ComboBox_Champion.Text = "";

			NewGameTab_ComboBox_Lane.Text = "";

			NewGameTab_Numeric_Kill.Value = 0;
			NewGameTab_Numeric_Death.Value = 0;
			NewGameTab_Numeric_Assist.Value = 0;

			NewGameTab_Radio_Vitoria.Checked = true;
			NewGameTab_Radio_Derrota.Checked = false;

			NewGameTab_TextBox_PositivePoints.Clear();
			NewGameTab_ListBox_PositivePoints.Items.Clear();

			NewGameTab_TextBox_NegativePoints.Clear();
			NewGameTab_ListBox_NegativePoints.Items.Clear();
			#endregion

			gamesPlayed.Add(thisGame);

		}

		private void NewGameTab_Button_PositivePoints_Click(object sender, EventArgs e)
		{
			positivePoints.Add(NewGameTab_TextBox_PositivePoints.Text);
			NewGameTab_ListBox_PositivePoints.Items.Add(" - " + NewGameTab_TextBox_PositivePoints.Text);
			NewGameTab_TextBox_PositivePoints.Clear();
		}

		private void NewGameTab_Button_NegativePoints_Click(object sender, EventArgs e)
		{
			negativePoints.Add(NewGameTab_TextBox_NegativePoints.Text);
			NewGameTab_ListBox_NegativePoints.Items.Add(" - " + NewGameTab_TextBox_NegativePoints.Text);
			NewGameTab_TextBox_NegativePoints.Clear();
		}

		private int Lane() 
		{
			int a = 0;

			switch (NewGameTab_ComboBox_Lane.Text)
			{
				case "Top":
					a = 0;
					break;

				case "Jungle":
					a = 1;
					break;

				case "Mid":
					a =  2;
					break;

				case "Adc":
					a =  3;
					break;

				case "Sup":
					a =  4;
					break;
			}

			return a;

		}

		private int Status()
		{
			int a = 0;

			switch (NewGameTab_Radio_Vitoria.Checked)
			{
				case true:
					a = 0;
					break;

				case false:
					a = 1;
					break;
			}

			return a;
		}
	}
}
