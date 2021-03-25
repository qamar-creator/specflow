using System;
using NUnit.Framework;

namespace Codemerger_specflow
{
    class Assertions
    {

        public static void assertionequals(string expectedresult, string actualresult)

        {
            Assert.AreEqual(actualresult, expectedresult, "strings are not equal");
        }

        internal static void assertionequals(string expectedresult, string actualresult, string v)
        {
            throw new NotImplementedException();
        }
    }
}
