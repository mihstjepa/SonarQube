//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistarAutomobila.Modeli
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModelAutomobila
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int SnagaMotora { get; set; }
        public decimal Cijena { get; set; }
        public Nullable<int> MarkaAutomobilaId { get; set; }
        public Nullable<int> KorisnikId { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual MarkaAutomobila MarkaAutomobila { get; set; }
    }
}