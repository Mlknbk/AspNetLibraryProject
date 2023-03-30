﻿using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Library.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.StudentID, x.BookID });

            builder
                .HasOne(o => o.Book)
                .WithMany(b => b.Operations)
                .HasForeignKey(o => o.BookID);
            builder
                .HasOne(o => o.Student)
                .WithMany(s => s.Operations)
                .HasForeignKey(o => o.StudentID);
        }
    }
}
