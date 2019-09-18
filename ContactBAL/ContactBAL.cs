using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ContactDAL;

namespace ContactBAL
{
    public class ContactBAL
    {
        public void Add(ContactRecord c)
        {
            c.Id = ContactDAL.LastId++;
            ContactDAL.contactList.Add(c);
        }
        public void Update(ContactRecord c)
        {
            ContactDAL.contactList.Where(x => x.Id == c.Id).Single(x => x.Note = c.Note);
        }
        public void Delete(ContactRecord c)
        {
            ContactDAL.contactList.Where(x => x.Id == c.Id).Single(x => x.IsActive = false);
        }
        public List<ContactRecord> GetAll()
        {
            return ContactDAL.contactList;
        }
    }
}
