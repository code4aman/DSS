//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DecisionSupportSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parameter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int CombinationId { get; set; }
    
        public virtual Combination Combination { get; set; }
    }
}
