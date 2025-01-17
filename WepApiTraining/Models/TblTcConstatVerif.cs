﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WepApiTraining.Models;

public partial class TblTcConstatVerif
{
    /// <summary>
    /// ID du constat
    /// </summary>
    public int IdconstatVerification { get; set; }

    /// <summary>
    /// ID de la machine concerné (obligatoire)
    /// </summary>
    public int? LnkIdmachine { get; set; }

    /// <summary>
    /// ID du contrat de maintenance associé (optionnel)
    /// </summary>
    public int? LnkIdcontrat { get; set; }

    /// <summary>
    /// N° du constat de vérification (nom unique obligatoire)
    /// </summary>
    public string StrCvnumero { get; set; }

    /// <summary>
    /// Date de l&apos;intervention / calibration
    /// </summary>
    public DateTime? DateCvintervention { get; set; }

    /// <summary>
    /// Intervenant / opérateur
    /// </summary>
    public string StrCvintervenant { get; set; }

    /// <summary>
    /// ID de l&apos;étalon de calibration XY
    /// </summary>
    public int? LnkIdetalonGrille { get; set; }

    /// <summary>
    /// ID de l&apos;étalon de calibration du Z
    /// </summary>
    public int? LnkIdetalonEtalonZ { get; set; }

    /// <summary>
    /// Type de correction
    /// </summary>
    public string StrCvtypeCorrection { get; set; }

    /// <summary>
    /// Rédacteur du constat
    /// </summary>
    public string StrCvredacteur { get; set; }

    /// <summary>
    /// Date du constat
    /// </summary>
    public DateTime? DateCvcertificat { get; set; }

    /// <summary>
    /// Mémo / remarques diverses
    /// </summary>
    public string MemoCvremarques { get; set; }

    public byte[] SsmaTimeStamp { get; set; }
}