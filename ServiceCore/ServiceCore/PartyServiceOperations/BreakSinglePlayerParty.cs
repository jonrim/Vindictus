﻿using System;
using UnifiedNetwork.Cooperation;

namespace ServiceCore.PartyServiceOperations
{
	[Serializable]
	public sealed class BreakSinglePlayerParty : Operation
	{
		public override OperationProcessor RequestProcessor()
		{
			return new OkOrFailProcessor(this);
		}
	}
}
