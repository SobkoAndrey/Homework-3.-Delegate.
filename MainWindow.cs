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
		
		/*
		if (ToUpperCheckButton.Active)
		{
			if (MainClass.IsEmpty(TextLabel.Text))

				TextLabel.Text = MainClass.StringOperations(TextField.Text, MainClass.ToUpperString);
			else
				TextLabel.Text = MainClass.StringOperations(TextLabel.Text, MainClass.ToUpperString);
		}

		if (TurnStringCheckButton.Active)
		{
			if (MainClass.IsEmpty(TextLabel.Text))

				TextLabel.Text = MainClass.StringOperations(TextField.Text, MainClass.TurnString);
			else
				TextLabel.Text = MainClass.StringOperations(TextLabel.Text, MainClass.TurnString);
		}

		if (AddSpacesCheckButton.Active)
		{
			if (MainClass.IsEmpty(TextLabel.Text))

				TextLabel.Text = MainClass.StringOperations(TextField.Text, MainClass.AddSpacesToString);
			else
				TextLabel.Text = MainClass.StringOperations(TextLabel.Text, MainClass.AddSpacesToString);
		}
		*/
	}
}
