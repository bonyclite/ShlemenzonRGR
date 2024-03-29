﻿namespace ServerApp.DataModel
{
    using ModelDataBase.DBPublicationTypes;
    using ModelDataBase.DBPublicationTypes.DBNewsTypes;
    using ModelDataBase.DBUserTypes;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class NewsForumContext : DbContext
    {
        private static NewsForumContext newsForumContext = new NewsForumContext();

        public static NewsForumContext GetNewsForumContext => newsForumContext;

        public DbSet<DBUser> Users { get; set; }
        public DbSet<DBPublication> Publications { get; set; }
        public DbSet<DBActor> Actors { get; set; }
        public DbSet<DBGenre> Genres { get; set; }
        public DbSet<DBMusicPublication> MusicPublications { get; set; }
        public DbSet<DBGamePubliaction> GamePublications { get; set; }
        public DbSet<DBFilmPublication> FilmPublications { get; set; }
        public DbSet<DBNewsPublication> NewsPublications { get; set; }
        public DbSet<DBInfoFile> InfoFiles { get; set; }
        public DbSet<DBNewsElement> NewsElements { get; set; }
        public DbSet<DBNewsElementFile> NewsElementFiles { get; set; }
        public DbSet<DBRating> Ratings { get; set; }
        public DbSet<DBComment> Comments { get; set; }
        
        public NewsForumContext()
            : base("NewsForumContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}