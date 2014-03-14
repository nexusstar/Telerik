namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public int Radius { get; private set; }
        public int Power { get; private set; }

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, uint reppelerPower, uint radiusOfEffect)
            : base(position, speed)
        {
            this.Radius = (int)radiusOfEffect;
            this.Power = (int)reppelerPower;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'x' } };
        }
    }
}