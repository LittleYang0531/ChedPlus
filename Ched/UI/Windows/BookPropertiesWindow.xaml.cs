﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Ched.Core;
using Ched.Localization;

namespace Ched.UI.Windows
{
    /// <summary>
    /// Interaction logic for BookPropertiesWindow.xaml
    /// </summary>
    public partial class BookPropertiesWindow : Window
    {
        public BookPropertiesWindow()
        {
            InitializeComponent();
        }
    }

    public class BookPropertiesWindowViewModel : ViewModel
    {
        private ScoreBook ScoreBook { get; } = new ScoreBook();
        private SoundSource MusicSource { get; set; } = new SoundSource();

        public string SoundSourceFilter { get; } = Helpers.GetFilterString(FileFilterStrings.AudioFilter, SoundSource.SupportedExtensions);
        public Action<string> SetMusicSourceFileAction => path => MusicSourcePath = path;

        private string title;
        public string Title
        {
            get => title;
            set
            {
                if (value == title) return;
                title = value;
                NotifyPropertyChanged();
            }
        }

        private string artist;
        public string Artist
        {
            get => artist;
            set
            {
                if (value == artist) return;
                artist = value;
                NotifyPropertyChanged();
            }
        }

        private string notesDesigner;
        public string NotesDesigner
        {
            get => notesDesigner;
            set
            {
                if (value == notesDesigner) return;
                notesDesigner = value;
                NotifyPropertyChanged();
            }
        }

        private string musicSourcePath;
        public string MusicSourcePath
        {
            get => musicSourcePath;
            set
            {
                if (value == musicSourcePath) return;
                musicSourcePath = value;
                NotifyPropertyChanged();
            }
        }

        private double musicSourceLatency;
        public double MusicSourceLatency
        {
            get => musicSourceLatency;
            set
            {
                if (value == musicSourceLatency) return;
                musicSourceLatency = value;
                NotifyPropertyChanged();
            }
        }

        public BookPropertiesWindowViewModel()
        {
        }

        public BookPropertiesWindowViewModel(ScoreBook scoreBook, SoundSource musicSource)
        {
            ScoreBook = scoreBook;
            MusicSource = musicSource;
        }

        public void BeginEdit()
        {
            Title = ScoreBook.Title;
            Artist = ScoreBook.ArtistName;
            NotesDesigner = ScoreBook.NotesDesignerName;

            MusicSource.FilePath = ScoreBook.Wave;
            MusicSource.Latency = ScoreBook.WaveOffset;
            MusicSourcePath = ScoreBook.Wave;
            MusicSourceLatency = ScoreBook.WaveOffset;
        }

        public void CommitEdit()
        {
            ScoreBook.Title = Title;
            ScoreBook.ArtistName = Artist;
            ScoreBook.NotesDesignerName = NotesDesigner;

            MusicSource.FilePath = MusicSourcePath;
            MusicSource.Latency = MusicSourceLatency;
            ScoreBook.Wave = MusicSourcePath;
            ScoreBook.WaveOffset = MusicSourceLatency;
        }
    }
}
