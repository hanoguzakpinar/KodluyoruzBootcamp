namespace OOPAssignment.Structs
{
    public struct MovementFactor
    {
        public int XFactor { get; set; }
        public int YFactor { get; set; }
        public MovementFactor(int xFactor, int yFactor)
        {
            XFactor = xFactor;
            YFactor = yFactor;
        }
    }
}