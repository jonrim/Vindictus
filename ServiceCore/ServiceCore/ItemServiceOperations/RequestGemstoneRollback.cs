﻿using System;
using UnifiedNetwork.Cooperation;

namespace ServiceCore.ItemServiceOperations
{
	[Serializable]
	public sealed class RequestGemstoneRollback : Operation
	{
		public long BraceletItemID { get; set; }

		public RequestGemstoneRollback(long braceletItemID)
		{
			this.BraceletItemID = braceletItemID;
		}

		public override OperationProcessor RequestProcessor()
		{
			return new OkOrFailProcessor(this);
		}
	}
}
