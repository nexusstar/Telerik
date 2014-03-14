namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ChaoticParticle : Particle
    {
        private readonly int directionChangeRow;
        private readonly int directionChangeCol;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed,
            Random randomGenerator, uint directionChangeFreqRowPercent, uint directionChangeFreqColPercent)
            : base(position, speed)
        {
            this.RandomGenerator = randomGenerator;
            this.directionChangeRow = (int)directionChangeFreqRowPercent;
            this.directionChangeCol = (int)directionChangeFreqColPercent;
        }

        protected Random RandomGenerator { get; private set; }

        protected int DirectionChangeFrequencyRowPercent
        {
            get
            {
                return this.directionChangeRow;
            }
        }

        protected int DirectionChangeFrequencyColPercent
        {
            get
            {
                return this.directionChangeCol;
            }
        }

        public override IEnumerable<Particle> Update()
        {
            if (this.RandomGenerator.Next(0, 101) <= this.directionChangeRow)
            {
                this.Accelerate(new MatrixCoords(2 * (this.Speed.Row * (-1)), 0));
            }
            if (this.RandomGenerator.Next(0, 101) <= this.directionChangeCol)
            {
                this.Accelerate(new MatrixCoords(0, 2 * (this.Speed.Col * (-1))));
            }
            return base.Update();
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '?' } };
        }
    }
}