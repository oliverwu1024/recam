using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Recam.Models.Entities;

namespace Recam.DataAccess.Data;
//dbcontext is to commect between database and code
public class RecamDbContext: IdentityDbContext<User>
{
    public RecamDbContext(DbContextOptions<RecamDbContext> options) : base(options)
    {
        
    }

    public DbSet<ListingCase> ListingCases {get; set;}
    public DbSet<Agent> Agents {get; set;}
    public DbSet<AgentListingCase> AgentListingCases {get; set;}
    public DbSet<AgentPhotographyCompany> AgentPhotographyCompanies {get; set;}
    public DbSet<CaseContact> CaseContacts {get; set;}
    public DbSet<MediaAsset> MediaAssets {get; set;}
    public DbSet<PhotographyCompany> PhotographyCompanies {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CaseContact>().HasKey(c => c.ContactId);
        modelBuilder.Entity<AgentListingCase>().HasKey(aL => new {aL.AgentId, aL.ListingCaseId});
        modelBuilder.Entity<AgentPhotographyCompany>().HasKey(aP => new {aP.AgentId, aP.PhotographyCompanyId});

        modelBuilder.Entity<Agent>()
            .HasOne(a => a.User)
            .WithOne(u=> u.Agent)
            .HasForeignKey<Agent>(a=>a.Id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PhotographyCompany>()
            .HasOne(pc=> pc.User)
            .WithOne(u=>u.PhotographyCompany)
            .HasForeignKey<PhotographyCompany>(pc=>pc.Id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ListingCase>()
            .HasOne(lc => lc.User)
            .WithMany(u=>u.ListingCases)
            .HasForeignKey(lc=>lc.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ListingCase>()
            .Property(lc => lc.Latitude)
            .HasPrecision(9,6);

        modelBuilder.Entity<ListingCase>()
            .Property(lc => lc.Longitude)
            .HasPrecision(9,6);            

        modelBuilder.Entity<ListingCase>()
            .Property(lc => lc.Title)
            .HasMaxLength(255);   

        modelBuilder.Entity<MediaAsset>()
            .HasOne(ma => ma.User)
            .WithMany(u => u.MediaAssets)
            .HasForeignKey(ma => ma.UserId)
            .OnDelete(DeleteBehavior.Restrict);


    }



}
