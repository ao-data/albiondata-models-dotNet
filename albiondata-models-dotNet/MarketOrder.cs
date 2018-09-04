﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbionData.Models
{
  public class MarketOrder
  {
    public long Id { get; set; }
    public string ItemTypeId { get; set; }
    public int LocationId { get; set; }
    public int QualityLevel { get; set; }
    public int EnchantmentLevel { get; set; }
    public long UnitPriceSilver { get; set; }
    public long Amount { get; set; }
    public string AuctionType { get; set; }
    public DateTime Expires { get; set; }

    [NotMapped]
    public string ItemGroupTypeId { get; set; }

    public override string ToString()
    {
      return $"{Id}{Amount}";
    }
  }

  public class MarketUpload
  {
    public List<MarketOrder> Orders = new List<MarketOrder>();
  }

  public class MarketOrderDB : MarketOrder
  {
    [Column("albion_id")]
    public long AlbionId { get; set; }

    [Column("initial_amount")]
    public long InitialAmount { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    public override string ToString()
    {
      return $"{AlbionId} - {ItemTypeId} at {LocationId}";
    }
  }
}