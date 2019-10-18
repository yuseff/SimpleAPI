using SimpleAPI.Domain.Models;

namespace SimpleAPI.Domain.Services.Communication
{
    public class SportResponse : BaseResponse
    {
        public Sport Sport { get; private set; }

        private SportResponse(bool success, string message, Sport sport) : base(success, message)
        {
            Sport = sport;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="sport">Saved category.</param>
        /// <returns>Response.</returns>
        public SportResponse(Sport sport) : this(true, string.Empty, sport)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SportResponse(string message) : this(false, message, null)
        { }
    }
}