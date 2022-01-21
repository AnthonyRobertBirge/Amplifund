namespace AmplifundExample.Data.Core;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

using Shared.Interface;
using Shared.Static.Enums;

[Table("Cars")]
public class CarModel : ICar
{
    #region Properties
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [NotMapped()] public BodyType Body     { get; set; }
    [NotMapped()] public Color    CarColor { get; set; }
    [NotMapped()] public Color    Color    { get; set; }

    [DataType(DataType.Date)] 
    public DateTime Year { get;              set; }
    [NotMapped()] public IEngine Engine { get; set; }

    public                           int      Miles    { get; set; }
    public                           int      MPG      { get; set; }

    [MaxLength(255)] public string Description { get; set; }
    [MaxLength(255)] public string Make        { get; set; }
    [MaxLength(255)] public string Model       { get; set; }
    [MaxLength(255)] public string Trim        { get; set; }
    [MaxLength(17)]  public string VIN         { get; set; }
    #endregion

    #region CTOR
    public CarModel() { }

    public CarModel(BodyType body, Color color, DateTime year, IEngine engine, int miles, int mpg, string description, string make, string model, string trim, string vin)
    {
        this.Body        = body;
        this.Color       = color;
        this.Year        = year;
        this.Engine      = engine;
        this.Miles       = miles;
        this.MPG         = mpg; 
        this.Description = description;
        this.Make        = make;
        this.Model       = model;
        this.Trim        = trim;
        this.VIN         = vin;
    }
    #endregion
}