using BallApplication.Models;

namespace BallApplication.Services.Interface
{
    public interface IContainerService : IService
    {
        /// <summary>
        /// create a container
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="name"></param>
        /// <returns></returns>
       ContainerModel CreateContainer(int depth, string name);

        /// <summary>
        /// add ball to the container
        /// </summary>
        /// <param name="ball"></param>
        /// <param name="container"></param>
       void AddBallToContainer(BallModel ball, ContainerModel container);
    }
}
