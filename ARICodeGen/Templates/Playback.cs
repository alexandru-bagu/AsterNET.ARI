﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 25/05/2014 20:39:48
*/
using System;
using System.Collections.Generic;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Object representing the playback of media to a channel
	/// </summary>
	public class Playback 
	{
		/// <summary>
		/// ID for this playback operation
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// URI for the media to play back.
		/// </summary>
		public string Media_uri { get; set; }

		/// <summary>
		/// URI for the channel or bridge to play the media on
		/// </summary>
		public string Target_uri { get; set; }

		/// <summary>
		/// For media types that support multiple languages, the language requested for playback.
		/// </summary>
		public string Language { get; set; }

		/// <summary>
		/// Current state of the playback operation.
		/// </summary>
		public string State { get; set; }

	}
}
