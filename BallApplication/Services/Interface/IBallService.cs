using BallApplication.Models;

namespace BallApplication.Services.Interface
{
    public interface IBallService : IService
    {
        /// <summary>
        /// create a ball 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BallModel CreateBall(int id);
    }
}
