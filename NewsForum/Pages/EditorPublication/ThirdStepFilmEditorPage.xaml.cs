﻿using Model.PublicationTypes;
using NewsForum.Model;
using Newtonsoft.Json;
using RequestServer;
using RequestServer.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModelDataBase.VMPublicationTypes;
using ViewModelDataBase.VMTypes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace NewsForum.Pages.EditorPublication
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ThirdStepDistributionEditorPage : Page
    {
        ObservableCollection<Actor> ListAutors = new ObservableCollection<Actor>();
        VMFilmPublication Publication { get; set; }

        public string[] Genres = GenreTypes.FilmGenres;
        public List<String> Actors { get; set; }

        public ThirdStepDistributionEditorPage()
        {
            this.InitializeComponent();
            ActorsListView.ItemsSource = ListAutors;
            EditPanelPublication.AddEditDescriptionBox(EditDescriptionBox);
        }

        async void LoadActors()
        {
            var answer = await ServerRequest.SendRequest(new MainRequest()
            {
                DataType = DataType.Actor,
                TypeRequest = TypeRequest.ReadSelf
            });
            Actors = JsonConvert.DeserializeObject<List<String>>(answer.ToString());
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Publication = e.Parameter as VMFilmPublication;
            LoadActors();
        }

        protected async override void OnNavigatedFrom(NavigationEventArgs e)
        {
            var file = await FilesAction.CreateLocalStorageFile("Description.rtf");
            await EditDescriptionBox.SaveDocumentStreamToFile(file);
            if (Publication != null)
            {
                Publication.ListGenres = GenresControl.SelectedGenres;
                Publication.ReleaseYear = RealeseDatePicker.GetCurrentDate.DateTime;
                Publication.ListFiles.Clear();
                Publication.ListActors = ListAutors.ToList();
                foreach (var item in AddPhotosControl.ListPhotos)
                {
                    Publication.ListFiles.Add(await FilesAction.ConvertToIFileVM(item, true));
                }
            }
        }

        private async Task AddFileToFilesPublic(StorageFile item)
        {
            var curr = await FilesAction.ConvertToIFileVM(item);
            Publication.ListFiles.Add(new VMFile()
            {
                Type = curr.Item1,
                Bytes = curr.Item2
            });
        }

        private void AddActorButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ListAutors.Add(new Actor());
        }

        private void DeleteActorsButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ListAutors.Remove(ActorsListView.SelectedItem as Actor);
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = sender.Text.ToLower();
                var results = Actors.Where(i => i.ToLower().Contains(term)).ToList();
                sender.ItemsSource = results;
            }
        }

        private void AutoSuggestBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var obj = sender as AutoSuggestBox;
            obj.ItemsSource = Actors;
            obj.IsSuggestionListOpen = true;
        }

        private void AutoSuggestBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var obj = sender as AutoSuggestBox;
            obj.IsSuggestionListOpen = false;
        }
    }
}