﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WepApiTraining.Models;

public partial class TblTcDefautProduction
{
    public int IddefautProduction { get; set; }

    public int? LnkIdmachine { get; set; }

    public string Description { get; set; }

    public string Type { get; set; }

    public byte[] SsmaTimeStamp { get; set; }

    public virtual TblTcMachine LnkIdmachineNavigation { get; set; }
}