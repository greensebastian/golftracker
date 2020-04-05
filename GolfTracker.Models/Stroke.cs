namespace Models
{
    public class Stroke
    {
        public Lie StartLie { get; set; } = Lie.Tee;
        public Lie EndLie { get; set; } = Lie.Hole;
        public Curve Curve { get; set; } = Curve.Straight;
        public Address Address { get; set; } = Address.Center;
        public byte Satisfaction { get; set; } = byte.MaxValue / 2;
    }
}
