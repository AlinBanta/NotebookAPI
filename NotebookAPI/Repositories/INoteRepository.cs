using NotebookAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotebookAPI.Repositories
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetAllNotes();

        Task<Note> GetNote(string id);

        // query after multiple parameters
        Task<IEnumerable<Note>> GetNote(string bodyText, DateTime updatedFrom, long headerSizeLimit);

        // add new note document
        Task AddNote(Note item);

        // remove a single document / note
        Task<bool> RemoveNote(string id);

        Task<bool> RemoveAllNotes();

        // update just a single document
        Task<bool> UpdateNote(string id, string body);

        // update just a single document
        Task<bool> UpdateNote(string id, Note item);

        //demo interface - full document update
        Task<bool> UpdateNoteDocument(string id, string body);

        // creates a sample index
        Task<string> CreateIndex();
    }
}
