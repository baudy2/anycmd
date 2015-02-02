﻿
namespace Anycmd.Engine.Edi.Messages
{
    using InOuts;

    public class AddNodeCommand : AddEntityCommand<INodeCreateIo>, IAnycmdCommand
    {
        public AddNodeCommand(IAcSession acSession, INodeCreateIo input)
            : base(acSession, input)
        {

        }
    }
}
