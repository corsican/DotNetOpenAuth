﻿//-----------------------------------------------------------------------
// <copyright file="IAuthorizationDescription.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuthWrap.ChannelElements {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// Describes a delegated authorization between a resource server, a client, and a user.
	/// </summary>
	[ContractClass(typeof(IAuthorizationDescriptionContract))]
	public interface IAuthorizationDescription {
		/// <summary>
		/// Gets the identifier of the client authorized to access protected data.
		/// </summary>
		string ClientIdentifier { get; }

		/// <summary>
		/// Gets the date this authorization was established or the token was issued.
		/// </summary>
		/// <value>A date/time expressed in UTC.</value>
		DateTime UtcIssued { get; }

		/// <summary>
		/// Gets the name on the account whose data on the resource server is accessible using this authorization.
		/// </summary>
		string User { get; }

		/// <summary>
		/// Gets the scope of operations the client is allowed to invoke.
		/// </summary>
		string Scope { get; }
	}

	[ContractClassFor(typeof(IAuthorizationDescription))]
	internal abstract class IAuthorizationDescriptionContract : IAuthorizationDescription {
		private IAuthorizationDescriptionContract() {
		}

		string IAuthorizationDescription.ClientIdentifier {
			get {
				Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));
				throw new NotImplementedException();
			}
		}

		DateTime IAuthorizationDescription.UtcIssued {
			get { throw new NotImplementedException(); }
		}

		string IAuthorizationDescription.User {
			get {
				Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));
				throw new NotImplementedException();
			}
		}

		string IAuthorizationDescription.Scope {
			get { throw new NotImplementedException(); }
		}
	}

}
