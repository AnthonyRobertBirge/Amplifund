namespace AmplifundExample.Shared.Interface
{
    using System;
    using System.Drawing;

    using Static.Enums;
    public interface ICar
    {
        #region Properties
        public BodyType Body        { get; set; }
        public Color    CarColor    { get; set; }
        public DateTime Year        { get; set; }
        public IEngine  Engine      { get; set; }
        public int      Miles       { get; set; }
        public int      MPG         { get; set; }
        public string   Description { get; set; }
        public string   Make        { get; set; }
        public string   Model       { get; set; }
        public string   Trim        { get; set; }
        public string   VIN         { get; set; }
        #endregion
    }
}