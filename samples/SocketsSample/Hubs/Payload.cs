// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


namespace SocketsSample.Hubs
{
    public struct Payload
        {
            public string Sender { get; }
            public string Message { get; }

            public Payload(string sender, string message)
            {
                Sender = sender;
                Message = message;
            }
        }
}
