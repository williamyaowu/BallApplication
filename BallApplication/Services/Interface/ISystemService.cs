using System.Collections.Generic;
using BallApplication.Models;

namespace BallApplication.Services.Interface
{
    public interface ISystemService : IService
    {
        /// <summary>
        /// create a system
        /// </summary>
        /// <param name="depth"></param>
        /// <returns></returns>
        SystemModel CreateSystem(int depth);

        /// <summary>
        /// add a ball to system
        /// </summary>
        /// <param name="ball"></param>
        /// <param name="system"></param>
        void AddBallToSystem(BallModel ball, SystemModel system);

        /// <summary>
        /// get empty containers in whole system
        /// </summary>
        /// <param name="system"></param>
        /// <returns></returns>
        IList<ContainerModel> GetEmptyContainers(SystemModel system);
    }
}
