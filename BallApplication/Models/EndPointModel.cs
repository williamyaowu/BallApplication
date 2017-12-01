using BallApplication.Models.Interface;

namespace BallApplication.Models
{
    public class EndPointModel : IComponent
    {
        /// <summary>
        /// EndPoint Name
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
        /// the depth current endpoint existing
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
        /// Gate in endpoint
        /// </summary>
        public GateModel Gate
        {
            get
            {
                return this._gate;
            }
        }
        private GateModel _gate;

        /// <summary>
        /// Component Type:EndPoint
        /// </summary>
        public Enums.ComponentTypeEnum ComponentType
        {
            get { return Enums.ComponentTypeEnum.EndPoint; }
        }

        /// <summary>
        /// Left component
        /// </summary>
        public IComponent LeftComponent
        {
            get
            {
                return this._leftComponent;
            }
        }
        private IComponent _leftComponent;

        /// <summary>
        /// right component
        /// </summary>
        public IComponent RightComponent
        {
            get
            {
                return this._rightComponent;
            }
        }
        private IComponent _rightComponent;

        public EndPointModel(int depth, string name, IComponent leftComponent, IComponent rightComponent,GateModel gate)
        {
            this._depth = depth;
            this._name = name;
            this._gate = gate;
            this._leftComponent = leftComponent;
            this._rightComponent = rightComponent;
        }
    }
}
