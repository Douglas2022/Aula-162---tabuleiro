using System;
using System.Net.Configuration;
using System.Runtime.InteropServices;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg): base(msg)
        {

        }
    }
}
