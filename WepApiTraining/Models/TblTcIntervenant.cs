﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WepApiTraining.Models;

public partial class TblTcIntervenant
{
    public int Idintervenant { get; set; }

    public string StrIntervenantNomCourt { get; set; }

    public string StrIntervenantNomLong { get; set; }

    public bool? BIntervenantActif { get; set; }

    public short? IIntervenantOrder { get; set; }

    public byte[] SsmaTimeStamp { get; set; }

    public virtual ICollection<TblTcFicheIntervention> TblTcFicheInterventionLnkIdintervenantFNavigation { get; } = new List<TblTcFicheIntervention>();

    public virtual ICollection<TblTcFicheIntervention> TblTcFicheInterventionLnkIdintervenantONavigation { get; } = new List<TblTcFicheIntervention>();

    public virtual ICollection<TblTcInterventionClient> TblTcInterventionClient { get; } = new List<TblTcInterventionClient>();

    public virtual ICollection<TblTcSsIntervertion> TblTcSsIntervertion { get; } = new List<TblTcSsIntervertion>();
}