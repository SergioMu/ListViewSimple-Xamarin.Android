using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace TutorialListView
{
	[Activity (Label = "TutorialListView", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private List<string> misElementos;
		private ListView misSeries;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			misSeries = FindViewById<ListView> (Resource.Id.miLista);

			misElementos = new List<string>();
			misElementos.Add ("The Walking Dead");
			misElementos.Add ("El Mentalista");
			misElementos.Add ("Big Bang");
			misElementos.Add ("New Girl");

			//ArrayAdapter<String> adaptador = new ArrayAdapter<string>(this, 
			//	Android.Resource.Layout.SimpleListItem1, misElementos);

			ListViewAdapter adaptador = new ListViewAdapter (this, misElementos);

			misSeries.Adapter = adaptador;

		}
	}
}