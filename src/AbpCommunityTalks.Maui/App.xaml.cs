﻿namespace AbpCommunityTalks.Maui;

public partial class App : Application
{
	public App(MainPage mainPage)
	{
		InitializeComponent();

		MainPage = mainPage;
	}
}
