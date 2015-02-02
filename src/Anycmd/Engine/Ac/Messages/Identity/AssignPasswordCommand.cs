﻿
namespace Anycmd.Engine.Ac.Messages.Identity
{
    using Commands;
    using InOuts;
    using System;

    public class AssignPasswordCommand : Command, IAnycmdCommand
    {
        public AssignPasswordCommand(IAcSession acSession, IPasswordAssignIo input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            this.AcSession = acSession;
            this.Input = input;
        }

        public IPasswordAssignIo Input { get; private set; }

        public IAcSession AcSession { get; private set; }
    }
}
