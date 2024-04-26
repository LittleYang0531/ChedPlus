using Ched.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sus2Image.Converter
{
    public class SusScoreData
    {
        public int TicksPerBeat { get; set; } = 192;
        public Dictionary<int, double> BpmDefinitions { get; set; } = new Dictionary<int, double>() { { 0, 120 } };
        public Dictionary<int, double> TimeSignatures { get; set; } = new Dictionary<int, double>() { { 0, 4.0 } };
        public List<HighSpeedChangeEvent> HiSpeeds { get; set; } = new List<HighSpeedChangeEvent>();
        public List<SplitLineChangeEvent> SplitLines { get; set; } = new List<SplitLineChangeEvent>();

        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string DesignerName { get; set; }
        public int Difficulty { get; set; }
        public string PlayLevel { get; set; }
        public string SongId { get; set; }
        public string Wave { get; set; }
        public double WaveOffset { get; set; }
        public string Jacket { get; set; }

        public Dictionary<char, List<NoteDefinition>> ShortNotes { get; set; }
        public Dictionary<char, List<List<NoteDefinition>>> LongNotes { get; set; }

        public int GetLastTick()
        {
            return Math.Max(
                ShortNotes.Count > 0 ? ShortNotes.Max(p => p.Value.Count > 0 ? p.Value.Max(q => q.Position.Tick) : 0) : 0,
                LongNotes.Count > 0 ? LongNotes.Max(p => p.Value.Count > 0 ? p.Value.Max(r => r.Max(s => s.Position.Tick)) : 0) : 0
                );
        }
    }

    public struct NoteDefinition
    {
        public int LineIndex { get; set; }
        public char Type { get; set; }
        public NotePosition Position { get; set; }
    }

    public struct NotePosition
    {
        public int Tick { get; set; }
        public int LaneIndex { get; set; }
        public int Width { get; set; }
    }
}
