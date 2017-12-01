using System.Collections.Generic;
using BallApplication.Models.Interface;

namespace BallApplication.Models
{
    public class ContainerModel : IComponent
    {
        /// <summary>
        /// container name
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        private string _name;

        /// <summary>
        /// the depth current container existing
        /// </summary>
        public int Depth
        {
            get
            {
                return this._depth;
            }
        }
        private int _depth;

        /// <summary>
        /// if there are balls in container
        /// </summary>
        public bool HasBall
        {
            get
            {
                return this.Balls.Count > 0;
            }
        }

        /// <summary>
        /// the count of the balls 
        /// </summary>
        public int BallCount
        {
            get
            {
                return this.Balls.Count;
            }
        }

        /// <summary>
        /// balls in container
        /// </summary>
        public IList<BallModel> Balls
        {
            get
            {
                if (this._balls == null)
                    this._balls = new List<BallModel>();
                return this._balls;
            }
        }
        private IList<BallModel> _balls;

        /// <summary>
        /// Component Type:Container
        /// </summary>
        public Enums.ComponentTypeEnum ComponentType
        {
            get { return Enums.ComponentTypeEnum.Container; }
        }

        public ContainerModel(int depth, string name)
        {
            this._depth = depth;
            this._name = name;
        }
    }
}
