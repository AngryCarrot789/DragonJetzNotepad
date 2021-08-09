﻿using REghZyNotepad.Notepad;

namespace REghZyNotepad.Views {
    public interface IViewProvider {
        void OpenFormatView();
        void OpenGotoLineView();
        void OpenAboutView();
        void OpenFindView(bool replace);

        void UpdateCurrentEditor(NotepadEditorViewModel editor);
    }
}