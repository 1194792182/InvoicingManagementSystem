using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Yjj.Web.Models.TableEntities.Tests;

namespace Yjj.Web.Models.CurrentDbContext
{
    public class ImsDc : ApplicationDbContext
    {
        public DbSet<Test> YjjTests { get; set; }
    }
}