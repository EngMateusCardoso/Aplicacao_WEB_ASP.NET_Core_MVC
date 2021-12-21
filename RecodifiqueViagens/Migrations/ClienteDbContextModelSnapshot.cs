﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecodifiqueViagens.Models;

namespace RecodifiqueViagens.Migrations
{
    [DbContext(typeof(ClienteDbContext))]
    partial class ClienteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecodifiqueViagens.Models.Agendamento_Destinos", b =>
                {
                    b.Property<int>("Id_Agendamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formaPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Agendamento");

                    b.ToTable("agendamentos");
                });

            modelBuilder.Entity("RecodifiqueViagens.Models.Cadastro_Mensagem_Contato", b =>
                {
                    b.Property<int>("Id_Msg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("aceitaReceberNot")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("msg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeDeContato")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Msg");

                    b.ToTable("mensagens");
                });
#pragma warning restore 612, 618
        }
    }
}