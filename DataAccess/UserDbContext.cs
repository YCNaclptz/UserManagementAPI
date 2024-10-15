using Microsoft.EntityFrameworkCore;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Location>()
            .HasKey(l => new { l.Province, l.City });

            modelBuilder.Entity<Location>().HasData(
            new Location { Province = "廣東", City = "廣州" },
            new Location { Province = "廣東", City = "深圳" },
            new Location { Province = "廣東", City = "珠海" },
            new Location { Province = "福建", City = "福州" },
            new Location { Province = "福建", City = "廈門" },
            new Location { Province = "廣西", City = "南寧" },
            new Location { Province = "廣西", City = "桂林" },
            new Location { Province = "上海", City = "上海" },
            new Location { Province = "北京", City = "北京" }
            );

            modelBuilder.Entity<User>()
                .HasData(
                    new User { Email = "zhangsan@example.com", Password = "password123", Name = "張三", Age = 26, Gender = Gender.Male, Province = "上海", City = "上海" },
                    new User { Email = "lisi@example.com", Password = "password123", Name = "李四", Age = 25, Gender = Gender.Female, Province = "北京", City = "北京" },
                    new User { Email = "wangwu@example.com", Password = "password123", Name = "王五", Age = 20, Gender = Gender.Male, Province = "廣東", City = "廣州" },
                    new User { Email = "zhaoliu@example.com", Password = "password123", Name = "趙六", Age = 30, Gender = Gender.Female, Province = "廣東", City = "深圳" },
                    new User { Email = "sunqi@example.com", Password = "password123", Name = "孫七", Age = 22, Gender = Gender.Male, Province = "廣東", City = "珠海" },
                    new User { Email = "zhouba@example.com", Password = "password123", Name = "周八", Age = 28, Gender = Gender.Female, Province = "廣西", City = "南寧" },
                    new User { Email = "wujia@example.com", Password = "password123", Name = "吳九", Age = 24, Gender = Gender.Male, Province = "廣西", City = "桂林" },
                    new User { Email = "zhengshi@example.com", Password = "password123", Name = "鄭十", Age = 27, Gender = Gender.Female, Province = "福建", City = "廈門" },
                    new User { Email = "wangyi@example.com", Password = "password123", Name = "王一", Age = 23, Gender = Gender.Male, Province = "福建", City = "福州" },
                    new User { Email = "liuer@example.com", Password = "password123", Name = "李二", Age = 29, Gender = Gender.Female, Province = "上海", City = "上海" },
                    new User { Email = "zhangsan2@example.com", Password = "password123", Name = "張三二", Age = 21, Gender = Gender.Male, Province = "北京", City = "北京" },
                    new User { Email = "lisi2@example.com", Password = "password123", Name = "李四二", Age = 26, Gender = Gender.Female, Province = "廣東", City = "廣州" },
                    new User { Email = "wangwu2@example.com", Password = "password123", Name = "王五二", Age = 22, Gender = Gender.Male, Province = "廣東", City = "深圳" },
                    new User { Email = "zhaoliu2@example.com", Password = "password123", Name = "趙六二", Age = 31, Gender = Gender.Female, Province = "廣東", City = "珠海" },
                    new User { Email = "sunqi2@example.com", Password = "password123", Name = "孫七二", Age = 23, Gender = Gender.Female, Province = "上海", City = "上海" }
                );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
