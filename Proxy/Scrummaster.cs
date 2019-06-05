using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Scrummaster : IDeveloper
    {
        string _CurrentCodeChanges = "";
        string _CurrentChangesCommited = "";
        string _CurrentChangesPushed = "";

        public void WriteCode(string code)
        {
            _CurrentCodeChanges += code;
        }

        public void Commit()
        {
            if (_CurrentCodeChanges == string.Empty)
            {
                Console.WriteLine("No changes to commit!");
                return;
            }
            _CurrentChangesCommited += _CurrentCodeChanges;
            _CurrentCodeChanges = "";
            Console.WriteLine("Changes commited!");

        }

        public void Push()
        {
            if (_CurrentChangesCommited == string.Empty)
            {
                Console.WriteLine("No changes commited!");
                return;
            }
            _CurrentChangesPushed += _CurrentChangesCommited;
            _CurrentChangesCommited = "";
            Console.WriteLine("Changes pushed!");
        }

        //Here happens the magic!
        public void Merge(string commitToMerge)
        {
            Console.WriteLine("Merged commit into Master: " + commitToMerge);
        }
    }
}
