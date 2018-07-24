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


        public List<Poem> Section1Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 1).ToList();
            }
                
        }

        public List<Poem> Section2Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 2).ToList();
            }

        }

        public List<Poem> Section3Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 3).ToList();
            }

        }

        public List<Poem> Section4Poems
        {
            get
            {
                return _poems.Where(s => s.Section == 4).ToList();
            }

        }

        public bool HasRead
        {
            get
            {
                return _bpUserId == -1 ? false : true; 
            }
        }


        public TableOfContentsViewModel()
        {
            _context = new ApplicationDbContext();
            _poems = _context.Poems.ToList();
        }

        public TableOfContentsViewModel(int BPUserId) : this()
        {
            _bpUserId = BPUserId;
        }




    }
}