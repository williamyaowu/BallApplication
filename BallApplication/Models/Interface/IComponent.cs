using BallApplication.Enums;

namespace BallApplication.Models.Interface
{
    public interface IComponent
    {
        /// <summary>
        /// component name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// the depth current component exist
        /// </summary>
        int Depth { get; }

        /// <summary>
        /// type of component, endpoint or container
        /// </summary>
        ComponentTypeEnum ComponentType { get; }
    }
}
