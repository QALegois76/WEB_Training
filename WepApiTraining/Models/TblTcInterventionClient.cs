﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WepApiTraining.Models;

public partial class TblTcInterventionClient
{
    public int IdinterventionClient { get; set; }

    public string CommandeCiel { get; set; }

    public int? LnkIdclient { get; set; }

    public int? LnkIdmachine { get; set; }

    public int? LnkIdintervenant { get; set; }

    public int? LnkIdtypeIntervention { get; set; }

    public bool? Garantie { get; set; }

    public float? TempsIntervention { get; set; }

    public float? TempsTrajet { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public byte[] SsmaTimeStamp { get; set; }

    public virtual TblTcClient LnkIdclientNavigation { get; set; }

    public virtual TblTcIntervenant LnkIdintervenantNavigation { get; set; }

    public virtual TblTcMachine LnkIdmachineNavigation { get; set; }

    public virtual TblTcTypeIntervention LnkIdtypeInterventionNavigation { get; set; }
}