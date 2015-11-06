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
using ReclutamientoDepersonal.Module.Util;

namespace ReclutamientoDepersonal.Module.BusinessObjects
{
    public class Documentation : BaseObject
    { 
        public Documentation(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
       
        public TypeDocument TypeDocument   { get; set; }
        public string DocumentNumber { get; set; }

    }
}
