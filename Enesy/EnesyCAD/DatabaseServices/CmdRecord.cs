﻿

namespace Enesy.EnesyCAD.DatabaseServices
{
    internal struct CmdRecord
    {
        public string GlobalName, Tag, Description, Author, Email, Help, Category;

        public CmdRecord(string globalName, string tab, string description, 
            string author, string email, string help, string category)
        {
            GlobalName = globalName;
            Tag = tab;
            Description = description;
            Author = author;
            Email = email;
            Help = help;
            Category = category;
        }
    }
}
