using BilleniumProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BilleniumProjekt.DAL
{
    public class FormDataContext : DbContext
    {
        public FormDataContext() : base("FormContext")
        {

        }      

        public DbSet<ContactData> ContactData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBilder)
        {
            base.OnModelCreating(modelBilder);
            modelBilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}