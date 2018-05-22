using BilleniumProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BilleniumProjekt.DAL
{
    public class FormInitializer : DropCreateDatabaseAlways<FormDataContext>
    { 

        protected override void Seed(FormDataContext context)
        {
            SeedPeopleData(context);
            base.Seed(context);
        }

        private void SeedPeopleData(FormDataContext context)
        {
            var dane = new List<ContactData>
            {
                new ContactData() {ContactDataId = 1, Name="Test1",Surname="Test2",Comment="Com1"}
            };

            dane.ForEach(k => context.ContactData.Add(k));
            context.SaveChanges();
        }
    }
}