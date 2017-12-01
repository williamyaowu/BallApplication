using BallApplication.Models;
using BallApplication.Models.Interface;
using BallApplication.Services.Interface;

namespace BallApplication.Services
{
    public class EndPointService : IEndPointService
    {
        IGateService _gateService;

        public EndPointService(IGateService gateService)
        {
            this._gateService = gateService;
        }

        public EndPointModel CreateEndPoint(int depth, string name, IComponent leftEndPoint, IComponent rightEndPoint)
        {
            var gate = _gateService.CreateGate();
            return new EndPointModel(depth, name, leftEndPoint, rightEndPoint, gate);
        }

        public void BallThroughEndPoint(EndPointModel endpoint)
        {
            this._gateService.ChangeGateDirection(endpoint.Gate);
        }
    }
}
