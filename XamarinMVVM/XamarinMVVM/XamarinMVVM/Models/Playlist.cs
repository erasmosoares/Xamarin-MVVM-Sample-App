using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamarinMVVM.ViewModels;

namespace XamarinMVVM.Models
{
    public class Playlist
    {
        public string Title { get; set; }
        public bool IsFavorite { get; set; }

    }
}
