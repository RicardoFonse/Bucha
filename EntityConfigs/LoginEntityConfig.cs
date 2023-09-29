using SenaiAlimentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SenaiAlimentos.EntityConfigs;
public class LoginEntityConfig : IEntityTypeConfiguration<Login>{

public void Configure(EntityTypeBuilder<Login> builder)
    {
        builder.ToTable("Login");
        builder.HasKey(l=>l.Id);
        builder.Property(l=> l.Nome)
               .HasColumnType("varchar(80)")
               .IsRequired();
        builder.Property(l=> l.Email)
               .HasColumnType("varchar(60)")
               .IsRequired();
        builder.Property(l=> l.Senha)
               .HasColumnType("char(8)")
               .IsRequired();


    }

}