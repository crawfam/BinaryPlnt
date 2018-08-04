using BinaryPlanet.Models;
using System.Collections.Generic;
using System.Linq;


namespace BinaryPlanet.ViewModels
{
    public class TableOfContentsViewModel
    {

        private readonly ApplicationDbContext _context;
        private readonly List<Poem> _poems;
        private readonly int _bpUserId = -1;
        private readonly List<int> _readPoems = new List<int>();


        public List<Poem> Section1Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 1).OrderBy(p => p.Sequence).ToList();
            }
                
        }

        public List<Poem> Section2Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 2).OrderBy(p => p.Sequence).ToList();
            }

        }

        public List<Poem> Section3Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 3).OrderBy(p => p.Sequence).ToList();
            }

        }

        public List<Poem> Section4Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 4).OrderBy(p => p.Sequence).ToList();
            }

        }

        public bool HasRead(int poemId)
        {
            if (_bpUserId == -1)
            {
                // user is not logged in                 
                return false;
            }
            else if (_readPoems.Count < 1)
            {
                // logged in but none read
                return false;
            }
            else if (_readPoems.Contains(poemId))
            {
                // has read poem of this Id
                return true;
            }

            // default - just show the TOC
            return false;

        }


        public TableOfContentsViewModel()
        {
            _context = new ApplicationDbContext();
            _poems = _context.Poems.Where(p => p.Sequence != null).ToList();
        }

        public TableOfContentsViewModel(int BPUserId) : this()
        {
            _bpUserId = BPUserId;

            // get list of all poems seen by user
            _readPoems = _context.BPUserPoems.Where(s => s.BPUserId == _bpUserId).Select(s => s.PoemId).ToList();

        }




    }
}