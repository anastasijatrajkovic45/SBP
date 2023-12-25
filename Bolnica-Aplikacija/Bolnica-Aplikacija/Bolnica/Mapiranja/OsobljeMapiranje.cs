﻿using Bolnica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Mapiranja
{
    class OsobljeMapiranje : ClassMap<Osoblje>
    {
        public OsobljeMapiranje()
        {
            Table("OSOBLJE");

            Id(x => x.MatBr).Column("MAT_BR").GeneratedBy.SequenceIdentity("S18456.OSOBLJE_MAT_BR_SEQ");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
        }
    }
}