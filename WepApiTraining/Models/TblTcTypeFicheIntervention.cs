﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WepApiTraining.Models;

public partial class TblTcTypeFicheIntervention
{
    public int IdtypeFicheIntervention { get; set; }

    public string StrTfitexteCourt { get; set; }

    public string StrTfiaide { get; set; }

    public virtual ICollection<TblTcFicheIntervention> TblTcFicheIntervention { get; } = new List<TblTcFicheIntervention>();
}