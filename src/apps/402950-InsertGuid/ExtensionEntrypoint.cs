using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

namespace InsertGuid
{
    /// <summary>
    /// Extension entrypoint for the VisualStudio.Extensibility extension.
    /// </summary>
    [VisualStudioContribution]
    internal class ExtensionEntrypoint : Extension
    {
        /// <inheritdoc/> 
        public override ExtensionConfiguration ExtensionConfiguration => new()
        {
            Metadata = new("InsertGuid.1666c8f6-5158-4cce-b75d-a0bf5bd30efb", this.ExtensionAssemblyVersion, "Publisher name", "InsertGuid"),
        };

        /// <inheritdoc />
        protected override void InitializeServices(IServiceCollection serviceCollection)
        {
            base.InitializeServices(serviceCollection);

            // You can configure dependency injection here by adding services to the serviceCollection.
        }
    }
}
