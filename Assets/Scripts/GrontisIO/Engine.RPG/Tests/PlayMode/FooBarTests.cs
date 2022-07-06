using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace GrontisIO.Engine.RPG.Tests.PlayMode
{
    //DEMO TEST CLASS
    
    public class FooBarTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void FooBarTestsSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator FooBarTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
