﻿using System;

namespace SkaCahToa.Rest.Models.Attributes
{
	/// <summary>
	/// Data population types for UrlDefinitions.
	/// </summary>
	public enum UrlDefinitionDataTypes
	{
		NotImplemented,
		Static,
		Data
	}

	public abstract class UrlDefinitionBase : Attribute
	{
		#region Properties

		public UrlDefinitionDataTypes Type { get; set; }

		public string Value { get; set; }

		#endregion Properties

		public UrlDefinitionBase(UrlDefinitionDataTypes type, string value)
		{
			Type = type;
			Value = value;
		}
	}
}