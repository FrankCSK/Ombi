
using System.Collections.Generic;
using Ombi.Settings.Settings.Models.Notifications;
using Ombi.Store.Entities;

namespace Ombi.Core.Models.UI
{
    /// <summary>
    /// The view model for the notification settings page
    /// </summary>
    /// <seealso cref="GotifyNotificationSettings" />
    public class GotifyNotificationViewModel : GotifySettings
    {
        /// <summary>
        /// Gets or sets the notification templates.
        /// </summary>
        /// <value>
        /// The notification templates.
        /// </value>
        public List<NotificationTemplates> NotificationTemplates { get; set; }
        
    }
}
