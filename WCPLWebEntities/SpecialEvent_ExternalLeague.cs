//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCPLWebEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpecialEvent_ExternalLeague
    {
        public int SpecialEventId { get; set; }
        public int ExternalLeagueId { get; set; }
        public System.DateTime CreateDateTime { get; set; }
    
        public virtual ExternalLeague ExternalLeague { get; set; }
        public virtual SpecialEvent SpecialEvent { get; set; }
    }
}
