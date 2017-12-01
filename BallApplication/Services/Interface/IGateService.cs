using BallApplication.Models;

namespace BallApplication.Services.Interface
{
    public interface IGateService : IService
    {
        /// <summary>
        /// create a gate
        /// </summary>
        /// <returns></returns>
        GateModel CreateGate();

        /// <summary>
        /// change the direction of the gate
        /// </summary>
        /// <param name="gate"></param>
        void ChangeGateDirection(GateModel gate);
    }
}
