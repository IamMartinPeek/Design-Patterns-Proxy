using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    //Proxy
    public class SimpleDeveloper : IDeveloper
    {

        string _CurrentCodeChanges = "";
        string _CurrentChangesCommited = "";
        string _CurrentChangesPushed = "";
        Scrummaster _MyScrumMaster = new Scrummaster(); 

        public void WriteCode(string code)
        {
            _CurrentCodeChanges += code;
        }

        public void Commit()
        {
            if(_CurrentCodeChanges == string.Empty)
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
            if(_CurrentChangesCommited == string.Empty)
            {
                Console.WriteLine("No changes commited!");
                return;
            }
            _CurrentChangesPushed += _CurrentChangesCommited;
            _CurrentChangesCommited = "";
            Console.WriteLine("Changes pushed!");
        }

        //Here happens the magic!
        public void Merge(string commitNumber)
        {
            //Simple developer has no rights for merging, so he delegates it to the scrummaster
            _MyScrumMaster.Merge(commitNumber);
        }

       

    }
}
