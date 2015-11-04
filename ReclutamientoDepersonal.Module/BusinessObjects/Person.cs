﻿using System;
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
    public class Person : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Person(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public ESexo Sexo { get; set; }
        public DateTime BirthDate { get; set; }
        
        
    }
}
