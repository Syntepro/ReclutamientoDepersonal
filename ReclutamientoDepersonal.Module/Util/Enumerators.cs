using System;
using DevExpress.Xpo;

namespace ReclutamientoDepersonal.Module.Util
{

    public enum EDocument {
        DUI,
        NIT,
        PASSPORT        
    }

    public enum ESexo {
        Male,
        Female
    }

    public enum EproccessEstatus
    {
        Candidate,
        Meeting,
        Contracted,
        Discarded,

    }
}