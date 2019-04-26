using System;
using Acquaint.Abstractions;
using Microsoft.WindowsAzure.MobileServices;
using MvvmHelpers;
using Newtonsoft.Json;

namespace Acquaint.Models
{
	/// <summary>
	/// A type that mirrors the properties of Microsoft.Azure.Mobile.Server.EntityData, and is also observable.
	/// </summary>
	public class ObservableEntityData : ObservableObject, IObservableEntityData
	{
		public ObservableEntityData()
		{
			Id = Guid.NewGuid().ToString().ToUpper();
		}

		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[CreatedAt]
		public DateTimeOffset CreatedAt { get; set; }

		[UpdatedAt]
		public DateTimeOffset UpdatedAt { get; set; }

		[Version]
		public byte[] Version { get; set; }
	}

    public class OvservableBool : ObservableObject
    {
        public OvservableBool(bool signedIn)
        {
            IsSignedIn = signedIn;
        }
        public bool IsSignedIn { get; set; }
        public string SignedInState
        {
             get { return IsSignedIn ? "Sign Out" : "Sign In"; }
        }
    }
}

