using ConsoleApp29.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.configuration
{
    internal class studentconf : IEntityTypeConfiguration<student>
    {
        public void Configure(EntityTypeBuilder<student> builder)
        {
            builder.HasKey(d => d.id);
            builder.Property(nameof(student.address)).HasDefaultValue("cairo");

        }
    }
}
