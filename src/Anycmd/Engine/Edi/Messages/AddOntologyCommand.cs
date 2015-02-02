﻿
namespace Anycmd.Engine.Edi.Messages
{
    using InOuts;

    public class AddOntologyCommand : AddEntityCommand<IOntologyCreateIo>, IAnycmdCommand
    {
        public AddOntologyCommand(IAcSession acSession, IOntologyCreateIo input)
            : base(acSession, input)
        {

        }
    }
}
