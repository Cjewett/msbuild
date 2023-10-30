using System.Threading;
using System.Threading.Tasks;
using Microsoft.Build.Execution;
using Microsoft.Build.Experimental.FileAccess;
using Microsoft.Build.Experimental.ProjectCache;
using Microsoft.Build.Framework;

namespace DistributedCachePlugin
{
    public class ExternalCachePlugin : ProjectCachePluginBase
    {
        public override Task BeginBuildAsync(
            CacheContext context,
            PluginLoggerBase logger,
            CancellationToken cancellationToken)
        {
            logger?.LogMessage($"ExternalCachePlugin: BeginBuildAsync", MessageImportance.High);
            return Task.CompletedTask;
        }

        public override Task EndBuildAsync(
            PluginLoggerBase logger,
            CancellationToken cancellationToken)
        {
            logger?.LogMessage($"ExternalCachePlugin: EndBuildAsync", MessageImportance.High);
            return Task.CompletedTask;
        }

        public override Task<CacheResult> GetCacheResultAsync(
            BuildRequestData buildRequest,
            PluginLoggerBase logger,
            CancellationToken cancellationToken)
        {
            logger?.LogMessage($"ExternalCachePlugin: GetCacheResultAsync", MessageImportance.High);
            return (Task<CacheResult>)Task.CompletedTask;
        }

        public override void HandleFileAccess(
            FileAccessContext fileAccessContext,
            FileAccessData fileAccessData)
        {
        }

        public override void HandleProcess(
            FileAccessContext fileAccessContext,
            ProcessData processData)
        {
        }

        public override Task HandleProjectFinishedAsync(
            FileAccessContext fileAccessContext,
            BuildResult buildResult,
            PluginLoggerBase logger,
            CancellationToken cancellationToken)
        {
            logger?.LogMessage($"ExternalCachePlugin: HandleProjectFinishedAsync", MessageImportance.High);
            return Task.CompletedTask;
        }
    }
}
