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
       
        public EDocument Document   { get; set; }
        public string DocumentNumber { get; set; }

    }
}
