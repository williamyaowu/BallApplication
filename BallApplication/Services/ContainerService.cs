using System.Collections.Generic;
using BallApplication.Models;
using BallApplication.Services.Interface;

namespace BallApplication.Services
{
    public class ContainerService : IContainerService
    {
        public ContainerModel CreateContainer(int depth, string name)
        {
            return new ContainerModel(depth, name);
        }

        public void AddBallToContainer(BallModel ball, ContainerModel container)
        {
            container.Balls.Add(ball);
        }
    }
}
