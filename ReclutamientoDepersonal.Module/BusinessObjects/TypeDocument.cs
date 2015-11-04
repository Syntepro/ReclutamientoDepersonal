using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace ReclutamientoDepersonal.Module.BusinessObjects
{
    [DefaultClassOptions]
   
    public class TypeDocument : BaseObject
    { 
        public TypeDocument(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
       
        public string DocumentName   { get; set; }
        public string DocumentNumber { get; set; }
        public Person person { get; set; }

    }
}
