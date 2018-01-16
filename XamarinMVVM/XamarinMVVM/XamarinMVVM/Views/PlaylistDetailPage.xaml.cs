using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMVVM.Models;
using XamarinMVVM.ViewModels;

namespace XamarinMVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistDetailPage : ContentPage
	{
        private PlaylistViewModel _playlist;

        public PlaylistDetailPage (PlaylistViewModel playlist)
		{
            _playlist = playlist;

            InitializeComponent ();

            title.Text = _playlist.Title;
        }
	}
}