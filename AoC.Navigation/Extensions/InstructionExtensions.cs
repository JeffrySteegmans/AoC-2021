using AoC.Navigation.Models;

namespace AoC.Navigation.Extensions
{
    internal static class InstructionExtensions
    {
        internal static Instruction ToInstruction(this string instruction)
        {
            if (instruction == null)
            {
                return null;
            }

            var instructionParts = instruction.Split(' ');

            if (instructionParts.Count() != 2)
            {
                return null;
            }

            if (instructionParts[0] != "forward" && instructionParts[0] != "up" && instructionParts[0] != "down")
            {
                return null;
            }

            Enum.TryParse<Direction>(instructionParts[0], out Direction direction);
            int.TryParse(instructionParts[1], out int distance);

            return new Instruction
            {
                Distance = distance,
                Direction = direction
            };
        }
    }
}
