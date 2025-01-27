﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ched.UI.Shortcuts
{
    public static class Commands
    {
        // MenuStrip
        public static string NewFile => "files.new";
        public static string OpenFile => "files.open";
        public static string Save => "files.save";
        public static string SaveAs => "files.saveAs";
        public static string ReExport => "files.reExport";
        public static string ShowScoreBookProperties => "editor.action.showScoreBookProperties";
        public static string ShowShortcutSettings => "application.showShortcutSettings";

        public static string Undo => "editor.action.undo";
        public static string Redo => "editor.action.redo";
        public static string Jump => "editor.action.jump";

        public static string Cut => "editor.action.clipboardCut";
        public static string Copy => "editor.action.clipboardCopy";
        public static string Paste => "editor.action.clipboardPaste";
        public static string PasteFlip => "editor.action.clipboardPasteFlip";

        public static string CutSelectedEvents => "editor.action.cutSelectedEvents";
        public static string CopySelectedEvents => "editor.action.copySelectedEvents";
        public static string PasteEvents => "editor.action.pasteEvents";

        public static string SelectAll => "editor.action.selectAll";
        public static string SelectToBegin => "editor.action.selectToBegin";
        public static string SelectToEnd => "editor.action.selectToEnd";

        public static string FlipSelectedNotes => "editor.action.flipSelectedNotes";
        public static string RemoveSelectedNotes => "editor.action.removeSelectedNotes";
        public static string RemoveSelectedEvents => "editor.action.removeSelectedEvents";

        public static string SwitchScorePreviewMode => "editor.view.switchScorePreviewMode";

        public static string WidenLaneWidth => "editor.view.widenLaneWidth";
        public static string NarrowLaneWidth => "editor.view.narrowLaneWidth";

        public static string InsertBpmChange => "editor.action.insertBpmChange";
        public static string InsertTimeSignatureChange => "editor.action.insertTimeSignatureChange";
        public static string InsertHighSpeedChange => "editor.action.insertHighSpeedChange";
        public static string InsertSplitLineChange => "editor.action.insertSplitLineChange";

        public static string PlayPreview => "editor.view.playPreview";

        public static string ShowHelp => "application.showHelp";

        // ToolStrip
        public static string SelectPen => "editor.selectPen";
        public static string SelectSelection => "editor.selectSelection";
        public static string SelectEraser => "editor.selectEraser";

        public static string ZoomIn => "editor.view.zoomIn";
        public static string ZoomOut => "editor.view.zoomOut";

        public static string SelectTap => "editor.selectTap";
        public static string SelectExTap => "editor.selectExTap";
        public static string SelectExTapDown => "editor.selectExTap";
        public static string SelectExTapCenter => "editor.selectExTap";
        public static string SelectHold => "editor.selectHold";
        public static string SelectSlide => "editor.selectSlide";
        public static string SelectSlideStep => "editor.selectSlideStep";
        public static string SelectSlideCurve => "editor.selectSlideCurve";
        public static string SelectAir => "editor.selectAir";
        public static string SelectAirUp => "editor.selectAirUp";
        public static string SelectAirDown => "editor.selectAirDown";
        public static string SelectAirAction => "editor.selectAirAction";
        public static string SelectFlick => "editor.selectFlick";
        public static string SelectDamage => "editor.selectDamage";

        public static string SeekForward => "editor.seekForward";
        public static string SeekFastForward => "editor.seekFastForward";
        public static string SeekBackward => "editor.seekBackward";
        public static string SeekFastBackward => "editor.seekFastBackward";
    }
}
