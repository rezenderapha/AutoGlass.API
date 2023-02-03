using AutoGlass.API.Domain.Context.ModelsBuilder;
using AutoGlass.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AutoGlass.API.Domain.Context
{
    public class AutoGlassContext : DbContext
    {
        public AutoGlassContext(DbContextOptions<AutoGlassContext> options) : base(options) { }
        private static bool _created = false;
        public AutoGlassContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>().AddBuilder();
            builder.Entity<Fornecedor>().AddBuilder();
            base.OnModelCreating(builder);

            builder.Entity<Fornecedor>()
                .HasData(new List<Fornecedor>()
                {
                    new Fornecedor(1,"Mil e uma peças","43336155000106",true),
                    new Fornecedor(2,"Felicidade em Fornecer","82824469000100",true),
                    new Fornecedor(3,"Uma noite na oficina","45315523000165", true),
                    new Fornecedor(4,"A peça filosofal","02770479000170", true),
                    new Fornecedor(5,"Um desejo, uma peça","27580353000164", true),
                    new Fornecedor(6,"Peças e Morty","44732984000170", true),
                    new Fornecedor(7,"The big bang peças","08884481000157", true),
                    new Fornecedor(8,"Fornecedor do Norte","71151701000170", true)
                });

            builder.Entity<Produto>()
                .HasData(new List<Produto>()
                {
                    new Produto(1,"Retrovisor Civic",true,null, null,1),
                    new Produto(2,"Parachoque Corsa",true,System.DateTime.Now.AddDays(-134), DateTime.Now.AddDays(472),2),
                    new Produto(3,"Lanterna Fiorino",true,System.DateTime.Now.AddDays(-720), DateTime.Now.AddDays(345),2),
                    new Produto(4,"Retrovisor Tucson",true,null, null,3),
                    new Produto(5,"Parachoque Palio",true,System.DateTime.Now.AddDays(-647), DateTime.Now.AddDays(321),4),
                    new Produto(6,"Radiador Citroen",true,System.DateTime.Now, DateTime.Now.AddDays(7145),5),
                    new Produto(7,"Ventoinha Onix",true,System.DateTime.Now, DateTime.Now.AddDays(474),6),
                    new Produto(8,"Grade Ford Ka",true,System.DateTime.Now, DateTime.Now.AddDays(897),6),
                    new Produto(9,"Reservatorio de Agua Kwid",true,System.DateTime.Now, DateTime.Now.AddDays(987),6),
                    new Produto(10,"Radiador Ford",true,System.DateTime.Now, DateTime.Now.AddDays(648),8),
                    new Produto(11,"Porta Fusca",true,System.DateTime.Now.AddDays(-1000), DateTime.Now.AddDays(648),3)
                });
        }
    }
}
