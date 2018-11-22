using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DifuseBomb
{
	public partial class MainPage : ContentPage
	{
		static string bomb = new Random().Next(1, 4).ToString(); // Assign random value to variable bomb every time
		static int scores = 0; // initialize score to 0 on start up

		
		public MainPage()
		{
			InitializeComponent();
		}

		async void Buttonclicked(object sender, EventArgs e)
		{
			Button button = sender as Button;
			//Game over
			if (button.Text == bomb)
			{
				await DisplayAlert("Bomb Exploded", "Game over", "Retry!");
				//var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
				//player.Load("Alarm01.wav");
				bomb = new Random().Next(1, 4).ToString();
				scores = 0;
			} else
			{
				scores += 1;
				await DisplayAlert("Bomb Defused!", "Scores:" + scores, "Continue");
				bomb = new Random().Next(1, 4).ToString();
			}

		}
		


	}
}
