using BallApplication.Models;
using BallApplication.Services.Interface;

namespace BallApplication.Services
{
    public class BallService : IBallService
    {
        public BallModel CreateBall(int id)
        {
            return new BallModel(id);
        }
    }
}
