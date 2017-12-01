using System;
using System.Linq;
using System.Collections.Generic;
using BallApplication.Enums;
using BallApplication.Models;
using BallApplication.Models.Interface;
using BallApplication.Services.Interface;

namespace BallApplication.Services
{
    public class SystemService : ISystemService
    {
        IContainerService _containerService;
        IEndPointService _endPointService;

        public SystemService(IContainerService containerService,
                             IEndPointService endPointService)
        {
            this._containerService = containerService;
            this._endPointService = endPointService;      
        }
        public SystemModel CreateSystem(int depth)
        {
            var componentList = new List<IComponent>();

            var root = this.createEndPoint(1, depth, "0", ref componentList);
            var system = new SystemModel(depth, root, componentList);

            return system;
        }

        public void AddBallToSystem(BallModel ball, SystemModel system)
        {
            this.moveToNext(ball, system.RootEndPoint);
        }

        public IList<ContainerModel> GetEmptyContainers(SystemModel system)
        {
            return system.Components
                         .Where(p => p.ComponentType == ComponentTypeEnum.Container
                                                  && !(p as ContainerModel).HasBall)
                         .Select(p=>p as ContainerModel)
                         .ToList();
        }

        private EndPointModel createEndPoint(int currentDepth, int maxDepth, string name, ref List<IComponent> componentList)
        {
            if (currentDepth > maxDepth)
            {
                throw new Exception("current depth should not be larger than max tree depth");
            }

            IComponent leftEndPoint = null;
            IComponent rightEndPoint = null;
            if (currentDepth < maxDepth)
            {
                leftEndPoint = this.createEndPoint(currentDepth + 1, maxDepth, name + "0", ref componentList);
                rightEndPoint = this.createEndPoint(currentDepth + 1, maxDepth, name + "1", ref componentList);
            }
            else
            {
                leftEndPoint = _containerService.CreateContainer(currentDepth + 1, name + "0");
                rightEndPoint = _containerService.CreateContainer(currentDepth + 1, name + "1");

                componentList.Add(leftEndPoint);
                componentList.Add(rightEndPoint);
            }

            EndPointModel endPoint = _endPointService.CreateEndPoint(currentDepth, name, leftEndPoint, rightEndPoint);
            componentList.Add(endPoint);

            return endPoint;
        }

        private void moveToNext(BallModel ball, IComponent currentPoint)
        {
            if (currentPoint.ComponentType == ComponentTypeEnum.Container)
            {
                var container = (currentPoint as ContainerModel);
                _containerService.AddBallToContainer(ball, container);
            }
            else
            {
                var endPoint = currentPoint as EndPointModel;
                if (endPoint.Gate.GateOpenDirection)
                {
                    this.moveToNext(ball, endPoint.LeftComponent);
                }
                else
                {
                    this.moveToNext(ball, endPoint.RightComponent);
                }

                _endPointService.BallThroughEndPoint(endPoint);
            }
        }
    }
}
