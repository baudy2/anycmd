﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using Abstractions.Infra;
    using InOuts;

    public class PositionAddedEvent : EntityAddedEvent<IPositionCreateIo>
    {
        public PositionAddedEvent(IAcSession acSession, GroupBase source, IPositionCreateIo output)
            : base(acSession, source, output)
        {
        }
    }
}
