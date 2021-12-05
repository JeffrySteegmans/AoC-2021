using AoC.Navigation.Extensions;
using AoC.Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Navigation
{
    public class Navigator
    {
        private int _aim = 0;

        public Position CalculatePosition(List<string> instructions)
        {
            var position = new Position();

            foreach(var instruction in instructions)
            {
                var instructionModel = instruction.ToInstruction();
                if (instructionModel != null)
                {
                    switch (instructionModel.Direction)
                    {
                        case Direction.forward:
                            position.HorizontalPosition += instructionModel.Distance;
                            break;
                        case Direction.up:
                            position.Depth -= instructionModel.Distance;
                            break;
                        case Direction.down:
                            position.Depth += instructionModel.Distance;
                            break;
                    }
                }
            }

            return position;
        }

        public Position CalculatePositionWithAim(List<string> instructions)
        {
            var position = new Position();

            foreach (var instruction in instructions)
            {
                var instructionModel = instruction.ToInstruction();
                if (instructionModel != null)
                {
                    switch (instructionModel.Direction)
                    {
                        case Direction.forward:
                            position.HorizontalPosition += instructionModel.Distance;
                            position.Depth += _aim * instructionModel.Distance;
                            break;
                        case Direction.up:
                            _aim -= instructionModel.Distance;
                            break;
                        case Direction.down:
                            _aim += instructionModel.Distance;
                            break;
                    }
                }
            }

            return position;
        }
    }
}
