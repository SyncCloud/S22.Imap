using System;

namespace S22.Imap {
    public class LocalException : Exception {
        public LocalException(Exception inner) : base("Service logic exception", inner) {
        }
    }
}