// Copyright (c) Microsoft. All rights reserved.
namespace MessagesAnalyzer
{
    using System;

    class MessageDetails
    {
        public MessageDetails(long seqNumber, DateTime enquedDateTime)
        {
            this.SequenceNumber = seqNumber;
            this.EnquedDateTime = enquedDateTime;
        }

        public DateTime EnquedDateTime { get; }

        public long SequenceNumber { get; }
    }
}
