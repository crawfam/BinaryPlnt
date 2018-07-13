using BinaryPlanet.Models;
using System.Linq;

namespace BinaryPlanet.ViewModels
{
    public class PoemViewModel
    {
        private readonly Poem _poem;
        private readonly string _fileName;
        private readonly int _minSeq;
        private readonly int _maxSeq;
        private readonly ApplicationDbContext _context;

        public PoemViewModel(int Id)
        {
            _context = new ApplicationDbContext();

            _poem = _context.Poems.Where(p => p.Id == Id).FirstOrDefault();

            _fileName = string.IsNullOrEmpty(_poem.SpecialName) ? _poem.Name.ToLower().Replace(" ", "_") : _poem.SpecialName;

            _minSeq = _context.Poems.Select(p => p.Sequence).Min();
            _maxSeq = _context.Poems.Select(p => p.Sequence).Max();
        }


        public string Name
        {
            get
            {
                return _poem.Name;
            }
        }

        public string FileNameJpg
        {
            get
            {
                return "../../Content/images/away/" + _fileName + ".jpg";
            }
        }


        public string FileNameView
        {
            get
            {
                return _fileName;
            }
        }

        public int NextPoemId
        {
            get
            {
                if (_poem.Sequence == _maxSeq)
                {
                    return _minSeq;
                }
                else
                {
                    return _poem.Sequence + 1;
                }
            }
        }

        public int PrevPoemId
        {
            get
            {
                if (_poem.Sequence ==_minSeq)
                {
                    return _maxSeq;
                }
                else
                {
                    return _poem.Sequence -1;
                }
            }
        }


    }
}