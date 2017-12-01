using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BallApplication.Models;
using BallApplication.Models.Interface;

namespace BallApplication.Services.Interface
{
    public interface IEndPointService : IService
    {
        /// <summary>
        /// create an endpoint
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="name"></param>
        /// <param name="leftEndPoint"></param>
        /// <param name="rightEndPoint"></param>
        /// <returns></returns>
        EndPointModel CreateEndPoint(int depth, string name, IComponent leftEndPoint, IComponent rightEndPoint);

        /// <summary>
        /// ball pass endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        void BallThroughEndPoint(EndPointModel endpoint);
    }
}
