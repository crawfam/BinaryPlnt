using BinaryPlanet.Models;
using System.Collections.Generic;
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
        private readonly List<int> _sequenceNumbers;

        public PoemViewModel(int Id)
        {
            _context = new ApplicationDbContext();

            _poem = _context.Poems.Where(p => p.Id == Id).FirstOrDefault();

            _fileName = string.IsNullOrEmpty(_poem.SpecialName) ? _poem.Name.ToLower().Replace(" ", "_") : _poem.SpecialName;

            _minSeq = _context.Poems.Select(p => p.Sequence).Min();
            _maxSeq = _context.Poems.Select(p => p.Sequence).Max();

            _sequenceNumbers = _context.Poems.OrderBy(p => p.Sequence).Select(p => p.Sequence).ToList();

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
                    int index = _sequenceNumbers.IndexOf(_poem.Sequence);
                    int nextSequenceNum = _sequenceNumbers[index + 1];
                    return _context.Poems.Where(p => p.Sequence == nextSequenceNum).Select(p => p.Id).FirstOrDefault();
                }
            }
        }

        public int PrevPoemId
        {
            get
            {
                if (_poem.Sequence == _minSeq)
                {
                    return _maxSeq;
                }
                else
                {
                    int index = _sequenceNumbers.IndexOf(_poem.Sequence);
                    int prevSequenceNum = _sequenceNumbers[index - 1];
                    return _context.Poems.Where(p => p.Sequence == prevSequenceNum).Select(p => p.Id).FirstOrDefault();
                }
            }


        }
    }
}