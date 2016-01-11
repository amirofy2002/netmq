﻿using NetMQ.Core;

namespace NetMQ.Sockets
{
    /// <summary>
    /// A PairSocket is a NetMQSocket, usually used to synchronize two threads - using only one socket on each side.
    /// </summary>
    public class PairSocket : NetMQSocket
    {
        /// <summary>
        /// Create a new PairSocket and attach socket to zero or more endpoints.               
        /// </summary>                
        /// <param name="connectionString">List of NetMQ endpoints, seperated by commas and prefixed by '@' (to bind the socket) or '>' (to connect the socket).
        /// Default action is connect (if endpoint doesn't start with '@' or '>')</param>
        /// <example><code>var socket = new PairSocket(">tcp://127.0.0.1:5555,@127.0.0.1:55556");</code></example>                 
        public PairSocket(string connectionString = null) : base(ZmqSocketType.Pair, connectionString, DefaultAction.Connect)
        {
            
        }

        /// <summary>
        /// Create a new PairSocket based upon the given SocketBase.
        /// </summary>
        /// <param name="socketHandle">the SocketBase to create the new socket from</param>
        internal PairSocket(SocketBase socketHandle)
            : base(socketHandle)
        {
        }
    }
}
