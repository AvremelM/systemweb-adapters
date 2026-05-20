// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Web
{
    public class HttpClientCertificateWrapper : HttpClientCertificateBase
    {
        private readonly HttpClientCertificate _certificate;

        public HttpClientCertificateWrapper(HttpClientCertificate certificate)
        {
            ArgumentNullException.ThrowIfNull(certificate);

            _certificate = certificate;
        }

        public override bool IsPresent => _certificate.IsPresent;

        public override byte[] BinaryIssuer => _certificate.BinaryIssuer;

        public override byte[] Certificate => _certificate.Certificate;

        public override string Issuer => _certificate.Issuer;

        public override string Subject => _certificate.Subject;

        public override string SerialNumber => _certificate.SerialNumber;

        public override DateTime ValidFrom => _certificate.ValidFrom;

        public override DateTime ValidUntil => _certificate.ValidUntil;
    }
}
