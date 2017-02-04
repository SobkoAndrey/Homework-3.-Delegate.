using System;
using System.Collections.Generic;
using Gtk;
using DelegateGTK;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnStartButtonClicked(object sender, EventArgs e)
	{

		TextLabel.Text = string.Empty;
		string text = TextField.Text;

		if (MainClass.methodsList != null)
			TextLabel.Text = MainClass.StringOperations(text, MainClass.methodsList);

		/*
		if (!MainClass.IsEmpty(TextLabel.Text))

			text = TextLabel.Text;

		if (ToUpperCheckButton.Active)
		{
			TextLabel.Text = MainClass.StringOperations(text, MainClass.ToUpperString);
			text = TextLabel.Text;
		}

		if (TurnStringCheckButton.Active)
		{
			TextLabel.Text = MainClass.StringOperations(text, MainClass.TurnString);
			text = TextLabel.Text;
		}

		if (AddSpacesCheckButton.Active)
		{
			TextLabel.Text = MainClass.StringOperations(text, MainClass.AddSpacesToString);
			text = TextLabel.Text;
		}
*/

	}

	protected void OnToUpperCheckButtonClicked(object sender, EventArgs e)
	{

		if (ToUpperCheckButton.Active)
		{
			MainClass.methodsList.Add(MainClass.ToUpperString);
		}
		else
		{
			MainClass.methodsList.Remove(MainClass.ToUpperString);
		}
	}

	protected void OnTurnStringCheckButtonClicked(object sender, EventArgs e)
	{

		if (TurnStringCheckButton.Active)
		{
			MainClass.methodsList.Add(MainClass.TurnString);
		}
		else
		{
			MainClass.methodsList.Remove(MainClass.TurnString);
		}

	}

	protected void OnAddSpacesCheckButtonClicked(object sender, EventArgs e)
	{
		
		if (AddSpacesCheckButton.Active)
		{
			MainClass.methodsList.Add(MainClass.AddSpacesToString);
		}
		else
		{
			MainClass.methodsList.Remove(MainClass.AddSpacesToString);
		}

	}
}
