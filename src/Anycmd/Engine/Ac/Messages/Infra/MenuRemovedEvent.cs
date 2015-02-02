﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using Abstractions.Infra;
    using Events;

    public class MenuRemovedEvent : DomainEvent
    {
        public MenuRemovedEvent(IAcSession acSession, MenuBase source)
            : base(acSession, source)
        {
        }
    }
}