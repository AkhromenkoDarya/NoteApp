using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Project
    {
        List<Note> _notes = null;

        public List<Note> Notes
        {
            get 
            {
                return _notes;
            }

            private set
            {
                _notes = value;
            }
        }

        public Project()
        {
            Notes = new List<Note>();
        }
    }
}
