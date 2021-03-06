﻿using ExploreCalifornia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExploreCalifornia.DAL
{
    public class ExploreCaliforniaContext : DbContext
    {
        public ExploreCaliforniaContext() : base("ExploreCaliforniaDB")
        {

        }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Trail> Trails { get; set; }
    }
}