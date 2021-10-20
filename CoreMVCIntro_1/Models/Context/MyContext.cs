using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro_1.Models.Context
{
    //EntityFrameworkCore.SqlServer kütüphanesini indirmeyi unutmayın...Options ayarları yoksa gelmeyecektir... 

    public class MyContext:DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) :base(options)
        {

        }


    }
}
