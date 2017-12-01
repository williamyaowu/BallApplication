using BallApplication.Configurations;
using BallApplication.Services.Interface;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;
using System;
using System.Linq;

namespace BallApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //default values
            var depth = 4;
            var ballCount = 15;

            //get parameter depth
            var treeDepthParam = args.SingleOrDefault(arg => arg.StartsWith("-D:"));
            if (!string.IsNullOrEmpty(treeDepthParam))
            {
                treeDepthParam = treeDepthParam.Replace("-D:", "");
                if (!int.TryParse(treeDepthParam, out depth))
                {
                    Console.WriteLine("Invalid Parameter -D");
                    return;
                }
            }
            //get parameter ball count
            var ballCountParam = args.SingleOrDefault(arg => arg.StartsWith("-C:"));
            if (!string.IsNullOrEmpty(ballCountParam))
            {
                ballCountParam = ballCountParam.Replace("-C:", "");
                if (!int.TryParse(ballCountParam, out ballCount))
                {
                    Console.WriteLine("Invalid Parameter -C");
                    return;
                }
            }

            var container = new WindsorContainer();

            container.Install(new BallApplicationInstaller());

            using (var scope = container.BeginScope())
            {
                var systemService = container.Resolve<ISystemService>();
                var ballService = container.Resolve<IBallService>();

                dropBallsToSystem(depth, ballCount, systemService, ballService);

                scope.Dispose();
            }
        }

        private static void dropBallsToSystem(int depth, int ballCount, ISystemService systemService, IBallService ballService)
        {
            var system = systemService.CreateSystem(depth);

            for (var i = 0; i < ballCount; i++)
            {
                var ball = ballService.CreateBall(i);
                systemService.AddBallToSystem(ball, system);
            }

            var emptyContainers = systemService.GetEmptyContainers(system);

            Console.WriteLine("Empty Container Names:" + string.Join(",", emptyContainers.Select(p => p.Name).ToArray()));
        }
    }
}
