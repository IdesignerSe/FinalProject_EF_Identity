using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Habit.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MVC_Habit.Models
{
    public class HabitContext : IdentityDbContext<AdvancedUser>
    {
        public HabitContext(DbContextOptions<HabitContext> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<Habit> Habits { get; set; }

        public DbSet<MVC_Habit.Models.ProgramSet> ProgramSet { get; set; }

        public DbSet<MVC_Habit.Models.Article> Article { get; set; }
    }
}
//Saving to Github
