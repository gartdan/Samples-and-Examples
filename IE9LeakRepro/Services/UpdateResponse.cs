using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IE9LeakRepro.Services
{
    /// <summary>
    /// Defines a class that encapsulates a dynamic updates response to the web browser
    /// </summary>
    [DataContract(Namespace = "", Name = "UpdateResponse")]
    public class UpdateResponse<T>
    {
        /// <summary>
        /// Constructor for UpdateResponse
        /// </summary>
        /// <param name="updates">Updates for the client.  Null or empty list if no updates.</param>
        /// <param name="alertIndicator">Alert indicator update for client.  Null if no change.</param>
        /// <param name="error">Error message.  Null if no error.</param>
        public UpdateResponse(IEnumerable<T> updates, string error)
        {
            this.Updates = updates;
            this.Error = error;
        }

        // Required for serialization
        private UpdateResponse() { }

        /// <summary>
        /// Gets or sets the update list
        /// </summary>
        [DataMember(Name = "Updates")]
        public IEnumerable<T> Updates { get; private set; }

        /// <summary>
        /// Gets or sets the error as text.
        /// </summary>
        [DataMember(Name = "Error")]
        public string Error { get; private set; }
    }
}