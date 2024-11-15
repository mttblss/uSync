using Microsoft.Extensions.Logging;

using System.Threading;
using System.Threading.Tasks;

using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Models.Entities;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;

using uSync.BackOffice.Configuration;
using uSync.BackOffice.Services;
using uSync.Core;

namespace uSync.BackOffice.SyncHandlers.Handlers;

/// <summary>
///  handler base for all ContentTypeBase handlers
/// </summary>
public abstract class ContentTypeBaseHandler<TObject> : SyncHandlerContainerBase<TObject>
    where TObject : ITreeEntity
{

    /// <summary>
    /// Constructor.
    /// </summary>
    protected ContentTypeBaseHandler(
        ILogger<SyncHandlerContainerBase<TObject>> logger,
        IEntityService entityService,
        AppCaches appCaches,
        IShortStringHelper shortStringHelper,
        ISyncFileService syncFileService,
        ISyncEventService mutexService,
        ISyncConfigService uSyncConfig,
        ISyncItemFactory syncItemFactory)
        : base(logger, entityService, appCaches, shortStringHelper, syncFileService, mutexService, uSyncConfig, syncItemFactory)
    { }

    public override async Task HandleAsync(SavingNotification<TObject> notification, CancellationToken cancellationToken)
    {
        // this is a hack fix, while we look into it, 
        // deeply suspect there is a lock in the core :( 
        Thread.Sleep(75);
        await base.HandleAsync(notification, cancellationToken);
    }

}
