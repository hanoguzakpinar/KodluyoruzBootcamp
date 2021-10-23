using OOPAssignment.Interfaces;

namespace OOPAssignment.Entities
{
    public class CarCommandExecutorBase
    {
        protected readonly ICarCommand CarCommand;
        public CarCommandExecutorBase(ICarCommand carCommand)
        {
            CarCommand = carCommand;
        }
    }
}