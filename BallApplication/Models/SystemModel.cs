using System.Collections.Generic;
using BallApplication.Models.Interface;

namespace BallApplication.Models
{
    public class SystemModel
    {
        public IList<IComponent> Components{
            get{
                return this._components;
            }
        }
        private IList<IComponent> _components;

        public int Depth
        {
            get
            {
                return this._depth;
            }
        }
        private int _depth;

        public EndPointModel RootEndPoint
        {
            get
            {
                return this._rootEndPoint;
            }
        }
        private EndPointModel _rootEndPoint;

        public SystemModel(int depth,EndPointModel root, List<IComponent> components)
        {
            this._components = components;
            this._depth = depth;
            this._rootEndPoint = root;
        }
    }
}
