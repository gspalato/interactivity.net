using Discord;
using Discord.WebSocket;

namespace InteractivityNET
{
    public class PaginatedContext
    {
        public PaginatedMessage PaginatedMessage { get; set; }
        public IUser User { get; set; }
        public SocketReaction Reaction { get; set; }
	}
}
