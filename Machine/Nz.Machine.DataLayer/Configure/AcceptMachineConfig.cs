using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Machine.Model.Model;

namespace Nz.Machine.DataLayer.Configure
{
    public class AcceptMachineConfiguration : EntityTypeConfiguration<AcceptMachine>
    {
        public AcceptMachineConfiguration()
        {
            this.ToTable("Machine.tbl_AcceptMachine");

            this
                .HasKey(x => x.ID);

            this
                .Property(x=>x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this
                .Property(e => e.TarixAccept)
                .HasColumnType("date");

            this
                .Property(e => e.TimeAccept)
                .HasColumnType("time");

            this
                .Property(x => x.Mobile)
                .IsFixedLength()
                .HasMaxLength(20)
                .IsOptional();

            this
                .Property(x => x.HomeAddress)
                .IsFixedLength()
                .HasMaxLength(300)
                .IsOptional();

            this
                .Property(x => x.WorkAddress)
                .IsFixedLength()
                .HasMaxLength(300)
                .IsOptional();

            this
                .Property(x => x.Job)
                .IsFixedLength()
                .HasMaxLength(150)
                .IsOptional();

            this
                .Property(x => x.Plak)
                .IsFixedLength()
                .HasMaxLength(30)
                .IsOptional();

            this
                .Property(x => x.KindMachine)
                .IsFixedLength()
                .HasMaxLength(50)
                .IsOptional();

            this.Property(x => x.Benzin)
                .HasColumnType("decimal")
                .HasPrecision(18,3);

            this
                .Property(x => x.MachineColor)
                .IsFixedLength()
                .HasMaxLength(20)
                .IsOptional();

            this
                .Property(x => x.ShomareShasi)
                .IsFixedLength()
                .HasMaxLength(50)
                .IsOptional();


            this
                .Property(x => x.ShomareMotor)
                .IsFixedLength()
                .HasMaxLength(50)
                .IsOptional();

            this
                .Property(x => x.ShomareMotor)
                .IsFixedLength()
                .HasMaxLength(50)
                .IsOptional();

            this
                .Property(x => x.CustomerRequest)
                .IsFixedLength()
                .HasMaxLength(500)
                .IsOptional();

            this
                .Property(x => x.Descipt)
                .IsFixedLength()
                .HasMaxLength(500)
                .IsOptional();

        }
    }
}
