﻿ 

// ******************************************************
// DO NOT CHANGE THE CONTENT OF THIS FILE
// This file was generated by the T4 engine and the 
// contents of this source code will be changed after
// the custom tool was run.
// ******************************************************
using System;
using System.ServiceModel;
using Apworks;
using ByteartRetail.DataObjects;
using ByteartRetail.ServiceContracts;

namespace ByteartRetail.Services.WCF
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
	public class PostbackService : IPostbackService
	{
		private readonly IPostbackService _postbackServiceImpl = ServiceLocator.Instance.GetService<IPostbackService>();
				public PostbackDataObject GetPostback()
		{
			try
			{
				return _postbackServiceImpl.GetPostback();
			}
			catch(Exception ex)
			{
				throw new FaultException<FaultData>(FaultData.CreateFromException(ex), FaultData.CreateFaultReason(ex));
			}
		}
		public void Dispose() { _postbackServiceImpl.Dispose(); }
	}
}

