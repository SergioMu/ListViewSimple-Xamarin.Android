using System;

using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using Android.Views;

namespace TutorialListView
{
	public class ListViewAdapter : BaseAdapter<string>
	{
		private List<String> nElementos;
		private Context nContext;

		public ListViewAdapter(Context context, List<string> elementos){
			nElementos = elementos;
			nContext = context;
		}

		public override int Count
		{
			get{return nElementos.Count;}
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override string this[int position] {
			get {
				return nElementos [position];
			}
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View fila = convertView;
			if (fila == null) {
				fila = LayoutInflater.From (nContext).Inflate(Resource.Layout.Filas_ListView, null, false);
			}

			TextView txtNom = fila.FindViewById<TextView> (Resource.Id.txtNombre);
			txtNom.Text = nElementos [position];

			return fila;
		}
		
	}
}

