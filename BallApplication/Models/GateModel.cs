using BallApplication.Services;

namespace BallApplication.Models
{
    public class GateModel
    {
        public bool GateOpenDirection { get; set; }

        public GateModel(bool direction)
        {
            this.GateOpenDirection = direction;
        }
    }
}
