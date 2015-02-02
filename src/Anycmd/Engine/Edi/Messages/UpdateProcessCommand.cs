﻿
namespace Anycmd.Engine.Edi.Messages
{
    using InOuts;

    public class UpdateProcessCommand : UpdateEntityCommand<IProcessUpdateIo>, IAnycmdCommand
    {
        public UpdateProcessCommand(IAcSession acSession, IProcessUpdateIo input)
            : base(acSession, input)
        {

        }
    }
}
