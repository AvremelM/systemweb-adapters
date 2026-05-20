// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Cryptography.X509Certificates;

namespace System.Web
{
    public class HttpClientCertificate
    {
        private readonly X509Certificate2? _certificate;

        internal HttpClientCertificate(X509Certificate2? certificate)
        {
            _certificate = certificate;
        }

        /// <summary>
        /// Gets a value indicating whether the client certificate is present.
        /// </summary>
        public bool IsPresent => _certificate is not null;

        /// <summary>
        /// Gets the binary issuer field of the certificate.
        /// </summary>
        public byte[] BinaryIssuer => _certificate?.IssuerName.RawData ?? Array.Empty<byte>();

        /// <summary>
        /// Gets the entire certificate in binary format.
        /// </summary>
        public byte[] Certificate => _certificate?.RawData ?? Array.Empty<byte>();

        /// <summary>
        /// Gets the issuer name from the certificate.
        /// </summary>
        public string Issuer => _certificate?.Issuer ?? string.Empty;

        /// <summary>
        /// Gets the subject name from the certificate.
        /// </summary>
        public string Subject => _certificate?.Subject ?? string.Empty;

        /// <summary>
        /// Gets the serial number of the certificate.
        /// </summary>
        public string SerialNumber => _certificate?.SerialNumber ?? string.Empty;

        /// <summary>
        /// Gets the date when the certificate becomes valid.
        /// </summary>
        public DateTime ValidFrom => _certificate?.NotBefore ?? DateTime.MinValue;

        /// <summary>
        /// Gets the date when the certificate expires.
        /// </summary>
        public DateTime ValidUntil => _certificate?.NotAfter ?? DateTime.MinValue;

        /// <summary>
        /// Gets the underlying X509Certificate2 object.
        /// </summary>
        internal X509Certificate2? GetCertificate() => _certificate;
    }
}
