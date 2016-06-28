using Microsoft.TeamFoundation.Framework.Server;

namespace Microsoft.VisualStudio.Services.Zeus.Extensions
{
    [StepPerformer("Zeus")]
    public partial class ZeusStepPerformer : TeamFoundationStepPerformerBase
    {
        [ServicingStep]
        public void ConfigureServiceTokens(ServicingContext servicingContext)
        {
        }
    }
}
