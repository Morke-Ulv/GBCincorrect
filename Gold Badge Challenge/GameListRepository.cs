using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Challenge
{
    class GameListRepository
    {
        protected List<Games> _contentDictionary = new List<Games>();

        public bool AddContentToDictionary(Games content)
        {
            int startingCount = _contentDictionary.Count;

            _contentDictionary.Add(content);

            bool wasAdded = (_contentDictionary.Count > startingCount);
            return wasAdded;
        }

        public bool RemoveContentByTitle(string title)
        {
            int startingCount = _contentDictionary.Count;
            int index = -1;
            foreach (Games content in _contentDictionary)
            {
                if(content.Title == title)
                {
                    index = _contentDictionary.IndexOf(content);
                }
            }
            if (index != -1)
            {
                _contentDictionary.RemoveAt(index);
            }
            bool wasRemoved = (_contentDictionary.Count < startingCount);
            return wasRemoved;
        }
    
        public List<Games> GetContentPlayed()
        {
            return _contentDictionary;
        }
    }

}
