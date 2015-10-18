using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TextInputTutorial
{
	[Activity (Label = "TextInputTutorial", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get TextView and EditText
			var editText = FindViewById<EditText> (Resource.Id.txtEditText);
			var textView = FindViewById<TextView> (Resource.Id.lblTextView);

			// Get the value of editText
			var userInput = editText.Text;

			// Add event handler for text change
			editText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => 
			{
				textView.Text = e.Text.ToString();
			}; 

		}
	}
}


