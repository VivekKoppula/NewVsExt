using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using System.Diagnostics;
using System.Windows;

namespace CommandParentingSample
{
    /// <summary>
    /// Command1 handler.
    /// </summary>
    [VisualStudioContribution]
    internal class SampleCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleCommand"/> class.
        /// </summary>
        /// <param name="extensibility">Extensibility object.</param>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public SampleCommand(VisualStudioExtensibility extensibility, TraceSource traceSource)
            : base(extensibility)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new("%CommandParentingSample.SampleCommand.DisplayName%")
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. DisplayName is localized and references an entry in .vsextension\string-resources.json.
            Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
            Placements = new[]
            {
		        // File in project context menu
		        CommandPlacement.FromVsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), 521),

		        // Project context menu
		        CommandPlacement.FromVsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), 518),

		        // Solution context menu
		        CommandPlacement.FromVsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), 537),
            },
        };

        /// <inheritdoc />
        public override Task InitializeAsync(CancellationToken cancellationToken)
        {
            // Use InitializeAsync for any one-time setup or initialization.
            return base.InitializeAsync(cancellationToken);
        }

        /// <inheritdoc />
        public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
        {
            // await context.ShowPromptAsync("Hello from an extension!", PromptOptions.OK, cancellationToken);
            MessageBox.Show("Here we go");
            return Task.CompletedTask;
        }
    }
}
