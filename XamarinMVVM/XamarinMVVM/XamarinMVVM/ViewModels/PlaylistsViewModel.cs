using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVM.Models;
using XamarinMVVM.Views;

namespace XamarinMVVM.ViewModels
{
    public class PlaylistsViewModel : BaseViewModel
    {
        private PlaylistViewModel _selectedPlaylist;
        private readonly IPageService _pageService;

        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistViewModel>();
        public ICommand AddPlaylistCommand { get; private set; }
        public ICommand SelectPlaylistCommand { get; private set; }

        public PlaylistsViewModel(IPageService pageService)
        {
            _pageService = pageService;

            AddPlaylistCommand = new Command(AddPlaylist);
            SelectPlaylistCommand = new Command<PlaylistViewModel>(async vm => await SelectPlayList(vm));
        }

        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlaylist; }
            set{ SetValue(ref _selectedPlaylist, value); }
        }

        private void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        private async Task SelectPlayList(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;
            
            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            await _pageService.PushAsync(new PlaylistDetailPage(playlist));
        }
    }
}
