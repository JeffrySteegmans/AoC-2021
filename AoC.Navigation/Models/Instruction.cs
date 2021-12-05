namespace AoC.Navigation.Models
{
    internal class Instruction
    {
        public Direction Direction { get; set; }
        public int Distance { get; set; }
    }

    internal enum Direction
    {
        forward,
        up,
        down
    }
}
