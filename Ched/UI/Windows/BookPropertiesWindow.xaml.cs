using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Ched.Core;
using Ched.Localization;
using Newtonsoft.Json.Linq;

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

        private double previewSpeed;
        public double PreviewSpeed
        {
            get => previewSpeed;
            set
            {
                if (value == previewSpeed) return;
                previewSpeed = value;
                (Father.Controls.Find("PreviewSpeedBox", true)[0] as NumericUpDown).Value = (decimal)value;
                NotifyPropertyChanged();
            }
        }

        private double volume;
        public double Volume
        {
            get => volume;
            set
            {
                if (value == volume) return;
                volume = value;
                NotifyPropertyChanged();
            }
        }

        private double sfxVolume;
        public double SfxVolume
        {
            get => sfxVolume;
            set
            {
                if (value == sfxVolume) return;
                sfxVolume = value;
                NotifyPropertyChanged();
            }
        }

        private MainForm Father { get; set; }

        public BookPropertiesWindowViewModel(MainForm father)
        {
            Father = father;
        }

        public BookPropertiesWindowViewModel(MainForm father, ScoreBook scoreBook, SoundSource musicSource)
        {
            Father = father;
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
            PreviewSpeed = MusicSource.PreviewSpeed;
            Volume = MusicSource.Volume;
            SfxVolume = MusicSource.SfxVolume;
        }

        public void CommitEdit()
        {
            ScoreBook.Title = Title;
            ScoreBook.ArtistName = Artist;
            ScoreBook.NotesDesignerName = NotesDesigner;

            MusicSource.FilePath = MusicSourcePath;
            MusicSource.Latency = MusicSourceLatency;
            MusicSource.PreviewSpeed = PreviewSpeed;
            ScoreBook.Wave = MusicSourcePath;
            ScoreBook.WaveOffset = MusicSourceLatency;
            MusicSource.Volume = Volume;
            MusicSource.SfxVolume = SfxVolume;
        }
    }
}
