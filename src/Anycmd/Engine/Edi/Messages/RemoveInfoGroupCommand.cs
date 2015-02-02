﻿
namespace Anycmd.Engine.Edi.Messages
{
    using System;

    public class RemoveInfoGroupCommand : RemoveEntityCommand
    {
        public RemoveInfoGroupCommand(IAcSession acSession, Guid infoGroupId)
            : base(acSession, infoGroupId)
        {

        }
    }
}
