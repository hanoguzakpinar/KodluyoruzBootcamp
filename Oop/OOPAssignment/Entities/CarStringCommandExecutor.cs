using System;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Entities
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {
        }
        public void ExecuteCommand(string commandObject)
        {
            if (string.IsNullOrEmpty(commandObject))
                throw new Exception("Komutlarda hata var.");
            //Komutlar� ay�r�p,diziye atma
            char[] commands = commandObject.ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'L':
                        CarCommand.TurnLeft();//Sol
                        break;
                    case 'R':
                        CarCommand.TurnRight();//Sa�
                        break;
                    case 'M':
                        MovementFactor mF = new();//�leri
                        CarCommand.Move(mF);
                        break;
                    default:
                        throw new Exception("Komutlarda hata var.");
                }
            }
        }
    }
}