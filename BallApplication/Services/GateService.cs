using BallApplication.Models;
using BallApplication.Services.Interface;

namespace BallApplication.Services
{
    public class GateService:IGateService
    {
        /// <summary>
        /// create a gate
        /// </summary>
        /// <returns></returns>
        public  GateModel CreateGate()
        {
            var direction = (MathHelper.GetRandomNumber() % 2) == 1;
            return new GateModel(direction);
        }

        /// <summary>
        /// change the direction of the gate
        /// </summary>
        public  void ChangeGateDirection(GateModel gate)
        {
            gate.GateOpenDirection = !gate.GateOpenDirection;
        }
    }
}
