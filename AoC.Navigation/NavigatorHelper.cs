using AoC.Navigation.Extensions;
using AoC.Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Navigation
{
    public static class NavigatorHelper
    {
        public static Position CalculatePosition(List<string> instructions)
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
    }
}
