﻿using Gerador_de_Testes.Dominio.ModuloDisciplina;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerador_de_Testes.Infraestrutura.Orm.ModuloDisciplina;
public class MapeadorDisciplinaOrm : IEntityTypeConfiguration<Disciplina>
{
    public void Configure(EntityTypeBuilder<Disciplina> builder)
    {
        builder.Property(d => d.Id)
            .ValueGeneratedNever().IsRequired();

        builder.Property(d => d.Nome)
            .HasMaxLength(100).IsRequired();

        builder.HasMany(d => d.Testes)
            .WithOne(t => t.Disciplina);

         builder.HasMany(d => d.Materias)
            .WithOne(m => m.Disciplina);
    }
}