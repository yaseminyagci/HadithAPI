using Hadith.Core.CustomException;
using Hadith.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingSystem.Data.Context
{
    public class EFHadithContext : DbContext
    {
        //public EFHadithContext()
        //    : base("BookingContext")
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //}

        //public override int SaveChanges()
        //{
        //    var result = 0;
        //    try
        //    {
        //        result = base.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        // özelleştir
        //        throw new DatabaseException("DataBaseExcetion", ex);
        //    }
        //    return result;
        //}

     

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
   
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}