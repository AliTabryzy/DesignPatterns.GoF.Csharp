using System;
using System.Collections.Generic;
using GoF.Behavioural_Patterns.Memento;
using NUnit.Framework;

namespace test.GoF.Behavioural_Patterns.Memento
{
    [TestFixture]
    public class CareTaker
    {
        [Test]
        public void Test()
        {
            var savedStates = new Stack<global::GoF.Behavioural_Patterns.Memento.Memento>();

            var originator = new Originator();


            Console.WriteLine("Adding states");
            for (var i = 1; i <= 10; i++)
            {
                originator.SetState($"State-{i}");
                Console.WriteLine(originator.State);
                savedStates.Push(originator.SaveState());
            }


            Console.WriteLine("Restoring states");
            while (true)
            {
                savedStates.TryPop(out var memento);
                if (memento == null) break;

                originator.ReStoreState(memento);
                Console.WriteLine(originator.State);
            }
        }
    }
}