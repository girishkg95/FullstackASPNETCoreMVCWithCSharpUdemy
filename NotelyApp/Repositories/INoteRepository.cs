﻿using NotelyApp.Models;
using System;
using System.Collections.Generic;

namespace NotelyApp.Repositories
{
    public interface INoteRepository
    {
        void deleteNote(NoteModel noteModel);
        NoteModel FindNoteById(Guid id);
        IEnumerable<NoteModel> GetAllNotes();
        void SaveNote(NoteModel noteModel);
    }
}