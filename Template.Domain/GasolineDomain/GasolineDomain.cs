using Template.Domain.ActionDomain;

namespace Template.Domain.GasolineDomain
{
    public class GasolineDomain : EngineDomai, IGasolineDomain
    {
        public override string Start()
        {
            return "Start Gasoline";
        }

        public override string Stop()
        {
            return "Stop Gasoline";
        }

        public override string Refuel()
        {
            return "Refuel Gasoline";
        }
    }
}
