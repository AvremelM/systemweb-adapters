// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace System.Web
{
    [SuppressMessage("Design", "CA1065:Do not raise exceptions in unexpected locations", Justification = "Constants.ApiFromAspNet")]
    public abstract class HttpClientCertificateBase
    {
        /// <summary>
        /// Gets a value indicating whether the client certificate is present.
        /// </summary>
        public virtual bool IsPresent => throw new NotImplementedException();

        /// <summary>
        /// Gets the binary issuer field of the certificate.
        /// </summary>
        public virtual byte[] BinaryIssuer => throw new NotImplementedException();

        /// <summary>
        /// Gets the entire certificate in binary format.
        /// </summary>
        public virtual byte[] Certificate => throw new NotImplementedException();

        /// <summary>
        /// Gets the issuer name from the certificate.
        /// </summary>
        public virtual string Issuer => throw new NotImplementedException();

        /// <summary>
        /// Gets the subject name from the certificate.
        /// </summary>
        public virtual string Subject => throw new NotImplementedException();

        /// <summary>
        /// Gets the serial number of the certificate.
        /// </summary>
        public virtual string SerialNumber => throw new NotImplementedException();

        /// <summary>
        /// Gets the date when the certificate becomes valid.
        /// </summary>
        public virtual DateTime ValidFrom => throw new NotImplementedException();

        /// <summary>
        /// Gets the date when the certificate expires.
        /// </summary>
        public virtual DateTime ValidUntil => throw new NotImplementedException();
    }
}
