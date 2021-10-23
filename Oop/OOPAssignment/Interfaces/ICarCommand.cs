using OOPAssignment.Structs;

namespace OOPAssignment.Interfaces
{
    public interface ICarCommand
    {
        public void TurnLeft();
        public void TurnRight();
        public void Move(MovementFactor movementFactor);
    }
}