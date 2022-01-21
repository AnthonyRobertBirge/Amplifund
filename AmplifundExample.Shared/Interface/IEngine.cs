namespace AmplifundExample.Shared.Interface;

using Static.Enums;

public interface IEngine
{
    #region Properties
    public FuelType Fuel       { get; set; }
    public int      Cylinders  { get; set; }
    public int      HorsePower { get; set; }
    public string   Name       { get; set; }
    #endregion
}