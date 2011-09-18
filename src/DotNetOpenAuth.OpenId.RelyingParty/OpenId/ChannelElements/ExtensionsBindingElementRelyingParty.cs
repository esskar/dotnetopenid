﻿//-----------------------------------------------------------------------
// <copyright file="ExtensionsBindingElementRelyingParty.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OpenId.ChannelElements {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.OpenId.RelyingParty;

	/// <summary>
	/// The OpenID binding element responsible for reading/writing OpenID extensions
	/// at the Relying Party.
	/// </summary>
	internal class ExtensionsBindingElementRelyingParty : ExtensionsBindingElement {
		/// <summary>
		/// The security settings that apply to this relying party, if it is a relying party.
		/// </summary>
		private readonly RelyingPartySecuritySettings relyingPartySecuritySettings;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtensionsBindingElementRelyingParty"/> class.
		/// </summary>
		/// <param name="extensionFactory">The extension factory.</param>
		/// <param name="securitySettings">The security settings.</param>
		internal ExtensionsBindingElementRelyingParty(IOpenIdExtensionFactory extensionFactory, RelyingPartySecuritySettings securitySettings)
			: base(extensionFactory, securitySettings, !securitySettings.IgnoreUnsignedExtensions) {
			Contract.Requires<ArgumentNullException>(extensionFactory != null);
			Contract.Requires<ArgumentNullException>(securitySettings != null);

			this.relyingPartySecuritySettings = securitySettings;
		}
	}
}