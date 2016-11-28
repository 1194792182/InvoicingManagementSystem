using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Yjj.Web.Models.TableEntities.Tests
{
    public class Test
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestId { get; set; }

        public string TestName { get; set; }
    }
}