using Moq;
using NUnit.Framework;
using XamarinMVVM.ViewModels;

namespace XamarinMVVM.Tests
{

    [TestFixture]
    public class MVVMTest
    {
        private PlaylistsViewModel _viewModel;
        private Mock<IPageService> _pageService;

        [SetUp]
        public void Setup()
        {
            _pageService = new Mock<IPageService>();
            _viewModel = new PlaylistsViewModel(_pageService.Object);
        }

        [Test()]
        public void AddPlaylistt_WhenCalled_TheNewPlaylist()
        {
            _viewModel.AddPlaylistCommand.Execute(null);

            Assert.AreEqual(1, _viewModel.Playlists.Count);
        }
    }
}
