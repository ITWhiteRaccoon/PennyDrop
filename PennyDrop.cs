using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Text;

namespace PennyDrop
{
    public enum Direction
    {
        Left,
        Right
    }

    class PennyDrop
    {
        public Actuator A1 { get; }
        public Actuator A2 { get; }
        public Actuator A3 { get; }

        public PennyDrop()
        {
            A1 = new Actuator();
            A2 = new Actuator();
            A3 = new Actuator();
        }

        /// <summary>
        /// Checks if the current configuration, given the input, is a winner.
        /// </summary>
        public bool IsWinner(Input input)
        {
            if (input == 0)
            {
                return A1.Position == Direction.Right &&
                       A2.Position == Direction.Right;
            }

            return A2.Position == Direction.Right ||
                   A3.Position == Direction.Right;
        }

        public void Reset()
        {
            A1.Reset();
            A2.Reset();
            A3.Reset();
        }

        public enum Input
        {
            X = 0,
            Y = 1
        }

        public class Actuator
        {
            public Direction Position { get; private set; }

            public Actuator()
            {
                Reset();
            }

            public void Reset()
            {
                Position = Direction.Left;
            }

            public void Switch()
            {
                Position = 1 - Position;
            }
        }
    }
}
